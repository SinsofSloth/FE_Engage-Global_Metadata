// Namespace: App
public class MaterialListMenu : BasicMenu // TypeDefIndex: 11032
{
	// Fields
	private List<BasicMenuItem> m_MenuItemListAll; // 0xC8
	private List<BasicMenuItem> m_MenuItemListGift; // 0xD0
	private List<BasicMenuItem> m_MenuItemListFood; // 0xD8
	private List<BasicMenuItem> m_MenuItemListMaterial; // 0xE0
	private List<BasicMenuItem> m_MenuItemListOther; // 0xE8
	private List<BasicMenuSelect> m_MenuSelectList; // 0xF0

	// Methods

	// RVA: 0x285B6D0 Offset: 0x285B7D1 VA: 0x285B6D0
	public static MaterialListMenu CreateBind(ProcInst super) { }

	// RVA: 0x285C200 Offset: 0x285C301 VA: 0x285C200
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, List<BasicMenuItem> menuItemListGift, List<BasicMenuItem> menuItemListFood, List<BasicMenuItem> menuItemListMaterial, List<BasicMenuItem> menuItemListOther) { }

	// RVA: 0x285C550 Offset: 0x285C651 VA: 0x285C550 Slot: 30
	public override string GetName() { }

	// RVA: 0x285C5A0 Offset: 0x285C6A1 VA: 0x285C5A0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x285C6D0 Offset: 0x285C7D1 VA: 0x285C6D0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x285CD80 Offset: 0x285CE81 VA: 0x285CD80 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x285D150 Offset: 0x285D251 VA: 0x285D150
	public void SetItemHelpText(string text) { }

	// RVA: 0x285C890 Offset: 0x285C991 VA: 0x285C890
	public MaterialListMenuContent.CategoryType GetCategory() { }

	// RVA: 0x285CB20 Offset: 0x285CC21 VA: 0x285CB20
	public void SortCategory() { }
}

