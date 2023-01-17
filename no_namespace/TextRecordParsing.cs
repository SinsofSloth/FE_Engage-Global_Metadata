// Namespace: 
public class TextRecordParsing.Record // TypeDefIndex: 6422
{
	// Fields
	private List<string> items; // 0x10

	// Properties
	public int Count { get; }
	public IEnumerable<string> Items { get; }

	// Methods

	// RVA: 0x3A776D0 Offset: 0x3A777D1 VA: 0x3A776D0
	public void .ctor(IEnumerable<string> initialItems) { }

	// RVA: 0x3A7F240 Offset: 0x3A7F341 VA: 0x3A7F240
	public int get_Count() { }

	// RVA: 0x3A7F290 Offset: 0x3A7F391 VA: 0x3A7F290
	public IEnumerable<string> get_Items() { }

	// RVA: 0x3A798B0 Offset: 0x3A799B1 VA: 0x3A798B0
	public string GetString(int index) { }

	// RVA: 0x3A7F2A0 Offset: 0x3A7F3A1 VA: 0x3A7F2A0
	public bool GetBool(int index) { }

	// RVA: 0x3A7F2B0 Offset: 0x3A7F3B1 VA: 0x3A7F2B0
	public bool TryGetInt(int index, ref int output) { }

	// RVA: 0x3A7F380 Offset: 0x3A7F481 VA: 0x3A7F380
	public bool TryGetFloat(int index, ref float output) { }

	// RVA: 0x3A7F450 Offset: 0x3A7F551 VA: 0x3A7F450
	public bool TryGetVector3(int startIndex, ref Vector3 output) { }

	// RVA: 0x3A7F460 Offset: 0x3A7F561 VA: 0x3A7F460
	public Queue<string> ToQueue() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B430 Offset: 0x5B531 VA: 0x5B430
[Serializable]
private sealed class TextRecordParsing.<>c // TypeDefIndex: 6423
{
	// Fields
	public static readonly TextRecordParsing.<>c <>9; // 0x0
	public static Func<string, string> <>9__9_0; // 0x8
	public static Func<TextRecordParsing.Record, bool> <>9__12_1; // 0x10

	// Methods

	// RVA: 0x3A7F030 Offset: 0x3A7F131 VA: 0x3A7F030
	private static void .cctor() { }

	// RVA: 0x3A7F0A0 Offset: 0x3A7F1A1 VA: 0x3A7F0A0
	public void .ctor() { }

	// RVA: 0x3A7F0B0 Offset: 0x3A7F1B1 VA: 0x3A7F0B0
	internal string <ParseRecordsFromReader>b__9_0(string item) { }

	// RVA: 0x3A7F0C0 Offset: 0x3A7F1C1 VA: 0x3A7F0C0
	internal bool <GetSectionRecords>b__12_1(TextRecordParsing.Record item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B440 Offset: 0x5B541 VA: 0x5B440
private sealed class TextRecordParsing.<>c__DisplayClass12_0 // TypeDefIndex: 6424
{
	// Fields
	public string sectionName; // 0x10

	// Methods

	// RVA: 0x3A78010 Offset: 0x3A78111 VA: 0x3A78010
	public void .ctor() { }

	// RVA: 0x3A7F180 Offset: 0x3A7F281 VA: 0x3A7F180
	internal bool <GetSectionRecords>b__0(TextRecordParsing.Record item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B450 Offset: 0x5B551 VA: 0x5B450
private sealed class TextRecordParsing.<>c__DisplayClass13_0 // TypeDefIndex: 6425
{
	// Fields
	public string trimmedLine; // 0x10

	// Methods

	// RVA: 0x3A78020 Offset: 0x3A78121 VA: 0x3A78020
	public void .ctor() { }

	// RVA: 0x3A7F220 Offset: 0x3A7F321 VA: 0x3A7F220
	internal bool <LineIsCommentedOut>b__0(string prefix) { }
}

