// Namespace: App
public class HubUtil // TypeDefIndex: 10820
{
	// Fields
	private static HubParams s_HubParams; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2953E0 Offset: 0x2954E1 VA: 0x2953E0
	private static readonly string <EmptyWord>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x2953F0 Offset: 0x2954F1 VA: 0x2953F0
	private static bool <IsFirstEntry>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x295400 Offset: 0x295501 VA: 0x295400
	private static string <LastScenarioChapter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x295410 Offset: 0x295511 VA: 0x295410
	private static bool <IsConditionMorning>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x295420 Offset: 0x295521 VA: 0x295420
	private static bool <IsConditionDay>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x295430 Offset: 0x295531 VA: 0x295430
	private static bool <IsConditionEvening>k__BackingField; // 0x22
	[CompilerGeneratedAttribute] // RVA: 0x295440 Offset: 0x295541 VA: 0x295440
	private static bool <IsConditionNight>k__BackingField; // 0x23
	[CompilerGeneratedAttribute] // RVA: 0x295450 Offset: 0x295551 VA: 0x295450
	private static bool <IsConditionWeaponOpened>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x295460 Offset: 0x295561 VA: 0x295460
	private static bool <IsConditionItemOpened>k__BackingField; // 0x25
	[CompilerGeneratedAttribute] // RVA: 0x295470 Offset: 0x295571 VA: 0x295470
	private static bool <IsConditionRefinementOpened>k__BackingField; // 0x26
	[CompilerGeneratedAttribute] // RVA: 0x295480 Offset: 0x295581 VA: 0x295480
	private static bool <IsConditionAccessoryOpened>k__BackingField; // 0x27
	[CompilerGeneratedAttribute] // RVA: 0x295490 Offset: 0x295591 VA: 0x295490
	private static bool <IsConditionTent1>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2954A0 Offset: 0x2955A1 VA: 0x2954A0
	private static bool <IsConditionTent2>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x2954B0 Offset: 0x2955B1 VA: 0x2954B0
	private static bool <IsConditionTent3>k__BackingField; // 0x2A
	[CompilerGeneratedAttribute] // RVA: 0x2954C0 Offset: 0x2955C1 VA: 0x2954C0
	private static bool <IsConditionFire>k__BackingField; // 0x2B
	[CompilerGeneratedAttribute] // RVA: 0x2954D0 Offset: 0x2955D1 VA: 0x2954D0
	private static bool <IsConditionFortuneHutOpened>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x2954E0 Offset: 0x2955E1 VA: 0x2954E0
	private static bool <IsConditionFleaMarket>k__BackingField; // 0x2D
	[CompilerGeneratedAttribute] // RVA: 0x2954F0 Offset: 0x2955F1 VA: 0x2954F0
	private static bool <IsConditionStatue>k__BackingField; // 0x2E
	[CompilerGeneratedAttribute] // RVA: 0x295500 Offset: 0x295601 VA: 0x295500
	private static bool <IsConditionRefineGodWeaponOpened>k__BackingField; // 0x2F
	[CompilerGeneratedAttribute] // RVA: 0x295510 Offset: 0x295611 VA: 0x295510
	private static bool <IsConditionMuscleHardOpened>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x295520 Offset: 0x295621 VA: 0x295520
	private static bool <IsConditionMuscleMasterAndEndlessOpened>k__BackingField; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x295530 Offset: 0x295631 VA: 0x295530
	private static bool <IsConditionDragonRideHardOpened>k__BackingField; // 0x32
	[CompilerGeneratedAttribute] // RVA: 0x295540 Offset: 0x295641 VA: 0x295540
	private static bool <IsConditionDragonRideExpertOpened>k__BackingField; // 0x33
	[CompilerGeneratedAttribute] // RVA: 0x295550 Offset: 0x295651 VA: 0x295550
	private static bool <IsConditionPoolCircleSwim>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x295560 Offset: 0x295661 VA: 0x295560
	private static string <CurrentCookingPid>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x295570 Offset: 0x295671 VA: 0x295570
	private static int <DragonRideLevel>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x295580 Offset: 0x295681 VA: 0x295580
	private static bool <IsDragonRideTimeTest>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x295590 Offset: 0x295691 VA: 0x295590
	private static bool <IsDragonRideWalkThrough>k__BackingField; // 0x45
	[CompilerGeneratedAttribute] // RVA: 0x2955A0 Offset: 0x2956A1 VA: 0x2955A0
	private static int <DragonRideTotalScore>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x2955B0 Offset: 0x2956B1 VA: 0x2955B0
	private static int <DragonRideNormalTargetCount>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x2955C0 Offset: 0x2956C1 VA: 0x2955C0
	private static int <DragonRideBigTargetCount>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x2955D0 Offset: 0x2956D1 VA: 0x2955D0
	private static int <DragonRideLinkTargetCount>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x2955E0 Offset: 0x2956E1 VA: 0x2955E0
	private static int <DragonRideSpecialTargetCount>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x2955F0 Offset: 0x2956F1 VA: 0x2955F0
	private static int <DragonRideRouletteTargetCount>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x295600 Offset: 0x295701 VA: 0x295600
	private static int <DragonRideAssistScore>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x295610 Offset: 0x295711 VA: 0x295610
	private static int <DragonRidePlayRankNum>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x295620 Offset: 0x295721 VA: 0x295620
	private static bool <DragonRideRetireFlag>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x295630 Offset: 0x295731 VA: 0x295630
	private static DragonRidePresetParamData.CourseData[] <DragonRideWalkThroughList>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x295640 Offset: 0x295741 VA: 0x295640
	private static string <DragonRideUsingPresetID>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x295650 Offset: 0x295751 VA: 0x295650
	private static float <DragonRideTargetSuicideSec>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x295660 Offset: 0x295761 VA: 0x295660
	private static float <DragonRideTargetSuicideSecRandomRange>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x295670 Offset: 0x295771 VA: 0x295670
	private static int <DragonRideAssistLevel>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x295680 Offset: 0x295781 VA: 0x295680
	private static bool <DebugDragonRideAssistSet>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x295690 Offset: 0x295791 VA: 0x295690
	private static bool <IsDragonRideResultCheck>k__BackingField; // 0x8D
	[CompilerGeneratedAttribute] // RVA: 0x2956A0 Offset: 0x2957A1 VA: 0x2956A0
	private static bool <IsDragonRideResultCheck_Assist>k__BackingField; // 0x8E
	[CompilerGeneratedAttribute] // RVA: 0x2956B0 Offset: 0x2957B1 VA: 0x2956B0
	private static bool <IsDragonRideResultCheck_HighScore>k__BackingField; // 0x8F
	[CompilerGeneratedAttribute] // RVA: 0x2956C0 Offset: 0x2957C1 VA: 0x2956C0
	private static int <FishingLureType>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x2956D0 Offset: 0x2957D1 VA: 0x2956D0
	private static string <FishingGetFishID>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x2956E0 Offset: 0x2957E1 VA: 0x2956E0
	private static float <FishingGetFishSize>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x2956F0 Offset: 0x2957F1 VA: 0x2956F0
	private static bool <IsPlayMuscleExercise>k__BackingField; // 0xA4

