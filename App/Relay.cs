// Namespace: App
internal class Relay : SingletonClass<Relay> // TypeDefIndex: 12937
{
	// Fields
	private RelayServerMetaData m_MetaData; // 0x20
	private RelayServerData m_Data; // 0x28
	private RelayServerMetaData m_SelectedMetaData; // 0x30
	private RelayBackupData m_BackupDataForReplay; // 0x38
	private RelayBackupData m_BackupDataForAll; // 0x40
	private RelayUserData m_CopiedUserData; // 0x48
	private Relay.Modes m_Mode; // 0x50
	private Relay.FlagsField m_Flag; // 0x58
	private Dictionary<string, int> m_DisposPlayerCounts; // 0x60
	private RelaySortie m_Sortie; // 0x68
	private List<Unit> m_AppearanceUnits; // 0x70
	private List<Unit> m_LeavingUnits; // 0x78
	private int m_MaxTurn; // 0x80
	private int m_LimitTurn; // 0x84
	private int m_CurrentPlayerIndex; // 0x88
	private RelayUserData.EnteredBattle m_CurrentBattle; // 0x90
	private int m_ReplayPlayerIndex; // 0x98
	private GameParam.Holder m_PlayingTermHolder; // 0xA0
	private List<string> m_PoolUnits; // 0xA8
	private List<string> m_PoolGods; // 0xB0

	// Properties
	public RelayServerMetaData MetaData { get; }
	public RelayServerData Data { get; }
	public RelayServerMetaData SelectedMetaData { get; }
	public RelayBackupData BackupDataForReplay { get; }
	public RelayBackupData BackupDataForAll { get; }
	public Relay.FlagsField Flag { get; }
	public bool IsNew { get; }
	public bool IsTakeOver { get; }
	public bool IsReplay { get; }
	public int MaxTurn { get; }
	public int LimitTurn { get; }
	public RelaySortie Sortie { get; }
	public List<Unit> AppearanceUnits { get; }
	public List<Unit> LeavingUnits { get; }
	public int CurrentPlayerIndex { get; set; }
	public RelayUserData.EnteredBattle CurrentBattle { get; }
	public List<string> PoolUnits { get; }
	public List<string> PoolGods { get; }

	// Methods

	// RVA: 0x2537230 Offset: 0x2537331 VA: 0x2537230
	public static bool IsValid() { }

	// RVA: 0x25372B0 Offset: 0x25373B1 VA: 0x25372B0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2537770 Offset: 0x2537871 VA: 0x2537770
	public void DisposPlayerCounts(ProcInst super) { }

	// RVA: 0x25377F0 Offset: 0x25378F1 VA: 0x25377F0
	public bool CanSelectNew(string cid) { }

	// RVA: 0x25378A0 Offset: 0x25379A1 VA: 0x25378A0
	public bool CanSelectTakeOver(RelayServerMetaData metaData, ulong principalId, long currentUnixTime, out Relay.CstoResult result) { }

	// RVA: 0x2537AB0 Offset: 0x2537BB1 VA: 0x2537AB0
	public void InitializeForNew(string cid) { }

	// RVA: 0x2538320 Offset: 0x2538421 VA: 0x2538320
	public void InitializeForTakeOver(RelayServerMetaData metaData) { }

	// RVA: 0x2538520 Offset: 0x2538621 VA: 0x2538520
	public void InitializeForReplay(RelayServerMetaData metaData, bool reinitMeta = False) { }

	// RVA: 0x2538710 Offset: 0x2538811 VA: 0x2538710
	public Relay.TrfrResult TryReinitializeForReplay(RelayServerMetaData newMetaData) { }

	// RVA: 0x2538790 Offset: 0x2538891 VA: 0x2538790
	public void SetPlayingDone() { }

	// RVA: 0x25387F0 Offset: 0x25388F1 VA: 0x25387F0
	public void DeleteGodLink() { }

	// RVA: 0x2538AD0 Offset: 0x2538BD1 VA: 0x2538AD0
	public void InitializeForSortie() { }

	// RVA: 0x2538B50 Offset: 0x2538C51 VA: 0x2538B50
	public void SetupForSortie() { }

	// RVA: 0x2538B60 Offset: 0x2538C61 VA: 0x2538B60
	public void GetSortieCount(out int maxTotalCount, out int reqPlayerCount) { }

	// RVA: 0x25379D0 Offset: 0x2537AD1 VA: 0x25379D0
	public void GetSortieCount(Relay.Modes mode, string cid, List<string> pids, out int maxTotalCount, out int reqPlayerCount, out int playerCount, out int playerNoSortieCount) { }

