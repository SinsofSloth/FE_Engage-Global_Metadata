// Namespace: App
public class GameUserData : SingletonClass<GameUserData> // TypeDefIndex: 13613
{
	// Fields
	public const int MaxGold = 9999999;
	public const int MaxRefine = 9999;
	public const int MaxPieceOfBond = 9999999;
	public const int MaxVariable = 4096;
	private GameUserData.StatusField m_Status; // 0x20
	private GameUserData.Sequences m_Sequence; // 0x28
	private GameMode m_GameMode; // 0x2C
	private Difficulty m_Difficulty; // 0x30
	private ChapterData m_Chapter; // 0x38
	private string m_GmapSpot; // 0x40
	private int m_ContentsIndex; // 0x48
	private GameVariable m_Variable; // 0x50
	private int m_Gold; // 0x58
	private int m_Progress; // 0x5C
	private int m_TrainingCount; // 0x60
	private int m_ArenaCount; // 0x64
	private UnitInfo.Mode m_UnitInfoMode; // 0x68
	private int m_PieceOfBond; // 0x6C
	private int m_TotalPieceOfBond; // 0x70
	private GameUserGmapData m_GmapData; // 0x78
	private GameUserHubData m_HubData; // 0x80
	private ChapterRecord m_ChapterRecord; // 0x88
	private string m_MascotName; // 0x90
	private MapEditData m_MapEditData; // 0x98
	private RelayUserData m_RelayData; // 0xA0
	private ulong m_Identifier; // 0xA8
	private VersusUserData m_VersusData; // 0xB0
	private bool m_IsShowNetTerms; // 0xB8
	private bool m_IsShowNetHowToReport; // 0xB9
	private Difficulty m_EvilDifficulty; // 0xBC
	private const string Flag_RefineIron = "G_所持_IID_てつの晶石";
	private const string Flag_RefineSteel = "G_所持_IID_はがねの晶石";
	private const string Flag_RefineSilver = "G_所持_IID_ぎんの晶石";
	private const string ChallengeRouteFlag = "G_連戦_ルート";
	private const string ChallengeSeedFlag = "G_連戦_乱数";
	private const string ChallengeLevelFlag = "G_連戦_レベル";
	private const string ChallengeBestLevelFlag = "G_連戦_推薦レベル";
	private const string ChallengeOffsetFlag = "G_連戦_オフセット";
	private const string ChallengeTurnFlag = "G_連戦_ターン";
	private const string KeyInvestmentFilene = "G_投資_フィレネ";
	private const string KeyInvestmentBrodia = "G_投資_ブロディア";
	private const string KeyInvestmentIrcion = "G_投資_イルシオン";
	private const string KeyInvestmentSolum = "G_投資_ソルム";
	private static readonly string[] LOCAL_FLAG; // 0x0
	public const string KeyFieldBGM_Changeable = "G_FieldBGM_切替可能";
	private const string Flag_RewindEnable = "G_所持_IID_竜の時水晶";
	private const string Flag_RelianceAPlusPermit = "G_所持_IID_約束の指輪";
	private const string Flag_GetPromiseRing = "G_約束の指輪取得済";

