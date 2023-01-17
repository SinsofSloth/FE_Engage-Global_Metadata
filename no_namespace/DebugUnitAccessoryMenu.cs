// Namespace: 
private class DebugUnitAccessoryMenu.UnitAccessoryAddItem : DebugUnitAccessoryMenu.UnitBaseItem // TypeDefIndex: 10150
{
	// Fields
	private bool m_IsEnable; // 0x28
	private AccessoryData m_Accessory; // 0x30
	private AccessoryData.Kinds m_Kind; // 0x38

	// Methods

	// RVA: 0x1E18220 Offset: 0x1E18321 VA: 0x1E18220
	public void .ctor(Unit unit, AccessoryData accessory, AccessoryData.Kinds kind) { }

	// RVA: 0x1E182E0 Offset: 0x1E183E1 VA: 0x1E182E0 Slot: 5
	public override string GetName() { }

	// RVA: 0x1E182F0 Offset: 0x1E183F1 VA: 0x1E182F0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x1E18300 Offset: 0x1E18401 VA: 0x1E18300 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitAccessoryMenu.UnitAccessoryItem : DebugUnitAccessoryMenu.UnitBaseItem // TypeDefIndex: 10152
{
	// Fields
	private string m_Label; // 0x28
	private AccessoryData.Kinds m_Kind; // 0x30

	// Methods

	// RVA: 0x1E18350 Offset: 0x1E18451 VA: 0x1E18350
	public void .ctor(Unit unit, AccessoryData.Kinds kind) { }

	// RVA: 0x1E183A0 Offset: 0x1E184A1 VA: 0x1E183A0 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E183B0 Offset: 0x1E184B1 VA: 0x1E183B0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E18440 Offset: 0x1E18541 VA: 0x1E18440 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E18480 Offset: 0x1E18581 VA: 0x1E18480 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E18490 Offset: 0x1E18591 VA: 0x1E18490 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E184A0 Offset: 0x1E185A1 VA: 0x1E184A0 Slot: 12
	public override MenuItem.Result ACall() { }
}

