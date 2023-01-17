// Namespace: App.CookingMenu
public class FoodstuffMenu : BasicMenu // TypeDefIndex: 14252
{
	// Fields
	private FoodstuffMenuContent m_Content; // 0xC8
	private FoodstuffMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private FoodstuffMenu.CancelEventHandler m_CancelEventHandler; // 0xD8

	// Methods

	// RVA: 0x29FCC70 Offset: 0x29FCD71 VA: 0x29FCC70
	protected void .ctor(List<BasicMenuItem> menuItemList, FoodstuffMenuContent menuContent, FoodstuffMenu.DecideEventHandler decideEventHandler, FoodstuffMenu.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x29FCCE0 Offset: 0x29FCDE1 VA: 0x29FCCE0
	public static void CreateBind(ProcInst super, DishAllMenuContent allContent, FoodData food, List<FoodstuffData> selectedFoodstuffs, FoodstuffMenu.DecideEventHandler decideEventHandler, FoodstuffMenu.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x29FD470 Offset: 0x29FD571 VA: 0x29FD470 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x29FD890 Offset: 0x29FD991 VA: 0x29FD890 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x29FD8D0 Offset: 0x29FD9D1 VA: 0x29FD8D0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x29FDAD0 Offset: 0x29FDBD1 VA: 0x29FDAD0 Slot: 27
	public override void OnCursorMoveEnd() { }

	// RVA: 0x29FD610 Offset: 0x29FD711 VA: 0x29FD610
	private FoodstuffMenu.FoodstuffMenuItem GetFoodstuffMenuItemCurrent() { }

	// RVA: 0x29FDBA0 Offset: 0x29FDCA1 VA: 0x29FDBA0
	private FoodstuffMenu.FoodstuffMenuItem GetFoodstuffMenuItem(int index) { }

	// RVA: 0x29FD6C0 Offset: 0x29FD7C1 VA: 0x29FD6C0
	private List<FoodstuffData> GetSelectedFoodstuffs() { }

	// RVA: 0x29FDC50 Offset: 0x29FDD51 VA: 0x29FDC50 Slot: 10
	protected override void OnDispose() { }
}

