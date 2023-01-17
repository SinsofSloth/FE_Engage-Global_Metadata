// Namespace: 
internal class ThreadPoolWorkQueue.SparseArray<T> // TypeDefIndex: 787
{
	// Fields
	private T[] m_array; // 0x0

	// Properties
	internal T[] Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BA5A0 Offset: 0x36BA6A1 VA: 0x36BA5A0
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BA610 Offset: 0x36BA711 VA: 0x36BA610
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BA640 Offset: 0x36BA741 VA: 0x36BA640
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BA8C0 Offset: 0x36BA9C1 VA: 0x36BA8C0
	|-ThreadPoolWorkQueue.SparseArray<object>.Remove
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Remove
	*/
}

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

// Namespace: 
internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 789
{
	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x1C07FB0 Offset: 0x1C080B1 VA: 0x1C07FB0
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x1C07FF0 Offset: 0x1C080F1 VA: 0x1C07FF0
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0x47C9B0 Offset: 0x47CAB1 VA: 0x47C9B0
	// RVA: 0x1C08070 Offset: 0x1C08171 VA: 0x1C08070
	public void .ctor() { }

	// RVA: 0x1C080E0 Offset: 0x1C081E1 VA: 0x1C080E0
	public bool IsUsedUp() { }

	// RVA: 0x1C08120 Offset: 0x1C08221 VA: 0x1C08120
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x1C081F0 Offset: 0x1C082F1 VA: 0x1C081F0
	public bool TryDequeue(out IThreadPoolWorkItem node) { }
}

