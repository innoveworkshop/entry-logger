namespace EntryLogger {
	partial class DataEntryForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryForm));
			this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.btnFirst = new System.Windows.Forms.ToolStripButton();
			this.btnPrevious = new System.Windows.Forms.ToolStripButton();
			this.txtCurrentEntry = new System.Windows.Forms.ToolStripTextBox();
			this.lblEntryCount = new System.Windows.Forms.ToolStripLabel();
			this.btnNext = new System.Windows.Forms.ToolStripButton();
			this.btnLast = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutTable
			// 
			this.layoutTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.layoutTable.AutoScroll = true;
			this.layoutTable.ColumnCount = 2;
			this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.layoutTable.Location = new System.Drawing.Point(12, 28);
			this.layoutTable.Name = "layoutTable";
			this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 264F));
			this.layoutTable.Size = new System.Drawing.Size(282, 125);
			this.layoutTable.TabIndex = 0;
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.btnPrevious,
            this.txtCurrentEntry,
            this.lblEntryCount,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator1,
            this.btnSave,
            this.btnDelete});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(306, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "toolStrip";
			// 
			// btnFirst
			// 
			this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
			this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(23, 22);
			this.btnFirst.Text = "First";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
			this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(23, 22);
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// txtCurrentEntry
			// 
			this.txtCurrentEntry.AcceptsReturn = true;
			this.txtCurrentEntry.Name = "txtCurrentEntry";
			this.txtCurrentEntry.Size = new System.Drawing.Size(30, 25);
			this.txtCurrentEntry.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtCurrentEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentEntry_KeyDown);
			// 
			// lblEntryCount
			// 
			this.lblEntryCount.Name = "lblEntryCount";
			this.lblEntryCount.Size = new System.Drawing.Size(39, 22);
			this.lblEntryCount.Text = "/ xxxx";
			// 
			// btnNext
			// 
			this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(23, 22);
			this.btnNext.Text = "Next";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
			this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(23, 22);
			this.btnLast.Text = "Last";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnSave
			// 
			this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(23, 22);
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 22);
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// DataEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 165);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.layoutTable);
			this.Name = "DataEntryForm";
			this.Text = "Data Entry";
			this.Activated += new System.EventHandler(this.DataEntryForm_Activated);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel layoutTable;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton btnFirst;
		private System.Windows.Forms.ToolStripButton btnPrevious;
		private System.Windows.Forms.ToolStripTextBox txtCurrentEntry;
		private System.Windows.Forms.ToolStripLabel lblEntryCount;
		private System.Windows.Forms.ToolStripButton btnNext;
		private System.Windows.Forms.ToolStripButton btnLast;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnDelete;
	}
}