	// Properties
	private static HubParams Params { get; }
	public static float PadThreshold { get; }
	public static float PlayerMaxSpeed { get; }
	public static float PlayerAccel { get; }
	public static float PlayerDecel { get; }
	public static float PlayerRotateSpeedRate { get; }
	public static float PlayerDashStopTime { get; }
	public static float PlayerDashSpeedIntensity { get; }
	public static float SpringGravityY { get; }
	public static float MinLookAtDist { get; }
	public static float MaxLookAtDist { get; }
	public static float PadAllowance { get; }
	public static float OthersBodyWeight { get; }
	public static float OthersHeadWeight { get; }
	public static string EmptyWord { get; }
	private static int EncountMaterialBase { get; }
	public static bool IsFirstEntry { get; set; }
	public static string LastScenarioChapter { get; set; }
	public static bool IsConditionMorning { get; set; }
	public static bool IsConditionDay { get; set; }
	public static bool IsConditionEvening { get; set; }
	public static bool IsConditionNight { get; set; }
	public static bool IsConditionWeaponOpened { get; set; }
	public static bool IsConditionItemOpened { get; set; }
	public static bool IsConditionRefinementOpened { get; set; }
	public static bool IsConditionAccessoryOpened { get; set; }
	public static bool IsConditionTent1 { get; set; }
	public static bool IsConditionTent2 { get; set; }
	public static bool IsConditionTent3 { get; set; }
	public static bool IsConditionFire { get; set; }
	public static bool IsConditionFortuneHutOpened { get; set; }
	public static bool IsConditionFleaMarket { get; set; }
	public static bool IsConditionStatue { get; set; }
	public static bool IsConditionRefineGodWeaponOpened { get; set; }
	public static bool IsConditionMuscleHardOpened { get; set; }
	public static bool IsConditionMuscleMasterAndEndlessOpened { get; set; }
	public static bool IsConditionDragonRideHardOpened { get; set; }
	public static bool IsConditionDragonRideExpertOpened { get; set; }
	public static bool IsConditionPoolCircleSwim { get; set; }
	public static string CurrentCookingPid { get; set; }
	public static int PersonLimitCount { get; }
	public static int GodPersonLimitCount { get; }
	public static int AnimalLimitCount { get; }
	public static int KizunaPersonLimitCount { get; }
	public static int DragonRideLevel { get; set; }
	public static bool IsDragonRideTimeTest { get; set; }
	public static bool IsDragonRideWalkThrough { get; set; }
	public static int DragonRideTotalScore { get; set; }
	public static int DragonRideNormalTargetCount { get; set; }
	public static int DragonRideBigTargetCount { get; set; }
	public static int DragonRideLinkTargetCount { get; set; }
	public static int DragonRideSpecialTargetCount { get; set; }
	public static int DragonRideRouletteTargetCount { get; set; }
	public static int DragonRideAssistScore { get; set; }
	public static int DragonRidePlayRankNum { get; set; }
	public static bool DragonRideRetireFlag { get; set; }
	public static DragonRidePresetParamData.CourseData[] DragonRideWalkThroughList { get; set; }
	public static string DragonRideUsingPresetID { get; set; }
	public static float DragonRideTargetSuicideSec { get; set; }
	public static float DragonRideTargetSuicideSecRandomRange { get; set; }
	public static int DragonRideAssistLevel { get; set; }
	public static bool DebugDragonRideAssistSet { get; set; }
	public static bool IsDragonRideResultCheck { get; set; }
	public static bool IsDragonRideResultCheck_Assist { get; set; }
	public static bool IsDragonRideResultCheck_HighScore { get; set; }
	public static int FishingLureType { get; set; }
	public static string FishingGetFishID { get; set; }
	public static float FishingGetFishSize { get; set; }
	public static bool IsPlayMuscleExercise { get; set; }

	// Methods

	// RVA: 0x2D4A120 Offset: 0x2D4A221 VA: 0x2D4A120
	private static HubParams get_Params() { }

