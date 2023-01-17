// Namespace: 
public class UnitSelectMenu.UnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 14257
{
	// Fields
	private Unit m_Unit; // 0x68
	private bool m_IsDecided; // 0x70
	private UnitSelectMenu.UnitSelectMenuItem.SelectEventHandler m_SelectEventHander; // 0x78

	// Methods

	// RVA: 0x1ED6B90 Offset: 0x1ED6C91 VA: 0x1ED6B90
	public void .ctor(Unit unit, UnitSelectMenu.UnitSelectMenuItem.SelectEventHandler selectEventHandler) { }

	// RVA: 0x1ED6BE0 Offset: 0x1ED6CE1 VA: 0x1ED6BE0
	public Unit Decide() { }

	// RVA: 0x1ED6BF0 Offset: 0x1ED6CF1 VA: 0x1ED6BF0
	public void Cancel() { }

	// RVA: 0x1ED6C00 Offset: 0x1ED6D01 VA: 0x1ED6C00 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1ED6DF0 Offset: 0x1ED6EF1 VA: 0x1ED6DF0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1ED6E00 Offset: 0x1ED6F01 VA: 0x1ED6E00
	public Unit GetUnit() { }

	// RVA: 0x1ED6E10 Offset: 0x1ED6F11 VA: 0x1ED6E10
	public bool IsDecided() { }
}

