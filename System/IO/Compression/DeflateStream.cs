// Namespace: System.IO.Compression
public class DeflateStream : Stream // TypeDefIndex: 2386
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1B54710 Offset: 0x1B54811 VA: 0x1B54710
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1B548C0 Offset: 0x1B549C1 VA: 0x1B548C0
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1B54720 Offset: 0x1B54821 VA: 0x1B54720
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x1B54A90 Offset: 0x1B54B91 VA: 0x1B54A90
	internal void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1B54AA0 Offset: 0x1B54BA1 VA: 0x1B54AA0
	internal void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, bool gzip) { }

	// RVA: 0x1B54AB0 Offset: 0x1B54BB1 VA: 0x1B54AB0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B54C20 Offset: 0x1B54D21 VA: 0x1B54C20
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1B54D40 Offset: 0x1B54E41 VA: 0x1B54D40 Slot: 29
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1B54F30 Offset: 0x1B55031 VA: 0x1B54F30
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1B55030 Offset: 0x1B55131 VA: 0x1B55030 Slot: 31
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1B55220 Offset: 0x1B55321 VA: 0x1B55220 Slot: 20
	public override void Flush() { }

	// RVA: 0x1B55370 Offset: 0x1B55471 VA: 0x1B55370 Slot: 21
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1B555E0 Offset: 0x1B556E1 VA: 0x1B555E0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1B55850 Offset: 0x1B55951 VA: 0x1B55850 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1B559A0 Offset: 0x1B55AA1 VA: 0x1B559A0 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1B55AF0 Offset: 0x1B55BF1 VA: 0x1B55AF0 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B55B30 Offset: 0x1B55C31 VA: 0x1B55B30 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x1B55B70 Offset: 0x1B55C71 VA: 0x1B55B70 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B55BA0 Offset: 0x1B55CA1 VA: 0x1B55BA0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B55BB0 Offset: 0x1B55CB1 VA: 0x1B55BB0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B55BE0 Offset: 0x1B55CE1 VA: 0x1B55BE0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B55C20 Offset: 0x1B55D21 VA: 0x1B55C20 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B55C60 Offset: 0x1B55D61 VA: 0x1B55C60 Slot: 13
	public override void set_Position(long value) { }
}

