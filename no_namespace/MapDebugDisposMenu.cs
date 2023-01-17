// Namespace: 
public class MapDebugDisposMenu.DisposMenuItem.SharedPositionGroup // TypeDefIndex: 11877
{
	// Fields
	private string m_PositionGroup; // 0x10

	// Methods

	// RVA: 0x21E2D20 Offset: 0x21E2E21 VA: 0x21E2D20
	public void Set(string positionGroup) { }

	// RVA: 0x21E2D30 Offset: 0x21E2E31 VA: 0x21E2D30
	public string Get() { }

	// RVA: 0x21E2D40 Offset: 0x21E2E41 VA: 0x21E2D40
	public void Clear() { }

	// RVA: 0x21E2D50 Offset: 0x21E2E51 VA: 0x21E2D50
	public void .ctor() { }
}

// Namespace: 
private class MapDebugDisposMenu.DisposMenuItem : MenuItem // TypeDefIndex: 11878
{
	// Fields
	private string m_Group; // 0x20
	private MapDebugDisposMenu.DisposMenuItem.SharedPositionGroup m_PositionGroup; // 0x28

	// Methods

	// RVA: 0x1D38190 Offset: 0x1D38291 VA: 0x1D38190
	public void .ctor(string group, MapDebugDisposMenu.DisposMenuItem.SharedPositionGroup positionGroup) { }

	// RVA: 0x1D381E0 Offset: 0x1D382E1 VA: 0x1D381E0 Slot: 5
	public override string GetName() { }

	// RVA: 0x1D381F0 Offset: 0x1D382F1 VA: 0x1D381F0
	private static void DrawCell(string group, string position) { }

	// RVA: 0x1D38520 Offset: 0x1D38621 VA: 0x1D38520 Slot: 68
	public override void OnTick() { }

	// RVA: 0x1D38530 Offset: 0x1D38631 VA: 0x1D38530 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1D38560 Offset: 0x1D38661 VA: 0x1D38560 Slot: 14
	public override MenuItem.Result XCall() { }
}

// Namespace: 
private class MapDebugDisposMenu.DeleteForceMenuItem : MenuItem // TypeDefIndex: 11879
{
	// Fields
	private Force.Type m_ForceType; // 0x20
	private string m_ForceName; // 0x28
	private string m_ForceUnitCount; // 0x30

	// Methods

	// RVA: 0x1D37EA0 Offset: 0x1D37FA1 VA: 0x1D37EA0
	public void .ctor(Force.Type forceType) { }

	// RVA: 0x1D37FA0 Offset: 0x1D380A1 VA: 0x1D37FA0 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x1D37FB0 Offset: 0x1D380B1 VA: 0x1D37FB0 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1D37FC0 Offset: 0x1D380C1 VA: 0x1D37FC0 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x1D37FD0 Offset: 0x1D380D1 VA: 0x1D37FD0 Slot: 33
	public override float GetColumnWidth2() { }

	// RVA: 0x1D37FE0 Offset: 0x1D380E1 VA: 0x1D37FE0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x1D38030 Offset: 0x1D38131 VA: 0x1D38030 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x1D38040 Offset: 0x1D38141 VA: 0x1D38040 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x1D38050 Offset: 0x1D38151 VA: 0x1D38050 Slot: 68
	public override void OnTick() { }

	// RVA: 0x1D38060 Offset: 0x1D38161 VA: 0x1D38060 Slot: 12
	public override MenuItem.Result ACall() { }
}

