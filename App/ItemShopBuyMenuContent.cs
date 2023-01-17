// Namespace: App
public class ItemShopBuyMenuContent : BasicMenuContent // TypeDefIndex: 11023
{
	// Fields
	public TextMeshProUGUI m_ColumnTitleItemText; // 0xE8
	public TextMeshProUGUI m_ColumnTitleCountText; // 0xF0
	public TextMeshProUGUI m_ColumnTitleStockText; // 0xF8
	public TextMeshProUGUI m_ColumnTitlePriceText; // 0x100
	[SpaceAttribute] // RVA: 0x296230 Offset: 0x296331 VA: 0x296230
	public GameObject m_ContentObject; // 0x108
	[SpaceAttribute] // RVA: 0x296250 Offset: 0x296351 VA: 0x296250
	public TextMeshProUGUI m_ItemDetailMessageText; // 0x110
	public TextMeshProUGUI m_ItemDetailSubMessageText; // 0x118

	// Methods

	// RVA: 0x2457070 Offset: 0x2457171 VA: 0x2457070 Slot: 31
	protected override void Start() { }

	// RVA: 0x2457310 Offset: 0x2457411 VA: 0x2457310 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x24573B0 Offset: 0x24574B1 VA: 0x24573B0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2456ED0 Offset: 0x2456FD1 VA: 0x2456ED0
	public void UpdateItemDetailMessages(ItemData itemData) { }

	// RVA: 0x24574A0 Offset: 0x24575A1 VA: 0x24574A0
	public void .ctor() { }
}

