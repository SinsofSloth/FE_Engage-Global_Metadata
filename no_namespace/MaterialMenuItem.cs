// Namespace: 
public sealed class MaterialMenuItem.SelectEventHandler : MulticastDelegate // TypeDefIndex: 11040
{
	// Methods

	// RVA: 0x2152990 Offset: 0x2152A91 VA: 0x2152990
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21529B0 Offset: 0x2152AB1 VA: 0x21529B0 Slot: 13
	public virtual void Invoke(string materialId) { }

	// RVA: 0x2152D10 Offset: 0x2152E11 VA: 0x2152D10 Slot: 14
	public virtual IAsyncResult BeginInvoke(string materialId, AsyncCallback callback, object object) { }

	// RVA: 0x2152D40 Offset: 0x2152E41 VA: 0x2152D40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

