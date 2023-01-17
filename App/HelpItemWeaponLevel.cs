// Namespace: App
public class HelpItemWeaponLevel : HelpItemBase // TypeDefIndex: 11810
{
	// Fields
	public int m_Index; // 0x50
	private Unit m_TempUnit; // 0x58

	// Properties
	public override HelpManager.HelpItemType HelpItemType { get; }

	// Methods

	// RVA: 0x2DBE210 Offset: 0x2DBE311 VA: 0x2DBE210 Slot: 4
	public override HelpManager.HelpItemType get_HelpItemType() { }

	// RVA: 0x2DBE220 Offset: 0x2DBE321 VA: 0x2DBE220
	private void Awake() { }

	// RVA: 0x2DBE290 Offset: 0x2DBE391 VA: 0x2DBE290
	private ItemData.Kinds GetWeaponKind(Unit unit, int index) { }

	// RVA: 0x2DBE5B0 Offset: 0x2DBE6B1 VA: 0x2DBE5B0 Slot: 7
	public override bool IsValid() { }

	// RVA: 0x2DBE6B0 Offset: 0x2DBE7B1 VA: 0x2DBE6B0 Slot: 6
	public override void SetContents(HelpParamSetter setter) { }

	// RVA: 0x2DBE850 Offset: 0x2DBE951 VA: 0x2DBE850
	public void .ctor() { }
}

