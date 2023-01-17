// Namespace: System.Threading
internal interface IThreadPoolWorkItem // TypeDefIndex: 783
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteWorkItem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarkAborted(ThreadAbortException tae);
}

