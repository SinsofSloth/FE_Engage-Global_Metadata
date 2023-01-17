// Namespace: 
public enum NexVersus.Results // TypeDefIndex: 12766
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.Results Failed = 0;
	public const NexVersus.Results Succeeded = 1;
	public const NexVersus.Results Cancelled = 2;
	public const NexVersus.Results FailedNotFound = 3;
	public const NexVersus.Results FailedDifferentType = 4;
}

// Namespace: 
private class NexVersus.NexSequenceBase.ConfirmRetryDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 12768
{
	// Fields
	private int m_Label; // 0x70

	// Methods

	// RVA: 0x2D7DAE0 Offset: 0x2D7DBE1 VA: 0x2D7DAE0
	public void .ctor(int label) { }

	// RVA: 0x2D7DB10 Offset: 0x2D7DC11 VA: 0x2D7DB10 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7DB40 Offset: 0x2D7DC41 VA: 0x2D7DB40
	private ProcInst GetSequence() { }
}

// Namespace: 
private class NexVersus.NexSequenceBase : ProcInst // TypeDefIndex: 12770
{
	// Methods

	// RVA: 0x1F125F0 Offset: 0x1F126F1 VA: 0x1F125F0
	protected void Login() { }

	// RVA: 0x1F0A980 Offset: 0x1F0AA81 VA: 0x1F0A980
	protected void Postlogin(int labelWhenCancelled, int labelWhenFailed) { }

	// RVA: 0x1F12660 Offset: 0x1F12761 VA: 0x1F12660
	protected void ShowError() { }

	// RVA: 0x1F0DD40 Offset: 0x1F0DE41 VA: 0x1F0DD40
	protected void SetMetaBinary(List<byte> paramMetaBytes, VersusServerRankedMetaData metaData) { }

	// RVA: 0x1F0B090 Offset: 0x1F0B191 VA: 0x1F0B090
	protected void SetResult(NexVersus.Results result, string message = "") { }

	// RVA: 0x1F0AD90 Offset: 0x1F0AE91 VA: 0x1F0AD90
	protected void SetResultError(NetError.App error, string message = "") { }

	// RVA: 0x1F0AFB0 Offset: 0x1F0B0B1 VA: 0x1F0AFB0
	protected void SetResultError(AsyncResult error, string message = "") { }

	// RVA: 0x1F126D0 Offset: 0x1F127D1 VA: 0x1F126D0
	protected void SetResultFailed(string message = "") { }

	// RVA: 0x1F0BA40 Offset: 0x1F0BB41 VA: 0x1F0BA40
	protected void SetResultNotFound() { }

	// RVA: 0x1F12770 Offset: 0x1F12871 VA: 0x1F12770
	protected void SetResultDifferentType(string message = "") { }

	// RVA: 0x1F0A960 Offset: 0x1F0AA61 VA: 0x1F0A960
	public void .ctor() { }
}

// Namespace: 
private class NexVersus.UploadSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12772
{
	// Fields
	private string m_PlayerName; // 0x70
	private VersusServerRankedMetaData m_MetaData; // 0x78
	private VersusServerRankedData m_Data; // 0x80
	private ushort m_DataType; // 0x88
	private byte[] m_PNGBytes; // 0x90
	private ulong m_PNGDataId; // 0x98

	// Methods

	// RVA: 0x1F18330 Offset: 0x1F18431 VA: 0x1F18330
	private void .ctor(string playerName, VersusServerRankedMetaData metaData, VersusServerRankedData data, ushort dataType, byte[] pngBytes) { }

	// RVA: 0x1F183C0 Offset: 0x1F184C1 VA: 0x1F183C0
	private void Postlogin() { }

	// RVA: 0x1F183D0 Offset: 0x1F184D1 VA: 0x1F183D0
	private void UploadPNG() { }

	// RVA: 0x1F18590 Offset: 0x1F18691 VA: 0x1F18590
	private void PostUploadPNG(AsyncResult asyncResult, ulong dataId) { }

