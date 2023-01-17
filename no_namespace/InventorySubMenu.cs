// Namespace: 
private abstract class InventorySubMenu.BaseMenuItem : BasicMenuItem // TypeDefIndex: 13206
{
	// Methods

	// RVA: 0x22225D0 Offset: 0x22226D1 VA: 0x22225D0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2222680 Offset: 0x2222781 VA: 0x2222680 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2222730 Offset: 0x2222831 VA: 0x2222730
	protected void .ctor() { }
}

// Namespace: 
private class InventorySubMenu.StoreMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13207
{
	// Methods

	// RVA: 0x2223730 Offset: 0x2223831 VA: 0x2223730 Slot: 4
	public override string GetName() { }

	// RVA: 0x22237B0 Offset: 0x22238B1 VA: 0x22237B0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2223860 Offset: 0x2223961 VA: 0x2223860 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2223B20 Offset: 0x2223C21 VA: 0x2223B20
	public void .ctor() { }
}

// Namespace: 
private class InventorySubMenu.ReceiveMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13208
{
	// Methods

	// RVA: 0x2222F10 Offset: 0x2223011 VA: 0x2222F10 Slot: 4
	public override string GetName() { }

	// RVA: 0x2222F90 Offset: 0x2223091 VA: 0x2222F90 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2223110 Offset: 0x2223211 VA: 0x2223110 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2223440 Offset: 0x2223541 VA: 0x2223440
	public void .ctor() { }
}

// Namespace: 
private class InventorySubMenu.TradeMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13209
{
	// Methods

	// RVA: 0x2224400 Offset: 0x2224501 VA: 0x2224400 Slot: 4
	public override string GetName() { }

	// RVA: 0x2224480 Offset: 0x2224581 VA: 0x2224480 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2224560 Offset: 0x2224661 VA: 0x2224560 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x22248E0 Offset: 0x22249E1 VA: 0x22248E0
	public void .ctor() { }
}

// Namespace: 
private class InventorySubMenu.EquipMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13210
{
	// Methods

	// RVA: 0x2222740 Offset: 0x2222841 VA: 0x2222740 Slot: 4
	public override string GetName() { }

	// RVA: 0x22227C0 Offset: 0x22228C1 VA: 0x22227C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2222DD0 Offset: 0x2222ED1 VA: 0x2222DD0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2222F00 Offset: 0x2223001 VA: 0x2222F00
	public void .ctor() { }
}

// Namespace: 
private class InventorySubMenu.TakeOffMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13211
{
	// Methods

	// RVA: 0x2223B30 Offset: 0x2223C31 VA: 0x2223B30 Slot: 4
	public override string GetName() { }

	// RVA: 0x2223BB0 Offset: 0x2223CB1 VA: 0x2223BB0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2223C70 Offset: 0x2223D71 VA: 0x2223C70 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2223D90 Offset: 0x2223E91 VA: 0x2223D90
	public void .ctor() { }
}

// Namespace: 
private class InventorySubMenu.SortMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13212
{
	// Methods

	// RVA: 0x2223450 Offset: 0x2223551 VA: 0x2223450 Slot: 4
	public override string GetName() { }

	// RVA: 0x22234D0 Offset: 0x22235D1 VA: 0x22234D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2223610 Offset: 0x2223711 VA: 0x2223610 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2223720 Offset: 0x2223821 VA: 0x2223720
	public void .ctor() { }
}

// Namespace: 
public sealed class InventorySubMenu.UseMenuItem.ConfirmDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 13213
{
	// Methods

