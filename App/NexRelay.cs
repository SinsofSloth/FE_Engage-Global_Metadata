// Namespace: App
internal class NexRelay : SingletonClass<NexRelay> // TypeDefIndex: 12764
{
	// Fields
	private const ushort Period = 7;
	public const uint MaxSearchCount = 20;
	private NexRelay.Results m_LastResult; // 0x1C
	private ulong m_LastUploadedDataId; // 0x20

	// Properties
	public NexRelay.Results LastResult { get; }
	public ulong LastUploadedDataId { get; }

	// Methods

	// RVA: 0x23576D0 Offset: 0x23577D1 VA: 0x23576D0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2357770 Offset: 0x2357871 VA: 0x2357770
	public void UploadNew(ProcInst super, string playerName, RelayServerMetaData metaData, RelayServerData data, bool isSecret = False) { }

	// RVA: 0x23577A0 Offset: 0x23578A1 VA: 0x23577A0
	public void UploadTakeOver(ProcInst super, ulong dataId, RelayServerMetaData oldMetaData, string playerName, RelayServerMetaData newMetaData, RelayServerData data, bool isChangeToPublic = False) { }

	// RVA: 0x23577D0 Offset: 0x23578D1 VA: 0x23577D0
	public void Search(ProcInst super, List<RelayServerMetaData> results) { }

	// RVA: 0x23577F0 Offset: 0x23578F1 VA: 0x23577F0
	public void SetPlaying(ProcInst super, ulong dataId, RelayServerMetaData oldMetaData, RelayServerMetaData newMetaData) { }

	// RVA: 0x2357810 Offset: 0x2357911 VA: 0x2357810
	public void Download(ProcInst super, ulong dataId, RelayServerData result, RelayServerMetaData resultMeta) { }

	// RVA: 0x2357830 Offset: 0x2357931 VA: 0x2357830
	public void DownloadMeta(ProcInst super, List<ulong> dataIds, List<RelayServerMetaData> results) { }

	// RVA: 0x2357850 Offset: 0x2357951 VA: 0x2357850
	public void DownloadMeta(ProcInst super, string dataCode, RelayServerMetaData result) { }

	// RVA: 0x2357870 Offset: 0x2357971 VA: 0x2357870
	public bool TryGetPrincipalId(out ulong principalId) { }

	// RVA: 0x23578A0 Offset: 0x23579A1 VA: 0x23578A0
	public NexRelay.Results get_LastResult() { }

	// RVA: 0x23578B0 Offset: 0x23579B1 VA: 0x23578B0
	public ulong get_LastUploadedDataId() { }

	// RVA: 0x23578C0 Offset: 0x23579C1 VA: 0x23578C0
	public static void CloseWaitMessage(ProcInst super, bool isSuccess = True) { }

	// RVA: 0x23578E0 Offset: 0x23579E1 VA: 0x23578E0
	public void .ctor() { }
}

