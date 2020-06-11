namespace EntryLogger {
	partial class MainForm {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mniFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mniFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.mniFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mniFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mniFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mniView = new System.Windows.Forms.ToolStripMenuItem();
			this.mniViewDataEntry = new System.Windows.Forms.ToolStripMenuItem();
			this.mniViewModel = new System.Windows.Forms.ToolStripMenuItem();
			this.mniViewSpreadsheet = new System.Windows.Forms.ToolStripMenuItem();
			this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mniHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.grpDocStatus = new System.Windows.Forms.GroupBox();
			this.chkEntries = new System.Windows.Forms.CheckBox();
			this.chkEntryModel = new System.Windows.Forms.CheckBox();
			this.grpStatistics = new System.Windows.Forms.GroupBox();
			this.lblEntries = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblColumns = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.mnuMain.SuspendLayout();
			this.stpStatus.SuspendLayout();
			this.grpDocStatus.SuspendLayout();
			this.grpStatistics.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniView,
            this.mniHelp});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(277, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mniFile
			// 
			this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFileNew,
            this.mniFileOpen,
            this.toolStripSeparator,
            this.mniFileSave,
            this.mniFileSaveAs,
            this.toolStripSeparator1,
            this.mniFileExit});
			this.mniFile.Name = "mniFile";
			this.mniFile.Size = new System.Drawing.Size(37, 20);
			this.mniFile.Text = "&File";
			// 
			// mniFileNew
			// 
			this.mniFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mniFileNew.Image")));
			this.mniFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mniFileNew.Name = "mniFileNew";
			this.mniFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mniFileNew.Size = new System.Drawing.Size(146, 22);
			this.mniFileNew.Text = "&New";
			this.mniFileNew.Click += new System.EventHandler(this.mniFileNew_Click);
			// 
			// mniFileOpen
			// 
			this.mniFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mniFileOpen.Image")));
			this.mniFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mniFileOpen.Name = "mniFileOpen";
			this.mniFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mniFileOpen.Size = new System.Drawing.Size(146, 22);
			this.mniFileOpen.Text = "&Open";
			this.mniFileOpen.Click += new System.EventHandler(this.mniFileOpen_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// mniFileSave
			// 
			this.mniFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mniFileSave.Image")));
			this.mniFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mniFileSave.Name = "mniFileSave";
			this.mniFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mniFileSave.Size = new System.Drawing.Size(146, 22);
			this.mniFileSave.Text = "&Save";
			this.mniFileSave.Click += new System.EventHandler(this.mniFileSave_Click);
			// 
			// mniFileSaveAs
			// 
			this.mniFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("mniFileSaveAs.Image")));
			this.mniFileSaveAs.Name = "mniFileSaveAs";
			this.mniFileSaveAs.Size = new System.Drawing.Size(146, 22);
			this.mniFileSaveAs.Text = "Save &As";
			this.mniFileSaveAs.Click += new System.EventHandler(this.mniFileSaveAs_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// mniFileExit
			// 
			this.mniFileExit.Image = ((System.Drawing.Image)(resources.GetObject("mniFileExit.Image")));
			this.mniFileExit.Name = "mniFileExit";
			this.mniFileExit.Size = new System.Drawing.Size(146, 22);
			this.mniFileExit.Text = "E&xit";
			this.mniFileExit.Click += new System.EventHandler(this.mniFileExit_Click);
			// 
			// mniView
			// 
			this.mniView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniViewDataEntry,
            this.mniViewModel,
            this.mniViewSpreadsheet});
			this.mniView.Name = "mniView";
			this.mniView.Size = new System.Drawing.Size(44, 20);
			this.mniView.Text = "&View";
			// 
			// mniViewDataEntry
			// 
			this.mniViewDataEntry.Image = ((System.Drawing.Image)(resources.GetObject("mniViewDataEntry.Image")));
			this.mniViewDataEntry.Name = "mniViewDataEntry";
			this.mniViewDataEntry.Size = new System.Drawing.Size(138, 22);
			this.mniViewDataEntry.Text = "&Data Entry";
			this.mniViewDataEntry.Click += new System.EventHandler(this.mniViewDataEntry_Click);
			// 
			// mniViewModel
			// 
			this.mniViewModel.Image = ((System.Drawing.Image)(resources.GetObject("mniViewModel.Image")));
			this.mniViewModel.Name = "mniViewModel";
			this.mniViewModel.Size = new System.Drawing.Size(138, 22);
			this.mniViewModel.Text = "Entry &Model";
			this.mniViewModel.Click += new System.EventHandler(this.mniViewModel_Click);
			// 
			// mniViewSpreadsheet
			// 
			this.mniViewSpreadsheet.Image = ((System.Drawing.Image)(resources.GetObject("mniViewSpreadsheet.Image")));
			this.mniViewSpreadsheet.Name = "mniViewSpreadsheet";
			this.mniViewSpreadsheet.Size = new System.Drawing.Size(138, 22);
			this.mniViewSpreadsheet.Text = "&Spreadsheet";
			this.mniViewSpreadsheet.Click += new System.EventHandler(this.mniViewSpreadsheet_Click);
			// 
			// mniHelp
			// 
			this.mniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHelpAbout});
			this.mniHelp.Name = "mniHelp";
			this.mniHelp.Size = new System.Drawing.Size(44, 20);
			this.mniHelp.Text = "&Help";
			// 
			// mniHelpAbout
			// 
			this.mniHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("mniHelpAbout.Image")));
			this.mniHelpAbout.Name = "mniHelpAbout";
			this.mniHelpAbout.Size = new System.Drawing.Size(116, 22);
			this.mniHelpAbout.Text = "&About...";
			// 
			// stpStatus
			// 
			this.stpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.stpStatus.Location = new System.Drawing.Point(0, 105);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(277, 22);
			this.stpStatus.TabIndex = 1;
			this.stpStatus.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// grpDocStatus
			// 
			this.grpDocStatus.Controls.Add(this.chkEntries);
			this.grpDocStatus.Controls.Add(this.chkEntryModel);
			this.grpDocStatus.Location = new System.Drawing.Point(8, 27);
			this.grpDocStatus.Name = "grpDocStatus";
			this.grpDocStatus.Size = new System.Drawing.Size(122, 73);
			this.grpDocStatus.TabIndex = 2;
			this.grpDocStatus.TabStop = false;
			this.grpDocStatus.Text = "Document Status";
			// 
			// chkEntries
			// 
			this.chkEntries.AutoSize = true;
			this.chkEntries.Enabled = false;
			this.chkEntries.Location = new System.Drawing.Point(6, 47);
			this.chkEntries.Name = "chkEntries";
			this.chkEntries.Size = new System.Drawing.Size(61, 19);
			this.chkEntries.TabIndex = 1;
			this.chkEntries.Text = "Entries";
			this.chkEntries.UseVisualStyleBackColor = true;
			// 
			// chkEntryModel
			// 
			this.chkEntryModel.AutoSize = true;
			this.chkEntryModel.Enabled = false;
			this.chkEntryModel.Location = new System.Drawing.Point(6, 22);
			this.chkEntryModel.Name = "chkEntryModel";
			this.chkEntryModel.Size = new System.Drawing.Size(90, 19);
			this.chkEntryModel.TabIndex = 0;
			this.chkEntryModel.Text = "Entry Model";
			this.chkEntryModel.UseVisualStyleBackColor = true;
			// 
			// grpStatistics
			// 
			this.grpStatistics.Controls.Add(this.lblEntries);
			this.grpStatistics.Controls.Add(this.label2);
			this.grpStatistics.Controls.Add(this.lblColumns);
			this.grpStatistics.Controls.Add(this.label1);
			this.grpStatistics.Location = new System.Drawing.Point(136, 27);
			this.grpStatistics.Name = "grpStatistics";
			this.grpStatistics.Size = new System.Drawing.Size(134, 73);
			this.grpStatistics.TabIndex = 3;
			this.grpStatistics.TabStop = false;
			this.grpStatistics.Text = "Document Statistics";
			// 
			// lblEntries
			// 
			this.lblEntries.AutoSize = true;
			this.lblEntries.Location = new System.Drawing.Point(73, 34);
			this.lblEntries.Name = "lblEntries";
			this.lblEntries.Size = new System.Drawing.Size(13, 15);
			this.lblEntries.TabIndex = 3;
			this.lblEntries.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Entries: ";
			// 
			// lblColumns
			// 
			this.lblColumns.AutoSize = true;
			this.lblColumns.Location = new System.Drawing.Point(73, 19);
			this.lblColumns.Name = "lblColumns";
			this.lblColumns.Size = new System.Drawing.Size(13, 15);
			this.lblColumns.TabIndex = 1;
			this.lblColumns.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Columns: ";
			// 
			// dlgOpen
			// 
			this.dlgOpen.DefaultExt = "eld";
			this.dlgOpen.Filter = "Entry Logger Document|*.eld|All files|*.*";
			this.dlgOpen.Title = "Open Document";
			// 
			// dlgSave
			// 
			this.dlgSave.DefaultExt = "eld";
			this.dlgSave.Filter = "Entry Logger Document|*.eld|All files|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 127);
			this.Controls.Add(this.grpStatistics);
			this.Controls.Add(this.grpDocStatus);
			this.Controls.Add(this.stpStatus);
			this.Controls.Add(this.mnuMain);
			this.Name = "MainForm";
			this.Text = "Entry Logger";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.stpStatus.ResumeLayout(false);
			this.stpStatus.PerformLayout();
			this.grpDocStatus.ResumeLayout(false);
			this.grpDocStatus.PerformLayout();
			this.grpStatistics.ResumeLayout(false);
			this.grpStatistics.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.StatusStrip stpStatus;
		private System.Windows.Forms.ToolStripMenuItem mniFile;
		private System.Windows.Forms.ToolStripMenuItem mniFileNew;
		private System.Windows.Forms.ToolStripMenuItem mniFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem mniFileSave;
		private System.Windows.Forms.ToolStripMenuItem mniFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mniFileExit;
		private System.Windows.Forms.ToolStripMenuItem mniHelp;
		private System.Windows.Forms.ToolStripMenuItem mniHelpAbout;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripMenuItem mniView;
		private System.Windows.Forms.ToolStripMenuItem mniViewModel;
		private System.Windows.Forms.ToolStripMenuItem mniViewSpreadsheet;
		private System.Windows.Forms.GroupBox grpDocStatus;
		private System.Windows.Forms.CheckBox chkEntries;
		private System.Windows.Forms.CheckBox chkEntryModel;
		private System.Windows.Forms.GroupBox grpStatistics;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblColumns;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEntries;
		private System.Windows.Forms.ToolStripMenuItem mniViewDataEntry;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.SaveFileDialog dlgSave;
	}
}

