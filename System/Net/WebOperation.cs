// Namespace: System.Net
internal class WebOperation // TypeDefIndex: 2596
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x319E0 Offset: 0x31AE1 VA: 0x319E0
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x319F0 Offset: 0x31AF1 VA: 0x319F0
	private WebConnection <Connection>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x31A00 Offset: 0x31B01 VA: 0x31A00
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x31A10 Offset: 0x31B11 VA: 0x31A10
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x31A20 Offset: 0x31B21 VA: 0x31A20
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private TaskCompletionSource<WebRequestStream> requestTask; // 0x40
	private TaskCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
	private TaskCompletionSource<WebResponseStream> responseTask; // 0x50
	private TaskCompletionSource<bool> completeResponseReadTask; // 0x58
	private TaskCompletionSource<ValueTuple<bool, WebOperation>> finishedTask; // 0x60
	private WebRequestStream writeStream; // 0x68
	private WebResponseStream responseStream; // 0x70
	private ExceptionDispatchInfo disposedInfo; // 0x78
	private ExceptionDispatchInfo closedInfo; // 0x80
	private WebOperation priorityRequest; // 0x88
	private bool finishedReading; // 0x90
	private int requestSent; // 0x94

	// Properties
	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x32E20 Offset: 0x32F21 VA: 0x32E20
	// RVA: 0x194D160 Offset: 0x194D261 VA: 0x194D160
	public HttpWebRequest get_Request() { }

	[CompilerGeneratedAttribute] // RVA: 0x32E30 Offset: 0x32F31 VA: 0x32E30
	// RVA: 0x194D170 Offset: 0x194D271 VA: 0x194D170
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x32E40 Offset: 0x32F41 VA: 0x32E40
	// RVA: 0x194D180 Offset: 0x194D281 VA: 0x194D180
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32E50 Offset: 0x32F51 VA: 0x32E50
	// RVA: 0x194D190 Offset: 0x194D291 VA: 0x194D190
	public ServicePoint get_ServicePoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x32E60 Offset: 0x32F61 VA: 0x32E60
	// RVA: 0x194D1A0 Offset: 0x194D2A1 VA: 0x194D1A0
	private void set_ServicePoint(ServicePoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32E70 Offset: 0x32F71 VA: 0x32E70
	// RVA: 0x194D1B0 Offset: 0x194D2B1 VA: 0x194D1B0
	public BufferOffsetSize get_WriteBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x32E80 Offset: 0x32F81 VA: 0x32E80
	// RVA: 0x194D1C0 Offset: 0x194D2C1 VA: 0x194D1C0
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x194D1D0 Offset: 0x194D2D1 VA: 0x194D1D0
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1948AE0 Offset: 0x1948BE1 VA: 0x1948AE0
	public bool get_Aborted() { }

	// RVA: 0x194D450 Offset: 0x194D551 VA: 0x194D450
	public bool get_Closed() { }

	// RVA: 0x194D4E0 Offset: 0x194D5E1 VA: 0x194D4E0
	public void Abort() { }

	// RVA: 0x194D760 Offset: 0x194D861 VA: 0x194D760
	public void Close() { }

	// RVA: 0x194D6B0 Offset: 0x194D7B1 VA: 0x194D6B0
	private void SetCanceled() { }

	// RVA: 0x194D820 Offset: 0x194D921 VA: 0x194D820
	private void SetError(Exception error) { }

	// RVA: 0x194D540 Offset: 0x194D641 VA: 0x194D540
	private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x194D8E0 Offset: 0x194D9E1 VA: 0x194D8E0
	internal void ThrowIfDisposed() { }

	// RVA: 0x194D960 Offset: 0x194DA61 VA: 0x194D960
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1948E10 Offset: 0x1948F11 VA: 0x1948E10
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x194DA50 Offset: 0x194DB51 VA: 0x194DA50
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x194DA00 Offset: 0x194DB01 VA: 0x194DA00
	private void ThrowDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x1947FD0 Offset: 0x19480D1 VA: 0x1947FD0
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x194DAF0 Offset: 0x194DBF1 VA: 0x194DAF0
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x194DC90 Offset: 0x194DD91 VA: 0x194DC90
	public Task<WebRequestStream> GetRequestStream() { }

	// RVA: 0x194DCE0 Offset: 0x194DDE1 VA: 0x194DCE0
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x194DD60 Offset: 0x194DE61 VA: 0x194DD60
	public Task<WebResponseStream> GetResponseStream() { }

	[AsyncStateMachineAttribute] // RVA: 0x32E90 Offset: 0x32F91 VA: 0x32E90
	// RVA: 0x194DDB0 Offset: 0x194DEB1 VA: 0x194DDB0
	internal Task<ValueTuple<bool, WebOperation>> WaitForCompletion(bool ignoreErrors) { }

	[AsyncStateMachineAttribute] // RVA: 0x32F00 Offset: 0x33001 VA: 0x32F00
	// RVA: 0x1948220 Offset: 0x1948321 VA: 0x1948220
	internal void Run() { }

	[AsyncStateMachineAttribute] // RVA: 0x32F70 Offset: 0x33071 VA: 0x32F70
	// RVA: 0x194DF20 Offset: 0x194E021 VA: 0x194DF20
	private void FinishReading() { }

	// RVA: 0x194E040 Offset: 0x194E141 VA: 0x194E040
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x194E0C0 Offset: 0x194E1C1 VA: 0x194E0C0
	internal void CompleteResponseRead(bool ok, Exception error) { }

	[CompilerGeneratedAttribute] // RVA: 0x32FE0 Offset: 0x330E1 VA: 0x32FE0
	// RVA: 0x194E150 Offset: 0x194E251 VA: 0x194E150
	private void <RegisterRequest>b__46_0() { }
}

