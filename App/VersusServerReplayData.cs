// Namespace: App
public class VersusServerReplayData // TypeDefIndex: 13777
{
	// Fields
	private const int BufferSize = 688128;
	private const ushort Version = 1;
	private byte[] m_Buffer; // 0x10
	private Stream m_Stream; // 0x18
	private bool m_IsEmpty; // 0x20

	// Properties
	public byte[] Buffer { get; }
	public int Size { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x2A44C50 Offset: 0x2A44D51 VA: 0x2A44C50
	public void .ctor() { }

	// RVA: 0x2A58600 Offset: 0x2A58701 VA: 0x2A58600
	public void Clear() { }

	// RVA: 0x2A58630 Offset: 0x2A58731 VA: 0x2A58630
	public void SetBinary(byte[] bin) { }

	// RVA: 0x2A46040 Offset: 0x2A46141 VA: 0x2A46040
	public void Serialize() { }

	// RVA: 0x2A58690 Offset: 0x2A58791 VA: 0x2A58690
	public bool Deserialize() { }

	// RVA: 0x2A58C30 Offset: 0x2A58D31 VA: 0x2A58C30
	public byte[] get_Buffer() { }

	// RVA: 0x2A58C40 Offset: 0x2A58D41 VA: 0x2A58C40
	public int get_Size() { }

	// RVA: 0x2A58C50 Offset: 0x2A58D51 VA: 0x2A58C50
	public bool get_IsEmpty() { }
}

