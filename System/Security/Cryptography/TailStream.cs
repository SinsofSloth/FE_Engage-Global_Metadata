// Namespace: System.Security.Cryptography
internal sealed class TailStream : Stream // TypeDefIndex: 933
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x365E550 Offset: 0x365E651 VA: 0x365E550
	public void .ctor(int bufferSize) { }

	// RVA: 0x365E600 Offset: 0x365E701 VA: 0x365E600
	public void Clear() { }

	// RVA: 0x365E610 Offset: 0x365E711 VA: 0x365E610 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x365E6C0 Offset: 0x365E7C1 VA: 0x365E6C0
	public byte[] get_Buffer() { }

	// RVA: 0x365E740 Offset: 0x365E841 VA: 0x365E740 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x365E750 Offset: 0x365E851 VA: 0x365E750 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x365E760 Offset: 0x365E861 VA: 0x365E760 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x365E770 Offset: 0x365E871 VA: 0x365E770 Slot: 11
	public override long get_Length() { }

	// RVA: 0x365E7D0 Offset: 0x365E8D1 VA: 0x365E7D0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x365E830 Offset: 0x365E931 VA: 0x365E830 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x365E890 Offset: 0x365E991 VA: 0x365E890 Slot: 20
	public override void Flush() { }

	// RVA: 0x365E8A0 Offset: 0x365E9A1 VA: 0x365E8A0 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x365E900 Offset: 0x365EA01 VA: 0x365E900 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x365E960 Offset: 0x365EA61 VA: 0x365E960 Slot: 29
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x365E9C0 Offset: 0x365EAC1 VA: 0x365E9C0 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }
}

