// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31040 Offset: 0x31141 VA: 0x31040
private struct ServicePointScheduler.AsyncManualResetEvent.<WaitAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 2574
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public int millisecondTimeout; // 0x20
	public ServicePointScheduler.AsyncManualResetEvent <>4__this; // 0x28
	private Task <timeoutTask>5__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x38

	// Methods

	// RVA: 0x1C15610 Offset: 0x1C15711 VA: 0x1C15610 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32980 Offset: 0x32A81 VA: 0x32980
	// RVA: 0x1C15960 Offset: 0x1C15A61 VA: 0x1C15960 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
private class ServicePointScheduler.AsyncManualResetEvent // TypeDefIndex: 2576
{
	// Fields
	private TaskCompletionSource<bool> m_tcs; // 0x10

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x32910 Offset: 0x32A11 VA: 0x32910
	// RVA: 0x191FC00 Offset: 0x191FD01 VA: 0x191FC00
	public Task<bool> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x191FD90 Offset: 0x191FE91 VA: 0x191FD90
	public void Set() { }

	// RVA: 0x191FB40 Offset: 0x191FC41 VA: 0x191FB40
	public void Reset() { }

	// RVA: 0x1920030 Offset: 0x1920131 VA: 0x1920030
	public void .ctor(bool state) { }
}

