// Namespace: App
public class AccessoryShopBuyMenuContent : BasicMenuContent // TypeDefIndex: 10892
{
	// Fields
	public TextMeshProUGUI m_CaptionText; // 0xE8
	public AccessoryShopBuyMenuContent.KindIcon[] m_KindIcon; // 0xF0
	[SpaceAttribute] // RVA: 0x295E40 Offset: 0x295F41 VA: 0x295E40
	public GameObject m_ContentObject; // 0xF8

	// Methods

	// RVA: 0x2B18D50 Offset: 0x2B18E51 VA: 0x2B18D50 Slot: 31
	protected override void Start() { }

	// RVA: 0x2B18E50 Offset: 0x2B18F51 VA: 0x2B18E50 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2B18EF0 Offset: 0x2B18FF1 VA: 0x2B18EF0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2B17E80 Offset: 0x2B17F81 VA: 0x2B17E80
	public void SetKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B18740 Offset: 0x2B18841 VA: 0x2B18740
	public AccessoryData.Kinds SetToPrevKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B18B70 Offset: 0x2B18C71 VA: 0x2B18B70
	public AccessoryData.Kinds SetToNextKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B18700 Offset: 0x2B18801 VA: 0x2B18700
	public bool IsFirstKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B18B20 Offset: 0x2B18C21 VA: 0x2B18B20
	public bool IsLastKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B18000 Offset: 0x2B18101 VA: 0x2B18000
	public int GetKindCount() { }

	// RVA: 0x2B18FE0 Offset: 0x2B190E1 VA: 0x2B18FE0
	public void .ctor() { }
}

