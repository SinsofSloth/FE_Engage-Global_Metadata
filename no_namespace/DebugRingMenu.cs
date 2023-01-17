// Namespace: 
private class DebugRingMenu.RingMenu : DebugMenu // TypeDefIndex: 10126
{
	// Methods

	// RVA: 0x1E166F0 Offset: 0x1E167F1 VA: 0x1E166F0
	public void Build() { }

	// RVA: 0x1E169A0 Offset: 0x1E16AA1 VA: 0x1E169A0 Slot: 20
	protected override void OnRebuild() { }

	// RVA: 0x1E169B0 Offset: 0x1E16AB1 VA: 0x1E169B0
	public void .ctor() { }
}

// Namespace: 
private class DebugRingMenu.RingLabelItem : LabelItem // TypeDefIndex: 10127
{
	// Methods

	// RVA: 0x1E16550 Offset: 0x1E16651 VA: 0x1E16550 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E16560 Offset: 0x1E16661 VA: 0x1E16560 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E165B0 Offset: 0x1E166B1 VA: 0x1E165B0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E16600 Offset: 0x1E16701 VA: 0x1E16600 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1E16650 Offset: 0x1E16751 VA: 0x1E16650 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E16660 Offset: 0x1E16761 VA: 0x1E16660 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E16670 Offset: 0x1E16771 VA: 0x1E16670 Slot: 33
	public override float GetColumnWidth2() { }

	// RVA: 0x1E16680 Offset: 0x1E16781 VA: 0x1E16680
	public void .ctor() { }
}

// Namespace: 
private class DebugRingMenu.RingItem : MenuItem // TypeDefIndex: 10128
{
	// Fields
	private UnitRing m_Ring; // 0x20

	// Methods

	// RVA: 0x1E16300 Offset: 0x1E16401 VA: 0x1E16300
	public void .ctor(UnitRing ring) { }

	// RVA: 0x1E16340 Offset: 0x1E16441 VA: 0x1E16340 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E16350 Offset: 0x1E16451 VA: 0x1E16350 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E16360 Offset: 0x1E16461 VA: 0x1E16360 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E16390 Offset: 0x1E16491 VA: 0x1E16390 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1E16400 Offset: 0x1E16501 VA: 0x1E16400 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E16410 Offset: 0x1E16511 VA: 0x1E16410 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E16420 Offset: 0x1E16521 VA: 0x1E16420 Slot: 33
	public override float GetColumnWidth2() { }

	// RVA: 0x1E16430 Offset: 0x1E16531 VA: 0x1E16430 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x1E164E0 Offset: 0x1E165E1 VA: 0x1E164E0 Slot: 14
	public override MenuItem.Result XCall() { }

	// RVA: 0x1E16500 Offset: 0x1E16601 VA: 0x1E16500 Slot: 7
	public override string GetHelp() { }
}

// Namespace: 
private class DebugRingMenu.AddRingItem.SubItem : MenuItem // TypeDefIndex: 10129
{
	// Fields
	private RingData m_Data; // 0x20

	// Methods

	// RVA: 0x1DC20C0 Offset: 0x1DC21C1 VA: 0x1DC20C0
	public void .ctor(RingData data) { }

	// RVA: 0x1DC2100 Offset: 0x1DC2201 VA: 0x1DC2100 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC2110 Offset: 0x1DC2211 VA: 0x1DC2110 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugRingMenu.AddRingItem : MenuItem // TypeDefIndex: 10130
{
	// Methods

	// RVA: 0x1E160C0 Offset: 0x1E161C1 VA: 0x1E160C0 Slot: 5
	public override string GetName() { }

	// RVA: 0x1E16110 Offset: 0x1E16211 VA: 0x1E16110 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1E162F0 Offset: 0x1E163F1 VA: 0x1E162F0
	public void .ctor() { }
}

// Namespace: 
private class DebugRingMenu.AddAllCommonRingItem : MenuItem // TypeDefIndex: 10131
{
	// Fields
	private int m_Count; // 0x20

	// Methods

	// RVA: 0x1E15F80 Offset: 0x1E16081 VA: 0x1E15F80 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E15F90 Offset: 0x1E16091 VA: 0x1E15F90 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E15FE0 Offset: 0x1E160E1 VA: 0x1E15FE0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E15FF0 Offset: 0x1E160F1 VA: 0x1E15FF0 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E16000 Offset: 0x1E16101 VA: 0x1E16000 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E16010 Offset: 0x1E16111 VA: 0x1E16010 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x1E160A0 Offset: 0x1E161A1 VA: 0x1E160A0 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1E160B0 Offset: 0x1E161B1 VA: 0x1E160B0
	public void .ctor() { }
}

