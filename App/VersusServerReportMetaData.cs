// Namespace: App
public class VersusServerReportMetaData // TypeDefIndex: 13779
{
	// Fields
	public const int BufferSize = 1024;
	private const ushort Version = 0;
	private byte[] m_Buffer; // 0x10
	private Stream m_Stream; // 0x18
	public const int DataIdListSize = 30;
	private List<ulong> m_DataIdList; // 0x20

	// Properties
	public byte[] Buffer { get; }
	public int Size { get; }

	// Methods

	// RVA: 0x2A59E10 Offset: 0x2A59F11 VA: 0x2A59E10
	public void .ctor() { }

	// RVA: 0x2A59F60 Offset: 0x2A5A061 VA: 0x2A59F60
	public void Clear() { }

	// RVA: 0x2A59FC0 Offset: 0x2A5A0C1 VA: 0x2A59FC0
	public void SetBinary(byte[] bin) { }

	// RVA: 0x2A5A060 Offset: 0x2A5A161 VA: 0x2A5A060
	public void SetBinary(List<byte> bin) { }

	// RVA: 0x2A5A110 Offset: 0x2A5A211 VA: 0x2A5A110
	public List<byte> GetBinary() { }

	// RVA: 0x2A5A1D0 Offset: 0x2A5A2D1 VA: 0x2A5A1D0
	public void AddDataId(ulong dataId) { }

	// RVA: 0x2A5A2A0 Offset: 0x2A5A3A1 VA: 0x2A5A2A0
	public bool Contains(ulong dataId) { }

	// RVA: 0x2A5A300 Offset: 0x2A5A401 VA: 0x2A5A300
	public byte[] get_Buffer() { }

	// RVA: 0x2A5A310 Offset: 0x2A5A411 VA: 0x2A5A310
	public int get_Size() { }

	[ConditionalAttribute] // RVA: 0x2CD4E0 Offset: 0x2CD5E1 VA: 0x2CD4E0
	// RVA: 0x2A5A320 Offset: 0x2A5A421 VA: 0x2A5A320
	public void Dump() { }

	// RVA: 0x2A5A550 Offset: 0x2A5A651 VA: 0x2A5A550
	public string ToStringIDs() { }

	// RVA: 0x2A5A5A0 Offset: 0x2A5A6A1 VA: 0x2A5A5A0
	public void Serialize() { }

	// RVA: 0x2A5A680 Offset: 0x2A5A781 VA: 0x2A5A680
	public void Deserialize() { }
}

