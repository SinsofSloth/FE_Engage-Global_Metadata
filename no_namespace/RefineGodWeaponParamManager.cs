// Namespace: 
public sealed class RefineGodWeaponParamManager.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 11045
{
	// Methods

	// RVA: 0x1F2F0B0 Offset: 0x1F2F1B1 VA: 0x1F2F0B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2F0D0 Offset: 0x1F2F1D1 VA: 0x1F2F0D0 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, ItemData godWeapon) { }

	// RVA: 0x1F2F340 Offset: 0x1F2F441 VA: 0x1F2F340 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, ItemData godWeapon, AsyncCallback callback, object object) { }

	// RVA: 0x1F2F3E0 Offset: 0x1F2F4E1 VA: 0x1F2F3E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

