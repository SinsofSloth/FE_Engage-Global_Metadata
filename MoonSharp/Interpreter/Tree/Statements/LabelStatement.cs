// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class LabelStatement : Statement // TypeDefIndex: 6013
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE5B0 Offset: 0xE6B1 VA: 0xE5B0
	private string <Label>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE5C0 Offset: 0xE6C1 VA: 0xE5C0
	private int <Address>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE5D0 Offset: 0xE6D1 VA: 0xE5D0
	private SourceRef <SourceRef>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xE5E0 Offset: 0xE6E1 VA: 0xE5E0
	private Token <NameToken>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE5F0 Offset: 0xE6F1 VA: 0xE5F0
	private int <DefinedVarsCount>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xE600 Offset: 0xE701 VA: 0xE600
	private string <LastDefinedVarName>k__BackingField; // 0x48
	private List<GotoStatement> m_Gotos; // 0x50
	private RuntimeScopeBlock m_StackFrame; // 0x58

	// Properties
	public string Label { get; set; }
	public int Address { get; set; }
	public SourceRef SourceRef { get; set; }
	public Token NameToken { get; set; }
	internal int DefinedVarsCount { get; set; }
	internal string LastDefinedVarName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10060 Offset: 0x10161 VA: 0x10060
	// RVA: 0x331D3D0 Offset: 0x331D4D1 VA: 0x331D3D0
	public string get_Label() { }

	[CompilerGeneratedAttribute] // RVA: 0x10070 Offset: 0x10171 VA: 0x10070
	// RVA: 0x331D3E0 Offset: 0x331D4E1 VA: 0x331D3E0
	private void set_Label(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10080 Offset: 0x10181 VA: 0x10080
	// RVA: 0x331D3F0 Offset: 0x331D4F1 VA: 0x331D3F0
	public int get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x10090 Offset: 0x10191 VA: 0x10090
	// RVA: 0x331D400 Offset: 0x331D501 VA: 0x331D400
	private void set_Address(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x100A0 Offset: 0x101A1 VA: 0x100A0
	// RVA: 0x331D410 Offset: 0x331D511 VA: 0x331D410
	public SourceRef get_SourceRef() { }

	[CompilerGeneratedAttribute] // RVA: 0x100B0 Offset: 0x101B1 VA: 0x100B0
	// RVA: 0x331D420 Offset: 0x331D521 VA: 0x331D420
	private void set_SourceRef(SourceRef value) { }

	[CompilerGeneratedAttribute] // RVA: 0x100C0 Offset: 0x101C1 VA: 0x100C0
	// RVA: 0x331D430 Offset: 0x331D531 VA: 0x331D430
	public Token get_NameToken() { }

	[CompilerGeneratedAttribute] // RVA: 0x100D0 Offset: 0x101D1 VA: 0x100D0
	// RVA: 0x331D440 Offset: 0x331D541 VA: 0x331D440
	private void set_NameToken(Token value) { }

	[CompilerGeneratedAttribute] // RVA: 0x100E0 Offset: 0x101E1 VA: 0x100E0
	// RVA: 0x331D450 Offset: 0x331D551 VA: 0x331D450
	internal int get_DefinedVarsCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x100F0 Offset: 0x101F1 VA: 0x100F0
	// RVA: 0x331D460 Offset: 0x331D561 VA: 0x331D460
	private void set_DefinedVarsCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10100 Offset: 0x10201 VA: 0x10100
	// RVA: 0x331D470 Offset: 0x331D571 VA: 0x331D470
	internal string get_LastDefinedVarName() { }

	[CompilerGeneratedAttribute] // RVA: 0x10110 Offset: 0x10211 VA: 0x10110
	// RVA: 0x331D480 Offset: 0x331D581 VA: 0x331D480
	private void set_LastDefinedVarName(string value) { }

	// RVA: 0x331D490 Offset: 0x331D591 VA: 0x331D490
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x331D5C0 Offset: 0x331D6C1 VA: 0x331D5C0
	internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName) { }

	// RVA: 0x331D5D0 Offset: 0x331D6D1 VA: 0x331D5D0
	internal void RegisterGoto(GotoStatement gotostat) { }

	// RVA: 0x331D630 Offset: 0x331D731 VA: 0x331D630 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x331D770 Offset: 0x331D871 VA: 0x331D770
	internal void SetScope(RuntimeScopeBlock runtimeScopeBlock) { }
}

