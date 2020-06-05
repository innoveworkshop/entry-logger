using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
			string projectPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) , @"..\..\..\..\"));
			string exampleFile = Path.GetFullPath(Path.Combine(projectPath,	@"test.eld"));
			DocumentParser parser = new DocumentParser(exampleFile);

			// Setup and run the application.
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(parser.Document));
		}
	}
}
