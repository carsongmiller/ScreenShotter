using System;
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
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;

namespace ScreenShotter
{
	public partial class Form1 : Form
	{
		System.Timers.Timer cursorPositionTimer;
		System.Timers.Timer screenCaptureTimer;

		System.Timers.Timer updateUITimer;

		Stopwatch progressStopwatch;

		int imageCount = 0;
		string currentSaveDir;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			populateRegionOptions();

			cursorPositionTimer = new System.Timers.Timer();
			cursorPositionTimer.Elapsed += CursorPositionTimer_Elapsed;
			cursorPositionTimer.Interval = 50;
			cursorPositionTimer.AutoReset = true;
			cursorPositionTimer.Start();

			updateUITimer = new System.Timers.Timer();
			updateUITimer.Elapsed += UpdateUITimer_Elapsed;
			updateUITimer.Interval = 50;
			updateUITimer.AutoReset = true;
			updateUITimer.Start();

			screenCaptureTimer = new System.Timers.Timer();
			screenCaptureTimer.Elapsed += ScreenCaptureTimer_Elapsed;

			tbSaveLocation.Text = Directory.GetCurrentDirectory();
			toolTip1.SetToolTip(tbSaveLocation, tbSaveLocation.Text);

			cmbRegionToCapture.SelectedIndex = 0;
			cmbImageFormat.SelectedIndex = 0;
		}

		private void StartScreenshotTimer(double interval)
		{
			screenCaptureTimer.Interval = interval;
			screenCaptureTimer.AutoReset = true;
			screenCaptureTimer.Start();

			progressStopwatch = new Stopwatch();
			progressStopwatch.Start();
		}

