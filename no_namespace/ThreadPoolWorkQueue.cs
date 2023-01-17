// Namespace: 
internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 788
{
	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x1C08320 Offset: 0x1C08421 VA: 0x1C08320
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x1C087B0 Offset: 0x1C088B1 VA: 0x1C087B0
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x1C08AA0 Offset: 0x1C08BA1 VA: 0x1C08AA0
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x1C08D90 Offset: 0x1C08E91 VA: 0x1C08D90
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x1C08DA0 Offset: 0x1C08EA1 VA: 0x1C08DA0
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x1C09080 Offset: 0x1C09181 VA: 0x1C09080
	public void .ctor() { }
}

