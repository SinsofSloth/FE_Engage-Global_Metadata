// Namespace: App
public class Versus : SingletonClass<Versus> // TypeDefIndex: 13760
{
	// Fields
	private VersusServerRankedMetaData m_PlayerMetaData; // 0x20
	private VersusServerRankedData m_PlayerData; // 0x28
	private List<NexVersus.RatingData> m_PlayerRatingList; // 0x30
	private VersusServerRankedMetaData m_OpponentMetaData; // 0x38
	private VersusServerRankedData m_OpponentData; // 0x40
	private VersusServerReplayData m_ReplayData; // 0x48
	private VersusServerReplayMetaData m_ReplayMetaData; // 0x50
	private VersusServerCasualMetaData m_CasualOpponentMetaData; // 0x58
	private VersusServerCasualData m_CasualOpponentData; // 0x60
	private VersusServerCasualData m_CasualPlayerData; // 0x68
	private VersusServerCasualMetaData m_CasualPlayerMetaData; // 0x70
	private VersusBackupData m_BackupData; // 0x78
	private VersusEditModeBackupData m_EditBackupData; // 0x80
	private Versus.Mode m_Mode; // 0x88
	private Versus.MatchingType m_MatchingType; // 0x8C
	private Versus.Error m_Error; // 0x90
	private Versus.MapResult m_Result; // 0x94
	private bool m_IsSurrender; // 0x98
	private int m_CasualMapNumber; // 0x9C
	public static readonly int ReplaySlotCount; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x29CB00 Offset: 0x29CC01 VA: 0x29CB00
	private ChapterData <ReturnChapter>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x29CB10 Offset: 0x29CC11 VA: 0x29CB10
	private bool <IsSucceedDeserializeCasual>k__BackingField; // 0xA8
	private bool m_IsExistOnServer; // 0xA9
	[CompilerGeneratedAttribute] // RVA: 0x29CB20 Offset: 0x29CC21 VA: 0x29CB20
	private bool <IsUploadDifferentSaveID>k__BackingField; // 0xAA
	[CompilerGeneratedAttribute] // RVA: 0x29CB30 Offset: 0x29CC31 VA: 0x29CB30
	private static bool <IsForceEditDataOverwrite>k__BackingField; // 0x4
	private Versus.DownloadHistory m_History; // 0xB0

	// Properties
	public VersusServerRankedMetaData PlayerMetaData { get; }
	public VersusServerRankedData PlayerData { get; }
	public VersusServerRankedMetaData OpponentMetaData { get; }
	public VersusServerRankedData OpponentData { get; }
	public VersusServerReplayData ReplayData { get; }
	public VersusServerReplayMetaData ReplayMetaData { get; }
	public VersusServerCasualMetaData CasualOpponentMetaData { get; }
	public VersusServerCasualData CasualOpponentData { get; }
	public VersusServerCasualData CasualPlayerData { get; }
	public VersusServerCasualMetaData CasualPlayerMetaData { get; }
	public ChapterData ReturnChapter { get; set; }
	public Versus.MapResult Result { get; }
	public Versus.MapResult OpponentResult { get; }
	public bool IsSurrender { get; }
	public Versus.Mode VersusMode { get; }
	public Versus.MatchingType Matching { get; }
	public Versus.Error ResultError { get; }
	public int CasualMapNumber { get; }
	public bool IsSucceedDeserializeCasual { get; set; }
	public bool IsExistRankedOnServer { get; set; }
	public bool IsUploadDifferentSaveID { get; set; }
	public static bool IsForceEditDataOverwrite { get; set; }
	public Versus.DownloadHistory History { get; }

	// Methods

	// RVA: 0x2A448D0 Offset: 0x2A449D1 VA: 0x2A448D0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2A450E0 Offset: 0x2A451E1 VA: 0x2A450E0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x2A45140 Offset: 0x2A45241 VA: 0x2A45140
	public static bool IsValid() { }

	// RVA: 0x2A45640 Offset: 0x2A45741 VA: 0x2A45640
	public static bool IsVersusMode() { }

