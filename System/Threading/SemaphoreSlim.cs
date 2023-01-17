// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4731A0 Offset: 0x4732A1 VA: 0x4731A0
[DebuggerDisplayAttribute] // RVA: 0x4731A0 Offset: 0x4732A1 VA: 0x4731A0
public class SemaphoreSlim : IDisposable // TypeDefIndex: 744
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x8

	// Methods

	// RVA: 0x3615D30 Offset: 0x3615E31 VA: 0x3615D30
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x3615F30 Offset: 0x3616031 VA: 0x3615F30
	public void Wait() { }

	// RVA: 0x3615F40 Offset: 0x3616041 VA: 0x3615F40
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3616850 Offset: 0x3616951 VA: 0x3616850
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x3616920 Offset: 0x3616A21 VA: 0x3616920
	public Task WaitAsync() { }

	// RVA: 0x3616540 Offset: 0x3616641 VA: 0x3616540
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3616930 Offset: 0x3616A31 VA: 0x3616930
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x3616BD0 Offset: 0x3616CD1 VA: 0x3616BD0
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute] // RVA: 0x47C4E0 Offset: 0x47C5E1 VA: 0x47C4E0
	// RVA: 0x36169F0 Offset: 0x3616AF1 VA: 0x36169F0
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3616CD0 Offset: 0x3616DD1 VA: 0x3616CD0
	public int Release() { }

	// RVA: 0x3616CE0 Offset: 0x3616DE1 VA: 0x3616CE0
	public int Release(int releaseCount) { }

	// RVA: 0x3617040 Offset: 0x3617141 VA: 0x3617040
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x3617050 Offset: 0x3617151 VA: 0x3617050 Slot: 4
	public void Dispose() { }

	// RVA: 0x36170D0 Offset: 0x36171D1 VA: 0x36170D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3617170 Offset: 0x3617271 VA: 0x3617170
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x3616490 Offset: 0x3616591 VA: 0x3616490
	private void CheckDispose() { }

	// RVA: 0x3615F20 Offset: 0x3616021 VA: 0x3615F20
	private static string GetResourceString(string str) { }

	// RVA: 0x36172B0 Offset: 0x36173B1 VA: 0x36172B0
	private static void .cctor() { }
}

