// Namespace: System.IO
internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 667
{
	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x38B2580 Offset: 0x38B2681 VA: 0x38B2580
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x38B3440 Offset: 0x38B3541 VA: 0x38B3440
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x38B34D0 Offset: 0x38B35D1 VA: 0x38B34D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x38B34E0 Offset: 0x38B35E1 VA: 0x38B34E0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x38B34F0 Offset: 0x38B35F1 VA: 0x38B34F0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x38B3500 Offset: 0x38B3601 VA: 0x38B3500 Slot: 4
	public bool get_IsCompleted() { }
}

