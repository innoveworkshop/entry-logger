namespace EntryLogger {
	partial class SpreadsheetForm {
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
			this.grdSpreadsheet = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grdSpreadsheet)).BeginInit();
			this.SuspendLayout();
			// 
			// grdSpreadsheet
			// 
			this.grdSpreadsheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdSpreadsheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdSpreadsheet.Location = new System.Drawing.Point(0, 0);
			this.grdSpreadsheet.Name = "grdSpreadsheet";
			this.grdSpreadsheet.Size = new System.Drawing.Size(617, 367);
			this.grdSpreadsheet.TabIndex = 0;
			// 
			// SpreadsheetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 367);
			this.Controls.Add(this.grdSpreadsheet);
			this.Name = "SpreadsheetForm";
			this.Text = "Spreadsheet";
			((System.ComponentModel.ISupportInitialize)(this.grdSpreadsheet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView grdSpreadsheet;
	}
}