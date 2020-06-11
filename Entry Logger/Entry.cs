using System;
using System.Collections.Generic;
using System.Text;

namespace EntryLogger {

	/// <summary>
	/// Abstration class that represents a user entry.
	/// </summary>
	public class Entry : List<string> {
		/// <summary>
		/// Initializes an empty entry.
		/// </summary>
		public Entry() : base() {
		}

		/// <summary>
		/// Initializes an entry with data.
		/// </summary>
		/// <param name="collection">Collection of columns to populate this entry.</param>
		public Entry(IEnumerable<string> collection) : base(collection) {
		}

		/// <summary>
		/// Returns the string representation of the entry.
		/// </summary>
		/// <returns>A list of values.</returns>
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