	// RVA: 0x1F18730 Offset: 0x1F18831 VA: 0x1F18730
	private void Post() { }

	// RVA: 0x1F18AD0 Offset: 0x1F18BD1 VA: 0x1F18AD0
	private void PostResult(AsyncResult asyncResult, ulong dataId) { }

	// RVA: 0x1F18CB0 Offset: 0x1F18DB1 VA: 0x1F18CB0
	public static void CreateBind(ProcInst super, string playerName, VersusServerRankedMetaData metaData, VersusServerRankedData data, ushort dataType, byte[] pngBytes) { }
}

// Namespace: 
private class NexVersus.UploadReplaySequence : NexVersus.NexSequenceBase // TypeDefIndex: 12774
{
	// Fields
	private VersusServerReplayMetaData m_MetaData; // 0x70
	private VersusServerReplayData m_Data; // 0x78
	private ushort m_Slot; // 0x80
	private VersusServerReplayMetaData m_ExistsMetaData; // 0x88
	private ulong m_PrincipalId; // 0x90
	private NexVersus.ReplaySlotMetaResultData m_ResultData; // 0x98

	// Methods

	// RVA: 0x1F16520 Offset: 0x1F16621 VA: 0x1F16520
	private void .ctor(VersusServerReplayMetaData metaData, VersusServerReplayData data, ushort slot) { }

	// RVA: 0x1F165E0 Offset: 0x1F166E1 VA: 0x1F165E0
	private void Postlogin() { }

	// RVA: 0x1F165F0 Offset: 0x1F166F1 VA: 0x1F165F0
	private void CheckExist() { }

	// RVA: 0x1F16730 Offset: 0x1F16831 VA: 0x1F16730
	private void Branch() { }

	// RVA: 0x1F16960 Offset: 0x1F16A61 VA: 0x1F16960
	private void Post() { }

	// RVA: 0x1F16AE0 Offset: 0x1F16BE1 VA: 0x1F16AE0
	protected void SetMetaBinary(List<byte> paramMetaBytes, VersusServerReplayMetaData metaData) { }

	// RVA: 0x1F16BC0 Offset: 0x1F16CC1 VA: 0x1F16BC0
	private void PostResult(AsyncResult asyncResult, ulong dataId) { }

	// RVA: 0x1F16D90 Offset: 0x1F16E91 VA: 0x1F16D90
	private void Invalid() { }

	// RVA: 0x1F16E40 Offset: 0x1F16F41 VA: 0x1F16E40
	private void PostInvalid() { }

	// RVA: 0x1F16F30 Offset: 0x1F17031 VA: 0x1F16F30
	public static void CreateBind(ProcInst super, VersusServerReplayMetaData metaData, VersusServerReplayData data, ushort slot) { }
}

// Namespace: 
private class NexVersus.UploadCasualSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12776
{
	// Fields
	private VersusServerCasualMetaData m_MetaData; // 0x70
	private VersusServerCasualData m_Data; // 0x78

	// Methods

	// RVA: 0x1F159D0 Offset: 0x1F15AD1 VA: 0x1F159D0
	private void .ctor(VersusServerCasualMetaData metaData, VersusServerCasualData data) { }

	// RVA: 0x1F15A20 Offset: 0x1F15B21 VA: 0x1F15A20
	private void Postlogin() { }

	// RVA: 0x1F15A30 Offset: 0x1F15B31 VA: 0x1F15A30
	private void SetMetaValue() { }

	// RVA: 0x1F15AD0 Offset: 0x1F15BD1 VA: 0x1F15AD0
	private void Post() { }

	// RVA: 0x1F15C50 Offset: 0x1F15D51 VA: 0x1F15C50
	protected void SetMetaBinary(List<byte> paramMetaBytes, VersusServerCasualMetaData metaData) { }

	// RVA: 0x1F15D30 Offset: 0x1F15E31 VA: 0x1F15D30
	private void PostResult(AsyncResult asyncResult, ulong dataId) { }

