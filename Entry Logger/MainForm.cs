using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

			// TODO: Remove this.
			Debug.WriteLine(elDocument.ToString());
		}

		private void mniFileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void mniViewSpreadsheet_Click(object sender, EventArgs e) {
			SpreadsheetForm frmSpreadsheet = new SpreadsheetForm(elDocument);
			frmSpreadsheet.Show();
		}
	}
}
