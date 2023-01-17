// Namespace: App
public class VersusServerReplayMetaData // TypeDefIndex: 13778
{
	// Fields
	public const int BufferSize = 1024;
	private const ushort Version = 2;
	private ushort m_Version; // 0x10
	private byte[] m_Buffer; // 0x18
	private Stream m_Stream; // 0x20
	private ulong m_DataId; // 0x28
	private ulong m_OffensePrincipalId; // 0x30
	private string m_OffensePlayerName; // 0x38
	private long m_MapEndUnixTime; // 0x40
	private Versus.MapResult m_MapResult; // 0x48
	private bool m_IsEnable; // 0x4C
	private bool m_IsEmpty; // 0x4D

	// Properties
	public byte[] Buffer { get; }
	public int Size { get; }
	public ulong DataId { get; set; }
	public bool IsEmpty { get; }
	public ulong OffensePrincipalId { get; }
	public string OffensePlayerName { get; }
	public long MapEndUnixTime { get; }
	public string MapEndUnixTimeStr { get; }
	public Versus.MapResult Result { get; }
	public Versus.MapResult ResultForDefense { get; }
	public bool IsEnable { get; }
	public bool IsClearReliance { get; }

	// Methods

	// RVA: 0x2A44D20 Offset: 0x2A44E21 VA: 0x2A44D20
	public void .ctor() { }

	// RVA: 0x2A58C60 Offset: 0x2A58D61 VA: 0x2A58C60
	public void Clear() { }

	// RVA: 0x2A58CB0 Offset: 0x2A58DB1 VA: 0x2A58CB0
	public void SetBinary(byte[] bin) { }

	// RVA: 0x2A58D40 Offset: 0x2A58E41 VA: 0x2A58D40
	public void SetBinary(List<byte> bin) { }

	// RVA: 0x2A58DB0 Offset: 0x2A58EB1 VA: 0x2A58DB0
	public void SetMapResult(Versus.MapResult result) { }

	// RVA: 0x2A46330 Offset: 0x2A46431 VA: 0x2A46330
	public void TrySetMapEndTime(long unixTime) { }

	// RVA: 0x2A58DC0 Offset: 0x2A58EC1 VA: 0x2A58DC0
	public void SetOffensePlayer(ulong principalId, string offensePlayerName) { }

	// RVA: 0x2A58DD0 Offset: 0x2A58ED1 VA: 0x2A58DD0
	public void Disable() { }

	[ConditionalAttribute] // RVA: 0x2CD4A0 Offset: 0x2CD5A1 VA: 0x2CD4A0
	// RVA: 0x2A58DE0 Offset: 0x2A58EE1 VA: 0x2A58DE0
	public void Dump(string opt = "") { }

	// RVA: 0x2A590E0 Offset: 0x2A591E1 VA: 0x2A590E0
	public void Serialize() { }

	// RVA: 0x2A592D0 Offset: 0x2A593D1 VA: 0x2A592D0
	public bool Deserialize() { }

	// RVA: 0x2A59A40 Offset: 0x2A59B41 VA: 0x2A59A40
	public byte[] get_Buffer() { }

	// RVA: 0x2A59A50 Offset: 0x2A59B51 VA: 0x2A59A50
	public int get_Size() { }

	// RVA: 0x2A59A60 Offset: 0x2A59B61 VA: 0x2A59A60
	public ulong get_DataId() { }

	// RVA: 0x2A59A70 Offset: 0x2A59B71 VA: 0x2A59A70
	public void set_DataId(ulong value) { }

	// RVA: 0x2A59A80 Offset: 0x2A59B81 VA: 0x2A59A80
	public bool get_IsEmpty() { }

	// RVA: 0x2A59A90 Offset: 0x2A59B91 VA: 0x2A59A90
	public ulong get_OffensePrincipalId() { }

	// RVA: 0x2A59AA0 Offset: 0x2A59BA1 VA: 0x2A59AA0
	public string get_OffensePlayerName() { }

	// RVA: 0x2A59AB0 Offset: 0x2A59BB1 VA: 0x2A59AB0
	public long get_MapEndUnixTime() { }

	// RVA: 0x2A59AC0 Offset: 0x2A59BC1 VA: 0x2A59AC0
	public string get_MapEndUnixTimeStr() { }

	// RVA: 0x2A59B40 Offset: 0x2A59C41 VA: 0x2A59B40
	public Versus.MapResult get_Result() { }

	// RVA: 0x2A59B50 Offset: 0x2A59C51 VA: 0x2A59B50
	public Versus.MapResult get_ResultForDefense() { }

	// RVA: 0x2A59B70 Offset: 0x2A59C71 VA: 0x2A59B70
	public bool get_IsEnable() { }

	// RVA: 0x2A59B80 Offset: 0x2A59C81 VA: 0x2A59B80
	public bool get_IsClearReliance() { }

	// RVA: 0x2A59B90 Offset: 0x2A59C91 VA: 0x2A59B90
	public static VersusServerReplayMetaData TryGetPlayableMetaData(List<VersusServerReplayMetaData> metaDataList) { }

	// RVA: 0x2A59CB0 Offset: 0x2A59DB1 VA: 0x2A59CB0
	public static VersusServerReplayMetaData GetUploadTargetMetaData(List<VersusServerReplayMetaData> metaDataList) { }
}

