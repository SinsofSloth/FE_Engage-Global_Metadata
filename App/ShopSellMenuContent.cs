// Namespace: App
public class ShopSellMenuContent : BasicMenuContent // TypeDefIndex: 11201
{
	// Fields
	public ShopSellMenuContent.KindIcon[] m_KindIcon; // 0xE8
	[SpaceAttribute] // RVA: 0x296F40 Offset: 0x297041 VA: 0x296F40
	public TextMeshProUGUI m_ColumnTitleItemText; // 0xF0
	public TextMeshProUGUI m_ColumnTitleUsableCountText; // 0xF8
	public TextMeshProUGUI m_ColumnTitlePriceText; // 0x100
	[SpaceAttribute] // RVA: 0x296F60 Offset: 0x297061 VA: 0x296F60
	public GameObject m_ContentObject; // 0x108

	// Methods

	// RVA: 0x2338DE0 Offset: 0x2338EE1 VA: 0x2338DE0 Slot: 31
	protected override void Start() { }

	// RVA: 0x2339000 Offset: 0x2339101 VA: 0x2339000 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x23390A0 Offset: 0x23391A1 VA: 0x23390A0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x23374A0 Offset: 0x23375A1 VA: 0x23374A0
	public void SetKind(ItemData.Kinds kind) { }

	// RVA: 0x2338100 Offset: 0x2338201 VA: 0x2338100
	public ItemData.Kinds SetToPrevKind(ItemData.Kinds kind) { }

	// RVA: 0x23384C0 Offset: 0x23385C1 VA: 0x23384C0
	public ItemData.Kinds SetToNextKind(ItemData.Kinds kind) { }

	// RVA: 0x2337AA0 Offset: 0x2337BA1 VA: 0x2337AA0
	public ItemData.Kinds GetFirstKind() { }

	// RVA: 0x2337AD0 Offset: 0x2337BD1 VA: 0x2337AD0
	public ItemData.Kinds GetLastKind() { }

	// RVA: 0x23380C0 Offset: 0x23381C1 VA: 0x23380C0
	public bool IsFirstKind(ItemData.Kinds kind) { }

	// RVA: 0x2338470 Offset: 0x2338571 VA: 0x2338470
	public bool IsLastKind(ItemData.Kinds kind) { }

	// RVA: 0x2337620 Offset: 0x2337721 VA: 0x2337620
	public int GetKindCount() { }

	// RVA: 0x2339190 Offset: 0x2339291 VA: 0x2339190
	public void .ctor() { }
}

