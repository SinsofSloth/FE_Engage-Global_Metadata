// Namespace: 
public class GodRoomUnitSelectMenu.GodRoomUnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 10995
{
	// Fields
	private int m_Index; // 0x64
	private Unit m_Unit; // 0x68
	public GodRoomUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x1FA3CE0 Offset: 0x1FA3DE1 VA: 0x1FA3CE0
	public void .ctor(int index, Unit unit, GodRoomUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1FA3F90 Offset: 0x1FA4091 VA: 0x1FA3F90 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3FA0 Offset: 0x1FA40A1 VA: 0x1FA3FA0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3EE0 Offset: 0x1FA3FE1 VA: 0x1FA3EE0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1FA3FB0 Offset: 0x1FA40B1 VA: 0x1FA3FB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1FA4070 Offset: 0x1FA4171 VA: 0x1FA4070 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1FA4110 Offset: 0x1FA4211 VA: 0x1FA4110
	public Unit GetUnit() { }
}

