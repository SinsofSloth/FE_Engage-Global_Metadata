// Namespace: 
public sealed class RefineGodWeaponParamMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 11053
{
	// Methods

	// RVA: 0x1F2FB20 Offset: 0x1F2FC21 VA: 0x1F2FB20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2FB40 Offset: 0x1F2FC41 VA: 0x1F2FB40 Slot: 13
	public virtual void Invoke(GodUnit godUnit, ItemData ItemData, GodWeaponRefineData.Kind refineKind, bool refineOrReset) { }

	// RVA: 0x1F2FF00 Offset: 0x1F30001 VA: 0x1F2FF00 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit godUnit, ItemData ItemData, GodWeaponRefineData.Kind refineKind, bool refineOrReset, AsyncCallback callback, object object) { }

	// RVA: 0x1F2FFD0 Offset: 0x1F300D1 VA: 0x1F2FFD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefineGodWeaponParamMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11054
{
	// Methods

	// RVA: 0x1F2F3F0 Offset: 0x1F2F4F1 VA: 0x1F2F3F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2F410 Offset: 0x1F2F511 VA: 0x1F2F410 Slot: 13
	public virtual void Invoke(GodWeaponRefineData refineData, GodWeaponRefineData.Kind refineKind, int currentLevel, string sid) { }

	// RVA: 0x1F2F7D0 Offset: 0x1F2F8D1 VA: 0x1F2F7D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodWeaponRefineData refineData, GodWeaponRefineData.Kind refineKind, int currentLevel, string sid, AsyncCallback callback, object object) { }

	// RVA: 0x1F2F8A0 Offset: 0x1F2F9A1 VA: 0x1F2F8A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefineGodWeaponParamMenu.RequestCloseEventHandler : MulticastDelegate // TypeDefIndex: 11055
{
	// Methods

	// RVA: 0x1F2F8B0 Offset: 0x1F2F9B1 VA: 0x1F2F8B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F2F8D0 Offset: 0x1F2F9D1 VA: 0x1F2F8D0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F2FAE0 Offset: 0x1F2FBE1 VA: 0x1F2FAE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F2FB10 Offset: 0x1F2FC11 VA: 0x1F2FB10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

