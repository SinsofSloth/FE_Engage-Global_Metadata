// Namespace: 
public static class NexVersus.RatingSpotId // TypeDefIndex: 12765
{
	// Fields
	public const sbyte Win = 1;
	public const sbyte Lose = 2;
}

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
public struct NexVersus.RatingData // TypeDefIndex: 12767
{
	// Fields
	public long TotalValue; // 0x0
	public uint Count; // 0x8
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
protected static class NexVersus.NexSequenceBase.ConfirmRetryDialog // TypeDefIndex: 12769
{
	// Methods

	// RVA: 0x21F1CF0 Offset: 0x21F1DF1 VA: 0x21F1CF0
	public static void CreateBind(ProcInst super, int yesLabel) { }
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
private enum NexVersus.UploadSequence.Label // TypeDefIndex: 12771
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.UploadSequence.Label Post = 0;
	public const NexVersus.UploadSequence.Label Error = 1;
	public const NexVersus.UploadSequence.Label End = 2;
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
private enum NexVersus.UploadReplaySequence.Label // TypeDefIndex: 12773
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.UploadReplaySequence.Label Error = 0;
	public const NexVersus.UploadReplaySequence.Label End = 1;
	public const NexVersus.UploadReplaySequence.Label Post = 2;
	public const NexVersus.UploadReplaySequence.Label Invalid = 3;
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
private enum NexVersus.UploadCasualSequence.Label // TypeDefIndex: 12775
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.UploadCasualSequence.Label Error = 0;
	public const NexVersus.UploadCasualSequence.Label End = 1;
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
private enum NexVersus.SearchSequence.Label // TypeDefIndex: 12777
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.SearchSequence.Label Error = 0;
	public const NexVersus.SearchSequence.Label End = 1;
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
private enum NexVersus.SearchCasualSequence.Label // TypeDefIndex: 12779
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.SearchCasualSequence.Label Error = 0;
	public const NexVersus.SearchCasualSequence.Label End = 1;
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
private enum NexVersus.DownloadSequence.Label<T> // TypeDefIndex: 12781
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.DownloadSequence.Label<T> Error = 0;
	public const NexVersus.DownloadSequence.Label<T> ErrorApp = 1;
	public const NexVersus.DownloadSequence.Label<T> End = 2;
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
private enum NexVersus.DownloadReplaySequence.Label // TypeDefIndex: 12783
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.DownloadReplaySequence.Label Error = 0;
	public const NexVersus.DownloadReplaySequence.Label End = 1;
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
private enum NexVersus.DownloadMetaSequence.Label<T> // TypeDefIndex: 12785
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.DownloadMetaSequence.Label<T> Error = 0;
	public const NexVersus.DownloadMetaSequence.Label<T> ErrorApp = 1;
	public const NexVersus.DownloadMetaSequence.Label<T> End = 2;
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
private class NexVersus.DownloadMetaSequence<T> : NexVersus.NexSequenceBase // TypeDefIndex: 12787
{
	// Fields
	private ulong m_DataId; // 0x0
	private NexVersus.DownloadMetaSequence.DataType<T> m_DataType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(ulong dataId, NexVersus.DownloadMetaSequence.DataType<T> dataType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390
	|-NexVersus.DownloadMetaSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Postlogin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26373D0 Offset: 0x26374D1 VA: 0x26373D0
	|-NexVersus.DownloadMetaSequence<object>.Postlogin
	*/

	// RVA: -1 Offset: -1
	private void GetData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26373E0 Offset: 0x26374E1 VA: 0x26373E0
	|-NexVersus.DownloadMetaSequence<object>.GetData
	*/

	// RVA: -1 Offset: -1
	private void GetMetaCallback(AsyncResult asyncResult, DataStoreMetaInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2637550 Offset: 0x2637651 VA: 0x2637550
	|-NexVersus.DownloadMetaSequence<object>.GetMetaCallback
	*/

	// RVA: -1 Offset: -1
	private bool IsValidDataType(ushort dataType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2637810 Offset: 0x2637911 VA: 0x2637810
	|-NexVersus.DownloadMetaSequence<object>.IsValidDataType
	*/

	// RVA: -1 Offset: -1
	public static void CreateBind(ProcInst super, ulong dataId, NexVersus.DownloadMetaSequence.DataType<T> dataType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2637850 Offset: 0x2637951 VA: 0x2637850
	|-NexVersus.DownloadMetaSequence<object>.CreateBind
	|-NexVersus.DownloadMetaSequence<VersusServerCasualMetaData>.CreateBind
	|-NexVersus.DownloadMetaSequence<VersusServerRankedMetaData>.CreateBind
	*/
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
private class NexVersus.AddRatingSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12789
{
	// Fields
	private ulong m_DataId; // 0x70
	private Versus.MapResult m_MapResult; // 0x78

	// Methods

	// RVA: 0x1F0A920 Offset: 0x1F0AA21 VA: 0x1F0A920
	private void .ctor(ulong dataId, Versus.MapResult mapResult) { }

	// RVA: 0x1F0A970 Offset: 0x1F0AA71 VA: 0x1F0A970
	private void Postlogin() { }

	// RVA: 0x1F0AC30 Offset: 0x1F0AD31 VA: 0x1F0AC30
	private sbyte GetSlotId(Versus.MapResult result) { }

	// RVA: 0x1F0AC50 Offset: 0x1F0AD51 VA: 0x1F0AC50
	private void UpdateRate() { }

	// RVA: 0x1F0AE70 Offset: 0x1F0AF71 VA: 0x1F0AE70
	private void PostUpdateRate(AsyncResult asyncResult, DataStoreRatingInfo info) { }

	// RVA: 0x1F0B130 Offset: 0x1F0B231 VA: 0x1F0B130
	public static void CreateBind(ProcInst super, ulong dataId, Versus.MapResult mapResult) { }
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
private class NexVersus.GetMetaDataFromPersistenceSlotSequence<T> : NexVersus.NexSequenceBase // TypeDefIndex: 12791
{
	// Fields
	private ushort m_SlotId; // 0x0
	private ulong m_PrincipalId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private ulong GetPrincipalId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FE70 Offset: 0x3A0FF71 VA: 0x3A0FE70
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<object>.GetPrincipalId
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ushort slotId, ulong principalId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FE80 Offset: 0x3A0FF81 VA: 0x3A0FE80
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Postlogin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FEC0 Offset: 0x3A0FFC1 VA: 0x3A0FEC0
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<object>.Postlogin
	*/

	// RVA: -1 Offset: -1
	private void GetPersistenceMetaData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FED0 Offset: 0x3A0FFD1 VA: 0x3A0FED0
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<object>.GetPersistenceMetaData
	*/

	// RVA: -1 Offset: -1
	private void GetMetaCallback(AsyncResult asyncResult, DataStoreMetaInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A10070 Offset: 0x3A10171 VA: 0x3A10070
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<object>.GetMetaCallback
	*/

	// RVA: -1 Offset: -1
	public static void CreateBind(ProcInst super, ushort slotId, ulong principalId = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A104B0 Offset: 0x3A105B1 VA: 0x3A104B0
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<object>.CreateBind
	|-NexVersus.GetMetaDataFromPersistenceSlotSequence<VersusServerCasualMetaData>.CreateBind
	*/
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
private class NexVersus.GetMetaDataListFromPersistenceSlotSequence<T> : NexVersus.NexSequenceBase // TypeDefIndex: 12793
{
	// Fields
	private List<ulong> m_PrincipalIdList; // 0x0
	private ushort m_SlotId; // 0x0
	private List<T> m_ResultList; // 0x0
	private List<List<NexVersus.RatingData>> m_ResultRatingList; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(List<ulong> principalIdList, ushort slotId, List<T> resultDataList, List<List<NexVersus.RatingData>> resultRatingList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A10B20 Offset: 0x3A10C21 VA: 0x3A10B20
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Postlogin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A10BA0 Offset: 0x3A10CA1 VA: 0x3A10BA0
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<object>.Postlogin
	*/

	// RVA: -1 Offset: -1
	private void GetPersistenceMetaData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A10BB0 Offset: 0x3A10CB1 VA: 0x3A10BB0
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<object>.GetPersistenceMetaData
	*/

	// RVA: -1 Offset: -1
	private void GetMetaCallback(AsyncResult asyncResult, List<DataStoreMetaInfo> infoList, List<DataStoreResult> resultList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A10D80 Offset: 0x3A10E81 VA: 0x3A10D80
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<object>.GetMetaCallback
	*/

	// RVA: -1 Offset: -1
	public static void CreateBind(ProcInst super, List<ulong> principalIdList, ushort slotId, List<T> resultDataList, List<List<NexVersus.RatingData>> resultRatingList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A11260 Offset: 0x3A11361 VA: 0x3A11260
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<object>.CreateBind
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<VersusServerCasualMetaData>.CreateBind
	|-NexVersus.GetMetaDataListFromPersistenceSlotSequence<VersusServerRankedMetaData>.CreateBind
	*/
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
private class NexVersus.GetReplayMetaDataFromPersistenceSlotSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12795
{
	// Fields
	public static readonly ushort AllSlot; // 0x0
	private ulong m_PrincipalId; // 0x70
	private ushort m_SlotId; // 0x78
	private ulong m_PersistenceDataId; // 0x80
	private NexVersus.ReplaySlotMetaResultData m_ResultData; // 0x88

	// Methods

	// RVA: 0x1F10F90 Offset: 0x1F11091 VA: 0x1F10F90
	private bool IsAllSlot() { }

	// RVA: 0x1F11010 Offset: 0x1F11111 VA: 0x1F11010
	private void .ctor(ulong principalId, ushort slotId, NexVersus.ReplaySlotMetaResultData result) { }

	// RVA: 0x1F11060 Offset: 0x1F11161 VA: 0x1F11060
	private void Postlogin() { }

	// RVA: 0x1F11070 Offset: 0x1F11171 VA: 0x1F11070
	private void GetPersistenceMetaData() { }

	// RVA: 0x1F11100 Offset: 0x1F11201 VA: 0x1F11100
	private void GetAllSlot() { }

	// RVA: 0x1F115B0 Offset: 0x1F116B1 VA: 0x1F115B0
	private void GetMetaListCallback(AsyncResult asyncResult, List<DataStoreMetaInfo> info, List<DataStoreResult> resultList) { }

	// RVA: 0x1F113C0 Offset: 0x1F114C1 VA: 0x1F113C0
	private void GetSingleSlot() { }

	// RVA: 0x1F11550 Offset: 0x1F11651 VA: 0x1F11550
	private DataStoreGetMetaParam GetMetaParam(ushort slot) { }

	// RVA: 0x1F11AD0 Offset: 0x1F11BD1 VA: 0x1F11AD0
	private void GetMetaCallback(AsyncResult asyncResult, DataStoreMetaInfo info) { }

	// RVA: 0x1F118D0 Offset: 0x1F119D1 VA: 0x1F118D0
	private bool ErrorCheck(AsyncResult asyncResult) { }

	// RVA: 0x1F11CB0 Offset: 0x1F11DB1 VA: 0x1F11CB0
	public static void CreateBind(ProcInst super, ulong principalId, ushort slotId, bool isShowDialog, NexVersus.ReplaySlotMetaResultData resultData) { }

	// RVA: 0x1F11D70 Offset: 0x1F11E71 VA: 0x1F11D70
	private ProcDesc[] CreateDesc(bool isShowDialog) { }

	// RVA: 0x1F125A0 Offset: 0x1F126A1 VA: 0x1F125A0
	private static void .cctor() { }
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
private enum NexVersus.ChangeMetaDataTypeSequence.Label // TypeDefIndex: 12797
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeMetaDataTypeSequence.Label Error = 0;
	public const NexVersus.ChangeMetaDataTypeSequence.Label End = 1;
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
private enum NexVersus.ChangeReplayMetaSequence.Label // TypeDefIndex: 12799
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.ChangeReplayMetaSequence.Label Error = 0;
	public const NexVersus.ChangeReplayMetaSequence.Label End = 1;
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
private class NexVersus.ChangeReplayMetaSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12801
{
	// Fields
	private NexVersus.ChangeReplayMetaSequence.Mode m_Mode; // 0x70
	private ulong m_TargetPrincipalId; // 0x78
	private ushort m_TargetSlotId; // 0x80
	private ulong m_DataId; // 0x88
	private VersusServerReplayMetaData m_MetaData; // 0x90
	private bool m_IsSetMetaParam; // 0x98

	// Methods

	// RVA: 0x1F0C140 Offset: 0x1F0C241 VA: 0x1F0C140
	private void .ctor(ulong dataId, VersusServerReplayMetaData metaData, bool isSetMetaParam) { }

	// RVA: 0x1F0C1A0 Offset: 0x1F0C2A1 VA: 0x1F0C1A0
	private void .ctor(ulong principalId, ushort slotId, VersusServerReplayMetaData metaData, bool isSetMetaParam) { }

	// RVA: 0x1F0C210 Offset: 0x1F0C311 VA: 0x1F0C210
	private void Postlogin() { }

	// RVA: 0x1F0C220 Offset: 0x1F0C321 VA: 0x1F0C220
	private void SetMetaParam() { }

	// RVA: 0x1F0C320 Offset: 0x1F0C421 VA: 0x1F0C320
	private void ChangeMeta() { }

	// RVA: 0x1F0C470 Offset: 0x1F0C571 VA: 0x1F0C470
	private void SetMetaBinary(List<byte> paramMetaBytes, VersusServerReplayMetaData metaData) { }

	// RVA: 0x1F0C550 Offset: 0x1F0C651 VA: 0x1F0C550
	private void ChangeMetaCallback(AsyncResult asyncResult) { }

	// RVA: 0x1F0C720 Offset: 0x1F0C821 VA: 0x1F0C720
	public static void CreateBind(ProcInst super, ulong dataId, VersusServerReplayMetaData metaData, bool isSetMetaParam, bool isShowDialog) { }

	// RVA: 0x1F0D110 Offset: 0x1F0D211 VA: 0x1F0D110
	public static void CreateBind(ProcInst super, ulong principalId, ushort slotId, VersusServerReplayMetaData metaData, bool isSetMetaParam, bool isShowDialog) { }

	// RVA: 0x1F0C7F0 Offset: 0x1F0C8F1 VA: 0x1F0C7F0
	private ProcDesc[] CreateDesc(bool isShowDialog) { }
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
private class NexVersus.ChangeReplaySequence : NexVersus.NexSequenceBase // TypeDefIndex: 12803
{
	// Fields
	private VersusServerReplayMetaData m_MetaData; // 0x70
	private VersusServerReplayData m_Data; // 0x78

	// Methods

	// RVA: 0x1F0D1E0 Offset: 0x1F0D2E1 VA: 0x1F0D1E0
	private void .ctor(VersusServerReplayMetaData metaData, VersusServerReplayData data) { }

	// RVA: 0x1F0D230 Offset: 0x1F0D331 VA: 0x1F0D230
	private void Postlogin() { }

	// RVA: 0x1F0D240 Offset: 0x1F0D341 VA: 0x1F0D240
	private void ChangeReplay() { }

	// RVA: 0x1F0D360 Offset: 0x1F0D461 VA: 0x1F0D360
	private void ChangeCallback(AsyncResult asyncResult) { }

	// RVA: 0x1F0D530 Offset: 0x1F0D631 VA: 0x1F0D530
	public static void CreateBind(ProcInst super, VersusServerReplayMetaData metaData, VersusServerReplayData data) { }
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
private class NexVersus.ChangeVersusDataSequence<T> : NexVersus.NexSequenceBase // TypeDefIndex: 12805
{
	// Fields
	private ulong m_DataId; // 0x0
	private T m_Data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(ulong dataId, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D7480 Offset: 0x30D7581 VA: 0x30D7480
	|-NexVersus.ChangeVersusDataSequence<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Postlogin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D74D0 Offset: 0x30D75D1 VA: 0x30D74D0
	|-NexVersus.ChangeVersusDataSequence<object>.Postlogin
	*/

	// RVA: -1 Offset: -1
	private void ChangeData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D74E0 Offset: 0x30D75E1 VA: 0x30D74E0
	|-NexVersus.ChangeVersusDataSequence<object>.ChangeData
	*/

	// RVA: -1 Offset: -1
	private void ChangeCallback(AsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D7610 Offset: 0x30D7711 VA: 0x30D7610
	|-NexVersus.ChangeVersusDataSequence<object>.ChangeCallback
	*/

	// RVA: -1 Offset: -1
	public static void CreateBind(ProcInst super, ulong dataId, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D7760 Offset: 0x30D7861 VA: 0x30D7760
	|-NexVersus.ChangeVersusDataSequence<object>.CreateBind
	|-NexVersus.ChangeVersusDataSequence<VersusServerCasualData>.CreateBind
	|-NexVersus.ChangeVersusDataSequence<VersusServerRankedData>.CreateBind
	*/
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
private class NexVersus.ChangeVersusRankedMetaDataSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12807
{
	// Fields
	private ulong m_DataId; // 0x70
	private VersusServerRankedMetaData m_MetaData; // 0x78
	private string m_PlayerName; // 0x80

	// Methods

	// RVA: 0x1F0DAE0 Offset: 0x1F0DBE1 VA: 0x1F0DAE0
	private void .ctor(ulong dataId, VersusServerRankedMetaData metaData, string playerName) { }

	// RVA: 0x1F0DB40 Offset: 0x1F0DC41 VA: 0x1F0DB40
	private void Postlogin() { }

	// RVA: 0x1F0DB50 Offset: 0x1F0DC51 VA: 0x1F0DB50
	private void SetMetaParam() { }

	// RVA: 0x1F0DC20 Offset: 0x1F0DD21 VA: 0x1F0DC20
	private void ChangeMeta() { }

	// RVA: 0x1F0DE20 Offset: 0x1F0DF21 VA: 0x1F0DE20
	private void ChangeMetaCallback(AsyncResult asyncResult) { }

	// RVA: 0x1F0DFF0 Offset: 0x1F0E0F1 VA: 0x1F0DFF0
	public static void CreateBind(ProcInst super, ulong dataId, VersusServerRankedMetaData metaData, string playerName) { }
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
private class NexVersus.ReportSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12809
{
	// Fields
	private ulong m_DataId; // 0x70
	private ulong m_ScreenShotId; // 0x78
	private Screening.ReportCategory m_Category; // 0x80
	private string m_Reason; // 0x88
	private string m_Language; // 0x90
	private bool m_IsNotSendSucceed; // 0x98

	// Methods

	// RVA: 0x1F12CE0 Offset: 0x1F12DE1 VA: 0x1F12CE0
	private void .ctor(ulong dataId, ulong screenshotId, Screening.ReportCategory category, string reason, string language, bool isNotSendSucceed) { }

	// RVA: 0x1F12D70 Offset: 0x1F12E71 VA: 0x1F12D70
	private void Postlogin() { }

	// RVA: 0x1F12D80 Offset: 0x1F12E81 VA: 0x1F12D80
	private void Report() { }

	// RVA: 0x1F12F90 Offset: 0x1F13091 VA: 0x1F12F90
	private void ReportCallback(AsyncResult asyncResult) { }

	// RVA: 0x1F130F0 Offset: 0x1F131F1 VA: 0x1F130F0
	private void ConfirmRetry() { }

	// RVA: 0x1F13100 Offset: 0x1F13201 VA: 0x1F13100
	public static void CreateBind(ProcInst super, ulong dataId, ulong screenshotId, Screening.ReportCategory category, string reason, string language, bool isNotSendSucceed) { }
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
public sealed class NexVersus.EndCallback : MulticastDelegate // TypeDefIndex: 12811
{
	// Methods

	// RVA: 0x1F100D0 Offset: 0x1F101D1 VA: 0x1F100D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F0EF40 Offset: 0x1F0F041 VA: 0x1F0EF40 Slot: 13
	public virtual void Invoke(NexVersus.Results result) { }

	// RVA: 0x1F100F0 Offset: 0x1F101F1 VA: 0x1F100F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(NexVersus.Results result, AsyncCallback callback, object object) { }

	// RVA: 0x1F10180 Offset: 0x1F10281 VA: 0x1F10180 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
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
public sealed class NexVersus.RankedMetaDataEndCallback : MulticastDelegate // TypeDefIndex: 12813
{
	// Methods

	// RVA: 0x1F12810 Offset: 0x1F12911 VA: 0x1F12810
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F0A690 Offset: 0x1F0A791 VA: 0x1F0A690 Slot: 13
	public virtual void Invoke(NexVersus.Results result, VersusServerRankedMetaData metaData, NexVersus.ResultInfo info) { }

	// RVA: 0x1F12830 Offset: 0x1F12931 VA: 0x1F12830 Slot: 14
	public virtual IAsyncResult BeginInvoke(NexVersus.Results result, VersusServerRankedMetaData metaData, NexVersus.ResultInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1F128E0 Offset: 0x1F129E1 VA: 0x1F128E0 Slot: 15
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
public enum NexVersus.UploadType // TypeDefIndex: 12815
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.UploadType None = -1;
	public const NexVersus.UploadType New = 0;
	public const NexVersus.UploadType Overwrite = 1;
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
public class NexVersus.TargetSlotList // TypeDefIndex: 12817
{
	// Fields
	private Dictionary<ulong, NexVersus.TargetSlotList.Results> m_Dict; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1F14DA0 Offset: 0x1F14EA1 VA: 0x1F14DA0
	public void .ctor() { }

	// RVA: 0x1F14E30 Offset: 0x1F14F31 VA: 0x1F14E30
	public void Add(ulong id) { }

	// RVA: 0x1F14ED0 Offset: 0x1F14FD1 VA: 0x1F14ED0
	public void Add(List<ulong> list) { }

	// RVA: 0x1F15060 Offset: 0x1F15161 VA: 0x1F15060
	public void Clear() { }

	// RVA: 0x1F150C0 Offset: 0x1F151C1 VA: 0x1F150C0
	public int get_Count() { }

	// RVA: 0x1F15120 Offset: 0x1F15221 VA: 0x1F15120
	public int GetCountValid() { }

	// RVA: 0x1F0E950 Offset: 0x1F0EA51 VA: 0x1F0E950
	public List<ulong> GetIDList() { }

	// RVA: 0x1F0EDF0 Offset: 0x1F0EEF1 VA: 0x1F0EDF0
	public void SetResult(ulong id, NexVersus.TargetSlotList.Results result) { }

	// RVA: 0x1F15270 Offset: 0x1F15371 VA: 0x1F15270
	public NexVersus.TargetSlotList.Results GetResult(ulong id) { }

	// RVA: 0x1F15310 Offset: 0x1F15411 VA: 0x1F15310
	public bool IsValid(ulong id) { }

	// RVA: 0x1F153C0 Offset: 0x1F154C1 VA: 0x1F153C0
	public string Dump() { }

	// RVA: 0x1F15690 Offset: 0x1F15791 VA: 0x1F15690
	public void ForEach(Action<ulong, NexVersus.TargetSlotList.Results> action) { }

	// RVA: 0x1F15830 Offset: 0x1F15931 VA: 0x1F15830
	public void ForEach(Action<int, ulong, NexVersus.TargetSlotList.Results> action) { }
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
private class NexVersus.GetRankedMetaDataFromPersistenceSlotSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12819
{
	// Methods

	// RVA: 0x1F10190 Offset: 0x1F10291 VA: 0x1F10190
	private ulong GetPrincipalId() { }

	// RVA: 0x1F101A0 Offset: 0x1F102A1 VA: 0x1F101A0
	private void .ctor() { }

	// RVA: 0x1F101B0 Offset: 0x1F102B1 VA: 0x1F101B0
	private void Postlogin() { }

	// RVA: 0x1F101C0 Offset: 0x1F102C1 VA: 0x1F101C0
	private void GetPersistenceMetaData() { }

	// RVA: 0x1F103C0 Offset: 0x1F104C1 VA: 0x1F103C0
	private void GetMetaCallback(AsyncResult asyncResult, List<DataStoreMetaInfo> infoList, List<DataStoreResult> resultList) { }

	// RVA: 0x1F10540 Offset: 0x1F10641 VA: 0x1F10540
	private bool SetEditData(DataStoreMetaInfo info, DataStoreResult result) { }

	// RVA: 0x1F10900 Offset: 0x1F10A01 VA: 0x1F10900
	private bool SetReportData(DataStoreMetaInfo info, DataStoreResult result) { }

	// RVA: 0x1F10A10 Offset: 0x1F10B11 VA: 0x1F10A10
	public static void CreateBind(ProcInst super) { }
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
private class NexVersus.UploadReportMetaSequence : NexVersus.NexSequenceBase // TypeDefIndex: 12821
{
	// Fields
	private VersusServerReportMetaData m_MetaData; // 0x70
	private NexVersus.UploadType m_Type; // 0x78

	// Methods

	// RVA: 0x1F17620 Offset: 0x1F17721 VA: 0x1F17620
	private void .ctor(VersusServerReportMetaData data, NexVersus.UploadType type) { }

	// RVA: 0x1F17670 Offset: 0x1F17771 VA: 0x1F17670
	private void Postlogin() { }

	// RVA: 0x1F17680 Offset: 0x1F17781 VA: 0x1F17680
	private void Upload() { }

	// RVA: 0x1F17750 Offset: 0x1F17851 VA: 0x1F17750
	private void UploadNew() { }

	// RVA: 0x1F178C0 Offset: 0x1F179C1 VA: 0x1F178C0
	private void UploadOverwrite() { }

	// RVA: 0x1F17A00 Offset: 0x1F17B01 VA: 0x1F17A00
	public static void CreateBind(ProcInst super, VersusServerReportMetaData data, NexVersus.UploadType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA090 Offset: 0x2CA191 VA: 0x2CA090
	// RVA: 0x1F18060 Offset: 0x1F18161 VA: 0x1F18060
	private void <UploadNew>b__6_0(AsyncResult asyncResult, ulong dataId) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA0A0 Offset: 0x2CA1A1 VA: 0x2CA0A0
	// RVA: 0x1F181F0 Offset: 0x1F182F1 VA: 0x1F181F0
	private void <UploadOverwrite>b__7_0(AsyncResult asyncResult) { }
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
public enum NexVersus.CheckAccessibleSlotSequence.Mode // TypeDefIndex: 12823
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.CheckAccessibleSlotSequence.Mode Casual = 0;
	public const NexVersus.CheckAccessibleSlotSequence.Mode Ranked = 1;
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
public sealed class NexVersus.DownloadMetaDataSequence.EndCallback<T> : MulticastDelegate // TypeDefIndex: 12825
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D293D0 Offset: 0x1D294D1 VA: 0x1D293D0
	|-NexVersus.DownloadMetaDataSequence.EndCallback<object>..ctor
	|-NexVersus.DownloadMetaDataSequence.EndCallback<VersusServerCasualMetaData>..ctor
	|-NexVersus.DownloadMetaDataSequence.EndCallback<VersusServerRankedMetaData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(NexVersus.Results result, T metaData, NexVersus.ResultInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D293F0 Offset: 0x1D294F1 VA: 0x1D293F0
	|-NexVersus.DownloadMetaDataSequence.EndCallback<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(NexVersus.Results result, T metaData, NexVersus.ResultInfo info, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29680 Offset: 0x1D29781 VA: 0x1D29680
	|-NexVersus.DownloadMetaDataSequence.EndCallback<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29730 Offset: 0x1D29831 VA: 0x1D29730
	|-NexVersus.DownloadMetaDataSequence.EndCallback<object>.EndInvoke
	*/
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
private enum NexVersus.DownloadMetaDataSequence.Label<T> // TypeDefIndex: 12827
{
	// Fields
	public int value__; // 0x0
	public const NexVersus.DownloadMetaDataSequence.Label<T> Error = 0;
	public const NexVersus.DownloadMetaDataSequence.Label<T> ErrorApp = 1;
	public const NexVersus.DownloadMetaDataSequence.Label<T> End = 2;
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
[CompilerGeneratedAttribute] // RVA: 0x278780 Offset: 0x278881 VA: 0x278780
private sealed class NexVersus.<>c__DisplayClass101_0 // TypeDefIndex: 12829
{
	// Fields
	public NexVersus.CasualMetaDataEndCallback endCallback; // 0x10

	// Methods

	// RVA: 0x1F0A3C0 Offset: 0x1F0A4C1 VA: 0x1F0A3C0
	public void .ctor() { }

	// RVA: 0x1F0A3D0 Offset: 0x1F0A4D1 VA: 0x1F0A3D0
	internal void <DownloadCasualMetaPrincipalID>g__callback|0(NexVersus.Results result, VersusServerCasualMetaData metaData, NexVersus.ResultInfo info) { }
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