		private void UpdateUITimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				//if the screenshot timer is running, update a progress bar showing how long until the next picture
				if (screenCaptureTimer.Enabled)
				{
					var max = (int)(screenCaptureTimer.Interval + 0.5);
					var current = (int)(progressStopwatch.ElapsedMilliseconds + 0.5);
					current = current <= max ? current : max;
					var difference = max - current;

					var difference_seconds = (int)(((double)difference / 1000) + 0.5);
					int hours = (int)(difference_seconds / 3600);
					int minutes = (int)((difference_seconds - (hours * 3600)) / 60);
					int seconds = difference_seconds - (hours * 3600) - (minutes * 60);
					string time = $"({hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")})";

					lblTimeRemaining.Text = time;

					progNextScreenshot.Maximum = max;
					progNextScreenshot.Value = current;
				}
			});
		}

		private void ScreenCaptureTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			BeginInvoke((Action)delegate
			{
				TakeOfficialScreenshot();
				progressStopwatch.Restart();
			});
		}

		private void TakeOfficialScreenshot()
		{
			string filePath = $"{currentSaveDir}\\{imageCount}{GetImageExtension()}";
			TakeScreenshot(filePath, GetImageFormat());
			imageCount += 1;
		}

		private string GetImageExtension()
		{
			switch (cmbImageFormat.Text)
			{
				case "JPG":
					return ".jpg";
				case "PNG":
					return ".png";
				case "BMP":
					return ".bmp";
				case "TIFF":
					return ".tiff";
				case "GIF":
					return ".gif";
				default:
					return ".jpg";
			}
		}

		private ImageFormat GetImageFormat()
		{
			switch (cmbImageFormat.Text)
			{
				case "JPG":
					return ImageFormat.Jpeg;
				case "PNG":
					return ImageFormat.Png;
				case "BMP":
					return ImageFormat.Bmp;
				case "TIFF":
					return ImageFormat.Tiff;
				case "GIF":
					return ImageFormat.Gif;
				default:
					return ImageFormat.Jpeg;
			}
		}

		private void CursorPositionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			try
			{
				BeginInvoke((Action)delegate
				{
					var mousePos = Cursor.Position;
					lblCurrentCursor_X.Text = mousePos.X.ToString();
					lblCurrentCursor_Y.Text = mousePos.Y.ToString();
				});
			}
			catch { }
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
			btnTest.Enabled = cmbRegionToCapture.SelectedIndex >= 0;
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

			StartScreenshotTimer((double)nudInterval.Value * 60000);

			btnStop.Enabled = true;
			btnStart.Enabled = false;
			btnOpenCurrentFolder.Enabled = true;
			btnManualScreenshot.Enabled = true;
			btnTest.Enabled = false;
			grpBasicSettings.Enabled = false;
			grpSelectedArea.Enabled = false;

			lblProgressBar.Enabled = true;
			progNextScreenshot.Enabled = true;
			lblTimeRemaining.Enabled = true;
		}

		private void CaptureMonitor(int monitorIndex, string saveFilePath, ImageFormat format)
		{
			var bounds = Screen.AllScreens[monitorIndex].Bounds;
			CaptureArea(bounds, saveFilePath, format);
		}

		private void CaptureWholeDisplay(string saveFilePath, ImageFormat format)
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

			CaptureArea(bounds, saveFilePath, format);
		}

		private void CaptureArea(Rectangle bounds, string saveFilePath, ImageFormat format)
		{
			try
			{
				//Capture the correct area into a bitmap object
				Bitmap captureBitmap = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
				Rectangle captureRectangle = bounds;
				Graphics captureGraphics = Graphics.FromImage(captureBitmap);
				captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

				//Specify image quality
				ImageCodecInfo formatSpecificEncoder = GetEncoder(format);
				System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
				EncoderParameters myEncoderParameters = new EncoderParameters(1);
				EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L); //Always take at the highest qualitiy
				myEncoderParameters.Param[0] = myEncoderParameter;

				if (cbOverlayTimestamp.Checked)
				{
					WriteTimestampToBMP(captureBitmap);
				}

				//Save the image
				captureBitmap.Save(saveFilePath, formatSpecificEncoder, myEncoderParameters);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error capturing screen:\n\n{ex.Message}");
			}
		}

		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

			foreach (ImageCodecInfo codec in codecs)
			{
				if (codec.FormatID == format.Guid)
				{
					return codec;
				}
			}

			return null;
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
			string path = $"{tbSaveLocation.Text}\\test{GetImageExtension()}";
			if (TakeScreenshot(path, GetImageFormat()))
			{
				Process.Start(path);
			}
		}

		private bool TakeScreenshot(string saveFilePath, ImageFormat format)
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
				CaptureWholeDisplay(saveFilePath, format);
				return true;
			}

			else if (selectedText.Substring(0, 7) == "Monitor")
			{
				var monitor = Convert.ToInt32(selectedText.Substring(selectedText.Length - 2)) - 1;
				CaptureMonitor(monitor, saveFilePath, format);
				return true;
			}

			else if (selectedText == "Specified Area")
			{
				int left = (int)nudSelectedAreaUpperLeft_X.Value;
				int top = (int)nudSelectedAreaUpperLeft_Y.Value;
				int right = (int)nudSelectedAreaLowerRight_X.Value;
				int bottom = (int)nudSelectedAreaLowerRight_Y.Value;

				var bounds = new Rectangle(left, top, right - left, bottom - top);
				CaptureArea(bounds, saveFilePath, format);
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
			btnOpenCurrentFolder.Enabled = false;
			btnManualScreenshot.Enabled = false;
			btnTest.Enabled = true;
			grpBasicSettings.Enabled = true;
			grpSelectedArea.Enabled = cmbRegionToCapture.SelectedItem.ToString() == "Specified Area";

			progressStopwatch.Stop();
			progNextScreenshot.Value = 0;
			lblTimeRemaining.Text = "(00:00:00)";

			lblProgressBar.Enabled = false;
			progNextScreenshot.Enabled = false;
			lblTimeRemaining.Enabled = false;

			currentSaveDir = "";
		}

		private void btnManualScreenshot_Click(object sender, EventArgs e)
		{
			TakeOfficialScreenshot();
		}

		private void btnOpenCurrentFolder_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(currentSaveDir))
			{
				Process.Start(currentSaveDir);
			}
			else
			{
				MessageBox.Show($"Directory does not exist:\n\n{currentSaveDir}");
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mergeFoldersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var mergeForm = new frmMergeFolders();
			mergeForm.Show();
		}

		private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var menuItem = (ToolStripMenuItem)sender;
			menuItem.Checked = !menuItem.Checked;
			TopMost = menuItem.Checked;
		}

		private Bitmap WriteTimestampToBMP(Bitmap bmp)
		{
			//Draw rectangle in bottom right
			int width = 250;
			int height = 20;
			RectangleF rectf = new RectangleF(bmp.Width - width, bmp.Height - height, width, 20);
			var reg = new Region(rectf);

			Graphics g = Graphics.FromImage(bmp);

			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			g.PixelOffsetMode = PixelOffsetMode.HighQuality;
			g.FillRegion(Brushes.White, reg);
			g.DrawString(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss (UTCzz)"), new Font("Tahoma", 12), Brushes.Black, rectf);

			g.Flush();

			return bmp;
		}

		private Bitmap WriteTimestampToBMP(Bitmap bmp, DateTime timestamp)
		{
			//Draw rectangle in bottom right
			int width = 250;
			int height = 20;
			RectangleF rectf = new RectangleF(bmp.Width - width, bmp.Height - height, width, 20);
			var reg = new Region(rectf);

			Graphics g = Graphics.FromImage(bmp);

			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			g.PixelOffsetMode = PixelOffsetMode.HighQuality;
			g.FillRegion(Brushes.White, reg);
			g.DrawString(timestamp.ToString("MM/dd/yyyy HH:mm:ss (UTCzz)"), new Font("Tahoma", 12), Brushes.Black, rectf);

			g.Flush();

			return bmp;
		}
	}
}
