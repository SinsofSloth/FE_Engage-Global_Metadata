// Namespace: System.IO.Compression
public class GZipStream : Stream // TypeDefIndex: 2383
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1AE7B30 Offset: 0x1AE7C31 VA: 0x1AE7B30
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1AE7C00 Offset: 0x1AE7D01 VA: 0x1AE7C00
	public void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) { }

	// RVA: 0x1AE7CD0 Offset: 0x1AE7DD1 VA: 0x1AE7CD0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1AE7CF0 Offset: 0x1AE7DF1 VA: 0x1AE7CF0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1AE7D10 Offset: 0x1AE7E11 VA: 0x1AE7D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1AE7D30 Offset: 0x1AE7E31 VA: 0x1AE7D30 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1AE7D90 Offset: 0x1AE7E91 VA: 0x1AE7D90 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1AE7DF0 Offset: 0x1AE7EF1 VA: 0x1AE7DF0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1AE7E50 Offset: 0x1AE7F51 VA: 0x1AE7E50 Slot: 20
	public override void Flush() { }

	// RVA: 0x1AE7EA0 Offset: 0x1AE7FA1 VA: 0x1AE7EA0 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1AE7F00 Offset: 0x1AE8001 VA: 0x1AE7F00 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x1AE7F60 Offset: 0x1AE8061 VA: 0x1AE7F60 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x1AE7F90 Offset: 0x1AE8091 VA: 0x1AE7F90 Slot: 21
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1AE8050 Offset: 0x1AE8151 VA: 0x1AE8050 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1AE80B0 Offset: 0x1AE81B1 VA: 0x1AE80B0 Slot: 29
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1AE80E0 Offset: 0x1AE81E1 VA: 0x1AE80E0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1AE81A0 Offset: 0x1AE82A1 VA: 0x1AE81A0 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1AE81B0 Offset: 0x1AE82B1 VA: 0x1AE81B0 Slot: 31
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1AE81E0 Offset: 0x1AE82E1 VA: 0x1AE81E0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AE8290 Offset: 0x1AE8391 VA: 0x1AE8290 Slot: 23
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1AE82C0 Offset: 0x1AE83C1 VA: 0x1AE82C0 Slot: 26
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1AE7E80 Offset: 0x1AE7F81 VA: 0x1AE7E80
	private void CheckDeflateStream() { }

	// RVA: 0x1AE82F0 Offset: 0x1AE83F1 VA: 0x1AE82F0
	private static void ThrowStreamClosedException() { }
}

