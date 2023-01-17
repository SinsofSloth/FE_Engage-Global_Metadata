// Namespace: System.Net
public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 2469
{
	// Methods

	// RVA: 0x1AEB680 Offset: 0x1AEB781 VA: 0x1AEB680
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AEB6A0 Offset: 0x1AEB7A1 VA: 0x1AEB6A0 Slot: 13
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

	// RVA: 0x1AEB8E0 Offset: 0x1AEB9E1 VA: 0x1AEB8E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object object) { }

	// RVA: 0x1AEB980 Offset: 0x1AEBA81 VA: 0x1AEB980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