	// RVA: 0x2A45250 Offset: 0x2A45351 VA: 0x2A45250
	public static bool IsCasual() { }

	// RVA: 0x2A45320 Offset: 0x2A45421 VA: 0x2A45320
	public static bool IsRanked() { }

	// RVA: 0x2A45570 Offset: 0x2A45671 VA: 0x2A45570
	public static bool IsMockBattle() { }

	// RVA: 0x2A453F0 Offset: 0x2A454F1 VA: 0x2A453F0
	public static bool IsEditMode() { }

	// RVA: 0x2A454C0 Offset: 0x2A455C1 VA: 0x2A454C0
	public static bool IsReplay() { }

	// RVA: 0x2A45830 Offset: 0x2A45931 VA: 0x2A45830
	public bool CanSortieRanked(Unit unit) { }

	// RVA: 0x2A459C0 Offset: 0x2A45AC1 VA: 0x2A459C0
	public bool CanSortieRanked(GodUnit god) { }

	// RVA: 0x2A45AB0 Offset: 0x2A45BB1 VA: 0x2A45AB0
	public void SaveCasualUnits() { }

	// RVA: 0x2A45AC0 Offset: 0x2A45BC1 VA: 0x2A45AC0
	public void SaveCasualUnitsInit() { }

	// RVA: 0x2A45CD0 Offset: 0x2A45DD1 VA: 0x2A45CD0
	public void MapEndEdit() { }

	// RVA: 0x2A45DC0 Offset: 0x2A45EC1 VA: 0x2A45DC0
	public void ResetResult() { }

	// RVA: 0x2A45DE0 Offset: 0x2A45EE1 VA: 0x2A45DE0
	public void SetAbort() { }

	// RVA: 0x2A45DF0 Offset: 0x2A45EF1 VA: 0x2A45DF0
	public void SetSurrender() { }

	// RVA: 0x2A45E00 Offset: 0x2A45F01 VA: 0x2A45E00
	public void SetResultReport() { }

	// RVA: 0x2A45E10 Offset: 0x2A45F11 VA: 0x2A45E10
	public void SetError(Versus.Error error) { }

	// RVA: 0x2A45E20 Offset: 0x2A45F21 VA: 0x2A45E20
	public void MapEndVersus() { }

	// RVA: 0x2A45F70 Offset: 0x2A46071 VA: 0x2A45F70
	private void MapEndVersusCasual() { }

	// RVA: 0x2A45F80 Offset: 0x2A46081 VA: 0x2A45F80
	private void MapEndVersusRanked() { }

	// RVA: 0x2A46340 Offset: 0x2A46441 VA: 0x2A46340
	public void ResetGodPoolId() { }

	// RVA: 0x2A46480 Offset: 0x2A46581 VA: 0x2A46480
	public bool IsExitsOnlineNode() { }

	// RVA: 0x2A46960 Offset: 0x2A46A61 VA: 0x2A46960
	public void MapEndReplay() { }

	// RVA: 0x2A45CE0 Offset: 0x2A45DE1 VA: 0x2A45CE0
	private void RestoreStoryChapter() { }

	// RVA: 0x2A46970 Offset: 0x2A46A71 VA: 0x2A46970
	public bool TrySetPlayerMetaData(VersusServerRankedMetaData metaData) { }

	// RVA: 0x2A46A80 Offset: 0x2A46B81 VA: 0x2A46A80
	public void SetPlayerMetaData(VersusServerCasualMetaData metaData) { }

	// RVA: 0x2A46A90 Offset: 0x2A46B91 VA: 0x2A46A90
	public void SetOpponentMetaData(VersusServerRankedMetaData metaData) { }

	// RVA: 0x2A46AA0 Offset: 0x2A46BA1 VA: 0x2A46AA0
	public void SetOpponentMetaData(VersusServerCasualMetaData metaData) { }

	// RVA: 0x2A46AB0 Offset: 0x2A46BB1 VA: 0x2A46AB0
	public void SetPlayerRatingList(List<NexVersus.RatingData> ratingList) { }

