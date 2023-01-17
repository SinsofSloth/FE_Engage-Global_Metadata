// Namespace: App
public class VersusEditMenu : BasicMenu // TypeDefIndex: 13724
{
	// Fields
	private static VersusMapEditContent m_MenuEditContent; // 0x0
	private static Action<int> m_ToOneCallCallback; // 0x8
	private static int m_FirstSelect; // 0x10
	private static Action m_OnCloseCallback; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29C920 Offset: 0x29CA21 VA: 0x29C920
	private VersusMapEditObjListMenuItemContent <MenuItemContentOld>k__BackingField; // 0xC8

	// Properties
	public VersusMapEditObjListMenuItemContent MenuItemContentOld { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD1A0 Offset: 0x2CD2A1 VA: 0x2CD1A0
	// RVA: 0x2A48740 Offset: 0x2A48841 VA: 0x2A48740
	public VersusMapEditObjListMenuItemContent get_MenuItemContentOld() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD1B0 Offset: 0x2CD2B1 VA: 0x2CD1B0
	// RVA: 0x2A48750 Offset: 0x2A48851 VA: 0x2A48750
	public void set_MenuItemContentOld(VersusMapEditObjListMenuItemContent value) { }

	// RVA: 0x2A48760 Offset: 0x2A48861 VA: 0x2A48760
	public static void CreateBind(ProcInst super, List<MapEditorObjectData> objList, VersusMapEditContent menuEditContent, Action<int> ToOneCallCallback, int firstSelect, Action<MapEditorCategoryData> onSelectCallback, Action onCloseCallback) { }

	// RVA: 0x2A48C10 Offset: 0x2A48D11 VA: 0x2A48C10
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusMapEditObjListMenuContent menuContent, int firstSelect) { }

	// RVA: 0x2A48C50 Offset: 0x2A48D51 VA: 0x2A48C50 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2A48FB0 Offset: 0x2A490B1 VA: 0x2A48FB0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2A49050 Offset: 0x2A49151 VA: 0x2A49050 Slot: 30
	public override string GetName() { }

	// RVA: 0x2A490A0 Offset: 0x2A491A1 VA: 0x2A490A0 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2A490B0 Offset: 0x2A491B1 VA: 0x2A490B0 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2A490C0 Offset: 0x2A491C1 VA: 0x2A490C0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2A490D0 Offset: 0x2A491D1 VA: 0x2A490D0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2A490E0 Offset: 0x2A491E1 VA: 0x2A490E0 Slot: 39
	protected override bool TickInput() { }

	// RVA: 0x2A4A210 Offset: 0x2A4A311 VA: 0x2A4A210
	public Sprite GetThumbSprite(string name) { }

	// RVA: 0x2A4A2A0 Offset: 0x2A4A3A1 VA: 0x2A4A2A0
	public Sprite GetCategorySprite(string name) { }

	// RVA: 0x2A4A330 Offset: 0x2A4A431 VA: 0x2A4A330
	public void ToOne(int selectIndex = -1) { }

	// RVA: 0x2A4A5B0 Offset: 0x2A4A6B1 VA: 0x2A4A5B0
	private static void .cctor() { }
}

