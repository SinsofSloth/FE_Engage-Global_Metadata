// Namespace: System.Net
internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 2614
{
	// Fields
	private BufferOffsetSize readBuffer; // 0x68
	private long contentLength; // 0x70
	private long totalRead; // 0x78
	private bool nextReadCalled; // 0x80
	private int stream_length; // 0x84
	private WebCompletionSource pendingRead; // 0x88
	private object locker; // 0x90
	private int nestedRead; // 0x98
	private bool read_eof; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x31A40 Offset: 0x31B41 VA: 0x31A40
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x31A50 Offset: 0x31B51 VA: 0x31A50
	private WebHeaderCollection <Headers>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x31A60 Offset: 0x31B61 VA: 0x31A60
	private HttpStatusCode <StatusCode>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x31A70 Offset: 0x31B71 VA: 0x31A70
	private string <StatusDescription>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x31A80 Offset: 0x31B81 VA: 0x31A80
	private Version <Version>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x31A90 Offset: 0x31B91 VA: 0x31A90
	private bool <KeepAlive>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x31AA0 Offset: 0x31BA1 VA: 0x31AA0
	private bool <ChunkedRead>k__BackingField; // 0xC9
	[CompilerGeneratedAttribute] // RVA: 0x31AB0 Offset: 0x31BB1 VA: 0x31AB0
	private MonoChunkStream <ChunkStream>k__BackingField; // 0xD0

	// Properties
	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override long Length { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	protected bool ChunkedRead { get; set; }
	protected MonoChunkStream ChunkStream { get; set; }
	private bool ExpectContent { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x33430 Offset: 0x33531 VA: 0x33430
	// RVA: 0x1952BC0 Offset: 0x1952CC1 VA: 0x1952BC0
	public WebRequestStream get_RequestStream() { }

	[CompilerGeneratedAttribute] // RVA: 0x33440 Offset: 0x33541 VA: 0x33440
	// RVA: 0x1952BD0 Offset: 0x1952CD1 VA: 0x1952BD0
	public WebHeaderCollection get_Headers() { }

	[CompilerGeneratedAttribute] // RVA: 0x33450 Offset: 0x33551 VA: 0x33450
	// RVA: 0x1952BE0 Offset: 0x1952CE1 VA: 0x1952BE0
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x33460 Offset: 0x33561 VA: 0x33460
	// RVA: 0x1952BF0 Offset: 0x1952CF1 VA: 0x1952BF0
	public HttpStatusCode get_StatusCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x33470 Offset: 0x33571 VA: 0x33470
	// RVA: 0x1952C00 Offset: 0x1952D01 VA: 0x1952C00
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x33480 Offset: 0x33581 VA: 0x33480
	// RVA: 0x1952C10 Offset: 0x1952D11 VA: 0x1952C10
	public string get_StatusDescription() { }

	[CompilerGeneratedAttribute] // RVA: 0x33490 Offset: 0x33591 VA: 0x33490
	// RVA: 0x1952C20 Offset: 0x1952D21 VA: 0x1952C20
	private void set_StatusDescription(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x334A0 Offset: 0x335A1 VA: 0x334A0
	// RVA: 0x1952C30 Offset: 0x1952D31 VA: 0x1952C30
	public Version get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x334B0 Offset: 0x335B1 VA: 0x334B0
	// RVA: 0x1952C40 Offset: 0x1952D41 VA: 0x1952C40
	private void set_Version(Version value) { }

	[CompilerGeneratedAttribute] // RVA: 0x334C0 Offset: 0x335C1 VA: 0x334C0
	// RVA: 0x1952C50 Offset: 0x1952D51 VA: 0x1952C50
	public bool get_KeepAlive() { }

	[CompilerGeneratedAttribute] // RVA: 0x334D0 Offset: 0x335D1 VA: 0x334D0
	// RVA: 0x1952C60 Offset: 0x1952D61 VA: 0x1952C60
	private void set_KeepAlive(bool value) { }

	// RVA: 0x1952C70 Offset: 0x1952D71 VA: 0x1952C70
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x1952D30 Offset: 0x1952E31 VA: 0x1952D30 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1952D40 Offset: 0x1952E41 VA: 0x1952D40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1952D50 Offset: 0x1952E51 VA: 0x1952D50 Slot: 10
	public override bool get_CanWrite() { }

	[CompilerGeneratedAttribute] // RVA: 0x334E0 Offset: 0x335E1 VA: 0x334E0
	// RVA: 0x1952D60 Offset: 0x1952E61 VA: 0x1952D60
	protected bool get_ChunkedRead() { }

	[CompilerGeneratedAttribute] // RVA: 0x334F0 Offset: 0x335F1 VA: 0x334F0
	// RVA: 0x1952D70 Offset: 0x1952E71 VA: 0x1952D70
	private void set_ChunkedRead(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x33500 Offset: 0x33601 VA: 0x33500
	// RVA: 0x1952D80 Offset: 0x1952E81 VA: 0x1952D80
	protected MonoChunkStream get_ChunkStream() { }

	[CompilerGeneratedAttribute] // RVA: 0x33510 Offset: 0x33611 VA: 0x33510
	// RVA: 0x1952D90 Offset: 0x1952E91 VA: 0x1952D90
	private void set_ChunkStream(MonoChunkStream value) { }

	[AsyncStateMachineAttribute] // RVA: 0x33520 Offset: 0x33621 VA: 0x33520
	// RVA: 0x1952DA0 Offset: 0x1952EA1 VA: 0x1952DA0 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33590 Offset: 0x33691 VA: 0x33590
	// RVA: 0x1952F90 Offset: 0x1953091 VA: 0x1952F90
	private Task<ValueTuple<int, int>> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33600 Offset: 0x33701 VA: 0x33600
	// RVA: 0x1953160 Offset: 0x1953261 VA: 0x1953160
	internal Task<int> InnerReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33670 Offset: 0x33771 VA: 0x33670
	// RVA: 0x1953330 Offset: 0x1953431 VA: 0x1953330
	private Task<int> EnsureReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1953500 Offset: 0x1953601 VA: 0x1953500
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x1953580 Offset: 0x1953681 VA: 0x1953580
	private bool IsNtlmAuth() { }

	// RVA: 0x1953750 Offset: 0x1953851 VA: 0x1953750
	private bool get_ExpectContent() { }

	[AsyncStateMachineAttribute] // RVA: 0x336E0 Offset: 0x337E1 VA: 0x336E0
	// RVA: 0x19537F0 Offset: 0x19538F1 VA: 0x19537F0
	private Task Initialize(BufferOffsetSize buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33750 Offset: 0x33851 VA: 0x33750
	// RVA: 0x1953980 Offset: 0x1953A81 VA: 0x1953980
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x1953AF0 Offset: 0x1953BF1 VA: 0x1953AF0 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1953BA0 Offset: 0x1953CA1 VA: 0x1953BA0 Slot: 33
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x1953CA0 Offset: 0x1953DA1 VA: 0x1953CA0
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[AsyncStateMachineAttribute] // RVA: 0x337C0 Offset: 0x338C1 VA: 0x337C0
	// RVA: 0x1954030 Offset: 0x1954131 VA: 0x1954030
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x19541B0 Offset: 0x19542B1 VA: 0x19541B0
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }
}

