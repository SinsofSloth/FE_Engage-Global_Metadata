// Namespace: App
public class RefineShopExchangeSourceMenu : BasicMenu // TypeDefIndex: 11136
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296AE0 Offset: 0x296BE1 VA: 0x296AE0
	private ItemRefineExchangeData <m_TargetMaterialData>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x296AF0 Offset: 0x296BF1 VA: 0x296AF0
	private ItemRefineExchangeData <m_SourceMaterialData>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x296B00 Offset: 0x296C01 VA: 0x296B00
	private int <m_TargetMaterialRate>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x296B10 Offset: 0x296C11 VA: 0x296B10
	private int <m_SourceMaterialRate>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x296B20 Offset: 0x296C21 VA: 0x296B20
	private bool <m_EnoughSourceCount>k__BackingField; // 0xE0
	private string m_TargetMaterialId; // 0xE8
	private string m_SourceMaterialId; // 0xF0
	private MaterialMenuItem.SelectEventHandler m_SelectEventHandler; // 0xF8
	private RefineShopExchangeSourceMenu.CloseEventHandler m_CloseEventHandler; // 0x100

	// Properties
	public ItemRefineExchangeData m_TargetMaterialData { get; set; }
	public ItemRefineExchangeData m_SourceMaterialData { get; set; }
	public int m_TargetMaterialRate { get; set; }
	public int m_SourceMaterialRate { get; set; }
	public bool m_EnoughSourceCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C37E0 Offset: 0x2C38E1 VA: 0x2C37E0
	// RVA: 0x2C6A530 Offset: 0x2C6A631 VA: 0x2C6A530
	public ItemRefineExchangeData get_m_TargetMaterialData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C37F0 Offset: 0x2C38F1 VA: 0x2C37F0
	// RVA: 0x2C6A540 Offset: 0x2C6A641 VA: 0x2C6A540
	private void set_m_TargetMaterialData(ItemRefineExchangeData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3800 Offset: 0x2C3901 VA: 0x2C3800
	// RVA: 0x2C6A550 Offset: 0x2C6A651 VA: 0x2C6A550
	public ItemRefineExchangeData get_m_SourceMaterialData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3810 Offset: 0x2C3911 VA: 0x2C3810
	// RVA: 0x2C6A560 Offset: 0x2C6A661 VA: 0x2C6A560
	private void set_m_SourceMaterialData(ItemRefineExchangeData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3820 Offset: 0x2C3921 VA: 0x2C3820
	// RVA: 0x2C6A570 Offset: 0x2C6A671 VA: 0x2C6A570
	public int get_m_TargetMaterialRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3830 Offset: 0x2C3931 VA: 0x2C3830
	// RVA: 0x2C6A580 Offset: 0x2C6A681 VA: 0x2C6A580
	private void set_m_TargetMaterialRate(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3840 Offset: 0x2C3941 VA: 0x2C3840
	// RVA: 0x2C6A590 Offset: 0x2C6A691 VA: 0x2C6A590
	public int get_m_SourceMaterialRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3850 Offset: 0x2C3951 VA: 0x2C3850
	// RVA: 0x2C6A5A0 Offset: 0x2C6A6A1 VA: 0x2C6A5A0
	private void set_m_SourceMaterialRate(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3860 Offset: 0x2C3961 VA: 0x2C3860
	// RVA: 0x2C6A5B0 Offset: 0x2C6A6B1 VA: 0x2C6A5B0
	public bool get_m_EnoughSourceCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3870 Offset: 0x2C3971 VA: 0x2C3870
	// RVA: 0x2C6A5C0 Offset: 0x2C6A6C1 VA: 0x2C6A5C0
	private void set_m_EnoughSourceCount(bool value) { }

	// RVA: 0x2C68F20 Offset: 0x2C69021 VA: 0x2C68F20
	public static RefineShopExchangeSourceMenu CreateBind(ProcInst super, RefineShopExchangeSourceMenuContent menuContent, string targetMaterialId, string initialSourceMaterialId, MaterialMenuItem.SelectEventHandler selectEventHandler, MaterialMenuItem.DecideEventHandler decideEventHandler, RefineShopExchangeSourceMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C6A660 Offset: 0x2C6A761 VA: 0x2C6A660
	private void .ctor(List<BasicMenuItem> menuItemList, RefineShopExchangeSourceMenuContent menuContent, string targetMaterialId, int initialSelectIndex, MaterialMenuItem.SelectEventHandler selectEventHandler, RefineShopExchangeSourceMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C6AA10 Offset: 0x2C6AB11 VA: 0x2C6AA10 Slot: 30
	public override string GetName() { }

	// RVA: 0x2C6AA60 Offset: 0x2C6AB61 VA: 0x2C6AA60
	public void OnSelectMenuItem(string materialId) { }

	// RVA: 0x2C6AA90 Offset: 0x2C6AB91 VA: 0x2C6AA90 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2C6AAB0 Offset: 0x2C6ABB1 VA: 0x2C6AAB0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2C6A710 Offset: 0x2C6A811 VA: 0x2C6A710
	private void CalcRate() { }
}

