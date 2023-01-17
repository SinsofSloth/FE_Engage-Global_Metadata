// Namespace: App
public class NexVersus : SingletonClass<NexVersus> // TypeDefIndex: 12831
{
	// Fields
	private const ushort Period = 7;
	public const uint MaxSearchCount = 20;
	private const uint MaxRatingSlot = 16;
	private NexVersus.Results m_LastResult; // 0x1C
	private string m_LastResultMessage; // 0x20
	private ulong m_LastUploadedDataId; // 0x28
	private VersusServerMetaData m_LastPersistenceMetaData; // 0x30
	private List<NexVersus.RatingData> m_LastPersistenceRatingList; // 0x38
	private ushort m_LastPersistenceDataType; // 0x40
	private DataStore.DataStatus m_LastPersistenceDataStatus; // 0x44
	private VersusServerReplayMetaData m_LastPersistenceReplayMetaData; // 0x48
	private VersusServerReportMetaData m_LastPersistenceReportMetaData; // 0x50

	// Properties
	public NexVersus.Results LastResult { get; }
	public string LastResultMessage { get; }
	public ulong LastUploadedDataId { get; }
	public List<NexVersus.RatingData> LastPersistenceRatingList { get; }
	public ushort LastPersistenceDataType { get; }
	public VersusServerReplayMetaData LastPersistenceReplayMetaData { get; }
	public VersusServerCasualMetaData LastPersistenceCasualMetaData { get; }
	public VersusServerRankedMetaData LastPersistenceRankedMetaData { get; }
	public VersusServerReportMetaData LastPersistenceReportMetaData { get; }
	public DataStore.DataStatus LastPersistenceStatus { get; }

	// Methods

	// RVA: 0x2357960 Offset: 0x2357A61 VA: 0x2357960 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2357A00 Offset: 0x2357B01 VA: 0x2357A00 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x2357A10 Offset: 0x2357B11 VA: 0x2357A10
	public NexVersus.Results get_LastResult() { }

	// RVA: 0x2357A20 Offset: 0x2357B21 VA: 0x2357A20
	public string get_LastResultMessage() { }

	// RVA: 0x2357A30 Offset: 0x2357B31 VA: 0x2357A30
	public ulong get_LastUploadedDataId() { }

	// RVA: 0x2357A40 Offset: 0x2357B41 VA: 0x2357A40
	public List<NexVersus.RatingData> get_LastPersistenceRatingList() { }

	// RVA: 0x2357A50 Offset: 0x2357B51 VA: 0x2357A50
	public ushort get_LastPersistenceDataType() { }

	// RVA: 0x2357A60 Offset: 0x2357B61 VA: 0x2357A60
	public VersusServerReplayMetaData get_LastPersistenceReplayMetaData() { }

	// RVA: 0x2357A70 Offset: 0x2357B71 VA: 0x2357A70
	public VersusServerCasualMetaData get_LastPersistenceCasualMetaData() { }

	// RVA: 0x2357B00 Offset: 0x2357C01 VA: 0x2357B00
	public VersusServerRankedMetaData get_LastPersistenceRankedMetaData() { }

	// RVA: 0x2357B90 Offset: 0x2357C91 VA: 0x2357B90
	public VersusServerReportMetaData get_LastPersistenceReportMetaData() { }

	// RVA: 0x2357BA0 Offset: 0x2357CA1 VA: 0x2357BA0
	public DataStore.DataStatus get_LastPersistenceStatus() { }

	// RVA: 0x2357BB0 Offset: 0x2357CB1 VA: 0x2357BB0
	private void ClearResult() { }

	// RVA: 0x2357C60 Offset: 0x2357D61 VA: 0x2357C60
	public bool IsLastSuccess(bool isDebugLog = False, string title = "") { }

	// RVA: 0x2357C70 Offset: 0x2357D71 VA: 0x2357C70
	public bool IsLastFailed(bool isDebugLog = False, string title = "") { }

