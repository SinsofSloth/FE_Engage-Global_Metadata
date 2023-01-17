// Namespace: App
public class VersusServerMetaData // TypeDefIndex: 13774
{
	// Fields
	public const int BufferSize = 1024;
	protected byte[] m_Buffer; // 0x10
	protected Stream m_Stream; // 0x18
	protected ulong m_DataId; // 0x20
	protected string m_DataCode; // 0x28

	// Properties
	public ulong DataId { get; set; }
	public string DataCode { get; set; }
	public byte[] Buffer { get; }
	public int Size { get; }

	// Methods

	// RVA: 0x2A55D70 Offset: 0x2A55E71 VA: 0x2A55D70
	protected void .ctor() { }

	// RVA: 0x2A55EC0 Offset: 0x2A55FC1 VA: 0x2A55EC0 Slot: 4
	public virtual void Clear() { }

	// RVA: 0x2A56B70 Offset: 0x2A56C71 VA: 0x2A56B70
	public void SetBinary(byte[] bin) { }

	// RVA: 0x2A56B90 Offset: 0x2A56C91 VA: 0x2A56B90
	public void SetBinary(List<byte> bin) { }

	// RVA: 0x2A56010 Offset: 0x2A56111 VA: 0x2A56010 Slot: 5
	public virtual void CopyFrom(VersusServerMetaData metaData) { }

	// RVA: 0x2A56BF0 Offset: 0x2A56CF1 VA: 0x2A56BF0 Slot: 6
	public virtual void Serialize() { }

	// RVA: 0x2A56C00 Offset: 0x2A56D01 VA: 0x2A56C00 Slot: 7
	public virtual bool Deserialize() { }

	// RVA: 0x2A56C10 Offset: 0x2A56D11 VA: 0x2A56C10
	public ulong get_DataId() { }

	// RVA: 0x2A56C20 Offset: 0x2A56D21 VA: 0x2A56C20
	public void set_DataId(ulong value) { }

	// RVA: 0x2A56C30 Offset: 0x2A56D31 VA: 0x2A56C30
	public string get_DataCode() { }

	// RVA: 0x2A56C40 Offset: 0x2A56D41 VA: 0x2A56C40
	public void set_DataCode(string value) { }

	// RVA: 0x2A56C50 Offset: 0x2A56D51 VA: 0x2A56C50
	public byte[] get_Buffer() { }

	// RVA: 0x2A56C60 Offset: 0x2A56D61 VA: 0x2A56C60
	public int get_Size() { }
}

