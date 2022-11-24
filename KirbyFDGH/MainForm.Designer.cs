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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xBINSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endiannessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.littleEndianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xBINVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fileListTab = new System.Windows.Forms.TabPage();
            this.removeFile = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.sceneListTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.assetGroup1Tab = new System.Windows.Forms.TabPage();
            this.ag1Remove = new System.Windows.Forms.Button();
            this.ag1Add = new System.Windows.Forms.Button();
            this.depsList = new System.Windows.Forms.ListBox();
            this.assetGroup2Tab = new System.Windows.Forms.TabPage();
            this.ag2Remove = new System.Windows.Forms.Button();
            this.ag2Add = new System.Windows.Forms.Button();
            this.assetList = new System.Windows.Forms.ListBox();
            this.removeScene = new System.Windows.Forms.Button();
            this.addScene = new System.Windows.Forms.Button();
            this.sceneList = new System.Windows.Forms.ListBox();
            this.stringListTab = new System.Windows.Forms.TabPage();
            this.stringList = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sceneListContainer = new System.Windows.Forms.SplitContainer();
            this.depsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.fileListTab.SuspendLayout();
            this.sceneListTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.assetGroup1Tab.SuspendLayout();
            this.assetGroup2Tab.SuspendLayout();
            this.stringListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sceneListContainer)).BeginInit();
            this.sceneListContainer.Panel1.SuspendLayout();
            this.sceneListContainer.Panel2.SuspendLayout();
            this.sceneListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depsSplitContainer)).BeginInit();
            this.depsSplitContainer.Panel1.SuspendLayout();
            this.depsSplitContainer.Panel2.SuspendLayout();
            this.depsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xBINSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // xBINSettingsToolStripMenuItem
            // 
            this.xBINSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endiannessToolStripMenuItem,
            this.xBINVersionToolStripMenuItem});
            this.xBINSettingsToolStripMenuItem.Name = "xBINSettingsToolStripMenuItem";
            this.xBINSettingsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.xBINSettingsToolStripMenuItem.Text = "XBIN Settings";
            // 
            // endiannessToolStripMenuItem
            // 
            this.endiannessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bigEndianToolStripMenuItem,
            this.littleEndianToolStripMenuItem});
            this.endiannessToolStripMenuItem.Name = "endiannessToolStripMenuItem";
            this.endiannessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endiannessToolStripMenuItem.Text = "Endianness";
            // 
            // bigEndianToolStripMenuItem
            // 
            this.bigEndianToolStripMenuItem.Name = "bigEndianToolStripMenuItem";
            this.bigEndianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bigEndianToolStripMenuItem.Text = "Big Endian";
            this.bigEndianToolStripMenuItem.Click += new System.EventHandler(this.bigEndianToolStripMenuItem_Click);
            // 
            // littleEndianToolStripMenuItem
            // 
            this.littleEndianToolStripMenuItem.Name = "littleEndianToolStripMenuItem";
            this.littleEndianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.littleEndianToolStripMenuItem.Text = "Little Endian";
            this.littleEndianToolStripMenuItem.Click += new System.EventHandler(this.littleEndianToolStripMenuItem_Click);
            // 
            // xBINVersionToolStripMenuItem
            // 
            this.xBINVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version2ToolStripMenuItem,
            this.version4ToolStripMenuItem});
            this.xBINVersionToolStripMenuItem.Name = "xBINVersionToolStripMenuItem";
            this.xBINVersionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xBINVersionToolStripMenuItem.Text = "XBIN Version";
            // 
            // version2ToolStripMenuItem
            // 
            this.version2ToolStripMenuItem.Name = "version2ToolStripMenuItem";
            this.version2ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.version2ToolStripMenuItem.Text = "Version 2 (RtDL to KPR)";
            this.version2ToolStripMenuItem.Click += new System.EventHandler(this.version2ToolStripMenuItem_Click);
            // 
            // version4ToolStripMenuItem
            // 
            this.version4ToolStripMenuItem.Name = "version4ToolStripMenuItem";
            this.version4ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.version4ToolStripMenuItem.Text = "Version 4 (KBR+)";
            this.version4ToolStripMenuItem.Click += new System.EventHandler(this.version4ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fileListTab);
            this.tabControl1.Controls.Add(this.sceneListTab);
            this.tabControl1.Controls.Add(this.stringListTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // fileListTab
            // 
            this.fileListTab.Controls.Add(this.splitContainer4);
            this.fileListTab.Location = new System.Drawing.Point(4, 22);
            this.fileListTab.Name = "fileListTab";
            this.fileListTab.Padding = new System.Windows.Forms.Padding(3);
            this.fileListTab.Size = new System.Drawing.Size(827, 450);
            this.fileListTab.TabIndex = 0;
            this.fileListTab.Text = "File List";
            this.fileListTab.UseVisualStyleBackColor = true;
            // 
            // removeFile
            // 
            this.removeFile.Location = new System.Drawing.Point(103, 3);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(94, 31);
            this.removeFile.TabIndex = 2;
            this.removeFile.Text = "Remove";
            this.removeFile.UseVisualStyleBackColor = true;
            this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(3, 3);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(94, 31);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Add";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // fileList
            // 
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(821, 398);
            this.fileList.TabIndex = 0;
            // 
            // sceneListTab
            // 
            this.sceneListTab.Controls.Add(this.splitContainer1);
            this.sceneListTab.Location = new System.Drawing.Point(4, 22);
            this.sceneListTab.Name = "sceneListTab";
            this.sceneListTab.Padding = new System.Windows.Forms.Padding(3);
            this.sceneListTab.Size = new System.Drawing.Size(827, 450);
            this.sceneListTab.TabIndex = 1;
            this.sceneListTab.Text = "Scene Data";
            this.sceneListTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.assetGroup1Tab);
            this.tabControl2.Controls.Add(this.assetGroup2Tab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(413, 444);
            this.tabControl2.TabIndex = 4;
            // 
            // assetGroup1Tab
            // 
            this.assetGroup1Tab.Controls.Add(this.depsSplitContainer);
            this.assetGroup1Tab.Location = new System.Drawing.Point(4, 22);
            this.assetGroup1Tab.Name = "assetGroup1Tab";
            this.assetGroup1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.assetGroup1Tab.Size = new System.Drawing.Size(405, 418);
            this.assetGroup1Tab.TabIndex = 0;
            this.assetGroup1Tab.Text = "Dependencies";
            this.assetGroup1Tab.UseVisualStyleBackColor = true;
            // 
            // ag1Remove
            // 
            this.ag1Remove.Location = new System.Drawing.Point(103, 3);
            this.ag1Remove.Name = "ag1Remove";
            this.ag1Remove.Size = new System.Drawing.Size(94, 31);
            this.ag1Remove.TabIndex = 5;
            this.ag1Remove.Text = "Remove";
            this.ag1Remove.UseVisualStyleBackColor = true;
            this.ag1Remove.Click += new System.EventHandler(this.ag1Remove_Click);
            // 
            // ag1Add
            // 
            this.ag1Add.Location = new System.Drawing.Point(3, 3);
            this.ag1Add.Name = "ag1Add";
            this.ag1Add.Size = new System.Drawing.Size(94, 31);
            this.ag1Add.TabIndex = 4;
            this.ag1Add.Text = "Add";
            this.ag1Add.UseVisualStyleBackColor = true;
            this.ag1Add.Click += new System.EventHandler(this.ag1Add_Click);
            // 
            // depsList
            // 
            this.depsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depsList.FormattingEnabled = true;
            this.depsList.Location = new System.Drawing.Point(0, 0);
            this.depsList.Name = "depsList";
            this.depsList.Size = new System.Drawing.Size(399, 367);
            this.depsList.TabIndex = 0;
            // 
            // assetGroup2Tab
            // 
            this.assetGroup2Tab.Controls.Add(this.splitContainer2);
            this.assetGroup2Tab.Location = new System.Drawing.Point(4, 22);
            this.assetGroup2Tab.Name = "assetGroup2Tab";
            this.assetGroup2Tab.Padding = new System.Windows.Forms.Padding(3);
            this.assetGroup2Tab.Size = new System.Drawing.Size(405, 418);
            this.assetGroup2Tab.TabIndex = 1;
            this.assetGroup2Tab.Text = "Asset List";
            this.assetGroup2Tab.UseVisualStyleBackColor = true;
            // 
            // ag2Remove
            // 
            this.ag2Remove.Location = new System.Drawing.Point(100, 4);
            this.ag2Remove.Name = "ag2Remove";
            this.ag2Remove.Size = new System.Drawing.Size(94, 31);
            this.ag2Remove.TabIndex = 8;
            this.ag2Remove.Text = "Remove";
            this.ag2Remove.UseVisualStyleBackColor = true;
            this.ag2Remove.Click += new System.EventHandler(this.ag2Remove_Click);
            // 
            // ag2Add
            // 
            this.ag2Add.Location = new System.Drawing.Point(0, 4);
            this.ag2Add.Name = "ag2Add";
            this.ag2Add.Size = new System.Drawing.Size(94, 31);
            this.ag2Add.TabIndex = 7;
            this.ag2Add.Text = "Add";
            this.ag2Add.UseVisualStyleBackColor = true;
            this.ag2Add.Click += new System.EventHandler(this.ag2Add_Click);
            // 
            // assetList
            // 
            this.assetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetList.FormattingEnabled = true;
            this.assetList.Location = new System.Drawing.Point(0, 0);
            this.assetList.Name = "assetList";
            this.assetList.Size = new System.Drawing.Size(399, 367);
            this.assetList.TabIndex = 6;
            // 
            // removeScene
            // 
            this.removeScene.Location = new System.Drawing.Point(103, 3);
            this.removeScene.Name = "removeScene";
            this.removeScene.Size = new System.Drawing.Size(94, 31);
            this.removeScene.TabIndex = 3;
            this.removeScene.Text = "Remove";
            this.removeScene.UseVisualStyleBackColor = true;
            this.removeScene.Click += new System.EventHandler(this.removeScene_Click);
            // 
            // addScene
            // 
            this.addScene.Location = new System.Drawing.Point(3, 3);
            this.addScene.Name = "addScene";
            this.addScene.Size = new System.Drawing.Size(94, 31);
            this.addScene.TabIndex = 2;
            this.addScene.Text = "Add";
            this.addScene.UseVisualStyleBackColor = true;
            this.addScene.Click += new System.EventHandler(this.addScene_Click);
            // 
            // sceneList
            // 
            this.sceneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneList.FormattingEnabled = true;
            this.sceneList.Location = new System.Drawing.Point(0, 0);
            this.sceneList.Name = "sceneList";
            this.sceneList.Size = new System.Drawing.Size(404, 403);
            this.sceneList.TabIndex = 0;
            this.sceneList.SelectedIndexChanged += new System.EventHandler(this.sceneList_SelectedIndexChanged);
            // 
            // stringListTab
            // 
            this.stringListTab.Controls.Add(this.stringList);
            this.stringListTab.Location = new System.Drawing.Point(4, 22);
            this.stringListTab.Name = "stringListTab";
            this.stringListTab.Size = new System.Drawing.Size(619, 361);
            this.stringListTab.TabIndex = 2;
            this.stringListTab.Text = "String List";
            this.stringListTab.UseVisualStyleBackColor = true;
            // 
            // stringList
            // 
            this.stringList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stringList.FormattingEnabled = true;
            this.stringList.Location = new System.Drawing.Point(0, 0);
            this.stringList.Name = "stringList";
            this.stringList.Size = new System.Drawing.Size(619, 361);
            this.stringList.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sceneListContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(821, 444);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.assetList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ag2Add);
            this.splitContainer2.Panel2.Controls.Add(this.ag2Remove);
            this.splitContainer2.Size = new System.Drawing.Size(399, 412);
            this.splitContainer2.SplitterDistance = 367;
            this.splitContainer2.TabIndex = 9;
            // 
            // sceneListContainer
            // 
            this.sceneListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneListContainer.Location = new System.Drawing.Point(0, 0);
            this.sceneListContainer.Name = "sceneListContainer";
            this.sceneListContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sceneListContainer.Panel1
            // 
            this.sceneListContainer.Panel1.Controls.Add(this.sceneList);
            // 
            // sceneListContainer.Panel2
            // 
            this.sceneListContainer.Panel2.Controls.Add(this.addScene);
            this.sceneListContainer.Panel2.Controls.Add(this.removeScene);
            this.sceneListContainer.Size = new System.Drawing.Size(404, 444);
            this.sceneListContainer.SplitterDistance = 403;
            this.sceneListContainer.TabIndex = 4;
            // 
            // depsSplitContainer
            // 
            this.depsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.depsSplitContainer.Name = "depsSplitContainer";
            this.depsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // depsSplitContainer.Panel1
            // 
            this.depsSplitContainer.Panel1.Controls.Add(this.depsList);
            // 
            // depsSplitContainer.Panel2
            // 
            this.depsSplitContainer.Panel2.Controls.Add(this.ag1Add);
            this.depsSplitContainer.Panel2.Controls.Add(this.ag1Remove);
            this.depsSplitContainer.Size = new System.Drawing.Size(399, 412);
            this.depsSplitContainer.SplitterDistance = 367;
            this.depsSplitContainer.TabIndex = 6;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.fileList);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.addFile);
            this.splitContainer4.Panel2.Controls.Add(this.removeFile);
            this.splitContainer4.Size = new System.Drawing.Size(821, 444);
            this.splitContainer4.SplitterDistance = 398;
            this.splitContainer4.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirby FDG Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.fileListTab.ResumeLayout(false);
            this.sceneListTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.assetGroup1Tab.ResumeLayout(false);
            this.assetGroup2Tab.ResumeLayout(false);
            this.stringListTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.sceneListContainer.Panel1.ResumeLayout(false);
            this.sceneListContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sceneListContainer)).EndInit();
            this.sceneListContainer.ResumeLayout(false);
            this.depsSplitContainer.Panel1.ResumeLayout(false);
            this.depsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depsSplitContainer)).EndInit();
            this.depsSplitContainer.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fileListTab;
        private System.Windows.Forms.TabPage sceneListTab;
        private System.Windows.Forms.TabPage stringListTab;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.ListBox stringList;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.Button addFile;
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
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}

