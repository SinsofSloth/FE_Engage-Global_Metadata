// Namespace: 
public sealed class RefineGodWeaponResetYesNoDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 11050
{
	// Methods

	// RVA: 0x1F2FFE0 Offset: 0x1F300E1 VA: 0x1F2FFE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F30000 Offset: 0x1F30101 VA: 0x1F30000 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F30210 Offset: 0x1F30311 VA: 0x1F30210 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F30240 Offset: 0x1F30341 VA: 0x1F30240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineGodWeaponResetYesNoDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11051
{
	// Fields
	private RefineGodWeaponResetYesNoDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x1F30250 Offset: 0x1F30351 VA: 0x1F30250
	public void .ctor(RefineGodWeaponResetYesNoDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1F30300 Offset: 0x1F30401 VA: 0x1F30300 Slot: 18
	public override BasicMenu.Result ACall() { }
}

