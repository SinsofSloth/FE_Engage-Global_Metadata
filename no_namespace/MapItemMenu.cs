// Namespace: 
private class MapItemMenu.AttackMenu : BasicMenu // TypeDefIndex: 12252
{
	// Methods

	// RVA: 0x24043C0 Offset: 0x24044C1 VA: 0x24043C0
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicItemMenuContent basicItemMenuContent) { }

	// RVA: 0x2404450 Offset: 0x2404551 VA: 0x2404450 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x24044F0 Offset: 0x24045F1 VA: 0x24044F0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2404540 Offset: 0x2404641 VA: 0x2404540
	public static void CreateBind(ProcInst super, MapMind.Type mind, MapTarget.ActionMask mask, SkillData skill) { }
}

// Namespace: 
private class MapItemMenu.RodMenu : BasicMenu // TypeDefIndex: 12254
{
	// Methods

	// RVA: 0x2407E50 Offset: 0x2407F51 VA: 0x2407E50
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicItemMenuContent basicItemMenuContent) { }

	// RVA: 0x2407EE0 Offset: 0x2407FE1 VA: 0x2407EE0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2407F60 Offset: 0x2408061 VA: 0x2407F60 Slot: 30
	public override string GetName() { }

	// RVA: 0x2407FB0 Offset: 0x24080B1 VA: 0x2407FB0
	public static void CreateBind(ProcInst super) { }
}

// Namespace: 
private class MapItemMenu.ItemMenu : BasicMenu // TypeDefIndex: 12256
{
	// Methods

	// RVA: 0x24058B0 Offset: 0x24059B1 VA: 0x24058B0
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicItemMenuContent basicItemMenuContent) { }

	// RVA: 0x2405940 Offset: 0x2405A41 VA: 0x2405940 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x2405A30 Offset: 0x2405B31 VA: 0x2405A30 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2405B70 Offset: 0x2405C71 VA: 0x2405B70 Slot: 30
	public override string GetName() { }

	// RVA: 0x2405BC0 Offset: 0x2405CC1 VA: 0x2405BC0
	public static void CreateBind(ProcInst super, MapItemMenu.EnchantType enchantType) { }

	// RVA: 0x2406090 Offset: 0x2406191 VA: 0x2406090
	public int GetMenuItemIndexEquipped() { }
}

// Namespace: 
public enum MapItemMenu.EnchantType // TypeDefIndex: 12258
{
	// Fields
	public int value__; // 0x0
	public const MapItemMenu.EnchantType None = 0;
	public const MapItemMenu.EnchantType Item = 1;
	public const MapItemMenu.EnchantType Weapon = 2;
}

// Namespace: 
private class MapItemMenu.SubItemMenu : BasicMenu // TypeDefIndex: 12260
{
	// Methods

	// RVA: 0x2409830 Offset: 0x2409931 VA: 0x2409830
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x24098C0 Offset: 0x24099C1 VA: 0x24098C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2406350 Offset: 0x2406451 VA: 0x2406350
	public static void CreateBind(BasicMenu super, int unitItemIndex, BasicMenuItem parentMenuItem) { }
}

// Namespace: 
private class MapItemMenu.SubItemEquipMenuItem : MapItemMenu.SubItemMenuItem // TypeDefIndex: 12262
{
	// Methods

	// RVA: 0x2408D50 Offset: 0x2408E51 VA: 0x2408D50
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x2408DB0 Offset: 0x2408EB1 VA: 0x2408DB0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2408E30 Offset: 0x2408F31 VA: 0x2408E30 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2409570 Offset: 0x2409671 VA: 0x2409570 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapItemMenu.SubItemSortMenuItem : MapItemMenu.SubItemMenuItem // TypeDefIndex: 12264
{
	// Methods

	// RVA: 0x24099A0 Offset: 0x2409AA1 VA: 0x24099A0
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x2409D60 Offset: 0x2409E61 VA: 0x2409D60 Slot: 4
	public override string GetName() { }

	// RVA: 0x2409DE0 Offset: 0x2409EE1 VA: 0x2409DE0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2409EF0 Offset: 0x2409FF1 VA: 0x2409EF0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapItemMenu.SubItemTradeMenuItem : MapItemMenu.SubItemMenuItem // TypeDefIndex: 12266
{
	// Methods

	// RVA: 0x2409970 Offset: 0x2409A71 VA: 0x2409970
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x240A3D0 Offset: 0x240A4D1 VA: 0x240A3D0 Slot: 4
	public override string GetName() { }

	// RVA: 0x240A450 Offset: 0x240A551 VA: 0x240A450 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x240A630 Offset: 0x240A731 VA: 0x240A630 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapItemMenu.SubItemPutOffMenuItem.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 12268
{
	// Fields
	private Unit m_Unit; // 0x70
	private int m_UnitItemIndex; // 0x78

	// Methods

	// RVA: 0x21E55E0 Offset: 0x21E56E1 VA: 0x21E55E0
	public void .ctor(string text, Unit unit, int unitItemIndex) { }

	// RVA: 0x21E5630 Offset: 0x21E5731 VA: 0x21E5630 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapItemMenu.MapTradeMenu : TradeMenu // TypeDefIndex: 12270
{
	// Methods

	// RVA: 0x24073C0 Offset: 0x24074C1 VA: 0x24073C0
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x2407440 Offset: 0x2407541 VA: 0x2407440 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2407530 Offset: 0x2407631 VA: 0x2407530
	public static void CreateBind(ProcInst super) { }
}

