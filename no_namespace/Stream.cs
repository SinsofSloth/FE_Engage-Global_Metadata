// Namespace: 
private struct Stream.ReadWriteParameters // TypeDefIndex: 636
{
	// Fields
	internal byte[] Buffer; // 0x0
	internal int Offset; // 0x8
	internal int Count; // 0xC
}

// Namespace: 
private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 637
{
	// Fields
	internal readonly bool _isRead; // 0x54
	internal Stream _stream; // 0x58
	internal byte[] _buffer; // 0x60
	internal int _offset; // 0x68
	internal int _count; // 0x6C
	private AsyncCallback _callback; // 0x70
	private ExecutionContext _context; // 0x78
	private static ContextCallback s_invokeAsyncCallback; // 0x0

	// Methods

	// RVA: 0x1C04E30 Offset: 0x1C04F31 VA: 0x1C04E30
	internal void ClearBeginState() { }

	// RVA: 0x1C05640 Offset: 0x1C05741 VA: 0x1C05640
	public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x1C05800 Offset: 0x1C05901 VA: 0x1C05800
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x1C05880 Offset: 0x1C05981 VA: 0x1C05880 Slot: 20
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }
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
[CompilerGeneratedAttribute] // RVA: 0x472B40 Offset: 0x472C41 VA: 0x472B40
[Serializable]
private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 639
{
	// Fields
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; // 0x0
	public static Func<ManualResetEvent> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x1C0F7D0 Offset: 0x1C0F8D1 VA: 0x1C0F7D0
	private static void .cctor() { }

	// RVA: 0x1C0F840 Offset: 0x1C0F941 VA: 0x1C0F840
	public void .ctor() { }

	// RVA: 0x1C0F850 Offset: 0x1C0F951 VA: 0x1C0F850
	internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }
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
[CompilerGeneratedAttribute] // RVA: 0x472B50 Offset: 0x472C51 VA: 0x472B50
[Serializable]
private sealed class Stream.<>c // TypeDefIndex: 641
{
	// Fields
	public static readonly Stream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__4_0; // 0x8
	public static Func<object, int> <>9__39_0; // 0x10
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__43_0; // 0x18
	public static Func<Stream, IAsyncResult, int> <>9__43_1; // 0x20
	public static Func<object, int> <>9__46_0; // 0x28
	public static Action<Task, object> <>9__47_0; // 0x30
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__53_0; // 0x38
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__53_1; // 0x40

	// Methods

	// RVA: 0x1C04C20 Offset: 0x1C04D21 VA: 0x1C04C20
	private static void .cctor() { }

	// RVA: 0x1C04C90 Offset: 0x1C04D91 VA: 0x1C04C90
	public void .ctor() { }

	// RVA: 0x1C04CA0 Offset: 0x1C04DA1 VA: 0x1C04CA0
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x1C04D00 Offset: 0x1C04E01 VA: 0x1C04D00
	internal int <BeginReadInternal>b__39_0(object <p0>) { }

	// RVA: 0x1C04E70 Offset: 0x1C04F71 VA: 0x1C04E70
	internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1C04EA0 Offset: 0x1C04FA1 VA: 0x1C04EA0
	internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x1C04EC0 Offset: 0x1C04FC1 VA: 0x1C04EC0
	internal int <BeginWriteInternal>b__46_0(object <p0>) { }

	// RVA: 0x1C04FE0 Offset: 0x1C050E1 VA: 0x1C04FE0
	internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	// RVA: 0x1C05080 Offset: 0x1C05181 VA: 0x1C05080
	internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1C050B0 Offset: 0x1C051B1 VA: 0x1C050B0
	internal VoidTaskResult <BeginEndWriteAsync>b__53_1(Stream stream, IAsyncResult asyncResult) { }
}

// Namespace: 
private struct Stream.Info // TypeDefIndex: 13927
{
	// Fields
	public int Position; // 0x0
	public int Version; // 0x4
	public int Size; // 0x8
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
public struct Stream.ReadScope : IDisposable // TypeDefIndex: 13929
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29CC40 Offset: 0x29CD41 VA: 0x29CC40
	private int <Version>k__BackingField; // 0x0
	private Stream m_Stream; // 0x8

	// Properties
	public int Version { get; set; }

	// Methods

	// RVA: 0x2051B90 Offset: 0x2051C91 VA: 0x2051B90
	public void .ctor(Stream stream) { }

	// RVA: 0x2051BF0 Offset: 0x2051CF1 VA: 0x2051BF0 Slot: 4
	public void Dispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD9F0 Offset: 0x2CDAF1 VA: 0x2CD9F0
	[IsReadOnlyAttribute] // RVA: 0x2CD9F0 Offset: 0x2CDAF1 VA: 0x2CD9F0
	// RVA: 0x2051C40 Offset: 0x2051D41 VA: 0x2051C40
	public int get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDA30 Offset: 0x2CDB31 VA: 0x2CDA30
	// RVA: 0x2051C50 Offset: 0x2051D51 VA: 0x2051C50
	private void set_Version(int value) { }
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

