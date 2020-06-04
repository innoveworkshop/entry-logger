using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryLogger {
	static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// Build a test document.
			ELDocument elDocument = new ELDocument();
			for (int i = 0; i < 5; i++) {
				elDocument.Model.AddColumn(new Column("Column " + i));
			}
			for (int i = 0; i < 10; i++) {
				Entry entry = new Entry();

				for (int j = 0; j < 5; j++) {
					entry.Add("Column " + j + " Row " + i);
				}

				elDocument.Entries.Add(entry);
			}

			// Setup and run the application.
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(elDocument));
		}
	}
}
