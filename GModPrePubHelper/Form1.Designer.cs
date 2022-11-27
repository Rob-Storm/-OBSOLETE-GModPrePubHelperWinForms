namespace GModPrePubHelper
{
    partial class GMPPH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMPPH));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpbxTags = new System.Windows.Forms.GroupBox();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.btnDefaultGmadPath = new System.Windows.Forms.Button();
            this.btnBrowseGmad = new System.Windows.Forms.Button();
            this.txtbxGmadPath = new System.Windows.Forms.TextBox();
            this.btnCreateDirectories = new System.Windows.Forms.Button();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxMapPath = new System.Windows.Forms.TextBox();
            this.lblMapFileInfo = new System.Windows.Forms.Label();
            this.btnMapFileBrowse = new System.Windows.Forms.Button();
            this.lblImageWarning = new System.Windows.Forms.Label();
            this.btnThumbnailBrowse = new System.Windows.Forms.Button();
            this.txtbxThumbnailPath = new System.Windows.Forms.TextBox();
            this.chkbxUsingThumbnail = new System.Windows.Forms.CheckBox();
            this.btnContentBrowse = new System.Windows.Forms.Button();
            this.txtbxContentPath = new System.Windows.Forms.TextBox();
            this.chkbxUsingCustomContent = new System.Windows.Forms.CheckBox();
            this.btnDesktopPath = new System.Windows.Forms.Button();
            this.txtbxFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpbxDir = new System.Windows.Forms.GroupBox();
            this.grpbxName = new System.Windows.Forms.GroupBox();
            this.grpbxCustomContent = new System.Windows.Forms.GroupBox();
            this.grpbxMap = new System.Windows.Forms.GroupBox();
            this.grpbxRootDir = new System.Windows.Forms.GroupBox();
            this.grpbxThumbnail = new System.Windows.Forms.GroupBox();
            this.grpbxGmad = new System.Windows.Forms.GroupBox();
            this.pnlMain.SuspendLayout();
            this.grpbxTags.SuspendLayout();
            this.grpbxDir.SuspendLayout();
            this.grpbxName.SuspendLayout();
            this.grpbxCustomContent.SuspendLayout();
            this.grpbxMap.SuspendLayout();
            this.grpbxRootDir.SuspendLayout();
            this.grpbxThumbnail.SuspendLayout();
            this.grpbxGmad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.Controls.Add(this.grpbxTags);
            this.pnlMain.Controls.Add(this.grpbxGmad);
            this.pnlMain.Controls.Add(this.grpbxThumbnail);
            this.pnlMain.Controls.Add(this.grpbxRootDir);
            this.pnlMain.Controls.Add(this.grpbxMap);
            this.pnlMain.Controls.Add(this.grpbxCustomContent);
            this.pnlMain.Controls.Add(this.grpbxName);
            this.pnlMain.Controls.Add(this.grpbxDir);
            this.pnlMain.Location = new System.Drawing.Point(5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(725, 469);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // grpbxTags
            // 
            this.grpbxTags.Controls.Add(this.clbTags);
            this.grpbxTags.Location = new System.Drawing.Point(6, 322);
            this.grpbxTags.Name = "grpbxTags";
            this.grpbxTags.Size = new System.Drawing.Size(347, 133);
            this.grpbxTags.TabIndex = 1;
            this.grpbxTags.TabStop = false;
            this.grpbxTags.Text = "JSON Tags (Choose up to 2)";
            // 
            // clbTags
            // 
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Items.AddRange(new object[] {
            "Fun",
            "Roleplay",
            "Scenic",
            "Movie",
            "Realism",
            "Cartoon",
            "Water",
            "Comic",
            "Build"});
            this.clbTags.Location = new System.Drawing.Point(6, 14);
            this.clbTags.MultiColumn = true;
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(322, 109);
            this.clbTags.TabIndex = 0;
            this.clbTags.SelectedIndexChanged += new System.EventHandler(this.clbTags_SelectedIndexChanged);
            // 
            // btnDefaultGmadPath
            // 
            this.btnDefaultGmadPath.Location = new System.Drawing.Point(72, 45);
            this.btnDefaultGmadPath.Name = "btnDefaultGmadPath";
            this.btnDefaultGmadPath.Size = new System.Drawing.Size(125, 24);
            this.btnDefaultGmadPath.TabIndex = 3;
            this.btnDefaultGmadPath.Text = "Use Default Path";
            this.btnDefaultGmadPath.UseVisualStyleBackColor = true;
            this.btnDefaultGmadPath.Click += new System.EventHandler(this.btnDefaultGmadPath_Click);
            // 
            // btnBrowseGmad
            // 
            this.btnBrowseGmad.Location = new System.Drawing.Point(259, 17);
            this.btnBrowseGmad.Name = "btnBrowseGmad";
            this.btnBrowseGmad.Size = new System.Drawing.Size(75, 24);
            this.btnBrowseGmad.TabIndex = 2;
            this.btnBrowseGmad.Text = "Browse...";
            this.btnBrowseGmad.UseVisualStyleBackColor = true;
            this.btnBrowseGmad.Click += new System.EventHandler(this.btnBrowseGmad_Click);
            // 
            // txtbxGmadPath
            // 
            this.txtbxGmadPath.Location = new System.Drawing.Point(6, 19);
            this.txtbxGmadPath.Name = "txtbxGmadPath";
            this.txtbxGmadPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxGmadPath.TabIndex = 1;
            this.txtbxGmadPath.TextChanged += new System.EventHandler(this.txtbxGmadPath_TextChanged);
            // 
            // btnCreateDirectories
            // 
            this.btnCreateDirectories.Location = new System.Drawing.Point(88, 48);
            this.btnCreateDirectories.Name = "btnCreateDirectories";
            this.btnCreateDirectories.Size = new System.Drawing.Size(150, 24);
            this.btnCreateDirectories.TabIndex = 8;
            this.btnCreateDirectories.Text = "Create Directories and GMA";
            this.btnCreateDirectories.UseVisualStyleBackColor = true;
            this.btnCreateDirectories.Click += new System.EventHandler(this.btnCreateDirectories_Click);
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Location = new System.Drawing.Point(67, 90);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(183, 13);
            this.lblGeneralInfo.TabIndex = 10;
            this.lblGeneralInfo.Text = "Click \"Create Directories\" when done";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(6, 19);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(250, 20);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // txtbxMapPath
            // 
            this.txtbxMapPath.Location = new System.Drawing.Point(6, 19);
            this.txtbxMapPath.Name = "txtbxMapPath";
            this.txtbxMapPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxMapPath.TabIndex = 4;
            this.txtbxMapPath.TextChanged += new System.EventHandler(this.txtbxMapPath_TextChanged);
            // 
            // lblMapFileInfo
            // 
            this.lblMapFileInfo.AutoSize = true;
            this.lblMapFileInfo.Location = new System.Drawing.Point(105, 44);
            this.lblMapFileInfo.Name = "lblMapFileInfo";
            this.lblMapFileInfo.Size = new System.Drawing.Size(89, 13);
            this.lblMapFileInfo.TabIndex = 3;
            this.lblMapFileInfo.Text = "File must be .bsp!";
            // 
            // btnMapFileBrowse
            // 
            this.btnMapFileBrowse.Location = new System.Drawing.Point(263, 17);
            this.btnMapFileBrowse.Name = "btnMapFileBrowse";
            this.btnMapFileBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnMapFileBrowse.TabIndex = 2;
            this.btnMapFileBrowse.Text = "Browse...";
            this.btnMapFileBrowse.UseVisualStyleBackColor = true;
            this.btnMapFileBrowse.Click += new System.EventHandler(this.btnMapFileBrowse_Click);
            // 
            // lblImageWarning
            // 
            this.lblImageWarning.AutoSize = true;
            this.lblImageWarning.Location = new System.Drawing.Point(61, 66);
            this.lblImageWarning.Name = "lblImageWarning";
            this.lblImageWarning.Size = new System.Drawing.Size(147, 13);
            this.lblImageWarning.TabIndex = 7;
            this.lblImageWarning.Text = "Image must be 128x128 .png!";
            // 
            // btnThumbnailBrowse
            // 
            this.btnThumbnailBrowse.Location = new System.Drawing.Point(262, 41);
            this.btnThumbnailBrowse.Name = "btnThumbnailBrowse";
            this.btnThumbnailBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnThumbnailBrowse.TabIndex = 6;
            this.btnThumbnailBrowse.Text = "Browse...";
            this.btnThumbnailBrowse.UseVisualStyleBackColor = true;
            this.btnThumbnailBrowse.Click += new System.EventHandler(this.btnThumbnailBrowse_Click);
            // 
            // txtbxThumbnailPath
            // 
            this.txtbxThumbnailPath.Location = new System.Drawing.Point(6, 43);
            this.txtbxThumbnailPath.Name = "txtbxThumbnailPath";
            this.txtbxThumbnailPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxThumbnailPath.TabIndex = 5;
            this.txtbxThumbnailPath.TextChanged += new System.EventHandler(this.txtbxThumbnailPath_TextChanged);
            // 
            // chkbxUsingThumbnail
            // 
            this.chkbxUsingThumbnail.AutoSize = true;
            this.chkbxUsingThumbnail.Location = new System.Drawing.Point(6, 19);
            this.chkbxUsingThumbnail.Name = "chkbxUsingThumbnail";
            this.chkbxUsingThumbnail.Size = new System.Drawing.Size(149, 17);
            this.chkbxUsingThumbnail.TabIndex = 4;
            this.chkbxUsingThumbnail.Text = "Using Custom Thumbnail?";
            this.chkbxUsingThumbnail.UseVisualStyleBackColor = true;
            this.chkbxUsingThumbnail.CheckedChanged += new System.EventHandler(this.chkbxUsingThumbnail_CheckedChanged);
            // 
            // btnContentBrowse
            // 
            this.btnContentBrowse.Location = new System.Drawing.Point(263, 41);
            this.btnContentBrowse.Name = "btnContentBrowse";
            this.btnContentBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnContentBrowse.TabIndex = 5;
            this.btnContentBrowse.Text = "Browse...";
            this.btnContentBrowse.UseVisualStyleBackColor = true;
            this.btnContentBrowse.Click += new System.EventHandler(this.btnContentBrowse_Click);
            // 
            // txtbxContentPath
            // 
            this.txtbxContentPath.Location = new System.Drawing.Point(6, 43);
            this.txtbxContentPath.Name = "txtbxContentPath";
            this.txtbxContentPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxContentPath.TabIndex = 4;
            this.txtbxContentPath.TextChanged += new System.EventHandler(this.txtbxContentPath_TextChanged);
            // 
            // chkbxUsingCustomContent
            // 
            this.chkbxUsingCustomContent.AutoSize = true;
            this.chkbxUsingCustomContent.Location = new System.Drawing.Point(6, 19);
            this.chkbxUsingCustomContent.Name = "chkbxUsingCustomContent";
            this.chkbxUsingCustomContent.Size = new System.Drawing.Size(137, 17);
            this.chkbxUsingCustomContent.TabIndex = 3;
            this.chkbxUsingCustomContent.Text = "Using Custom Content?";
            this.chkbxUsingCustomContent.UseVisualStyleBackColor = true;
            this.chkbxUsingCustomContent.CheckedChanged += new System.EventHandler(this.chkbxUsingCustomContent_CheckedChanged);
            // 
            // btnDesktopPath
            // 
            this.btnDesktopPath.Location = new System.Drawing.Point(81, 44);
            this.btnDesktopPath.Name = "btnDesktopPath";
            this.btnDesktopPath.Size = new System.Drawing.Size(100, 24);
            this.btnDesktopPath.TabIndex = 3;
            this.btnDesktopPath.Text = "Use Desktop";
            this.btnDesktopPath.UseVisualStyleBackColor = true;
            this.btnDesktopPath.Click += new System.EventHandler(this.btnDesktopPath_Click);
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Location = new System.Drawing.Point(6, 19);
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.Size = new System.Drawing.Size(250, 20);
            this.txtbxFilePath.TabIndex = 0;
            this.txtbxFilePath.TextChanged += new System.EventHandler(this.txtbxFilePath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(262, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpbxDir
            // 
            this.grpbxDir.Controls.Add(this.lblGeneralInfo);
            this.grpbxDir.Controls.Add(this.btnCreateDirectories);
            this.grpbxDir.Location = new System.Drawing.Point(359, 322);
            this.grpbxDir.Name = "grpbxDir";
            this.grpbxDir.Size = new System.Drawing.Size(350, 133);
            this.grpbxDir.TabIndex = 1;
            this.grpbxDir.TabStop = false;
            this.grpbxDir.Text = "Create Directories and GMA";
            // 
            // grpbxName
            // 
            this.grpbxName.Controls.Add(this.txtbxName);
            this.grpbxName.Location = new System.Drawing.Point(359, 216);
            this.grpbxName.Name = "grpbxName";
            this.grpbxName.Size = new System.Drawing.Size(350, 100);
            this.grpbxName.TabIndex = 2;
            this.grpbxName.TabStop = false;
            this.grpbxName.Text = "Map Name (Required! Do NOT Include file type)";
            // 
            // grpbxCustomContent
            // 
            this.grpbxCustomContent.Controls.Add(this.btnContentBrowse);
            this.grpbxCustomContent.Controls.Add(this.chkbxUsingCustomContent);
            this.grpbxCustomContent.Controls.Add(this.txtbxContentPath);
            this.grpbxCustomContent.Location = new System.Drawing.Point(359, 109);
            this.grpbxCustomContent.Name = "grpbxCustomContent";
            this.grpbxCustomContent.Size = new System.Drawing.Size(350, 100);
            this.grpbxCustomContent.TabIndex = 14;
            this.grpbxCustomContent.TabStop = false;
            this.grpbxCustomContent.Text = "Custom Content (DOES NOT DO ANYTHING YET)";
            // 
            // grpbxMap
            // 
            this.grpbxMap.Controls.Add(this.txtbxMapPath);
            this.grpbxMap.Controls.Add(this.btnMapFileBrowse);
            this.grpbxMap.Controls.Add(this.lblMapFileInfo);
            this.grpbxMap.Location = new System.Drawing.Point(359, 4);
            this.grpbxMap.Name = "grpbxMap";
            this.grpbxMap.Size = new System.Drawing.Size(350, 100);
            this.grpbxMap.TabIndex = 15;
            this.grpbxMap.TabStop = false;
            this.grpbxMap.Text = "Compiled Map File (Required!)";
            // 
            // grpbxRootDir
            // 
            this.grpbxRootDir.Controls.Add(this.btnDesktopPath);
            this.grpbxRootDir.Controls.Add(this.txtbxFilePath);
            this.grpbxRootDir.Controls.Add(this.btnBrowse);
            this.grpbxRootDir.Location = new System.Drawing.Point(6, 4);
            this.grpbxRootDir.Name = "grpbxRootDir";
            this.grpbxRootDir.Size = new System.Drawing.Size(347, 100);
            this.grpbxRootDir.TabIndex = 16;
            this.grpbxRootDir.TabStop = false;
            this.grpbxRootDir.Text = "Select Folder To Store GMA (Required!)";
            // 
            // grpbxThumbnail
            // 
            this.grpbxThumbnail.Controls.Add(this.lblImageWarning);
            this.grpbxThumbnail.Controls.Add(this.chkbxUsingThumbnail);
            this.grpbxThumbnail.Controls.Add(this.txtbxThumbnailPath);
            this.grpbxThumbnail.Controls.Add(this.btnThumbnailBrowse);
            this.grpbxThumbnail.Location = new System.Drawing.Point(6, 109);
            this.grpbxThumbnail.Name = "grpbxThumbnail";
            this.grpbxThumbnail.Size = new System.Drawing.Size(347, 100);
            this.grpbxThumbnail.TabIndex = 17;
            this.grpbxThumbnail.TabStop = false;
            this.grpbxThumbnail.Text = "Custom Thumbnail (Optional)";
            // 
            // grpbxGmad
            // 
            this.grpbxGmad.Controls.Add(this.btnDefaultGmadPath);
            this.grpbxGmad.Controls.Add(this.txtbxGmadPath);
            this.grpbxGmad.Controls.Add(this.btnBrowseGmad);
            this.grpbxGmad.Location = new System.Drawing.Point(4, 216);
            this.grpbxGmad.Name = "grpbxGmad";
            this.grpbxGmad.Size = new System.Drawing.Size(349, 100);
            this.grpbxGmad.TabIndex = 18;
            this.grpbxGmad.TabStop = false;
            this.grpbxGmad.Text = "gmad.exe (Required! Usually in GarrysMod/bin)";
            // 
            // GMPPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 475);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GMPPH";
            this.Text = "GMod Pre-Publishing Helper 0.2.8";
            this.pnlMain.ResumeLayout(false);
            this.grpbxTags.ResumeLayout(false);
            this.grpbxDir.ResumeLayout(false);
            this.grpbxDir.PerformLayout();
            this.grpbxName.ResumeLayout(false);
            this.grpbxName.PerformLayout();
            this.grpbxCustomContent.ResumeLayout(false);
            this.grpbxCustomContent.PerformLayout();
            this.grpbxMap.ResumeLayout(false);
            this.grpbxMap.PerformLayout();
            this.grpbxRootDir.ResumeLayout(false);
            this.grpbxRootDir.PerformLayout();
            this.grpbxThumbnail.ResumeLayout(false);
            this.grpbxThumbnail.PerformLayout();
            this.grpbxGmad.ResumeLayout(false);
            this.grpbxGmad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtbxFilePath;
        private System.Windows.Forms.CheckBox chkbxUsingCustomContent;
        private System.Windows.Forms.CheckBox chkbxUsingThumbnail;
        private System.Windows.Forms.Button btnContentBrowse;
        private System.Windows.Forms.TextBox txtbxContentPath;
        private System.Windows.Forms.Button btnThumbnailBrowse;
        private System.Windows.Forms.TextBox txtbxThumbnailPath;
        private System.Windows.Forms.Label lblImageWarning;
        private System.Windows.Forms.Button btnMapFileBrowse;
        private System.Windows.Forms.Label lblMapFileInfo;
        private System.Windows.Forms.TextBox txtbxMapPath;
        private System.Windows.Forms.Button btnDesktopPath;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxGmadPath;
        private System.Windows.Forms.Button btnBrowseGmad;
        private System.Windows.Forms.GroupBox grpbxTags;
        private System.Windows.Forms.Button btnCreateDirectories;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Button btnDefaultGmadPath;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.GroupBox grpbxDir;
        private System.Windows.Forms.GroupBox grpbxCustomContent;
        private System.Windows.Forms.GroupBox grpbxName;
        private System.Windows.Forms.GroupBox grpbxGmad;
        private System.Windows.Forms.GroupBox grpbxThumbnail;
        private System.Windows.Forms.GroupBox grpbxRootDir;
        private System.Windows.Forms.GroupBox grpbxMap;
    }
}

