using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryLogger {
	public partial class ModelForm : Form {
		private ELDocument elDocument;

		/// <summary>
		/// Constructs an empty entry model form without a document attached to it.
		/// </summary>
		public ModelForm() {
			InitializeComponent();
		}

		/// <summary>
		/// Contructs an entry model form with an Entry Logger document attached to it.
		/// </summary>
		/// <param name="elDocument">Entry Logger document associated with the form.</param>
		public ModelForm(ELDocument elDocument) : this() {
			this.elDocument = elDocument;
			PopulateList();
		}

		/// <summary>
		/// Populates the entry model list with models from the associated document.
		/// </summary>
		private void PopulateList() {
			ClearList(false);

			foreach (Column model in elDocument.Model) {
				AddToList(model, false);
			}
		}

		/// <summary>
		/// Adds an entry model column to the list and optionally syncs this change with the associated document.
		/// </summary>
		/// <param name="model">Column entry model to be added.</param>
		/// <param name="sync">Should we sync this change with the associated document?</param>
		public void AddToList(Column model, bool sync) {
			lstModels.Items.Add(model);

			if (sync)
				elDocument.Model.Add(model);
		}

		/// <summary>
		/// Clears the entry model list and optionally syncs this change to the associated document.
		/// </summary>
		/// <param name="sync">Should we sync this change with the associated document?</param>
		public void ClearList(bool sync) {
			lstModels.Items.Clear();

			if (sync)
				elDocument.Model.Clear();
		}

		private void btnClear_Click(object sender, EventArgs e) {
			ClearList(true);
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			elDocument.Model.RemoveAt(lstModels.SelectedIndex);
			PopulateList();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			elDocument.Model.Add(new Column(txtName.Text));
			PopulateList();
		}
	}
}
