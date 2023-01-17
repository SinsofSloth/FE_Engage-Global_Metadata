// Namespace: 
private class EnumeratorAsyncExtensions.EnumeratorAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem // TypeDefIndex: 4915
{
	// Fields
	private IEnumerator innerEnumerator; // 0x10
	private CancellationToken cancellationToken; // 0x18
	private Action continuation; // 0x20
	private AwaiterStatus status; // 0x28
	private ExceptionDispatchInfo exception; // 0x30

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x2E82150 Offset: 0x2E82251 VA: 0x2E82150
	public void .ctor(IEnumerator innerEnumerator, CancellationToken cancellationToken) { }

	// RVA: 0x2E821F0 Offset: 0x2E822F1 VA: 0x2E821F0 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x2E8FBB0 Offset: 0x2E8FCB1 VA: 0x2E8FBB0 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x2E8FBC0 Offset: 0x2E8FCC1 VA: 0x2E8FBC0 Slot: 6
	public void GetResult() { }

	// RVA: 0x2E8FC00 Offset: 0x2E8FD01 VA: 0x2E8FC00 Slot: 9
	public bool MoveNext() { }

	// RVA: 0x2E8FD70 Offset: 0x2E8FE71 VA: 0x2E8FD70
	private void InvokeContinuation(AwaiterStatus status) { }

	// RVA: 0x2E8FE40 Offset: 0x2E8FF41 VA: 0x2E8FE40 Slot: 8
	public void OnCompleted(Action continuation) { }

	// RVA: 0x2E8FED0 Offset: 0x2E8FFD1 VA: 0x2E8FED0 Slot: 7
	public void UnsafeOnCompleted(Action continuation) { }
}

