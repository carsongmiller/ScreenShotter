﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ScreenShotter
{
	public partial class Form1 : Form
	{
		System.Timers.Timer cursorPositionTimer;
		System.Timers.Timer screenCaptureTimer;

		int imageCount = 0;
		string currentSaveDir;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TopMost = true;

			populateRegionOptions();
			cursorPositionTimer = new System.Timers.Timer();
			cursorPositionTimer.Elapsed += CursorPositionTimer_Elapsed;
			cursorPositionTimer.Interval = 50;
			cursorPositionTimer.AutoReset = true;
			cursorPositionTimer.Start();

			screenCaptureTimer = new System.Timers.Timer();
			screenCaptureTimer.Elapsed += ScreenCaptureTimer_Elapsed;

			tbSaveLocation.Text = Directory.GetCurrentDirectory();
			toolTip1.SetToolTip(tbSaveLocation, tbSaveLocation.Text);
		}

		private void ScreenCaptureTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				string filePath = $"{currentSaveDir}\\{imageCount}.jpg";
				TakeScreenshot(filePath);
				imageCount += 1;
			});
		}

		private void CursorPositionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				var mousePos = Cursor.Position;
				lblCurrentCursor_X.Text = mousePos.X.ToString();
				lblCurrentCursor_Y.Text = mousePos.Y.ToString();
			});
		}

		private void populateRegionOptions()
		{
			cmbRegionToCapture.Items.Clear();

			//Populate the selected area box
			cmbRegionToCapture.Items.Add("Whole Display");

			for (int i = 1; i <= Screen.AllScreens.Count(); i++)
			{
				cmbRegionToCapture.Items.Add($"Monitor {i}");
			}
			cmbRegionToCapture.Items.Add("Specified Area");
		}

		private void btnSaveLocationBrowse_Click(object sender, EventArgs e)
		{

			if (System.IO.Directory.Exists(tbSaveLocation.Text))
			{
				folderBrowserDialog1.SelectedPath = tbSaveLocation.Text;
			}

			folderBrowserDialog1.ShowNewFolderButton = true;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbSaveLocation.Text = folderBrowserDialog1.SelectedPath;
				toolTip1.SetToolTip(tbSaveLocation, tbSaveLocation.Text);
			}
		}

		private void cmbSelectedArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			grpSelectedArea.Enabled = cmbRegionToCapture.SelectedItem.ToString() == "Specified Area";
			btnStart.Enabled = cmbRegionToCapture.SelectedIndex >= 0;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//Create new directory based on current date and time
			string newDirName = DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
			currentSaveDir = $"{tbSaveLocation.Text}\\{newDirName}";
			
			if (!Directory.Exists(currentSaveDir))
			{
				Directory.CreateDirectory(currentSaveDir);
			}

			imageCount = 0;

			screenCaptureTimer.Interval = (double)nudInterval.Value * 60000;
			screenCaptureTimer.AutoReset = true;
			screenCaptureTimer.Start();

			btnStop.Enabled = true;
			btnStart.Enabled = false;
			grpBasicSettings.Enabled = false;
			grpSelectedArea.Enabled = false;
		}

		private void CaptureMonitor(int monitorIndex, string saveFilePath)
		{
			var bounds = Screen.AllScreens[monitorIndex].Bounds;
			CaptureArea(bounds, saveFilePath);
		}

		private void CaptureWholeDisplay(string saveFilePath)
		{
			//Get the limits in all 4 directions of monitors
			int left = 0;
			int top = 0;
			int right = 0;
			int bottom = 0;

			foreach (var screen in Screen.AllScreens)
			{
				left =	screen.Bounds.Left < left ? screen.Bounds.Left : left;
				right = screen.Bounds.Right > right ? screen.Bounds.Right : right;
				top = screen.Bounds.Top < top ? screen.Bounds.Top : top;
				bottom = screen.Bounds.Bottom > bottom ? screen.Bounds.Bottom : bottom;
			}

			Rectangle bounds = new Rectangle(left, top, right - left, bottom - top);

			CaptureArea(bounds, saveFilePath);
		}

		private void CaptureArea(Rectangle bounds, string saveFilePath)
		{
			try
			{
				Bitmap captureBitmap = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
				Rectangle captureRectangle = bounds;
				Graphics captureGraphics = Graphics.FromImage(captureBitmap);
				captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
				captureBitmap.Save(saveFilePath, ImageFormat.Jpeg);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error capturing screen:\n\n{ex.Message}");
			}
		}

		private void btnSaveLocationOpen_Click(object sender, EventArgs e)
		{


			if (Directory.Exists(tbSaveLocation.Text))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					Arguments = tbSaveLocation.Text,
					FileName = "explorer.exe"
				};

				Process.Start(startInfo);
			}
			else
			{
				MessageBox.Show(string.Format("{0} Directory does not exist!", tbSaveLocation.Text));
			}
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			string path = $"{tbSaveLocation.Text}\\test.jpg";
			if (TakeScreenshot(path))
			{
				Process.Start(path);
			}
		}

		private bool TakeScreenshot(string saveFilePath)
		{
			if (cmbRegionToCapture.SelectedIndex < 0)
			{
				return false;
			}
				
			var selectedText = cmbRegionToCapture.SelectedItem.ToString();

			if (selectedText == "")
			{
				MessageBox.Show("No region type selected");
				return false;
			}

			else if (selectedText == "Whole Display")
			{
				CaptureWholeDisplay(saveFilePath);
				return true;
			}

			else if (selectedText.Substring(0, 7) == "Monitor")
			{
				var monitor = Convert.ToInt32(selectedText.Substring(selectedText.Length - 2)) - 1;
				CaptureMonitor(monitor, saveFilePath);
				return true;
			}

			else if (selectedText == "Specified Area")
			{
				int left = (int)nudSelectedAreaUpperLeft_X.Value;
				int top = (int)nudSelectedAreaUpperLeft_Y.Value;
				int right = (int)nudSelectedAreaLowerRight_X.Value;
				int bottom = (int)nudSelectedAreaLowerRight_Y.Value;

				var bounds = new Rectangle(left, top, right - left, bottom - top);
				CaptureArea(bounds, saveFilePath);
				return true;
			}
			else
			{
				return false;
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			screenCaptureTimer.Stop();

			btnStart.Enabled = true;
			btnStop.Enabled = false;
			grpBasicSettings.Enabled = true;
			grpSelectedArea.Enabled = cmbRegionToCapture.SelectedItem.ToString() == "Specified Area";
		}
	}
}