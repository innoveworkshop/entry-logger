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
		private int currentIndex;
		private List<TextBox> txtEntries;

		/// <summary>
		/// Contructs an empty data entry form.
		/// </summary>
		public DataEntryForm() {
			InitializeComponent();
			txtEntries = new List<TextBox>();
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

			// Go through the list of columns in the model and populate the table.
			foreach (Column col in elDocument.Model) {
				txtEntries.Add(CreateTextBox(col.Name));

				layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
				layoutTable.Controls.Add(CreateLabel(col.ToString()), 0, layoutTable.RowCount);
				layoutTable.Controls.Add(txtEntries[txtEntries.Count - 1], 1, layoutTable.RowCount);
				layoutTable.RowCount++;
			}

			// Add an extra row to size the others properly.
			layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
			layoutTable.RowCount++;

			// Update the counters and update the UI.
			currentIndex = elDocument.Entries.Count;
			UpdateUI();
		}

		/// <summary>
		/// Populates the form with data from the current entry.
		/// </summary>
		private void PopulateEntry() {
			// Looks like a new entry.
			if (currentIndex == elDocument.Entries.Count) {
				// Clear all the entry fields.
				foreach (TextBox txtEntry in txtEntries) {
					txtEntry.Clear();
				}

				return;
			}

			// Populate the entry fields with data from the currently selected entry.
			Entry entry = elDocument.Entries[currentIndex];
			for (int i = 0; i < elDocument.Model.Count; i++) {
				txtEntries[i].Text = entry[i];
			}
		}

		/// <summary>
		/// Updates the various dynamic items in the toolbar.
		/// </summary>
		private void UpdateToolbar() {
			// Counters.
			lblEntryCount.Text = $"/ {elDocument.Entries.Count}";
			txtCurrentEntry.Text = (currentIndex + 1).ToString();

			// Previous buttons.
			btnFirst.Enabled = (currentIndex > 0);
			btnPrevious.Enabled = (currentIndex > 0);

			// Next buttons.
			btnLast.Enabled = (currentIndex < elDocument.Entries.Count);
			btnNext.Enabled = (currentIndex < elDocument.Entries.Count);
		}

		/// <summary>
		/// Updates the user interface elements according to the current entry index.
		/// </summary>
		private void UpdateUI() {
			UpdateToolbar();
			PopulateEntry();
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

		private void DataEntryForm_Activated(object sender, EventArgs e) {
			UpdateToolbar();
		}
	}
}
