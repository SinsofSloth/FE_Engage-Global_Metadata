// Namespace: System.Net
internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 2547
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1ADFB60 Offset: 0x1ADFC61 VA: 0x1ADFB60
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x1ADFC60 Offset: 0x1ADFD61 VA: 0x1ADFC60 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1ADFC70 Offset: 0x1ADFD71 VA: 0x1ADFC70 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1ADFC80 Offset: 0x1ADFD81 VA: 0x1ADFC80 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1ADFC90 Offset: 0x1ADFD91 VA: 0x1ADFC90 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1ADFCD0 Offset: 0x1ADFDD1 VA: 0x1ADFCD0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1ADFD10 Offset: 0x1ADFE11 VA: 0x1ADFD10 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1ADFD50 Offset: 0x1ADFE51 VA: 0x1ADFD50 Slot: 18
	public override void Close() { }

	// RVA: 0x1ADFD70 Offset: 0x1ADFE71 VA: 0x1ADFD70 Slot: 20
	public override void Flush() { }

	// RVA: 0x1ADFD80 Offset: 0x1ADFE81 VA: 0x1ADFD80 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1ADFDC0 Offset: 0x1ADFEC1 VA: 0x1ADFDC0 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x1ADFE00 Offset: 0x1ADFF01 VA: 0x1ADFE00
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AE0150 Offset: 0x1AE0251 VA: 0x1AE0150 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1AE03D0 Offset: 0x1AE04D1 VA: 0x1AE03D0 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1AE0520 Offset: 0x1AE0621 VA: 0x1AE0520 Slot: 29
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AE0740 Offset: 0x1AE0841 VA: 0x1AE0740
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AE0880 Offset: 0x1AE0981 VA: 0x1AE0880 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1AE0A80 Offset: 0x1AE0B81 VA: 0x1AE0A80 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1AE0BD0 Offset: 0x1AE0CD1 VA: 0x1AE0BD0 Slot: 31
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AE0DF0 Offset: 0x1AE0EF1 VA: 0x1AE0DF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AE0E70 Offset: 0x1AE0F71 VA: 0x1AE0E70 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AE0F00 Offset: 0x1AE1001 VA: 0x1AE0F00 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AE0350 Offset: 0x1AE0451 VA: 0x1AE0350
	private void CheckDisposed() { }
}

