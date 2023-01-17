// Namespace: 
private struct Stream.ReadWriteParameters // TypeDefIndex: 636
{
	// Fields
	internal byte[] Buffer; // 0x0
	internal int Offset; // 0x8
	internal int Count; // 0xC
}

// Namespace: 
[Serializable]
private sealed class Stream.NullStream : Stream // TypeDefIndex: 638
{
	// Fields
	private static Task<int> s_nullReadTask; // 0x0

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1C050E0 Offset: 0x1C051E1 VA: 0x1C050E0
	internal void .ctor() { }

	// RVA: 0x1C05150 Offset: 0x1C05251 VA: 0x1C05150 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1C05160 Offset: 0x1C05261 VA: 0x1C05160 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C05170 Offset: 0x1C05271 VA: 0x1C05170 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1C05180 Offset: 0x1C05281 VA: 0x1C05180 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C05190 Offset: 0x1C05291 VA: 0x1C05190 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C051A0 Offset: 0x1C052A1 VA: 0x1C051A0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C051B0 Offset: 0x1C052B1 VA: 0x1C051B0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C051C0 Offset: 0x1C052C1 VA: 0x1C051C0 Slot: 20
	public override void Flush() { }

	// RVA: 0x1C051D0 Offset: 0x1C052D1 VA: 0x1C051D0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C05250 Offset: 0x1C05351 VA: 0x1C05250 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1C05300 Offset: 0x1C05401 VA: 0x1C05300 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C05380 Offset: 0x1C05481 VA: 0x1C05380 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1C05430 Offset: 0x1C05531 VA: 0x1C05430 Slot: 29
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C2E0 Offset: 0x47C3E1 VA: 0x47C2E0
	// RVA: 0x1C05440 Offset: 0x1C05541 VA: 0x1C05440 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C05540 Offset: 0x1C05641 VA: 0x1C05540 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x1C05550 Offset: 0x1C05651 VA: 0x1C05550 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C300 Offset: 0x47C401 VA: 0x47C300
	// RVA: 0x1C05560 Offset: 0x1C05661 VA: 0x1C05560 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C05610 Offset: 0x1C05711 VA: 0x1C05610 Slot: 32
	public override void WriteByte(byte value) { }

	// RVA: 0x1C05620 Offset: 0x1C05721 VA: 0x1C05620 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1C05630 Offset: 0x1C05731 VA: 0x1C05630 Slot: 28
	public override void SetLength(long length) { }
}

// Namespace: 
internal sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 640
{
	// Fields
	private readonly object _stateObject; // 0x10
	private readonly bool _isWrite; // 0x18
	private ManualResetEvent _waitHandle; // 0x20
	private ExceptionDispatchInfo _exceptionInfo; // 0x28
	private bool _endXxxCalled; // 0x30
	private int _bytesRead; // 0x34

	// Properties
	public bool IsCompleted { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }

	// Methods

	// RVA: 0x1C05AB0 Offset: 0x1C05BB1 VA: 0x1C05AB0
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x1C05B00 Offset: 0x1C05C01 VA: 0x1C05B00
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x1C05B40 Offset: 0x1C05C41 VA: 0x1C05B40
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x1C05BB0 Offset: 0x1C05CB1 VA: 0x1C05BB0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1C05BC0 Offset: 0x1C05CC1 VA: 0x1C05BC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1C05CF0 Offset: 0x1C05DF1 VA: 0x1C05CF0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1C05D00 Offset: 0x1C05E01 VA: 0x1C05D00 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1C05D10 Offset: 0x1C05E11 VA: 0x1C05D10
	internal void ThrowIfError() { }

	// RVA: 0x1C05D30 Offset: 0x1C05E31 VA: 0x1C05D30
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1C05DD0 Offset: 0x1C05ED1 VA: 0x1C05DD0
	internal static void EndWrite(IAsyncResult asyncResult) { }
}

// Namespace: 
public struct Stream.WriteScope : IDisposable // TypeDefIndex: 13928
{
	// Fields
	private Stream m_Stream; // 0x0

	// Methods

	// RVA: 0x2051C60 Offset: 0x2051D61 VA: 0x2051C60
	public void .ctor(Stream stream, int version) { }

	// RVA: 0x2051CB0 Offset: 0x2051DB1 VA: 0x2051CB0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public struct Stream.PositionScope : IDisposable // TypeDefIndex: 13930
{
	// Fields
	private Stream m_Stream; // 0x0
	private int m_Position; // 0x8

	// Methods

	// RVA: 0x2051AE0 Offset: 0x2051BE1 VA: 0x2051AE0
	public void .ctor(Stream stream, int position = 0) { }

	// RVA: 0x2051B40 Offset: 0x2051C41 VA: 0x2051B40 Slot: 4
	public void Dispose() { }
}

