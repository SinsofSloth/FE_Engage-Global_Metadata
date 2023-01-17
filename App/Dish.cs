// Namespace: App
public class Dish // TypeDefIndex: 13519
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C3C0 Offset: 0x29C4C1 VA: 0x29C3C0
	private UnitEnhanceValues <Enhance>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29C3D0 Offset: 0x29C4D1 VA: 0x29C3D0
	private UnitEnhanceValues <BonusEnhance>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29C3E0 Offset: 0x29C4E1 VA: 0x29C3E0
	private UnitEnhanceValues <TotalBonusEnhance>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29C3F0 Offset: 0x29C4F1 VA: 0x29C3F0
	private bool <RaiseReliance>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29C400 Offset: 0x29C501 VA: 0x29C400
	private TasteData <Taste>k__BackingField; // 0x30
	private TasteConditionData.ConditionFunc m_Func; // 0x38
	private string m_MakeBentoIid; // 0x40
	private FoodData m_FoodData; // 0x48

	// Properties
	public string Name { get; }
	public UnitEnhanceValues Enhance { get; set; }
	public UnitEnhanceValues BonusEnhance { get; set; }
	public UnitEnhanceValues TotalBonusEnhance { get; set; }
	public bool RaiseReliance { get; set; }
	public TasteData Taste { get; set; }
	public FoodData Food { get; }

	// Methods

	// RVA: 0x2376A50 Offset: 0x2376B51 VA: 0x2376A50
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD30 Offset: 0x2CBE31 VA: 0x2CBD30
	// RVA: 0x2376AB0 Offset: 0x2376BB1 VA: 0x2376AB0
	public UnitEnhanceValues get_Enhance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD40 Offset: 0x2CBE41 VA: 0x2CBD40
	// RVA: 0x2376AC0 Offset: 0x2376BC1 VA: 0x2376AC0
	private void set_Enhance(UnitEnhanceValues value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD50 Offset: 0x2CBE51 VA: 0x2CBD50
	// RVA: 0x2376AD0 Offset: 0x2376BD1 VA: 0x2376AD0
	public UnitEnhanceValues get_BonusEnhance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD60 Offset: 0x2CBE61 VA: 0x2CBD60
	// RVA: 0x2376AE0 Offset: 0x2376BE1 VA: 0x2376AE0
	private void set_BonusEnhance(UnitEnhanceValues value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD70 Offset: 0x2CBE71 VA: 0x2CBD70
	// RVA: 0x2376AF0 Offset: 0x2376BF1 VA: 0x2376AF0
	public UnitEnhanceValues get_TotalBonusEnhance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD80 Offset: 0x2CBE81 VA: 0x2CBD80
	// RVA: 0x2376B00 Offset: 0x2376C01 VA: 0x2376B00
	private void set_TotalBonusEnhance(UnitEnhanceValues value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD90 Offset: 0x2CBE91 VA: 0x2CBD90
	// RVA: 0x2376B10 Offset: 0x2376C11 VA: 0x2376B10
	public bool get_RaiseReliance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBDA0 Offset: 0x2CBEA1 VA: 0x2CBDA0
	// RVA: 0x2376B20 Offset: 0x2376C21 VA: 0x2376B20
	private void set_RaiseReliance(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBDB0 Offset: 0x2CBEB1 VA: 0x2CBDB0
	// RVA: 0x2376B30 Offset: 0x2376C31 VA: 0x2376B30
	public TasteData get_Taste() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBDC0 Offset: 0x2CBEC1 VA: 0x2CBDC0
	// RVA: 0x2376B40 Offset: 0x2376C41 VA: 0x2376B40
	private void set_Taste(TasteData value) { }

	// RVA: 0x2376B50 Offset: 0x2376C51 VA: 0x2376B50
	public void .ctor(Unit unit, FoodData foodData, TasteData tasteData, bool raiseReliance = False) { }

	// RVA: 0x2377610 Offset: 0x2377711 VA: 0x2377610
	public FoodData get_Food() { }

	// RVA: 0x2376AA0 Offset: 0x2376BA1 VA: 0x2376AA0
	public string GetFoodName() { }

	// RVA: 0x2377620 Offset: 0x2377721 VA: 0x2377620
	public void ApplyEnhance(Unit unit) { }

	// RVA: 0x2377680 Offset: 0x2377781 VA: 0x2377680
	public Dish.RelianceResult ApplyReliance(Unit heroUnit, Unit unitA, Unit unitB, Cooking.ConversationType type) { }

	// RVA: 0x2377AD0 Offset: 0x2377BD1 VA: 0x2377AD0
	public int CalculateRelianceRiseValue(Unit unitA, Unit unitB, Cooking.ConversationType type) { }

	// RVA: 0x2377D50 Offset: 0x2377E51 VA: 0x2377D50
	public UnitItem MakeBento() { }

	// RVA: 0x2376C60 Offset: 0x2376D61 VA: 0x2376C60
	private void SetEnhance(FoodData foodData, TasteData tasteData) { }

	// RVA: 0x2377E30 Offset: 0x2377F31 VA: 0x2377E30
	private UnitEnhanceValues CalculateEnhance(CapabilitySbyte enhance, TasteData tasteData) { }

	// RVA: 0x2377C10 Offset: 0x2377D11 VA: 0x2377C10
	public Dish.Liking GetLiking(Unit unit) { }

	// RVA: 0x2378460 Offset: 0x2378561 VA: 0x2378460
	public string GetCondDescription() { }

	// RVA: 0x2378530 Offset: 0x2378631 VA: 0x2378530
	public Cooking.ConversationType GetConversationType(Unit unitA, Unit unitB, FoodstuffData[] foodstuffs, StringBuilder builder) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBDD0 Offset: 0x2CBED1 VA: 0x2CBDD0
	// RVA: 0x2377BF0 Offset: 0x2377CF1 VA: 0x2377BF0
	internal static Dish.RelianceResult.TryResult <ApplyReliance>g__SetTryResult|31_0(bool isAdded, UnitRelianceData reliance) { }
}