	// RVA: 0x2A46B20 Offset: 0x2A46C21 VA: 0x2A46B20
	public void SetMode(Versus.Mode mode) { }

	// RVA: 0x2A46B30 Offset: 0x2A46C31 VA: 0x2A46B30
	public void SetCasualMap(int mapNumber) { }

	// RVA: 0x2A46B40 Offset: 0x2A46C41 VA: 0x2A46B40
	public void SetMatchingType(Versus.MatchingType type) { }

	// RVA: 0x2A46B50 Offset: 0x2A46C51 VA: 0x2A46B50
	public bool IsHavePlayerEditData() { }

	// RVA: 0x2A46BF0 Offset: 0x2A46CF1 VA: 0x2A46BF0
	public bool IsSavedLocalEditData() { }

	// RVA: 0x2A46C80 Offset: 0x2A46D81 VA: 0x2A46C80
	public bool IsUseServerEditDataForBattle() { }

	// RVA: 0x2A46D50 Offset: 0x2A46E51 VA: 0x2A46D50
	public bool IsUseServerEditDataForEdit() { }

	// RVA: 0x2A459B0 Offset: 0x2A45AB1 VA: 0x2A459B0
	public MapEditData GetMyMapEditDataForBattle() { }

	// RVA: 0x2A46E50 Offset: 0x2A46F51 VA: 0x2A46E50
	public MapEditData GetMyMapEditDataForEdit() { }

	// RVA: 0x2A46EF0 Offset: 0x2A46FF1 VA: 0x2A46EF0
	public string GetSortieTitle() { }

	// RVA: 0x2A470D0 Offset: 0x2A471D1 VA: 0x2A470D0
	public bool TryGetOpponentInfo(out string name, out ulong principalID) { }

	// RVA: 0x2A47180 Offset: 0x2A47281 VA: 0x2A47180
	private bool IsUseBackup() { }

	// RVA: 0x2A471F0 Offset: 0x2A472F1 VA: 0x2A471F0
	public void SerializeBackup() { }

	// RVA: 0x2A474A0 Offset: 0x2A475A1 VA: 0x2A474A0
	public void DeserializeBackup() { }

	// RVA: 0x2A47A50 Offset: 0x2A47B51 VA: 0x2A47A50
	public static int GetCasualSortieMax() { }

	// RVA: 0x2A47A60 Offset: 0x2A47B61 VA: 0x2A47A60
	public static int GetOffenseSortieMax() { }

	// RVA: 0x2A47B50 Offset: 0x2A47C51 VA: 0x2A47B50
	public static int GetDefenseSortieMax() { }

	// RVA: 0x2A47C40 Offset: 0x2A47D41 VA: 0x2A47C40
	public VersusServerRankedMetaData get_PlayerMetaData() { }

	// RVA: 0x2A47C50 Offset: 0x2A47D51 VA: 0x2A47C50
	public VersusServerRankedData get_PlayerData() { }

	// RVA: 0x2A47C60 Offset: 0x2A47D61 VA: 0x2A47C60
	public VersusServerRankedMetaData get_OpponentMetaData() { }

	// RVA: 0x2A47C70 Offset: 0x2A47D71 VA: 0x2A47C70
	public VersusServerRankedData get_OpponentData() { }

	// RVA: 0x2A47C80 Offset: 0x2A47D81 VA: 0x2A47C80
	public VersusServerReplayData get_ReplayData() { }

	// RVA: 0x2A47C90 Offset: 0x2A47D91 VA: 0x2A47C90
	public VersusServerReplayMetaData get_ReplayMetaData() { }

	// RVA: 0x2A47CA0 Offset: 0x2A47DA1 VA: 0x2A47CA0
	public VersusServerCasualMetaData get_CasualOpponentMetaData() { }

	// RVA: 0x2A47CB0 Offset: 0x2A47DB1 VA: 0x2A47CB0
	public VersusServerCasualData get_CasualOpponentData() { }