	// RVA: 0x1F15F00 Offset: 0x1F16001 VA: 0x1F15F00
	public static void CreateBind(ProcInst super, VersusServerCasualMetaData metaData, VersusServerCasualData data) { }
}

// Namespace: 
private class NexVersus.SearchSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12778
{
	// Fields
	private List<VersusServerRankedMetaData> m_Results; // 0x70
	private ushort m_DataType; // 0x78

	// Methods

	// RVA: 0x1F142C0 Offset: 0x1F143C1 VA: 0x1F142C0
	private void .ctor(List<VersusServerRankedMetaData> results, ushort dataType) { }

	// RVA: 0x1F14310 Offset: 0x1F14411 VA: 0x1F14310
	private void Search() { }

	// RVA: 0x1F14440 Offset: 0x1F14541 VA: 0x1F14440
	private void SearchResult(AsyncResult asyncResult, DataStoreSearchResult searchResult) { }

	// RVA: 0x1F147F0 Offset: 0x1F148F1 VA: 0x1F147F0
	private void Postlogin() { }

	// RVA: 0x1F14800 Offset: 0x1F14901 VA: 0x1F14800
	public static void CreateBind(ProcInst super, List<VersusServerRankedMetaData> results, ushort dataType) { }
}

// Namespace: 
private class NexVersus.SearchCasualSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12780
{
	// Fields
	private List<VersusServerCasualMetaData> m_Results; // 0x70

	// Methods

	// RVA: 0x1F13820 Offset: 0x1F13921 VA: 0x1F13820
	private void .ctor(List<VersusServerCasualMetaData> results) { }

	// RVA: 0x1F13860 Offset: 0x1F13961 VA: 0x1F13860
	private void Search() { }

	// RVA: 0x1F13990 Offset: 0x1F13A91 VA: 0x1F13990
	private void SearchResult(AsyncResult asyncResult, DataStoreSearchResult searchResult) { }

	// RVA: 0x1F13D10 Offset: 0x1F13E11 VA: 0x1F13D10
	private void Postlogin() { }

	// RVA: 0x1F13D20 Offset: 0x1F13E21 VA: 0x1F13D20
	public static void CreateBind(ProcInst super, List<VersusServerCasualMetaData> results) { }
}

// Namespace: 
private class NexVersus.DownloadSequence<T> : NexVersus.NexSequenceBase // TypeDefIndex: 12782
{
	// Fields
	private ulong m_DataId; // 0x0
	private T m_Result; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(ulong dataId, T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2637FA0 Offset: 0x26380A1 VA: 0x2637FA0
	|-NexVersus.DownloadSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Postlogin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2637FF0 Offset: 0x26380F1 VA: 0x2637FF0
	|-NexVersus.DownloadSequence<object>.Postlogin
	*/

	// RVA: -1 Offset: -1
	private void GetData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	|-NexVersus.DownloadSequence<object>.GetData
	*/

	// RVA: -1 Offset: -1
	private void GetDataResult(AsyncResult asyncResult, byte[] data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638120 Offset: 0x2638221 VA: 0x2638120
	|-NexVersus.DownloadSequence<object>.GetDataResult
	*/

	// RVA: -1 Offset: -1
	public static void CreateBind(ProcInst super, ulong dataId, T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	|-NexVersus.DownloadSequence<object>.CreateBind
	|-NexVersus.DownloadSequence<VersusServerCasualData>.CreateBind
	|-NexVersus.DownloadSequence<VersusServerRankedData>.CreateBind
	*/
}

// Namespace: 
private class NexVersus.DownloadReplaySequence : NexVersus.NexSequenceBase // TypeDefIndex: 12784
{
	// Fields
	private ulong m_DataId; // 0x70
	private VersusServerReplayData m_Result; // 0x78

	// Methods

	// RVA: 0x1F0F7D0 Offset: 0x1F0F8D1 VA: 0x1F0F7D0
	private void .ctor(ulong dataId, VersusServerReplayData result) { }

	// RVA: 0x1F0F820 Offset: 0x1F0F921 VA: 0x1F0F820
	private void Postlogin() { }

	// RVA: 0x1F0F830 Offset: 0x1F0F931 VA: 0x1F0F830
	private void GetData() { }

	// RVA: 0x1F0F940 Offset: 0x1F0FA41 VA: 0x1F0F940
	private void GetDataResult(AsyncResult asyncResult, byte[] data) { }

	// RVA: 0x1F0FB20 Offset: 0x1F0FC21 VA: 0x1F0FB20
	public static void CreateBind(ProcInst super, ulong dataId, VersusServerReplayData result) { }
}

// Namespace: 
public enum NexVersus.DownloadMetaSequence.DataType<T> // TypeDefIndex: 12786
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.DownloadMetaSequence.DataType<T> Casual = 0;
	public const NexVersus.DownloadMetaSequence.DataType<T> Ranked = 1;
}

// Namespace: 
private enum NexVersus.AddRatingSequence.Label // TypeDefIndex: 12788
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.AddRatingSequence.Label Error = 0;
	public const NexVersus.AddRatingSequence.Label End = 1;
}

// Namespace: 
private enum NexVersus.GetMetaDataFromPersistenceSlotSequence.Label<T> // TypeDefIndex: 12790
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.GetMetaDataFromPersistenceSlotSequence.Label<T> Error = 0;
	public const NexVersus.GetMetaDataFromPersistenceSlotSequence.Label<T> End = 1;
}

