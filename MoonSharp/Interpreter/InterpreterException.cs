// Namespace: MoonSharp.Interpreter
[Serializable]
public class InterpreterException : Exception // TypeDefIndex: 5958
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE310 Offset: 0xE411 VA: 0xE310
	private int <InstructionPtr>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0xE320 Offset: 0xE421 VA: 0xE320
	private IList<WatchItem> <CallStack>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0xE330 Offset: 0xE431 VA: 0xE330
	private string <DecoratedMessage>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0xE340 Offset: 0xE441 VA: 0xE340
	private bool <DoNotDecorateMessage>k__BackingField; // 0xA0

	// Properties
	public int InstructionPtr { get; set; }
	public IList<WatchItem> CallStack { get; set; }
	public string DecoratedMessage { get; set; }
	public bool DoNotDecorateMessage { get; set; }

	// Methods

	// RVA: 0x3318DC0 Offset: 0x3318EC1 VA: 0x3318DC0
	protected void .ctor(Exception ex, string message) { }

	// RVA: 0x3318E50 Offset: 0x3318F51 VA: 0x3318E50
	protected void .ctor(Exception ex) { }

	// RVA: 0x3318AE0 Offset: 0x3318BE1 VA: 0x3318AE0
	protected void .ctor(string message) { }

	// RVA: 0x3318C00 Offset: 0x3318D01 VA: 0x3318C00
	protected void .ctor(string format, object[] args) { }

	[CompilerGeneratedAttribute] // RVA: 0xFA90 Offset: 0xFB91 VA: 0xFA90
	// RVA: 0x3318EE0 Offset: 0x3318FE1 VA: 0x3318EE0
	public int get_InstructionPtr() { }

	[CompilerGeneratedAttribute] // RVA: 0xFAA0 Offset: 0xFBA1 VA: 0xFAA0
	// RVA: 0x3318EF0 Offset: 0x3318FF1 VA: 0x3318EF0
	internal void set_InstructionPtr(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFAB0 Offset: 0xFBB1 VA: 0xFAB0
	// RVA: 0x3318F00 Offset: 0x3319001 VA: 0x3318F00
	public IList<WatchItem> get_CallStack() { }

	[CompilerGeneratedAttribute] // RVA: 0xFAC0 Offset: 0xFBC1 VA: 0xFAC0
	// RVA: 0x3318F10 Offset: 0x3319011 VA: 0x3318F10
	internal void set_CallStack(IList<WatchItem> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFAD0 Offset: 0xFBD1 VA: 0xFAD0
	// RVA: 0x3318F20 Offset: 0x3319021 VA: 0x3318F20
	public string get_DecoratedMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0xFAE0 Offset: 0xFBE1 VA: 0xFAE0
	// RVA: 0x3318F30 Offset: 0x3319031 VA: 0x3318F30
	internal void set_DecoratedMessage(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFAF0 Offset: 0xFBF1 VA: 0xFAF0
	// RVA: 0x3318F40 Offset: 0x3319041 VA: 0x3318F40
	public bool get_DoNotDecorateMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0xFB00 Offset: 0xFC01 VA: 0xFB00
	// RVA: 0x3318F50 Offset: 0x3319051 VA: 0x3318F50
	public void set_DoNotDecorateMessage(bool value) { }

	// RVA: 0x3318F60 Offset: 0x3319061 VA: 0x3318F60
	internal void DecorateMessage(Script script, SourceRef sref, int ip = -1) { }

	// RVA: 0x33190C0 Offset: 0x33191C1 VA: 0x33190C0 Slot: 18
	public virtual void Rethrow() { }
}

