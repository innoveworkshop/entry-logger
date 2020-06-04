using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry_Logger {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();

			statusLabel.Text = "Welcome to Entry Logger!";
		}

		private void mniFileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