	// RVA: 0x2357C80 Offset: 0x2357D81 VA: 0x2357C80
	public bool IsLastCancelled(bool isDebugLog = False, string title = "") { }

	// RVA: 0x2357C90 Offset: 0x2357D91 VA: 0x2357C90
	public void Upload(ProcInst super, string playerName, VersusServerRankedMetaData metaData, VersusServerRankedData data, ushort dataType, byte[] pngBytes) { }

	// RVA: 0x2357D00 Offset: 0x2357E01 VA: 0x2357D00
	public void UploadReplay(ProcInst super, VersusServerReplayMetaData metaData, VersusServerReplayData data, ushort slot) { }

	// RVA: 0x2357D60 Offset: 0x2357E61 VA: 0x2357D60
	public void Upload(ProcInst super, VersusServerCasualMetaData metaData, VersusServerCasualData data) { }

	// RVA: 0x2357DB0 Offset: 0x2357EB1 VA: 0x2357DB0
	public void Search(ProcInst super, List<VersusServerRankedMetaData> results, ushort dataType) { }

	// RVA: 0x2357DF0 Offset: 0x2357EF1 VA: 0x2357DF0
	public void Search(ProcInst super, List<VersusServerCasualMetaData> results) { }

	// RVA: 0x2357E20 Offset: 0x2357F21 VA: 0x2357E20
	public void ChangeMetaDataType(ProcInst super, ulong targetPrincipalId, ushort targetSlotId, ushort dataType) { }

	// RVA: 0x2357E70 Offset: 0x2357F71 VA: 0x2357E70
	public void ChangeMetaDataType(ProcInst super, ulong targetDataId, ushort dataType) { }

	// RVA: 0x2357EB0 Offset: 0x2357FB1 VA: 0x2357EB0
	public void Download(ProcInst super, ulong dataId, VersusServerRankedData result) { }

	// RVA: 0x2357F30 Offset: 0x2358031 VA: 0x2357F30
	public void Download(ProcInst super, ulong dataId, VersusServerCasualData result) { }

	// RVA: 0x2357FB0 Offset: 0x23580B1 VA: 0x2357FB0
	public void DownloadCasualMeta(ProcInst super, ulong dataId) { }

	// RVA: 0x2358030 Offset: 0x2358131 VA: 0x2358030
	public void DownloadRankedMeta(ProcInst super, ulong dataId) { }

	// RVA: 0x23580B0 Offset: 0x23581B1 VA: 0x23580B0
	public void Download(ProcInst super, ulong dataId, VersusServerReplayData result) { }

	// RVA: 0x23580F0 Offset: 0x23581F1 VA: 0x23580F0
	public void AddRatingValue(ProcInst super, ulong dataId, Versus.MapResult mapResult) { }

	// RVA: 0x2358130 Offset: 0x2358231 VA: 0x2358130
	public void GetCasualMetaDataFromPersistenceSlot(ProcInst super) { }

	// RVA: 0x23581A0 Offset: 0x23582A1 VA: 0x23581A0
	public void GetRankedMetaDataFromPersistenceSlot(ProcInst super) { }

	// RVA: 0x23581D0 Offset: 0x23582D1 VA: 0x23581D0
	public void GetReplayMetaDataFromPersistenceSlot(ProcInst super, ulong principalId, ushort slotId, NexVersus.ReplaySlotMetaResultData result) { }

	// RVA: 0x2358280 Offset: 0x2358381 VA: 0x2358280
	public void GetAllReplayMetaDataFromPersistenceSlot(ProcInst super, ulong principalId, NexVersus.ReplaySlotMetaResultData result) { }

	// RVA: 0x2358320 Offset: 0x2358421 VA: 0x2358320
	public void GetCasualMetaDataListFromPersistenceSlot(ProcInst super, List<ulong> principalIdList, List<VersusServerCasualMetaData> resultDataList) { }

