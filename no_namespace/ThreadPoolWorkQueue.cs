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

