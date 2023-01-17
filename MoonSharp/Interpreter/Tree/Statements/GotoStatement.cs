// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class GotoStatement : Statement // TypeDefIndex: 6010
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE560 Offset: 0xE661 VA: 0xE560
	private SourceRef <SourceRef>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE570 Offset: 0xE671 VA: 0xE570
	private Token <GotoToken>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE580 Offset: 0xE681 VA: 0xE580
	private string <Label>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xE590 Offset: 0xE691 VA: 0xE590
	private int <DefinedVarsCount>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE5A0 Offset: 0xE6A1 VA: 0xE5A0
	private string <LastDefinedVarName>k__BackingField; // 0x40
	private Instruction m_Jump; // 0x48
	private int m_LabelAddress; // 0x50

	// Properties
	internal SourceRef SourceRef { get; set; }
	internal Token GotoToken { get; set; }
	public string Label { get; set; }
	internal int DefinedVarsCount { get; set; }
	internal string LastDefinedVarName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xFFC0 Offset: 0x100C1 VA: 0xFFC0
	// RVA: 0x3316040 Offset: 0x3316141 VA: 0x3316040
	internal SourceRef get_SourceRef() { }

	[CompilerGeneratedAttribute] // RVA: 0xFFD0 Offset: 0x100D1 VA: 0xFFD0
	// RVA: 0x3316050 Offset: 0x3316151 VA: 0x3316050
	private void set_SourceRef(SourceRef value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFFE0 Offset: 0x100E1 VA: 0xFFE0
	// RVA: 0x3316060 Offset: 0x3316161 VA: 0x3316060
	internal Token get_GotoToken() { }

	[CompilerGeneratedAttribute] // RVA: 0xFFF0 Offset: 0x100F1 VA: 0xFFF0
	// RVA: 0x3316070 Offset: 0x3316171 VA: 0x3316070
	private void set_GotoToken(Token value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10000 Offset: 0x10101 VA: 0x10000
	// RVA: 0x3316080 Offset: 0x3316181 VA: 0x3316080
	public string get_Label() { }

	[CompilerGeneratedAttribute] // RVA: 0x10010 Offset: 0x10111 VA: 0x10010
	// RVA: 0x3316090 Offset: 0x3316191 VA: 0x3316090
	private void set_Label(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10020 Offset: 0x10121 VA: 0x10020
	// RVA: 0x33160A0 Offset: 0x33161A1 VA: 0x33160A0
	internal int get_DefinedVarsCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x10030 Offset: 0x10131 VA: 0x10030
	// RVA: 0x33160B0 Offset: 0x33161B1 VA: 0x33160B0
	private void set_DefinedVarsCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10040 Offset: 0x10141 VA: 0x10040
	// RVA: 0x33160C0 Offset: 0x33161C1 VA: 0x33160C0
	internal string get_LastDefinedVarName() { }

	[CompilerGeneratedAttribute] // RVA: 0x10050 Offset: 0x10151 VA: 0x10050
	// RVA: 0x33160D0 Offset: 0x33161D1 VA: 0x33160D0
	private void set_LastDefinedVarName(string value) { }

	// RVA: 0x33160E0 Offset: 0x33161E1 VA: 0x33160E0
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x3316190 Offset: 0x3316291 VA: 0x3316190 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x33161E0 Offset: 0x33162E1 VA: 0x33161E0
	internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName) { }

	// RVA: 0x33161F0 Offset: 0x33162F1 VA: 0x33161F0
	internal void SetAddress(int labelAddress) { }
}

