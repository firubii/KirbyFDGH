using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KirbyLib;
using KirbyLib.IO;

namespace KirbyFDGH
{
    public partial class MainForm : Form
    {
        string filepath;
        FDG fdg;

        bool isLoading;

        public MainForm()
        {
            InitializeComponent();
        }

        public void RefreshLists()
        {
            isLoading = true;

            int lastSelected = sceneList.SelectedIndex;

            sceneList.Items.Clear();
            sceneList.BeginUpdate();

            for (int i = 0; i < fdg.Scenes.Count; i++)
                sceneList.Items.Add(fdg[i].Name);

            sceneList.SelectedIndex = lastSelected < sceneList.Items.Count ? lastSelected : -1;

            sceneList.EndUpdate();

            isLoading = false;

            RefreshSceneInfo();
        }

        public void RefreshSceneInfo()
        {
            isLoading = true;

            depsList.Items.Clear();
            assetList.Items.Clear();
            depsList.BeginUpdate();
            assetList.BeginUpdate();

            if (sceneList.SelectedIndex >= 0 && sceneList.SelectedIndex < fdg.Scenes.Count)
            {
                FDG.Scene scene = fdg[sceneList.SelectedIndex];
                sceneName.Text = scene.Name;
                isPublic.Checked = scene.Public;

                for (int i = 0; i < scene.Dependencies.Count; i++)
                    depsList.Items.Add(scene.Dependencies[i].Name);

                for (int i = 0; i < scene.Assets.Count; i++)
                    assetList.Items.Add(scene.Assets[i]);
            }

            depsList.EndUpdate();
            assetList.EndUpdate();

            isLoading = false;
        }

        public void Save()
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            using (FileStream stream = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(stream))
                fdg.Write(writer);

            this.Enabled = true;
            this.Cursor = Cursors.Arrow;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "FDG Files|*.dat";
            open.CheckFileExists = true;
            open.Multiselect = false;
            open.Title = "Select an FDG File";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filepath = open.FileName;
                using (FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                using (EndianBinaryReader reader = new EndianBinaryReader(stream))
                    fdg = new FDG(reader);

                bigEndianToolStripMenuItem.Checked = fdg.XData.Endianness == Endianness.Big;
                littleEndianToolStripMenuItem.Checked = fdg.XData.Endianness == Endianness.Little;
                version2ToolStripMenuItem.Checked = fdg.XData.Version[0] == 2 && fdg.XData.Version[1] == 0;
                version4ToolStripMenuItem.Checked = fdg.XData.Version[0] == 4 && fdg.XData.Version[1] == 0;
                fdgVersionToolStripMenuItem.Checked = fdg.Version == 3;

                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;

                RefreshLists();
            }
        }

        private void addScene_Click(object sender, EventArgs e)
        {
            StringWindow strWindow = new StringWindow();
            if (strWindow.ShowDialog() == DialogResult.OK)
            {
                FDG.Scene scene = new()
                {
                    Name = strWindow.InputText
                };
                fdg.Scenes.Add(scene);

                RefreshLists();
            }
        }

        private void removeScene_Click(object sender, EventArgs e)
        {
            if (sceneList.SelectedItem != null
                && MessageBox.Show("KirbyFDG", "Are you sure? This cannot be undone.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var scene = fdg[sceneList.SelectedIndex];
                for (int i = 0; i < fdg.Scenes.Count; i++)
                {
                    var s = fdg[i];
                    for (int d = 0; d < s.Dependencies.Count; d++)
                    {
                        if (s.Dependencies[d].Name == scene.Name)
                        {
                            s.Dependencies.RemoveAt(d);
                            d--;
                        }
                    }
                }

                fdg.Scenes.RemoveAt(sceneList.SelectedIndex);
                sceneList.Items.RemoveAt(sceneList.SelectedIndex);
            }
        }

        private void depAdd_Click(object sender, EventArgs e)
        {
            if (sceneList.SelectedItem != null)
            {
                DropDownWindow dialog = new DropDownWindow(fdg.Scenes.Select(x => x.Name).ToArray());
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var scene = fdg[sceneList.SelectedIndex];
                    scene.Dependencies.Add(fdg[dialog.InputText]);
                    depsList.Items.Add(dialog.InputText);
                }
            }
        }

        private void depRemove_Click(object sender, EventArgs e)
        {
            if (depsList.SelectedItem != null)
            {
                var scene = fdg[sceneList.SelectedIndex];
                scene.Dependencies.RemoveAt(depsList.SelectedIndex);
                depsList.Items.RemoveAt(depsList.SelectedIndex);
            }
        }

        private void fileAdd_Click(object sender, EventArgs e)
        {
            if (sceneList.SelectedItem != null)
            {
                StringWindow dialog = new StringWindow();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var scene = fdg[sceneList.SelectedIndex];
                    scene.Assets.Add(dialog.InputText);
                    assetList.Items.Add(dialog.InputText);
                }
            }
        }

        private void fileRemove_Click(object sender, EventArgs e)
        {
            if (assetList.SelectedItem != null)
            {
                var scene = fdg[sceneList.SelectedIndex];
                scene.Assets.RemoveAt(assetList.SelectedIndex);
                assetList.Items.RemoveAt(assetList.SelectedIndex);
            }
        }

        private void sceneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSceneInfo();
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
            save.Filter = "FDG Data Files|*.dat";
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
                fdg.XData.Endianness = Endianness.Big;
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
                fdg.XData.Endianness = Endianness.Little;
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
                fdg.XData.Version = new byte[] { 2, 0 };
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
                fdg.XData.Version = new byte[] { 4, 0 };
                version4ToolStripMenuItem.Checked = true;
                version4ToolStripMenuItem.Enabled = false;
                version2ToolStripMenuItem.Checked = false;
                version2ToolStripMenuItem.Enabled = true;
            }
        }

        private void depsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string dep = depsList.SelectedItem.ToString();
            sceneList.SelectedIndex = sceneList.Items.IndexOf(dep);
        }

        private void fdgVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdgVersionToolStripMenuItem.Checked = !fdgVersionToolStripMenuItem.Checked;
            fdg.Version = fdgVersionToolStripMenuItem.Checked ? 3 : 2;
        }

        private void isPublic_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLoading && sceneList.SelectedItem != null)
                fdg[sceneList.SelectedIndex].Public = isPublic.Checked;
        }

        private void sceneName_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading && sceneList.SelectedItem != null)
            {
                var scene = fdg[sceneList.SelectedIndex];
                scene.Name = sceneName.Text;
                sceneList.Items[sceneList.SelectedIndex] = scene.Name;
            }
        }
    }
}