	// RVA: 0x23583A0 Offset: 0x23584A1 VA: 0x23583A0
	public void GetRankedMetaDataListFromPersistenceSlot(ProcInst super, List<ulong> principalIdList, List<VersusServerRankedMetaData> resultDataList, List<List<NexVersus.RatingData>> resultRatingList) { }

	// RVA: 0x2358430 Offset: 0x2358531 VA: 0x2358430
	public void Change(ProcInst super, ulong dataId, VersusServerCasualData data) { }

	// RVA: 0x23584B0 Offset: 0x23585B1 VA: 0x23584B0
	public void Change(ProcInst super, ulong dataId, VersusServerRankedData data) { }

	// RVA: 0x2358530 Offset: 0x2358631 VA: 0x2358530
	public void ChangeMeta(ProcInst super, ulong dataId, VersusServerRankedMetaData metaData, string playerName) { }

	// RVA: 0x2358580 Offset: 0x2358681 VA: 0x2358580
	public void ChangeMeta(ProcInst super, ulong dataId, VersusServerRankedMetaData metaData) { }

	// RVA: 0x23585D0 Offset: 0x23586D1 VA: 0x23585D0
	public void ChangeReplayMeta(ProcInst super, ulong dataId, VersusServerReplayMetaData metaData, bool isSetMetaPatam, bool isShowDialog = True) { }

	// RVA: 0x2358630 Offset: 0x2358731 VA: 0x2358630
	public void ChangeReplayMeta(ProcInst super, ulong principalId, ushort slotId, VersusServerReplayMetaData metaData, bool isSetMetaParam, bool isShowDialog = True) { }

	// RVA: 0x2358690 Offset: 0x2358791 VA: 0x2358690
	public void ChangeReplay(ProcInst super, VersusServerReplayMetaData metaData, VersusServerReplayData data) { }

	// RVA: 0x23586D0 Offset: 0x23587D1 VA: 0x23586D0
	public void ReportOpponent(ProcInst super, ulong dataId, ulong screenshotId, Screening.ReportCategory category, string reason, string language, bool isNotSendSucceed = False) { }

	// RVA: 0x2358740 Offset: 0x2358841 VA: 0x2358740
	public bool TryGetPrincipalId(out ulong principalId) { }

	// RVA: 0x2358770 Offset: 0x2358871 VA: 0x2358770
	public string DataId2DataCode(ulong dataId) { }

	// RVA: 0x23587B0 Offset: 0x23588B1 VA: 0x23587B0
	public ulong DataCode2DataId(string dataCode) { }

	// RVA: 0x23587C0 Offset: 0x23588C1 VA: 0x23587C0
	private static string GetDataTypeName(ushort dataType) { }

	// RVA: 0x23589D0 Offset: 0x2358AD1 VA: 0x23589D0
	public void UploadReport(ProcInst super, VersusServerReportMetaData metaData, NexVersus.UploadType type) { }

	// RVA: 0x2358A10 Offset: 0x2358B11 VA: 0x2358A10
	public void CheckAccessibleCasualSlot(ProcInst super, NexVersus.TargetSlotList targetInfoList, NexVersus.EndCallback endCallback) { }

	// RVA: 0x2358A60 Offset: 0x2358B61 VA: 0x2358A60
	public void CheckAccessibleRankedSlot(ProcInst super, NexVersus.TargetSlotList targetInfoList, NexVersus.EndCallback endCallback) { }

	// RVA: 0x2358AB0 Offset: 0x2358BB1 VA: 0x2358AB0
	public void DownloadCasualMetaPrincipalID(ProcInst super, ulong principalID, NexVersus.CasualMetaDataEndCallback endCallback) { }

	// RVA: 0x2358BD0 Offset: 0x2358CD1 VA: 0x2358BD0
	public void DownloadRankedMetaPrincipalID(ProcInst super, ulong principalID, NexVersus.RankedMetaDataEndCallback endCallback) { }

	// RVA: 0x2358CF0 Offset: 0x2358DF1 VA: 0x2358CF0
	public void .ctor() { }
}