	// RVA: 0x2A47CC0 Offset: 0x2A47DC1 VA: 0x2A47CC0
	public VersusServerCasualData get_CasualPlayerData() { }

	// RVA: 0x2A47CD0 Offset: 0x2A47DD1 VA: 0x2A47CD0
	public VersusServerCasualMetaData get_CasualPlayerMetaData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD310 Offset: 0x2CD411 VA: 0x2CD310
	// RVA: 0x2A47CE0 Offset: 0x2A47DE1 VA: 0x2A47CE0
	public ChapterData get_ReturnChapter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD320 Offset: 0x2CD421 VA: 0x2CD320
	// RVA: 0x2A47CF0 Offset: 0x2A47DF1 VA: 0x2A47CF0
	public void set_ReturnChapter(ChapterData value) { }

	// RVA: 0x2A47D00 Offset: 0x2A47E01 VA: 0x2A47D00
	public Versus.MapResult get_Result() { }

	// RVA: 0x2A47D10 Offset: 0x2A47E11 VA: 0x2A47D10
	public Versus.MapResult get_OpponentResult() { }

	// RVA: 0x2A47D20 Offset: 0x2A47E21 VA: 0x2A47D20
	public bool get_IsSurrender() { }

	// RVA: 0x2A47D30 Offset: 0x2A47E31 VA: 0x2A47D30
	public Versus.Mode get_VersusMode() { }

	// RVA: 0x2A47D40 Offset: 0x2A47E41 VA: 0x2A47D40
	public Versus.MatchingType get_Matching() { }

	// RVA: 0x2A47D50 Offset: 0x2A47E51 VA: 0x2A47D50
	public Versus.Error get_ResultError() { }

	// RVA: 0x2A47D60 Offset: 0x2A47E61 VA: 0x2A47D60
	public int get_CasualMapNumber() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD330 Offset: 0x2CD431 VA: 0x2CD330
	// RVA: 0x2A47D70 Offset: 0x2A47E71 VA: 0x2A47D70
	public bool get_IsSucceedDeserializeCasual() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD340 Offset: 0x2CD441 VA: 0x2CD340
	// RVA: 0x2A47D80 Offset: 0x2A47E81 VA: 0x2A47D80
	public void set_IsSucceedDeserializeCasual(bool value) { }

	// RVA: 0x2A47D90 Offset: 0x2A47E91 VA: 0x2A47D90
	public bool get_IsExistRankedOnServer() { }

	// RVA: 0x2A47DA0 Offset: 0x2A47EA1 VA: 0x2A47DA0
	private void set_IsExistRankedOnServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD350 Offset: 0x2CD451 VA: 0x2CD350
	// RVA: 0x2A47DB0 Offset: 0x2A47EB1 VA: 0x2A47DB0
	public bool get_IsUploadDifferentSaveID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD360 Offset: 0x2CD461 VA: 0x2CD360
	// RVA: 0x2A47DC0 Offset: 0x2A47EC1 VA: 0x2A47DC0
	public void set_IsUploadDifferentSaveID(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD370 Offset: 0x2CD471 VA: 0x2CD370
	// RVA: 0x2A47DD0 Offset: 0x2A47ED1 VA: 0x2A47DD0
	public static bool get_IsForceEditDataOverwrite() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD380 Offset: 0x2CD481 VA: 0x2CD380
	// RVA: 0x2A47E40 Offset: 0x2A47F41 VA: 0x2A47E40
	public static void set_IsForceEditDataOverwrite(bool value) { }

	// RVA: 0x2A47EC0 Offset: 0x2A47FC1 VA: 0x2A47EC0
	public static bool CheckValid() { }

	// RVA: 0x2A47ED0 Offset: 0x2A47FD1 VA: 0x2A47ED0
	public Versus.DownloadHistory get_History() { }

	// RVA: 0x2A47EE0 Offset: 0x2A47FE1 VA: 0x2A47EE0
	public void .ctor() { }

	// RVA: 0x2A47F60 Offset: 0x2A48061 VA: 0x2A47F60
	private static void .cctor() { }
}

