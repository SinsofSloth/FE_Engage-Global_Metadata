// Namespace: App
public class DiscardItemMenuContent : BasicMenuContent // TypeDefIndex: 12545
{
	// Fields
	public DiscardItemMenuContent.KindIcon[] m_KindIcon; // 0xE8
	public TextMeshProUGUI m_MenuTitleText; // 0xF0
	public TextMeshProUGUI m_TransporterText; // 0xF8
	public TextMeshProUGUI m_StockValueText; // 0x100
	public TextMeshProUGUI m_StockValueMaxText; // 0x108

	// Methods

	// RVA: 0x2375E60 Offset: 0x2375F61 VA: 0x2375E60 Slot: 18
	public override void BuildMenuItemContent() { }

	// RVA: 0x2376030 Offset: 0x2376131 VA: 0x2376030 Slot: 31
	protected override void Start() { }

	// RVA: 0x2376270 Offset: 0x2376371 VA: 0x2376270 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2376360 Offset: 0x2376461 VA: 0x2376360
	public void SetKind(ItemData.Kinds kind) { }

	// RVA: 0x23754D0 Offset: 0x23755D1 VA: 0x23754D0
	public ItemData.Kinds SetToPrevKind(ItemData.Kinds kind) { }

	// RVA: 0x2375890 Offset: 0x2375991 VA: 0x2375890
	public ItemData.Kinds SetToNextKind(ItemData.Kinds kind) { }

	// RVA: 0x2375490 Offset: 0x2375591 VA: 0x2375490
	public bool IsFirstKind(ItemData.Kinds kind) { }

	// RVA: 0x2375840 Offset: 0x2375941 VA: 0x2375840
	public bool IsLastKind(ItemData.Kinds kind) { }

	// RVA: 0x2374E90 Offset: 0x2374F91 VA: 0x2374E90
	public int GetKindCount() { }

	// RVA: 0x23764E0 Offset: 0x23765E1 VA: 0x23764E0
	public void .ctor() { }
}

