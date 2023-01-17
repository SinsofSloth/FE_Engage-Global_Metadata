// Namespace: 
public enum NexRelay.Results // TypeDefIndex: 12748
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.Results Failed = 0;
	public const NexRelay.Results FailedCompare = 1;
	public const NexRelay.Results FailedNotFound = 2;
	public const NexRelay.Results Cancelled = 3;
	public const NexRelay.Results Succeeded = 4;
}

// Namespace: 
private class NexRelay.ServerSequenceBase.ConfirmRetryDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 12749
{
	// Fields
	private int m_Label; // 0x70

	// Methods

	// RVA: 0x2D7DA70 Offset: 0x2D7DB71 VA: 0x2D7DA70
	public void .ctor(int label) { }

	// RVA: 0x2D7DAA0 Offset: 0x2D7DBA1 VA: 0x2D7DAA0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7DAD0 Offset: 0x2D7DBD1 VA: 0x2D7DAD0
	private ProcInst GetSequence() { }
}

// Namespace: 
protected static class NexRelay.ServerSequenceBase.ConfirmRetryDialog // TypeDefIndex: 12750
{
	// Methods

	// RVA: 0x21F1C10 Offset: 0x21F1D11 VA: 0x21F1C10
	public static void CreateBind(ProcInst super, int yesLabel) { }
}

// Namespace: 
private class NexRelay.ServerSequenceBase : ProcInst // TypeDefIndex: 12751
{
	// Methods

	// RVA: 0x26F6AA0 Offset: 0x26F6BA1 VA: 0x26F6AA0
	protected void Login() { }

	// RVA: 0x26F3910 Offset: 0x26F3A11 VA: 0x26F3910
	protected void Postlogin(int labelWhenCancelled, int labelWhenFailed) { }

	// RVA: 0x26F4360 Offset: 0x26F4461 VA: 0x26F4360
	protected void SetResult(NexRelay.Results result) { }

	// RVA: 0x26F40C0 Offset: 0x26F41C1 VA: 0x26F40C0
	protected void SetResultFailed(AsyncResult error) { }

	// RVA: 0x26F3E40 Offset: 0x26F3F41 VA: 0x26F3E40
	protected void SetResultFailed(NetError.App error) { }

	// RVA: 0x26F6B10 Offset: 0x26F6C11 VA: 0x26F6B10
	protected void SetResultFailedCompare() { }

	// RVA: 0x26F45A0 Offset: 0x26F46A1 VA: 0x26F45A0
	protected void SetResultFailedNotFound() { }

	// RVA: 0x26F6B90 Offset: 0x26F6C91 VA: 0x26F6B90
	protected void Error() { }

	// RVA: 0x26F6C00 Offset: 0x26F6D01 VA: 0x26F6C00
	protected void SetMetaBinary(List<byte> paramMetaBytes, RelayServerMetaData metaData, bool forCompare = False) { }

	// RVA: 0x26F6CF0 Offset: 0x26F6DF1 VA: 0x26F6CF0
	protected void ComplementTime(RelayServerMetaData metaData) { }

	// RVA: 0x26F4190 Offset: 0x26F4291 VA: 0x26F4190
	protected RelayServerMetaData GetMetaInfoResultOne(DataStoreMetaInfo info, RelayServerMetaData result) { }

	// RVA: 0x26F63C0 Offset: 0x26F64C1 VA: 0x26F63C0
	protected void SetFromMetaInfo(RelayServerMetaData metaData, DataStoreMetaInfo metaInfo) { }

	// RVA: 0x26F6D70 Offset: 0x26F6E71 VA: 0x26F6D70
	protected bool IsSecret(DataStoreMetaInfo metaInfo) { }

	// RVA: 0x26F38A0 Offset: 0x26F39A1 VA: 0x26F38A0
	public void .ctor() { }
}

// Namespace: 
private enum NexRelay.UploadNewSequence.Label // TypeDefIndex: 12752
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.UploadNewSequence.Label Login = 0;
	public const NexRelay.UploadNewSequence.Label Error = 1;
	public const NexRelay.UploadNewSequence.Label End = 2;
}

