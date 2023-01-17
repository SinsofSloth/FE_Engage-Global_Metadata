// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 1745
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x32E9300 Offset: 0x32E9401 VA: 0x32E9300
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x3303240 Offset: 0x3303341 VA: 0x3303240 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x33032D0 Offset: 0x33033D1 VA: 0x33032D0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x33033F0 Offset: 0x33034F1 VA: 0x33033F0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3303410 Offset: 0x3303511 VA: 0x3303410 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3303430 Offset: 0x3303531 VA: 0x3303430 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x3303450 Offset: 0x3303551 VA: 0x3303450 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x3303470 Offset: 0x3303571 VA: 0x3303470 Slot: 20
	public override void Flush() { }

	// RVA: 0x3303490 Offset: 0x3303591 VA: 0x3303490 Slot: 29
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x33034B0 Offset: 0x33035B1 VA: 0x33034B0 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x33034D0 Offset: 0x33035D1 VA: 0x33034D0 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x33034F0 Offset: 0x33035F1 VA: 0x33034F0 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x3303510 Offset: 0x3303611 VA: 0x3303510 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x3303530 Offset: 0x3303631 VA: 0x3303530 Slot: 32
	public override void WriteByte(byte value) { }

	// RVA: 0x3303550 Offset: 0x3303651 VA: 0x3303550 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3303560 Offset: 0x3303661 VA: 0x3303560 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3303570 Offset: 0x3303671 VA: 0x3303570 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x3303580 Offset: 0x3303681 VA: 0x3303580 Slot: 11
	public override long get_Length() { }

	// RVA: 0x3303590 Offset: 0x3303691 VA: 0x3303590 Slot: 12
	public override long get_Position() { }

	// RVA: 0x33035A0 Offset: 0x33036A1 VA: 0x33035A0 Slot: 13
	public override void set_Position(long value) { }
}

