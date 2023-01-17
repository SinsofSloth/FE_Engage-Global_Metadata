// Namespace: 
public sealed class Subscriber.GetContentCB : MulticastDelegate // TypeDefIndex: 14952
{
	// Methods

	// RVA: 0x2052750 Offset: 0x2052851 VA: 0x2052750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2052770 Offset: 0x2052871 VA: 0x2052770 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<SubscriberContent> contents) { }

	// RVA: 0x2052AE0 Offset: 0x2052BE1 VA: 0x2052AE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<SubscriberContent> contents, AsyncCallback callback, object object) { }

	// RVA: 0x2052B10 Offset: 0x2052C11 VA: 0x2052B10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Subscriber.GetSubscriberUserStatusInfoCB : MulticastDelegate // TypeDefIndex: 14954
{
	// Methods

	// RVA: 0x2052EF0 Offset: 0x2052FF1 VA: 0x2052EF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2052F10 Offset: 0x2053011 VA: 0x2052F10 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<SubscriberUserStatusInfo> infos) { }

	// RVA: 0x2053280 Offset: 0x2053381 VA: 0x2053280 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<SubscriberUserStatusInfo> infos, AsyncCallback callback, object object) { }

	// RVA: 0x20532B0 Offset: 0x20533B1 VA: 0x20532B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

