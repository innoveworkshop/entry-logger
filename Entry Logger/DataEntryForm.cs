using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryLogger {
	public partial class DataEntryForm : Form {
		private ELDocument elDocument;

		/// <summary>
		/// Contructs an empty data entry form.
		/// </summary>
		public DataEntryForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Contructs a data entry form with a model from a document.
		/// </summary>
		/// <param name="elDocument">Entry Logger document object.</param>
		public DataEntryForm(ELDocument elDocument) : this() {
			this.elDocument = elDocument;
			PopulateForm();
		}

		/// <summary>
		/// Repopulates the form with entry controls.
		/// </summary>
		private void PopulateForm() {
			ClearForm();

			foreach (Column col in elDocument.Model) {
				layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
				layoutTable.Controls.Add(CreateLabel(col.ToString()), 0, layoutTable.RowCount);
				layoutTable.Controls.Add(CreateTextBox(col.Name), 1, layoutTable.RowCount);
				layoutTable.RowCount++;
			}
		}

		/// <summary>
		/// Creates a label control with its text already set.
		/// </summary>
		/// <param name="text">Text caption to be displayed by the label.</param>
		/// <returns>A prepared label control.</returns>
		private Label CreateLabel(string text) {
			Label label = new Label();

			label.Dock = DockStyle.Fill;
			label.Text = text;
			label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			return label;
		}

		/// <summary>
		/// Creates a TextBox control with a name to identify it.
		/// </summary>
		/// <param name="name">Name of the TextBox.</param>
		/// <returns>A prepared TextBox control.</returns>
		private TextBox CreateTextBox(string name) {
			TextBox textBox = new TextBox();

			textBox.Dock = DockStyle.Fill;
			textBox.Name = name;

			return textBox;
		}

		/// <summary>
		/// Clears the form's layout table.
		/// </summary>
		private void ClearForm() {
			layoutTable.Controls.Clear();
			layoutTable.RowStyles.Clear();
			layoutTable.RowCount = 0;
		}
	}
}
