// Namespace: 
private class MascotFoodSelectMenuItem.ConfirmDialogYes : BasicDialogItemYes // TypeDefIndex: 10854
{
	// Fields
	private FoodstuffData m_foodStuffData; // 0x70

	// Methods

	// RVA: 0x2151470 Offset: 0x2151571 VA: 0x2151470
	public void .ctor(FoodstuffData foodstuffData) { }

	// RVA: 0x21515B0 Offset: 0x21516B1 VA: 0x21515B0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MascotFoodSelectMenuItem.ConfirmDialog : BasicDialog // TypeDefIndex: 10856
{
	// Methods

	// RVA: 0x21511D0 Offset: 0x21512D1 VA: 0x21511D0
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent) { }

	// RVA: 0x21511E0 Offset: 0x21512E1 VA: 0x21511E0
	public static MascotFoodSelectMenuItem.ConfirmDialog CreateBind(ProcInst super, FoodstuffData foodstuffData) { }
}

