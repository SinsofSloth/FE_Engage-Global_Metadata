// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 791
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x4790F0 Offset: 0x4791F1 VA: 0x4790F0
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x1B15FB0 Offset: 0x1B160B1 VA: 0x1B15FB0
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x1B16AA0 Offset: 0x1B16BA1 VA: 0x1B16AA0
	private void CleanUp() { }

	// RVA: 0x1B16BD0 Offset: 0x1B16CD1 VA: 0x1B16BD0 Slot: 1
	protected override void Finalize() { }
}

