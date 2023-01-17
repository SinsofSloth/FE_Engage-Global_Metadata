// Namespace: MoonSharp.Interpreter.Execution.VM
internal class CallStackItem // TypeDefIndex: 6187
{
	// Fields
	public int Debug_EntryPoint; // 0x10
	public SymbolRef[] Debug_Symbols; // 0x18
	public SourceRef CallingSourceRef; // 0x20
	public CallbackFunction ClrFunction; // 0x28
	public CallbackFunction Continuation; // 0x30
	public CallbackFunction ErrorHandler; // 0x38
	public DynValue ErrorHandlerBeforeUnwind; // 0x40
	public int BasePointer; // 0x48
	public int ReturnAddress; // 0x4C
	public DynValue[] LocalScope; // 0x50
	public ClosureContext ClosureScope; // 0x58
	public CallStackItemFlags Flags; // 0x60

	// Methods

	// RVA: 0x30F4870 Offset: 0x30F4971 VA: 0x30F4870
	public void .ctor() { }
}

