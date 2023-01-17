// Namespace: UTJ
public static class CSVUtilities // TypeDefIndex: 6408
{
	// Fields
	private const string DefaultSeparators = ",\t";

	// Methods

	// RVA: 0x3106200 Offset: 0x3106301 VA: 0x3106200
	public static string BuildCSVItem(string source) { }

	// RVA: 0x31072A0 Offset: 0x31073A1 VA: 0x31072A0
	public static string BuildCSVItem(string source, string separatorCharacters) { }

	// RVA: 0x3107450 Offset: 0x3107551 VA: 0x3107450
	public static IList<string> ReadNextCSVRow(TextReader reader) { }

	// RVA: 0x31074B0 Offset: 0x31075B1 VA: 0x31074B0
	public static IList<string> ReadNextCSVRow(TextReader reader, string separatorCharacters) { }
}

