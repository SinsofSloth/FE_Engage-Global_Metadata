// Namespace: 
private class MapItemMenu.TargetMenuItem : BasicItemMenuItem // TypeDefIndex: 12251
{
	// Fields
	protected int m_UnitItemIndex; // 0x64

	// Properties
	protected virtual MapMind.Type ActiveMind { get; }
	protected virtual MapPanelDeploy.Mode DeployMode { get; }

	// Methods

	// RVA: 0x240B220 Offset: 0x240B321 VA: 0x240B220 Slot: 34
	protected virtual MapMind.Type get_ActiveMind() { }

	// RVA: 0x240B230 Offset: 0x240B331 VA: 0x240B230 Slot: 35
	protected virtual MapPanelDeploy.Mode get_DeployMode() { }

	// RVA: 0x2404A40 Offset: 0x2404B41 VA: 0x2404A40
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x240B240 Offset: 0x240B341 VA: 0x240B240 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x240B2E0 Offset: 0x240B3E1 VA: 0x240B2E0 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x240B320 Offset: 0x240B421 VA: 0x240B320 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x240B3A0 Offset: 0x240B4A1 VA: 0x240B3A0 Slot: 12
	public override void OnSelect() { }
}

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
private class MapItemMenu.AttackMenuItem : MapItemMenu.TargetMenuItem // TypeDefIndex: 12253
{
	// Fields
	private MapMind.Type m_Mind; // 0x68
	private MapTarget.ActionMask m_ActionMask; // 0x6C
	private SkillData m_Skill; // 0x70
	private BasicItemMenuContent m_BasicItemMenuContent; // 0x78

	// Methods

	// RVA: 0x24049D0 Offset: 0x2404AD1 VA: 0x24049D0
	public void .ctor(int unitItemIndex, MapMind.Type mind, MapTarget.ActionMask actionMask, SkillData skill, BasicItemMenuContent basicItemMenuContent) { }

	// RVA: 0x2404A70 Offset: 0x2404B71 VA: 0x2404A70 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2404CC0 Offset: 0x2404DC1 VA: 0x2404CC0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2404EE0 Offset: 0x2404FE1 VA: 0x2404EE0 Slot: 20
	public override BasicMenu.Result XCall() { }
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
private class MapItemMenu.RodMenuItem : MapItemMenu.TargetMenuItem // TypeDefIndex: 12255
{
	// Fields
	private BasicItemMenuContent m_BasicItemMenuContent; // 0x68

	// Methods

	// RVA: 0x2408490 Offset: 0x2408591 VA: 0x2408490
	public void .ctor(int unitItemIndex, BasicItemMenuContent basicItemMenuContent) { }

	// RVA: 0x24084E0 Offset: 0x24085E1 VA: 0x24084E0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2408780 Offset: 0x2408881 VA: 0x2408780 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2408C40 Offset: 0x2408D41 VA: 0x2408C40 Slot: 20
	public override BasicMenu.Result XCall() { }

	// RVA: 0x2408CC0 Offset: 0x2408DC1 VA: 0x2408CC0 Slot: 19
	public override BasicMenu.Result BCall() { }
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
private class MapItemMenu.ItemMenuItem : BasicItemMenuItem // TypeDefIndex: 12257
{
	// Fields
	protected BasicItemMenuContent m_BasicItemMenuContent; // 0x68
	protected int m_UnitItemIndex; // 0x70

	// Methods

	// RVA: 0x2404FB0 Offset: 0x24050B1 VA: 0x2404FB0
	public void .ctor(int unitItemIndex, BasicItemMenuContent basicItemMenuContent) { }

	// RVA: 0x2406210 Offset: 0x2406311 VA: 0x2406210 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x24055C0 Offset: 0x24056C1 VA: 0x24055C0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2406310 Offset: 0x2406411 VA: 0x2406310 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2406670 Offset: 0x2406771 VA: 0x2406670 Slot: 20
	public override BasicMenu.Result XCall() { }

	// RVA: 0x24066F0 Offset: 0x24067F1 VA: 0x24066F0 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x2405760 Offset: 0x2405861 VA: 0x2405760
	public int GetUnitItemIndex() { }

	// RVA: 0x2406770 Offset: 0x2406871 VA: 0x2406770 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x24067C0 Offset: 0x24068C1 VA: 0x24067C0 Slot: 33
	public override bool IsEffective() { }
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
private class MapItemMenu.EnchantItemMenuItem : MapItemMenu.ItemMenuItem // TypeDefIndex: 12259
{
	// Fields
	private MapItemMenu.EnchantType m_EnchantType; // 0x74

	// Methods

	// RVA: 0x2404F60 Offset: 0x2405061 VA: 0x2404F60
	public void .ctor(int unitItemIndex, BasicItemMenuContent basicItemMenuContent, MapItemMenu.EnchantType enchantType) { }