// Namespace: 
private class NexRelay.UploadNewSequence : NexRelay.ServerSequenceBase // TypeDefIndex: 12753
{
	// Fields
	private string m_PlayerName; // 0x70
	private RelayServerMetaData m_MetaData; // 0x78
	private RelayServerData m_Data; // 0x80
	private bool m_IsComplemented; // 0x88

	// Methods

	// RVA: 0x26F79B0 Offset: 0x26F7AB1 VA: 0x26F79B0
	private void .ctor(string playerName, RelayServerMetaData metaData, RelayServerData data, bool isSecret) { }

	// RVA: 0x26F7A40 Offset: 0x26F7B41 VA: 0x26F7A40
	private void Postlogin() { }

	// RVA: 0x26F7A50 Offset: 0x26F7B51 VA: 0x26F7A50
	private void Post() { }

	// RVA: 0x26F7E60 Offset: 0x26F7F61 VA: 0x26F7E60
	private void PostResult(AsyncResult asyncResult, ulong dataId) { }

	// RVA: 0x26F7D20 Offset: 0x26F7E21 VA: 0x26F7D20
	private void ComplementMetaData() { }

	// RVA: 0x26F8020 Offset: 0x26F8121 VA: 0x26F8020
	private void ConfirmRetry() { }

	// RVA: 0x26F8030 Offset: 0x26F8131 VA: 0x26F8030
	public static void CreateBind(ProcInst super, string playerName, RelayServerMetaData metaData, RelayServerData data, bool isSecret) { }
}

// Namespace: 
private enum NexRelay.UploadTakeOverSequence.Label // TypeDefIndex: 12754
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.UploadTakeOverSequence.Label Login = 0;
	public const NexRelay.UploadTakeOverSequence.Label UpdateData = 1;
	public const NexRelay.UploadTakeOverSequence.Label Error = 2;
	public const NexRelay.UploadTakeOverSequence.Label ErrorApp = 3;
	public const NexRelay.UploadTakeOverSequence.Label End = 4;
}

// Namespace: 
private class NexRelay.UploadTakeOverSequence : NexRelay.ServerSequenceBase // TypeDefIndex: 12755
{
	// Fields
	private const DataStore.ModificationFlag DefaultModificationFlag = 80;
	private ulong m_DataId; // 0x70
	private RelayServerMetaData m_OldMetaData; // 0x78
	private string m_PlayerName; // 0x80
	private RelayServerMetaData m_NewMetaData; // 0x88
	private RelayServerData m_Data; // 0x90
	private bool m_IsComplementedNewMetaData; // 0x98
	private bool m_IsChangeToPublic; // 0x99

	// Methods

	// RVA: 0x26F86E0 Offset: 0x26F87E1 VA: 0x26F86E0
	private void .ctor(ulong dataId, RelayServerMetaData oldMetaData, string playerName, RelayServerMetaData newMetaData, RelayServerData data, bool isChangeToPublic) { }

	// RVA: 0x26F8790 Offset: 0x26F8891 VA: 0x26F8790
	private void Postlogin() { }

	// RVA: 0x26F87A0 Offset: 0x26F88A1 VA: 0x26F87A0
	private void ChangeMeta() { }

	// RVA: 0x26F8B10 Offset: 0x26F8C11 VA: 0x26F8B10
	private void ChangeMetaResult(AsyncResult asyncResult) { }

	// RVA: 0x26F89D0 Offset: 0x26F8AD1 VA: 0x26F89D0
	private void ComplementNewMetaData() { }

	// RVA: 0x26F8CC0 Offset: 0x26F8DC1 VA: 0x26F8CC0
	private void UpdateData() { }

	// RVA: 0x26F8EA0 Offset: 0x26F8FA1 VA: 0x26F8EA0
	private void UpdateDataResult(AsyncResult asyncResult) { }

	// RVA: 0x26F9040 Offset: 0x26F9141 VA: 0x26F9040
	private void ConfirmRetry() { }

