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

