// Namespace: 
public class DynamicsSetup.ParseMessage // TypeDefIndex: 6358
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B6A0 Offset: 0x5B7A1 VA: 0x5B6A0
	private string <Message>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5B6B0 Offset: 0x5B7B1 VA: 0x5B6B0
	private string <SourceLine>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x5B6C0 Offset: 0x5B7C1 VA: 0x5B6C0
	private string <Exception>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x5B6D0 Offset: 0x5B7D1 VA: 0x5B6D0
	private Object <Context>k__BackingField; // 0x28

	// Properties
	public string Message { get; set; }
	public string SourceLine { get; set; }
	public string Exception { get; set; }
	public Object Context { get; set; }

	// Methods

	// RVA: 0x3A79A00 Offset: 0x3A79B01 VA: 0x3A79A00
	public void .ctor(string message, string sourceLine = "", string exception = "", Object context) { }

	// RVA: 0x3A79A80 Offset: 0x3A79B81 VA: 0x3A79A80
	public void .ctor(string message, IEnumerable<string> sourceLineItems, string exception = "", Object context) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C120 Offset: 0x5C221 VA: 0x5C120
	// RVA: 0x3A79BA0 Offset: 0x3A79CA1 VA: 0x3A79BA0
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C130 Offset: 0x5C231 VA: 0x5C130
	// RVA: 0x3A79BB0 Offset: 0x3A79CB1 VA: 0x3A79BB0
	private void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C140 Offset: 0x5C241 VA: 0x5C140
	// RVA: 0x3A79BC0 Offset: 0x3A79CC1 VA: 0x3A79BC0
	public string get_SourceLine() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C150 Offset: 0x5C251 VA: 0x5C150
	// RVA: 0x3A79BD0 Offset: 0x3A79CD1 VA: 0x3A79BD0
	private void set_SourceLine(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C160 Offset: 0x5C261 VA: 0x5C160
	// RVA: 0x3A79BE0 Offset: 0x3A79CE1 VA: 0x3A79BE0
	public string get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C170 Offset: 0x5C271 VA: 0x5C170
	// RVA: 0x3A79BF0 Offset: 0x3A79CF1 VA: 0x3A79BF0
	private void set_Exception(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C180 Offset: 0x5C281 VA: 0x5C180
	// RVA: 0x3A79C00 Offset: 0x3A79D01 VA: 0x3A79C00
	public Object get_Context() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C190 Offset: 0x5C291 VA: 0x5C190
	// RVA: 0x3A79C10 Offset: 0x3A79D11 VA: 0x3A79C10
	private void set_Context(Object value) { }

	// RVA: 0x3A79C20 Offset: 0x3A79D21 VA: 0x3A79C20
	public string ToLogMessage() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B250 Offset: 0x5B351 VA: 0x5B250
[Serializable]
private sealed class DynamicsSetup.<>c // TypeDefIndex: 6360
{
	// Fields
	public static readonly DynamicsSetup.<>c <>9; // 0x0
	public static Func<TextRecordParsing.Record, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x3A79770 Offset: 0x3A79871 VA: 0x3A79770
	private static void .cctor() { }

	// RVA: 0x3A797E0 Offset: 0x3A798E1 VA: 0x3A797E0
	public void .ctor() { }

	// RVA: 0x3A797F0 Offset: 0x3A798F1 VA: 0x3A797F0
	internal bool <GetVersionFromSetupRecords>b__6_0(TextRecordParsing.Record item) { }
}

