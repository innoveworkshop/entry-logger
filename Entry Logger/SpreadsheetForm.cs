using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace EntryLogger {
	public partial class SpreadsheetForm : Form {
		private ELDocument elDocument;

		/// <summary>
		/// Initializes an empty spreadsheet form.
		/// </summary>
		public SpreadsheetForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Initializes a spreadsheet form with a document attached to it.
		/// </summary>
		/// <param name="elDocument">Entry Logger document to populate the spreadsheet with.</param>
		public SpreadsheetForm(ELDocument elDocument) : this() {
			this.elDocument = elDocument;
			PopulateSpreadsheet();
		}

		/// <summary>
		/// Repopulates the whole data grid with data from the Entry Logger document.
		/// </summary>
		private void PopulateSpreadsheet() {
			UpdateColumns();
			UpdateRows();
		}

		/// <summary>
		/// Repopulates the columns in the data grid.
		/// </summary>
		private void UpdateColumns() {
			// Change the number of columns being displayed.
			grdSpreadsheet.Columns.Clear();
			grdSpreadsheet.ColumnCount = elDocument.Model.Count;

			// Populate the columns.
			for (int i = 0; i < elDocument.Model.Count; i++) {
				grdSpreadsheet.Columns[i].Name = elDocument.Model[i].Name;
			}
		}

		/// <summary>
		/// Repopulates the rows in the data grid.
		/// </summary>
		private void UpdateRows() {
			// Empty the rows.
			grdSpreadsheet.Rows.Clear();

			// Populate the grid with entries.
			foreach (Entry entry in elDocument.Entries) {
				grdSpreadsheet.Rows.Add(entry.ToArray());
			}
		}
	}
}
