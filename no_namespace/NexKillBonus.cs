// Namespace: 
private class NexKillBonus.ServerSequence : ProcInst // TypeDefIndex: 12731
{
	// Fields
	private NexKillBonus.ServerSequence.Mode m_Mode; // 0x70
	private string m_Cid; // 0x78
	private MapKillBonus.CountImage m_KillCountImage; // 0x80
	private MapKillBonus.CountImage m_KilledCountImage; // 0x88
	private ulong m_DataId; // 0x90
	private List<DataStoreDeleteParam> m_DeleteParams; // 0x98

	// Methods

	// RVA: 0x26EC3A0 Offset: 0x26EC4A1 VA: 0x26EC3A0
	private void .ctor(NexKillBonus.ServerSequence.Mode mode, string cid, MapKillBonus.CountImage killCountImage, MapKillBonus.CountImage killedCountImage) { }

	// RVA: 0x26EC420 Offset: 0x26EC521 VA: 0x26EC420
	private void Login() { }

	// RVA: 0x26EC490 Offset: 0x26EC591 VA: 0x26EC490
	private void Postlogin() { }

	// RVA: 0x26EC600 Offset: 0x26EC701 VA: 0x26EC600
	private void SearchData() { }

	// RVA: 0x26EC9C0 Offset: 0x26ECAC1 VA: 0x26EC9C0
	private void SearchDataResult(AsyncResult asyncResult, DataStoreSearchResult searchResult) { }

	// RVA: 0x26ECDD0 Offset: 0x26ECED1 VA: 0x26ECDD0
	private void SearchSelfData() { }

	// RVA: 0x26ED070 Offset: 0x26ED171 VA: 0x26ED070
	private void DeleteData() { }

	// RVA: 0x26ED280 Offset: 0x26ED381 VA: 0x26ED280
	private void GetData() { }

	// RVA: 0x26ED500 Offset: 0x26ED601 VA: 0x26ED500
	private void PostData() { }

	// RVA: 0x26ED840 Offset: 0x26ED941 VA: 0x26ED840
	private void UpdateData() { }

	// RVA: 0x26EDAC0 Offset: 0x26EDBC1 VA: 0x26EDAC0
	private void Succeeded() { }

	// RVA: 0x26ECD60 Offset: 0x26ECE61 VA: 0x26ECD60
	private void SetError(AsyncResult error) { }

	// RVA: 0x26EC950 Offset: 0x26ECA51 VA: 0x26EC950
	private void SetError(NetError.App error) { }

	// RVA: 0x26EDB40 Offset: 0x26EDC41 VA: 0x26EDB40
	private void Error() { }

	// RVA: 0x26EDBB0 Offset: 0x26EDCB1 VA: 0x26EDBB0
	private void OpenWaitMessage() { }

	// RVA: 0x26EDBC0 Offset: 0x26EDCC1 VA: 0x26EDBC0
	private void CloseWaitMessage() { }

	// RVA: 0x26EC8A0 Offset: 0x26EC9A1 VA: 0x26EC8A0
	private ushort GetDataType() { }

	// RVA: 0x26EDBE0 Offset: 0x26EDCE1 VA: 0x26EDBE0
	public static void CreateBindDownload(ProcInst super, string cid) { }

	// RVA: 0x26EE870 Offset: 0x26EE971 VA: 0x26EE870
	public static void CreateBindUpload(ProcInst super, string cid, MapKillBonus.CountImage killCountImage, MapKillBonus.CountImage killedCountImage) { }

	// RVA: 0x26EDC00 Offset: 0x26EDD01 VA: 0x26EDC00
	private static void CreateBindImpl(ProcInst super, NexKillBonus.ServerSequence.Mode mode, string cid, MapKillBonus.CountImage killCountImage, MapKillBonus.CountImage killedCountImage) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9FB0 Offset: 0x2CA0B1 VA: 0x2C9FB0
	// RVA: 0x26EE890 Offset: 0x26EE991 VA: 0x26EE890
	private void <SearchSelfData>b__13_0(AsyncResult asyncResult, DataStoreSearchResult searchResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9FC0 Offset: 0x2CA0C1 VA: 0x2C9FC0
	// RVA: 0x26EEA30 Offset: 0x26EEB31 VA: 0x26EEA30
	private void <DeleteData>b__14_0(AsyncResult asyncResult, List<DataStoreResult> deleteResults) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9FD0 Offset: 0x2CA0D1 VA: 0x2C9FD0
	// RVA: 0x26EEAA0 Offset: 0x26EEBA1 VA: 0x26EEAA0
	private void <GetData>b__15_0(AsyncResult asyncResult, byte[] data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9FE0 Offset: 0x2CA0E1 VA: 0x2C9FE0
	// RVA: 0x26EEC90 Offset: 0x26EED91 VA: 0x26EEC90
	private void <PostData>b__16_0(AsyncResult asyncResult, ulong dataId) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9FF0 Offset: 0x2CA0F1 VA: 0x2C9FF0
	// RVA: 0x26EED90 Offset: 0x26EEE91 VA: 0x26EED90
	private void <UpdateData>b__17_0(AsyncResult asyncResult) { }
}