	// RVA: 0x2D74E90 Offset: 0x2D74F91 VA: 0x2D74E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D74EB0 Offset: 0x2D74FB1 VA: 0x2D74EB0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2D750C0 Offset: 0x2D751C1 VA: 0x2D750C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D750F0 Offset: 0x2D751F1 VA: 0x2D750F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class InventorySubMenu.UseMenuItem.ConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 13214
{
	// Fields
	private InventorySubMenu.UseMenuItem.ConfirmDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x2D75100 Offset: 0x2D75201 VA: 0x2D75100
	public void .ctor(InventorySubMenu.UseMenuItem.ConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x2D751B0 Offset: 0x2D752B1 VA: 0x2D751B0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class InventorySubMenu.UseMenuItem.ConfirmDialog : YesNoDialog // TypeDefIndex: 13215
{
	// Methods

	// RVA: 0x1DD1370 Offset: 0x1DD1471 VA: 0x1DD1370
	public static InventorySubMenu.UseMenuItem.ConfirmDialog CreateBind(ProcInst super, ItemData itemData, InventorySubMenu.UseMenuItem.ConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1DD15B0 Offset: 0x1DD16B1 VA: 0x1DD15B0
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent) { }
}

// Namespace: 
private class InventorySubMenu.UseMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13216
{
	// Methods

	// RVA: 0x22248F0 Offset: 0x22249F1 VA: 0x22248F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2224970 Offset: 0x2224A71 VA: 0x2224970 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2225100 Offset: 0x2225201 VA: 0x2225100 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2225220 Offset: 0x2225321 VA: 0x2225220
	public void OnConfirmYes() { }

	// RVA: 0x2225480 Offset: 0x2225581 VA: 0x2225480
	private void UseItem() { }

	// RVA: 0x22257C0 Offset: 0x22258C1 VA: 0x22257C0
	public void .ctor() { }
}

// Namespace: 
public sealed class InventorySubMenu.ThrowAwayMenuItem.ConfirmDialog.DecideCallback : MulticastDelegate // TypeDefIndex: 13217
{
	// Methods

	// RVA: 0x2D74E30 Offset: 0x2D74F31 VA: 0x2D74E30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D74C20 Offset: 0x2D74D21 VA: 0x2D74C20 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2D74E50 Offset: 0x2D74F51 VA: 0x2D74E50 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D74E80 Offset: 0x2D74F81 VA: 0x2D74E80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class InventorySubMenu.ThrowAwayMenuItem.ConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 13218
{
	// Fields
	private Unit m_Unit; // 0x70
	private int m_UnitItemIndex; // 0x78
	private InventorySubMenu.ThrowAwayMenuItem.ConfirmDialog.DecideCallback m_DecideCallback; // 0x80

	// Methods

	// RVA: 0x2D74BA0 Offset: 0x2D74CA1 VA: 0x2D74BA0
	public void .ctor(string text, Unit unit, int unitItemIndex, InventorySubMenu.ThrowAwayMenuItem.ConfirmDialog.DecideCallback decideCallback) { }

	// RVA: 0x2D74C00 Offset: 0x2D74D01 VA: 0x2D74C00 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class InventorySubMenu.ThrowAwayMenuItem.ConfirmDialog : YesNoDialog // TypeDefIndex: 13219
{
	// Methods

	// RVA: 0x1DD0CF0 Offset: 0x1DD0DF1 VA: 0x1DD0CF0
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x1DD0D70 Offset: 0x1DD0E71 VA: 0x1DD0D70
	public static void CreateBind(ProcInst super, Unit unit, int unitItemIndex, InventorySubMenu.ThrowAwayMenuItem.ConfirmDialog.DecideCallback decideCallback) { }
}

// Namespace: 
private class InventorySubMenu.ThrowAwayMenuItem : InventorySubMenu.BaseMenuItem // TypeDefIndex: 13220
{
	// Methods

	// RVA: 0x2223DA0 Offset: 0x2223EA1 VA: 0x2223DA0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2223E20 Offset: 0x2223F21 VA: 0x2223E20 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2224020 Offset: 0x2224121 VA: 0x2224020 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2224130 Offset: 0x2224231 VA: 0x2224130
	public void ThrowAway() { }

	// RVA: 0x22243F0 Offset: 0x22244F1 VA: 0x22243F0
	public void .ctor() { }
}

