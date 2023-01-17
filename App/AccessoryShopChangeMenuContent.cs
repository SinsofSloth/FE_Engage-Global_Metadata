// Namespace: App
public class AccessoryShopChangeMenuContent : BasicMenuContent // TypeDefIndex: 10907
{
	// Fields
	public AccessoryShopChangeMenuContent.KindIcon[] m_KindIcon; // 0xE8
	[SpaceAttribute] // RVA: 0x295E60 Offset: 0x295F61 VA: 0x295E60
	public GameObject m_ContentObject; // 0xF0

	// Methods

	// RVA: 0x2B1F2E0 Offset: 0x2B1F3E1 VA: 0x2B1F2E0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2B1F380 Offset: 0x2B1F481 VA: 0x2B1F380 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2B1DFB0 Offset: 0x2B1E0B1 VA: 0x2B1DFB0
	public void SetKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B1ECE0 Offset: 0x2B1EDE1 VA: 0x2B1ECE0
	public AccessoryData.Kinds SetToPrevKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B1F110 Offset: 0x2B1F211 VA: 0x2B1F110
	public AccessoryData.Kinds SetToNextKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B1ECA0 Offset: 0x2B1EDA1 VA: 0x2B1ECA0
	public bool IsFirstKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B1F0C0 Offset: 0x2B1F1C1 VA: 0x2B1F0C0
	public bool IsLastKind(AccessoryData.Kinds kind) { }

	// RVA: 0x2B1E130 Offset: 0x2B1E231 VA: 0x2B1E130
	public int GetKindCount() { }

	// RVA: 0x2B1F470 Offset: 0x2B1F571 VA: 0x2B1F470
	public void .ctor() { }
}

