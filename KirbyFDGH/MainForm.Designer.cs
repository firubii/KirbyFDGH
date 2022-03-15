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
            this.ag1List = new System.Windows.Forms.ListBox();
            this.assetGroup2Tab = new System.Windows.Forms.TabPage();
            this.ag2Remove = new System.Windows.Forms.Button();
            this.ag2Add = new System.Windows.Forms.Button();
            this.ag2List = new System.Windows.Forms.ListBox();
            this.removeScene = new System.Windows.Forms.Button();
            this.addScene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sceneList = new System.Windows.Forms.ListBox();
            this.stringListTab = new System.Windows.Forms.TabPage();
            this.stringList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.fileListTab.SuspendLayout();
            this.sceneListTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.assetGroup1Tab.SuspendLayout();
            this.assetGroup2Tab.SuspendLayout();
            this.stringListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xBINSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
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
            this.endiannessToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.endiannessToolStripMenuItem.Text = "Endianness";
            // 
            // bigEndianToolStripMenuItem
            // 
            this.bigEndianToolStripMenuItem.Name = "bigEndianToolStripMenuItem";
            this.bigEndianToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.bigEndianToolStripMenuItem.Text = "Big Endian";
            this.bigEndianToolStripMenuItem.Click += new System.EventHandler(this.bigEndianToolStripMenuItem_Click);
            // 
            // littleEndianToolStripMenuItem
            // 
            this.littleEndianToolStripMenuItem.Name = "littleEndianToolStripMenuItem";
            this.littleEndianToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.littleEndianToolStripMenuItem.Text = "Little Endian";
            this.littleEndianToolStripMenuItem.Click += new System.EventHandler(this.littleEndianToolStripMenuItem_Click);
            // 
            // xBINVersionToolStripMenuItem
            // 
            this.xBINVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version2ToolStripMenuItem,
            this.version4ToolStripMenuItem});
            this.xBINVersionToolStripMenuItem.Name = "xBINVersionToolStripMenuItem";
            this.xBINVersionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.xBINVersionToolStripMenuItem.Text = "XBIN Version";
            // 
            // version2ToolStripMenuItem
            // 
            this.version2ToolStripMenuItem.Name = "version2ToolStripMenuItem";
            this.version2ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.version2ToolStripMenuItem.Text = "Version 2 (RtDL ,TDX, KPR)";
            this.version2ToolStripMenuItem.Click += new System.EventHandler(this.version2ToolStripMenuItem_Click);
            // 
            // version4ToolStripMenuItem
            // 
            this.version4ToolStripMenuItem.Name = "version4ToolStripMenuItem";
            this.version4ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.version4ToolStripMenuItem.Text = "Version 4 (KBR, KSA)";
            this.version4ToolStripMenuItem.Click += new System.EventHandler(this.version4ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fileListTab);
            this.tabControl1.Controls.Add(this.sceneListTab);
            this.tabControl1.Controls.Add(this.stringListTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 375);
            this.tabControl1.TabIndex = 1;
            // 
            // fileListTab
            // 
            this.fileListTab.Controls.Add(this.removeFile);
            this.fileListTab.Controls.Add(this.addFile);
            this.fileListTab.Controls.Add(this.fileList);
            this.fileListTab.Location = new System.Drawing.Point(4, 22);
            this.fileListTab.Name = "fileListTab";
            this.fileListTab.Padding = new System.Windows.Forms.Padding(3);
            this.fileListTab.Size = new System.Drawing.Size(595, 349);
            this.fileListTab.TabIndex = 0;
            this.fileListTab.Text = "File List";
            this.fileListTab.UseVisualStyleBackColor = true;
            // 
            // removeFile
            // 
            this.removeFile.Location = new System.Drawing.Point(103, 312);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(94, 31);
            this.removeFile.TabIndex = 2;
            this.removeFile.Text = "Remove";
            this.removeFile.UseVisualStyleBackColor = true;
            this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(3, 312);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(94, 31);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Add";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(3, 3);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(588, 303);
            this.fileList.TabIndex = 0;
            // 
            // sceneListTab
            // 
            this.sceneListTab.Controls.Add(this.tabControl2);
            this.sceneListTab.Controls.Add(this.removeScene);
            this.sceneListTab.Controls.Add(this.addScene);
            this.sceneListTab.Controls.Add(this.label1);
            this.sceneListTab.Controls.Add(this.sceneList);
            this.sceneListTab.Location = new System.Drawing.Point(4, 22);
            this.sceneListTab.Name = "sceneListTab";
            this.sceneListTab.Padding = new System.Windows.Forms.Padding(3);
            this.sceneListTab.Size = new System.Drawing.Size(595, 349);
            this.sceneListTab.TabIndex = 1;
            this.sceneListTab.Text = "Scene Data";
            this.sceneListTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.assetGroup1Tab);
            this.tabControl2.Controls.Add(this.assetGroup2Tab);
            this.tabControl2.Location = new System.Drawing.Point(302, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(287, 337);
            this.tabControl2.TabIndex = 4;
            // 
            // assetGroup1Tab
            // 
            this.assetGroup1Tab.Controls.Add(this.ag1Remove);
            this.assetGroup1Tab.Controls.Add(this.ag1Add);
            this.assetGroup1Tab.Controls.Add(this.ag1List);
            this.assetGroup1Tab.Location = new System.Drawing.Point(4, 22);
            this.assetGroup1Tab.Name = "assetGroup1Tab";
            this.assetGroup1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.assetGroup1Tab.Size = new System.Drawing.Size(279, 311);
            this.assetGroup1Tab.TabIndex = 0;
            this.assetGroup1Tab.Text = "Asset Group 1";
            this.assetGroup1Tab.UseVisualStyleBackColor = true;
            // 
            // ag1Remove
            // 
            this.ag1Remove.Location = new System.Drawing.Point(106, 274);
            this.ag1Remove.Name = "ag1Remove";
            this.ag1Remove.Size = new System.Drawing.Size(94, 31);
            this.ag1Remove.TabIndex = 5;
            this.ag1Remove.Text = "Remove";
            this.ag1Remove.UseVisualStyleBackColor = true;
            this.ag1Remove.Click += new System.EventHandler(this.ag1Remove_Click);
            // 
            // ag1Add
            // 
            this.ag1Add.Location = new System.Drawing.Point(6, 274);
            this.ag1Add.Name = "ag1Add";
            this.ag1Add.Size = new System.Drawing.Size(94, 31);
            this.ag1Add.TabIndex = 4;
            this.ag1Add.Text = "Add";
            this.ag1Add.UseVisualStyleBackColor = true;
            this.ag1Add.Click += new System.EventHandler(this.ag1Add_Click);
            // 
            // ag1List
            // 
            this.ag1List.FormattingEnabled = true;
            this.ag1List.Location = new System.Drawing.Point(6, 6);
            this.ag1List.Name = "ag1List";
            this.ag1List.Size = new System.Drawing.Size(267, 264);
            this.ag1List.TabIndex = 0;
            // 
            // assetGroup2Tab
            // 
            this.assetGroup2Tab.Controls.Add(this.ag2Remove);
            this.assetGroup2Tab.Controls.Add(this.ag2Add);
            this.assetGroup2Tab.Controls.Add(this.ag2List);
            this.assetGroup2Tab.Location = new System.Drawing.Point(4, 22);
            this.assetGroup2Tab.Name = "assetGroup2Tab";
            this.assetGroup2Tab.Padding = new System.Windows.Forms.Padding(3);
            this.assetGroup2Tab.Size = new System.Drawing.Size(279, 311);
            this.assetGroup2Tab.TabIndex = 1;
            this.assetGroup2Tab.Text = "Asset Group 2";
            this.assetGroup2Tab.UseVisualStyleBackColor = true;
            // 
            // ag2Remove
            // 
            this.ag2Remove.Location = new System.Drawing.Point(106, 274);
            this.ag2Remove.Name = "ag2Remove";
            this.ag2Remove.Size = new System.Drawing.Size(94, 31);
            this.ag2Remove.TabIndex = 8;
            this.ag2Remove.Text = "Remove";
            this.ag2Remove.UseVisualStyleBackColor = true;
            this.ag2Remove.Click += new System.EventHandler(this.ag2Remove_Click);
            // 
            // ag2Add
            // 
            this.ag2Add.Location = new System.Drawing.Point(6, 274);
            this.ag2Add.Name = "ag2Add";
            this.ag2Add.Size = new System.Drawing.Size(94, 31);
            this.ag2Add.TabIndex = 7;
            this.ag2Add.Text = "Add";
            this.ag2Add.UseVisualStyleBackColor = true;
            this.ag2Add.Click += new System.EventHandler(this.ag2Add_Click);
            // 
            // ag2List
            // 
            this.ag2List.FormattingEnabled = true;
            this.ag2List.Location = new System.Drawing.Point(6, 6);
            this.ag2List.Name = "ag2List";
            this.ag2List.Size = new System.Drawing.Size(267, 264);
            this.ag2List.TabIndex = 6;
            // 
            // removeScene
            // 
            this.removeScene.Location = new System.Drawing.Point(103, 312);
            this.removeScene.Name = "removeScene";
            this.removeScene.Size = new System.Drawing.Size(94, 31);
            this.removeScene.TabIndex = 3;
            this.removeScene.Text = "Remove";
            this.removeScene.UseVisualStyleBackColor = true;
            this.removeScene.Click += new System.EventHandler(this.removeScene_Click);
            // 
            // addScene
            // 
            this.addScene.Location = new System.Drawing.Point(3, 312);
            this.addScene.Name = "addScene";
            this.addScene.Size = new System.Drawing.Size(94, 31);
            this.addScene.TabIndex = 2;
            this.addScene.Text = "Add";
            this.addScene.UseVisualStyleBackColor = true;
            this.addScene.Click += new System.EventHandler(this.addScene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scene List";
            // 
            // sceneList
            // 
            this.sceneList.FormattingEnabled = true;
            this.sceneList.Location = new System.Drawing.Point(3, 17);
            this.sceneList.Name = "sceneList";
            this.sceneList.Size = new System.Drawing.Size(293, 290);
            this.sceneList.TabIndex = 0;
            this.sceneList.SelectedIndexChanged += new System.EventHandler(this.sceneList_SelectedIndexChanged);
            // 
            // stringListTab
            // 
            this.stringListTab.Controls.Add(this.stringList);
            this.stringListTab.Location = new System.Drawing.Point(4, 22);
            this.stringListTab.Name = "stringListTab";
            this.stringListTab.Size = new System.Drawing.Size(595, 349);
            this.stringListTab.TabIndex = 2;
            this.stringListTab.Text = "String List";
            this.stringListTab.UseVisualStyleBackColor = true;
            // 
            // stringList
            // 
            this.stringList.FormattingEnabled = true;
            this.stringList.Location = new System.Drawing.Point(3, 3);
            this.stringList.Name = "stringList";
            this.stringList.Size = new System.Drawing.Size(588, 342);
            this.stringList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirby FDG Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.fileListTab.ResumeLayout(false);
            this.sceneListTab.ResumeLayout(false);
            this.sceneListTab.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.assetGroup1Tab.ResumeLayout(false);
            this.assetGroup2Tab.ResumeLayout(false);
            this.stringListTab.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sceneList;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage assetGroup1Tab;
        private System.Windows.Forms.Button ag1Remove;
        private System.Windows.Forms.Button ag1Add;
        private System.Windows.Forms.ListBox ag1List;
        private System.Windows.Forms.TabPage assetGroup2Tab;
        private System.Windows.Forms.Button ag2Remove;
        private System.Windows.Forms.Button ag2Add;
        private System.Windows.Forms.ListBox ag2List;
        private System.Windows.Forms.ToolStripMenuItem xBINSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endiannessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littleEndianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xBINVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version4ToolStripMenuItem;
    }
}

