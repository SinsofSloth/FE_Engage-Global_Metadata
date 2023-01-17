// Namespace: App
public class WeaponShopBuyMenuContent : BasicMenuContent // TypeDefIndex: 11256
{
	// Fields
	public WeaponShopBuyMenuContent.KindIcon[] m_KindIcon; // 0xE8
	[SpaceAttribute] // RVA: 0x2972C0 Offset: 0x2973C1 VA: 0x2972C0
	public TextMeshProUGUI m_ColumnTitleItemText; // 0xF0
	public TextMeshProUGUI m_ColumnTitleStockCountText; // 0xF8
	public TextMeshProUGUI m_ColumnTitlePriceText; // 0x100
	[SpaceAttribute] // RVA: 0x2972E0 Offset: 0x2973E1 VA: 0x2972E0
	public GameObject m_ContentObject; // 0x108
	private int m_EnabledItemKindCount; // 0x110

	// Methods

	// RVA: 0x26CFB10 Offset: 0x26CFC11 VA: 0x26CFB10 Slot: 31
	protected override void Start() { }

	// RVA: 0x26CFE40 Offset: 0x26CFF41 VA: 0x26CFE40 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x26CFE50 Offset: 0x26CFF51 VA: 0x26CFE50 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x26CFEF0 Offset: 0x26CFFF1 VA: 0x26CFEF0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x26CE680 Offset: 0x26CE781 VA: 0x26CE680
	public void SetKind(ItemData.Kinds kind) { }

	// RVA: 0x26CF390 Offset: 0x26CF491 VA: 0x26CF390
	public ItemData.Kinds SetToPrevKind(ItemData.Kinds kind) { }

	// RVA: 0x26CF770 Offset: 0x26CF871 VA: 0x26CF770
	public ItemData.Kinds SetToNextKind(ItemData.Kinds kind) { }

	// RVA: 0x26CF350 Offset: 0x26CF451 VA: 0x26CF350
	public bool IsFirstKind(ItemData.Kinds kind) { }

	// RVA: 0x26CF720 Offset: 0x26CF821 VA: 0x26CF720
	public bool IsLastKind(ItemData.Kinds kind) { }

	// RVA: 0x26CE800 Offset: 0x26CE901 VA: 0x26CE800
	public void EnableItemKind(ItemData.Kinds kind, bool enabled) { }

	// RVA: 0x26CFDA0 Offset: 0x26CFEA1 VA: 0x26CFDA0
	private void UpdateGetKindCount() { }

	// RVA: 0x26CFFE0 Offset: 0x26D00E1 VA: 0x26CFFE0
	public int GetKindCount() { }

	// RVA: 0x26CFFF0 Offset: 0x26D00F1 VA: 0x26CFFF0
	public void .ctor() { }
}

