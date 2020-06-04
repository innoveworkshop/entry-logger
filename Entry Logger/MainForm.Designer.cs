namespace Entry_Logger {
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
			this.mniViewModel = new System.Windows.Forms.ToolStripMenuItem();
			this.mniViewSpreadsheet = new System.Windows.Forms.ToolStripMenuItem();
			this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mniHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mnuMain.SuspendLayout();
			this.stpStatus.SuspendLayout();
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
			this.mnuMain.Size = new System.Drawing.Size(533, 24);
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
			this.mniFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mniFileNew.Name = "mniFileNew";
			this.mniFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mniFileNew.Size = new System.Drawing.Size(146, 22);
			this.mniFileNew.Text = "&New";
			// 
			// mniFileOpen
			// 
			this.mniFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mniFileOpen.Name = "mniFileOpen";
			this.mniFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mniFileOpen.Size = new System.Drawing.Size(146, 22);
			this.mniFileOpen.Text = "&Open";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// mniFileSave
			// 
			this.mniFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mniFileSave.Name = "mniFileSave";
			this.mniFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mniFileSave.Size = new System.Drawing.Size(146, 22);
			this.mniFileSave.Text = "&Save";
			// 
			// mniFileSaveAs
			// 
			this.mniFileSaveAs.Name = "mniFileSaveAs";
			this.mniFileSaveAs.Size = new System.Drawing.Size(146, 22);
			this.mniFileSaveAs.Text = "Save &As";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// mniFileExit
			// 
			this.mniFileExit.Name = "mniFileExit";
			this.mniFileExit.Size = new System.Drawing.Size(146, 22);
			this.mniFileExit.Text = "E&xit";
			this.mniFileExit.Click += new System.EventHandler(this.mniFileExit_Click);
			// 
			// mniView
			// 
			this.mniView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniViewModel,
            this.mniViewSpreadsheet});
			this.mniView.Name = "mniView";
			this.mniView.Size = new System.Drawing.Size(44, 20);
			this.mniView.Text = "&View";
			// 
			// mniViewModel
			// 
			this.mniViewModel.Name = "mniViewModel";
			this.mniViewModel.Size = new System.Drawing.Size(138, 22);
			this.mniViewModel.Text = "&Model";
			// 
			// mniViewSpreadsheet
			// 
			this.mniViewSpreadsheet.Name = "mniViewSpreadsheet";
			this.mniViewSpreadsheet.Size = new System.Drawing.Size(138, 22);
			this.mniViewSpreadsheet.Text = "&Spreadsheet";
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
			this.mniHelpAbout.Name = "mniHelpAbout";
			this.mniHelpAbout.Size = new System.Drawing.Size(116, 22);
			this.mniHelpAbout.Text = "&About...";
			// 
			// stpStatus
			// 
			this.stpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.stpStatus.Location = new System.Drawing.Point(0, 302);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(533, 22);
			this.stpStatus.TabIndex = 1;
			this.stpStatus.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 324);
			this.Controls.Add(this.stpStatus);
			this.Controls.Add(this.mnuMain);
			this.Name = "MainForm";
			this.Text = "Entry Logger";
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.stpStatus.ResumeLayout(false);
			this.stpStatus.PerformLayout();
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
	}
}

