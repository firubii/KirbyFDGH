using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirbyFDGH
{
    public partial class MainForm : Form
    {
        string filepath;
        FDGH archive;

        public MainForm()
        {
            InitializeComponent();
        }

        public void RefreshLists()
        {
            int fileSel = 0;
            int sceneSel = 0;
            int stringSel = 0;
            if (fileList.SelectedItem != null) fileSel = fileList.SelectedIndex;
            if (sceneList.SelectedItem != null) sceneSel = sceneList.SelectedIndex;
            if (stringList.SelectedItem != null) stringSel = stringList.SelectedIndex;

            fileList.Items.Clear();
            sceneList.Items.Clear();
            depsList.Items.Clear();
            assetList.Items.Clear();
            stringList.Items.Clear();

            fileList.BeginUpdate();
            sceneList.BeginUpdate();
            depsList.BeginUpdate();
            assetList.BeginUpdate();
            stringList.BeginUpdate();

            for (int i = 0; i < archive.FileList.Count; i++)
                fileList.Items.Add(archive.FileList[i]);

            for (int i = 0; i < archive.SceneList.Count; i++)
                sceneList.Items.Add(archive.SceneList[i].Name);

            if (sceneList.SelectedItem != null)
            {
                for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].Dependencies.Count; i++)
                    depsList.Items.Add(archive.SceneList[sceneList.SelectedIndex].Dependencies[i]);

                for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].AssetList.Count; i++)
                    assetList.Items.Add(archive.SceneList[sceneList.SelectedIndex].AssetList[i]);
            }

            for (int i = 0; i < archive.StringList.Count; i++)
                stringList.Items.Add(archive.StringList[i]);

            fileList.SelectedIndex = fileSel;
            sceneList.SelectedIndex = sceneSel;
            stringList.SelectedIndex = stringSel;

            fileList.EndUpdate();
            sceneList.EndUpdate();
            depsList.EndUpdate();
            assetList.EndUpdate();
            stringList.EndUpdate();
        }

        public void RefreshAssetGroups()
        {
            depsList.Items.Clear();
            assetList.Items.Clear();
            depsList.BeginUpdate();
            assetList.BeginUpdate();

            for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].Dependencies.Count; i++)
                depsList.Items.Add(archive.SceneList[sceneList.SelectedIndex].Dependencies[i]);

            for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].AssetList.Count; i++)
                assetList.Items.Add(archive.SceneList[sceneList.SelectedIndex].AssetList[i]);

            depsList.EndUpdate();
            assetList.EndUpdate();
        }

        public void Save()
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            archive.Write(filepath);

            this.Enabled = true;
            this.Cursor = Cursors.Arrow;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "FDGH Data Files|*.dat";
            open.CheckFileExists = true;
            open.Multiselect = false;
            open.Title = "Select an FDGH Data File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filepath = open.FileName;
                archive = new FDGH(filepath);

                RefreshLists();

                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                xBINSettingsToolStripMenuItem.Enabled = true;
                if (archive.Endianness == Endianness.Big)
                {
                    bigEndianToolStripMenuItem.Checked = true;
                    bigEndianToolStripMenuItem.Enabled = false;
                    littleEndianToolStripMenuItem.Checked = false;
                    littleEndianToolStripMenuItem.Enabled = true;
                }
                else
                {
                    bigEndianToolStripMenuItem.Checked = false;
                    bigEndianToolStripMenuItem.Enabled = true;
                    littleEndianToolStripMenuItem.Checked = true;
                    littleEndianToolStripMenuItem.Enabled = false;
                }
                if (archive.XbinVersion == 4)
                {
                    version4ToolStripMenuItem.Checked = true;
                    version4ToolStripMenuItem.Enabled = false;
                    version2ToolStripMenuItem.Checked = false;
                    version2ToolStripMenuItem.Enabled = true;
                }
                else
                {
                    version4ToolStripMenuItem.Checked = false;
                    version4ToolStripMenuItem.Enabled = true;
                    version2ToolStripMenuItem.Checked = true;
                    version2ToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            StringWindow strWindow = new StringWindow();
            if (strWindow.ShowDialog() == DialogResult.OK)
            {
                archive.FileList.Add(strWindow.input);
                archive.StringList.Add(strWindow.input);
                fileList.Items.Add(strWindow.input);
                stringList.Items.Add(strWindow.input);
            }
        }

        private void removeFile_Click(object sender, EventArgs e)
        {
            if (fileList.SelectedItem != null)
            {
                archive.FileList.RemoveAt(fileList.SelectedIndex);
                fileList.Items.RemoveAt(fileList.SelectedIndex);
            }
        }

        private void addScene_Click(object sender, EventArgs e)
        {
            StringWindow strWindow = new StringWindow();
            if (strWindow.ShowDialog() == DialogResult.OK)
            {
                FDGH.Scene scene = new FDGH.Scene();
                scene.Name = strWindow.input;
                scene.Dependencies = new List<string>();
                scene.AssetList = new List<string>();
                archive.SceneList.Add(scene);
                sceneList.Items.Add(strWindow.input);
            }
        }

        private void removeScene_Click(object sender, EventArgs e)
        {
            if (sceneList.SelectedItem != null)
            {
                archive.SceneList.RemoveAt(sceneList.SelectedIndex);
                sceneList.Items.RemoveAt(sceneList.SelectedIndex);
            }
        }

        private void ag1Add_Click(object sender, EventArgs e)
        {
            DropDownWindow ddWindow = new DropDownWindow();
            string[] options = new string[archive.SceneList.Count];
            for (int i = 0; i < options.Length; i++)
                options[i] = archive.SceneList[i].Name;
            ddWindow.options = options;

            if (ddWindow.ShowDialog() == DialogResult.OK)
            {
                FDGH.Scene scene = archive.SceneList[sceneList.SelectedIndex];
                List<string> ag = scene.Dependencies;
                ag.Add(ddWindow.input);
                scene.Dependencies = ag;
                archive.SceneList[sceneList.SelectedIndex] = scene;
                depsList.Items.Add(ddWindow.input);
            }
        }

        private void ag1Remove_Click(object sender, EventArgs e)
        {
            if (depsList.SelectedItem != null)
            {
                archive.SceneList[sceneList.SelectedIndex].Dependencies.RemoveAt(depsList.SelectedIndex);
                depsList.Items.RemoveAt(depsList.SelectedIndex);
            }
        }

        private void ag2Add_Click(object sender, EventArgs e)
        {
            DropDownWindow ddWindow = new DropDownWindow();
            ddWindow.options = archive.StringList.ToArray();
            if (ddWindow.ShowDialog() == DialogResult.OK)
            {
                FDGH.Scene scene = archive.SceneList[sceneList.SelectedIndex];
                List<string> ag = scene.AssetList;
                ag.Add(ddWindow.input);
                scene.AssetList = ag;
                archive.SceneList[sceneList.SelectedIndex] = scene;
                assetList.Items.Add(ddWindow.input);
            }
        }

        private void ag2Remove_Click(object sender, EventArgs e)
        {
            if (assetList.SelectedItem != null)
            {
                archive.SceneList[sceneList.SelectedIndex].AssetList.RemoveAt(assetList.SelectedIndex);
                assetList.Items.RemoveAt(assetList.SelectedIndex);
            }
        }

        private void sceneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAssetGroups();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.DefaultExt = ".dat";
            save.Filter = "FDGH Data Files|*.dat";
            save.Title = "Save As";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filepath = save.FileName;
                Save();
            }
        }

        private void bigEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!bigEndianToolStripMenuItem.Checked)
            {
                archive.Endianness = Endianness.Big;
                bigEndianToolStripMenuItem.Enabled = false;
                bigEndianToolStripMenuItem.Checked = true;
                littleEndianToolStripMenuItem.Checked = false;
                littleEndianToolStripMenuItem.Enabled = true;
            }
        }

        private void littleEndianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!littleEndianToolStripMenuItem.Checked)
            {
                archive.Endianness = Endianness.Little;
                bigEndianToolStripMenuItem.Enabled = true;
                bigEndianToolStripMenuItem.Checked = false;
                littleEndianToolStripMenuItem.Checked = true;
                littleEndianToolStripMenuItem.Enabled = false;
            }
        }

        private void version2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!version2ToolStripMenuItem.Checked)
            {
                archive.XbinVersion = 2;
                version4ToolStripMenuItem.Checked = false;
                version4ToolStripMenuItem.Enabled = true;
                version2ToolStripMenuItem.Checked = true;
                version2ToolStripMenuItem.Enabled = false;
            }
        }

        private void version4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!version4ToolStripMenuItem.Checked)
            {
                archive.XbinVersion = 4;
                version4ToolStripMenuItem.Checked = true;
                version4ToolStripMenuItem.Enabled = false;
                version2ToolStripMenuItem.Checked = false;
                version2ToolStripMenuItem.Enabled = true;
            }
        }
    }
}
