// Namespace: App
public class RefineShopRefineTargetEvolveMenuItem : RefineShopRefineTargetBaseMenuItem // TypeDefIndex: 11162
{
	// Fields
	private UnitItem m_EvolvedUnitItem; // 0x90
	private int m_EvolveIndex; // 0x98
	private ItemEvolveData m_EvolveData; // 0xA0
	private RefineShopRefineTargetMenu.SelectEventHandler m_SelectEventHandler; // 0xA8
	private RefineShopRefineTargetMenu.DecideToEvolveEventHandler m_DecideEventHandler; // 0xB0

	// Properties
	public override UnitItem m_TargetUnitItem { get; set; }

	// Methods

	// RVA: 0x2C70D70 Offset: 0x2C70E71 VA: 0x2C70D70 Slot: 27
	public override UnitItem get_m_TargetUnitItem() { }

	// RVA: 0x2C70D80 Offset: 0x2C70E81 VA: 0x2C70D80 Slot: 28
	protected override void set_m_TargetUnitItem(UnitItem value) { }

	// RVA: 0x2C70D90 Offset: 0x2C70E91 VA: 0x2C70D90
	public void .ctor(UnitItem unitItem, int evolveIndex, ItemEvolveData evolveData, RefineShopRefineTargetMenu.SelectEventHandler selectEventHandler, RefineShopRefineTargetMenu.DecideToEvolveEventHandler decideEventHandler) { }

	// RVA: 0x2C70FB0 Offset: 0x2C710B1 VA: 0x2C70FB0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2C71000 Offset: 0x2C71101 VA: 0x2C71000 Slot: 18
	public override BasicMenu.Result ACall() { }
}