	// RVA: 0x26F9050 Offset: 0x26F9151 VA: 0x26F9050
	public static void CreateBind(ProcInst super, ulong dataId, RelayServerMetaData oldMetaData, string playerName, RelayServerMetaData newMetaData, RelayServerData data, bool isChangeToPublic) { }
}

// Namespace: 
private enum NexRelay.SearchSequence.Label // TypeDefIndex: 12756
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.SearchSequence.Label Error = 0;
	public const NexRelay.SearchSequence.Label End = 1;
}

// Namespace: 
private class NexRelay.SearchSequence : NexRelay.ServerSequenceBase // TypeDefIndex: 12757
{
	// Fields
	private List<RelayServerMetaData> m_Results; // 0x70

	// Methods

	// RVA: 0x26F5F30 Offset: 0x26F6031 VA: 0x26F5F30
	private void .ctor(List<RelayServerMetaData> results) { }

	// RVA: 0x26F5FB0 Offset: 0x26F60B1 VA: 0x26F5FB0
	private void Postlogin() { }

	// RVA: 0x26F5FC0 Offset: 0x26F60C1 VA: 0x26F5FC0
	private void Search() { }

	// RVA: 0x26F61B0 Offset: 0x26F62B1 VA: 0x26F61B0
	private void SearchResult(AsyncResult asyncResult, DataStoreSearchResult searchResult) { }

	// RVA: 0x26F64D0 Offset: 0x26F65D1 VA: 0x26F64D0
	public static void CreateBind(ProcInst super, List<RelayServerMetaData> results) { }
}

// Namespace: 
private enum NexRelay.SetPlayingSequence.Label // TypeDefIndex: 12758
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.SetPlayingSequence.Label Login = 0;
	public const NexRelay.SetPlayingSequence.Label Error = 1;
	public const NexRelay.SetPlayingSequence.Label ErrorApp = 2;
	public const NexRelay.SetPlayingSequence.Label End = 3;
}

// Namespace: 
private class NexRelay.SetPlayingSequence : NexRelay.ServerSequenceBase // TypeDefIndex: 12759
{
	// Fields
	private const DataStore.ModificationFlag ModificationFlags = 80;
	private ulong m_DataId; // 0x70
	private RelayServerMetaData m_OldMetaData; // 0x78
	private RelayServerMetaData m_NewMetaData; // 0x80
	private bool m_IsComplementedNewMetaData; // 0x88

	// Methods

	// RVA: 0x26F6D80 Offset: 0x26F6E81 VA: 0x26F6D80
	private void .ctor(ulong dataId, RelayServerMetaData oldMetaData, RelayServerMetaData newMetaData) { }

	// RVA: 0x26F6DE0 Offset: 0x26F6EE1 VA: 0x26F6DE0
	private void Postlogin() { }

	// RVA: 0x26F6DF0 Offset: 0x26F6EF1 VA: 0x26F6DF0
	private void ChangeMeta() { }

	// RVA: 0x26F7080 Offset: 0x26F7181 VA: 0x26F7080
	private void ChangeMetaResult(AsyncResult asyncResult) { }

	// RVA: 0x26F7020 Offset: 0x26F7121 VA: 0x26F7020
	private void ComplementNewMetaData() { }

	// RVA: 0x26F7280 Offset: 0x26F7381 VA: 0x26F7280
	private void ConfirmRetry() { }

	// RVA: 0x26F7290 Offset: 0x26F7391 VA: 0x26F7290
	public static void CreateBind(ProcInst super, ulong dataId, RelayServerMetaData oldMetaData, RelayServerMetaData newMetaData) { }
}

// Namespace: 
private enum NexRelay.DownloadSequence.Label // TypeDefIndex: 12760
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.DownloadSequence.Label Login = 0;
	public const NexRelay.DownloadSequence.Label GetData = 1;
	public const NexRelay.DownloadSequence.Label Error = 2;
	public const NexRelay.DownloadSequence.Label ErrorApp = 3;
	public const NexRelay.DownloadSequence.Label End = 4;
}

