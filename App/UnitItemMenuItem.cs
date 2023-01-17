// Namespace: App
internal class UnitItemMenuItem : BasicItemMenuItem // TypeDefIndex: 12681
{
	// Fields
	protected int m_OwnerItemIndex; // 0x64
	protected bool m_SelectableBlank; // 0x68
	protected UnitItemMenu.SelectEventHandler m_SelectEventHandler; // 0x70
	protected UnitItemMenu.DecideEventHandler m_DecideEventHandler; // 0x78
	protected UnitItemMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0x80

	// Methods

	// RVA: 0x243C0C0 Offset: 0x243C1C1 VA: 0x243C0C0
	public void .ctor(int i, bool selectableBlank, UnitItemMenu.SelectEventHandler selectEventHandler, UnitItemMenu.DecideEventHandler decideEventHandler, UnitItemMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2442A50 Offset: 0x2442B51 VA: 0x2442A50 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2442B00 Offset: 0x2442C01 VA: 0x2442B00 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x2442B60 Offset: 0x2442C61 VA: 0x2442B60 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x2442BE0 Offset: 0x2442CE1 VA: 0x2442BE0 Slot: 29
	protected override Unit GetRecieverUnit() { }

	// RVA: 0x2442BF0 Offset: 0x2442CF1 VA: 0x2442BF0 Slot: 31
	public override bool IsVisibleItemIconOnBlank() { }

	// RVA: 0x243C1D0 Offset: 0x243C2D1 VA: 0x243C1D0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2442C00 Offset: 0x2442D01 VA: 0x2442C00 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2442C70 Offset: 0x2442D71 VA: 0x2442C70 Slot: 19
	public override BasicMenu.Result BCall() { }
}

