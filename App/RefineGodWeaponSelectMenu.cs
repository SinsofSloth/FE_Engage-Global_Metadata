// Namespace: App
public class RefineGodWeaponSelectMenu : BasicMenu // TypeDefIndex: 11070
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2965A0 Offset: 0x2966A1 VA: 0x2965A0
	private List<GodUnit> <m_GodUnitList>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x2965B0 Offset: 0x2966B1 VA: 0x2965B0
	private int <m_GodUnitIndex>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x2965C0 Offset: 0x2966C1 VA: 0x2965C0
	private GodUnit <m_GodUnit>k__BackingField; // 0xD8
	private BasicMenuSelect[] m_Selects; // 0xE0
	private RefineGodWeaponSelectMenu.SelectEventHandler m_SelectEventHandler; // 0xE8
	private RefineGodWeaponSelectMenu.DecideEventHandler m_DecideEventHandler; // 0xF0
	private RefineGodWeaponSelectMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xF8

	// Properties
	public List<GodUnit> m_GodUnitList { get; set; }
	public int m_GodUnitIndex { get; set; }
	public GodUnit m_GodUnit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3320 Offset: 0x2C3421 VA: 0x2C3320
	// RVA: 0x277BA00 Offset: 0x277BB01 VA: 0x277BA00
	public List<GodUnit> get_m_GodUnitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3330 Offset: 0x2C3431 VA: 0x2C3330
	// RVA: 0x277BA10 Offset: 0x277BB11 VA: 0x277BA10
	private void set_m_GodUnitList(List<GodUnit> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3340 Offset: 0x2C3441 VA: 0x2C3340
	// RVA: 0x277BA20 Offset: 0x277BB21 VA: 0x277BA20
	public int get_m_GodUnitIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3350 Offset: 0x2C3451 VA: 0x2C3350
	// RVA: 0x277BA30 Offset: 0x277BB31 VA: 0x277BA30
	private void set_m_GodUnitIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3360 Offset: 0x2C3461 VA: 0x2C3360
	// RVA: 0x277BA40 Offset: 0x277BB41 VA: 0x277BA40
	public GodUnit get_m_GodUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3370 Offset: 0x2C3471 VA: 0x2C3370
	// RVA: 0x277BA50 Offset: 0x277BB51 VA: 0x277BA50
	private void set_m_GodUnit(GodUnit value) { }

	// RVA: 0x277B2E0 Offset: 0x277B3E1 VA: 0x277B2E0
	public static RefineGodWeaponSelectMenu CreateBind(ProcInst super, RefineGodWeaponSelectMenuContent menuContent, GodUnit initialGodUnit, ItemData initialGodWeapon, int initialScrollIndex, RefineGodWeaponSelectMenu.SelectEventHandler selectEventHandler, RefineGodWeaponSelectMenu.DecideEventHandler decideEventHandler, RefineGodWeaponSelectMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x277BA60 Offset: 0x277BB61 VA: 0x277BA60
	public static List<BasicMenuItem> CreateMenuItem(GodUnit godUnit, RefineGodWeaponSelectMenu.SelectEventHandler selectEventHandler, RefineGodWeaponSelectMenu.DecideEventHandler decideEventHandler, RefineGodWeaponSelectMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x277BDB0 Offset: 0x277BEB1 VA: 0x277BDB0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, List<GodUnit> godUnitList, GodUnit initialGodUnit, ItemData initialGodWeapon, int initialScrollIndex, RefineGodWeaponSelectMenu.SelectEventHandler selectEventHandler, RefineGodWeaponSelectMenu.DecideEventHandler decideEventHandler, RefineGodWeaponSelectMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x277C100 Offset: 0x277C201 VA: 0x277C100 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x277C1B0 Offset: 0x277C2B1 VA: 0x277C1B0
	public void RebuildMenu() { }

	// RVA: 0x277C2A0 Offset: 0x277C3A1 VA: 0x277C2A0
	private void RebuildMenuItem() { }

	// RVA: 0x277C3A0 Offset: 0x277C4A1 VA: 0x277C3A0 Slot: 30
	public override string GetName() { }

	// RVA: 0x277C330 Offset: 0x277C431 VA: 0x277C330
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x277C3F0 Offset: 0x277C4F1 VA: 0x277C3F0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x277C5A0 Offset: 0x277C6A1 VA: 0x277C5A0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x277C760 Offset: 0x277C861 VA: 0x277C760 Slot: 10
	protected override void OnDispose() { }
}

