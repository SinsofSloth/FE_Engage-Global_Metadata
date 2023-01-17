// Namespace: App
public class ArenaBondUnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 10962
{
	// Fields
	public ArenaBondUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x68
	public ArenaBondUnitSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x2960F0 Offset: 0x2961F1 VA: 0x2960F0
	private Unit <Unit>k__BackingField; // 0x78
	private bool IsSelectableUnit; // 0x80

	// Properties
	public Unit Unit { get; set; }
	public bool IsSelectable { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2B20 Offset: 0x2C2C21 VA: 0x2C2B20
	// RVA: 0x21066F0 Offset: 0x21067F1 VA: 0x21066F0
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2B30 Offset: 0x2C2C31 VA: 0x2C2B30
	// RVA: 0x2106700 Offset: 0x2106801 VA: 0x2106700
	private void set_Unit(Unit value) { }

	// RVA: 0x2106710 Offset: 0x2106811 VA: 0x2106710
	public bool get_IsSelectable() { }

	// RVA: 0x2106380 Offset: 0x2106481 VA: 0x2106380
	public void .ctor(Unit unit, ArenaBondUnitSelectMenu.DecideEventHandler decideEventHandler, ArenaBondUnitSelectMenu.SelectEventHandler selectEventHandler) { }

	// RVA: 0x2106730 Offset: 0x2106831 VA: 0x2106730 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2106780 Offset: 0x2106881 VA: 0x2106780 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2106860 Offset: 0x2106961 VA: 0x2106860 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2106890 Offset: 0x2106991 VA: 0x2106890 Slot: 12
	public override void OnSelect() { }
}

