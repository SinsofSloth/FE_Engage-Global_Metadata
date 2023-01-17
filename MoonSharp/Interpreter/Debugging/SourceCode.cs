// Namespace: MoonSharp.Interpreter.Debugging
public class SourceCode : IScriptPrivateResource // TypeDefIndex: 6215
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xEC70 Offset: 0xED71 VA: 0xEC70
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xEC80 Offset: 0xED81 VA: 0xEC80
	private string <Code>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xEC90 Offset: 0xED91 VA: 0xEC90
	private string[] <Lines>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xECA0 Offset: 0xEDA1 VA: 0xECA0
	private Script <OwnerScript>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xECB0 Offset: 0xEDB1 VA: 0xECB0
	private int <SourceID>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xECC0 Offset: 0xEDC1 VA: 0xECC0
	private List<SourceRef> <Refs>k__BackingField; // 0x38

	// Properties
	public string Name { get; set; }
	public string Code { get; set; }
	public string[] Lines { get; set; }
	public Script OwnerScript { get; set; }
	public int SourceID { get; set; }
	internal List<SourceRef> Refs { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11230 Offset: 0x11331 VA: 0x11230
	// RVA: 0x301FA90 Offset: 0x301FB91 VA: 0x301FA90
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x11240 Offset: 0x11341 VA: 0x11240
	// RVA: 0x301FAA0 Offset: 0x301FBA1 VA: 0x301FAA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11250 Offset: 0x11351 VA: 0x11250
	// RVA: 0x301FAB0 Offset: 0x301FBB1 VA: 0x301FAB0
	public string get_Code() { }

	[CompilerGeneratedAttribute] // RVA: 0x11260 Offset: 0x11361 VA: 0x11260
	// RVA: 0x301FAC0 Offset: 0x301FBC1 VA: 0x301FAC0
	private void set_Code(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11270 Offset: 0x11371 VA: 0x11270
	// RVA: 0x301FAD0 Offset: 0x301FBD1 VA: 0x301FAD0
	public string[] get_Lines() { }

	[CompilerGeneratedAttribute] // RVA: 0x11280 Offset: 0x11381 VA: 0x11280
	// RVA: 0x301FAE0 Offset: 0x301FBE1 VA: 0x301FAE0
	private void set_Lines(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11290 Offset: 0x11391 VA: 0x11290
	// RVA: 0x301FAF0 Offset: 0x301FBF1 VA: 0x301FAF0 Slot: 4
	public Script get_OwnerScript() { }

	[CompilerGeneratedAttribute] // RVA: 0x112A0 Offset: 0x113A1 VA: 0x112A0
	// RVA: 0x301FB00 Offset: 0x301FC01 VA: 0x301FB00
	private void set_OwnerScript(Script value) { }

	[CompilerGeneratedAttribute] // RVA: 0x112B0 Offset: 0x113B1 VA: 0x112B0
	// RVA: 0x301FB10 Offset: 0x301FC11 VA: 0x301FB10
	public int get_SourceID() { }

	[CompilerGeneratedAttribute] // RVA: 0x112C0 Offset: 0x113C1 VA: 0x112C0
	// RVA: 0x301FB20 Offset: 0x301FC21 VA: 0x301FB20
	private void set_SourceID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x112D0 Offset: 0x113D1 VA: 0x112D0
	// RVA: 0x301FB30 Offset: 0x301FC31 VA: 0x301FB30
	internal List<SourceRef> get_Refs() { }

	[CompilerGeneratedAttribute] // RVA: 0x112E0 Offset: 0x113E1 VA: 0x112E0
	// RVA: 0x301FB40 Offset: 0x301FC41 VA: 0x301FB40
	private void set_Refs(List<SourceRef> value) { }

	// RVA: 0x3017490 Offset: 0x3017591 VA: 0x3017490
	internal void .ctor(string name, string code, int sourceID, Script ownerScript) { }

	// RVA: 0x301FB50 Offset: 0x301FC51 VA: 0x301FB50
	public string GetCodeSnippet(SourceRef sourceCodeRef) { }

	// RVA: 0x301FEB0 Offset: 0x301FFB1 VA: 0x301FEB0
	private int AdjustStrIndex(string str, int loc) { }
}

