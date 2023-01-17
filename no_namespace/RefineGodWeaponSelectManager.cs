// Namespace: 
public sealed class RefineGodWeaponSelectManager.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 11065
{
	// Methods

	// RVA: 0x1F30350 Offset: 0x1F30451 VA: 0x1F30350
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F30370 Offset: 0x1F30471 VA: 0x1F30370 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, GodUnit godUnit, UnitItem godWeapon, int scrollIndex) { }

	// RVA: 0x1F30620 Offset: 0x1F30721 VA: 0x1F30620 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, GodUnit godUnit, UnitItem godWeapon, int scrollIndex, AsyncCallback callback, object object) { }

	// RVA: 0x1F306F0 Offset: 0x1F307F1 VA: 0x1F306F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

