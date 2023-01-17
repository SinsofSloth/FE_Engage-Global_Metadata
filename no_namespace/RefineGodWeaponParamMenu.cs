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

