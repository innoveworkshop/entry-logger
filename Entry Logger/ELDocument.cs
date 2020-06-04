using System;
using System.Collections.Generic;
using System.Text;

namespace EntryLogger {
	/// <summary>
	/// Abstract representation of an Entry Logger Document file.
	/// </summary>
	public class ELDocument {
		/// <summary>
		/// Constructs an empty Entry Logger document.
		/// </summary>
		public ELDocument() {
			Model = new EntryModel();
			Entries = new List<Entry>();
		}

		/// <summary>
		/// Checks if this document contains an entry model.
		/// </summary>
		/// <returns>True if an entry model is set.</returns>
		public bool HasEntryModel() {
			return Model.Count > 0;
		}

		/// <summary>
		/// Checks if there are any entries in this document.
		/// </summary>
		/// <returns>True if there are any entries.</returns>
		public bool HasEntries() {
			return Entries.Count > 0;
		}

		/// <summary>
		/// Returns the string representation of the document in a human-readable format.
		/// </summary>
		/// <returns>A nice and readable representation of the document.</returns>
		public override string ToString() {
			StringBuilder str = new StringBuilder();

			str.AppendLine("Model:");
			str.AppendLine(Model.ToString());
			str.AppendLine();
			str.AppendLine("Entries:");
			foreach (Entry entry in Entries) {
				str.AppendLine(entry.ToString());
			}

			return str.ToString();
		}

		/// <summary>
		/// The data model of the document.
		/// </summary>
		public EntryModel Model { get; set; }

		/// <summary>
		/// The list of entries in the document.
		/// </summary>
		public List<Entry> Entries { get; set; }
	}
}
