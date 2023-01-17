// Namespace: App
public class RefineShopExchangeCountMenu : BasicMenu // TypeDefIndex: 11122
{
	// Fields
	public static readonly int ValueMin; // 0x0
	public static int SourceValueMin; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x296890 Offset: 0x296991 VA: 0x296890
	private ItemRefineExchangeData <m_SourceMaterialData>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x2968A0 Offset: 0x2969A1 VA: 0x2968A0
	private ItemRefineExchangeData <m_TargetMaterialData>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x2968B0 Offset: 0x2969B1 VA: 0x2968B0
	private int <m_SourceMaterialValue>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x2968C0 Offset: 0x2969C1 VA: 0x2968C0
	private int <m_TargetMaterialValue>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x2968D0 Offset: 0x2969D1 VA: 0x2968D0
	private int <m_TargetMaterialValueExpect>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x2968E0 Offset: 0x2969E1 VA: 0x2968E0
	private int <m_TargetMaterialOverflow>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x2968F0 Offset: 0x2969F1 VA: 0x2968F0
	private bool <m_SourceMaterialValueEnable>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x296900 Offset: 0x296A01 VA: 0x296900
	private bool <m_TargetMaterialValueEnable>k__BackingField; // 0xE9
	[CompilerGeneratedAttribute] // RVA: 0x296910 Offset: 0x296A11 VA: 0x296910
	private bool <m_ValuableSourceThanTarget>k__BackingField; // 0xEA
	private int m_Times; // 0xEC
	private bool m_Min; // 0xF0
	private bool m_Max; // 0xF1
	private RefineShopExchangeCountMenu.CloseEventHandler m_CloseEventHandler; // 0xF8

