using System;
using System.Runtime.CompilerServices;
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

		/// <summary>
		/// Updates the statistics in the UI.
		/// </summary>
		private void UpdateStatistics() {
			// Status.
			chkEntryModel.Checked = elDocument.HasEntryModel();
			chkEntries.Checked = elDocument.HasEntries();

			// Statistics.
			lblColumns.Text = elDocument.Model.Count.ToString();
			lblEntries.Text = elDocument.Entries.Count.ToString();
		}

		private void mniFileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void mniViewSpreadsheet_Click(object sender, EventArgs e) {
			SpreadsheetForm frmSpreadsheet = new SpreadsheetForm(elDocument);
			frmSpreadsheet.Show();
		}

		private void MainForm_Activated(object sender, EventArgs e) {
			UpdateStatistics();
		}

		private void mniViewModel_Click(object sender, EventArgs e) {
			ModelForm frmModel = new ModelForm(elDocument);
			frmModel.Show();
		}

		private void mniViewDataEntry_Click(object sender, EventArgs e) {
			DataEntryForm frmEntry = new DataEntryForm(elDocument);
			frmEntry.Show();
		}

		private void mniFileNew_Click(object sender, EventArgs e) {
			elDocument = new ELDocument();
			UpdateStatistics();
		}

		private void mniFileOpen_Click(object sender, EventArgs e) {
			if (dlgOpen.ShowDialog() == DialogResult.OK) {
				DocumentParser parser = new DocumentParser(dlgOpen.FileName);
				elDocument = parser.Document;

				UpdateStatistics();
			}
		}

		private void mniFileSave_Click(object sender, EventArgs e) {
			// Should we display a save file dialog?
			if (!elDocument.HasFileName()) {
				dlgSave.Title = "Save Document";
				if (dlgSave.ShowDialog() == DialogResult.OK)
					elDocument.FileName = dlgSave.FileName;
			}

			elDocument.Save();
		}

		private void mniFileSaveAs_Click(object sender, EventArgs e) {
			dlgSave.Title = "Save Document As";
			if (dlgSave.ShowDialog() == DialogResult.OK) {
				elDocument.FileName = dlgSave.FileName;
				elDocument.Save();
			}
		}
	}
}
