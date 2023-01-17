// Namespace: 
public sealed class MaterialMenuItem.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11041
{
	// Methods

	// RVA: 0x21525D0 Offset: 0x21526D1 VA: 0x21525D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21525F0 Offset: 0x21526F1 VA: 0x21525F0 Slot: 13
	public virtual void Invoke(string materialId) { }

	// RVA: 0x2152950 Offset: 0x2152A51 VA: 0x2152950 Slot: 14
	public virtual IAsyncResult BeginInvoke(string materialId, AsyncCallback callback, object object) { }

	// RVA: 0x2152980 Offset: 0x2152A81 VA: 0x2152980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

