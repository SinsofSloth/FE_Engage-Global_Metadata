// Namespace: App
public class MapImageHistory // TypeDefIndex: 12115
{
	// Fields
	public MapImageHistory.HeatMap UnitMap; // 0x10
	public MapImageHistory.HeatMap BattleMap; // 0x18
	public MapImageHistory.HeatMap DeadMap; // 0x20
	private MapPos[] m_Cells; // 0x28

	// Methods

	// RVA: 0x246C360 Offset: 0x246C461 VA: 0x246C360
	public void Clear() { }

	[ConditionalAttribute] // RVA: 0x2C7CA0 Offset: 0x2C7DA1 VA: 0x2C7CA0
	// RVA: 0x246C3A0 Offset: 0x246C4A1 VA: 0x246C3A0
	public void UpdatePhase() { }

	[ConditionalAttribute] // RVA: 0x2C7CE0 Offset: 0x2C7DE1 VA: 0x2C7CE0
	// RVA: 0x246C650 Offset: 0x246C751 VA: 0x246C650
	public void AddDead(Unit unit) { }

	[ConditionalAttribute] // RVA: 0x2C7D20 Offset: 0x2C7E21 VA: 0x2C7D20
	// RVA: 0x246C730 Offset: 0x246C831 VA: 0x246C730
	public void AddBattle(Unit unit) { }

	// RVA: 0x246C810 Offset: 0x246C911 VA: 0x246C810
	public void .ctor() { }
}

