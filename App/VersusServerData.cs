// Namespace: App
public class VersusServerData // TypeDefIndex: 13773
{
	// Fields
	public const int BufferSize = 131072;
	protected byte[] m_Buffer; // 0x10
	protected Stream m_Stream; // 0x18
	protected bool m_IsEmpty; // 0x20

	// Properties
	public byte[] Buffer { get; }
	public int Size { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x2A53380 Offset: 0x2A53481 VA: 0x2A53380
	protected void .ctor() { }

	// RVA: 0x2A56AA0 Offset: 0x2A56BA1 VA: 0x2A56AA0
	public void Clear() { }

	// RVA: 0x2A56AD0 Offset: 0x2A56BD1 VA: 0x2A56AD0
	public void SetBinary(byte[] bin) { }

	// RVA: 0x2A53710 Offset: 0x2A53811 VA: 0x2A53710 Slot: 4
	public virtual void Serialize() { }

	// RVA: 0x2A56B30 Offset: 0x2A56C31 VA: 0x2A56B30 Slot: 5
	public virtual bool Deserialize() { }

	// RVA: 0x2A56B40 Offset: 0x2A56C41 VA: 0x2A56B40
	public byte[] get_Buffer() { }

	// RVA: 0x2A56B50 Offset: 0x2A56C51 VA: 0x2A56B50
	public int get_Size() { }

	// RVA: 0x2A56B60 Offset: 0x2A56C61 VA: 0x2A56B60
	public bool get_IsEmpty() { }
}

