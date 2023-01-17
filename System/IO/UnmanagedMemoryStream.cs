// Namespace: System.IO
public class UnmanagedMemoryStream : Stream // TypeDefIndex: 655
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0x47DE80 Offset: 0x47DF81 VA: 0x47DE80
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x34CA500 Offset: 0x34CA601 VA: 0x34CA500
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x47C330 Offset: 0x47C431 VA: 0x47C330
	// RVA: 0x34CA580 Offset: 0x34CA681 VA: 0x34CA580
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x34CA860 Offset: 0x34CA961 VA: 0x34CA860
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x34CA620 Offset: 0x34CA721 VA: 0x34CA620
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x34CA910 Offset: 0x34CAA11 VA: 0x34CA910 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x34CA930 Offset: 0x34CAA31 VA: 0x34CA930 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x34CA940 Offset: 0x34CAA41 VA: 0x34CA940 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34CA960 Offset: 0x34CAA61 VA: 0x34CA960 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34CA980 Offset: 0x34CAA81 VA: 0x34CA980 Slot: 20
	public override void Flush() { }

	// RVA: 0x34CA9A0 Offset: 0x34CAAA1 VA: 0x34CA9A0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x34CA9E0 Offset: 0x34CAAE1 VA: 0x34CA9E0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x34CAA20 Offset: 0x34CAB21 VA: 0x34CAA20 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x34CAAD0 Offset: 0x34CABD1 VA: 0x34CAAD0
	public byte* get_PositionPointer() { }

	// RVA: 0x34CABD0 Offset: 0x34CACD1 VA: 0x34CABD0 Slot: 29
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C350 Offset: 0x47C451 VA: 0x47C350
	// RVA: 0x34CAEE0 Offset: 0x34CAFE1 VA: 0x34CAEE0 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34CB260 Offset: 0x34CB361 VA: 0x34CB260 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x34CB3D0 Offset: 0x34CB4D1 VA: 0x34CB3D0 Slot: 27
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x34CB510 Offset: 0x34CB611 VA: 0x34CB510 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x34CB6E0 Offset: 0x34CB7E1 VA: 0x34CB6E0 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C370 Offset: 0x47C471 VA: 0x47C370
	// RVA: 0x34CBAD0 Offset: 0x34CBBD1 VA: 0x34CBAD0 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34CBDD0 Offset: 0x34CBED1 VA: 0x34CBDD0 Slot: 32
	public override void WriteByte(byte value) { }
}

