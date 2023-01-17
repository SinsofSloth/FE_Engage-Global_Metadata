// Namespace: App
public class RefreshUnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 11706
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298C50 Offset: 0x298D51 VA: 0x298C50
	private Unit <m_Unit>k__BackingField; // 0x68
	private bool m_InitialSelected; // 0x70
	private bool m_Decided; // 0x71
	protected RefreshUnitSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x78
	protected RefreshUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x80

	// Properties
	public Unit m_Unit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C63C0 Offset: 0x2C64C1 VA: 0x2C63C0
	// RVA: 0x2530EF0 Offset: 0x2530FF1 VA: 0x2530EF0
	public Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C63D0 Offset: 0x2C64D1 VA: 0x2C63D0
	// RVA: 0x2530F00 Offset: 0x2531001 VA: 0x2530F00
	private void set_m_Unit(Unit value) { }

	// RVA: 0x252F8B0 Offset: 0x252F9B1 VA: 0x252F8B0
	public void .ctor(Unit unit, bool initialSelected, bool decided, RefreshUnitSelectMenu.SelectEventHandler selectEventHandler, RefreshUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2530F10 Offset: 0x2531011 VA: 0x2530F10 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2530F30 Offset: 0x2531031 VA: 0x2530F30 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2530F40 Offset: 0x2531041 VA: 0x2530F40 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x252FAF0 Offset: 0x252FBF1 VA: 0x252FAF0
	public void SetInitialColor() { }

	// RVA: 0x25310A0 Offset: 0x25311A1 VA: 0x25310A0
	public void UpdateFixedCursor() { }

	// RVA: 0x2530930 Offset: 0x2530A31 VA: 0x2530930
	public void SetDecided(bool decided) { }

	// RVA: 0x25310B0 Offset: 0x25311B1 VA: 0x25310B0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x25310E0 Offset: 0x25311E1 VA: 0x25310E0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x25311D0 Offset: 0x25312D1 VA: 0x25311D0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x25312E0 Offset: 0x25313E1 VA: 0x25312E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

