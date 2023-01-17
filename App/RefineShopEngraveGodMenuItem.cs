// Namespace: App
public class RefineShopEngraveGodMenuItem : BasicMenuItem // TypeDefIndex: 11106
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296850 Offset: 0x296951 VA: 0x296850
	private GodData <m_GodData>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x296860 Offset: 0x296961 VA: 0x296860
	private UnitItem <m_BaseUnitItem>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296870 Offset: 0x296971 VA: 0x296870
	private bool <m_IsEnoughPieceOfBond>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296880 Offset: 0x296981 VA: 0x296880
	private int <m_NeededPieceOfBond>k__BackingField; // 0x7C
	private UnitItem m_EngravedUnitItem; // 0x80
	private RefineShopEngraveGodMenu.SelectEventHandler m_SelectEventHandler; // 0x88
	private RefineShopEngraveGodMenu.DecideEventHandler m_DecideEventHandler; // 0x90

	// Properties
	public GodData m_GodData { get; set; }
	public UnitItem m_BaseUnitItem { get; set; }
	public bool m_IsEnoughPieceOfBond { get; set; }
	public int m_NeededPieceOfBond { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3610 Offset: 0x2C3711 VA: 0x2C3610
	// RVA: 0x2C61D20 Offset: 0x2C61E21 VA: 0x2C61D20
	public GodData get_m_GodData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3620 Offset: 0x2C3721 VA: 0x2C3620
	// RVA: 0x2C61D30 Offset: 0x2C61E31 VA: 0x2C61D30
	private void set_m_GodData(GodData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3630 Offset: 0x2C3731 VA: 0x2C3630
	// RVA: 0x2C61D40 Offset: 0x2C61E41 VA: 0x2C61D40
	public UnitItem get_m_BaseUnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3640 Offset: 0x2C3741 VA: 0x2C3640
	// RVA: 0x2C61D50 Offset: 0x2C61E51 VA: 0x2C61D50
	private void set_m_BaseUnitItem(UnitItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3650 Offset: 0x2C3751 VA: 0x2C3650
	// RVA: 0x2C61D60 Offset: 0x2C61E61 VA: 0x2C61D60
	public bool get_m_IsEnoughPieceOfBond() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3660 Offset: 0x2C3761 VA: 0x2C3660
	// RVA: 0x2C61D70 Offset: 0x2C61E71 VA: 0x2C61D70
	private void set_m_IsEnoughPieceOfBond(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3670 Offset: 0x2C3771 VA: 0x2C3670
	// RVA: 0x2C61D80 Offset: 0x2C61E81 VA: 0x2C61D80
	public int get_m_NeededPieceOfBond() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3680 Offset: 0x2C3781 VA: 0x2C3680
	// RVA: 0x2C61D90 Offset: 0x2C61E91 VA: 0x2C61D90
	private void set_m_NeededPieceOfBond(int value) { }

	// RVA: 0x2C61790 Offset: 0x2C61891 VA: 0x2C61790
	public void .ctor(UnitItem baseUnitItem, GodData godData, RefineShopEngraveGodMenu.SelectEventHandler selectEventHandler, RefineShopEngraveGodMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2C61DA0 Offset: 0x2C61EA1 VA: 0x2C61DA0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2C61E70 Offset: 0x2C61F71 VA: 0x2C61E70 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2C61F20 Offset: 0x2C62021 VA: 0x2C61F20 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2C62030 Offset: 0x2C62131 VA: 0x2C62030 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2C61F30 Offset: 0x2C62031 VA: 0x2C61F30
	public void SetInitialColor() { }

	// RVA: 0x2C62040 Offset: 0x2C62141 VA: 0x2C62040 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2C62090 Offset: 0x2C62191 VA: 0x2C62090 Slot: 18
	public override BasicMenu.Result ACall() { }
}