	// RVA: 0x2D4A290 Offset: 0x2D4A391 VA: 0x2D4A290
	public static bool IsParamsValid() { }

	// RVA: 0x2D4A330 Offset: 0x2D4A431 VA: 0x2D4A330
	public static int GetUnitDisplayNum() { }

	// RVA: 0x2D4A390 Offset: 0x2D4A491 VA: 0x2D4A390
	public static float get_PadThreshold() { }

	// RVA: 0x2D4A3F0 Offset: 0x2D4A4F1 VA: 0x2D4A3F0
	public static float get_PlayerMaxSpeed() { }

	// RVA: 0x2D4A450 Offset: 0x2D4A551 VA: 0x2D4A450
	public static float get_PlayerAccel() { }

	// RVA: 0x2D4A4B0 Offset: 0x2D4A5B1 VA: 0x2D4A4B0
	public static float get_PlayerDecel() { }

	// RVA: 0x2D4A510 Offset: 0x2D4A611 VA: 0x2D4A510
	public static float get_PlayerRotateSpeedRate() { }

	// RVA: 0x2D4A570 Offset: 0x2D4A671 VA: 0x2D4A570
	public static float get_PlayerDashStopTime() { }

	// RVA: 0x2D4A5D0 Offset: 0x2D4A6D1 VA: 0x2D4A5D0
	public static float get_PlayerDashSpeedIntensity() { }

	// RVA: 0x2D4A630 Offset: 0x2D4A731 VA: 0x2D4A630
	public static float get_SpringGravityY() { }

	// RVA: 0x2D4A690 Offset: 0x2D4A791 VA: 0x2D4A690
	public static float GetPlayerSpeedCurve(float magnitude) { }

	// RVA: 0x2D4A0C0 Offset: 0x2D4A1C1 VA: 0x2D4A0C0
	public static AnimationCurve GetTurnCurve() { }

	// RVA: 0x2D4A710 Offset: 0x2D4A811 VA: 0x2D4A710
	public static float get_MinLookAtDist() { }

	// RVA: 0x2D4A770 Offset: 0x2D4A871 VA: 0x2D4A770
	public static float get_MaxLookAtDist() { }

	// RVA: 0x2D4A7D0 Offset: 0x2D4A8D1 VA: 0x2D4A7D0
	public static float get_PadAllowance() { }

	// RVA: 0x2D4A830 Offset: 0x2D4A931 VA: 0x2D4A830
	public static float get_OthersBodyWeight() { }

	// RVA: 0x2D4A890 Offset: 0x2D4A991 VA: 0x2D4A890
	public static float get_OthersHeadWeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1AE0 Offset: 0x2C1BE1 VA: 0x2C1AE0
	// RVA: 0x2D4A8F0 Offset: 0x2D4A9F1 VA: 0x2D4A8F0
	public static string get_EmptyWord() { }

	// RVA: 0x2D4A960 Offset: 0x2D4AA61 VA: 0x2D4A960
	public static CharacterAppearance GetCharacterAppearance(string pid, string accessory = "") { }

	// RVA: 0x2D4AE60 Offset: 0x2D4AF61 VA: 0x2D4AE60
	public static CharacterAppearance GetPlayerAppearance(string pid) { }

	// RVA: 0x2D49D60 Offset: 0x2D49E61 VA: 0x2D49D60
	public static HubLookAtController CreateLookAt(GameObject gameObject, bool disabledParam = False) { }

	// RVA: 0x2D4AFE0 Offset: 0x2D4B0E1 VA: 0x2D4AFE0
	public static bool IsMain() { }

	// RVA: 0x2D4B0A0 Offset: 0x2D4B1A1 VA: 0x2D4B0A0
	public static bool IsHubSequence() { }

	// RVA: 0x2D46990 Offset: 0x2D46A91 VA: 0x2D46990
	public static bool IsPlayerFemale() { }

	// RVA: 0x2D4B160 Offset: 0x2D4B261 VA: 0x2D4B160
	public static bool IsComplete(string cid) { }

	// RVA: 0x2D4B2E0 Offset: 0x2D4B3E1 VA: 0x2D4B2E0
	public static string PIDToGID(string pid) { }

	// RVA: 0x2D4B350 Offset: 0x2D4B451 VA: 0x2D4B350
	public static string GIDToPID(string gid) { }

	// RVA: 0x2D4B3C0 Offset: 0x2D4B4C1 VA: 0x2D4B3C0
	public static Unit TryGetSortieUnit(string pid) { }

	// RVA: 0x2D4B420 Offset: 0x2D4B521 VA: 0x2D4B420
	public static bool IsSortieUnit(string pid) { }

	// RVA: 0x2D48E70 Offset: 0x2D48F71 VA: 0x2D48E70
	public static bool IsBestReliance(string pid) { }

	// RVA: 0x2D4B4D0 Offset: 0x2D4B5D1 VA: 0x2D4B4D0
	public static int GetNowYear() { }

	// RVA: 0x2D4B5A0 Offset: 0x2D4B6A1 VA: 0x2D4B5A0
	public static ValueTuple<int, int> GetNowDay() { }

	// RVA: 0x2D4B6B0 Offset: 0x2D4B7B1 VA: 0x2D4B6B0
	public static bool IsBirthday(string pid) { }

	// RVA: 0x2D4B7B0 Offset: 0x2D4B8B1 VA: 0x2D4B7B0
	public static bool IsHeroBirthday() { }

	// RVA: 0x2D4B850 Offset: 0x2D4B951 VA: 0x2D4B850
	public static bool IsBirthdayPresentGot(string pid) { }