// Namespace: 
private class NexRelay.DownloadSequence : NexRelay.ServerSequenceBase // TypeDefIndex: 12761
{
	// Fields
	private ulong m_DataId; // 0x70
	private RelayServerData m_Result; // 0x78
	private RelayServerMetaData m_ResultMeta; // 0x80

	// Methods

	// RVA: 0x26F4E10 Offset: 0x26F4F11 VA: 0x26F4E10
	private void .ctor(ulong dataId, RelayServerData result, RelayServerMetaData resultMeta) { }

	// RVA: 0x26F4EA0 Offset: 0x26F4FA1 VA: 0x26F4EA0
	private void Postlogin() { }

	// RVA: 0x26F4EB0 Offset: 0x26F4FB1 VA: 0x26F4EB0
	private bool IsNeedToGetMetaInfo() { }

	// RVA: 0x26F4EC0 Offset: 0x26F4FC1 VA: 0x26F4EC0
	private void GetMetaInfo() { }

	// RVA: 0x26F5090 Offset: 0x26F5191 VA: 0x26F5090
	private void GetMetaInfoResult(AsyncResult asyncResult, DataStoreMetaInfo info) { }

	// RVA: 0x26F5230 Offset: 0x26F5331 VA: 0x26F5230
	private void GetData() { }

	// RVA: 0x26F5410 Offset: 0x26F5511 VA: 0x26F5410
	private void GetDataResult(AsyncResult asyncResult, byte[] data) { }

	// RVA: 0x26F55C0 Offset: 0x26F56C1 VA: 0x26F55C0
	private void ConfirmRetry() { }

	// RVA: 0x26F55D0 Offset: 0x26F56D1 VA: 0x26F55D0
	public static void CreateBind(ProcInst super, ulong dataId, RelayServerData result, RelayServerMetaData resultMeta) { }
}

// Namespace: 
private enum NexRelay.DownloadMetaSequence.Label // TypeDefIndex: 12762
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.DownloadMetaSequence.Label Error = 0;
	public const NexRelay.DownloadMetaSequence.Label ErrorApp = 1;
	public const NexRelay.DownloadMetaSequence.Label End = 2;
}

// Namespace: 
private class NexRelay.DownloadMetaSequence : NexRelay.ServerSequenceBase // TypeDefIndex: 12763
{
	// Fields
	private List<ulong> m_DataIds; // 0x70
	private List<RelayServerMetaData> m_Results; // 0x78
	private string m_DataCode; // 0x80
	private RelayServerMetaData m_DataCodeResult; // 0x88

	// Methods

	// RVA: 0x26F3810 Offset: 0x26F3911 VA: 0x26F3810
	private void .ctor(List<ulong> dataIds, List<RelayServerMetaData> results) { }

	// RVA: 0x26F38B0 Offset: 0x26F39B1 VA: 0x26F38B0
	private void .ctor(string dataCode, RelayServerMetaData result) { }

	// RVA: 0x26F3900 Offset: 0x26F3A01 VA: 0x26F3900
	private void Postlogin() { }

	// RVA: 0x26F3B40 Offset: 0x26F3C41 VA: 0x26F3B40
	private void GetMetaInfo() { }

	// RVA: 0x26F3F10 Offset: 0x26F4011 VA: 0x26F3F10
	private void GetMetaInfoResult(AsyncResult asyncResult, List<DataStoreMetaInfo> infos, List<DataStoreResult> results) { }

	// RVA: 0x26F43F0 Offset: 0x26F44F1 VA: 0x26F43F0
	private void GetMetaInfoResult(AsyncResult asyncResult, DataStoreMetaInfo info) { }

	// RVA: 0x26F4620 Offset: 0x26F4721 VA: 0x26F4620
	public static void CreateBind(ProcInst super, List<ulong> dataIds, List<RelayServerMetaData> results) { }

	// RVA: 0x26F4D70 Offset: 0x26F4E71 VA: 0x26F4D70
	public static void CreateBind(ProcInst super, string dataCode, RelayServerMetaData result) { }

	// RVA: 0x26F4700 Offset: 0x26F4801 VA: 0x26F4700
	private static void CreateBindImpl(ProcInst super, NexRelay.DownloadMetaSequence p) { }
}

