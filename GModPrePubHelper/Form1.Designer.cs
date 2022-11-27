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
            this.panel4 = new System.Windows.Forms.Panel();
            this.grpbxTags = new System.Windows.Forms.GroupBox();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.lblJson = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDefaultGmadPath = new System.Windows.Forms.Button();
            this.btnBrowseGmad = new System.Windows.Forms.Button();
            this.txtbxGmadPath = new System.Windows.Forms.TextBox();
            this.lblGmad = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateDirectories = new System.Windows.Forms.Button();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblMapNameInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxMapPath = new System.Windows.Forms.TextBox();
            this.lblMapFileInfo = new System.Windows.Forms.Label();
            this.btnMapFileBrowse = new System.Windows.Forms.Button();
            this.lblMapFile = new System.Windows.Forms.Label();
            this.pnlCustomThumbnail = new System.Windows.Forms.Panel();
            this.lblImageWarning = new System.Windows.Forms.Label();
            this.btnThumbnailBrowse = new System.Windows.Forms.Button();
            this.txtbxThumbnailPath = new System.Windows.Forms.TextBox();
            this.lblCustomThumbnail = new System.Windows.Forms.Label();
            this.chkbxUsingThumbnail = new System.Windows.Forms.CheckBox();
            this.pnlCustomContent = new System.Windows.Forms.Panel();
            this.btnContentBrowse = new System.Windows.Forms.Button();
            this.txtbxContentPath = new System.Windows.Forms.TextBox();
            this.lblCustomContent = new System.Windows.Forms.Label();
            this.chkbxUsingCustomContent = new System.Windows.Forms.CheckBox();
            this.pnlMainFolder = new System.Windows.Forms.Panel();
            this.btnDesktopPath = new System.Windows.Forms.Button();
            this.txtbxFilePath = new System.Windows.Forms.TextBox();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpbxTags.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCustomThumbnail.SuspendLayout();
            this.pnlCustomContent.SuspendLayout();
            this.pnlMainFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.pnlName);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlCustomThumbnail);
            this.pnlMain.Controls.Add(this.pnlCustomContent);
            this.pnlMain.Controls.Add(this.pnlMainFolder);
            this.pnlMain.Location = new System.Drawing.Point(13, 13);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(775, 458);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grpbxTags);
            this.panel4.Controls.Add(this.lblJson);
            this.panel4.Location = new System.Drawing.Point(6, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 133);
            this.panel4.TabIndex = 13;
            // 
            // grpbxTags
            // 
            this.grpbxTags.Controls.Add(this.clbTags);
            this.grpbxTags.Location = new System.Drawing.Point(9, 17);
            this.grpbxTags.Name = "grpbxTags";
            this.grpbxTags.Size = new System.Drawing.Size(338, 113);
            this.grpbxTags.TabIndex = 1;
            this.grpbxTags.TabStop = false;
            this.grpbxTags.Text = "Tags (Choose up to 2)";
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
            this.clbTags.Size = new System.Drawing.Size(322, 94);
            this.clbTags.TabIndex = 0;
            this.clbTags.SelectedIndexChanged += new System.EventHandler(this.clbTags_SelectedIndexChanged);
            // 
            // lblJson
            // 
            this.lblJson.AutoSize = true;
            this.lblJson.Location = new System.Drawing.Point(3, 0);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(109, 13);
            this.lblJson.TabIndex = 0;
            this.lblJson.Text = "JSON File (Required!)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDefaultGmadPath);
            this.panel3.Controls.Add(this.btnBrowseGmad);
            this.panel3.Controls.Add(this.txtbxGmadPath);
            this.panel3.Controls.Add(this.lblGmad);
            this.panel3.Location = new System.Drawing.Point(6, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 100);
            this.panel3.TabIndex = 12;
            // 
            // btnDefaultGmadPath
            // 
            this.btnDefaultGmadPath.Location = new System.Drawing.Point(83, 47);
            this.btnDefaultGmadPath.Name = "btnDefaultGmadPath";
            this.btnDefaultGmadPath.Size = new System.Drawing.Size(125, 24);
            this.btnDefaultGmadPath.TabIndex = 3;
            this.btnDefaultGmadPath.Text = "Use Default Path";
            this.btnDefaultGmadPath.UseVisualStyleBackColor = true;
            this.btnDefaultGmadPath.Click += new System.EventHandler(this.btnDefaultGmadPath_Click);
            // 
            // btnBrowseGmad
            // 
            this.btnBrowseGmad.Location = new System.Drawing.Point(262, 19);
            this.btnBrowseGmad.Name = "btnBrowseGmad";
            this.btnBrowseGmad.Size = new System.Drawing.Size(75, 24);
            this.btnBrowseGmad.TabIndex = 2;
            this.btnBrowseGmad.Text = "Browse...";
            this.btnBrowseGmad.UseVisualStyleBackColor = true;
            this.btnBrowseGmad.Click += new System.EventHandler(this.btnBrowseGmad_Click);
            // 
            // txtbxGmadPath
            // 
            this.txtbxGmadPath.Location = new System.Drawing.Point(9, 21);
            this.txtbxGmadPath.Name = "txtbxGmadPath";
            this.txtbxGmadPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxGmadPath.TabIndex = 1;
            this.txtbxGmadPath.TextChanged += new System.EventHandler(this.txtbxGmadPath_TextChanged);
            // 
            // lblGmad
            // 
            this.lblGmad.AutoSize = true;
            this.lblGmad.Location = new System.Drawing.Point(6, 4);
            this.lblGmad.Name = "lblGmad";
            this.lblGmad.Size = new System.Drawing.Size(269, 13);
            this.lblGmad.TabIndex = 0;
            this.lblGmad.Text = "gmad.exe location (Required! Usually in GarrysMod/bin)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateDirectories);
            this.panel2.Controls.Add(this.lblGeneralInfo);
            this.panel2.Location = new System.Drawing.Point(362, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 125);
            this.panel2.TabIndex = 11;
            // 
            // btnCreateDirectories
            // 
            this.btnCreateDirectories.Location = new System.Drawing.Point(118, 37);
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
            this.lblGeneralInfo.Location = new System.Drawing.Point(102, 64);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(183, 13);
            this.lblGeneralInfo.TabIndex = 10;
            this.lblGeneralInfo.Text = "Click \"Create Directories\" when done";
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txtbxName);
            this.pnlName.Controls.Add(this.lblMapNameInfo);
            this.pnlName.Location = new System.Drawing.Point(359, 215);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(400, 100);
            this.pnlName.TabIndex = 9;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(6, 21);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(250, 20);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblMapNameInfo
            // 
            this.lblMapNameInfo.AutoSize = true;
            this.lblMapNameInfo.Location = new System.Drawing.Point(3, 0);
            this.lblMapNameInfo.Name = "lblMapNameInfo";
            this.lblMapNameInfo.Size = new System.Drawing.Size(236, 13);
            this.lblMapNameInfo.TabIndex = 0;
            this.lblMapNameInfo.Text = "Map Name (Required! Do NOT include file type!)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbxMapPath);
            this.panel1.Controls.Add(this.lblMapFileInfo);
            this.panel1.Controls.Add(this.btnMapFileBrowse);
            this.panel1.Controls.Add(this.lblMapFile);
            this.panel1.Location = new System.Drawing.Point(359, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 100);
            this.panel1.TabIndex = 7;
            // 
            // txtbxMapPath
            // 
            this.txtbxMapPath.Location = new System.Drawing.Point(6, 16);
            this.txtbxMapPath.Name = "txtbxMapPath";
            this.txtbxMapPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxMapPath.TabIndex = 4;
            this.txtbxMapPath.TextChanged += new System.EventHandler(this.txtbxMapPath_TextChanged);
            // 
            // lblMapFileInfo
            // 
            this.lblMapFileInfo.AutoSize = true;
            this.lblMapFileInfo.Location = new System.Drawing.Point(105, 41);
            this.lblMapFileInfo.Name = "lblMapFileInfo";
            this.lblMapFileInfo.Size = new System.Drawing.Size(89, 13);
            this.lblMapFileInfo.TabIndex = 3;
            this.lblMapFileInfo.Text = "File must be .bsp!";
            // 
            // btnMapFileBrowse
            // 
            this.btnMapFileBrowse.Location = new System.Drawing.Point(263, 14);
            this.btnMapFileBrowse.Name = "btnMapFileBrowse";
            this.btnMapFileBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnMapFileBrowse.TabIndex = 2;
            this.btnMapFileBrowse.Text = "Browse...";
            this.btnMapFileBrowse.UseVisualStyleBackColor = true;
            this.btnMapFileBrowse.Click += new System.EventHandler(this.btnMapFileBrowse_Click);
            // 
            // lblMapFile
            // 
            this.lblMapFile.AutoSize = true;
            this.lblMapFile.Location = new System.Drawing.Point(3, 0);
            this.lblMapFile.Name = "lblMapFile";
            this.lblMapFile.Size = new System.Drawing.Size(138, 13);
            this.lblMapFile.TabIndex = 0;
            this.lblMapFile.Text = "Select Map File (Required!):";
            // 
            // pnlCustomThumbnail
            // 
            this.pnlCustomThumbnail.Controls.Add(this.lblImageWarning);
            this.pnlCustomThumbnail.Controls.Add(this.btnThumbnailBrowse);
            this.pnlCustomThumbnail.Controls.Add(this.txtbxThumbnailPath);
            this.pnlCustomThumbnail.Controls.Add(this.lblCustomThumbnail);
            this.pnlCustomThumbnail.Controls.Add(this.chkbxUsingThumbnail);
            this.pnlCustomThumbnail.Location = new System.Drawing.Point(6, 109);
            this.pnlCustomThumbnail.Name = "pnlCustomThumbnail";
            this.pnlCustomThumbnail.Size = new System.Drawing.Size(350, 100);
            this.pnlCustomThumbnail.TabIndex = 6;
            // 
            // lblImageWarning
            // 
            this.lblImageWarning.AutoSize = true;
            this.lblImageWarning.Location = new System.Drawing.Point(61, 63);
            this.lblImageWarning.Name = "lblImageWarning";
            this.lblImageWarning.Size = new System.Drawing.Size(147, 13);
            this.lblImageWarning.TabIndex = 7;
            this.lblImageWarning.Text = "Image must be 128x128 .png!";
            // 
            // btnThumbnailBrowse
            // 
            this.btnThumbnailBrowse.Location = new System.Drawing.Point(262, 38);
            this.btnThumbnailBrowse.Name = "btnThumbnailBrowse";
            this.btnThumbnailBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnThumbnailBrowse.TabIndex = 6;
            this.btnThumbnailBrowse.Text = "Browse...";
            this.btnThumbnailBrowse.UseVisualStyleBackColor = true;
            this.btnThumbnailBrowse.Click += new System.EventHandler(this.btnThumbnailBrowse_Click);
            // 
            // txtbxThumbnailPath
            // 
            this.txtbxThumbnailPath.Location = new System.Drawing.Point(6, 40);
            this.txtbxThumbnailPath.Name = "txtbxThumbnailPath";
            this.txtbxThumbnailPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxThumbnailPath.TabIndex = 5;
            this.txtbxThumbnailPath.TextChanged += new System.EventHandler(this.txtbxThumbnailPath_TextChanged);
            // 
            // lblCustomThumbnail
            // 
            this.lblCustomThumbnail.AutoSize = true;
            this.lblCustomThumbnail.Location = new System.Drawing.Point(3, 0);
            this.lblCustomThumbnail.Name = "lblCustomThumbnail";
            this.lblCustomThumbnail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomThumbnail.Size = new System.Drawing.Size(145, 13);
            this.lblCustomThumbnail.TabIndex = 0;
            this.lblCustomThumbnail.Text = ":Custom Thumbnail (Optional)";
            // 
            // chkbxUsingThumbnail
            // 
            this.chkbxUsingThumbnail.AutoSize = true;
            this.chkbxUsingThumbnail.Location = new System.Drawing.Point(6, 16);
            this.chkbxUsingThumbnail.Name = "chkbxUsingThumbnail";
            this.chkbxUsingThumbnail.Size = new System.Drawing.Size(149, 17);
            this.chkbxUsingThumbnail.TabIndex = 4;
            this.chkbxUsingThumbnail.Text = "Using Custom Thumbnail?";
            this.chkbxUsingThumbnail.UseVisualStyleBackColor = true;
            this.chkbxUsingThumbnail.CheckedChanged += new System.EventHandler(this.chkbxUsingThumbnail_CheckedChanged);
            // 
            // pnlCustomContent
            // 
            this.pnlCustomContent.Controls.Add(this.btnContentBrowse);
            this.pnlCustomContent.Controls.Add(this.txtbxContentPath);
            this.pnlCustomContent.Controls.Add(this.lblCustomContent);
            this.pnlCustomContent.Controls.Add(this.chkbxUsingCustomContent);
            this.pnlCustomContent.Location = new System.Drawing.Point(359, 109);
            this.pnlCustomContent.Name = "pnlCustomContent";
            this.pnlCustomContent.Size = new System.Drawing.Size(350, 100);
            this.pnlCustomContent.TabIndex = 6;
            // 
            // btnContentBrowse
            // 
            this.btnContentBrowse.Location = new System.Drawing.Point(263, 42);
            this.btnContentBrowse.Name = "btnContentBrowse";
            this.btnContentBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnContentBrowse.TabIndex = 5;
            this.btnContentBrowse.Text = "Browse...";
            this.btnContentBrowse.UseVisualStyleBackColor = true;
            this.btnContentBrowse.Click += new System.EventHandler(this.btnContentBrowse_Click);
            // 
            // txtbxContentPath
            // 
            this.txtbxContentPath.Location = new System.Drawing.Point(6, 44);
            this.txtbxContentPath.Name = "txtbxContentPath";
            this.txtbxContentPath.Size = new System.Drawing.Size(250, 20);
            this.txtbxContentPath.TabIndex = 4;
            this.txtbxContentPath.TextChanged += new System.EventHandler(this.txtbxContentPath_TextChanged);
            // 
            // lblCustomContent
            // 
            this.lblCustomContent.AutoSize = true;
            this.lblCustomContent.Location = new System.Drawing.Point(3, 0);
            this.lblCustomContent.Name = "lblCustomContent";
            this.lblCustomContent.Size = new System.Drawing.Size(252, 13);
            this.lblCustomContent.TabIndex = 0;
            this.lblCustomContent.Text = "Custom Content (DOES NOT DO ANYTHING YET):";
            // 
            // chkbxUsingCustomContent
            // 
            this.chkbxUsingCustomContent.AutoSize = true;
            this.chkbxUsingCustomContent.Location = new System.Drawing.Point(6, 20);
            this.chkbxUsingCustomContent.Name = "chkbxUsingCustomContent";
            this.chkbxUsingCustomContent.Size = new System.Drawing.Size(137, 17);
            this.chkbxUsingCustomContent.TabIndex = 3;
            this.chkbxUsingCustomContent.Text = "Using Custom Content?";
            this.chkbxUsingCustomContent.UseVisualStyleBackColor = true;
            this.chkbxUsingCustomContent.CheckedChanged += new System.EventHandler(this.chkbxUsingCustomContent_CheckedChanged);
            // 
            // pnlMainFolder
            // 
            this.pnlMainFolder.Controls.Add(this.btnDesktopPath);
            this.pnlMainFolder.Controls.Add(this.txtbxFilePath);
            this.pnlMainFolder.Controls.Add(this.lblBrowse);
            this.pnlMainFolder.Controls.Add(this.btnBrowse);
            this.pnlMainFolder.Location = new System.Drawing.Point(3, 3);
            this.pnlMainFolder.Name = "pnlMainFolder";
            this.pnlMainFolder.Size = new System.Drawing.Size(353, 100);
            this.pnlMainFolder.TabIndex = 5;
            // 
            // btnDesktopPath
            // 
            this.btnDesktopPath.Location = new System.Drawing.Point(106, 41);
            this.btnDesktopPath.Name = "btnDesktopPath";
            this.btnDesktopPath.Size = new System.Drawing.Size(100, 24);
            this.btnDesktopPath.TabIndex = 3;
            this.btnDesktopPath.Text = "Use Desktop";
            this.btnDesktopPath.UseVisualStyleBackColor = true;
            this.btnDesktopPath.Click += new System.EventHandler(this.btnDesktopPath_Click);
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Location = new System.Drawing.Point(6, 16);
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.Size = new System.Drawing.Size(250, 20);
            this.txtbxFilePath.TabIndex = 0;
            this.txtbxFilePath.TextChanged += new System.EventHandler(this.txtbxFilePath_TextChanged);
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Location = new System.Drawing.Point(3, 0);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(205, 13);
            this.lblBrowse.TabIndex = 1;
            this.lblBrowse.Text = "Select A Folder To Store Map (Required!):";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(262, 14);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // GMPPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GMPPH";
            this.Text = "GMod Pre-Publishing Helper 0.2.7";
            this.pnlMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpbxTags.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCustomThumbnail.ResumeLayout(false);
            this.pnlCustomThumbnail.PerformLayout();
            this.pnlCustomContent.ResumeLayout(false);
            this.pnlCustomContent.PerformLayout();
            this.pnlMainFolder.ResumeLayout(false);
            this.pnlMainFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblBrowse;
        private System.Windows.Forms.TextBox txtbxFilePath;
        private System.Windows.Forms.CheckBox chkbxUsingCustomContent;
        private System.Windows.Forms.CheckBox chkbxUsingThumbnail;
        private System.Windows.Forms.Panel pnlCustomThumbnail;
        private System.Windows.Forms.Label lblCustomThumbnail;
        private System.Windows.Forms.Panel pnlCustomContent;
        private System.Windows.Forms.Label lblCustomContent;
        private System.Windows.Forms.Panel pnlMainFolder;
        private System.Windows.Forms.Button btnContentBrowse;
        private System.Windows.Forms.TextBox txtbxContentPath;
        private System.Windows.Forms.Button btnThumbnailBrowse;
        private System.Windows.Forms.TextBox txtbxThumbnailPath;
        private System.Windows.Forms.Label lblImageWarning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMapFile;
        private System.Windows.Forms.Button btnMapFileBrowse;
        private System.Windows.Forms.Label lblMapFileInfo;
        private System.Windows.Forms.TextBox txtbxMapPath;
        private System.Windows.Forms.Button btnDesktopPath;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lblMapNameInfo;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGmad;
        private System.Windows.Forms.TextBox txtbxGmadPath;
        private System.Windows.Forms.Button btnBrowseGmad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblJson;
        private System.Windows.Forms.GroupBox grpbxTags;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateDirectories;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Button btnDefaultGmadPath;
        private System.Windows.Forms.CheckedListBox clbTags;
    }
}

