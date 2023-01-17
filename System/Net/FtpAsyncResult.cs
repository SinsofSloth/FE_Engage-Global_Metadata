// Namespace: System.Net
internal class FtpAsyncResult : IAsyncResult // TypeDefIndex: 2544
{
	// Fields
	private FtpWebResponse response; // 0x10
	private ManualResetEvent waitHandle; // 0x18
	private Exception exception; // 0x20
	private AsyncCallback callback; // 0x28
	private Stream stream; // 0x30
	private object state; // 0x38
	private bool completed; // 0x40
	private bool synch; // 0x41
	private object locker; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }
	internal FtpWebResponse Response { get; }
	internal Stream Stream { get; set; }

	// Methods

	// RVA: 0x1ADF5F0 Offset: 0x1ADF6F1 VA: 0x1ADF5F0
	public void .ctor(AsyncCallback callback, object state) { }

	// RVA: 0x1ADF6A0 Offset: 0x1ADF7A1 VA: 0x1ADF6A0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1ADF6B0 Offset: 0x1ADF7B1 VA: 0x1ADF6B0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1ADF7E0 Offset: 0x1ADF8E1 VA: 0x1ADF7E0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1ADF7F0 Offset: 0x1ADF8F1 VA: 0x1ADF7F0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1ADF8D0 Offset: 0x1ADF9D1 VA: 0x1ADF8D0
	internal bool get_GotException() { }

	// RVA: 0x1ADF8E0 Offset: 0x1ADF9E1 VA: 0x1ADF8E0
	internal Exception get_Exception() { }

	// RVA: 0x1ADF8F0 Offset: 0x1ADF9F1 VA: 0x1ADF8F0
	internal FtpWebResponse get_Response() { }

	// RVA: 0x1ADF900 Offset: 0x1ADFA01 VA: 0x1ADF900
	internal Stream get_Stream() { }

	// RVA: 0x1ADF910 Offset: 0x1ADFA11 VA: 0x1ADF910
	internal void set_Stream(Stream value) { }

	// RVA: 0x1ADF920 Offset: 0x1ADFA21 VA: 0x1ADF920
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x1ADF980 Offset: 0x1ADFA81 VA: 0x1ADF980
	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0x1ADFB40 Offset: 0x1ADFC41 VA: 0x1ADFB40
	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	// RVA: 0x1ADFB50 Offset: 0x1ADFC51 VA: 0x1ADFB50
	internal void SetCompleted(bool synch, Exception exc) { }

	// RVA: 0x1ADFAA0 Offset: 0x1ADFBA1 VA: 0x1ADFAA0
	internal void DoCallback() { }
}

