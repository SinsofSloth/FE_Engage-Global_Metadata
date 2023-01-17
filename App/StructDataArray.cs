// Namespace: App
public class StructDataArray<T> : StructTemplate<T> // TypeDefIndex: 13981
{
	// Fields
	private static StructArrayList<T> s_arrayList; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x29CD70 Offset: 0x29CE71 VA: 0x29CD70
	private string <ArrayName>k__BackingField; // 0x0
	private static bool s_loaded; // 0x0

	// Properties
	public string ArrayName { get; set; }
	public static StructArrayList<T> ArrayList { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDC00 Offset: 0x2CDD01 VA: 0x2CDC00
	// RVA: -1 Offset: -1
	public string get_ArrayName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5910 Offset: 0x36C5A11 VA: 0x36C5910
	|-StructDataArray<AIData>.get_ArrayName
	|-StructDataArray<CalculatorTableAdd2D>.get_ArrayName
	|-StructDataArray<CalculatorTableSub2D>.get_ArrayName
	|-StructDataArray<DisposData>.get_ArrayName
	|-StructDataArray<EncountEquipData>.get_ArrayName
	|-StructDataArray<ItemEvolveData>.get_ArrayName
	|-StructDataArray<object>.get_ArrayName
	|-StructDataArray<PhotographPauseData>.get_ArrayName
	|-StructDataArray<SupportData>.get_ArrayName
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CDC10 Offset: 0x2CDD11 VA: 0x2CDC10
	// RVA: -1 Offset: -1
	public void set_ArrayName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5920 Offset: 0x36C5A21 VA: 0x36C5920
	|-StructDataArray<object>.set_ArrayName
	*/

	// RVA: -1 Offset: -1
	public static StructArrayList<T> get_ArrayList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5930 Offset: 0x36C5A31 VA: 0x36C5930
	|-StructDataArray<JobIntroData>.get_ArrayList
	|-StructDataArray<object>.get_ArrayList
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override string GetDebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5A60 Offset: 0x36C5B61 VA: 0x36C5A60
	|-StructDataArray<AccessoryShopData>.GetDebugName
	|-StructDataArray<ArenaData>.GetDebugName
	|-StructDataArray<CalculatorTableAdd2D>.GetDebugName
	|-StructDataArray<CalculatorTableSub2D>.GetDebugName
	|-StructDataArray<DisposData>.GetDebugName
	|-StructDataArray<DragonRideTargetPatternData>.GetDebugName
	|-StructDataArray<FleaMarketData>.GetDebugName
	|-StructDataArray<GodWeaponRefineData>.GetDebugName
	|-StructDataArray<HubInvestmentAnimal>.GetDebugName
	|-StructDataArray<HubInvestmentBonusAnimal>.GetDebugName
	|-StructDataArray<HubInvestmentBonusFood>.GetDebugName
	|-StructDataArray<HubInvestmentBonusItem>.GetDebugName
	|-StructDataArray<HubInvestmentFoodstuff>.GetDebugName
	|-StructDataArray<HubInvestmentLevel>.GetDebugName
	|-StructDataArray<ItemShopData>.GetDebugName
	|-StructDataArray<JobIntroData>.GetDebugName
	|-StructDataArray<KeyHelpData>.GetDebugName
	|-StructDataArray<LaterTalkData>.GetDebugName
	|-StructDataArray<MuscleSquatScorePatternData>.GetDebugName
	|-StructDataArray<object>.GetDebugName
	|-StructDataArray<PhotographPauseData>.GetDebugName
	|-StructDataArray<RangeData>.GetDebugName
	|-StructDataArray<ShopData>.GetDebugName
	|-StructDataArray<TutorialData>.GetDebugName
	|-StructDataArray<WeaponShopData>.GetDebugName
	*/

	// RVA: -1 Offset: -1
	protected static void Load(string path, string sheetName, Action completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5A80 Offset: 0x36C5B81 VA: 0x36C5A80
	|-StructDataArray<AIData>.Load
	|-StructDataArray<AccessoryShopData>.Load
	|-StructDataArray<ArenaData>.Load
	|-StructDataArray<CalculatorTableAdd2D>.Load
	|-StructDataArray<CalculatorTableSub2D>.Load
	|-StructDataArray<ChartData>.Load
	|-StructDataArray<ChartVariableData>.Load
	|-StructDataArray<DisposData>.Load
	|-StructDataArray<DragonRideTargetPatternData>.Load
	|-StructDataArray<EncountEquipData>.Load
	|-StructDataArray<EncountRareMonayData>.Load
	|-StructDataArray<EncountWeaponCategoryData>.Load
	|-StructDataArray<EventData>.Load
	|-StructDataArray<FleaMarketData>.Load
	|-StructDataArray<GodGrowthData>.Load
	|-StructDataArray<GodWeaponRefineData>.Load
	|-StructDataArray<HubDisposData>.Load
	|-StructDataArray<HubInvestmentAnimal>.Load
	|-StructDataArray<HubInvestmentBonusAnimal>.Load
	|-StructDataArray<HubInvestmentBonusFood>.Load
	|-StructDataArray<HubInvestmentBonusItem>.Load
	|-StructDataArray<HubInvestmentFoodstuff>.Load
	|-StructDataArray<HubInvestmentLevel>.Load
	|-StructDataArray<HubMoveData>.Load
	|-StructDataArray<HubRandomSet>.Load
	|-StructDataArray<ItemEvolveData>.Load
	|-StructDataArray<ItemRefineData>.Load
	|-StructDataArray<ItemShopData>.Load
	|-StructDataArray<JobIntroData>.Load
	|-StructDataArray<KeyHelpData>.Load
	|-StructDataArray<KillBonusData>.Load
	|-StructDataArray<KilledBonusData>.Load
	|-StructDataArray<LaterTalkData>.Load
	|-StructDataArray<MuscleSquatScorePatternData>.Load
	|-StructDataArray<object>.Load
	|-StructDataArray<PhotographPauseData>.Load
	|-StructDataArray<RangeData>.Load
	|-StructDataArray<RelayCompletionAwardData>.Load
	|-StructDataArray<RewardData>.Load
	|-StructDataArray<RingCleaningVoiceData>.Load
	|-StructDataArray<SupportData>.Load
	|-StructDataArray<TemplateArrayData>.Load
	|-StructDataArray<TutorialData>.Load
	|-StructDataArray<WeaponShopData>.Load
	*/

	// RVA: -1 Offset: -1
	protected static void Import(byte[] data, string path, string sheetName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C60D0 Offset: 0x36C61D1 VA: 0x36C60D0
	|-StructDataArray<object>.Import
	*/

	// RVA: -1 Offset: -1
	protected static void Intermediate(XmlReader reader, List<StructProperty> propertys, string arrayIdent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C67F0 Offset: 0x36C68F1 VA: 0x36C67F0
	|-StructDataArray<object>.Intermediate
	*/

	// RVA: -1 Offset: -1
	private static void AddArrayList(StructDataArrayList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C6FC0 Offset: 0x36C70C1 VA: 0x36C6FC0
	|-StructDataArray<object>.AddArrayList
	*/

	// RVA: -1 Offset: -1
	public static void Completed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C73E0 Offset: 0x36C74E1 VA: 0x36C73E0
	|-StructDataArray<object>.Completed
	*/

	// RVA: -1 Offset: -1
	public static void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C75F0 Offset: 0x36C76F1 VA: 0x36C75F0
	|-StructDataArray<DisposData>.Unload
	|-StructDataArray<EncountEquipData>.Unload
	|-StructDataArray<EncountRareMonayData>.Unload
	|-StructDataArray<EncountWeaponCategoryData>.Unload
	|-StructDataArray<EventData>.Unload
	|-StructDataArray<JobIntroData>.Unload
	|-StructDataArray<LaterTalkData>.Unload
	|-StructDataArray<object>.Unload
	|-StructDataArray<RingCleaningVoiceData>.Unload
	*/

	// RVA: -1 Offset: -1
	public static StructDataArrayList<T> Get(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C7A70 Offset: 0x36C7B71 VA: 0x36C7A70
	|-StructDataArray<DisposData>.Get
	|-StructDataArray<EncountEquipData>.Get
	|-StructDataArray<EncountRareMonayData>.Get
	|-StructDataArray<EncountWeaponCategoryData>.Get
	|-StructDataArray<HubInvestmentAnimal>.Get
	|-StructDataArray<HubInvestmentBonusAnimal>.Get
	|-StructDataArray<HubInvestmentBonusFood>.Get
	|-StructDataArray<HubInvestmentBonusItem>.Get
	|-StructDataArray<HubInvestmentFoodstuff>.Get
	|-StructDataArray<HubInvestmentLevel>.Get
	|-StructDataArray<KeyHelpData>.Get
	|-StructDataArray<object>.Get
	|-StructDataArray<PhotographPauseData>.Get
	|-StructDataArray<TutorialData>.Get
	*/

	// RVA: -1 Offset: -1
	public static StructDataArrayList<T> Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C7BD0 Offset: 0x36C7CD1 VA: 0x36C7BD0
	|-StructDataArray<EncountEquipData>.Get
	|-StructDataArray<GodGrowthData>.Get
	|-StructDataArray<HubDisposData>.Get
	|-StructDataArray<object>.Get
	|-StructDataArray<RangeData>.Get
	|-StructDataArray<TutorialData>.Get
	*/

	// RVA: -1 Offset: -1
	public static StructDataArrayList<T> TryGet(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C7D30 Offset: 0x36C7E31 VA: 0x36C7D30
	|-StructDataArray<AIData>.TryGet
	|-StructDataArray<DisposData>.TryGet
	|-StructDataArray<DragonRideTargetPatternData>.TryGet
	|-StructDataArray<GodGrowthData>.TryGet
	|-StructDataArray<GodWeaponRefineData>.TryGet
	|-StructDataArray<HubDisposData>.TryGet
	|-StructDataArray<HubInvestmentLevel>.TryGet
	|-StructDataArray<HubMoveData>.TryGet
	|-StructDataArray<HubRandomSet>.TryGet
	|-StructDataArray<ItemEvolveData>.TryGet
	|-StructDataArray<ItemRefineData>.TryGet
	|-StructDataArray<KeyHelpData>.TryGet
	|-StructDataArray<LaterTalkData>.TryGet
	|-StructDataArray<MuscleSquatScorePatternData>.TryGet
	|-StructDataArray<object>.TryGet
	|-StructDataArray<RelayCompletionAwardData>.TryGet
	|-StructDataArray<RewardData>.TryGet
	|-StructDataArray<RingCleaningVoiceData>.TryGet
	|-StructDataArray<ShopData>.TryGet
	|-StructDataArray<SupportData>.TryGet
	|-StructDataArray<TutorialData>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static StructDataArrayList<T> TryGet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8040 Offset: 0x36C8141 VA: 0x36C8040
	|-StructDataArray<AccessoryShopData>.TryGet
	|-StructDataArray<object>.TryGet
	|-StructDataArray<ShopData>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static StructDataArrayList<T> TryGetFromHash(int hash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8350 Offset: 0x36C8451 VA: 0x36C8350
	|-StructDataArray<object>.TryGetFromHash
	*/

	// RVA: -1 Offset: -1
	public static int GetIndex(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8660 Offset: 0x36C8761 VA: 0x36C8660
	|-StructDataArray<AIData>.GetIndex
	|-StructDataArray<ChartVariableData>.GetIndex
	|-StructDataArray<object>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public static string GetKey(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C87F0 Offset: 0x36C88F1 VA: 0x36C87F0
	|-StructDataArray<AIData>.GetKey
	|-StructDataArray<AccessoryShopData>.GetKey
	|-StructDataArray<DisposData>.GetKey
	|-StructDataArray<HubDisposData>.GetKey
	|-StructDataArray<ItemEvolveData>.GetKey
	|-StructDataArray<ItemRefineData>.GetKey
	|-StructDataArray<object>.GetKey
	|-StructDataArray<ShopData>.GetKey
	*/

	// RVA: -1 Offset: -1
	public static int GetCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8980 Offset: 0x36C8A81 VA: 0x36C8980
	|-StructDataArray<AccessoryShopData>.GetCount
	|-StructDataArray<DisposData>.GetCount
	|-StructDataArray<GodGrowthData>.GetCount
	|-StructDataArray<HubDisposData>.GetCount
	|-StructDataArray<ItemEvolveData>.GetCount
	|-StructDataArray<object>.GetCount
	|-StructDataArray<RangeData>.GetCount
	|-StructDataArray<ShopData>.GetCount
	|-StructDataArray<TutorialData>.GetCount
	*/

	// RVA: -1 Offset: -1
	public static StructArrayList<T> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8B10 Offset: 0x36C8C11 VA: 0x36C8B10
	|-StructDataArray<ChartVariableData>.GetList
	|-StructDataArray<DragonRideTargetPatternData>.GetList
	|-StructDataArray<EncountEquipData>.GetList
	|-StructDataArray<ItemEvolveData>.GetList
	|-StructDataArray<JobIntroData>.GetList
	|-StructDataArray<KillBonusData>.GetList
	|-StructDataArray<KilledBonusData>.GetList
	|-StructDataArray<LaterTalkData>.GetList
	|-StructDataArray<object>.GetList
	|-StructDataArray<TutorialData>.GetList
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8C40 Offset: 0x36C8D41 VA: 0x36C8C40
	|-StructDataArray<AIData>..ctor
	|-StructDataArray<AccessoryShopData>..ctor
	|-StructDataArray<ArenaData>..ctor
	|-StructDataArray<ChartData>..ctor
	|-StructDataArray<ChartVariableData>..ctor
	|-StructDataArray<DisposData>..ctor
	|-StructDataArray<DragonRideTargetPatternData>..ctor
	|-StructDataArray<EncountEquipData>..ctor
	|-StructDataArray<EncountRareMonayData>..ctor
	|-StructDataArray<EncountWeaponCategoryData>..ctor
	|-StructDataArray<EventData>..ctor
	|-StructDataArray<GodGrowthData>..ctor
	|-StructDataArray<GodWeaponRefineData>..ctor
	|-StructDataArray<HubDisposData>..ctor
	|-StructDataArray<HubInvestmentAnimal>..ctor
	|-StructDataArray<HubInvestmentBonusAnimal>..ctor
	|-StructDataArray<HubInvestmentBonusFood>..ctor
	|-StructDataArray<HubInvestmentBonusItem>..ctor
	|-StructDataArray<HubInvestmentFoodstuff>..ctor
	|-StructDataArray<HubInvestmentLevel>..ctor
	|-StructDataArray<HubMoveData>..ctor
	|-StructDataArray<HubRandomSet>..ctor
	|-StructDataArray<ItemEvolveData>..ctor
	|-StructDataArray<ItemRefineData>..ctor
	|-StructDataArray<JobIntroData>..ctor
	|-StructDataArray<KeyHelpData>..ctor
	|-StructDataArray<KillBonusData>..ctor
	|-StructDataArray<KilledBonusData>..ctor
	|-StructDataArray<LaterTalkData>..ctor
	|-StructDataArray<MuscleSquatScorePatternData>..ctor
	|-StructDataArray<object>..ctor
	|-StructDataArray<PhotographPauseData>..ctor
	|-StructDataArray<RangeData>..ctor
	|-StructDataArray<RelayCompletionAwardData>..ctor
	|-StructDataArray<RewardData>..ctor
	|-StructDataArray<RingCleaningVoiceData>..ctor
	|-StructDataArray<ShopData>..ctor
	|-StructDataArray<SupportData>..ctor
	|-StructDataArray<TemplateArrayData>..ctor
	|-StructDataArray<TutorialData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8CF0 Offset: 0x36C8DF1 VA: 0x36C8CF0
	|-StructDataArray<object>..cctor
	*/
}

