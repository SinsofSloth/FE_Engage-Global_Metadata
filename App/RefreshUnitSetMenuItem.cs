// Namespace: App
public class RefreshUnitSetMenuItem : BasicMenuItem // TypeDefIndex: 11719
{
	// Fields
	private Unit m_Unit; // 0x68
	private bool m_Decided; // 0x70
	private RefreshUnitSetMenu.DecideEventHandler m_DecideEventHandler; // 0x78

	// Methods

	// RVA: 0x25339F0 Offset: 0x2533AF1 VA: 0x25339F0
	public void .ctor(Unit unit, RefreshUnitSetMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x25353B0 Offset: 0x25354B1 VA: 0x25353B0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x25353C0 Offset: 0x25354C1 VA: 0x25353C0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x25354C0 Offset: 0x25355C1 VA: 0x25354C0
	public void SetInitialColor() { }

	// RVA: 0x2535780 Offset: 0x2535881 VA: 0x2535780 Slot: 4
	public override string GetName() { }

	// RVA: 0x2534920 Offset: 0x2534A21 VA: 0x2534920
	public void SetUnit(Unit unit) { }

	// RVA: 0x25357F0 Offset: 0x25358F1 VA: 0x25357F0
	public void UpdateFixedCursor() { }

	// RVA: 0x2534B00 Offset: 0x2534C01 VA: 0x2534B00
	public void SetDecided(bool decided) { }

	// RVA: 0x2535A00 Offset: 0x2535B01 VA: 0x2535A00 Slot: 18
	public override BasicMenu.Result ACall() { }
}

