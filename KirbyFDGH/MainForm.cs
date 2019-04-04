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
            ag1List.Items.Clear();
            ag2List.Items.Clear();
            stringList.Items.Clear();

            fileList.BeginUpdate();
            sceneList.BeginUpdate();
            ag1List.BeginUpdate();
            ag2List.BeginUpdate();
            stringList.BeginUpdate();

            for (int i = 0; i < archive.FileList.Count; i++)
            {
                fileList.Items.Add(archive.FileList[i]);
            }

            for (int i = 0; i < archive.SceneList.Count; i++)
            {
                sceneList.Items.Add(archive.SceneList[i].Name);
            }

            if (sceneList.SelectedItem != null)
            {
                for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].AssetGroup1.Count; i++)
                {
                    ag1List.Items.Add(archive.SceneList[sceneList.SelectedIndex].AssetGroup1[i]);
                }
                for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].AssetGroup2.Count; i++)
                {
                    ag2List.Items.Add(archive.SceneList[sceneList.SelectedIndex].AssetGroup2[i]);
                }
            }

            for (int i = 0; i < archive.StringList.Count; i++)
            {
                stringList.Items.Add(archive.StringList[i]);
            }

            fileList.SelectedIndex = fileSel;
            sceneList.SelectedIndex = sceneSel;
            stringList.SelectedIndex = stringSel;

            fileList.EndUpdate();
            sceneList.EndUpdate();
            ag1List.EndUpdate();
            ag2List.EndUpdate();
            stringList.EndUpdate();
        }

        public void RefreshAssetGroups()
        {
            ag1List.Items.Clear();
            ag2List.Items.Clear();
            ag1List.BeginUpdate();
            ag2List.BeginUpdate();
            for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].AssetGroup1.Count; i++)
            {
                ag1List.Items.Add(archive.SceneList[sceneList.SelectedIndex].AssetGroup1[i]);
            }
            for (int i = 0; i < archive.SceneList[sceneList.SelectedIndex].AssetGroup2.Count; i++)
            {
                ag2List.Items.Add(archive.SceneList[sceneList.SelectedIndex].AssetGroup2[i]);
            }
            ag1List.EndUpdate();
            ag2List.EndUpdate();
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
                scene.AssetGroup1 = new List<string>();
                scene.AssetGroup2 = new List<string>();
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
            ddWindow.options = archive.StringList.ToArray();
            if (ddWindow.ShowDialog() == DialogResult.OK)
            {
                FDGH.Scene scene = archive.SceneList[sceneList.SelectedIndex];
                List<string> ag = scene.AssetGroup1;
                ag.Add(ddWindow.input);
                scene.AssetGroup1 = ag;
                archive.SceneList[sceneList.SelectedIndex] = scene;
                ag1List.Items.Add(ddWindow.input);
            }
        }

        private void ag1Remove_Click(object sender, EventArgs e)
        {
            if (ag1List.SelectedItem != null)
            {
                archive.SceneList[sceneList.SelectedIndex].AssetGroup1.RemoveAt(ag1List.SelectedIndex);
                ag1List.Items.RemoveAt(ag1List.SelectedIndex);
            }
        }

        private void ag2Add_Click(object sender, EventArgs e)
        {
            DropDownWindow ddWindow = new DropDownWindow();
            ddWindow.options = archive.StringList.ToArray();
            if (ddWindow.ShowDialog() == DialogResult.OK)
            {
                FDGH.Scene scene = archive.SceneList[sceneList.SelectedIndex];
                List<string> ag = scene.AssetGroup2;
                ag.Add(ddWindow.input);
                scene.AssetGroup2 = ag;
                archive.SceneList[sceneList.SelectedIndex] = scene;
                ag2List.Items.Add(ddWindow.input);
            }
        }

        private void ag2Remove_Click(object sender, EventArgs e)
        {
            if (ag2List.SelectedItem != null)
            {
                archive.SceneList[sceneList.SelectedIndex].AssetGroup2.RemoveAt(ag2List.SelectedIndex);
                ag2List.Items.RemoveAt(ag2List.SelectedIndex);
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
            save.Title = "Specify where to save the file";
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
