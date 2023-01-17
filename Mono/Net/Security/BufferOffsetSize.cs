// Namespace: Mono.Net.Security
internal class BufferOffsetSize // TypeDefIndex: 2178
{
	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Properties
	public int EndOffset { get; }
	public int Remaining { get; }

	// Methods

	// RVA: 0x1B40DE0 Offset: 0x1B40EE1 VA: 0x1B40DE0
	public int get_EndOffset() { }

	// RVA: 0x1B40DF0 Offset: 0x1B40EF1 VA: 0x1B40DF0
	public int get_Remaining() { }

	// RVA: 0x1B3E890 Offset: 0x1B3E991 VA: 0x1B3E890
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x1B40E10 Offset: 0x1B40F11 VA: 0x1B40E10 Slot: 3
	public override string ToString() { }
}

