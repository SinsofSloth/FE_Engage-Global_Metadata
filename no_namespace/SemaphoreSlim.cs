// Namespace: 
private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 742
{
	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x1C020B0 Offset: 0x1C021B1 VA: 0x1C020B0
	internal void .ctor() { }

	// RVA: 0x1C02130 Offset: 0x1C02231 VA: 0x1C02130 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1C02190 Offset: 0x1C02291 VA: 0x1C02190 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4731F0 Offset: 0x4732F1 VA: 0x4731F0
private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 743
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public SemaphoreSlim.TaskNode asyncWaiter; // 0x28
	public int millisecondsTimeout; // 0x30
	private CancellationTokenSource <cts>5__1; // 0x38
	public SemaphoreSlim <>4__this; // 0x40
	private object <>7__wrap1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x1C018A0 Offset: 0x1C019A1 VA: 0x1C018A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x47C550 Offset: 0x47C651 VA: 0x47C550
	// RVA: 0x1C02050 Offset: 0x1C02151 VA: 0x1C02050 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

