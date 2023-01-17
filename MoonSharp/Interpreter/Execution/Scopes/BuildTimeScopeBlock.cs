// Namespace: MoonSharp.Interpreter.Execution.Scopes
internal class BuildTimeScopeBlock // TypeDefIndex: 6198
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xEB70 Offset: 0xEC71 VA: 0xEB70
	private BuildTimeScopeBlock <Parent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xEB80 Offset: 0xEC81 VA: 0xEB80
	private List<BuildTimeScopeBlock> <ChildNodes>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xEB90 Offset: 0xEC91 VA: 0xEB90
	private RuntimeScopeBlock <ScopeBlock>k__BackingField; // 0x20
	private Dictionary<string, SymbolRef> m_DefinedNames; // 0x28
	private List<GotoStatement> m_PendingGotos; // 0x30
	private Dictionary<string, LabelStatement> m_LocalLabels; // 0x38
	private string m_LastDefinedName; // 0x40

	// Properties
	internal BuildTimeScopeBlock Parent { get; set; }
	internal List<BuildTimeScopeBlock> ChildNodes { get; set; }
	internal RuntimeScopeBlock ScopeBlock { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11030 Offset: 0x11131 VA: 0x11030
	// RVA: 0x30F1390 Offset: 0x30F1491 VA: 0x30F1390
	internal BuildTimeScopeBlock get_Parent() { }

	[CompilerGeneratedAttribute] // RVA: 0x11040 Offset: 0x11141 VA: 0x11040
	// RVA: 0x30F13A0 Offset: 0x30F14A1 VA: 0x30F13A0
	private void set_Parent(BuildTimeScopeBlock value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11050 Offset: 0x11151 VA: 0x11050
	// RVA: 0x30F13B0 Offset: 0x30F14B1 VA: 0x30F13B0
	internal List<BuildTimeScopeBlock> get_ChildNodes() { }

	[CompilerGeneratedAttribute] // RVA: 0x11060 Offset: 0x11161 VA: 0x11060
	// RVA: 0x30F13C0 Offset: 0x30F14C1 VA: 0x30F13C0
	private void set_ChildNodes(List<BuildTimeScopeBlock> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11070 Offset: 0x11171 VA: 0x11070
	// RVA: 0x30F13D0 Offset: 0x30F14D1 VA: 0x30F13D0
	internal RuntimeScopeBlock get_ScopeBlock() { }

	[CompilerGeneratedAttribute] // RVA: 0x11080 Offset: 0x11181 VA: 0x11080
	// RVA: 0x30F13E0 Offset: 0x30F14E1 VA: 0x30F13E0
	private void set_ScopeBlock(RuntimeScopeBlock value) { }

	// RVA: 0x30F13F0 Offset: 0x30F14F1 VA: 0x30F13F0
	internal void Rename(string name) { }

	// RVA: 0x30F1550 Offset: 0x30F1651 VA: 0x30F1550
	internal void .ctor(BuildTimeScopeBlock parent) { }

	// RVA: 0x30F1690 Offset: 0x30F1791 VA: 0x30F1690
	internal BuildTimeScopeBlock AddChild() { }

	// RVA: 0x30F1720 Offset: 0x30F1821 VA: 0x30F1720
	internal SymbolRef Find(string name) { }

	// RVA: 0x30F1780 Offset: 0x30F1881 VA: 0x30F1780
	internal SymbolRef Define(string name) { }

	// RVA: 0x30F1840 Offset: 0x30F1941 VA: 0x30F1840
	internal int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame) { }

	// RVA: 0x30F1DD0 Offset: 0x30F1ED1 VA: 0x30F1DD0
	internal void DefineLabel(LabelStatement label) { }

	// RVA: 0x30F1FE0 Offset: 0x30F20E1 VA: 0x30F1FE0
	internal void RegisterGoto(GotoStatement gotostat) { }

	// RVA: 0x30F20D0 Offset: 0x30F21D1 VA: 0x30F20D0
	internal void ResolveGotos() { }
}

