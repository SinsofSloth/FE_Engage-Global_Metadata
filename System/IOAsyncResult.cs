// Namespace: System
internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 2240
{
	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; set; }
	public bool IsCompleted { get; set; }

	// Methods

	// RVA: 0x1AF2A60 Offset: 0x1AF2B61 VA: 0x1AF2A60
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x1AF2AB0 Offset: 0x1AF2BB1 VA: 0x1AF2AB0
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x1AF2AC0 Offset: 0x1AF2BC1 VA: 0x1AF2AC0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1AF2AD0 Offset: 0x1AF2BD1 VA: 0x1AF2AD0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1AF2C10 Offset: 0x1AF2D11 VA: 0x1AF2C10 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1AF2C20 Offset: 0x1AF2D21 VA: 0x1AF2C20
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x1AF2C30 Offset: 0x1AF2D31 VA: 0x1AF2C30 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1AF2C40 Offset: 0x1AF2D41 VA: 0x1AF2C40
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed();
}

