using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Transactions;

namespace EntryLogger {
	/// <summary>
	/// Abstraction class that represents the document data model.
	/// </summary>
	public class EntryModel : List<Column> {
		/// <summary>
		/// Adds a column to the model.
		/// </summary>
		/// <param name="column">Column object to be added to the model.</param>
		public void AddColumn(Column column) {
			base.Add(column);
		}

		/// <summary>
		/// Returns the string representation of the entry model.
		/// </summary>
		/// <returns>A list of the columns with their names.</returns>
		public override string ToString() {
			StringBuilder str = new StringBuilder();

			for (int i = 0; i < this.Count; i++) {
				str.Append(this[i].ToString());

				if (i < (this.Count - 1)) {
					str.Append(", ");
				}
			}

			return str.ToString();
		}
	}
}
