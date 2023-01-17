// Namespace: App
public class StructData<T> : StructTemplate<T> // TypeDefIndex: 13980
{
	// Fields
	protected static StructList<T> s_list; // 0x0
	private static bool s_loaded; // 0x0

	// Properties
	public static string[] PublicNames { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void AddPublicLabel(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8E10 Offset: 0x36C8F11 VA: 0x36C8E10
	|-StructData<object>.AddPublicLabel
	*/

	// RVA: -1 Offset: -1
	public static string[] get_PublicNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C9150 Offset: 0x36C9251 VA: 0x36C9150
	|-StructData<object>.get_PublicNames
	*/

	// RVA: -1 Offset: -1
	protected static void Import(byte[] data, string path, string sheetName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C92E0 Offset: 0x36C93E1 VA: 0x36C92E0
	|-StructData<object>.Import
	*/

	// RVA: -1 Offset: -1
	protected static void Load(string path, string sheetName, Action completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C9CC0 Offset: 0x36C9DC1 VA: 0x36C9CC0
	|-StructData<AccessoryData>.Load
	|-StructData<AchieveData>.Load
	|-StructData<AmiiboData>.Load
	|-StructData<AnimSetDB>.Load
	|-StructData<AnimalData>.Load
	|-StructData<AssetTable>.Load
	|-StructData<BattleStyle>.Load
	|-StructData<BelongData>.Load
	|-StructData<CalculatorData>.Load
	|-StructData<CalculatorTableAdd1D>.Load
	|-StructData<CalculatorTableSub1D>.Load
	|-StructData<ChallengeData>.Load
	|-StructData<ChapterData>.Load
	|-StructData<ChartGodData>.Load
	|-StructData<CookData>.Load
	|-StructData<DragonRidePresetParamData>.Load
	|-StructData<DragonRidePrizeData>.Load
	|-StructData<EffectData>.Load
	|-StructData<EffectSequence>.Load
	|-StructData<EncountJobData>.Load
	|-StructData<EndRollData>.Load
	|-StructData<ExpTable>.Load
	|-StructData<FishingAssistData>.Load
	|-StructData<FishingDisposPatternData>.Load
	|-StructData<FishingFishData>.Load
	|-StructData<FishingRadicalParamData>.Load
	|-StructData<FishingSizeTableData>.Load
	|-StructData<FishingTargetListData>.Load
	|-StructData<FoodData>.Load
	|-StructData<FoodstuffData>.Load
	|-StructData<FriendListData>.Load
	|-StructData<GameParam>.Load
	|-StructData<GiftData>.Load
	|-StructData<GodData>.Load
	|-StructData<GodLevelData>.Load
	|-StructData<GroundAttribute>.Load
	|-StructData<HubAreaData>.Load
	|-StructData<HubDemoData>.Load
	|-StructData<HubFacilityData>.Load
	|-StructData<HubFortuneTellingData>.Load
	|-StructData<HubMapIconData>.Load
	|-StructData<HubMaterialBonus>.Load
	|-StructData<HubMyRoomData>.Load
	|-StructData<HubNationData>.Load
	|-StructData<HubResourceData>.Load
	|-StructData<HubTalkData>.Load
	|-StructData<HubTalkFacilityData>.Load
	|-StructData<HubTalkRelative>.Load
	|-StructData<InteractData>.Load
	|-StructData<ItemData>.Load
	|-StructData<ItemRefineExchangeData>.Load
	|-StructData<JobData>.Load
	|-StructData<JukeboxData>.Load
	|-StructData<MapEditorCategoryData>.Load
	|-StructData<MapEditorObjectData>.Load
	|-StructData<MapHistoryData>.Load
	|-StructData<MascotAccData>.Load
	|-StructData<MascotColorData>.Load
	|-StructData<MascotFoodData>.Load
	|-StructData<MascotParamData>.Load
	|-StructData<MovieDefineData>.Load
	|-StructData<MuscleAssistData>.Load
	|-StructData<MuscleExercisePrizeData>.Load
	|-StructData<MuscleExerciseScoreData>.Load
	|-StructData<MusclePushUpAreaData>.Load
	|-StructData<MusclePushUpSpeedData>.Load
	|-StructData<MuscleSitUpFallData>.Load
	|-StructData<MuscleSquatJudgeAreaData>.Load
	|-StructData<MuscleSquatScoreListData>.Load
	|-StructData<MusicData>.Load
	|-StructData<NameTypeData>.Load
	|-StructData<object>.Load
	|-StructData<PersonData>.Load
	|-StructData<PhotographSpotData>.Load
	|-StructData<ProfileCardBgData>.Load
	|-StructData<ProfileCardCharacterStampData>.Load
	|-StructData<ProfileCardCommentData>.Load
	|-StructData<ProfileCardDefaultCommentData>.Load
	|-StructData<ProfileCardFavoriteCharacterData>.Load
	|-StructData<ProfileCardFavoriteMapData>.Load
	|-StructData<ProfileCardFrameData>.Load
	|-StructData<ProfileCardStampData>.Load
	|-StructData<ProfileCardTextColorData>.Load
	|-StructData<ProfileCardTextDecoData>.Load
	|-StructData<ProfileCardThemeOfEditMapData>.Load
	|-StructData<ProfileCardTitleData>.Load
	|-StructData<RelayAwardData>.Load
	|-StructData<RelayData>.Load
	|-StructData<RelayStampData>.Load
	|-StructData<RelianceData>.Load
	|-StructData<RelianceExpData>.Load
	|-StructData<RingData>.Load
	|-StructData<SkillData>.Load
	|-StructData<TasteConditionData>.Load
	|-StructData<TasteData>.Load
	|-StructData<TemplateOneData>.Load
	|-StructData<TerrainCostData>.Load
	|-StructData<TerrainData>.Load
	|-StructData<TipsData>.Load
	|-StructData<VersusRewardData>.Load
	|-StructData<VibrationDefineData>.Load
	|-StructData<TitleSequence.PedestalData>.Load
	|-StructData<TitleSequence.ProcTitleCall.TitleCallData>.Load
	*/

	// RVA: -1 Offset: -1
	public static void Completed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA310 Offset: 0x36CA411 VA: 0x36CA310
	|-StructData<object>.Completed
	*/

	// RVA: -1 Offset: -1
	public static void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA520 Offset: 0x36CA621 VA: 0x36CA520
	|-StructData<EncountJobData>.Unload
	|-StructData<EndRollData>.Unload
	|-StructData<object>.Unload
	|-StructData<TitleSequence.PedestalData>.Unload
	|-StructData<TitleSequence.ProcTitleCall.TitleCallData>.Unload
	*/

	// RVA: -1 Offset: -1
	public static T Get(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA870 Offset: 0x36CA971 VA: 0x36CA870
	|-StructData<AccessoryData>.Get
	|-StructData<AmiiboData>.Get
	|-StructData<ChapterData>.Get
	|-StructData<CookData>.Get
	|-StructData<EffectData>.Get
	|-StructData<EffectSequence>.Get
	|-StructData<EncountJobData>.Get
	|-StructData<FishingAssistData>.Get
	|-StructData<FishingFishData>.Get
	|-StructData<FoodstuffData>.Get
	|-StructData<GodData>.Get
	|-StructData<HubAreaData>.Get
	|-StructData<HubFacilityData>.Get
	|-StructData<HubNationData>.Get
	|-StructData<HubTalkData>.Get
	|-StructData<ItemData>.Get
	|-StructData<ItemRefineExchangeData>.Get
	|-StructData<JobData>.Get
	|-StructData<MapEditorObjectData>.Get
	|-StructData<MascotParamData>.Get
	|-StructData<MovieDefineData>.Get
	|-StructData<MuscleAssistData>.Get
	|-StructData<MuscleExercisePrizeData>.Get
	|-StructData<MuscleSquatJudgeAreaData>.Get
	|-StructData<MuscleSquatScoreListData>.Get
	|-StructData<NameTypeData>.Get
	|-StructData<object>.Get
	|-StructData<PersonData>.Get
	|-StructData<RelayAwardData>.Get
	|-StructData<RelayData>.Get
	|-StructData<RingData>.Get
	|-StructData<SkillData>.Get
	|-StructData<TasteConditionData>.Get
	|-StructData<TasteData>.Get
	|-StructData<TerrainCostData>.Get
	|-StructData<TerrainData>.Get
	|-StructData<VersusRewardData>.Get
	*/

	// RVA: -1 Offset: -1
	public static T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA9D0 Offset: 0x36CAAD1 VA: 0x36CA9D0
	|-StructData<AccessoryData>.Get
	|-StructData<AchieveData>.Get
	|-StructData<AnimalData>.Get
	|-StructData<ChallengeData>.Get
	|-StructData<ChapterData>.Get
	|-StructData<ChartGodData>.Get
	|-StructData<EncountJobData>.Get
	|-StructData<FishingFishData>.Get
	|-StructData<FriendListData>.Get
	|-StructData<GodData>.Get
	|-StructData<GodLevelData>.Get
	|-StructData<HubAreaData>.Get
	|-StructData<HubFortuneTellingData>.Get
	|-StructData<HubMapIconData>.Get
	|-StructData<HubNationData>.Get
	|-StructData<HubResourceData>.Get
	|-StructData<HubTalkData>.Get
	|-StructData<InteractData>.Get
	|-StructData<ItemData>.Get
	|-StructData<ItemRefineExchangeData>.Get
	|-StructData<JobData>.Get
	|-StructData<JukeboxData>.Get
	|-StructData<MascotColorData>.Get
	|-StructData<MusicData>.Get
	|-StructData<object>.Get
	|-StructData<PersonData>.Get
	|-StructData<RingData>.Get
	|-StructData<SkillData>.Get
	|-StructData<TerrainCostData>.Get
	|-StructData<TerrainData>.Get
	*/

	// RVA: -1 Offset: -1
	public static T TryGet(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAB30 Offset: 0x36CAC31 VA: 0x36CAB30
	|-StructData<AccessoryData>.TryGet
	|-StructData<AchieveData>.TryGet
	|-StructData<AnimSetDB>.TryGet
	|-StructData<AssetTable>.TryGet
	|-StructData<BelongData>.TryGet
	|-StructData<CalculatorTableAdd1D>.TryGet
	|-StructData<CalculatorTableSub1D>.TryGet
	|-StructData<ChapterData>.TryGet
	|-StructData<DragonRidePrizeData>.TryGet
	|-StructData<EffectData>.TryGet
	|-StructData<EffectSequence>.TryGet
	|-StructData<ExpTable>.TryGet
	|-StructData<FishingFishData>.TryGet
	|-StructData<FishingRadicalParamData>.TryGet
	|-StructData<GameParam>.TryGet
	|-StructData<GiftData>.TryGet
	|-StructData<GodData>.TryGet
	|-StructData<GroundAttribute>.TryGet
	|-StructData<HubDemoData>.TryGet
	|-StructData<HubFacilityData>.TryGet
	|-StructData<HubMapIconData>.TryGet
	|-StructData<HubMaterialBonus>.TryGet
	|-StructData<HubMyRoomData>.TryGet
	|-StructData<HubNationData>.TryGet
	|-StructData<HubTalkData>.TryGet
	|-StructData<HubTalkFacilityData>.TryGet
	|-StructData<HubTalkRelative>.TryGet
	|-StructData<ItemData>.TryGet
	|-StructData<ItemRefineExchangeData>.TryGet
	|-StructData<JobData>.TryGet
	|-StructData<MapEditorCategoryData>.TryGet
	|-StructData<MapEditorObjectData>.TryGet
	|-StructData<MapHistoryData>.TryGet
	|-StructData<MascotFoodData>.TryGet
	|-StructData<MascotParamData>.TryGet
	|-StructData<object>.TryGet
	|-StructData<PersonData>.TryGet
	|-StructData<ProfileCardBgData>.TryGet
	|-StructData<ProfileCardCharacterStampData>.TryGet
	|-StructData<ProfileCardCommentData>.TryGet
	|-StructData<ProfileCardDefaultCommentData>.TryGet
	|-StructData<ProfileCardFavoriteCharacterData>.TryGet
	|-StructData<ProfileCardFrameData>.TryGet
	|-StructData<ProfileCardTextColorData>.TryGet
	|-StructData<ProfileCardTextDecoData>.TryGet
	|-StructData<RelayAwardData>.TryGet
	|-StructData<RelayData>.TryGet
	|-StructData<RingData>.TryGet
	|-StructData<SkillData>.TryGet
	|-StructData<TasteData>.TryGet
	|-StructData<TerrainData>.TryGet
	|-StructData<VibrationDefineData>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static T TryGet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAE50 Offset: 0x36CAF51 VA: 0x36CAE50
	|-StructData<AccessoryData>.TryGet
	|-StructData<AchieveData>.TryGet
	|-StructData<AnimalData>.TryGet
	|-StructData<BattleStyle>.TryGet
	|-StructData<ChallengeData>.TryGet
	|-StructData<FishingDisposPatternData>.TryGet
	|-StructData<FishingTargetListData>.TryGet
	|-StructData<GameParam>.TryGet
	|-StructData<HubAreaData>.TryGet
	|-StructData<ItemData>.TryGet
	|-StructData<ItemRefineExchangeData>.TryGet
	|-StructData<object>.TryGet
	|-StructData<PersonData>.TryGet
	|-StructData<ProfileCardBgData>.TryGet
	|-StructData<ProfileCardCharacterStampData>.TryGet
	|-StructData<ProfileCardCommentData>.TryGet
	|-StructData<ProfileCardFavoriteCharacterData>.TryGet
	|-StructData<ProfileCardFavoriteMapData>.TryGet
	|-StructData<ProfileCardFrameData>.TryGet
	|-StructData<ProfileCardStampData>.TryGet
	|-StructData<ProfileCardTextColorData>.TryGet
	|-StructData<ProfileCardTextDecoData>.TryGet
	|-StructData<ProfileCardThemeOfEditMapData>.TryGet
	|-StructData<ProfileCardTitleData>.TryGet
	|-StructData<RelianceData>.TryGet
	|-StructData<RelianceExpData>.TryGet
	|-StructData<RingData>.TryGet
	|-StructData<SkillData>.TryGet
	|-StructData<TerrainData>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static T TryGetFromHash(int hash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB160 Offset: 0x36CB261 VA: 0x36CB160
	|-StructData<ChapterData>.TryGetFromHash
	|-StructData<GodData>.TryGetFromHash
	|-StructData<object>.TryGetFromHash
	|-StructData<PersonData>.TryGetFromHash
	|-StructData<RingData>.TryGetFromHash
	|-StructData<SkillData>.TryGetFromHash
	|-StructData<TerrainData>.TryGetFromHash
	*/

	// RVA: -1 Offset: -1
	public static bool TryGet(string name, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB470 Offset: 0x36CB571 VA: 0x36CB470
	|-StructData<EffectData>.TryGet
	|-StructData<EffectSequence>.TryGet
	|-StructData<object>.TryGet
	|-StructData<PersonData>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static bool TryGet(int index, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB5F0 Offset: 0x36CB6F1 VA: 0x36CB5F0
	|-StructData<object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public static T UnsafeGet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB770 Offset: 0x36CB871 VA: 0x36CB770
	|-StructData<object>.UnsafeGet
	|-StructData<SkillData>.UnsafeGet
	*/

	// RVA: -1 Offset: -1
	public static int GetIndex(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB900 Offset: 0x36CBA01 VA: 0x36CB900
	|-StructData<ChapterData>.GetIndex
	|-StructData<ChartGodData>.GetIndex
	|-StructData<ItemData>.GetIndex
	|-StructData<JobData>.GetIndex
	|-StructData<object>.GetIndex
	|-StructData<PersonData>.GetIndex
	|-StructData<RelayAwardData>.GetIndex
	|-StructData<RingData>.GetIndex
	|-StructData<SkillData>.GetIndex
	|-StructData<TerrainCostData>.GetIndex
	|-StructData<TerrainData>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public static int TryGetIndex(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBA60 Offset: 0x36CBB61 VA: 0x36CBA60
	|-StructData<GameParam>.TryGetIndex
	|-StructData<object>.TryGetIndex
	|-StructData<RelianceData>.TryGetIndex
	|-StructData<TerrainData>.TryGetIndex
	*/

	// RVA: -1 Offset: -1
	public static int GetIndex(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBC20 Offset: 0x36CBD21 VA: 0x36CBC20
	|-StructData<ChapterData>.GetIndex
	|-StructData<GodData>.GetIndex
	|-StructData<object>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public static int GetCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBC40 Offset: 0x36CBD41 VA: 0x36CBC40
	|-StructData<AccessoryData>.GetCount
	|-StructData<AchieveData>.GetCount
	|-StructData<AnimalData>.GetCount
	|-StructData<ChallengeData>.GetCount
	|-StructData<ChapterData>.GetCount
	|-StructData<EncountJobData>.GetCount
	|-StructData<FishingDisposPatternData>.GetCount
	|-StructData<FishingFishData>.GetCount
	|-StructData<FishingTargetListData>.GetCount
	|-StructData<FriendListData>.GetCount
	|-StructData<GameParam>.GetCount
	|-StructData<GodLevelData>.GetCount
	|-StructData<HubAreaData>.GetCount
	|-StructData<HubFortuneTellingData>.GetCount
	|-StructData<HubMapIconData>.GetCount
	|-StructData<HubNationData>.GetCount
	|-StructData<HubResourceData>.GetCount
	|-StructData<HubTalkData>.GetCount
	|-StructData<ItemData>.GetCount
	|-StructData<ItemRefineExchangeData>.GetCount
	|-StructData<JobData>.GetCount
	|-StructData<JukeboxData>.GetCount
	|-StructData<MapEditorObjectData>.GetCount
	|-StructData<MusicData>.GetCount
	|-StructData<object>.GetCount
	|-StructData<PersonData>.GetCount
	|-StructData<ProfileCardBgData>.GetCount
	|-StructData<ProfileCardCharacterStampData>.GetCount
	|-StructData<ProfileCardCommentData>.GetCount
	|-StructData<ProfileCardFavoriteCharacterData>.GetCount
	|-StructData<ProfileCardFavoriteMapData>.GetCount
	|-StructData<ProfileCardFrameData>.GetCount
	|-StructData<ProfileCardStampData>.GetCount
	|-StructData<ProfileCardTextColorData>.GetCount
	|-StructData<ProfileCardTextDecoData>.GetCount
	|-StructData<ProfileCardThemeOfEditMapData>.GetCount
	|-StructData<ProfileCardTitleData>.GetCount
	|-StructData<RingData>.GetCount
	|-StructData<SkillData>.GetCount
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBDD0 Offset: 0x36CBED1 VA: 0x36CBDD0
	|-StructData<AccessoryData>.GetList
	|-StructData<AchieveData>.GetList
	|-StructData<AnimalData>.GetList
	|-StructData<AssetTable>.GetList
	|-StructData<ChallengeData>.GetList
	|-StructData<ChapterData>.GetList
	|-StructData<EffectData>.GetList
	|-StructData<EndRollData>.GetList
	|-StructData<FriendListData>.GetList
	|-StructData<GodData>.GetList
	|-StructData<HubFacilityData>.GetList
	|-StructData<HubNationData>.GetList
	|-StructData<ItemData>.GetList
	|-StructData<JobData>.GetList
	|-StructData<MascotAccData>.GetList
	|-StructData<MovieDefineData>.GetList
	|-StructData<MuscleExerciseScoreData>.GetList
	|-StructData<MusclePushUpAreaData>.GetList
	|-StructData<MusclePushUpSpeedData>.GetList
	|-StructData<MuscleSitUpFallData>.GetList
	|-StructData<object>.GetList
	|-StructData<PersonData>.GetList
	|-StructData<RelayStampData>.GetList
	|-StructData<RelianceData>.GetList
	|-StructData<RingData>.GetList
	|-StructData<SkillData>.GetList
	|-StructData<TasteData>.GetList
	|-StructData<TipsData>.GetList
	|-StructData<TitleSequence.PedestalData>.GetList
	|-StructData<TitleSequence.ProcTitleCall.TitleCallData>.GetList
	*/

	// RVA: -1 Offset: -1
	public static void ForEach(StructData.EachFuncVoid<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBF00 Offset: 0x36CC001 VA: 0x36CBF00
	|-StructData<AssetTable>.ForEach
	|-StructData<EncountJobData>.ForEach
	|-StructData<FoodData>.ForEach
	|-StructData<FoodstuffData>.ForEach
	|-StructData<GodData>.ForEach
	|-StructData<HubNationData>.ForEach
	|-StructData<MapEditorCategoryData>.ForEach
	|-StructData<MapEditorObjectData>.ForEach
	|-StructData<MascotAccData>.ForEach
	|-StructData<object>.ForEach
	|-StructData<PersonData>.ForEach
	|-StructData<PhotographSpotData>.ForEach
	|-StructData<ProfileCardThemeOfEditMapData>.ForEach
	|-StructData<RingData>.ForEach
	*/

	// RVA: -1 Offset: -1
	public static T ForEach(StructData.EachFuncBool<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC3B0 Offset: 0x36CC4B1 VA: 0x36CC3B0
	|-StructData<GodData>.ForEach
	|-StructData<object>.ForEach
	|-StructData<PersonData>.ForEach
	|-StructData<RelayStampData>.ForEach
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC9F0 Offset: 0x36CCAF1 VA: 0x36CC9F0
	|-StructData<AccessoryData>..ctor
	|-StructData<AchieveData>..ctor
	|-StructData<AmiiboData>..ctor
	|-StructData<AnimSetDB>..ctor
	|-StructData<AnimalData>..ctor
	|-StructData<AssetTable>..ctor
	|-StructData<BattleStyle>..ctor
	|-StructData<BelongData>..ctor
	|-StructData<CalculatorTableAdd1D>..ctor
	|-StructData<CalculatorTableSub1D>..ctor
	|-StructData<ChallengeData>..ctor
	|-StructData<ChapterData>..ctor
	|-StructData<ChartGodData>..ctor
	|-StructData<CookData>..ctor
	|-StructData<DragonRidePresetParamData>..ctor
	|-StructData<DragonRidePrizeData>..ctor
	|-StructData<EffectData>..ctor
	|-StructData<EffectSequence>..ctor
	|-StructData<EncountJobData>..ctor
	|-StructData<EndRollData>..ctor
	|-StructData<ExpTable>..ctor
	|-StructData<FishingAssistData>..ctor
	|-StructData<FishingDisposPatternData>..ctor
	|-StructData<FishingFishData>..ctor
	|-StructData<FishingRadicalParamData>..ctor
	|-StructData<FishingSizeTableData>..ctor
	|-StructData<FishingTargetListData>..ctor
	|-StructData<FoodData>..ctor
	|-StructData<FoodstuffData>..ctor
	|-StructData<FriendListData>..ctor
	|-StructData<GameParam>..ctor
	|-StructData<GiftData>..ctor
	|-StructData<GodData>..ctor
	|-StructData<GodLevelData>..ctor
	|-StructData<GroundAttribute>..ctor
	|-StructData<HubAreaData>..ctor
	|-StructData<HubDemoData>..ctor
	|-StructData<HubFacilityData>..ctor
	|-StructData<HubFortuneTellingData>..ctor
	|-StructData<HubMapIconData>..ctor
	|-StructData<HubMaterialBonus>..ctor
	|-StructData<HubMyRoomData>..ctor
	|-StructData<HubNationData>..ctor
	|-StructData<HubResourceData>..ctor
	|-StructData<HubTalkData>..ctor
	|-StructData<HubTalkFacilityData>..ctor
	|-StructData<HubTalkRelative>..ctor
	|-StructData<InteractData>..ctor
	|-StructData<ItemData>..ctor
	|-StructData<ItemRefineExchangeData>..ctor
	|-StructData<JobData>..ctor
	|-StructData<JukeboxData>..ctor
	|-StructData<MapEditorCategoryData>..ctor
	|-StructData<MapEditorObjectData>..ctor
	|-StructData<MapHistoryData>..ctor
	|-StructData<MascotAccData>..ctor
	|-StructData<MascotColorData>..ctor
	|-StructData<MascotFoodData>..ctor
	|-StructData<MascotParamData>..ctor
	|-StructData<MovieDefineData>..ctor
	|-StructData<MuscleAssistData>..ctor
	|-StructData<MuscleExercisePrizeData>..ctor
	|-StructData<MuscleExerciseScoreData>..ctor
	|-StructData<MusclePushUpAreaData>..ctor
	|-StructData<MusclePushUpSpeedData>..ctor
	|-StructData<MuscleSitUpFallData>..ctor
	|-StructData<MuscleSquatJudgeAreaData>..ctor
	|-StructData<MuscleSquatNotesData>..ctor
	|-StructData<MuscleSquatScoreListData>..ctor
	|-StructData<MusicData>..ctor
	|-StructData<NameTypeData>..ctor
	|-StructData<object>..ctor
	|-StructData<PersonData>..ctor
	|-StructData<PhotographSpotData>..ctor
	|-StructData<ProfileCardBgData>..ctor
	|-StructData<ProfileCardCharacterStampData>..ctor
	|-StructData<ProfileCardCommentData>..ctor
	|-StructData<ProfileCardDefaultCommentData>..ctor
	|-StructData<ProfileCardFavoriteCharacterData>..ctor
	|-StructData<ProfileCardFavoriteMapData>..ctor
	|-StructData<ProfileCardFrameData>..ctor
	|-StructData<ProfileCardStampData>..ctor
	|-StructData<ProfileCardTextColorData>..ctor
	|-StructData<ProfileCardTextDecoData>..ctor
	|-StructData<ProfileCardThemeOfEditMapData>..ctor
	|-StructData<ProfileCardTitleData>..ctor
	|-StructData<RelayAwardData>..ctor
	|-StructData<RelayData>..ctor
	|-StructData<RelayStampData>..ctor
	|-StructData<RelianceData>..ctor
	|-StructData<RelianceExpData>..ctor
	|-StructData<RingData>..ctor
	|-StructData<TasteConditionData>..ctor
	|-StructData<TasteData>..ctor
	|-StructData<TemplateOneData>..ctor
	|-StructData<TerrainCostData>..ctor
	|-StructData<TerrainData>..ctor
	|-StructData<TipsData>..ctor
	|-StructData<VersusRewardData>..ctor
	|-StructData<VibrationDefineData>..ctor
	|-StructData<TitleSequence.PedestalData>..ctor
	|-StructData<TitleSequence.ProcTitleCall.TitleCallData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CCAA0 Offset: 0x36CCBA1 VA: 0x36CCAA0
	|-StructData<object>..cctor
	*/
}