// Namespace: 
private enum NexVersus.GetMetaDataListFromPersistenceSlotSequence.Label<T> // TypeDefIndex: 12792
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.GetMetaDataListFromPersistenceSlotSequence.Label<T> Error = 0;
	public const NexVersus.GetMetaDataListFromPersistenceSlotSequence.Label<T> End = 1;
}

// Namespace: 
private enum NexVersus.GetReplayMetaDataFromPersistenceSlotSequence.Label // TypeDefIndex: 12794
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.GetReplayMetaDataFromPersistenceSlotSequence.Label Error = 0;
	public const NexVersus.GetReplayMetaDataFromPersistenceSlotSequence.Label End = 1;
}

// Namespace: 
private enum NexVersus.ChangeMetaDataTypeSequence.TargetType // TypeDefIndex: 12796
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeMetaDataTypeSequence.TargetType PrincipalSlot = 0;
	public const NexVersus.ChangeMetaDataTypeSequence.TargetType DataId = 1;
}

// Namespace: 
private class NexVersus.ChangeMetaDataTypeSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12798
{
	// Fields
	private NexVersus.ChangeMetaDataTypeSequence.TargetType m_TargetType; // 0x70
	private ulong m_DataId; // 0x78
	private ulong m_TargetPrincipalId; // 0x80
	private ushort m_TargetSlotId; // 0x88
	private ushort m_DataType; // 0x8A

	// Methods

	// RVA: 0x1F0B630 Offset: 0x1F0B731 VA: 0x1F0B630
	private void .ctor(ulong targetPrincipalId, ushort targetSlotId, ushort dataType) { }

	// RVA: 0x1F0B680 Offset: 0x1F0B781 VA: 0x1F0B680
	private void .ctor(ulong dataId, ushort dataType) { }

	// RVA: 0x1F0B6D0 Offset: 0x1F0B7D1 VA: 0x1F0B6D0
	private void Postlogin() { }

	// RVA: 0x1F0B6E0 Offset: 0x1F0B7E1 VA: 0x1F0B6E0
	private void ChangeMeta() { }

	// RVA: 0x1F0B840 Offset: 0x1F0B941 VA: 0x1F0B840
	private void ChangeMetaCallback(AsyncResult asyncResult) { }

	// RVA: 0x1F0BAC0 Offset: 0x1F0BBC1 VA: 0x1F0BAC0
	public static void CreateBind(ProcInst super, ulong targetPrincipalId, ushort targetSlotId, ushort dataType) { }

	// RVA: 0x1F0C0A0 Offset: 0x1F0C1A1 VA: 0x1F0C0A0
	public static void CreateBind(ProcInst super, ulong dataId, ushort dataType) { }