	// RVA: 0x2538BB0 Offset: 0x2538CB1 VA: 0x2538BB0
	private void GetSortieCountFromData(Relay.Modes mode, string cid, out int maxTotalCount, out int reqPlayerCount) { }

	// RVA: 0x2538CE0 Offset: 0x2538DE1 VA: 0x2538CE0
	private void GetPlayerUnitCount(Relay.Modes mode, List<string> pids, out int unitCount, out int noSortieUnitCount) { }

	// RVA: 0x2538DF0 Offset: 0x2538EF1 VA: 0x2538DF0
	public void DecideToBattle() { }

	// RVA: 0x2539890 Offset: 0x2539991 VA: 0x2539890
	public void MapBegin() { }

	// RVA: 0x25399E0 Offset: 0x2539AE1 VA: 0x25399E0
	public void MapEnd() { }

	// RVA: 0x2539D20 Offset: 0x2539E21 VA: 0x2539D20
	public void Complete() { }

	// RVA: 0x253A670 Offset: 0x253A771 VA: 0x253A670
	public void GameOver() { }

	// RVA: 0x253A6C0 Offset: 0x253A7C1 VA: 0x253A6C0
	public void AddEnteredBattle(RelayUserData.EnteredBattle newBattle) { }

	// RVA: 0x253A6D0 Offset: 0x253A7D1 VA: 0x253A6D0
	public RelayUserData.EnteredBattle GetEnteredBattle(ulong dataId) { }

	// RVA: 0x253A6E0 Offset: 0x253A7E1 VA: 0x253A6E0
	public void ClearCurrentBattle() { }

	// RVA: 0x253A6F0 Offset: 0x253A7F1 VA: 0x253A6F0
	public string GetPlayerName(int playerIndex) { }

	// RVA: 0x253A850 Offset: 0x253A951 VA: 0x253A850
	public string GetLastPlayerName() { }

	// RVA: 0x253A8A0 Offset: 0x253A9A1 VA: 0x253A8A0
	public string GetReplayPlayerName() { }

	// RVA: 0x253A8B0 Offset: 0x253A9B1 VA: 0x253A8B0
	public void NextReplayPlayer() { }

	// RVA: 0x253A930 Offset: 0x253AA31 VA: 0x253A930
	public void SetReplayPlayerForSkip(int playerIndex) { }

	[ConditionalAttribute] // RVA: 0x2CA240 Offset: 0x2CA341 VA: 0x2CA240
	// RVA: 0x253A9B0 Offset: 0x253AAB1 VA: 0x253A9B0
	public void DbgFakeAwardee() { }

	// RVA: 0x253ACD0 Offset: 0x253ADD1 VA: 0x253ACD0
	public static bool IsMyUnit(Unit unit) { }

	// RVA: 0x253AD40 Offset: 0x253AE41 VA: 0x253AD40
	public static bool IsOthersUnit(Unit unit) { }

	// RVA: 0x253ADB0 Offset: 0x253AEB1 VA: 0x253ADB0
	public static bool IsNoCountUnit(Unit unit) { }

	// RVA: 0x253A7D0 Offset: 0x253A8D1 VA: 0x253A7D0
	public static string GetNickname() { }

	// RVA: 0x253AE70 Offset: 0x253AF71 VA: 0x253AE70
	public RelayServerMetaData get_MetaData() { }

	// RVA: 0x253AE80 Offset: 0x253AF81 VA: 0x253AE80
	public RelayServerData get_Data() { }

	// RVA: 0x253AE90 Offset: 0x253AF91 VA: 0x253AE90
	public RelayServerMetaData get_SelectedMetaData() { }

	// RVA: 0x253AEA0 Offset: 0x253AFA1 VA: 0x253AEA0
	public RelayBackupData get_BackupDataForReplay() { }

	// RVA: 0x253AEB0 Offset: 0x253AFB1 VA: 0x253AEB0
	public RelayBackupData get_BackupDataForAll() { }

	// RVA: 0x253AEC0 Offset: 0x253AFC1 VA: 0x253AEC0
	public Relay.FlagsField get_Flag() { }

	// RVA: 0x253AED0 Offset: 0x253AFD1 VA: 0x253AED0
	public bool get_IsNew() { }

	// RVA: 0x253AEE0 Offset: 0x253AFE1 VA: 0x253AEE0
	public bool get_IsTakeOver() { }

