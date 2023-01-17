// Namespace: 
private abstract class DebugUnitRingMenu.UnitMenuItem : MenuItem // TypeDefIndex: 10180
{
	// Fields
	protected Unit m_Unit; // 0x20

	// Methods

	// RVA: 0x1E1AC70 Offset: 0x1E1AD71 VA: 0x1E1AC70
	public void .ctor(Unit unit) { }
}

// Namespace: 
private class DebugUnitRingMenu.ClearRingItem : DebugUnitRingMenu.UnitMenuItem // TypeDefIndex: 10182
{
	// Methods

	// RVA: 0x1E1AC30 Offset: 0x1E1AD31 VA: 0x1E1AC30
	public void .ctor(Unit unit) { }

	// RVA: 0x1E1ACB0 Offset: 0x1E1ADB1 VA: 0x1E1ACB0 Slot: 5
	public override string GetName() { }

	// RVA: 0x1E1AD00 Offset: 0x1E1AE01 VA: 0x1E1AD00 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private abstract class DebugUnitRingMenu.RingLabelItemBase : LabelItem // TypeDefIndex: 10184
{
	// Methods

	// RVA: 0x1E1B5E0 Offset: 0x1E1B6E1 VA: 0x1E1B5E0 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E1B5F0 Offset: 0x1E1B6F1 VA: 0x1E1B5F0 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E1B600 Offset: 0x1E1B701 VA: 0x1E1B600 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E1B610 Offset: 0x1E1B711 VA: 0x1E1B610 Slot: 33
	public override float GetColumnWidth2() { }

	// RVA: 0x1E1B040 Offset: 0x1E1B141 VA: 0x1E1B040
	protected void .ctor() { }
}

// Namespace: 
private class DebugUnitRingMenu.EmblemRingItem : DebugUnitRingMenu.RingItemBase // TypeDefIndex: 10186
{
	// Fields
	private GodUnit m_GodUnit; // 0x28

	// Methods

	// RVA: 0x1E1B210 Offset: 0x1E1B311 VA: 0x1E1B210
	public void .ctor(Unit unit, GodUnit godUnit) { }

	// RVA: 0x1E1B260 Offset: 0x1E1B361 VA: 0x1E1B260 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E1B2F0 Offset: 0x1E1B3F1 VA: 0x1E1B2F0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E1B340 Offset: 0x1E1B441 VA: 0x1E1B340 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1E1B3B0 Offset: 0x1E1B4B1 VA: 0x1E1B3B0 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugUnitRingMenu.CommonRingItem : DebugUnitRingMenu.RingItemBase // TypeDefIndex: 10188
{
	// Fields
	private UnitRing m_Ring; // 0x28

	// Methods

	// RVA: 0x1E1AD60 Offset: 0x1E1AE61 VA: 0x1E1AD60
	public void .ctor(Unit unit, UnitRing ring) { }

	// RVA: 0x1E1ADF0 Offset: 0x1E1AEF1 VA: 0x1E1ADF0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E1AE00 Offset: 0x1E1AF01 VA: 0x1E1AE00 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E1AE30 Offset: 0x1E1AF31 VA: 0x1E1AE30 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1E1AEA0 Offset: 0x1E1AFA1 VA: 0x1E1AEA0 Slot: 12
	public override MenuItem.Result ACall() { }
}

