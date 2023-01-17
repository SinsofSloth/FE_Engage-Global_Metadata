// Namespace: App
public class AchieveData : StructData<AchieveData> // TypeDefIndex: 9798
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x287920 Offset: 0x287A21 VA: 0x287920
	private string <Aid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287930 Offset: 0x287A31 VA: 0x287930
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x287940 Offset: 0x287A41 VA: 0x287940
	private AchieveData.Categories <Category>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x287950 Offset: 0x287A51 VA: 0x287950
	private AchieveData.Kinds <Kind>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x287960 Offset: 0x287A61 VA: 0x287960
	private int <Count>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x287970 Offset: 0x287A71 VA: 0x287970
	private string <Arg>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x287980 Offset: 0x287A81 VA: 0x287980
	private string <CountUnit>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x287990 Offset: 0x287A91 VA: 0x287990
	private int <KizunaReward>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x2879A0 Offset: 0x287AA1 VA: 0x2879A0
	private string <Chapter>k__BackingField; // 0x58
	private string m_FlagName; // 0x60
	private static Dictionary<int, List<AchieveData>> s_KindDictionary; // 0x0
	private static Queue<AchieveData> s_ShowQueue; // 0x8

	// Properties
	public string Aid { get; set; }
	public string Name { get; set; }
	public AchieveData.Categories Category { get; set; }
	public AchieveData.Kinds Kind { get; set; }
	public int Count { get; set; }
	public string Arg { get; set; }
	public string CountUnit { get; set; }
	public int KizunaReward { get; set; }
	public string Chapter { get; set; }

	// Methods

	// RVA: 0x2B24830 Offset: 0x2B24931 VA: 0x2B24830
	public static void Load() { }

	// RVA: 0x2B248E0 Offset: 0x2B249E1 VA: 0x2B248E0
	public static bool IsGrouping(AchieveData.Kinds kind) { }

	// RVA: 0x2B24900 Offset: 0x2B24A01 VA: 0x2B24900
	public static bool IsCount(AchieveData.Kinds kind) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1090 Offset: 0x2B1191 VA: 0x2B1090
	// RVA: 0x2B24950 Offset: 0x2B24A51 VA: 0x2B24950
	public string get_Aid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B10A0 Offset: 0x2B11A1 VA: 0x2B10A0
	// RVA: 0x2B24960 Offset: 0x2B24A61 VA: 0x2B24960
	private void set_Aid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B10B0 Offset: 0x2B11B1 VA: 0x2B10B0
	// RVA: 0x2B24970 Offset: 0x2B24A71 VA: 0x2B24970
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B10C0 Offset: 0x2B11C1 VA: 0x2B10C0
	// RVA: 0x2B24980 Offset: 0x2B24A81 VA: 0x2B24980
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B10D0 Offset: 0x2B11D1 VA: 0x2B10D0
	// RVA: 0x2B24990 Offset: 0x2B24A91 VA: 0x2B24990
	public AchieveData.Categories get_Category() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B10E0 Offset: 0x2B11E1 VA: 0x2B10E0
	// RVA: 0x2B249A0 Offset: 0x2B24AA1 VA: 0x2B249A0
	private void set_Category(AchieveData.Categories value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B10F0 Offset: 0x2B11F1 VA: 0x2B10F0
	// RVA: 0x2B249B0 Offset: 0x2B24AB1 VA: 0x2B249B0
	public AchieveData.Kinds get_Kind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1100 Offset: 0x2B1201 VA: 0x2B1100
	// RVA: 0x2B249C0 Offset: 0x2B24AC1 VA: 0x2B249C0
	private void set_Kind(AchieveData.Kinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1110 Offset: 0x2B1211 VA: 0x2B1110
	// RVA: 0x2B249D0 Offset: 0x2B24AD1 VA: 0x2B249D0
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1120 Offset: 0x2B1221 VA: 0x2B1120
	// RVA: 0x2B249E0 Offset: 0x2B24AE1 VA: 0x2B249E0
	private void set_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1130 Offset: 0x2B1231 VA: 0x2B1130
	// RVA: 0x2B249F0 Offset: 0x2B24AF1 VA: 0x2B249F0
	public string get_Arg() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1140 Offset: 0x2B1241 VA: 0x2B1140
	// RVA: 0x2B24A00 Offset: 0x2B24B01 VA: 0x2B24A00
	private void set_Arg(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1150 Offset: 0x2B1251 VA: 0x2B1150
	// RVA: 0x2B24A10 Offset: 0x2B24B11 VA: 0x2B24A10
	public string get_CountUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1160 Offset: 0x2B1261 VA: 0x2B1160
	// RVA: 0x2B24A20 Offset: 0x2B24B21 VA: 0x2B24A20
	private void set_CountUnit(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1170 Offset: 0x2B1271 VA: 0x2B1170
	// RVA: 0x2B24A30 Offset: 0x2B24B31 VA: 0x2B24A30
	public int get_KizunaReward() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1180 Offset: 0x2B1281 VA: 0x2B1180
	// RVA: 0x2B24A40 Offset: 0x2B24B41 VA: 0x2B24A40
	private void set_KizunaReward(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1190 Offset: 0x2B1291 VA: 0x2B1190
	// RVA: 0x2B24A50 Offset: 0x2B24B51 VA: 0x2B24A50
	public string get_Chapter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B11A0 Offset: 0x2B12A1 VA: 0x2B11A0
	// RVA: 0x2B24A60 Offset: 0x2B24B61 VA: 0x2B24A60
	private void set_Chapter(string value) { }

	// RVA: 0x2B24A70 Offset: 0x2B24B71 VA: 0x2B24A70 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x2B24AF0 Offset: 0x2B24BF1 VA: 0x2B24AF0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2B24B00 Offset: 0x2B24C01 VA: 0x2B24B00
	public AchieveData.ArgType GetArgType() { }

	// RVA: 0x2B24CA0 Offset: 0x2B24DA1 VA: 0x2B24CA0
	public ChapterData GetChapter() { }

	// RVA: 0x2B24D50 Offset: 0x2B24E51 VA: 0x2B24D50
	public PersonData GetPerson() { }

	// RVA: 0x2B24E00 Offset: 0x2B24F01 VA: 0x2B24E00
	public GodData GetGod() { }

	// RVA: 0x2B24EB0 Offset: 0x2B24FB1 VA: 0x2B24EB0
	public string GetName() { }

	// RVA: 0x2B25280 Offset: 0x2B25381 VA: 0x2B25280
	public AchieveData.Status GetStatus() { }

	// RVA: 0x2B25360 Offset: 0x2B25461 VA: 0x2B25360
	public bool SetCleared() { }

	// RVA: 0x2B25580 Offset: 0x2B25681 VA: 0x2B25580
	public bool SetShowed() { }

	// RVA: 0x2B255D0 Offset: 0x2B256D1 VA: 0x2B255D0
	public bool SetComplete() { }

	// RVA: 0x2B25620 Offset: 0x2B25721 VA: 0x2B25620
	public bool IsCanGet() { }

	// RVA: 0x2B253B0 Offset: 0x2B254B1 VA: 0x2B253B0
	public void SetStatus(AchieveData.Status status) { }

	// RVA: 0x2B25660 Offset: 0x2B25761 VA: 0x2B25660
	public int GetValue() { }

	// RVA: 0x2B25830 Offset: 0x2B25931 VA: 0x2B25830
	public static void RegistGlobalFlags() { }

	// RVA: 0x2B25780 Offset: 0x2B25881 VA: 0x2B25780
	private static string GetFlagName(AchieveData.Kinds kind) { }

	// RVA: 0x2B263D0 Offset: 0x2B264D1 VA: 0x2B263D0
	private static string GetFlagName(AchieveData.Kinds kind, string footer) { }

	// RVA: 0x2B26450 Offset: 0x2B26551 VA: 0x2B26450
	private static string GetFlagName(string kind) { }

	// RVA: 0x2B264B0 Offset: 0x2B265B1 VA: 0x2B264B0
	public int GetCountCurrent(string footer) { }

	// RVA: 0x2B266C0 Offset: 0x2B267C1 VA: 0x2B266C0
	public static int GetKindCount(string kind) { }

	// RVA: 0x2B26810 Offset: 0x2B26911 VA: 0x2B26810
	public static void SetClearReliance(PersonData person) { }

	// RVA: 0x2B26BB0 Offset: 0x2B26CB1 VA: 0x2B26BB0
	public static void AddCountRelianceB() { }

	// RVA: 0x2B270D0 Offset: 0x2B271D1 VA: 0x2B270D0
	public static void AddCountRelianceA() { }

	// RVA: 0x2B27130 Offset: 0x2B27231 VA: 0x2B27130
	public static void AddCountRelianceS() { }

	// RVA: 0x2B27190 Offset: 0x2B27291 VA: 0x2B27190
	public static void AddCountSortie(PersonData person) { }

	// RVA: 0x2B27850 Offset: 0x2B27951 VA: 0x2B27850
	public static void AddCountEncount() { }

	// RVA: 0x2B278B0 Offset: 0x2B279B1 VA: 0x2B278B0
	public static void AddCountBattle() { }

	// RVA: 0x2B27910 Offset: 0x2B27A11 VA: 0x2B27910
	public static void AddCountDefeat(PersonData person) { }

	// RVA: 0x2B27A00 Offset: 0x2B27B01 VA: 0x2B27A00
	public static void AddCountRod() { }

	// RVA: 0x2B27A60 Offset: 0x2B27B61 VA: 0x2B27A60
	public static void AddCountCritical() { }

	// RVA: 0x2B27AC0 Offset: 0x2B27BC1 VA: 0x2B27AC0
	public static void AddCountEngage() { }

	// RVA: 0x2B27B20 Offset: 0x2B27C21 VA: 0x2B27B20
	public static void AddCountEngageAttack() { }

	// RVA: 0x2B27B80 Offset: 0x2B27C81 VA: 0x2B27B80
	public static void AddCountAvoidance() { }

	// RVA: 0x2B27BE0 Offset: 0x2B27CE1 VA: 0x2B27BE0
	public static void AddCountChainGuard() { }

	// RVA: 0x2B27C40 Offset: 0x2B27D41 VA: 0x2B27C40
	public static void AddCountChainAttack() { }

	// RVA: 0x2B27CA0 Offset: 0x2B27DA1 VA: 0x2B27CA0
	public static void SetValueChainUnit(int unitNum) { }

	// RVA: 0x2B281D0 Offset: 0x2B282D1 VA: 0x2B281D0
	public static void AddCountBreak() { }

	// RVA: 0x2B28230 Offset: 0x2B28331 VA: 0x2B28230
	public static void AddCountSmash() { }

	// RVA: 0x2B28290 Offset: 0x2B28391 VA: 0x2B28290
	public static void AddCountMiniGame() { }

	// RVA: 0x2B282F0 Offset: 0x2B283F1 VA: 0x2B282F0
	public static void AddCountRingForm(int addValue) { }

	// RVA: 0x2B28360 Offset: 0x2B28461 VA: 0x2B28360
	public static void AddCountRingMix() { }

	// RVA: 0x2B283C0 Offset: 0x2B284C1 VA: 0x2B283C0
	public static void AddCountBondsRingC(int addValue) { }

	// RVA: 0x2B28430 Offset: 0x2B28531 VA: 0x2B28430
	public static void AddCountBondsRingB(int addValue) { }

	// RVA: 0x2B284A0 Offset: 0x2B285A1 VA: 0x2B284A0
	public static void AddCountBondsRingA(int addValue) { }

	// RVA: 0x2B28510 Offset: 0x2B28611 VA: 0x2B28510
	public static void AddCountBondsRingS(int addValue) { }

	// RVA: 0x2B28580 Offset: 0x2B28681 VA: 0x2B28580
	public static void AddCountRingCleaning() { }

	// RVA: 0x2B285E0 Offset: 0x2B286E1 VA: 0x2B285E0
	public static void SetValueInvestmentFilene(int level) { }

	// RVA: 0x2B28650 Offset: 0x2B28751 VA: 0x2B28650
	public static void SetValueInvestmentBrodia(int level) { }

	// RVA: 0x2B286C0 Offset: 0x2B287C1 VA: 0x2B286C0
	public static void SetValueInvestmentIrcion(int level) { }

	// RVA: 0x2B28730 Offset: 0x2B28831 VA: 0x2B28730
	public static void SetValueInvestmentSolum(int level) { }

	// RVA: 0x2B287A0 Offset: 0x2B288A1 VA: 0x2B287A0
	public static void SetClearInvestmentAll() { }

	// RVA: 0x2B28980 Offset: 0x2B28A81 VA: 0x2B28980
	public static void AddCountInvestmentMoney(int Money) { }

	// RVA: 0x2B289F0 Offset: 0x2B28AF1 VA: 0x2B289F0
	public static void AddCountCookAll() { }

	// RVA: 0x2B28A50 Offset: 0x2B28B51 VA: 0x2B28A50
	public static void AddCountCookG() { }

	// RVA: 0x2B28AB0 Offset: 0x2B28BB1 VA: 0x2B28AB0
	public static void AddCountCookF() { }

	// RVA: 0x2B28B10 Offset: 0x2B28C11 VA: 0x2B28B10
	public static void AddCountCookE() { }

	// RVA: 0x2B28B70 Offset: 0x2B28C71 VA: 0x2B28B70
	public static void AddCountCookD() { }

	// RVA: 0x2B28BD0 Offset: 0x2B28CD1 VA: 0x2B28BD0
	public static void AddCountCookC() { }

	// RVA: 0x2B28C30 Offset: 0x2B28D31 VA: 0x2B28C30
	public static void AddCountCookB() { }

	// RVA: 0x2B28C90 Offset: 0x2B28D91 VA: 0x2B28C90
	public static void AddCountCookA() { }

	// RVA: 0x2B28CF0 Offset: 0x2B28DF1 VA: 0x2B28CF0
	public static void AddCountCookS() { }

	// RVA: 0x2B28D50 Offset: 0x2B28E51 VA: 0x2B28D50
	public static void AddCountCookSS() { }

	// RVA: 0x2B28DB0 Offset: 0x2B28EB1 VA: 0x2B28DB0
	public static void AddCountSleep() { }

	// RVA: 0x2B28E10 Offset: 0x2B28F11 VA: 0x2B28E10
	public static void AddCountWakeUpC() { }

	// RVA: 0x2B28E70 Offset: 0x2B28F71 VA: 0x2B28E70
	public static void AddCountWakeUpB() { }

	// RVA: 0x2B28ED0 Offset: 0x2B28FD1 VA: 0x2B28ED0
	public static void AddCountWakeUpA() { }

	// RVA: 0x2B28F30 Offset: 0x2B29031 VA: 0x2B28F30
	public static void AddCountWakeUpS() { }

	// RVA: 0x2B28F90 Offset: 0x2B29091 VA: 0x2B28F90
	public static void AddCountUnitBattle() { }

	// RVA: 0x2B28FF0 Offset: 0x2B290F1 VA: 0x2B28FF0
	public static void AddCountUnitBattleWin() { }

	// RVA: 0x2B29050 Offset: 0x2B29151 VA: 0x2B29050
	public static void AddCountGodBattle() { }

	// RVA: 0x2B290B0 Offset: 0x2B291B1 VA: 0x2B290B0
	public static void AddCountGodBattleWin() { }

	// RVA: 0x2B29110 Offset: 0x2B29211 VA: 0x2B29110
	public static void AddCountBuyWeapon() { }

	// RVA: 0x2B29170 Offset: 0x2B29271 VA: 0x2B29170
	public static void AddCountBuySword() { }

	// RVA: 0x2B291D0 Offset: 0x2B292D1 VA: 0x2B291D0
	public static void AddCountBuyLance() { }

	// RVA: 0x2B29230 Offset: 0x2B29331 VA: 0x2B29230
	public static void AddCountBuyAxe() { }

	// RVA: 0x2B29290 Offset: 0x2B29391 VA: 0x2B29290
	public static void AddCountBuyBow() { }

	// RVA: 0x2B292F0 Offset: 0x2B293F1 VA: 0x2B292F0
	public static void AddCountBuyKnife() { }

	// RVA: 0x2B29350 Offset: 0x2B29451 VA: 0x2B29350
	public static void AddCountBuyMagic() { }

	// RVA: 0x2B293B0 Offset: 0x2B294B1 VA: 0x2B293B0
	public static void AddCountBuyFist() { }

	// RVA: 0x2B29410 Offset: 0x2B29511 VA: 0x2B29410
	public static void AddCountSellWeapon(int addValue) { }

	// RVA: 0x2B29480 Offset: 0x2B29581 VA: 0x2B29480
	public static void AddCountBuyItem() { }

	// RVA: 0x2B294E0 Offset: 0x2B295E1 VA: 0x2B294E0
	public static void AddCountSellItem(int addValue) { }

	// RVA: 0x2B29550 Offset: 0x2B29651 VA: 0x2B29550
	public static void AddCountBuyRod() { }

	// RVA: 0x2B295B0 Offset: 0x2B296B1 VA: 0x2B295B0
	public static void AddCountBuyAccessories() { }

	// RVA: 0x2B29610 Offset: 0x2B29711 VA: 0x2B29610
	public static void AddCountChangeAccessories() { }

	// RVA: 0x2B29670 Offset: 0x2B29771 VA: 0x2B29670
	public static void AddCountForging() { }

	// RVA: 0x2B296D0 Offset: 0x2B297D1 VA: 0x2B296D0
	public static void AddCountForgingSword() { }

	// RVA: 0x2B29730 Offset: 0x2B29831 VA: 0x2B29730
	public static void AddCountForgingLance() { }

	// RVA: 0x2B29790 Offset: 0x2B29891 VA: 0x2B29790
	public static void AddCountForgingAxe() { }

	// RVA: 0x2B297F0 Offset: 0x2B298F1 VA: 0x2B297F0
	public static void AddCountForgingBow() { }

	// RVA: 0x2B29850 Offset: 0x2B29951 VA: 0x2B29850
	public static void AddCountForgingKnife() { }

	// RVA: 0x2B298B0 Offset: 0x2B299B1 VA: 0x2B298B0
	public static void AddCountForgingMagic() { }

	// RVA: 0x2B29910 Offset: 0x2B29A11 VA: 0x2B29910
	public static void AddCountForgingFist() { }

	// RVA: 0x2B29970 Offset: 0x2B29A71 VA: 0x2B29970
	public static void AddCountEngrave() { }

	// RVA: 0x2B299D0 Offset: 0x2B29AD1 VA: 0x2B299D0
	public static void SetValuePlayTime(float time) { }

	// RVA: 0x2B29A80 Offset: 0x2B29B81 VA: 0x2B29A80
	public static void SetClearChapter(ChapterData chapter) { }

	// RVA: 0x2B29F50 Offset: 0x2B2A051 VA: 0x2B29F50
	public static void AddCountNetMatch() { }

	// RVA: 0x2B29FB0 Offset: 0x2B2A0B1 VA: 0x2B29FB0
	public static void AddCountNetMatchWin() { }

	// RVA: 0x2B2A010 Offset: 0x2B2A111 VA: 0x2B2A010
	public static void AddCountRelayBattle() { }

	// RVA: 0x2B2A070 Offset: 0x2B2A171 VA: 0x2B2A070
	public static void AddCountRelayBattleWin() { }

	// RVA: 0x2B2A0D0 Offset: 0x2B2A1D1 VA: 0x2B2A0D0
	public static void SetChallengeRank(int route, int level) { }

	// RVA: 0x2B2A240 Offset: 0x2B2A341 VA: 0x2B2A240
	public static void PlayReportAddCountClassChange() { }

	// RVA: 0x2B2A2A0 Offset: 0x2B2A3A1 VA: 0x2B2A2A0
	public static void PlayReportAddCountPushUpsNormal() { }

	// RVA: 0x2B2A300 Offset: 0x2B2A401 VA: 0x2B2A300
	public static void PlayReportAddCountPushUpsHard() { }

	// RVA: 0x2B2A360 Offset: 0x2B2A461 VA: 0x2B2A360
	public static void PlayReportAddCountPushUpsExpert() { }

	// RVA: 0x2B2A3C0 Offset: 0x2B2A4C1 VA: 0x2B2A3C0
	public static void PlayReportAddCountPushUpsMuscle() { }

	// RVA: 0x2B2A420 Offset: 0x2B2A521 VA: 0x2B2A420
	public static void PlayReportAddCountAdsNormal() { }

	// RVA: 0x2B2A480 Offset: 0x2B2A581 VA: 0x2B2A480
	public static void PlayReportAddCountAdsHard() { }

	// RVA: 0x2B2A4E0 Offset: 0x2B2A5E1 VA: 0x2B2A4E0
	public static void PlayReportAddCountAdsExpert() { }

	// RVA: 0x2B2A540 Offset: 0x2B2A641 VA: 0x2B2A540
	public static void PlayReportAddCountAdsMuscle() { }

	// RVA: 0x2B2A5A0 Offset: 0x2B2A6A1 VA: 0x2B2A5A0
	public static void PlayReportAddCountSquatNormal() { }

	// RVA: 0x2B2A600 Offset: 0x2B2A701 VA: 0x2B2A600
	public static void PlayReportAddCountSquatHard() { }

	// RVA: 0x2B2A660 Offset: 0x2B2A761 VA: 0x2B2A660
	public static void PlayReportAddCountSquatExpert() { }

	// RVA: 0x2B2A6C0 Offset: 0x2B2A7C1 VA: 0x2B2A6C0
	public static void PlayReportAddCountSquatMuscle() { }

	// RVA: 0x2B2A720 Offset: 0x2B2A821 VA: 0x2B2A720
	public static void PlayReportAddCountDragonRideNormal() { }

	// RVA: 0x2B2A780 Offset: 0x2B2A881 VA: 0x2B2A780
	public static void PlayReportAddCountDragonRideHard() { }

	// RVA: 0x2B2A7E0 Offset: 0x2B2A8E1 VA: 0x2B2A7E0
	public static void PlayReportAddCountDragonRideExpert() { }

	// RVA: 0x2B2A840 Offset: 0x2B2A941 VA: 0x2B2A840
	public static void PlayReportAddCountFishingRodSmoll() { }

	// RVA: 0x2B2A8A0 Offset: 0x2B2A9A1 VA: 0x2B2A8A0
	public static void PlayReportAddCountFishingRodNormal() { }

	// RVA: 0x2B2A900 Offset: 0x2B2AA01 VA: 0x2B2A900
	public static void PlayReportAddCountFishingRodAllPurpose() { }

	// RVA: 0x2B2A960 Offset: 0x2B2AA61 VA: 0x2B2A960
	public static void PlayReportAddCountCleaningFormGod(string gid) { }

	// RVA: 0x2B2AC70 Offset: 0x2B2AD71 VA: 0x2B2AC70
	public static void PlayReportAddCountChallenge(int route) { }

	// RVA: 0x2B2AE10 Offset: 0x2B2AF11 VA: 0x2B2AE10
	public static void PlayReportAddCountChallengeClear(int route) { }

	// RVA: 0x2B2AFB0 Offset: 0x2B2B0B1 VA: 0x2B2AFB0
	public static void PlayReportAddCountRelayBattle(int route) { }

	// RVA: 0x2B2B150 Offset: 0x2B2B251 VA: 0x2B2B150
	public static void PlayReportAddCountRelayBattleInherit() { }

	// RVA: 0x2B2B1B0 Offset: 0x2B2B2B1 VA: 0x2B2B1B0
	public static void PlayReportAddCountVersusCasual() { }

	// RVA: 0x2B2B210 Offset: 0x2B2B311 VA: 0x2B2B210
	public static void PlayReportAddCountVersusCasualWin() { }

	// RVA: 0x2B2B270 Offset: 0x2B2B371 VA: 0x2B2B270
	public static void PlayReportAddCountVersusCasualLose() { }

	// RVA: 0x2B2B2D0 Offset: 0x2B2B3D1 VA: 0x2B2B2D0
	public static void PlayReportAddCountVersusRanked() { }

	// RVA: 0x2B2B330 Offset: 0x2B2B431 VA: 0x2B2B330
	public static void PlayReportAddCountVersusRankedWin() { }

	// RVA: 0x2B2B390 Offset: 0x2B2B491 VA: 0x2B2B390
	public static void PlayReportAddCountVersusRankedLose() { }

	// RVA: 0x2B2B3F0 Offset: 0x2B2B4F1 VA: 0x2B2B3F0
	public static void PlayReportAddCountVersusRankedDefenseWin() { }

	// RVA: 0x2B2B450 Offset: 0x2B2B551 VA: 0x2B2B450
	public static void PlayReportAddCountVersusRankedDefenseLose() { }

	// RVA: 0x2B2B4B0 Offset: 0x2B2B5B1 VA: 0x2B2B4B0
	public static int PlayReportGetCount(AchieveData.Kinds kinds) { }

	// RVA: 0x2B2B760 Offset: 0x2B2B861 VA: 0x2B2B760
	public static int PlayReportGetCountCleaningFormGod(string gid) { }

	// RVA: 0x2B26AC0 Offset: 0x2B26BC1 VA: 0x2B26AC0
	private static bool TrySetCleard(AchieveData data) { }

	// RVA: 0x2B27710 Offset: 0x2B27811 VA: 0x2B27710
	private static bool IsProhibited() { }

	// RVA: 0x2B2B650 Offset: 0x2B2B751 VA: 0x2B2B650
	private static bool IsValid(string flagName) { }

	// RVA: 0x2B26C10 Offset: 0x2B26D11 VA: 0x2B26C10
	private static void AddCount(AchieveData.Kinds kind, int addValue = 1) { }

	// RVA: 0x2B27D10 Offset: 0x2B27E11 VA: 0x2B27D10
	private static void CommitValue(AchieveData.Kinds kind, int value) { }

	// RVA: 0x2B26320 Offset: 0x2B26421 VA: 0x2B26320
	public static List<AchieveData> GetKindList(AchieveData.Kinds kind) { }

	// RVA: 0x2B2B8E0 Offset: 0x2B2B9E1 VA: 0x2B2B8E0
	public static void UpdateShowQueue() { }

	// RVA: 0x2B2BAE0 Offset: 0x2B2BBE1 VA: 0x2B2BAE0
	public static void ClearShowQueue() { }

	// RVA: 0x2B2BBC0 Offset: 0x2B2BCC1 VA: 0x2B2BBC0
	public static AchieveData DequeueShowData() { }

	// RVA: 0x2B2BCB0 Offset: 0x2B2BDB1 VA: 0x2B2BCB0
	public void .ctor() { }

	// RVA: 0x2B2BD30 Offset: 0x2B2BE31 VA: 0x2B2BD30
	private static void .cctor() { }
}

