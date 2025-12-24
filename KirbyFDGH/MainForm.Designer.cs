namespace KirbyFDGH
{
    partial class MainForm
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            xBINSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            endiannessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bigEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            littleEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            xBINVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            version2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            version4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fdgVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            sceneListContainer = new System.Windows.Forms.SplitContainer();
            sceneList = new System.Windows.Forms.ListBox();
            addScene = new System.Windows.Forms.Button();
            removeScene = new System.Windows.Forms.Button();
            sceneSplitContainer = new System.Windows.Forms.SplitContainer();
            sceneName = new System.Windows.Forms.TextBox();
            isPublic = new System.Windows.Forms.CheckBox();
            tabControl2 = new System.Windows.Forms.TabControl();
            assetGroup1Tab = new System.Windows.Forms.TabPage();
            depsSplitContainer = new System.Windows.Forms.SplitContainer();
            depsList = new System.Windows.Forms.ListBox();
            ag1Add = new System.Windows.Forms.Button();
            ag1Remove = new System.Windows.Forms.Button();
            assetGroup2Tab = new System.Windows.Forms.TabPage();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            assetList = new System.Windows.Forms.ListBox();
            ag2Add = new System.Windows.Forms.Button();
            ag2Remove = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sceneListContainer).BeginInit();
            sceneListContainer.Panel1.SuspendLayout();
            sceneListContainer.Panel2.SuspendLayout();
            sceneListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sceneSplitContainer).BeginInit();
            sceneSplitContainer.Panel1.SuspendLayout();
            sceneSplitContainer.Panel2.SuspendLayout();
            sceneSplitContainer.SuspendLayout();
            tabControl2.SuspendLayout();
            assetGroup1Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depsSplitContainer).BeginInit();
            depsSplitContainer.Panel1.SuspendLayout();
            depsSplitContainer.Panel2.SuspendLayout();
            depsSplitContainer.SuspendLayout();
            assetGroup2Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, xBINSettingsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(974, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // xBINSettingsToolStripMenuItem
            // 
            xBINSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { endiannessToolStripMenuItem, xBINVersionToolStripMenuItem, fdgVersionToolStripMenuItem });
            xBINSettingsToolStripMenuItem.Name = "xBINSettingsToolStripMenuItem";
            xBINSettingsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            xBINSettingsToolStripMenuItem.Text = "XBIN Settings";
            // 
            // endiannessToolStripMenuItem
            // 
            endiannessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bigEndianToolStripMenuItem, littleEndianToolStripMenuItem });
            endiannessToolStripMenuItem.Name = "endiannessToolStripMenuItem";
            endiannessToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            endiannessToolStripMenuItem.Text = "Endianness";
            // 
            // bigEndianToolStripMenuItem
            // 
            bigEndianToolStripMenuItem.Name = "bigEndianToolStripMenuItem";
            bigEndianToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            bigEndianToolStripMenuItem.Text = "Big Endian";
            bigEndianToolStripMenuItem.Click += bigEndianToolStripMenuItem_Click;
            // 
            // littleEndianToolStripMenuItem
            // 
            littleEndianToolStripMenuItem.Name = "littleEndianToolStripMenuItem";
            littleEndianToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            littleEndianToolStripMenuItem.Text = "Little Endian";
            littleEndianToolStripMenuItem.Click += littleEndianToolStripMenuItem_Click;
            // 
            // xBINVersionToolStripMenuItem
            // 
            xBINVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { version2ToolStripMenuItem, version4ToolStripMenuItem });
            xBINVersionToolStripMenuItem.Name = "xBINVersionToolStripMenuItem";
            xBINVersionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            xBINVersionToolStripMenuItem.Text = "XData Version";
            // 
            // version2ToolStripMenuItem
            // 
            version2ToolStripMenuItem.Name = "version2ToolStripMenuItem";
            version2ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            version2ToolStripMenuItem.Text = "Version 2 (RtDL to KPR)";
            version2ToolStripMenuItem.Click += version2ToolStripMenuItem_Click;
            // 
            // version4ToolStripMenuItem
            // 
            version4ToolStripMenuItem.Name = "version4ToolStripMenuItem";
            version4ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            version4ToolStripMenuItem.Text = "Version 4 (KBR+)";
            version4ToolStripMenuItem.Click += version4ToolStripMenuItem_Click;
            // 
            // fdgVersionToolStripMenuItem
            // 
            fdgVersionToolStripMenuItem.Name = "fdgVersionToolStripMenuItem";
            fdgVersionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            fdgVersionToolStripMenuItem.Text = "FDG Version 3";
            fdgVersionToolStripMenuItem.Click += fdgVersionToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(sceneListContainer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(sceneSplitContainer);
            splitContainer1.Size = new System.Drawing.Size(974, 553);
            splitContainer1.SplitterDistance = 478;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 5;
            // 
            // sceneListContainer
            // 
            sceneListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            sceneListContainer.Location = new System.Drawing.Point(0, 0);
            sceneListContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sceneListContainer.Name = "sceneListContainer";
            sceneListContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sceneListContainer.Panel1
            // 
            sceneListContainer.Panel1.Controls.Add(sceneList);
            // 
            // sceneListContainer.Panel2
            // 
            sceneListContainer.Panel2.Controls.Add(addScene);
            sceneListContainer.Panel2.Controls.Add(removeScene);
            sceneListContainer.Size = new System.Drawing.Size(478, 553);
            sceneListContainer.SplitterDistance = 498;
            sceneListContainer.SplitterWidth = 5;
            sceneListContainer.TabIndex = 4;
            // 
            // sceneList
            // 
            sceneList.Dock = System.Windows.Forms.DockStyle.Fill;
            sceneList.FormattingEnabled = true;
            sceneList.ItemHeight = 15;
            sceneList.Location = new System.Drawing.Point(0, 0);
            sceneList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sceneList.Name = "sceneList";
            sceneList.Size = new System.Drawing.Size(478, 498);
            sceneList.TabIndex = 0;
            sceneList.SelectedIndexChanged += sceneList_SelectedIndexChanged;
            // 
            // addScene
            // 
            addScene.Location = new System.Drawing.Point(4, 3);
            addScene.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addScene.Name = "addScene";
            addScene.Size = new System.Drawing.Size(110, 36);
            addScene.TabIndex = 2;
            addScene.Text = "Add";
            addScene.UseVisualStyleBackColor = true;
            addScene.Click += addScene_Click;
            // 
            // removeScene
            // 
            removeScene.Location = new System.Drawing.Point(120, 3);
            removeScene.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            removeScene.Name = "removeScene";
            removeScene.Size = new System.Drawing.Size(110, 36);
            removeScene.TabIndex = 3;
            removeScene.Text = "Remove";
            removeScene.UseVisualStyleBackColor = true;
            removeScene.Click += removeScene_Click;
            // 
            // sceneSplitContainer
            // 
            sceneSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            sceneSplitContainer.Location = new System.Drawing.Point(0, 0);
            sceneSplitContainer.Name = "sceneSplitContainer";
            sceneSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sceneSplitContainer.Panel1
            // 
            sceneSplitContainer.Panel1.Controls.Add(sceneName);
            sceneSplitContainer.Panel1.Controls.Add(isPublic);
            // 
            // sceneSplitContainer.Panel2
            // 
            sceneSplitContainer.Panel2.Controls.Add(tabControl2);
            sceneSplitContainer.Size = new System.Drawing.Size(491, 553);
            sceneSplitContainer.SplitterDistance = 26;
            sceneSplitContainer.TabIndex = 5;
            // 
            // sceneName
            // 
            sceneName.Location = new System.Drawing.Point(3, 0);
            sceneName.Name = "sceneName";
            sceneName.Size = new System.Drawing.Size(411, 23);
            sceneName.TabIndex = 1;
            sceneName.TextChanged += sceneName_TextChanged;
            // 
            // isPublic
            // 
            isPublic.AutoSize = true;
            isPublic.Location = new System.Drawing.Point(420, 4);
            isPublic.Name = "isPublic";
            isPublic.Size = new System.Drawing.Size(59, 19);
            isPublic.TabIndex = 0;
            isPublic.Text = "Public";
            isPublic.UseVisualStyleBackColor = true;
            isPublic.CheckedChanged += isPublic_CheckedChanged;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(assetGroup1Tab);
            tabControl2.Controls.Add(assetGroup2Tab);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(0, 0);
            tabControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(491, 523);
            tabControl2.TabIndex = 4;
            // 
            // assetGroup1Tab
            // 
            assetGroup1Tab.Controls.Add(depsSplitContainer);
            assetGroup1Tab.Location = new System.Drawing.Point(4, 24);
            assetGroup1Tab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            assetGroup1Tab.Name = "assetGroup1Tab";
            assetGroup1Tab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            assetGroup1Tab.Size = new System.Drawing.Size(483, 495);
            assetGroup1Tab.TabIndex = 0;
            assetGroup1Tab.Text = "Dependencies";
            assetGroup1Tab.UseVisualStyleBackColor = true;
            // 
            // depsSplitContainer
            // 
            depsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            depsSplitContainer.Location = new System.Drawing.Point(4, 3);
            depsSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            depsSplitContainer.Name = "depsSplitContainer";
            depsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // depsSplitContainer.Panel1
            // 
            depsSplitContainer.Panel1.Controls.Add(depsList);
            // 
            // depsSplitContainer.Panel2
            // 
            depsSplitContainer.Panel2.Controls.Add(ag1Add);
            depsSplitContainer.Panel2.Controls.Add(ag1Remove);
            depsSplitContainer.Size = new System.Drawing.Size(475, 489);
            depsSplitContainer.SplitterDistance = 435;
            depsSplitContainer.SplitterWidth = 5;
            depsSplitContainer.TabIndex = 6;
            // 
            // depsList
            // 
            depsList.Dock = System.Windows.Forms.DockStyle.Fill;
            depsList.FormattingEnabled = true;
            depsList.ItemHeight = 15;
            depsList.Location = new System.Drawing.Point(0, 0);
            depsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            depsList.Name = "depsList";
            depsList.Size = new System.Drawing.Size(475, 435);
            depsList.TabIndex = 0;
            depsList.MouseDoubleClick += depsList_MouseDoubleClick;
            // 
            // ag1Add
            // 
            ag1Add.Location = new System.Drawing.Point(4, 3);
            ag1Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ag1Add.Name = "ag1Add";
            ag1Add.Size = new System.Drawing.Size(110, 36);
            ag1Add.TabIndex = 4;
            ag1Add.Text = "Add";
            ag1Add.UseVisualStyleBackColor = true;
            ag1Add.Click += depAdd_Click;
            // 
            // ag1Remove
            // 
            ag1Remove.Location = new System.Drawing.Point(120, 3);
            ag1Remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ag1Remove.Name = "ag1Remove";
            ag1Remove.Size = new System.Drawing.Size(110, 36);
            ag1Remove.TabIndex = 5;
            ag1Remove.Text = "Remove";
            ag1Remove.UseVisualStyleBackColor = true;
            ag1Remove.Click += depRemove_Click;
            // 
            // assetGroup2Tab
            // 
            assetGroup2Tab.Controls.Add(splitContainer2);
            assetGroup2Tab.Location = new System.Drawing.Point(4, 24);
            assetGroup2Tab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            assetGroup2Tab.Name = "assetGroup2Tab";
            assetGroup2Tab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            assetGroup2Tab.Size = new System.Drawing.Size(483, 495);
            assetGroup2Tab.TabIndex = 1;
            assetGroup2Tab.Text = "Asset List";
            assetGroup2Tab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(4, 3);
            splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(assetList);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(ag2Add);
            splitContainer2.Panel2.Controls.Add(ag2Remove);
            splitContainer2.Size = new System.Drawing.Size(475, 489);
            splitContainer2.SplitterDistance = 435;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 9;
            // 
            // assetList
            // 
            assetList.Dock = System.Windows.Forms.DockStyle.Fill;
            assetList.FormattingEnabled = true;
            assetList.ItemHeight = 15;
            assetList.Location = new System.Drawing.Point(0, 0);
            assetList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            assetList.Name = "assetList";
            assetList.Size = new System.Drawing.Size(475, 435);
            assetList.TabIndex = 6;
            // 
            // ag2Add
            // 
            ag2Add.Location = new System.Drawing.Point(4, 3);
            ag2Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ag2Add.Name = "ag2Add";
            ag2Add.Size = new System.Drawing.Size(110, 36);
            ag2Add.TabIndex = 7;
            ag2Add.Text = "Add";
            ag2Add.UseVisualStyleBackColor = true;
            ag2Add.Click += fileAdd_Click;
            // 
            // ag2Remove
            // 
            ag2Remove.Location = new System.Drawing.Point(121, 3);
            ag2Remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ag2Remove.Name = "ag2Remove";
            ag2Remove.Size = new System.Drawing.Size(110, 36);
            ag2Remove.TabIndex = 8;
            ag2Remove.Text = "Remove";
            ag2Remove.UseVisualStyleBackColor = true;
            ag2Remove.Click += fileRemove_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(974, 553);
            panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(974, 577);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kirby FDG Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            sceneListContainer.Panel1.ResumeLayout(false);
            sceneListContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sceneListContainer).EndInit();
            sceneListContainer.ResumeLayout(false);
            sceneSplitContainer.Panel1.ResumeLayout(false);
            sceneSplitContainer.Panel1.PerformLayout();
            sceneSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sceneSplitContainer).EndInit();
            sceneSplitContainer.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            assetGroup1Tab.ResumeLayout(false);
            depsSplitContainer.Panel1.ResumeLayout(false);
            depsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)depsSplitContainer).EndInit();
            depsSplitContainer.ResumeLayout(false);
            assetGroup2Tab.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button removeScene;
        private System.Windows.Forms.Button addScene;
        private System.Windows.Forms.ListBox sceneList;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage assetGroup1Tab;
        private System.Windows.Forms.Button ag1Remove;
        private System.Windows.Forms.Button ag1Add;
        private System.Windows.Forms.ListBox depsList;
        private System.Windows.Forms.TabPage assetGroup2Tab;
        private System.Windows.Forms.Button ag2Remove;
        private System.Windows.Forms.Button ag2Add;
        private System.Windows.Forms.ListBox assetList;
        private System.Windows.Forms.ToolStripMenuItem xBINSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endiannessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littleEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xBINVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version4ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer sceneListContainer;
        private System.Windows.Forms.SplitContainer depsSplitContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer sceneSplitContainer;
        private System.Windows.Forms.TextBox sceneName;
        private System.Windows.Forms.CheckBox isPublic;
        private System.Windows.Forms.ToolStripMenuItem fdgVersionToolStripMenuItem;
    }
}

