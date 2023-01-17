// Namespace: 
public sealed class Subscriber.GetContentsCB : MulticastDelegate // TypeDefIndex: 14953
{
	// Methods

	// RVA: 0x2052B20 Offset: 0x2052C21 VA: 0x2052B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2052B40 Offset: 0x2052C41 VA: 0x2052B40 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<List<SubscriberContent>> contents) { }

	// RVA: 0x2052EB0 Offset: 0x2052FB1 VA: 0x2052EB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<List<SubscriberContent>> contents, AsyncCallback callback, object object) { }

	// RVA: 0x2052EE0 Offset: 0x2052FE1 VA: 0x2052EE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

