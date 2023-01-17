// Namespace: 
public class DynamicsSetup.ImportSettings // TypeDefIndex: 6357
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B680 Offset: 0x5B781 VA: 0x5B680
	private bool <ImportSpringBones>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5B690 Offset: 0x5B791 VA: 0x5B690
	private bool <ImportCollision>k__BackingField; // 0x11

	// Properties
	public bool ImportSpringBones { get; set; }
	public bool ImportCollision { get; set; }

	// Methods

	// RVA: 0x3A79950 Offset: 0x3A79A51 VA: 0x3A79950
	public void .ctor() { }

	// RVA: 0x3A79980 Offset: 0x3A79A81 VA: 0x3A79980
	public void .ctor(DynamicsSetup.ImportSettings sourceSettings) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C0E0 Offset: 0x5C1E1 VA: 0x5C0E0
	// RVA: 0x3A799C0 Offset: 0x3A79AC1 VA: 0x3A799C0
	public bool get_ImportSpringBones() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C0F0 Offset: 0x5C1F1 VA: 0x5C0F0
	// RVA: 0x3A799D0 Offset: 0x3A79AD1 VA: 0x3A799D0
	public void set_ImportSpringBones(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C100 Offset: 0x5C201 VA: 0x5C100
	// RVA: 0x3A799E0 Offset: 0x3A79AE1 VA: 0x3A799E0
	public bool get_ImportCollision() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C110 Offset: 0x5C211 VA: 0x5C110
	// RVA: 0x3A799F0 Offset: 0x3A79AF1 VA: 0x3A799F0
	public void set_ImportCollision(bool value) { }
}

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
public class DynamicsSetup.ParseResults // TypeDefIndex: 6359
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5B6E0 Offset: 0x5B7E1 VA: 0x5B6E0
	private DynamicsSetup <Setup>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5B6F0 Offset: 0x5B7F1 VA: 0x5B6F0
	private List<DynamicsSetup.ParseMessage> <Errors>k__BackingField; // 0x18

	// Properties
	public DynamicsSetup Setup { get; set; }
	public List<DynamicsSetup.ParseMessage> Errors { get; set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x3A79CF0 Offset: 0x3A79DF1 VA: 0x3A79CF0
	public void .ctor() { }

	// RVA: 0x3A79D90 Offset: 0x3A79E91 VA: 0x3A79D90
	public void .ctor(DynamicsSetup setup, IEnumerable<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x3A79E20 Offset: 0x3A79F21 VA: 0x3A79E20
	public static DynamicsSetup.ParseResults Failure(string error) { }

	// RVA: 0x3A79FD0 Offset: 0x3A7A0D1 VA: 0x3A79FD0
	public static DynamicsSetup.ParseResults Failure(IEnumerable<DynamicsSetup.ParseMessage> errors) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1A0 Offset: 0x5C2A1 VA: 0x5C1A0
	// RVA: 0x3A7A090 Offset: 0x3A7A191 VA: 0x3A7A090
	public DynamicsSetup get_Setup() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1B0 Offset: 0x5C2B1 VA: 0x5C1B0
	// RVA: 0x3A7A0A0 Offset: 0x3A7A1A1 VA: 0x3A7A0A0
	private void set_Setup(DynamicsSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1C0 Offset: 0x5C2C1 VA: 0x5C1C0
	// RVA: 0x3A7A0B0 Offset: 0x3A7A1B1 VA: 0x3A7A0B0
	public List<DynamicsSetup.ParseMessage> get_Errors() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C1D0 Offset: 0x5C2D1 VA: 0x5C1D0
	// RVA: 0x3A7A0C0 Offset: 0x3A7A1C1 VA: 0x3A7A0C0
	private void set_Errors(List<DynamicsSetup.ParseMessage> value) { }

	// RVA: 0x3A7A0D0 Offset: 0x3A7A1D1 VA: 0x3A7A0D0
	public bool get_HasErrors() { }

	// RVA: 0x3A7A120 Offset: 0x3A7A221 VA: 0x3A7A120
	public void LogErrors() { }
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

