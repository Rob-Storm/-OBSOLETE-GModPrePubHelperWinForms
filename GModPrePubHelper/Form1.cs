using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace GModPrePubHelper
{

    public partial class GMPPH : Form
    {
        /*
        UI Prefix name reference
        -------------------------
        lbl - label
        btn - button
        chkbx - checkbox
        clb - checklist box
        grpbx - group box
        -------------------------
        */


        //Variables N Shit

        //Directories
        public string folderPath, contentPath, thumbnailPath, mapPath, gmadPath;

        public string mapName;

        //Optional Stuff
        public bool usingCustomContent, usingThumbnail, imageValid, usingName = false;

        //JSON Shit

        public string[] addonTags = new string[2];


        public GMPPH()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            chkbxUsingCustomContent.Enabled = false;

            txtbxContentPath.Enabled = false;
            txtbxThumbnailPath.Enabled = false;

            btnContentBrowse.Enabled = false;
            btnThumbnailBrowse.Enabled = false;

        }


        //Select Folder To Store all of this stuff
        private void txtbxFilePath_TextChanged(object sender, EventArgs e)
        {
            folderPath = txtbxFilePath.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ValidateNames = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = false;

            openFileDialog.FileName = "Folder Selection";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                //Would rather use this than the stupid folder selection dialogue
                //I prefer using file explorer rather than that drop down only crap
                //should be easier for the user to select a folder

                int pathLength;

                folderPath = openFileDialog.FileName;
                pathLength = folderPath.Length - 17;
                folderPath = folderPath.Remove(pathLength, 17);

                txtbxFilePath.Text = folderPath;
            }
        }

        private void btnDesktopPath_Click(object sender, EventArgs e)
        {
            string desktopFolder;

            desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            folderPath = desktopFolder;
            txtbxFilePath.Text = folderPath;

        }


        //Custom Content

        private void chkbxUsingCustomContent_CheckedChanged(object sender, EventArgs e)
        {
            usingCustomContent = chkbxUsingCustomContent.Checked;

            if (usingCustomContent)
            {
                txtbxContentPath.Enabled = true;
                btnContentBrowse.Enabled = true;
            }

            else
            {
                txtbxContentPath.Enabled = false;
                btnContentBrowse.Enabled = false;
            }
        }
        private void txtbxContentPath_TextChanged(object sender, EventArgs e)
        {
            contentPath = txtbxContentPath.Text;
        }
        private void btnContentBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.ValidateNames = false;
            openFileDialog2.CheckFileExists = false;
            openFileDialog2.CheckPathExists = false;

            openFileDialog2.FileName = "Folder Selection";

            DialogResult result2 = openFileDialog2.ShowDialog();

            if (result2 == DialogResult.OK)
            {
                //Same hacky terribleness as before
                //works fine for me!

                int cPathLength;

                contentPath = openFileDialog2.FileName;

                cPathLength = contentPath.Length - 17;
                contentPath = contentPath.Remove(cPathLength, 17);
                txtbxContentPath.Text = contentPath;
            }
        }


        //Custom Thumbnail

        private void chkbxUsingThumbnail_CheckedChanged(object sender, EventArgs e)
        {
            usingThumbnail = chkbxUsingThumbnail.Checked;

            if (usingThumbnail)
            {
                txtbxThumbnailPath.Enabled = true;
                btnThumbnailBrowse.Enabled = true;
            }

            else
            {
                txtbxThumbnailPath.Enabled = false;
                btnThumbnailBrowse.Enabled = false;
            }
        }
        private void txtbxThumbnailPath_TextChanged(object sender, EventArgs e)
        {
            thumbnailPath = txtbxThumbnailPath.Text;

            if (File.Exists(thumbnailPath))
            {
                IMGChecker(thumbnailPath);
            }
        }
        private void btnThumbnailBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.DefaultExt = ".png";
            openFileDialog3.Filter = "Image Files|*.png";

            DialogResult result3 = openFileDialog3.ShowDialog();

            if (result3 == DialogResult.OK)
            {
                thumbnailPath = openFileDialog3.FileName;
                txtbxThumbnailPath.Text = thumbnailPath;
                IMGChecker(thumbnailPath);
            }
        }

        void IMGChecker(string imagePath)
        {
            var thumb = Image.FromFile(imagePath);

            if (thumb.Width != 128 || thumb.Height != 128)
            {
                imageValid = false;
                lblImageWarning.Text = "Image resolution is not valid! Use 128x128!";
            }

            else
            {
                imageValid = true;
                lblImageWarning.Text = "Image is valid!";
            }
        }

        //Map File
        private void txtbxMapPath_TextChanged(object sender, EventArgs e)
        {
            mapPath = txtbxMapPath.Text;
        }
        private void btnMapFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog4 = new OpenFileDialog();
            openFileDialog4.DefaultExt = ".bsp";
            openFileDialog4.Filter = "Compiled Map Files|*.bsp";

            DialogResult result4 = openFileDialog4.ShowDialog();

            if (result4 == DialogResult.OK)
            {
                mapPath = openFileDialog4.FileName;
                txtbxMapPath.Text = mapPath;
            }
        }


        //Map Name
        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            mapName = txtbxName.Text;
        }


        //GMAD.exe
        private void btnBrowseGmad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog5 = new OpenFileDialog();
            openFileDialog5.DefaultExt = ".exe";
            openFileDialog5.Filter = "Executable Files|*.exe";

            DialogResult result5 = openFileDialog5.ShowDialog();

            if (result5 == DialogResult.OK)
            {
                gmadPath = openFileDialog5.FileName;
                txtbxGmadPath.Text = gmadPath;
            }
        }
        private void txtbxGmadPath_TextChanged(object sender, EventArgs e)
        {
            gmadPath = txtbxGmadPath.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/The1Wolfcast/GModPrePubHelper#readme");
        }

        private void btnDefaultGmadPath_Click(object sender, EventArgs e)
        {
            gmadPath = @"C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\bin\gmad.exe";

            txtbxGmadPath.Text = gmadPath;
        }


        //JSON Tags
        private void clbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //Create Directories
        private void btnCreateDirectories_Click(object sender, EventArgs e)
        {
            FolderSetup(folderPath, mapPath, thumbnailPath, mapName, gmadPath, usingThumbnail);
        }


        //Actually Do The Stuff
        //
        //
        //Yay

        public void FolderSetup(string rootDir, string mapDir, string thumbnailDir, string mapName, string gmadDir, bool usingThumbnail)
        {
            //I DONT CARE IF ITS MESSY THE ENDS JUSTIFY THE MEANS GODDAMNNIT

            if (rootDir == null || mapDir == null || thumbnailDir == null && usingThumbnail || gmadPath == null || mapName == null)
            {
                lblGeneralInfo.Text = "One or more Directories are invalid!";

                return;
            }

            if (usingThumbnail && !imageValid)
            {
                lblGeneralInfo.Text = "Please use a valid image!";

                return;
            }

            if (clbTags.CheckedItems.Count > 2)
            {
                lblGeneralInfo.Text = "Please choose 2 tags at most!";

                return;
            }

            //Variables

            string rootFolder = rootDir + "/" + mapName;

            string mapsFolder = rootFolder + "/" + "maps";

            string mapFileTarget = mapsFolder + "/" + Path.GetFileName(mapDir);

            string thumbFolder = mapsFolder + "/" + "thumb";

            string customName = mapsFolder + "/" + mapName;

            string customThumb = thumbFolder + "/" + mapName;

            string addonFolder = rootDir;

            System.IO.Directory.CreateDirectory(rootFolder);
            System.IO.Directory.CreateDirectory(mapsFolder);

            System.IO.File.Copy(mapDir, mapFileTarget);

            System.IO.File.Move(mapFileTarget, customName + ".bsp");

            if (usingThumbnail)
            {
                System.IO.Directory.CreateDirectory(thumbFolder);
                System.IO.File.Copy(thumbnailDir, thumbFolder + "/" + Path.GetFileName(thumbnailDir));
                System.IO.File.Move(thumbFolder + "/" + Path.GetFileName(thumbnailDir), customThumb + ".png");
            }

            //WAY BETTER THAN WHAT I TRIED BEFOREHAND
            //thank you tim for this solution, you basically saved this project lol! https://stackoverflow.com/users/745969/tim


            //get json tags and put convert them to array

            List<string> checkedTags = new List<string>();

            for (int i = 0; i < clbTags.Items.Count; i++)
            {
                if (clbTags.GetItemChecked(i) && clbTags.CheckedItems.Count <= 2)
                {
                    checkedTags.Add(clbTags.GetItemText(clbTags.Items[i]));
                }
            }

            addonTags = checkedTags.ToArray();

            JSONCreation(rootFolder);

            GMACreation(addonFolder, gmadPath, rootFolder, rootDir);

            lblGeneralInfo.Text = "GMA File Created Successfully!";
        }


        //Addon.json Creation
        public void JSONCreation(string rootDirectory)
        {
            JSONFile jsonFile = new JSONFile();
            {
                jsonFile.title = mapName;

                jsonFile.type = "map";

                jsonFile.tags = addonTags;

                jsonFile.ignore = new List<string>()
                {
                    "*.psd",
                    "*.vcproj",
                    "*.svn*"
                };
            };

            string json = JsonConvert.SerializeObject(jsonFile, Formatting.Indented);

            File.WriteAllText(rootDirectory + "/" + "addon.json", json);
        }


        //GMAD.EXE Creation
        public void GMACreation(string addonPath, string gmadPath, string pathToFolder, string outFolder)
        {
            var process = Process.Start(gmadPath, "create " + "-folder " + pathToFolder);

            process.WaitForExit();
        }


        //TIMEOUT CORNER
        //Dont delete or else you fuck up the design page somehow???!!1
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }

    //My first time using json and it somehow ended up working in the end?
    public class JSONFile
    {
        public string title { get; set; }

        public string type { get; set; }

        public string[] tags { get; set; }

        public IList<string> ignore { get; set; }
        
    }
}