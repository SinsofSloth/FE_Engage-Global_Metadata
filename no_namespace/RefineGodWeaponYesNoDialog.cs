// Namespace: 
public sealed class RefineGodWeaponYesNoDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 11047
{
	// Methods

	// RVA: 0x1F315F0 Offset: 0x1F316F1 VA: 0x1F315F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F31610 Offset: 0x1F31711 VA: 0x1F31610 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F31820 Offset: 0x1F31921 VA: 0x1F31820 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F31850 Offset: 0x1F31951 VA: 0x1F31850 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineGodWeaponYesNoDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11048
{
	// Fields
	private RefineGodWeaponYesNoDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x1F31860 Offset: 0x1F31961 VA: 0x1F31860
	public void .ctor(string message, RefineGodWeaponYesNoDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1F318A0 Offset: 0x1F319A1 VA: 0x1F318A0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