	// RVA: 0x2D4B990 Offset: 0x2D4BA91 VA: 0x2D4B990
	public static bool CanPromiseEngage(Unit unit) { }

	// RVA: 0x2D4BBF0 Offset: 0x2D4BCF1 VA: 0x2D4BBF0
	public static bool IsAvaliableDispos(HubDisposData data, HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x2D4C200 Offset: 0x2D4C301 VA: 0x2D4C200
	public static void LevelUpReliance(Unit a, Unit b, RelianceData.Level level) { }

	// RVA: 0x2D4C2E0 Offset: 0x2D4C3E1 VA: 0x2D4C2E0
	public static string GetRelianceSuffixLetter(RelianceData.Level level) { }

	// RVA: 0x2D4C380 Offset: 0x2D4C481 VA: 0x2D4C380
	public static bool CanAnyRelianceLevelUp() { }

	// RVA: 0x2D4C480 Offset: 0x2D4C581 VA: 0x2D4C480
	public static bool CanAnyGodLevelUp() { }

	// RVA: 0x2D4C7A0 Offset: 0x2D4C8A1 VA: 0x2D4C7A0
	public static bool CanAnyRelianceLevelUp(string pid, bool withoutAPlus = False) { }

	// RVA: 0x2D4CF30 Offset: 0x2D4D031 VA: 0x2D4CF30
	public static bool CanAnyRelianceLevelUpPlayer(string pid, bool withoutAPlus = False) { }

	// RVA: 0x2D4D260 Offset: 0x2D4D361 VA: 0x2D4D260
	public static string GetAPlusAsciiName() { }

	// RVA: 0x2D4D2E0 Offset: 0x2D4D3E1 VA: 0x2D4D2E0
	public static int ContinuousSortieCount(string pid) { }

	// RVA: 0x2D4D320 Offset: 0x2D4D421 VA: 0x2D4D320
	public static bool IsExistsMID(string label) { }

	// RVA: 0x2D4D400 Offset: 0x2D4D501 VA: 0x2D4D400
	public static bool HasStoryTalk(string pid) { }

	// RVA: 0x2D4D710 Offset: 0x2D4D811 VA: 0x2D4D710
	public static bool HasSwimsuit(string pid) { }

	// RVA: 0x2D4D7F0 Offset: 0x2D4D8F1 VA: 0x2D4D7F0
	public static AccessoryData GetSwimsuit() { }

	// RVA: 0x2D4D9D0 Offset: 0x2D4DAD1 VA: 0x2D4D9D0
	public static AnimalData GetAnimal(string locator) { }

	// RVA: 0x2D4DE50 Offset: 0x2D4DF51 VA: 0x2D4DE50
	public static bool IsCaptureAnimal(AnimalData animal) { }

	// RVA: 0x2D4DF00 Offset: 0x2D4E001 VA: 0x2D4DF00
	public static int GetAnimalCaptureNum(AnimalData animal) { }

	// RVA: 0x2D4DFF0 Offset: 0x2D4E0F1 VA: 0x2D4DFF0
	public static void SetAnimalCaptureNum(AnimalData animal, int num) { }

	// RVA: 0x2D4E1D0 Offset: 0x2D4E2D1 VA: 0x2D4E1D0
	public static void IncAnimalCaptureNum(AnimalData animal, int num = 1) { }

	// RVA: 0x2D4E250 Offset: 0x2D4E351 VA: 0x2D4E250
	private static int get_EncountMaterialBase() { }

	// RVA: 0x2D4E390 Offset: 0x2D4E491 VA: 0x2D4E390
	public static int GetEncountMaterialItemCount() { }

	// RVA: 0x2D4E550 Offset: 0x2D4E651 VA: 0x2D4E550
	public static int GetItemCountWithBonus(ItemData item, int baseCount) { }

	// RVA: 0x2D4E710 Offset: 0x2D4E811 VA: 0x2D4E710
	public static void UpdateLocate(string pid) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1AF0 Offset: 0x2C1BF1 VA: 0x2C1AF0
	// RVA: 0x2D4E820 Offset: 0x2D4E921 VA: 0x2D4E820
	public static bool get_IsFirstEntry() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B00 Offset: 0x2C1C01 VA: 0x2C1B00
	// RVA: 0x2D4E890 Offset: 0x2D4E991 VA: 0x2D4E890
	private static void set_IsFirstEntry(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B10 Offset: 0x2C1C11 VA: 0x2C1B10
	// RVA: 0x2D4E910 Offset: 0x2D4EA11 VA: 0x2D4E910
	public static string get_LastScenarioChapter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B20 Offset: 0x2C1C21 VA: 0x2C1B20
	// RVA: 0x2D4E980 Offset: 0x2D4EA81 VA: 0x2D4E980
	private static void set_LastScenarioChapter(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B30 Offset: 0x2C1C31 VA: 0x2C1B30
	// RVA: 0x2D4EA00 Offset: 0x2D4EB01 VA: 0x2D4EA00
	public static bool get_IsConditionMorning() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B40 Offset: 0x2C1C41 VA: 0x2C1B40
	// RVA: 0x2D4EA70 Offset: 0x2D4EB71 VA: 0x2D4EA70
	private static void set_IsConditionMorning(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B50 Offset: 0x2C1C51 VA: 0x2C1B50
	// RVA: 0x2D4EAF0 Offset: 0x2D4EBF1 VA: 0x2D4EAF0
	public static bool get_IsConditionDay() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B60 Offset: 0x2C1C61 VA: 0x2C1B60
	// RVA: 0x2D4EB60 Offset: 0x2D4EC61 VA: 0x2D4EB60
	private static void set_IsConditionDay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B70 Offset: 0x2C1C71 VA: 0x2C1B70
	// RVA: 0x2D4EBE0 Offset: 0x2D4ECE1 VA: 0x2D4EBE0
	public static bool get_IsConditionEvening() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B80 Offset: 0x2C1C81 VA: 0x2C1B80
	// RVA: 0x2D4EC50 Offset: 0x2D4ED51 VA: 0x2D4EC50
	private static void set_IsConditionEvening(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1B90 Offset: 0x2C1C91 VA: 0x2C1B90
	// RVA: 0x2D4ECD0 Offset: 0x2D4EDD1 VA: 0x2D4ECD0
	public static bool get_IsConditionNight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1BA0 Offset: 0x2C1CA1 VA: 0x2C1BA0
	// RVA: 0x2D4ED40 Offset: 0x2D4EE41 VA: 0x2D4ED40
	private static void set_IsConditionNight(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1BB0 Offset: 0x2C1CB1 VA: 0x2C1BB0
	// RVA: 0x2D4EDC0 Offset: 0x2D4EEC1 VA: 0x2D4EDC0
	public static bool get_IsConditionWeaponOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1BC0 Offset: 0x2C1CC1 VA: 0x2C1BC0
	// RVA: 0x2D4EE30 Offset: 0x2D4EF31 VA: 0x2D4EE30
	private static void set_IsConditionWeaponOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1BD0 Offset: 0x2C1CD1 VA: 0x2C1BD0
	// RVA: 0x2D4EEB0 Offset: 0x2D4EFB1 VA: 0x2D4EEB0
	public static bool get_IsConditionItemOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1BE0 Offset: 0x2C1CE1 VA: 0x2C1BE0
	// RVA: 0x2D4EF20 Offset: 0x2D4F021 VA: 0x2D4EF20
	private static void set_IsConditionItemOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1BF0 Offset: 0x2C1CF1 VA: 0x2C1BF0
	// RVA: 0x2D4EFA0 Offset: 0x2D4F0A1 VA: 0x2D4EFA0
	public static bool get_IsConditionRefinementOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C00 Offset: 0x2C1D01 VA: 0x2C1C00
	// RVA: 0x2D4F010 Offset: 0x2D4F111 VA: 0x2D4F010
	private static void set_IsConditionRefinementOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C10 Offset: 0x2C1D11 VA: 0x2C1C10
	// RVA: 0x2D4F090 Offset: 0x2D4F191 VA: 0x2D4F090
	public static bool get_IsConditionAccessoryOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C20 Offset: 0x2C1D21 VA: 0x2C1C20
	// RVA: 0x2D4F100 Offset: 0x2D4F201 VA: 0x2D4F100
	private static void set_IsConditionAccessoryOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C30 Offset: 0x2C1D31 VA: 0x2C1C30
	// RVA: 0x2D4F180 Offset: 0x2D4F281 VA: 0x2D4F180
	public static bool get_IsConditionTent1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C40 Offset: 0x2C1D41 VA: 0x2C1C40
	// RVA: 0x2D4F1F0 Offset: 0x2D4F2F1 VA: 0x2D4F1F0
	private static void set_IsConditionTent1(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C50 Offset: 0x2C1D51 VA: 0x2C1C50
	// RVA: 0x2D4F270 Offset: 0x2D4F371 VA: 0x2D4F270
	public static bool get_IsConditionTent2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C60 Offset: 0x2C1D61 VA: 0x2C1C60
	// RVA: 0x2D4F2E0 Offset: 0x2D4F3E1 VA: 0x2D4F2E0
	private static void set_IsConditionTent2(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C70 Offset: 0x2C1D71 VA: 0x2C1C70
	// RVA: 0x2D4F360 Offset: 0x2D4F461 VA: 0x2D4F360
	public static bool get_IsConditionTent3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C80 Offset: 0x2C1D81 VA: 0x2C1C80
	// RVA: 0x2D4F3D0 Offset: 0x2D4F4D1 VA: 0x2D4F3D0
	private static void set_IsConditionTent3(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1C90 Offset: 0x2C1D91 VA: 0x2C1C90
	// RVA: 0x2D4F450 Offset: 0x2D4F551 VA: 0x2D4F450
	public static bool get_IsConditionFire() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1CA0 Offset: 0x2C1DA1 VA: 0x2C1CA0
	// RVA: 0x2D4F4C0 Offset: 0x2D4F5C1 VA: 0x2D4F4C0
	private static void set_IsConditionFire(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1CB0 Offset: 0x2C1DB1 VA: 0x2C1CB0
	// RVA: 0x2D4F540 Offset: 0x2D4F641 VA: 0x2D4F540
	public static bool get_IsConditionFortuneHutOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1CC0 Offset: 0x2C1DC1 VA: 0x2C1CC0
	// RVA: 0x2D4F5B0 Offset: 0x2D4F6B1 VA: 0x2D4F5B0
	private static void set_IsConditionFortuneHutOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1CD0 Offset: 0x2C1DD1 VA: 0x2C1CD0
	// RVA: 0x2D4F630 Offset: 0x2D4F731 VA: 0x2D4F630
	public static bool get_IsConditionFleaMarket() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1CE0 Offset: 0x2C1DE1 VA: 0x2C1CE0
	// RVA: 0x2D4F6A0 Offset: 0x2D4F7A1 VA: 0x2D4F6A0
	private static void set_IsConditionFleaMarket(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1CF0 Offset: 0x2C1DF1 VA: 0x2C1CF0
	// RVA: 0x2D4F720 Offset: 0x2D4F821 VA: 0x2D4F720
	public static bool get_IsConditionStatue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D00 Offset: 0x2C1E01 VA: 0x2C1D00
	// RVA: 0x2D4F790 Offset: 0x2D4F891 VA: 0x2D4F790
	private static void set_IsConditionStatue(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D10 Offset: 0x2C1E11 VA: 0x2C1D10
	// RVA: 0x2D4F810 Offset: 0x2D4F911 VA: 0x2D4F810
	public static bool get_IsConditionRefineGodWeaponOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D20 Offset: 0x2C1E21 VA: 0x2C1D20
	// RVA: 0x2D4F880 Offset: 0x2D4F981 VA: 0x2D4F880
	private static void set_IsConditionRefineGodWeaponOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D30 Offset: 0x2C1E31 VA: 0x2C1D30
	// RVA: 0x2D4F900 Offset: 0x2D4FA01 VA: 0x2D4F900
	public static bool get_IsConditionMuscleHardOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D40 Offset: 0x2C1E41 VA: 0x2C1D40
	// RVA: 0x2D4F970 Offset: 0x2D4FA71 VA: 0x2D4F970
	private static void set_IsConditionMuscleHardOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D50 Offset: 0x2C1E51 VA: 0x2C1D50
	// RVA: 0x2D4F9F0 Offset: 0x2D4FAF1 VA: 0x2D4F9F0
	public static bool get_IsConditionMuscleMasterAndEndlessOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D60 Offset: 0x2C1E61 VA: 0x2C1D60
	// RVA: 0x2D4FA60 Offset: 0x2D4FB61 VA: 0x2D4FA60
	private static void set_IsConditionMuscleMasterAndEndlessOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D70 Offset: 0x2C1E71 VA: 0x2C1D70
	// RVA: 0x2D4FAE0 Offset: 0x2D4FBE1 VA: 0x2D4FAE0
	public static bool get_IsConditionDragonRideHardOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D80 Offset: 0x2C1E81 VA: 0x2C1D80
	// RVA: 0x2D4FB50 Offset: 0x2D4FC51 VA: 0x2D4FB50
	private static void set_IsConditionDragonRideHardOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1D90 Offset: 0x2C1E91 VA: 0x2C1D90
	// RVA: 0x2D4FBD0 Offset: 0x2D4FCD1 VA: 0x2D4FBD0
	public static bool get_IsConditionDragonRideExpertOpened() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1DA0 Offset: 0x2C1EA1 VA: 0x2C1DA0
	// RVA: 0x2D4FC40 Offset: 0x2D4FD41 VA: 0x2D4FC40
	private static void set_IsConditionDragonRideExpertOpened(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1DB0 Offset: 0x2C1EB1 VA: 0x2C1DB0
	// RVA: 0x2D4FCC0 Offset: 0x2D4FDC1 VA: 0x2D4FCC0
	public static bool get_IsConditionPoolCircleSwim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1DC0 Offset: 0x2C1EC1 VA: 0x2C1DC0
	// RVA: 0x2D4FD30 Offset: 0x2D4FE31 VA: 0x2D4FD30
	private static void set_IsConditionPoolCircleSwim(bool value) { }

	// RVA: 0x2D4FDB0 Offset: 0x2D4FEB1 VA: 0x2D4FDB0
	public static bool IsFirstAccessRefineGodWeapon() { }

	// RVA: 0x2D4FEB0 Offset: 0x2D4FFB1 VA: 0x2D4FEB0
	public static void SetFirstAccessRefineGodWeapon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1DD0 Offset: 0x2C1ED1 VA: 0x2C1DD0
	// RVA: 0x2D4FFE0 Offset: 0x2D500E1 VA: 0x2D4FFE0
	public static string get_CurrentCookingPid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1DE0 Offset: 0x2C1EE1 VA: 0x2C1DE0
	// RVA: 0x2D50050 Offset: 0x2D50151 VA: 0x2D50050
	public static void set_CurrentCookingPid(string value) { }

	// RVA: 0x2D500D0 Offset: 0x2D501D1 VA: 0x2D500D0
	public static int get_PersonLimitCount() { }

	// RVA: 0x2D50120 Offset: 0x2D50221 VA: 0x2D50120
	public static int get_GodPersonLimitCount() { }

	// RVA: 0x2D50170 Offset: 0x2D50271 VA: 0x2D50170
	public static int get_AnimalLimitCount() { }

	// RVA: 0x2D501C0 Offset: 0x2D502C1 VA: 0x2D501C0
	public static int get_KizunaPersonLimitCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1DF0 Offset: 0x2C1EF1 VA: 0x2C1DF0
	// RVA: 0x2D50210 Offset: 0x2D50311 VA: 0x2D50210
	public static int get_DragonRideLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E00 Offset: 0x2C1F01 VA: 0x2C1E00
	// RVA: 0x2D50280 Offset: 0x2D50381 VA: 0x2D50280
	public static void set_DragonRideLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E10 Offset: 0x2C1F11 VA: 0x2C1E10
	// RVA: 0x2D502F0 Offset: 0x2D503F1 VA: 0x2D502F0
	public static bool get_IsDragonRideTimeTest() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E20 Offset: 0x2C1F21 VA: 0x2C1E20
	// RVA: 0x2D50360 Offset: 0x2D50461 VA: 0x2D50360
	public static void set_IsDragonRideTimeTest(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E30 Offset: 0x2C1F31 VA: 0x2C1E30
	// RVA: 0x2D503E0 Offset: 0x2D504E1 VA: 0x2D503E0
	public static bool get_IsDragonRideWalkThrough() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E40 Offset: 0x2C1F41 VA: 0x2C1E40
	// RVA: 0x2D50450 Offset: 0x2D50551 VA: 0x2D50450
	private static void set_IsDragonRideWalkThrough(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E50 Offset: 0x2C1F51 VA: 0x2C1E50
	// RVA: 0x2D504D0 Offset: 0x2D505D1 VA: 0x2D504D0
	public static int get_DragonRideTotalScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E60 Offset: 0x2C1F61 VA: 0x2C1E60
	// RVA: 0x2D50540 Offset: 0x2D50641 VA: 0x2D50540
	public static void set_DragonRideTotalScore(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E70 Offset: 0x2C1F71 VA: 0x2C1E70
	// RVA: 0x2D505B0 Offset: 0x2D506B1 VA: 0x2D505B0
	public static int get_DragonRideNormalTargetCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E80 Offset: 0x2C1F81 VA: 0x2C1E80
	// RVA: 0x2D50620 Offset: 0x2D50721 VA: 0x2D50620
	public static void set_DragonRideNormalTargetCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1E90 Offset: 0x2C1F91 VA: 0x2C1E90
	// RVA: 0x2D50690 Offset: 0x2D50791 VA: 0x2D50690
	public static int get_DragonRideBigTargetCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1EA0 Offset: 0x2C1FA1 VA: 0x2C1EA0
	// RVA: 0x2D50700 Offset: 0x2D50801 VA: 0x2D50700
	public static void set_DragonRideBigTargetCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1EB0 Offset: 0x2C1FB1 VA: 0x2C1EB0
	// RVA: 0x2D50770 Offset: 0x2D50871 VA: 0x2D50770
	public static int get_DragonRideLinkTargetCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1EC0 Offset: 0x2C1FC1 VA: 0x2C1EC0
	// RVA: 0x2D507E0 Offset: 0x2D508E1 VA: 0x2D507E0
	public static void set_DragonRideLinkTargetCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1ED0 Offset: 0x2C1FD1 VA: 0x2C1ED0
	// RVA: 0x2D50850 Offset: 0x2D50951 VA: 0x2D50850
	public static int get_DragonRideSpecialTargetCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1EE0 Offset: 0x2C1FE1 VA: 0x2C1EE0
	// RVA: 0x2D508C0 Offset: 0x2D509C1 VA: 0x2D508C0
	public static void set_DragonRideSpecialTargetCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1EF0 Offset: 0x2C1FF1 VA: 0x2C1EF0
	// RVA: 0x2D50930 Offset: 0x2D50A31 VA: 0x2D50930
	public static int get_DragonRideRouletteTargetCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F00 Offset: 0x2C2001 VA: 0x2C1F00
	// RVA: 0x2D509A0 Offset: 0x2D50AA1 VA: 0x2D509A0
	public static void set_DragonRideRouletteTargetCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F10 Offset: 0x2C2011 VA: 0x2C1F10
	// RVA: 0x2D50A10 Offset: 0x2D50B11 VA: 0x2D50A10
	public static int get_DragonRideAssistScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F20 Offset: 0x2C2021 VA: 0x2C1F20
	// RVA: 0x2D50A80 Offset: 0x2D50B81 VA: 0x2D50A80
	public static void set_DragonRideAssistScore(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F30 Offset: 0x2C2031 VA: 0x2C1F30
	// RVA: 0x2D50AF0 Offset: 0x2D50BF1 VA: 0x2D50AF0
	public static int get_DragonRidePlayRankNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F40 Offset: 0x2C2041 VA: 0x2C1F40
	// RVA: 0x2D50B60 Offset: 0x2D50C61 VA: 0x2D50B60
	public static void set_DragonRidePlayRankNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F50 Offset: 0x2C2051 VA: 0x2C1F50
	// RVA: 0x2D50BD0 Offset: 0x2D50CD1 VA: 0x2D50BD0
	public static bool get_DragonRideRetireFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F60 Offset: 0x2C2061 VA: 0x2C1F60
	// RVA: 0x2D50C40 Offset: 0x2D50D41 VA: 0x2D50C40
	public static void set_DragonRideRetireFlag(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F70 Offset: 0x2C2071 VA: 0x2C1F70
	// RVA: 0x2D50CC0 Offset: 0x2D50DC1 VA: 0x2D50CC0
	public static DragonRidePresetParamData.CourseData[] get_DragonRideWalkThroughList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F80 Offset: 0x2C2081 VA: 0x2C1F80
	// RVA: 0x2D50D30 Offset: 0x2D50E31 VA: 0x2D50D30
	private static void set_DragonRideWalkThroughList(DragonRidePresetParamData.CourseData[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1F90 Offset: 0x2C2091 VA: 0x2C1F90
	// RVA: 0x2D50DB0 Offset: 0x2D50EB1 VA: 0x2D50DB0
	public static string get_DragonRideUsingPresetID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1FA0 Offset: 0x2C20A1 VA: 0x2C1FA0
	// RVA: 0x2D50E20 Offset: 0x2D50F21 VA: 0x2D50E20
	public static void set_DragonRideUsingPresetID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1FB0 Offset: 0x2C20B1 VA: 0x2C1FB0
	// RVA: 0x2D50EA0 Offset: 0x2D50FA1 VA: 0x2D50EA0
	public static float get_DragonRideTargetSuicideSec() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1FC0 Offset: 0x2C20C1 VA: 0x2C1FC0
	// RVA: 0x2D50F10 Offset: 0x2D51011 VA: 0x2D50F10
	public static void set_DragonRideTargetSuicideSec(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1FD0 Offset: 0x2C20D1 VA: 0x2C1FD0
	// RVA: 0x2D50F80 Offset: 0x2D51081 VA: 0x2D50F80
	public static float get_DragonRideTargetSuicideSecRandomRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1FE0 Offset: 0x2C20E1 VA: 0x2C1FE0
	// RVA: 0x2D50FF0 Offset: 0x2D510F1 VA: 0x2D50FF0
	public static void set_DragonRideTargetSuicideSecRandomRange(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1FF0 Offset: 0x2C20F1 VA: 0x2C1FF0
	// RVA: 0x2D51060 Offset: 0x2D51161 VA: 0x2D51060
	public static int get_DragonRideAssistLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2000 Offset: 0x2C2101 VA: 0x2C2000
	// RVA: 0x2D510D0 Offset: 0x2D511D1 VA: 0x2D510D0
	public static void set_DragonRideAssistLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2010 Offset: 0x2C2111 VA: 0x2C2010
	// RVA: 0x2D51140 Offset: 0x2D51241 VA: 0x2D51140
	public static bool get_DebugDragonRideAssistSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2020 Offset: 0x2C2121 VA: 0x2C2020
	// RVA: 0x2D511B0 Offset: 0x2D512B1 VA: 0x2D511B0
	public static void set_DebugDragonRideAssistSet(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2030 Offset: 0x2C2131 VA: 0x2C2030
	// RVA: 0x2D51230 Offset: 0x2D51331 VA: 0x2D51230
	public static bool get_IsDragonRideResultCheck() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2040 Offset: 0x2C2141 VA: 0x2C2040
	// RVA: 0x2D512A0 Offset: 0x2D513A1 VA: 0x2D512A0
	public static void set_IsDragonRideResultCheck(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2050 Offset: 0x2C2151 VA: 0x2C2050
	// RVA: 0x2D51320 Offset: 0x2D51421 VA: 0x2D51320
	public static bool get_IsDragonRideResultCheck_Assist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2060 Offset: 0x2C2161 VA: 0x2C2060
	// RVA: 0x2D51390 Offset: 0x2D51491 VA: 0x2D51390
	public static void set_IsDragonRideResultCheck_Assist(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2070 Offset: 0x2C2171 VA: 0x2C2070
	// RVA: 0x2D51410 Offset: 0x2D51511 VA: 0x2D51410
	public static bool get_IsDragonRideResultCheck_HighScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2080 Offset: 0x2C2181 VA: 0x2C2080
	// RVA: 0x2D51480 Offset: 0x2D51581 VA: 0x2D51480
	public static void set_IsDragonRideResultCheck_HighScore(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2090 Offset: 0x2C2191 VA: 0x2C2090
	// RVA: 0x2D51500 Offset: 0x2D51601 VA: 0x2D51500
	public static int get_FishingLureType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C20A0 Offset: 0x2C21A1 VA: 0x2C20A0
	// RVA: 0x2D51570 Offset: 0x2D51671 VA: 0x2D51570
	private static void set_FishingLureType(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C20B0 Offset: 0x2C21B1 VA: 0x2C20B0
	// RVA: 0x2D515E0 Offset: 0x2D516E1 VA: 0x2D515E0
	public static string get_FishingGetFishID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C20C0 Offset: 0x2C21C1 VA: 0x2C20C0
	// RVA: 0x2D51650 Offset: 0x2D51751 VA: 0x2D51650
	public static void set_FishingGetFishID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C20D0 Offset: 0x2C21D1 VA: 0x2C20D0
	// RVA: 0x2D516D0 Offset: 0x2D517D1 VA: 0x2D516D0
	public static float get_FishingGetFishSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C20E0 Offset: 0x2C21E1 VA: 0x2C20E0
	// RVA: 0x2D51740 Offset: 0x2D51841 VA: 0x2D51740
	public static void set_FishingGetFishSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C20F0 Offset: 0x2C21F1 VA: 0x2C20F0
	// RVA: 0x2D517B0 Offset: 0x2D518B1 VA: 0x2D517B0
	public static bool get_IsPlayMuscleExercise() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2100 Offset: 0x2C2201 VA: 0x2C2100
	// RVA: 0x2D51820 Offset: 0x2D51921 VA: 0x2D51820
	public static void set_IsPlayMuscleExercise(bool value) { }

	// RVA: 0x2D518A0 Offset: 0x2D519A1 VA: 0x2D518A0
	public static void InitializeCondition() { }

	// RVA: 0x2D53040 Offset: 0x2D53141 VA: 0x2D53040
	public static void FinalizeCondition() { }

	// RVA: 0x2D53B10 Offset: 0x2D53C11 VA: 0x2D53B10
	public static bool IsCondition(HubUtil.ConditionType conditionType) { }

	// RVA: 0x2D53740 Offset: 0x2D53841 VA: 0x2D53740
	private static void InitCookingPerson() { }

	// RVA: 0x2D54250 Offset: 0x2D54351 VA: 0x2D54250
	public static int GetPersonLimitCount() { }

	// RVA: 0x2D543A0 Offset: 0x2D544A1 VA: 0x2D543A0
	public static void SetupCharacterDisposType(Character chara, HubDisposData.DisposTypes disposType) { }

	// RVA: 0x2D54610 Offset: 0x2D54711 VA: 0x2D54610
	public static void SetupCharacterGroundHeight(Character chara, float groundOffset, float gravity = 0) { }

	// RVA: 0x2D54770 Offset: 0x2D54871 VA: 0x2D54770
	public void .ctor() { }

	// RVA: 0x2D54780 Offset: 0x2D54881 VA: 0x2D54780
	private static void .cctor() { }
}

