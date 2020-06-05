using System;
using System.Windows.Forms;

namespace EntryLogger {
	public partial class MainForm : Form {
		private ELDocument elDocument;

		/// <summary>
		/// Constructs a blank main form.
		/// </summary>
		public MainForm() {
			InitializeComponent();
			statusLabel.Text = "Welcome to Entry Logger!";
		}

		/// <summary>
		/// Constructs a main form already with a document associated with it.
		/// </summary>
		/// <param name="elDocument">Entry Logger document.</param>
		public MainForm(ELDocument elDocument) : this() {
			this.elDocument = elDocument;
		}

		private void mniFileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void mniViewSpreadsheet_Click(object sender, EventArgs e) {
			SpreadsheetForm frmSpreadsheet = new SpreadsheetForm(elDocument);
			frmSpreadsheet.Show();
		}

		private void MainForm_Activated(object sender, EventArgs e) {
			// Status.
			chkEntryModel.Checked = elDocument.HasEntryModel();
			chkEntries.Checked = elDocument.HasEntries();

			// Statistics.
			lblColumns.Text = elDocument.Model.Count.ToString();
			lblEntries.Text = elDocument.Entries.Count.ToString();
		}

		private void mniViewModel_Click(object sender, EventArgs e) {
			ModelForm frmModel = new ModelForm(elDocument);
			frmModel.Show();
		}

		private void mniViewDataEntry_Click(object sender, EventArgs e) {
			DataEntryForm frmEntry = new DataEntryForm(elDocument);
			frmEntry.Show();
		}
	}
}