	// RVA: 0x253AEF0 Offset: 0x253AFF1 VA: 0x253AEF0
	public bool get_IsReplay() { }

	// RVA: 0x253AF00 Offset: 0x253B001 VA: 0x253AF00
	public int get_MaxTurn() { }

	// RVA: 0x253AF10 Offset: 0x253B011 VA: 0x253AF10
	public int get_LimitTurn() { }

	// RVA: 0x253AF20 Offset: 0x253B021 VA: 0x253AF20
	public RelaySortie get_Sortie() { }

	// RVA: 0x253AF30 Offset: 0x253B031 VA: 0x253AF30
	public List<Unit> get_AppearanceUnits() { }

	// RVA: 0x253AF40 Offset: 0x253B041 VA: 0x253AF40
	public List<Unit> get_LeavingUnits() { }

	// RVA: 0x253AF50 Offset: 0x253B051 VA: 0x253AF50
	public int get_CurrentPlayerIndex() { }

	// RVA: 0x253AF60 Offset: 0x253B061 VA: 0x253AF60
	public void set_CurrentPlayerIndex(int value) { }

	// RVA: 0x253AF70 Offset: 0x253B071 VA: 0x253AF70
	public RelayUserData.EnteredBattle get_CurrentBattle() { }

	// RVA: 0x253AF80 Offset: 0x253B081 VA: 0x253AF80
	public List<string> get_PoolUnits() { }

	// RVA: 0x253AF90 Offset: 0x253B091 VA: 0x253AF90
	public List<string> get_PoolGods() { }

	// RVA: 0x253AFA0 Offset: 0x253B0A1 VA: 0x253AFA0
	public static RelayStampData.Kinds ConvertToKinds(PersonData.Country country) { }

	// RVA: 0x25391E0 Offset: 0x25392E1 VA: 0x25391E0
	private void DeleteUnneededUnits() { }

	// RVA: 0x2539350 Offset: 0x2539451 VA: 0x2539350
	private void DeleteUnneededGodUnitsAndBonds() { }

	// RVA: 0x2539670 Offset: 0x2539771 VA: 0x2539670
	private void DeleteUnneededRings() { }

	// RVA: 0x2539D80 Offset: 0x2539E81 VA: 0x2539D80
	private void ChooseAwardee() { }

	// RVA: 0x2537C50 Offset: 0x2537D51 VA: 0x2537C50
	private void Clear() { }

	// RVA: 0x2537EE0 Offset: 0x2537FE1 VA: 0x2537EE0
	private void SaveTempPoolUnit() { }

	// RVA: 0x2537D70 Offset: 0x2537E71 VA: 0x2537D70
	private static int GetMaxTurnFromRelayData(string cid) { }

	// RVA: 0x2537E20 Offset: 0x2537F21 VA: 0x2537E20
	private static int GetPlayTurnFromRelayData(string cid, bool isNew) { }

	[ConditionalAttribute] // RVA: 0x2CA280 Offset: 0x2CA381 VA: 0x2CA280
	// RVA: 0x253B550 Offset: 0x253B651 VA: 0x253B550
	private void DbgLogBegin() { }

	[ConditionalAttribute] // RVA: 0x2CA2C0 Offset: 0x2CA3C1 VA: 0x2CA2C0
	// RVA: 0x253B570 Offset: 0x253B671 VA: 0x253B570
	private void DbgLogEnd() { }

	[ConditionalAttribute] // RVA: 0x2CA300 Offset: 0x2CA401 VA: 0x2CA300
	// RVA: 0x253B590 Offset: 0x253B691 VA: 0x253B590
	private void DbgLogAppendLine(string str) { }

	// RVA: 0x253B560 Offset: 0x253B661 VA: 0x253B560
	private void DbgLogBeginImpl() { }

	// RVA: 0x253B580 Offset: 0x253B681 VA: 0x253B580
	private void DbgLogEndImpl() { }

	// RVA: 0x253B5A0 Offset: 0x253B6A1 VA: 0x253B5A0
	private void DbgLogAppendLineImpl(string str) { }

	// RVA: 0x253B5B0 Offset: 0x253B6B1 VA: 0x253B5B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA340 Offset: 0x2CA441 VA: 0x2CA340
	// RVA: 0x253B630 Offset: 0x253B731 VA: 0x253B630
	private void <DecideToBattle>b__43_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA350 Offset: 0x2CA451 VA: 0x2CA350
	// RVA: 0x253B7D0 Offset: 0x253B8D1 VA: 0x253B7D0
	private void <MapEnd>b__45_0(Unit unit) { }
}

