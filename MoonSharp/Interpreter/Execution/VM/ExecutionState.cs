// Namespace: MoonSharp.Interpreter.Execution.VM
internal sealed class ExecutionState // TypeDefIndex: 6189
{
	// Fields
	public FastStack<DynValue> ValueStack; // 0x10
	public FastStack<CallStackItem> ExecutionStack; // 0x18
	public int InstructionPtr; // 0x20
	public CoroutineState State; // 0x24

	// Methods

	// RVA: 0x330B800 Offset: 0x330B901 VA: 0x330B800
	public void .ctor() { }
}