	// RVA: 0x1F0BB60 Offset: 0x1F0BC61 VA: 0x1F0BB60
	private static ProcDesc[] GetProcDescs(NexVersus.ChangeMetaDataTypeSequence p) { }
}

// Namespace: 
public enum NexVersus.ChangeReplayMetaSequence.Mode // TypeDefIndex: 12800
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeReplayMetaSequence.Mode Principal = 0;
	public const NexVersus.ChangeReplayMetaSequence.Mode DataID = 1;
}

// Namespace: 
private enum NexVersus.ChangeReplaySequence.Label // TypeDefIndex: 12802
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeReplaySequence.Label Error = 0;
	public const NexVersus.ChangeReplaySequence.Label End = 1;
}

// Namespace: 
private enum NexVersus.ChangeVersusDataSequence.Label<T> // TypeDefIndex: 12804
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeVersusDataSequence.Label<T> Error = 0;
	public const NexVersus.ChangeVersusDataSequence.Label<T> End = 1;
}

// Namespace: 
private enum NexVersus.ChangeVersusRankedMetaDataSequence.Label // TypeDefIndex: 12806
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeVersusRankedMetaDataSequence.Label Error = 0;
	public const NexVersus.ChangeVersusRankedMetaDataSequence.Label End = 1;
}

// Namespace: 
private enum NexVersus.ReportSequence.Label // TypeDefIndex: 12808
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ReportSequence.Label Login = 0;
	public const NexVersus.ReportSequence.Label Report = 1;
	public const NexVersus.ReportSequence.Label Error = 2;
	public const NexVersus.ReportSequence.Label End = 3;
}

// Namespace: 
public class NexVersus.ReplaySlotMetaResultData // TypeDefIndex: 12810
{
	// Fields
	private List<VersusServerReplayMetaData> m_List; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1F128F0 Offset: 0x1F129F1 VA: 0x1F128F0
	public void .ctor() { }

	// RVA: 0x1F12920 Offset: 0x1F12A21 VA: 0x1F12920
	public void Clear() { }

	// RVA: 0x1F11A20 Offset: 0x1F11B21 VA: 0x1F11A20
	public void Add(VersusServerReplayMetaData metaData) { }

	// RVA: 0x1F129D0 Offset: 0x1F12AD1 VA: 0x1F129D0
	public VersusServerReplayMetaData TryGetPlayableMetaData() { }

	// RVA: 0x1F12B00 Offset: 0x1F12C01 VA: 0x1F12B00
	public VersusServerReplayMetaData GetUploadTargetMetaData() { }

	// RVA: 0x1F12C70 Offset: 0x1F12D71 VA: 0x1F12C70
	public bool TryRemove(VersusServerReplayMetaData metaData) { }

	// RVA: 0x1F12CD0 Offset: 0x1F12DD1 VA: 0x1F12CD0
	public List<VersusServerReplayMetaData> GetMetaDataList() { }

	// RVA: 0x1F11A80 Offset: 0x1F11B81 VA: 0x1F11A80
	public int get_Count() { }
}

// Namespace: 
public sealed class NexVersus.CasualMetaDataEndCallback : MulticastDelegate // TypeDefIndex: 12812
{
	// Methods

	// RVA: 0x1F0B550 Offset: 0x1F0B651 VA: 0x1F0B550
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F0A3E0 Offset: 0x1F0A4E1 VA: 0x1F0A3E0 Slot: 13
	public virtual void Invoke(NexVersus.Results result, VersusServerCasualMetaData metaData, NexVersus.ResultInfo info) { }

