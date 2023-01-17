// Namespace: App
internal class RelayServerData // TypeDefIndex: 12861
{
	// Fields
	private const int BufferSize = 688128;
	private const ushort Version = 5;
	private byte[] m_Buffer; // 0x10
	private Stream m_Stream; // 0x18
	private byte m_Message; // 0x20
	private List<RelayLeavingUnitData> m_LeavingUnitData; // 0x28
	private bool m_IsEmpty; // 0x30

	// Properties
	public byte[] Buffer { get; }
	public int Size { get; }
	public bool IsEmpty { get; }
	public byte Message { get; set; }
	public List<RelayLeavingUnitData> LeavingUnitData { get; }

	// Methods

	// RVA: 0x24C1110 Offset: 0x24C1211 VA: 0x24C1110
	public void .ctor() { }

	// RVA: 0x24C12E0 Offset: 0x24C13E1 VA: 0x24C12E0
	public void SetBinary(byte[] bin) { }

	// RVA: 0x24C1270 Offset: 0x24C1371 VA: 0x24C1270
	public void Clear() { }

	// RVA: 0x24C1380 Offset: 0x24C1481 VA: 0x24C1380
	public void Serialize() { }

	// RVA: 0x24BF130 Offset: 0x24BF231 VA: 0x24BF130
	public bool Deserialize() { }

	// RVA: 0x24C16C0 Offset: 0x24C17C1 VA: 0x24C16C0
	public byte[] get_Buffer() { }

	// RVA: 0x24C16D0 Offset: 0x24C17D1 VA: 0x24C16D0
	public int get_Size() { }

	// RVA: 0x24C16E0 Offset: 0x24C17E1 VA: 0x24C16E0
	public bool get_IsEmpty() { }

	// RVA: 0x24C16F0 Offset: 0x24C17F1 VA: 0x24C16F0
	public byte get_Message() { }

	// RVA: 0x24C1700 Offset: 0x24C1801 VA: 0x24C1700
	public void set_Message(byte value) { }

	// RVA: 0x24C1710 Offset: 0x24C1811 VA: 0x24C1710
	public List<RelayLeavingUnitData> get_LeavingUnitData() { }
}

