// Namespace: App
public class RefineGodWeaponParamMenu : BasicMenu // TypeDefIndex: 11056
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2962F0 Offset: 0x2963F1 VA: 0x2962F0
	private GodUnit <m_GodUnit>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x296300 Offset: 0x296401 VA: 0x296300
	private List<ItemData> <m_GodWeaponList>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x296310 Offset: 0x296411 VA: 0x296310
	private int <m_GodWeaponIndex>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x296320 Offset: 0x296421 VA: 0x296320
	private ItemData <m_GodWeapon>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x296330 Offset: 0x296431 VA: 0x296330
	private bool <m_RefineOrReset>k__BackingField; // 0xE8
	public static readonly GodWeaponRefineData.Kind[] m_MenuItemOrder; // 0x0
	private BasicMenuSelect[] m_Selects; // 0xF0
	private RefineGodWeaponParamMenu.SelectEventHandler m_SelectEventHandler; // 0xF8
	private RefineGodWeaponParamMenu.DecideEventHandler m_DecideEventHandler; // 0x100
	private RefineGodWeaponParamMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0x108

	// Properties
	public GodUnit m_GodUnit { get; set; }
	public List<ItemData> m_GodWeaponList { get; set; }
	public int m_GodWeaponIndex { get; set; }
	public ItemData m_GodWeapon { get; set; }
	public bool m_RefineOrReset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C30F0 Offset: 0x2C31F1 VA: 0x2C30F0
	// RVA: 0x2776140 Offset: 0x2776241 VA: 0x2776140
	public GodUnit get_m_GodUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3100 Offset: 0x2C3201 VA: 0x2C3100
	// RVA: 0x2776150 Offset: 0x2776251 VA: 0x2776150
	private void set_m_GodUnit(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3110 Offset: 0x2C3211 VA: 0x2C3110
	// RVA: 0x2776160 Offset: 0x2776261 VA: 0x2776160
	public List<ItemData> get_m_GodWeaponList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3120 Offset: 0x2C3221 VA: 0x2C3120
	// RVA: 0x2776170 Offset: 0x2776271 VA: 0x2776170
	private void set_m_GodWeaponList(List<ItemData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3130 Offset: 0x2C3231 VA: 0x2C3130
	// RVA: 0x2776180 Offset: 0x2776281 VA: 0x2776180
	public int get_m_GodWeaponIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3140 Offset: 0x2C3241 VA: 0x2C3140
	// RVA: 0x2776190 Offset: 0x2776291 VA: 0x2776190
	private void set_m_GodWeaponIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3150 Offset: 0x2C3251 VA: 0x2C3150
	// RVA: 0x27761A0 Offset: 0x27762A1 VA: 0x27761A0
	public ItemData get_m_GodWeapon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3160 Offset: 0x2C3261 VA: 0x2C3160
	// RVA: 0x27761B0 Offset: 0x27762B1 VA: 0x27761B0
	private void set_m_GodWeapon(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3170 Offset: 0x2C3271 VA: 0x2C3170
	// RVA: 0x27761C0 Offset: 0x27762C1 VA: 0x27761C0
	public bool get_m_RefineOrReset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3180 Offset: 0x2C3281 VA: 0x2C3180
	// RVA: 0x27761D0 Offset: 0x27762D1 VA: 0x27761D0
	private void set_m_RefineOrReset(bool value) { }

	// RVA: 0x2774980 Offset: 0x2774A81 VA: 0x2774980
	public static RefineGodWeaponParamMenu CreateBind(ProcInst super, RefineGodWeaponParamMenuContent menuContent, GodUnit godUnit, ItemData initialGodWeapon, bool refineOrReset, RefineGodWeaponParamMenu.SelectEventHandler selectEventHandler, RefineGodWeaponParamMenu.DecideEventHandler decideEventHandler, RefineGodWeaponParamMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x27761E0 Offset: 0x27762E1 VA: 0x27761E0
	public static List<BasicMenuItem> CreateMenuItem(ItemData godWeapon, GodUnit godUnit, bool refineOrReset, RefineGodWeaponParamMenu.SelectEventHandler selectEventHandler, RefineGodWeaponParamMenu.DecideEventHandler decideEventHandler, RefineGodWeaponParamMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2776590 Offset: 0x2776691 VA: 0x2776590
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, GodUnit godUnit, List<ItemData> godWeaponList, int initialGodWeaponIndex, bool refineOrReset, RefineGodWeaponParamMenu.SelectEventHandler selectEventHandler, RefineGodWeaponParamMenu.DecideEventHandler decideEventHandler, RefineGodWeaponParamMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x27758F0 Offset: 0x27759F1 VA: 0x27758F0
	public void RebuildMenu() { }

	// RVA: 0x2776840 Offset: 0x2776941 VA: 0x2776840 Slot: 30
	public override string GetName() { }

	// RVA: 0x27767D0 Offset: 0x27768D1 VA: 0x27767D0
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x2776890 Offset: 0x2776991 VA: 0x2776890 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x27769F0 Offset: 0x2776AF1 VA: 0x27769F0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2776B60 Offset: 0x2776C61 VA: 0x2776B60 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x2776BE0 Offset: 0x2776CE1 VA: 0x2776BE0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2776CB0 Offset: 0x2776DB1 VA: 0x2776CB0
	private static void .cctor() { }
}

