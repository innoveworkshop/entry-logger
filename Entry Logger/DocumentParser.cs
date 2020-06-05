using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EntryLogger {
	/// <summary>
	/// A parser for Entry Logger documents.
	/// </summary>
	public class DocumentParser {
		const string ModelSeparator = @": ";
		const char EntryColumnSeparator = '\t';

		/// <summary>
		/// Constructs an empty Entry Logger document parser.
		/// </summary>
		public DocumentParser() {
			Document = new ELDocument();
		}

		/// <summary>
		/// Constructs an Entry Logger document parser and parses a given file.
		/// </summary>
		/// <param name="filePath">Path to the document to be parsed.</param>
		public DocumentParser(string filePath) : this() {
			ParseFile(filePath);
		}

		/// <summary>
		/// Parses an Entry Logger document file.
		/// </summary>
		/// <param name="filePath">Path to the document to be parsed.</param>
		/// <returns>Object representation of the document.</returns>
		public ELDocument ParseFile(string filePath) {
			Document = new ELDocument();
			ParseLines(File.ReadLines(filePath));

			return Document;
		}

		/// <summary>
		/// Parses the lines of an Entry Logger document.
		/// </summary>
		/// <param name="lines">Enumerator with the document lines.</param>
		private void ParseLines(IEnumerable<string> lines) {
			bool inModel = true;

			foreach (string line in lines) {
				// Are we parsing the model section of the file?
				if (inModel) {
					// Check if we are transitioning into the data section of the file.
					if (line.Equals("")) {
						inModel = false;
						continue;
					}

					ParseModelLine(line);
					continue;
				}

				ParseEntryLine(line);
			}
		}

		/// <summary>
		/// Parses an entry model line of the document.
		/// </summary>
		/// <param name="line">Document entry model line.</param>
		private void ParseModelLine(string line) {
			int separatorIndex = line.IndexOf(ModelSeparator);

			// Check if we found a model separator in the line.
			if (separatorIndex <= 0)
				throw new Exception("Invalid model line. Couldn't find the separator '" + ModelSeparator + "'.");

			string name = line.Substring(0, separatorIndex);
			string type = line.Substring(separatorIndex + ModelSeparator.Length);
			Column col = new Column(name, type);
			Document.Model.AddColumn(col);
		}

		/// <summary>
		/// Parses an entry line of the document.
		/// </summary>
		/// <param name="line">Document entry line.</param>
		private void ParseEntryLine(string line) {
			Document.Entries.Add(new Entry(line.Split(EntryColumnSeparator)));
		}

		/// <summary>
		/// Entry Logger Document.
		/// </summary>
		public ELDocument Document { get; set; }
	}
}
