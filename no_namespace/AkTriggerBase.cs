// Namespace: 
public sealed class AkTriggerBase.Trigger : MulticastDelegate // TypeDefIndex: 8053
{
	// Methods

	// RVA: 0x1F5B7C0 Offset: 0x1F5B8C1 VA: 0x1F5B7C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F5B7E0 Offset: 0x1F5B8E1 VA: 0x1F5B7E0 Slot: 13
	public virtual void Invoke(GameObject in_gameObject) { }

	// RVA: 0x1F5BB40 Offset: 0x1F5BC41 VA: 0x1F5BB40 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject in_gameObject, AsyncCallback callback, object object) { }

	// RVA: 0x1F5BB70 Offset: 0x1F5BC71 VA: 0x1F5BB70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

