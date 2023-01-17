// Namespace: NexPlugin
public sealed class NotificationEventCB : MulticastDelegate // TypeDefIndex: 14863
{
	// Methods

	// RVA: 0x235E220 Offset: 0x235E321 VA: 0x235E220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x235E240 Offset: 0x235E341 VA: 0x235E240 Slot: 13
	public virtual void Invoke(NotificationEvent notificationEvent) { }

	// RVA: 0x235E5A0 Offset: 0x235E6A1 VA: 0x235E5A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(NotificationEvent notificationEvent, AsyncCallback callback, object object) { }

	// RVA: 0x235E5D0 Offset: 0x235E6D1 VA: 0x235E5D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

