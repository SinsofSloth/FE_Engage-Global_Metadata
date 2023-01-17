// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 790
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x1B15A70 Offset: 0x1B15B71 VA: 0x1B15A70
	public void .ctor() { }

	// RVA: 0x1B15F20 Offset: 0x1B16021 VA: 0x1B15F20
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x1B16140 Offset: 0x1B16241 VA: 0x1B16140
	internal void EnsureThreadRequested() { }

	// RVA: 0x1B16200 Offset: 0x1B16301 VA: 0x1B16200
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x1B15550 Offset: 0x1B15651 VA: 0x1B15550
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x1B15820 Offset: 0x1B15921 VA: 0x1B15820
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x1B16250 Offset: 0x1B16351 VA: 0x1B16250
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x1B16430 Offset: 0x1B16531 VA: 0x1B16430
	internal static bool Dispatch() { }

	// RVA: 0x1B16A00 Offset: 0x1B16B01 VA: 0x1B16A00
	private static void .cctor() { }
}