	// RVA: 0x2405000 Offset: 0x2405101 VA: 0x2405000 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2405390 Offset: 0x2405491 VA: 0x2405390 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2405470 Offset: 0x2405571 VA: 0x2405470 Slot: 20
	public override BasicMenu.Result XCall() { }

	// RVA: 0x2405480 Offset: 0x2405581 VA: 0x2405480 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x24050F0 Offset: 0x24051F1 VA: 0x24050F0
	private bool CanEnchant(UnitItem unitItem) { }

	// RVA: 0x24051E0 Offset: 0x24052E1 VA: 0x24051E0
	private bool Enumerate() { }

	// RVA: 0x24058A0 Offset: 0x24059A1 VA: 0x24058A0 Slot: 33
	public override bool IsEffective() { }
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
private class MapItemMenu.SubItemMenuItem : BasicMenuItem // TypeDefIndex: 12261
{
	// Fields
	protected int m_UnitItemIndex; // 0x64

	// Methods

	// RVA: 0x2408D80 Offset: 0x2408E81 VA: 0x2408D80
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x24097B0 Offset: 0x24098B1 VA: 0x24097B0
	protected BasicMenu GetParentMenu() { }

	// RVA: 0x2409450 Offset: 0x2409551 VA: 0x2409450
	protected Unit GetUnit() { }

	// RVA: 0x24094D0 Offset: 0x24095D1 VA: 0x24094D0
	protected UnitItem GetUnitItem() { }
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
private class MapItemMenu.SubItemTakeOffMenuItem : MapItemMenu.SubItemMenuItem // TypeDefIndex: 12263
{
	// Methods

	// RVA: 0x2409910 Offset: 0x2409A11 VA: 0x2409910
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x240A100 Offset: 0x240A201 VA: 0x240A100 Slot: 4
	public override string GetName() { }

	// RVA: 0x240A180 Offset: 0x240A281 VA: 0x240A180 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x240A1B0 Offset: 0x240A2B1 VA: 0x240A1B0 Slot: 18
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
private class MapItemMenu.SubItemUseMenuItem : MapItemMenu.SubItemMenuItem // TypeDefIndex: 12265
{
	// Methods

	// RVA: 0x2409940 Offset: 0x2409A41 VA: 0x2409940
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x240A870 Offset: 0x240A971 VA: 0x240A870 Slot: 4
	public override string GetName() { }

	// RVA: 0x240A8F0 Offset: 0x240A9F1 VA: 0x240A8F0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x240B020 Offset: 0x240B121 VA: 0x240B020 Slot: 18
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
private class MapItemMenu.SubItemPutOffMenuItem.ConfirmDialog : YesNoDialog // TypeDefIndex: 12267
{
	// Methods

	// RVA: 0x21E4F40 Offset: 0x21E5041 VA: 0x21E4F40
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x21E4FC0 Offset: 0x21E50C1 VA: 0x21E4FC0
	public static void CreateBind(ProcInst super, Unit unit, int unitItemIndex) { }
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
private class MapItemMenu.SubItemPutOffMenuItem : MapItemMenu.SubItemMenuItem // TypeDefIndex: 12269
{
	// Methods

	// RVA: 0x24099D0 Offset: 0x2409AD1 VA: 0x24099D0
	public void .ctor(int unitItemIndex) { }

	// RVA: 0x2409A00 Offset: 0x2409B01 VA: 0x2409A00 Slot: 4
	public override string GetName() { }

	// RVA: 0x2409A80 Offset: 0x2409B81 VA: 0x2409A80 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2409C90 Offset: 0x2409D91 VA: 0x2409C90 Slot: 18
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

// Namespace: 
private class MapItemMenu.MapTradeMenuItem : TradeMenuItem // TypeDefIndex: 12271
{
	// Methods

	// RVA: 0x2407980 Offset: 0x2407A81 VA: 0x2407980 Slot: 34
	protected override Unit GetLeftUnit() { }

	// RVA: 0x2407A00 Offset: 0x2407B01 VA: 0x2407A00 Slot: 35
	protected override Unit GetRightUnit() { }

	// RVA: 0x2407A80 Offset: 0x2407B81 VA: 0x2407A80 Slot: 38
	protected override void SetDone() { }

	// RVA: 0x2407B00 Offset: 0x2407C01 VA: 0x2407B00 Slot: 39
	protected override bool IsDone() { }

	// RVA: 0x2407B80 Offset: 0x2407C81 VA: 0x2407B80 Slot: 41
	protected override void OnEnd() { }

	// RVA: 0x2407970 Offset: 0x2407A71 VA: 0x2407970
	public void .ctor() { }
}

