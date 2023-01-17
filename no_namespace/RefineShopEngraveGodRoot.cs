// Namespace: 
public sealed class RefineShopEngraveGodRoot.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 11110
{
	// Methods

	// RVA: 0x1F33330 Offset: 0x1F33431 VA: 0x1F33330
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F33350 Offset: 0x1F33451 VA: 0x1F33350 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, GodData godData, UnitItem afterUnitItem) { }

	// RVA: 0x1F335E0 Offset: 0x1F336E1 VA: 0x1F335E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, GodData godData, UnitItem afterUnitItem, AsyncCallback callback, object object) { }

	// RVA: 0x1F33690 Offset: 0x1F33791 VA: 0x1F33690 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineShopEngraveGodRoot.ConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11112
{
	// Fields
	private RefineShopEngraveGodRoot.ConfirmDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x21F42B0 Offset: 0x21F43B1 VA: 0x21F42B0
	public void .ctor(RefineShopEngraveGodRoot.ConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x21F4360 Offset: 0x21F4461 VA: 0x21F4360 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public sealed class RefineShopEngraveGodRoot.ConfirmToReplaceDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 11114
{
	// Methods

	// RVA: 0x21F4380 Offset: 0x21F4481 VA: 0x21F4380
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F43A0 Offset: 0x21F44A1 VA: 0x21F43A0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21F45B0 Offset: 0x21F46B1 VA: 0x21F45B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21F45E0 Offset: 0x21F46E1 VA: 0x21F45E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineShopEngraveGodRoot.ConfirmToReplaceDialog // TypeDefIndex: 11116
{
	// Methods

	// RVA: 0x1F32F70 Offset: 0x1F33071 VA: 0x1F32F70
	public static YesNoDialog CreateBind(ProcInst super, UnitItem engravedUnitItem, GodData godData, RefineShopEngraveGodRoot.ConfirmToReplaceDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1F33320 Offset: 0x1F33421 VA: 0x1F33320
	public void .ctor() { }
}

