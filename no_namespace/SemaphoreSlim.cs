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

