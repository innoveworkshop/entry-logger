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
			this.layoutTable.Location = new System.Drawing.Point(22, 26);
			this.layoutTable.Margin = new System.Windows.Forms.Padding(6);
			this.layoutTable.Name = "layoutTable";
			this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutTable.Size = new System.Drawing.Size(524, 563);
			this.layoutTable.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 6);
			this.textBox1.Margin = new System.Windows.Forms.Padding(6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(182, 39);
			this.textBox1.TabIndex = 1;
			// 
			// DataEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 614);
			this.Controls.Add(this.layoutTable);
			this.Margin = new System.Windows.Forms.Padding(6);
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