﻿namespace ScreenShotter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.nudInterval = new System.Windows.Forms.NumericUpDown();
			this.lblInterval = new System.Windows.Forms.Label();
			this.lblSaveLocation = new System.Windows.Forms.Label();
			this.tbSaveLocation = new System.Windows.Forms.TextBox();
			this.btnSaveLocationBrowse = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnTest = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblRegionToCapture = new System.Windows.Forms.Label();
			this.cmbRegionToCapture = new System.Windows.Forms.ComboBox();
			this.nudSelectedAreaUpperLeft_X = new System.Windows.Forms.NumericUpDown();
			this.lblSelectedAreaUpperLeft_X = new System.Windows.Forms.Label();
			this.grpSelectedArea = new System.Windows.Forms.GroupBox();
			this.lblLowerRight = new System.Windows.Forms.Label();
			this.lblSelectedAreaLowerRight_Y = new System.Windows.Forms.Label();
			this.nudSelectedAreaLowerRight_Y = new System.Windows.Forms.NumericUpDown();
			this.lblSelectedAreaLowerRight_X = new System.Windows.Forms.Label();
			this.nudSelectedAreaLowerRight_X = new System.Windows.Forms.NumericUpDown();
			this.lblUpperLeft = new System.Windows.Forms.Label();
			this.lblSelectedAreaUpperLeft_Y = new System.Windows.Forms.Label();
			this.nudSelectedAreaUpperLeft_Y = new System.Windows.Forms.NumericUpDown();
			this.lblCurrentCursor_Xlabel = new System.Windows.Forms.Label();
			this.lblCurrentCursor_X = new System.Windows.Forms.Label();
			this.lblCurrentCursor_Y = new System.Windows.Forms.Label();
			this.lblCurrentCursor_Ylabel = new System.Windows.Forms.Label();
			this.btnSaveLocationOpen = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.grpBasicSettings = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaUpperLeft_X)).BeginInit();
			this.grpSelectedArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaLowerRight_Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaLowerRight_X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaUpperLeft_Y)).BeginInit();
			this.grpBasicSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudInterval
			// 
			this.nudInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudInterval.DecimalPlaces = 1;
			this.nudInterval.Location = new System.Drawing.Point(132, 19);
			this.nudInterval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudInterval.Name = "nudInterval";
			this.nudInterval.Size = new System.Drawing.Size(248, 20);
			this.nudInterval.TabIndex = 0;
			this.nudInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// lblInterval
			// 
			this.lblInterval.AutoSize = true;
			this.lblInterval.Location = new System.Drawing.Point(13, 21);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(87, 13);
			this.lblInterval.TabIndex = 1;
			this.lblInterval.Text = "Interval (minutes)";
			// 
			// lblSaveLocation
			// 
			this.lblSaveLocation.AutoSize = true;
			this.lblSaveLocation.Location = new System.Drawing.Point(13, 48);
			this.lblSaveLocation.Name = "lblSaveLocation";
			this.lblSaveLocation.Size = new System.Drawing.Size(108, 13);
			this.lblSaveLocation.TabIndex = 2;
			this.lblSaveLocation.Text = "Image Save Location";
			// 
			// tbSaveLocation
			// 
			this.tbSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSaveLocation.Location = new System.Drawing.Point(132, 45);
			this.tbSaveLocation.Name = "tbSaveLocation";
			this.tbSaveLocation.Size = new System.Drawing.Size(248, 20);
			this.tbSaveLocation.TabIndex = 1;
			this.tbSaveLocation.Text = "C:\\";
			// 
			// btnSaveLocationBrowse
			// 
			this.btnSaveLocationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveLocationBrowse.Location = new System.Drawing.Point(386, 44);
			this.btnSaveLocationBrowse.Name = "btnSaveLocationBrowse";
			this.btnSaveLocationBrowse.Size = new System.Drawing.Size(57, 22);
			this.btnSaveLocationBrowse.TabIndex = 2;
			this.btnSaveLocationBrowse.Text = "Browse";
			this.btnSaveLocationBrowse.UseVisualStyleBackColor = true;
			this.btnSaveLocationBrowse.Click += new System.EventHandler(this.btnSaveLocationBrowse_Click);
			// 
			// btnTest
			// 
			this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTest.Location = new System.Drawing.Point(205, 213);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 26;
			this.btnTest.Text = "Test";
			this.toolTip1.SetToolTip(this.btnTest, "Capture an image with the current settings to make sure they\'re ok");
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(12, 213);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 9;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblRegionToCapture
			// 
			this.lblRegionToCapture.AutoSize = true;
			this.lblRegionToCapture.Location = new System.Drawing.Point(13, 74);
			this.lblRegionToCapture.Name = "lblRegionToCapture";
			this.lblRegionToCapture.Size = new System.Drawing.Size(93, 13);
			this.lblRegionToCapture.TabIndex = 6;
			this.lblRegionToCapture.Text = "Region to Capture";
			// 
			// cmbRegionToCapture
			// 
			this.cmbRegionToCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbRegionToCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRegionToCapture.FormattingEnabled = true;
			this.cmbRegionToCapture.Location = new System.Drawing.Point(132, 71);
			this.cmbRegionToCapture.Name = "cmbRegionToCapture";
			this.cmbRegionToCapture.Size = new System.Drawing.Size(248, 21);
			this.cmbRegionToCapture.TabIndex = 3;
			this.cmbRegionToCapture.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedArea_SelectedIndexChanged);
			// 
			// nudSelectedAreaUpperLeft_X
			// 
			this.nudSelectedAreaUpperLeft_X.Location = new System.Drawing.Point(104, 19);
			this.nudSelectedAreaUpperLeft_X.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudSelectedAreaUpperLeft_X.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
			this.nudSelectedAreaUpperLeft_X.Name = "nudSelectedAreaUpperLeft_X";
			this.nudSelectedAreaUpperLeft_X.Size = new System.Drawing.Size(63, 20);
			this.nudSelectedAreaUpperLeft_X.TabIndex = 5;
			// 
			// lblSelectedAreaUpperLeft_X
			// 
			this.lblSelectedAreaUpperLeft_X.AutoSize = true;
			this.lblSelectedAreaUpperLeft_X.Location = new System.Drawing.Point(84, 21);
			this.lblSelectedAreaUpperLeft_X.Name = "lblSelectedAreaUpperLeft_X";
			this.lblSelectedAreaUpperLeft_X.Size = new System.Drawing.Size(14, 13);
			this.lblSelectedAreaUpperLeft_X.TabIndex = 9;
			this.lblSelectedAreaUpperLeft_X.Text = "X";
			this.lblSelectedAreaUpperLeft_X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpSelectedArea
			// 
			this.grpSelectedArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpSelectedArea.Controls.Add(this.lblLowerRight);
			this.grpSelectedArea.Controls.Add(this.lblSelectedAreaLowerRight_Y);
			this.grpSelectedArea.Controls.Add(this.nudSelectedAreaLowerRight_Y);
			this.grpSelectedArea.Controls.Add(this.lblSelectedAreaLowerRight_X);
			this.grpSelectedArea.Controls.Add(this.nudSelectedAreaLowerRight_X);
			this.grpSelectedArea.Controls.Add(this.lblUpperLeft);
			this.grpSelectedArea.Controls.Add(this.lblSelectedAreaUpperLeft_Y);
			this.grpSelectedArea.Controls.Add(this.nudSelectedAreaUpperLeft_Y);
			this.grpSelectedArea.Controls.Add(this.lblSelectedAreaUpperLeft_X);
			this.grpSelectedArea.Controls.Add(this.nudSelectedAreaUpperLeft_X);
			this.grpSelectedArea.Enabled = false;
			this.grpSelectedArea.Location = new System.Drawing.Point(12, 119);
			this.grpSelectedArea.Name = "grpSelectedArea";
			this.grpSelectedArea.Size = new System.Drawing.Size(512, 78);
			this.grpSelectedArea.TabIndex = 4;
			this.grpSelectedArea.TabStop = false;
			this.grpSelectedArea.Text = "Selected Area";
			// 
			// lblLowerRight
			// 
			this.lblLowerRight.AutoSize = true;
			this.lblLowerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLowerRight.Location = new System.Drawing.Point(8, 47);
			this.lblLowerRight.Name = "lblLowerRight";
			this.lblLowerRight.Size = new System.Drawing.Size(75, 13);
			this.lblLowerRight.TabIndex = 19;
			this.lblLowerRight.Text = "Lower Right";
			this.lblLowerRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSelectedAreaLowerRight_Y
			// 
			this.lblSelectedAreaLowerRight_Y.AutoSize = true;
			this.lblSelectedAreaLowerRight_Y.Location = new System.Drawing.Point(173, 47);
			this.lblSelectedAreaLowerRight_Y.Name = "lblSelectedAreaLowerRight_Y";
			this.lblSelectedAreaLowerRight_Y.Size = new System.Drawing.Size(14, 13);
			this.lblSelectedAreaLowerRight_Y.TabIndex = 18;
			this.lblSelectedAreaLowerRight_Y.Text = "Y";
			this.lblSelectedAreaLowerRight_Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nudSelectedAreaLowerRight_Y
			// 
			this.nudSelectedAreaLowerRight_Y.Location = new System.Drawing.Point(193, 45);
			this.nudSelectedAreaLowerRight_Y.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudSelectedAreaLowerRight_Y.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
			this.nudSelectedAreaLowerRight_Y.Name = "nudSelectedAreaLowerRight_Y";
			this.nudSelectedAreaLowerRight_Y.Size = new System.Drawing.Size(63, 20);
			this.nudSelectedAreaLowerRight_Y.TabIndex = 8;
			this.nudSelectedAreaLowerRight_Y.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// lblSelectedAreaLowerRight_X
			// 
			this.lblSelectedAreaLowerRight_X.AutoSize = true;
			this.lblSelectedAreaLowerRight_X.Location = new System.Drawing.Point(84, 47);
			this.lblSelectedAreaLowerRight_X.Name = "lblSelectedAreaLowerRight_X";
			this.lblSelectedAreaLowerRight_X.Size = new System.Drawing.Size(14, 13);
			this.lblSelectedAreaLowerRight_X.TabIndex = 16;
			this.lblSelectedAreaLowerRight_X.Text = "X";
			this.lblSelectedAreaLowerRight_X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nudSelectedAreaLowerRight_X
			// 
			this.nudSelectedAreaLowerRight_X.Location = new System.Drawing.Point(104, 45);
			this.nudSelectedAreaLowerRight_X.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudSelectedAreaLowerRight_X.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
			this.nudSelectedAreaLowerRight_X.Name = "nudSelectedAreaLowerRight_X";
			this.nudSelectedAreaLowerRight_X.Size = new System.Drawing.Size(63, 20);
			this.nudSelectedAreaLowerRight_X.TabIndex = 7;
			this.nudSelectedAreaLowerRight_X.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// lblUpperLeft
			// 
			this.lblUpperLeft.AutoSize = true;
			this.lblUpperLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUpperLeft.Location = new System.Drawing.Point(8, 21);
			this.lblUpperLeft.Name = "lblUpperLeft";
			this.lblUpperLeft.Size = new System.Drawing.Size(67, 13);
			this.lblUpperLeft.TabIndex = 14;
			this.lblUpperLeft.Text = "Upper Left";
			this.lblUpperLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSelectedAreaUpperLeft_Y
			// 
			this.lblSelectedAreaUpperLeft_Y.AutoSize = true;
			this.lblSelectedAreaUpperLeft_Y.Location = new System.Drawing.Point(173, 21);
			this.lblSelectedAreaUpperLeft_Y.Name = "lblSelectedAreaUpperLeft_Y";
			this.lblSelectedAreaUpperLeft_Y.Size = new System.Drawing.Size(14, 13);
			this.lblSelectedAreaUpperLeft_Y.TabIndex = 11;
			this.lblSelectedAreaUpperLeft_Y.Text = "Y";
			this.lblSelectedAreaUpperLeft_Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nudSelectedAreaUpperLeft_Y
			// 
			this.nudSelectedAreaUpperLeft_Y.Location = new System.Drawing.Point(193, 19);
			this.nudSelectedAreaUpperLeft_Y.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudSelectedAreaUpperLeft_Y.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
			this.nudSelectedAreaUpperLeft_Y.Name = "nudSelectedAreaUpperLeft_Y";
			this.nudSelectedAreaUpperLeft_Y.Size = new System.Drawing.Size(63, 20);
			this.nudSelectedAreaUpperLeft_Y.TabIndex = 6;
			// 
			// lblCurrentCursor_Xlabel
			// 
			this.lblCurrentCursor_Xlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentCursor_Xlabel.AutoSize = true;
			this.lblCurrentCursor_Xlabel.Location = new System.Drawing.Point(482, 213);
			this.lblCurrentCursor_Xlabel.Name = "lblCurrentCursor_Xlabel";
			this.lblCurrentCursor_Xlabel.Size = new System.Drawing.Size(17, 13);
			this.lblCurrentCursor_Xlabel.TabIndex = 21;
			this.lblCurrentCursor_Xlabel.Text = "X:";
			this.lblCurrentCursor_Xlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCurrentCursor_X
			// 
			this.lblCurrentCursor_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentCursor_X.AutoSize = true;
			this.lblCurrentCursor_X.Location = new System.Drawing.Point(494, 213);
			this.lblCurrentCursor_X.Name = "lblCurrentCursor_X";
			this.lblCurrentCursor_X.Size = new System.Drawing.Size(31, 13);
			this.lblCurrentCursor_X.TabIndex = 22;
			this.lblCurrentCursor_X.Text = "1000";
			this.lblCurrentCursor_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCurrentCursor_Y
			// 
			this.lblCurrentCursor_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentCursor_Y.AutoSize = true;
			this.lblCurrentCursor_Y.Location = new System.Drawing.Point(494, 228);
			this.lblCurrentCursor_Y.Name = "lblCurrentCursor_Y";
			this.lblCurrentCursor_Y.Size = new System.Drawing.Size(31, 13);
			this.lblCurrentCursor_Y.TabIndex = 24;
			this.lblCurrentCursor_Y.Text = "1000";
			this.lblCurrentCursor_Y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCurrentCursor_Ylabel
			// 
			this.lblCurrentCursor_Ylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentCursor_Ylabel.AutoSize = true;
			this.lblCurrentCursor_Ylabel.Location = new System.Drawing.Point(482, 228);
			this.lblCurrentCursor_Ylabel.Name = "lblCurrentCursor_Ylabel";
			this.lblCurrentCursor_Ylabel.Size = new System.Drawing.Size(17, 13);
			this.lblCurrentCursor_Ylabel.TabIndex = 23;
			this.lblCurrentCursor_Ylabel.Text = "Y:";
			this.lblCurrentCursor_Ylabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSaveLocationOpen
			// 
			this.btnSaveLocationOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveLocationOpen.Location = new System.Drawing.Point(449, 44);
			this.btnSaveLocationOpen.Name = "btnSaveLocationOpen";
			this.btnSaveLocationOpen.Size = new System.Drawing.Size(57, 22);
			this.btnSaveLocationOpen.TabIndex = 25;
			this.btnSaveLocationOpen.Text = "Open";
			this.btnSaveLocationOpen.UseVisualStyleBackColor = true;
			this.btnSaveLocationOpen.Click += new System.EventHandler(this.btnSaveLocationOpen_Click);
			// 
			// btnStop
			// 
			this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(93, 213);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 27;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// grpBasicSettings
			// 
			this.grpBasicSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpBasicSettings.Controls.Add(this.nudInterval);
			this.grpBasicSettings.Controls.Add(this.lblInterval);
			this.grpBasicSettings.Controls.Add(this.lblSaveLocation);
			this.grpBasicSettings.Controls.Add(this.btnSaveLocationOpen);
			this.grpBasicSettings.Controls.Add(this.tbSaveLocation);
			this.grpBasicSettings.Controls.Add(this.btnSaveLocationBrowse);
			this.grpBasicSettings.Controls.Add(this.lblRegionToCapture);
			this.grpBasicSettings.Controls.Add(this.cmbRegionToCapture);
			this.grpBasicSettings.Location = new System.Drawing.Point(12, 12);
			this.grpBasicSettings.Name = "grpBasicSettings";
			this.grpBasicSettings.Size = new System.Drawing.Size(512, 101);
			this.grpBasicSettings.TabIndex = 28;
			this.grpBasicSettings.TabStop = false;
			this.grpBasicSettings.Text = "Basic Settings";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 248);
			this.Controls.Add(this.grpBasicSettings);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.lblCurrentCursor_Y);
			this.Controls.Add(this.lblCurrentCursor_Ylabel);
			this.Controls.Add(this.lblCurrentCursor_X);
			this.Controls.Add(this.lblCurrentCursor_Xlabel);
			this.Controls.Add(this.grpSelectedArea);
			this.Controls.Add(this.btnStart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "ScreenShotter 3000X";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaUpperLeft_X)).EndInit();
			this.grpSelectedArea.ResumeLayout(false);
			this.grpSelectedArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaLowerRight_Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaLowerRight_X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSelectedAreaUpperLeft_Y)).EndInit();
			this.grpBasicSettings.ResumeLayout(false);
			this.grpBasicSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudInterval;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.Label lblSaveLocation;
		private System.Windows.Forms.TextBox tbSaveLocation;
		private System.Windows.Forms.Button btnSaveLocationBrowse;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblRegionToCapture;
		private System.Windows.Forms.ComboBox cmbRegionToCapture;
		private System.Windows.Forms.NumericUpDown nudSelectedAreaUpperLeft_X;
		private System.Windows.Forms.Label lblSelectedAreaUpperLeft_X;
		private System.Windows.Forms.GroupBox grpSelectedArea;
		private System.Windows.Forms.Label lblSelectedAreaUpperLeft_Y;
		private System.Windows.Forms.NumericUpDown nudSelectedAreaUpperLeft_Y;
		private System.Windows.Forms.Label lblLowerRight;
		private System.Windows.Forms.Label lblSelectedAreaLowerRight_Y;
		private System.Windows.Forms.NumericUpDown nudSelectedAreaLowerRight_Y;
		private System.Windows.Forms.Label lblSelectedAreaLowerRight_X;
		private System.Windows.Forms.NumericUpDown nudSelectedAreaLowerRight_X;
		private System.Windows.Forms.Label lblUpperLeft;
		private System.Windows.Forms.Label lblCurrentCursor_Xlabel;
		private System.Windows.Forms.Label lblCurrentCursor_X;
		private System.Windows.Forms.Label lblCurrentCursor_Y;
		private System.Windows.Forms.Label lblCurrentCursor_Ylabel;
		private System.Windows.Forms.Button btnSaveLocationOpen;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.GroupBox grpBasicSettings;
	}
}
