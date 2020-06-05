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
				layoutTable.Controls.Add(CreateLabel("Hello"), 0, layoutTable.RowCount++);
				// TODO: Set RowStyles.
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
		/// Clears the form's layout table.
		/// </summary>
		private void ClearForm() {
			layoutTable.Controls.Clear();
			layoutTable.RowCount = 0;
		}
	}
}