	// RVA: 0x1F0B570 Offset: 0x1F0B671 VA: 0x1F0B570 Slot: 14
	public virtual IAsyncResult BeginInvoke(NexVersus.Results result, VersusServerCasualMetaData metaData, NexVersus.ResultInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1F0B620 Offset: 0x1F0B721 VA: 0x1F0B620 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class NexVersus.ResultInfo // TypeDefIndex: 12814
{
	// Fields
	private bool m_IsValid; // 0x10
	private DataStore.DataStatus m_DataStatus; // 0x14
	private ushort m_DataType; // 0x18

	// Properties
	public DataStore.DataStatus DataStatus { get; }
	public ushort DataType { get; }

	// Methods

	// RVA: 0x1F137A0 Offset: 0x1F138A1 VA: 0x1F137A0
	public void .ctor() { }

	// RVA: 0x1F137D0 Offset: 0x1F138D1 VA: 0x1F137D0
	public void SetValues(DataStore.DataStatus status, ushort type) { }

	// RVA: 0x1F137F0 Offset: 0x1F138F1 VA: 0x1F137F0
	public bool IsValid() { }

	// RVA: 0x1F13800 Offset: 0x1F13901 VA: 0x1F13800
	public DataStore.DataStatus get_DataStatus() { }

	// RVA: 0x1F13810 Offset: 0x1F13911 VA: 0x1F13810
	public ushort get_DataType() { }
}

// Namespace: 
public enum NexVersus.TargetSlotList.Results // TypeDefIndex: 12816
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.TargetSlotList.Results None = -1;
	public const NexVersus.TargetSlotList.Results Valid = 0;
	public const NexVersus.TargetSlotList.Results Error_NotFound = 1;
	public const NexVersus.TargetSlotList.Results Error_UnderReviewing = 2;
	public const NexVersus.TargetSlotList.Results Error = 3;
}

// Namespace: 
private enum NexVersus.GetRankedMetaDataFromPersistenceSlotSequence.Label // TypeDefIndex: 12818
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.GetRankedMetaDataFromPersistenceSlotSequence.Label Error = 0;
	public const NexVersus.GetRankedMetaDataFromPersistenceSlotSequence.Label End = 1;
}

// Namespace: 
private enum NexVersus.UploadReportMetaSequence.Label // TypeDefIndex: 12820
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.UploadReportMetaSequence.Label Error = 0;
	public const NexVersus.UploadReportMetaSequence.Label ErrorApp = 1;
	public const NexVersus.UploadReportMetaSequence.Label End = 2;
}

// Namespace: 
private enum NexVersus.CheckAccessibleSlotSequence.Label // TypeDefIndex: 12822
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.CheckAccessibleSlotSequence.Label Error = 0;
	public const NexVersus.CheckAccessibleSlotSequence.Label End = 1;
}

// Namespace: 
private class NexVersus.CheckAccessibleSlotSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12824
{
	// Fields
	private NexVersus.TargetSlotList m_TargetInfoList; // 0x70
	private NexVersus.CheckAccessibleSlotSequence.Mode m_Mode; // 0x78
	private NexVersus.EndCallback m_EndCallback; // 0x80

	// Methods

	// RVA: 0x1F0E620 Offset: 0x1F0E721 VA: 0x1F0E620
	private ushort GetSlot() { }

	// RVA: 0x1F0E690 Offset: 0x1F0E791 VA: 0x1F0E690
	private void .ctor(NexVersus.TargetSlotList targetInfoList, NexVersus.CheckAccessibleSlotSequence.Mode mode, NexVersus.EndCallback endCallback) { }

	// RVA: 0x1F0E6F0 Offset: 0x1F0E7F1 VA: 0x1F0E6F0
	private void Postlogin() { }

	// RVA: 0x1F0E700 Offset: 0x1F0E801 VA: 0x1F0E700
	private void GetInfo() { }

	// RVA: 0x1F0E9C0 Offset: 0x1F0EAC1 VA: 0x1F0E9C0
	private void GetMetaCallback(AsyncResult asyncResult, List<DataStoreMetaInfo> infoList, List<DataStoreResult> resultList) { }

	// RVA: 0x1F0EEA0 Offset: 0x1F0EFA1 VA: 0x1F0EEA0
	private void EndCallback() { }

