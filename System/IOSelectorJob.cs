// Namespace: System
internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2241
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x1AF2D30 Offset: 0x1AF2E31 VA: 0x1AF2D30
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x1AF2D90 Offset: 0x1AF2E91 VA: 0x1AF2D90 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1AF2DA0 Offset: 0x1AF2EA1 VA: 0x1AF2DA0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1AF2DB0 Offset: 0x1AF2EB1 VA: 0x1AF2DB0
	public void MarkDisposed() { }
}