	// Properties
	public GameUserData.StatusField Status { get; }
	public GameUserData.Sequences Sequence { get; set; }
	public GameVariable Variable { get; }
	public int Gold { get; set; }
	public ChapterData Chapter { get; }
	public ChapterRecord ChapterRecord { get; }
	public string GmapSpot { get; set; }
	public GameUserGmapData GmapData { get; }
	public GameUserHubData HubData { get; }
	public int ContentsIndex { get; set; }
	public int Progress { get; set; }
	public int TrainingCount { get; set; }
	public int ArenaCount { get; set; }
	public UnitInfo.Mode UnitInfoMode { get; set; }
	public int RefineIron { get; set; }
	public int RefineSteel { get; set; }
	public int RefineSilver { get; set; }
	public int PieceOfBond { get; set; }
	public int TotalPieceOfBond { get; set; }
	public string MascotName { get; set; }
	public MapEditData MapEditData { get; }
	public RelayUserData RelayData { get; }
	public VersusUserData VersusData { get; }
	public ulong Identifier { get; }
	public static int MinChallengeLevel { get; }
	public static int MaxChallengeLevel { get; }
	public int ChallengeRoute { get; set; }
	public int ChallengeLevel { get; set; }
	public int ChallengeBestLevel { get; set; }
	public int ChallengeSeed { get; set; }
	public int ChallengeOffset { get; set; }
	public int ChallengeTurn { get; set; }
	public int InvestmentFilene { get; set; }
	public int InvestmentBrodia { get; set; }
	public int InvestmentIrcion { get; set; }
	public int InvestmentSolum { get; set; }
	public string FieldBGMPlayer { get; set; }
	public string FieldBGMEnemy { get; set; }
	public bool IsNetLoginOnce { get; set; }
	public bool IsShowNetTerms { get; set; }
	public bool IsShowNetHowToReport { get; set; }
	public bool IsRewindEnable { get; set; }
	public bool IsRelianceAPlusPermit { get; set; }
	public bool IsGetPromiseRing { get; set; }
	public bool CanCCEnchant { get; set; }
	public bool CanCCGunner { get; set; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x28CE290 Offset: 0x28CE391 VA: 0x28CE290
	public GameUserData.StatusField get_Status() { }

	// RVA: 0x28CE2A0 Offset: 0x28CE3A1 VA: 0x28CE2A0
	public GameUserData.Sequences get_Sequence() { }

	// RVA: 0x28CE2B0 Offset: 0x28CE3B1 VA: 0x28CE2B0
	public void set_Sequence(GameUserData.Sequences value) { }

	// RVA: 0x28CE2C0 Offset: 0x28CE3C1 VA: 0x28CE2C0
	public GameVariable get_Variable() { }

	// RVA: 0x28CE2D0 Offset: 0x28CE3D1 VA: 0x28CE2D0
	public int get_Gold() { }

	// RVA: 0x28CE2E0 Offset: 0x28CE3E1 VA: 0x28CE2E0
	public void set_Gold(int value) { }

	// RVA: 0x28CE320 Offset: 0x28CE421 VA: 0x28CE320
	public ChapterData get_Chapter() { }

	// RVA: 0x28CE330 Offset: 0x28CE431 VA: 0x28CE330
	public ChapterRecord get_ChapterRecord() { }

	// RVA: 0x28CE340 Offset: 0x28CE441 VA: 0x28CE340
	public string get_GmapSpot() { }

	// RVA: 0x28CE350 Offset: 0x28CE451 VA: 0x28CE350
	public void set_GmapSpot(string value) { }

	// RVA: 0x28CE360 Offset: 0x28CE461 VA: 0x28CE360
	public GameUserGmapData get_GmapData() { }

	// RVA: 0x28CE370 Offset: 0x28CE471 VA: 0x28CE370
	public GameUserHubData get_HubData() { }

	// RVA: 0x28CE380 Offset: 0x28CE481 VA: 0x28CE380
	public int get_ContentsIndex() { }

	// RVA: 0x28CE390 Offset: 0x28CE491 VA: 0x28CE390
	public void set_ContentsIndex(int value) { }

	// RVA: 0x28CE3A0 Offset: 0x28CE4A1 VA: 0x28CE3A0
	public int get_Progress() { }

	// RVA: 0x28CE3B0 Offset: 0x28CE4B1 VA: 0x28CE3B0
	public void set_Progress(int value) { }

	// RVA: 0x28CE3C0 Offset: 0x28CE4C1 VA: 0x28CE3C0
	public int get_TrainingCount() { }

	// RVA: 0x28CE3D0 Offset: 0x28CE4D1 VA: 0x28CE3D0
	public void set_TrainingCount(int value) { }

	// RVA: 0x28CE3E0 Offset: 0x28CE4E1 VA: 0x28CE3E0
	public int get_ArenaCount() { }

	// RVA: 0x28CE3F0 Offset: 0x28CE4F1 VA: 0x28CE3F0
	public void set_ArenaCount(int value) { }

	// RVA: 0x28CE400 Offset: 0x28CE501 VA: 0x28CE400
	public UnitInfo.Mode get_UnitInfoMode() { }

	// RVA: 0x28CE410 Offset: 0x28CE511 VA: 0x28CE410
	public void set_UnitInfoMode(UnitInfo.Mode value) { }

	// RVA: 0x28CE420 Offset: 0x28CE521 VA: 0x28CE420
	public int get_RefineIron() { }

	// RVA: 0x28CE4D0 Offset: 0x28CE5D1 VA: 0x28CE4D0
	public void set_RefineIron(int value) { }

	// RVA: 0x28CE680 Offset: 0x28CE781 VA: 0x28CE680
	public int get_RefineSteel() { }

	// RVA: 0x28CE730 Offset: 0x28CE831 VA: 0x28CE730
	public void set_RefineSteel(int value) { }

	// RVA: 0x28CE8E0 Offset: 0x28CE9E1 VA: 0x28CE8E0
	public int get_RefineSilver() { }

	// RVA: 0x28CE990 Offset: 0x28CEA91 VA: 0x28CE990
	public void set_RefineSilver(int value) { }

	// RVA: 0x28CEB40 Offset: 0x28CEC41 VA: 0x28CEB40
	public int get_PieceOfBond() { }

	// RVA: 0x28CEB50 Offset: 0x28CEC51 VA: 0x28CEB50
	public void set_PieceOfBond(int value) { }

	// RVA: 0x28CEC00 Offset: 0x28CED01 VA: 0x28CEC00
	public int get_TotalPieceOfBond() { }

	// RVA: 0x28CEBC0 Offset: 0x28CECC1 VA: 0x28CEBC0
	public void set_TotalPieceOfBond(int value) { }

	// RVA: 0x28CEC10 Offset: 0x28CED11 VA: 0x28CEC10
	public void set_MascotName(string value) { }

	// RVA: 0x28CEC20 Offset: 0x28CED21 VA: 0x28CEC20
	public string get_MascotName() { }

	// RVA: 0x28CECC0 Offset: 0x28CEDC1 VA: 0x28CECC0
	public MapEditData get_MapEditData() { }

	// RVA: 0x28CECD0 Offset: 0x28CEDD1 VA: 0x28CECD0
	public RelayUserData get_RelayData() { }

	// RVA: 0x28CECE0 Offset: 0x28CEDE1 VA: 0x28CECE0
	public VersusUserData get_VersusData() { }

	// RVA: 0x28CECF0 Offset: 0x28CEDF1 VA: 0x28CECF0
	public ulong get_Identifier() { }

	// RVA: 0x28CED00 Offset: 0x28CEE01 VA: 0x28CED00
	public static int get_MinChallengeLevel() { }

	// RVA: 0x28CED50 Offset: 0x28CEE51 VA: 0x28CED50
	public static int get_MaxChallengeLevel() { }

	// RVA: 0x28CEE50 Offset: 0x28CEF51 VA: 0x28CEE50
	public int get_ChallengeRoute() { }

	// RVA: 0x28CEF00 Offset: 0x28CF001 VA: 0x28CEF00
	public void set_ChallengeRoute(int value) { }

	// RVA: 0x28CF090 Offset: 0x28CF191 VA: 0x28CF090
	public int get_ChallengeLevel() { }

	// RVA: 0x28CF140 Offset: 0x28CF241 VA: 0x28CF140
	public void set_ChallengeLevel(int value) { }

	// RVA: 0x28CF360 Offset: 0x28CF461 VA: 0x28CF360
	public int get_ChallengeBestLevel() { }

	// RVA: 0x28CF410 Offset: 0x28CF511 VA: 0x28CF410
	public void set_ChallengeBestLevel(int value) { }

	// RVA: 0x28CF630 Offset: 0x28CF731 VA: 0x28CF630
	public int get_ChallengeSeed() { }

	// RVA: 0x28CF6E0 Offset: 0x28CF7E1 VA: 0x28CF6E0
	public void set_ChallengeSeed(int value) { }

	// RVA: 0x28CF870 Offset: 0x28CF971 VA: 0x28CF870
	public int get_ChallengeOffset() { }

	// RVA: 0x28CF920 Offset: 0x28CFA21 VA: 0x28CF920
	public void set_ChallengeOffset(int value) { }

	// RVA: 0x28CFAB0 Offset: 0x28CFBB1 VA: 0x28CFAB0
	public int get_ChallengeTurn() { }

	// RVA: 0x28CFB60 Offset: 0x28CFC61 VA: 0x28CFB60
	public void set_ChallengeTurn(int value) { }

	// RVA: 0x28CFCF0 Offset: 0x28CFDF1 VA: 0x28CFCF0
	public void SetChallenge(ChallengeData data) { }

	// RVA: 0x28CFF40 Offset: 0x28D0041 VA: 0x28CFF40
	public void ResetChallenge() { }

	// RVA: 0x28CFD30 Offset: 0x28CFE31 VA: 0x28CFD30
	private void ResetChallengeSortieCount() { }

	// RVA: 0x28CFF80 Offset: 0x28D0081 VA: 0x28CFF80
	public ChallengeData GetChallengeData() { }

	// RVA: 0x28D0090 Offset: 0x28D0191 VA: 0x28D0090
	public Random GetChallengeRandom() { }

	// RVA: 0x28D0180 Offset: 0x28D0281 VA: 0x28D0180
	private List<ChapterData> GetChallengeChapters() { }

	// RVA: 0x28D01D0 Offset: 0x28D02D1 VA: 0x28D01D0
	public ChapterData GetChallengeChapter(int index) { }

	// RVA: 0x28D0290 Offset: 0x28D0391 VA: 0x28D0290
	public int GetChallengeStage() { }

	// RVA: 0x28D02A0 Offset: 0x28D03A1 VA: 0x28D02A0
	public int GetChallengeStage(ChapterData chapter) { }

	// RVA: 0x28D0380 Offset: 0x28D0481 VA: 0x28D0380
	public List<ItemData> GetChallengeRewardList() { }

	// RVA: 0x28D0460 Offset: 0x28D0561 VA: 0x28D0460
	public int get_InvestmentFilene() { }

	// RVA: 0x28D0520 Offset: 0x28D0621 VA: 0x28D0520
	public void set_InvestmentFilene(int value) { }

	// RVA: 0x28D06D0 Offset: 0x28D07D1 VA: 0x28D06D0
	public int get_InvestmentBrodia() { }

	// RVA: 0x28D0790 Offset: 0x28D0891 VA: 0x28D0790
	public void set_InvestmentBrodia(int value) { }

	// RVA: 0x28D0940 Offset: 0x28D0A41 VA: 0x28D0940
	public int get_InvestmentIrcion() { }

	// RVA: 0x28D0A00 Offset: 0x28D0B01 VA: 0x28D0A00
	public void set_InvestmentIrcion(int value) { }

	// RVA: 0x28D0BB0 Offset: 0x28D0CB1 VA: 0x28D0BB0
	public int get_InvestmentSolum() { }

	// RVA: 0x28D0C70 Offset: 0x28D0D71 VA: 0x28D0C70
	public void set_InvestmentSolum(int value) { }

	// RVA: 0x28D0E20 Offset: 0x28D0F21 VA: 0x28D0E20
	public string get_FieldBGMPlayer() { }

	// RVA: 0x28D0EA0 Offset: 0x28D0FA1 VA: 0x28D0EA0
	public void set_FieldBGMPlayer(string value) { }

	// RVA: 0x28D0F30 Offset: 0x28D1031 VA: 0x28D0F30
	public string get_FieldBGMEnemy() { }

	// RVA: 0x28D0FB0 Offset: 0x28D10B1 VA: 0x28D0FB0
	public void set_FieldBGMEnemy(string value) { }

	// RVA: 0x28D1040 Offset: 0x28D1141 VA: 0x28D1040
	public bool CanChangeFieldBGM() { }

	// RVA: 0x28D1190 Offset: 0x28D1291 VA: 0x28D1190
	public void ResetForGame() { }

	// RVA: 0x28D1830 Offset: 0x28D1931 VA: 0x28D1830
	private void CreateGlobalFlags() { }

	// RVA: 0x28D2660 Offset: 0x28D2761 VA: 0x28D2660
	public void ResetForBeginOfMap() { }

	// RVA: 0x28D26C0 Offset: 0x28D27C1 VA: 0x28D26C0
	public void ResetForEndOfMap() { }

	// RVA: 0x28D2720 Offset: 0x28D2821 VA: 0x28D2720
	public void SetupForChapter(bool isResume) { }

	// RVA: 0x28D2B20 Offset: 0x28D2C21 VA: 0x28D2B20
	public void CleanupForChapter() { }

	// RVA: 0x28D2B10 Offset: 0x28D2C11 VA: 0x28D2B10
	public string GetMessFileName() { }

	// RVA: 0x28D2BC0 Offset: 0x28D2CC1 VA: 0x28D2BC0
	public void SetChapter(ChapterData chapter) { }

	// RVA: 0x28D2C40 Offset: 0x28D2D41 VA: 0x28D2C40
	private void SetGmapSpot(ChapterData chapter) { }

	// RVA: 0x28D2F60 Offset: 0x28D3061 VA: 0x28D2F60
	public void ResetLastScenarioChapter() { }

	// RVA: 0x28D3190 Offset: 0x28D3291 VA: 0x28D3190
	private static string GetRecordPid(Unit unit) { }

	// RVA: 0x28D3210 Offset: 0x28D3311 VA: 0x28D3210
	private static string GetRecordJid(Unit unit) { }

	// RVA: 0x28D3300 Offset: 0x28D3401 VA: 0x28D3300
	private static string GetRecordGid(Unit unit) { }

	// RVA: 0x28D33A0 Offset: 0x28D34A1 VA: 0x28D33A0
	public GameUserData.MapModes GetMapMode() { }

	// RVA: 0x28D3500 Offset: 0x28D3601 VA: 0x28D3500
	public void CompletedChapter() { }

	// RVA: 0x28D4700 Offset: 0x28D4801 VA: 0x28D4700
	private bool CanUpdateHub(GameUserData.MapModes mode) { }

	// RVA: 0x28D45E0 Offset: 0x28D46E1 VA: 0x28D45E0
	public void TryUpdateHub(GameUserData.MapModes mode) { }

	// RVA: 0x28D46F0 Offset: 0x28D47F1 VA: 0x28D46F0
	public void AddEncountCounter(GameUserGmapData.EncountCounterType type) { }

	// RVA: 0x28D4550 Offset: 0x28D4651 VA: 0x28D4550
	public void TryAddEncountCounter(GameUserGmapData.EncountCounterType type) { }

	// RVA: 0x28D2FA0 Offset: 0x28D30A1 VA: 0x28D2FA0
	public ChapterData GetLastScenarioChapter() { }

	// RVA: 0x28D4870 Offset: 0x28D4971 VA: 0x28D4870
	public ChapterData GetNextScenarioChapter() { }

	// RVA: 0x28D4AB0 Offset: 0x28D4BB1 VA: 0x28D4AB0
	public ChapterData GetNextChapter() { }

	// RVA: 0x28D4B70 Offset: 0x28D4C71 VA: 0x28D4B70
	public GameMode GetGameMode() { }

	// RVA: 0x28D4B80 Offset: 0x28D4C81 VA: 0x28D4B80
	public void SetGameMode(GameMode gameMode) { }

	// RVA: 0x28D4B90 Offset: 0x28D4C91 VA: 0x28D4B90
	public Difficulty GetDifficulty(bool isDynamic = True) { }

	// RVA: 0x28D4E10 Offset: 0x28D4F11 VA: 0x28D4E10
	public void SetDifficulty(Difficulty difficulty) { }

	// RVA: 0x28D4E20 Offset: 0x28D4F21 VA: 0x28D4E20
	public Difficulty GetEvilDifficulty() { }

	// RVA: 0x28D4E30 Offset: 0x28D4F31 VA: 0x28D4E30
	public void SetEvilDifficulty(Difficulty difficulty) { }

	// RVA: 0x28D4E40 Offset: 0x28D4F41 VA: 0x28D4E40
	public GrowMode GetGrowMode() { }

	// RVA: 0x28D4EA0 Offset: 0x28D4FA1 VA: 0x28D4EA0
	public void SetGrowMode(GrowMode mode) { }

	// RVA: 0x28D4F30 Offset: 0x28D5031 VA: 0x28D4F30
	public void CommitForGame() { }

	// RVA: 0x28D4FE0 Offset: 0x28D50E1 VA: 0x28D4FE0
	public void SetCompleted(string cid) { }

	// RVA: 0x28D4340 Offset: 0x28D4441 VA: 0x28D4340
	public void SetCompleted(ChapterData chapter) { }

	// RVA: 0x28D5130 Offset: 0x28D5231 VA: 0x28D5130
	public void SetCompletedGame() { }

	// RVA: 0x28D5500 Offset: 0x28D5601 VA: 0x28D5500
	public void ClearCompletedGame() { }

	// RVA: 0x28D5660 Offset: 0x28D5761 VA: 0x28D5660
	public bool IsCompleted(string cid) { }

	// RVA: 0x28D5770 Offset: 0x28D5871 VA: 0x28D5770
	public bool IsCompleted(ChapterData chapter) { }

	// RVA: 0x28D5800 Offset: 0x28D5901 VA: 0x28D5800
	public bool IsCompletedGame() { }

	// RVA: 0x28D5860 Offset: 0x28D5961 VA: 0x28D5860
	public bool IsAllowEarnings() { }

	// RVA: 0x28D5910 Offset: 0x28D5A11 VA: 0x28D5910
	public bool IsOpenSkillMenu() { }

	// RVA: 0x28D5A70 Offset: 0x28D5B71 VA: 0x28D5A70
	public bool IsEncountMap() { }

	// RVA: 0x28D5AD0 Offset: 0x28D5BD1 VA: 0x28D5AD0
	public bool IsTrainingMap() { }

	// RVA: 0x28D5B60 Offset: 0x28D5C61 VA: 0x28D5B60
	public bool IsChallengeMap() { }

	// RVA: 0x28D5B80 Offset: 0x28D5C81 VA: 0x28D5B80
	public bool IsNextContinueMap() { }

	// RVA: 0x28D5C70 Offset: 0x28D5D71 VA: 0x28D5C70
	public bool IsContinuedMap() { }

	// RVA: 0x28D5CD0 Offset: 0x28D5DD1 VA: 0x28D5CD0
	public bool IsRestartMap() { }

	// RVA: 0x28D5D30 Offset: 0x28D5E31 VA: 0x28D5D30
	public bool IsRecollectionMap() { }

	// RVA: 0x28D5D90 Offset: 0x28D5E91 VA: 0x28D5D90
	public bool IsEvilMap() { }

	// RVA: 0x28D5E20 Offset: 0x28D5F21 VA: 0x28D5E20
	public bool IsOppositionMap() { }

	// RVA: 0x28D5E40 Offset: 0x28D5F41 VA: 0x28D5E40
	public bool IsTemporary() { }

	// RVA: 0x28D5EE0 Offset: 0x28D5FE1 VA: 0x28D5EE0
	public static bool ExistsEncountMob(ChapterData chapter) { }

	// RVA: 0x28D5F90 Offset: 0x28D6091 VA: 0x28D5F90
	public void CompleteEncountMap() { }

	// RVA: 0x28D4D00 Offset: 0x28D4E01 VA: 0x28D4D00
	public static Difficulty GetChallengeDifficulty(int level) { }

	// RVA: 0x28D6060 Offset: 0x28D6161 VA: 0x28D6060
	public bool get_IsNetLoginOnce() { }

	// RVA: 0x28D60C0 Offset: 0x28D61C1 VA: 0x28D60C0
	public void set_IsNetLoginOnce(bool value) { }

	// RVA: 0x28D6140 Offset: 0x28D6241 VA: 0x28D6140
	public bool get_IsShowNetTerms() { }

	// RVA: 0x28D6150 Offset: 0x28D6251 VA: 0x28D6150
	public void set_IsShowNetTerms(bool value) { }

	// RVA: 0x28D6160 Offset: 0x28D6261 VA: 0x28D6160
	public bool get_IsShowNetHowToReport() { }

	// RVA: 0x28D6170 Offset: 0x28D6271 VA: 0x28D6170
	public void set_IsShowNetHowToReport(bool value) { }

	// RVA: 0x28D6180 Offset: 0x28D6281 VA: 0x28D6180
	public bool get_IsRewindEnable() { }

	// RVA: 0x28D6230 Offset: 0x28D6331 VA: 0x28D6230
	public void set_IsRewindEnable(bool value) { }

	// RVA: 0x28D6500 Offset: 0x28D6601 VA: 0x28D6500
	public bool get_IsRelianceAPlusPermit() { }

	// RVA: 0x28D65B0 Offset: 0x28D66B1 VA: 0x28D65B0
	public void set_IsRelianceAPlusPermit(bool value) { }

	// RVA: 0x28D6880 Offset: 0x28D6981 VA: 0x28D6880
	public bool get_IsGetPromiseRing() { }

	// RVA: 0x28D6930 Offset: 0x28D6A31 VA: 0x28D6930
	public void set_IsGetPromiseRing(bool value) { }

	// RVA: 0x28D6C00 Offset: 0x28D6D01 VA: 0x28D6C00
	public bool get_CanCCEnchant() { }

	// RVA: 0x28D6C10 Offset: 0x28D6D11 VA: 0x28D6C10
	public void set_CanCCEnchant(bool value) { }

	// RVA: 0x28D6C20 Offset: 0x28D6D21 VA: 0x28D6C20
	public bool get_CanCCGunner() { }

	// RVA: 0x28D6C30 Offset: 0x28D6D31 VA: 0x28D6C30
	public void set_CanCCGunner(bool value) { }

	// RVA: 0x28D6C40 Offset: 0x28D6D41 VA: 0x28D6C40 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x28D6C50 Offset: 0x28D6D51 VA: 0x28D6C50 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x28D7580 Offset: 0x28D7681 VA: 0x28D7580 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x28D9570 Offset: 0x28D9671 VA: 0x28D9570
	public void SerializeForMapHistoryReplay(Stream stream) { }

	// RVA: 0x28D9690 Offset: 0x28D9791 VA: 0x28D9690
	public void DeserializeForMapHistoryReplay(Stream stream) { }

	// RVA: 0x28D9580 Offset: 0x28D9681 VA: 0x28D9580
	public void SerializeForOnline(Stream stream) { }

	// RVA: 0x28D96A0 Offset: 0x28D97A1 VA: 0x28D96A0
	public void DeserializeForOnline(Stream stream) { }

	// RVA: 0x28D9C40 Offset: 0x28D9D41 VA: 0x28D9C40
	public static ProcDesc PSetSequence(GameUserData.Sequences sequence) { }

	// RVA: 0x28D9CB0 Offset: 0x28D9DB1 VA: 0x28D9CB0
	public void .ctor() { }

	// RVA: 0x28DA1E0 Offset: 0x28DA2E1 VA: 0x28DA1E0
	private static void .cctor() { }
}