	// RVA: 0x1F0F1A0 Offset: 0x1F0F2A1 VA: 0x1F0F1A0
	public static void CreateBind(ProcInst super, NexVersus.TargetSlotList targetInfoList, NexVersus.CheckAccessibleSlotSequence.Mode mode, NexVersus.EndCallback endCallback) { }
}

// Namespace: 
public enum NexVersus.DownloadMetaDataSequence.Mode<T> // TypeDefIndex: 12826
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.DownloadMetaDataSequence.Mode<T> Casual = 0;
	public const NexVersus.DownloadMetaDataSequence.Mode<T> Ranked = 1;
}

// Namespace: 
private class NexVersus.DownloadMetaDataSequence<T> : NexVersus.NexSequenceBase // TypeDefIndex: 12828
{
	// Fields
	private ulong m_PrincipalID; // 0x0
	private NexVersus.DownloadMetaDataSequence.Mode<T> m_Mode; // 0x0
	private NexVersus.DownloadMetaDataSequence.EndCallback<T> m_EndCallback; // 0x0
	private T m_ResultMeta; // 0x0
	private NexVersus.ResultInfo m_Info; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(ulong principalID, NexVersus.DownloadMetaDataSequence.Mode<T> mode, NexVersus.DownloadMetaDataSequence.EndCallback<T> endCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636610 Offset: 0x2636711 VA: 0x2636610
	|-NexVersus.DownloadMetaDataSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Postlogin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636700 Offset: 0x2636801 VA: 0x2636700
	|-NexVersus.DownloadMetaDataSequence<object>.Postlogin
	*/

	// RVA: -1 Offset: -1
	private ushort GetSlot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636710 Offset: 0x2636811 VA: 0x2636710
	|-NexVersus.DownloadMetaDataSequence<object>.GetSlot
	*/

	// RVA: -1 Offset: -1
	private void GetMeta() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636730 Offset: 0x2636831 VA: 0x2636730
	|-NexVersus.DownloadMetaDataSequence<object>.GetMeta
	*/

	// RVA: -1 Offset: -1
	private void GetMetaCallback(AsyncResult asyncResult, DataStoreMetaInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636870 Offset: 0x2636971 VA: 0x2636870
	|-NexVersus.DownloadMetaDataSequence<object>.GetMetaCallback
	*/

	// RVA: -1 Offset: -1
	private bool IsValidDataType(ushort dataType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636AC0 Offset: 0x2636BC1 VA: 0x2636AC0
	|-NexVersus.DownloadMetaDataSequence<object>.IsValidDataType
	*/

	// RVA: -1 Offset: -1
	private void InvokeEndCallback() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636B00 Offset: 0x2636C01 VA: 0x2636B00
	|-NexVersus.DownloadMetaDataSequence<object>.InvokeEndCallback
	*/

	// RVA: -1 Offset: -1
	public static void CreateBind(ProcInst super, ulong principalID, NexVersus.DownloadMetaDataSequence.Mode<T> mode, NexVersus.DownloadMetaDataSequence.EndCallback<T> endCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636BC0 Offset: 0x2636CC1 VA: 0x2636BC0
	|-NexVersus.DownloadMetaDataSequence<object>.CreateBind
	|-NexVersus.DownloadMetaDataSequence<VersusServerCasualMetaData>.CreateBind
	|-NexVersus.DownloadMetaDataSequence<VersusServerRankedMetaData>.CreateBind
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278790 Offset: 0x278891 VA: 0x278790
private sealed class NexVersus.<>c__DisplayClass102_0 // TypeDefIndex: 12830
{
	// Fields
	public NexVersus.RankedMetaDataEndCallback endCallback; // 0x10

	// Methods

	// RVA: 0x1F0A670 Offset: 0x1F0A771 VA: 0x1F0A670
	public void .ctor() { }

	// RVA: 0x1F0A680 Offset: 0x1F0A781 VA: 0x1F0A680
	internal void <DownloadRankedMetaPrincipalID>g__callback|0(NexVersus.Results result, VersusServerRankedMetaData metaData, NexVersus.ResultInfo info) { }
}

