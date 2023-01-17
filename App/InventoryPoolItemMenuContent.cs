// Namespace: App
public class InventoryPoolItemMenuContent : BasicMenuContent // TypeDefIndex: 13199
{
	// Fields
	[HeaderAttribute] // RVA: 0x29BC30 Offset: 0x29BD31 VA: 0x29BC30
	public TextMeshProUGUI m_MenuTitleText; // 0xE8
	public TextMeshProUGUI m_TransporterText; // 0xF0
	public TextMeshProUGUI m_StockValueText; // 0xF8
	public TextMeshProUGUI m_StockValueMaxText; // 0x100
	[HeaderAttribute] // RVA: 0x29BC70 Offset: 0x29BD71 VA: 0x29BC70
	public List<InventoryPoolItemMenuContent.KindBgNameClass> m_KindBgName; // 0x108

	// Methods

	// RVA: 0x2B539F0 Offset: 0x2B53AF1 VA: 0x2B539F0 Slot: 31
	protected override void Start() { }

	// RVA: 0x2B53B90 Offset: 0x2B53C91 VA: 0x2B53B90 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2B53BB0 Offset: 0x2B53CB1 VA: 0x2B53BB0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2B53CA0 Offset: 0x2B53DA1 VA: 0x2B53CA0
	public int GetKindNum() { }

	// RVA: 0x2B50D80 Offset: 0x2B50E81 VA: 0x2B50D80
	public ItemData.Kinds GetFirstKind() { }

	// RVA: 0x2B50F30 Offset: 0x2B51031 VA: 0x2B50F30
	public ItemData.Kinds GetLastKind() { }

	// RVA: 0x2B511A0 Offset: 0x2B512A1 VA: 0x2B511A0
	public ItemData.Kinds GetNextKind(ItemData.Kinds kind) { }

	// RVA: 0x2B514A0 Offset: 0x2B515A1 VA: 0x2B514A0
	public ItemData.Kinds GetPrevKind(ItemData.Kinds kind) { }

	// RVA: 0x2B53CF0 Offset: 0x2B53DF1 VA: 0x2B53CF0
	public int GetKindIndex(ItemData.Kinds kind) { }

	// RVA: 0x2B523B0 Offset: 0x2B524B1 VA: 0x2B523B0
	public void SetKind(ItemData.Kinds kind) { }

	// RVA: 0x2B525A0 Offset: 0x2B526A1 VA: 0x2B525A0
	public void SetStockValue(int value) { }

	// RVA: 0x2B52660 Offset: 0x2B52761 VA: 0x2B52660
	public void SetStockValueMax(int value) { }

	// RVA: 0x2B53E60 Offset: 0x2B53F61 VA: 0x2B53E60
	public void .ctor() { }
}

