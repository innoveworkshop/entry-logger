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
			this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.layoutTable.SuspendLayout();
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
			this.layoutTable.Controls.Add(this.label1, 0, 0);
			this.layoutTable.Controls.Add(this.textBox1, 1, 0);
			this.layoutTable.Location = new System.Drawing.Point(12, 12);
			this.layoutTable.Name = "layoutTable";
			this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 264F));
			this.layoutTable.Size = new System.Drawing.Size(282, 264);
			this.layoutTable.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(47, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 1;
			// 
			// DataEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 288);
			this.Controls.Add(this.layoutTable);
			this.Name = "DataEntryForm";
			this.Text = "Data Entry";
			this.layoutTable.ResumeLayout(false);
			this.layoutTable.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel layoutTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}