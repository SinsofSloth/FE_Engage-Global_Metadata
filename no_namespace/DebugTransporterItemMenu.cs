// Namespace: 
private class DebugTransporterItemMenu.EditMenuItem : MenuItem // TypeDefIndex: 10138
{
	// Fields
	private int m_TransporterIndex; // 0x20

	// Methods

	// RVA: 0x1E16AB0 Offset: 0x1E16BB1 VA: 0x1E16AB0
	public void .ctor(int index) { }

	// RVA: 0x1E16AE0 Offset: 0x1E16BE1 VA: 0x1E16AE0 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E16AF0 Offset: 0x1E16BF1 VA: 0x1E16AF0 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E16B00 Offset: 0x1E16C01 VA: 0x1E16B00 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E16B10 Offset: 0x1E16C11 VA: 0x1E16B10 Slot: 33
	public override float GetColumnWidth2() { }

	// RVA: 0x1E16B20 Offset: 0x1E16C21 VA: 0x1E16B20 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E16B30 Offset: 0x1E16C31 VA: 0x1E16B30
	private UnitItem GetUnitItem() { }

	// RVA: 0x1E16BB0 Offset: 0x1E16CB1 VA: 0x1E16BB0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E16CD0 Offset: 0x1E16DD1 VA: 0x1E16CD0 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1E16DC0 Offset: 0x1E16EC1 VA: 0x1E16DC0 Slot: 53
	public override MenuItem.Align GetColumnAlign0() { }

	// RVA: 0x1E16DD0 Offset: 0x1E16ED1 VA: 0x1E16DD0 Slot: 54
	public override MenuItem.Align GetColumnAlign1() { }

	// RVA: 0x1E16DE0 Offset: 0x1E16EE1 VA: 0x1E16DE0 Slot: 55
	public override MenuItem.Align GetColumnAlign2() { }

	// RVA: 0x1E16DF0 Offset: 0x1E16EF1 VA: 0x1E16DF0 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1E17010 Offset: 0x1E17111 VA: 0x1E17010 Slot: 14
	public override MenuItem.Result XCall() { }

	// RVA: 0x1E17030 Offset: 0x1E17131 VA: 0x1E17030 Slot: 7
	public override string GetHelp() { }
}

// Namespace: 
private class DebugTransporterItemMenu.SelectMenuItem : MenuItem // TypeDefIndex: 10139
{
	// Fields
	private int m_TransporterIndex; // 0x20
	private int m_ItemIndex; // 0x24

	// Methods

	// RVA: 0x1E16FD0 Offset: 0x1E170D1 VA: 0x1E16FD0
	public void .ctor(int transporterIndex, int itemIndex) { }

	// RVA: 0x1E17080 Offset: 0x1E17181 VA: 0x1E17080 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1E17090 Offset: 0x1E17191 VA: 0x1E17090 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E170A0 Offset: 0x1E171A1 VA: 0x1E170A0 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1E170B0 Offset: 0x1E171B1 VA: 0x1E170B0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1E170C0 Offset: 0x1E171C1 VA: 0x1E170C0 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1E17150 Offset: 0x1E17251 VA: 0x1E17150 Slot: 12
	public override MenuItem.Result ACall() { }
}

