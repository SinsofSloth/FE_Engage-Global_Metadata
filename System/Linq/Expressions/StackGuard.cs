// Namespace: System.Linq.Expressions
internal sealed class StackGuard // TypeDefIndex: 2871
{
	// Fields
	private int _executionStackCount; // 0x10

	// Methods

	// RVA: 0x332F060 Offset: 0x332F161 VA: 0x332F060
	public bool TryEnterOnCurrentStack() { }

	// RVA: -1 Offset: -1
	public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201F0A0 Offset: 0x201F1A1 VA: 0x201F0A0
	|-StackGuard.RunOnEmptyStack<LightCompiler, Expression>
	|-StackGuard.RunOnEmptyStack<object, object>
	*/

	// RVA: -1 Offset: -1
	private R RunOnEmptyStackCore<R>(Func<object, R> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201F2E0 Offset: 0x201F3E1 VA: 0x201F2E0
	|-StackGuard.RunOnEmptyStackCore<object>
	*/

	// RVA: 0x332F0E0 Offset: 0x332F1E1 VA: 0x332F0E0
	public void .ctor() { }
}

