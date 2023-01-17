// Namespace: App
public class HelpItemUnitItem : HelpItemBase // TypeDefIndex: 11807
{
	// Fields
	public bool m_IsOutsideSetup; // 0x50
	public int m_Index; // 0x54
	private Unit m_Unit; // 0x58
	private UnitItem m_UnitItem; // 0x60
	private bool m_IsUseEnchant; // 0x68

	// Properties
	public override int StartItemConstPriority { get; }

	// Methods

	// RVA: 0x2DBD120 Offset: 0x2DBD221 VA: 0x2DBD120 Slot: 5
	public override int get_StartItemConstPriority() { }

	// RVA: 0x2DBD130 Offset: 0x2DBD231 VA: 0x2DBD130
	public void SetData(Unit unit, UnitItem item, bool isUseEnchant = False) { }

	// RVA: 0x2DBD180 Offset: 0x2DBD281 VA: 0x2DBD180 Slot: 7
	public override bool IsValid() { }

	// RVA: 0x2DBD470 Offset: 0x2DBD571 VA: 0x2DBD470 Slot: 6
	public override void SetContents(HelpParamSetter setter) { }

	// RVA: 0x2DBC670 Offset: 0x2DBC771 VA: 0x2DBC670
	public void .ctor() { }
}

