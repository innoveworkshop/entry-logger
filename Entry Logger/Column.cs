namespace EntryLogger {
	/// <summary>
	/// Abstraction class that represents a column in a data model.
	/// </summary>
	public class Column {
		/// <summary>
		/// Constructs a column with a name pre-populated.
		/// </summary>
		/// <param name="name">Name of the column.</param>
		/// <param name="type">Type of the column.</param>
		public Column(string name, string type) {
			Name = name;
			Type = type;
		}
		/// <summary>
		/// Constructs a column with a name pre-populated.
		/// </summary>
		/// <param name="name">Name of the column.</param>
		/// <param name="type">Type of the column.</param>
		/// <param name="replaceSpaces">Replace the spaces in the name with dashes?</param>
		public Column(string name, string type, bool replaceSpaces) : this(name, type) {
			if (replaceSpaces)
				Name = name.Replace(' ', '-');
		}

		/// <summary>
		/// Returns the string representation of the object.
		/// </summary>
		/// <returns>Name of the column.</returns>
		public override string ToString() {
			return Name.Replace('-', ' ');
		}

		/// <summary>
		/// Name of the column.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Type of the column.
		/// </summary>
		public string Type { get; set; }
	}
}