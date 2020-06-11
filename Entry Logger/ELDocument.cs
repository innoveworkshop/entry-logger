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
			FileName = null;
		}

		/// <summary>
		/// Constructs an empty Entry Logger document with a file associated.
		/// </summary>
		/// <param name="fileName"></param>
		public ELDocument(string fileName) : this() {
			FileName = fileName;
		}

		/// <summary>
		/// Saves the document to a file.
		/// </summary>
		public void Save() {
			if (!HasFileName())
				return;

			System.IO.File.WriteAllText(FileName, this.ToFileFormat());
		}

		/// <summary>
		/// Returns this object in the same way it would be inside a file.
		/// </summary>
		/// <returns>File representation of the document.</returns>
		public string ToFileFormat() {
			StringBuilder str = new StringBuilder();

			str.Append(Model.ToFileFormat());
			str.AppendLine();
			foreach (Entry entry in Entries) {
				str.AppendLine(entry.ToFileFormat());
			}

			return str.ToString();
		}

		/// <summary>
		/// Checks if this document has a file associated with it.
		/// </summary>
		/// <returns>True if there is a file associated.</returns>
		public bool HasFileName() {
			return FileName != null;
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
		/// The location of the file of this document.
		/// </summary>
		public string FileName { get; set; }

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
