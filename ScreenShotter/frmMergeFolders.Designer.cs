namespace ScreenShotter
{
	partial class frmMergeFolders
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMergeFolders));
			this.dgvAddedFolders = new System.Windows.Forms.DataGridView();
			this.btnBrowseFolderToAdd = new System.Windows.Forms.Button();
			this.folderBrowserDialog_Add = new System.Windows.Forms.FolderBrowserDialog();
			this.tbFolderToAdd = new System.Windows.Forms.TextBox();
			this.lblFolderToAdd = new System.Windows.Forms.Label();
			this.lblFoldersAdded = new System.Windows.Forms.Label();
			this.lblOutputFolder = new System.Windows.Forms.Label();
			this.tbOutputFolder = new System.Windows.Forms.TextBox();
			this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
			this.folderBrowserDialog_Output = new System.Windows.Forms.FolderBrowserDialog();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnMerge = new System.Windows.Forms.Button();
			this.lblStartNumberingAt = new System.Windows.Forms.Label();
			this.nudStartNumbering = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblFormatsToMerge = new System.Windows.Forms.Label();
			this.radAll = new System.Windows.Forms.RadioButton();
			this.radJPG = new System.Windows.Forms.RadioButton();
			this.radPNG = new System.Windows.Forms.RadioButton();
			this.radBMP = new System.Windows.Forms.RadioButton();
			this.radTIFF = new System.Windows.Forms.RadioButton();
			this.radGIF = new System.Windows.Forms.RadioButton();
			this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNumFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedFolders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStartNumbering)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAddedFolders
			// 
			this.dgvAddedFolders.AllowUserToAddRows = false;
			this.dgvAddedFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAddedFolders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAddedFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddedFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPath,
            this.colNumFiles});
			this.dgvAddedFolders.Location = new System.Drawing.Point(12, 95);
			this.dgvAddedFolders.Name = "dgvAddedFolders";
			this.dgvAddedFolders.ReadOnly = true;
			this.dgvAddedFolders.Size = new System.Drawing.Size(652, 107);
			this.dgvAddedFolders.TabIndex = 0;
			// 
			// btnBrowseFolderToAdd
			// 
			this.btnBrowseFolderToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseFolderToAdd.Location = new System.Drawing.Point(589, 12);
			this.btnBrowseFolderToAdd.Name = "btnBrowseFolderToAdd";
			this.btnBrowseFolderToAdd.Size = new System.Drawing.Size(75, 22);
			this.btnBrowseFolderToAdd.TabIndex = 1;
			this.btnBrowseFolderToAdd.Text = "Browse";
			this.btnBrowseFolderToAdd.UseVisualStyleBackColor = true;
			this.btnBrowseFolderToAdd.Click += new System.EventHandler(this.btnBrowseFolderToAdd_Click);
			// 
			// tbFolderToAdd
			// 
			this.tbFolderToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFolderToAdd.Location = new System.Drawing.Point(89, 13);
			this.tbFolderToAdd.Name = "tbFolderToAdd";
			this.tbFolderToAdd.Size = new System.Drawing.Size(496, 20);
			this.tbFolderToAdd.TabIndex = 3;
			this.tbFolderToAdd.Text = "C:\\Users\\carso\\Documents\\Programming\\ScreenShotter\\ScreenShotter\\bin\\Debug";
			// 
			// lblFolderToAdd
			// 
			this.lblFolderToAdd.AutoSize = true;
			this.lblFolderToAdd.Location = new System.Drawing.Point(12, 17);
			this.lblFolderToAdd.Name = "lblFolderToAdd";
			this.lblFolderToAdd.Size = new System.Drawing.Size(69, 13);
			this.lblFolderToAdd.TabIndex = 4;
			this.lblFolderToAdd.Text = "Folder to add";
			// 
			// lblFoldersAdded
			// 
			this.lblFoldersAdded.AutoSize = true;
			this.lblFoldersAdded.Location = new System.Drawing.Point(12, 79);
			this.lblFoldersAdded.Name = "lblFoldersAdded";
			this.lblFoldersAdded.Size = new System.Drawing.Size(75, 13);
			this.lblFoldersAdded.TabIndex = 5;
			this.lblFoldersAdded.Text = "Folders Added";
			// 
			// lblOutputFolder
			// 
			this.lblOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblOutputFolder.AutoSize = true;
			this.lblOutputFolder.Location = new System.Drawing.Point(12, 213);
			this.lblOutputFolder.Name = "lblOutputFolder";
			this.lblOutputFolder.Size = new System.Drawing.Size(71, 13);
			this.lblOutputFolder.TabIndex = 8;
			this.lblOutputFolder.Text = "Output Folder";
			// 
			// tbOutputFolder
			// 
			this.tbOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutputFolder.Location = new System.Drawing.Point(89, 209);
			this.tbOutputFolder.Name = "tbOutputFolder";
			this.tbOutputFolder.Size = new System.Drawing.Size(496, 20);
			this.tbOutputFolder.TabIndex = 7;
			// 
			// btnBrowseOutputFolder
			// 
			this.btnBrowseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOutputFolder.Location = new System.Drawing.Point(589, 208);
			this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
			this.btnBrowseOutputFolder.Size = new System.Drawing.Size(75, 22);
			this.btnBrowseOutputFolder.TabIndex = 6;
			this.btnBrowseOutputFolder.Text = "Browse";
			this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
			this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 44);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 22);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnMerge
			// 
			this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMerge.Location = new System.Drawing.Point(12, 338);
			this.btnMerge.Name = "btnMerge";
			this.btnMerge.Size = new System.Drawing.Size(75, 22);
			this.btnMerge.TabIndex = 10;
			this.btnMerge.Text = "Merge";
			this.btnMerge.UseVisualStyleBackColor = true;
			this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
			// 
			// lblStartNumberingAt
			// 
			this.lblStartNumberingAt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblStartNumberingAt.AutoSize = true;
			this.lblStartNumberingAt.Location = new System.Drawing.Point(12, 241);
			this.lblStartNumberingAt.Name = "lblStartNumberingAt";
			this.lblStartNumberingAt.Size = new System.Drawing.Size(96, 13);
			this.lblStartNumberingAt.TabIndex = 11;
			this.lblStartNumberingAt.Text = "Start Numbering At";
			// 
			// nudStartNumbering
			// 
			this.nudStartNumbering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudStartNumbering.Location = new System.Drawing.Point(114, 239);
			this.nudStartNumbering.Name = "nudStartNumbering";
			this.nudStartNumbering.Size = new System.Drawing.Size(471, 20);
			this.nudStartNumbering.TabIndex = 12;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.radAll);
			this.flowLayoutPanel1.Controls.Add(this.radJPG);
			this.flowLayoutPanel1.Controls.Add(this.radPNG);
			this.flowLayoutPanel1.Controls.Add(this.radBMP);
			this.flowLayoutPanel1.Controls.Add(this.radTIFF);
			this.flowLayoutPanel1.Controls.Add(this.radGIF);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 282);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 50);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// lblFormatsToMerge
			// 
			this.lblFormatsToMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFormatsToMerge.AutoSize = true;
			this.lblFormatsToMerge.Location = new System.Drawing.Point(12, 266);
			this.lblFormatsToMerge.Name = "lblFormatsToMerge";
			this.lblFormatsToMerge.Size = new System.Drawing.Size(89, 13);
			this.lblFormatsToMerge.TabIndex = 14;
			this.lblFormatsToMerge.Text = "Formats to Merge";
			// 
			// radAll
			// 
			this.radAll.AutoSize = true;
			this.radAll.Checked = true;
			this.radAll.Location = new System.Drawing.Point(3, 3);
			this.radAll.Name = "radAll";
			this.radAll.Size = new System.Drawing.Size(36, 17);
			this.radAll.TabIndex = 0;
			this.radAll.TabStop = true;
			this.radAll.Text = "All";
			this.radAll.UseVisualStyleBackColor = true;
			this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
			// 
			// radJPG
			// 
			this.radJPG.AutoSize = true;
			this.radJPG.Location = new System.Drawing.Point(3, 26);
			this.radJPG.Name = "radJPG";
			this.radJPG.Size = new System.Drawing.Size(45, 17);
			this.radJPG.TabIndex = 1;
			this.radJPG.Text = "JPG";
			this.radJPG.UseVisualStyleBackColor = true;
			this.radJPG.CheckedChanged += new System.EventHandler(this.radJPG_CheckedChanged);
			// 
			// radPNG
			// 
			this.radPNG.AutoSize = true;
			this.radPNG.Location = new System.Drawing.Point(54, 3);
			this.radPNG.Name = "radPNG";
			this.radPNG.Size = new System.Drawing.Size(48, 17);
			this.radPNG.TabIndex = 2;
			this.radPNG.Text = "PNG";
			this.radPNG.UseVisualStyleBackColor = true;
			this.radPNG.CheckedChanged += new System.EventHandler(this.radPNG_CheckedChanged);
			// 
			// radBMP
			// 
			this.radBMP.AutoSize = true;
			this.radBMP.Location = new System.Drawing.Point(54, 26);
			this.radBMP.Name = "radBMP";
			this.radBMP.Size = new System.Drawing.Size(48, 17);
			this.radBMP.TabIndex = 3;
			this.radBMP.Text = "BMP";
			this.radBMP.UseVisualStyleBackColor = true;
			this.radBMP.CheckedChanged += new System.EventHandler(this.radBMP_CheckedChanged);
			// 
			// radTIFF
			// 
			this.radTIFF.AutoSize = true;
			this.radTIFF.Location = new System.Drawing.Point(108, 3);
			this.radTIFF.Name = "radTIFF";
			this.radTIFF.Size = new System.Drawing.Size(47, 17);
			this.radTIFF.TabIndex = 4;
			this.radTIFF.Text = "TIFF";
			this.radTIFF.UseVisualStyleBackColor = true;
			this.radTIFF.CheckedChanged += new System.EventHandler(this.radTIFF_CheckedChanged);
			// 
			// radGIF
			// 
			this.radGIF.AutoSize = true;
			this.radGIF.Location = new System.Drawing.Point(108, 26);
			this.radGIF.Name = "radGIF";
			this.radGIF.Size = new System.Drawing.Size(42, 17);
			this.radGIF.TabIndex = 5;
			this.radGIF.Text = "GIF";
			this.radGIF.UseVisualStyleBackColor = true;
			this.radGIF.CheckedChanged += new System.EventHandler(this.radGIF_CheckedChanged);
			// 
			// colPath
			// 
			this.colPath.FillWeight = 300F;
			this.colPath.HeaderText = "Path";
			this.colPath.Name = "colPath";
			this.colPath.ReadOnly = true;
			// 
			// colNumFiles
			// 
			this.colNumFiles.HeaderText = "# Files";
			this.colNumFiles.Name = "colNumFiles";
			this.colNumFiles.ReadOnly = true;
			// 
			// frmMergeFolders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 372);
			this.Controls.Add(this.lblFormatsToMerge);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.nudStartNumbering);
			this.Controls.Add(this.lblStartNumberingAt);
			this.Controls.Add(this.btnMerge);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblOutputFolder);
			this.Controls.Add(this.tbOutputFolder);
			this.Controls.Add(this.btnBrowseOutputFolder);
			this.Controls.Add(this.lblFoldersAdded);
			this.Controls.Add(this.lblFolderToAdd);
			this.Controls.Add(this.tbFolderToAdd);
			this.Controls.Add(this.btnBrowseFolderToAdd);
			this.Controls.Add(this.dgvAddedFolders);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(327, 363);
			this.Name = "frmMergeFolders";
			this.Text = "Merge Folder Contents";
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedFolders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStartNumbering)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAddedFolders;
		private System.Windows.Forms.Button btnBrowseFolderToAdd;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Add;
		private System.Windows.Forms.TextBox tbFolderToAdd;
		private System.Windows.Forms.Label lblFolderToAdd;
		private System.Windows.Forms.Label lblFoldersAdded;
		private System.Windows.Forms.Label lblOutputFolder;
		private System.Windows.Forms.TextBox tbOutputFolder;
		private System.Windows.Forms.Button btnBrowseOutputFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Output;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnMerge;
		private System.Windows.Forms.Label lblStartNumberingAt;
		private System.Windows.Forms.NumericUpDown nudStartNumbering;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.RadioButton radAll;
		private System.Windows.Forms.RadioButton radJPG;
		private System.Windows.Forms.RadioButton radPNG;
		private System.Windows.Forms.RadioButton radBMP;
		private System.Windows.Forms.RadioButton radTIFF;
		private System.Windows.Forms.RadioButton radGIF;
		private System.Windows.Forms.Label lblFormatsToMerge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumFiles;
	}
}