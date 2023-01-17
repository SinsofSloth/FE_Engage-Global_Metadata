// Namespace: MoonSharp.Interpreter.Execution.Scopes
internal class BuildTimeScopeFrame // TypeDefIndex: 6199
{
	// Fields
	private BuildTimeScopeBlock m_ScopeTreeRoot; // 0x10
	private BuildTimeScopeBlock m_ScopeTreeHead; // 0x18
	private RuntimeScopeFrame m_ScopeFrame; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xEBA0 Offset: 0xECA1 VA: 0xEBA0
	private bool <HasVarArgs>k__BackingField; // 0x28

	// Properties
	public bool HasVarArgs { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11090 Offset: 0x11191 VA: 0x11090
	// RVA: 0x30F2550 Offset: 0x30F2651 VA: 0x30F2550
	public bool get_HasVarArgs() { }

	[CompilerGeneratedAttribute] // RVA: 0x110A0 Offset: 0x111A1 VA: 0x110A0
	// RVA: 0x30F2560 Offset: 0x30F2661 VA: 0x30F2560
	private void set_HasVarArgs(bool value) { }

	// RVA: 0x30F05F0 Offset: 0x30F06F1 VA: 0x30F05F0
	internal void .ctor(bool hasVarArgs) { }

	// RVA: 0x30F07B0 Offset: 0x30F08B1 VA: 0x30F07B0
	internal void PushBlock() { }

	// RVA: 0x30F08B0 Offset: 0x30F09B1 VA: 0x30F08B0
	internal RuntimeScopeBlock PopBlock() { }

	// RVA: 0x30F0AC0 Offset: 0x30F0BC1 VA: 0x30F0AC0
	internal RuntimeScopeFrame GetRuntimeFrameData() { }

	// RVA: 0x30F0CE0 Offset: 0x30F0DE1 VA: 0x30F0CE0
	internal SymbolRef Find(string name) { }

	// RVA: 0x30F10B0 Offset: 0x30F11B1 VA: 0x30F10B0
	internal SymbolRef DefineLocal(string name) { }

	// RVA: 0x30F10C0 Offset: 0x30F11C1 VA: 0x30F10C0
	internal SymbolRef TryDefineLocal(string name) { }

	// RVA: 0x30F0A90 Offset: 0x30F0B91 VA: 0x30F0A90
	internal void ResolveLRefs() { }

	// RVA: 0x30F1CF0 Offset: 0x30F1DF1 VA: 0x30F1CF0
	internal int AllocVar(SymbolRef var) { }

	// RVA: 0x30F1D80 Offset: 0x30F1E81 VA: 0x30F1D80
	internal int GetPosForNextVar() { }

	// RVA: 0x30F1220 Offset: 0x30F1321 VA: 0x30F1220
	internal void DefineLabel(LabelStatement label) { }

	// RVA: 0x30F12A0 Offset: 0x30F13A1 VA: 0x30F12A0
	internal void RegisterGoto(GotoStatement gotostat) { }
}

