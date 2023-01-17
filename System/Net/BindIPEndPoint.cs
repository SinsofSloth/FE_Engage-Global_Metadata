// Namespace: System.Net
public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 2537
{
	// Methods

	// RVA: 0x1B40780 Offset: 0x1B40881 VA: 0x1B40780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B407A0 Offset: 0x1B408A1 VA: 0x1B407A0 Slot: 13
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

	// RVA: 0x1B40B40 Offset: 0x1B40C41 VA: 0x1B40B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, object object) { }

	// RVA: 0x1B40BF0 Offset: 0x1B40CF1 VA: 0x1B40BF0 Slot: 15
	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }
}

