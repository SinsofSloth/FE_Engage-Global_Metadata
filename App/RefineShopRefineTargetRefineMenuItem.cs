// Namespace: App
public class RefineShopRefineTargetRefineMenuItem : RefineShopRefineTargetBaseMenuItem // TypeDefIndex: 11161
{
	// Fields
	private UnitItem m_RefinedUnitItem; // 0x90
	private int m_RefineLevel; // 0x98
	private ItemRefineData m_RefineData; // 0xA0
	private RefineShopRefineTargetMenu.SelectEventHandler m_SelectEventHandler; // 0xA8
	private RefineShopRefineTargetMenu.DecideToRefineEventHandler m_DecideEventHandler; // 0xB0

	// Properties
	public override UnitItem m_TargetUnitItem { get; set; }

	// Methods

	// RVA: 0x2523960 Offset: 0x2523A61 VA: 0x2523960 Slot: 27
	public override UnitItem get_m_TargetUnitItem() { }

	// RVA: 0x2523970 Offset: 0x2523A71 VA: 0x2523970 Slot: 28
	protected override void set_m_TargetUnitItem(UnitItem value) { }

	// RVA: 0x2523980 Offset: 0x2523A81 VA: 0x2523980
	public void .ctor(UnitItem unitItem, int refineLevel, ItemRefineData refineData, RefineShopRefineTargetMenu.SelectEventHandler selectEventHandler, RefineShopRefineTargetMenu.DecideToRefineEventHandler decideEventHandler) { }

	// RVA: 0x2523BA0 Offset: 0x2523CA1 VA: 0x2523BA0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2523BF0 Offset: 0x2523CF1 VA: 0x2523BF0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

