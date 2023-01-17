// Namespace: App
public class ItemGainSequence : ProcInst // TypeDefIndex: 13009
{
	// Fields
	private Unit m_Unit; // 0x70
	private UnitItem m_UnitItem; // 0x78
	private ItemData m_ItemData; // 0x80
	private string m_Label; // 0x88
	private int m_Count; // 0x90

	// Methods

	// RVA: 0x244A500 Offset: 0x244A601 VA: 0x244A500
	private void .ctor(UnitItem unitItem, Unit unit, string label, int count) { }

	// RVA: 0x244A590 Offset: 0x244A691 VA: 0x244A590
	private void Gain() { }

	// RVA: 0x244AB80 Offset: 0x244AC81 VA: 0x244AB80
	private void Branch() { }

	// RVA: 0x244AC00 Offset: 0x244AD01 VA: 0x244AC00
	private void Tutorial() { }

	// RVA: 0x244AB10 Offset: 0x244AC11 VA: 0x244AB10
	private bool IsPlayer(Unit unit) { }

	// RVA: 0x244ACC0 Offset: 0x244ADC1 VA: 0x244ACC0
	public static void CreateBind(ProcInst super, ItemData item, int count) { }

	// RVA: 0x244B140 Offset: 0x244B241 VA: 0x244B140
	public static void CreateBind(ProcInst super, ItemData item, Unit unit, string label, int count = 1) { }

	// RVA: 0x244AD50 Offset: 0x244AE51 VA: 0x244AD50
	public static void CreateBind(ProcInst super, UnitItem unitItem, Unit unit, string label, int count = 1) { }
}

