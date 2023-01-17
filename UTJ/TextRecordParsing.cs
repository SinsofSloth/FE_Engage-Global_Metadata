// Namespace: UTJ
public class TextRecordParsing // TypeDefIndex: 6426
{
	// Fields
	public const string DefaultSeparators = "\t,";

	// Properties
	public static IEnumerable<string> DefaultCommentPrefixes { get; }

	// Methods

	// RVA: 0x3A76CA0 Offset: 0x3A76DA1 VA: 0x3A76CA0
	public static IEnumerable<string> get_DefaultCommentPrefixes() { }

	// RVA: 0x3A76E20 Offset: 0x3A76F21 VA: 0x3A76E20
	public static string GetString(List<string> items, int index) { }

	// RVA: 0x3A76EC0 Offset: 0x3A76FC1 VA: 0x3A76EC0
	public static bool GetBool(List<string> items, int index) { }

	// RVA: 0x3A77070 Offset: 0x3A77171 VA: 0x3A77070
	public static bool GetInt(List<string> items, int index, ref int output) { }

	// RVA: 0x3A77140 Offset: 0x3A77241 VA: 0x3A77140
	public static bool GetFloat(List<string> items, int index, ref float output) { }

	// RVA: 0x3A77210 Offset: 0x3A77311 VA: 0x3A77210
	public static bool GetVector3(List<string> items, int startIndex, ref Vector3 output) { }

	// RVA: 0x3A77340 Offset: 0x3A77441 VA: 0x3A77340
	public static List<TextRecordParsing.Record> ParseRecordsFromReader(TextReader reader, string entrySeparators = "\t,", IEnumerable<string> commentPrefixes) { }

	// RVA: 0x3A777A0 Offset: 0x3A778A1 VA: 0x3A777A0
	public static List<TextRecordParsing.Record> ParseRecordsFromFile(string sourcePath, Encoding encoding, string entrySeparators = "\t,", IEnumerable<string> commentPrefixes) { }

	// RVA: 0x3A77A60 Offset: 0x3A77B61 VA: 0x3A77A60
	public static List<TextRecordParsing.Record> ParseRecordsFromText(string sourceText, string entrySeparators = "\t,", IEnumerable<string> commentPrefixes) { }

	// RVA: 0x3A77D00 Offset: 0x3A77E01 VA: 0x3A77D00
	public static List<TextRecordParsing.Record> GetSectionRecords(List<TextRecordParsing.Record> sourceRecords, string sectionName) { }

	// RVA: 0x3A775D0 Offset: 0x3A776D1 VA: 0x3A775D0
	private static bool LineIsCommentedOut(string trimmedLine, IEnumerable<string> commentPrefixes) { }

	// RVA: 0x3A78030 Offset: 0x3A78131 VA: 0x3A78030
	public void .ctor() { }
}

