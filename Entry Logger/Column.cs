namespace EntryLogger {
	/// <summary>
	/// Abstraction class that represents a column in a data model.
	/// </summary>
	public class Column {
		/// <summary>
		/// Constructs a column with a name pre-populated.
		/// </summary>
		/// <param name="name">Name of the column.</param>
		public Column(string name) {
			Name = name;
		}

		/// <summary>
		/// Returns the string representation of the object.
		/// </summary>
		/// <returns>Name of the column.</returns>
		public override string ToString() {
			return Name;
		}

		/// <summary>
		/// Name of the column.
		/// </summary>
		public string Name { get; set; }
	}
}