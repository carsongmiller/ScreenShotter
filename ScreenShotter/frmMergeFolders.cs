using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ScreenShotter
{
	public partial class frmMergeFolders : Form
	{
		public frmMergeFolders()
		{
			InitializeComponent();
			folderBrowserDialog_Add.SelectedPath = Directory.GetCurrentDirectory();
			folderBrowserDialog_Add.ShowNewFolderButton = false;

			folderBrowserDialog_Output.SelectedPath = Directory.GetCurrentDirectory();
			folderBrowserDialog_Add.ShowNewFolderButton = true;

			tbFolderToAdd.Text = Directory.GetCurrentDirectory();
			tbOutputFolder.Text = Directory.GetCurrentDirectory();
		}

		private void btnBrowseFolderToAdd_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog_Add.ShowDialog() == DialogResult.OK)
			{
				tbFolderToAdd.Text = folderBrowserDialog_Add.SelectedPath;
			}
		}

		private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
		{
			folderBrowserDialog_Output.ShowNewFolderButton = true;
			if (folderBrowserDialog_Output.ShowDialog() == DialogResult.OK)
			{
				tbOutputFolder.Text = folderBrowserDialog_Output.SelectedPath;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(tbFolderToAdd.Text))
			{
				AddFolder(tbFolderToAdd.Text, GetSelectedFormat());
			}
			else
			{
				MessageBox.Show($"Directory is not valid:\n\n{tbFolderToAdd.Text}");
			}
		}

		private ImageFormat GetSelectedFormat()
		{
			if (radAll.Checked)
			{
				return ImageFormat.All;
			}
			else if (radJPG.Checked)
			{
				return ImageFormat.JPG;
			}
			else if (radPNG.Checked)
			{
				return ImageFormat.PNG;
			}
			else if (radBMP.Checked)
			{
				return ImageFormat.BMP;
			}
			else if (radTIFF.Checked)
			{
				return ImageFormat.TIFF;
			}
			else if (radGIF.Checked)
			{
				return ImageFormat.GIF;
			}
			else
			{
				return ImageFormat.All;
			}
		}

		private enum ImageFormat
		{
			All = 0,
			JPG,
			PNG,
			BMP,
			TIFF,
			GIF
		}

		private void AddFolder(string dir, ImageFormat format)
		{
			//Check if folder already is added
			foreach (DataGridViewRow existingRow in dgvAddedFolders.Rows)
			{
				string path = (string)existingRow.Cells[0].Value;
				if (path == dir)
				{
					string title = "Folder Not Added";
					string caption = $"Did not add folder--folder has already been added:\n\n{dir}";
					MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			var newRow = new DataGridViewRow();
			var cellPath = new DataGridViewTextBoxCell();
			var cellFileCount = new DataGridViewTextBoxCell();

			int fileCount = CountFiles(dir, format);
			cellPath.Value = dir;
			cellFileCount.Value = fileCount;

			newRow.Cells.Add(cellPath);
			newRow.Cells.Add(cellFileCount);
			dgvAddedFolders.Rows.Add(newRow);
		}

		private int CountFiles(string dir, ImageFormat format)
		{
			var contents = Directory.GetFiles(dir);
			int fileCount = 0;
			foreach (var file in contents)
			{
				if ((format == ImageFormat.All || format == ImageFormat.JPG) && Path.GetExtension(file).ToLower() == ".jpg")
				{
					fileCount += 1;
				}
				else if ((format == ImageFormat.All || format == ImageFormat.PNG) && Path.GetExtension(file).ToLower() == ".png")
				{
					fileCount += 1;
				}
				else if ((format == ImageFormat.All || format == ImageFormat.BMP) && Path.GetExtension(file).ToLower() == ".bmp")
				{
					fileCount += 1;
				}
				else if ((format == ImageFormat.All || format == ImageFormat.TIFF) && Path.GetExtension(file).ToLower() == ".tiff")
				{
					fileCount += 1;
				}
				else if ((format == ImageFormat.All || format == ImageFormat.GIF) && Path.GetExtension(file).ToLower() == ".gif")
				{
					fileCount += 1;
				}
			}
			return fileCount;
		}

		private void btnMerge_Click(object sender, EventArgs e)
		{
			//Ensure that output directory is valid
			var outputDir = tbOutputFolder.Text;
			if (!Directory.Exists(outputDir))
			{
				try
				{
					Directory.CreateDirectory(outputDir);
				}
				catch (Exception ex)
				{
					string title = "Folders Not Merged";
					string caption = $"Folders were not merged.  Output directory does not exist, and an error occurred when attempting to create:\n\n{ex.Message}";
					MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (Directory.GetFiles(outputDir).Count() > 0)
			{
				string title = "Output Directory Not Empty";
				string caption = $"Output directory is not empty. Continue attempting to copy files?";
				if (MessageBox.Show(caption, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				{
					return;
				}
			}

			//Directory exists now
			//For each folder added, for each file in those folders, if it's the correct filetype,
			//add to a list which we'll sort by date, then copy

			var filesToCopy = new List<FileInfo>();
			var format = GetSelectedFormat();

			foreach (DataGridViewRow row in dgvAddedFolders.Rows)
			{
				string path = (string)row.Cells[0].Value;
				var files = Directory.GetFiles(path);
				foreach (var file in files)
				{
					filesToCopy.Add(new FileInfo(file));
				}
			}
			// sort the list of files by creation date
			filesToCopy = filesToCopy.OrderBy(x => x.CreationTime).ToList();

			int number = (int)nudStartNumbering.Value;
			// copy the files
			foreach (var file in filesToCopy)
			{
				try
				{
					file.CopyTo($"{outputDir}\\{number}{file.Extension}");
				}
				catch (Exception ex)
				{
					string title = "Error copying file";
					string caption = $"Error copying file:\n\n{file.FullName}\n\n{ex.Message}\n\nContinue attempting to copy remaining files?";
					if (MessageBox.Show(caption, title, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
					{
						return;
					}
				}
				
				number++;
			}
		}

		private void RecountFiles(ImageFormat format)
		{
			foreach (DataGridViewRow row in dgvAddedFolders.Rows)
			{
				var dir = (string)row.Cells[0].Value;
				row.Cells[1].Value = CountFiles(dir, format);
			}
		}

		private void radAll_CheckedChanged(object sender, EventArgs e)
		{
			if (radAll.Checked)
			{
				RecountFiles(ImageFormat.All);
			}
		}

		private void radJPG_CheckedChanged(object sender, EventArgs e)
		{
			if (radJPG.Checked)
			{
				RecountFiles(ImageFormat.JPG);
			}
		}

		private void radPNG_CheckedChanged(object sender, EventArgs e)
		{
			if (radPNG.Checked)
			{
				RecountFiles(ImageFormat.PNG);
			}
		}

		private void radBMP_CheckedChanged(object sender, EventArgs e)
		{
			if (radBMP.Checked)
			{
				RecountFiles(ImageFormat.BMP);
			}
		}

		private void radTIFF_CheckedChanged(object sender, EventArgs e)
		{
			if (radTIFF.Checked)
			{
				RecountFiles(ImageFormat.TIFF);
			}
		}

		private void radGIF_CheckedChanged(object sender, EventArgs e)
		{
			if (radGIF.Checked)
			{
				RecountFiles(ImageFormat.GIF);
			}
		}
	}
}