	// Properties
	public ItemRefineExchangeData m_SourceMaterialData { get; set; }
	public ItemRefineExchangeData m_TargetMaterialData { get; set; }
	public int m_SourceMaterialValue { get; set; }
	public int m_TargetMaterialValue { get; set; }
	public int m_TargetMaterialValueExpect { get; set; }
	public int m_TargetMaterialOverflow { get; set; }
	public bool m_SourceMaterialValueEnable { get; set; }
	public bool m_TargetMaterialValueEnable { get; set; }
	public bool m_ValuableSourceThanTarget { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3690 Offset: 0x2C3791 VA: 0x2C3690
	// RVA: 0x2C65790 Offset: 0x2C65891 VA: 0x2C65790
	public ItemRefineExchangeData get_m_SourceMaterialData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C36A0 Offset: 0x2C37A1 VA: 0x2C36A0
	// RVA: 0x2C657A0 Offset: 0x2C658A1 VA: 0x2C657A0
	private void set_m_SourceMaterialData(ItemRefineExchangeData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C36B0 Offset: 0x2C37B1 VA: 0x2C36B0
	// RVA: 0x2C657B0 Offset: 0x2C658B1 VA: 0x2C657B0
	public ItemRefineExchangeData get_m_TargetMaterialData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C36C0 Offset: 0x2C37C1 VA: 0x2C36C0
	// RVA: 0x2C657C0 Offset: 0x2C658C1 VA: 0x2C657C0
	private void set_m_TargetMaterialData(ItemRefineExchangeData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C36D0 Offset: 0x2C37D1 VA: 0x2C36D0
	// RVA: 0x2C657D0 Offset: 0x2C658D1 VA: 0x2C657D0
	public int get_m_SourceMaterialValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C36E0 Offset: 0x2C37E1 VA: 0x2C36E0
	// RVA: 0x2C657E0 Offset: 0x2C658E1 VA: 0x2C657E0
	private void set_m_SourceMaterialValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C36F0 Offset: 0x2C37F1 VA: 0x2C36F0
	// RVA: 0x2C657F0 Offset: 0x2C658F1 VA: 0x2C657F0
	public int get_m_TargetMaterialValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3700 Offset: 0x2C3801 VA: 0x2C3700
	// RVA: 0x2C65800 Offset: 0x2C65901 VA: 0x2C65800
	private void set_m_TargetMaterialValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3710 Offset: 0x2C3811 VA: 0x2C3710
	// RVA: 0x2C65810 Offset: 0x2C65911 VA: 0x2C65810
	public int get_m_TargetMaterialValueExpect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3720 Offset: 0x2C3821 VA: 0x2C3720
	// RVA: 0x2C65820 Offset: 0x2C65921 VA: 0x2C65820
	private void set_m_TargetMaterialValueExpect(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3730 Offset: 0x2C3831 VA: 0x2C3730
	// RVA: 0x2C65830 Offset: 0x2C65931 VA: 0x2C65830
	public int get_m_TargetMaterialOverflow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3740 Offset: 0x2C3841 VA: 0x2C3740
	// RVA: 0x2C65840 Offset: 0x2C65941 VA: 0x2C65840
	private void set_m_TargetMaterialOverflow(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3750 Offset: 0x2C3851 VA: 0x2C3750
	// RVA: 0x2C65850 Offset: 0x2C65951 VA: 0x2C65850
	public bool get_m_SourceMaterialValueEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3760 Offset: 0x2C3861 VA: 0x2C3760
	// RVA: 0x2C65860 Offset: 0x2C65961 VA: 0x2C65860
	private void set_m_SourceMaterialValueEnable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3770 Offset: 0x2C3871 VA: 0x2C3770
	// RVA: 0x2C65870 Offset: 0x2C65971 VA: 0x2C65870
	public bool get_m_TargetMaterialValueEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3780 Offset: 0x2C3881 VA: 0x2C3780
	// RVA: 0x2C65880 Offset: 0x2C65981 VA: 0x2C65880
	private void set_m_TargetMaterialValueEnable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3790 Offset: 0x2C3891 VA: 0x2C3790
	// RVA: 0x2C65890 Offset: 0x2C65991 VA: 0x2C65890
	public bool get_m_ValuableSourceThanTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C37A0 Offset: 0x2C38A1 VA: 0x2C37A0
	// RVA: 0x2C658A0 Offset: 0x2C659A1 VA: 0x2C658A0
	private void set_m_ValuableSourceThanTarget(bool value) { }

	// RVA: 0x2C658B0 Offset: 0x2C659B1 VA: 0x2C658B0
	public static RefineShopExchangeCountMenu CreateBind(ProcInst super, RefineShopExchangeCountMenuContent menuContent, ItemRefineExchangeData sourceMaterialData, ItemRefineExchangeData targetMaterialData, RefineShopExchangeCountMenuItem.SelectEventHandler selectEventHandler, RefineShopExchangeCountMenuItem.DecideEventHandler decideEventHandler, RefineShopExchangeCountMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C65B20 Offset: 0x2C65C21 VA: 0x2C65B20
	private void .ctor(List<BasicMenuItem> menuItemList, RefineShopExchangeCountMenuContent menuContent, ItemRefineExchangeData sourceMaterialData, ItemRefineExchangeData targetMaterialData, RefineShopExchangeCountMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C660E0 Offset: 0x2C661E1 VA: 0x2C660E0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2C66130 Offset: 0x2C66231 VA: 0x2C66130
	public void ResetValues() { }

	// RVA: 0x2C665B0 Offset: 0x2C666B1 VA: 0x2C665B0 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2C665C0 Offset: 0x2C666C1 VA: 0x2C665C0 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2C665D0 Offset: 0x2C666D1 VA: 0x2C665D0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2C667D0 Offset: 0x2C668D1 VA: 0x2C667D0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2C669D0 Offset: 0x2C66AD1 VA: 0x2C669D0 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2C66E40 Offset: 0x2C66F41 VA: 0x2C66E40 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2C66E60 Offset: 0x2C66F61 VA: 0x2C66E60 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2C65D40 Offset: 0x2C65E41 VA: 0x2C65D40
	private bool CalcValue(int valueDiff) { }

	// RVA: 0x2C66F30 Offset: 0x2C67031 VA: 0x2C66F30
	private static void .cctor() { }
}

