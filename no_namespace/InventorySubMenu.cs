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

