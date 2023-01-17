// Namespace: 
private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 2554
{
	// Fields
	public int value__; // 0x0
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30FE0 Offset: 0x310E1 VA: 0x30FE0
private struct HttpWebRequest.<MyGetRequestStreamAsync>d__229 : IAsyncStateMachine // TypeDefIndex: 2556
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x30

	// Methods

	// RVA: 0x1919510 Offset: 0x1919611 VA: 0x1919510 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32780 Offset: 0x32881 VA: 0x32780
	// RVA: 0x1919B10 Offset: 0x1919C11 VA: 0x1919B10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31000 Offset: 0x31101 VA: 0x31000
private struct HttpWebRequest.<RunWithTimeout>d__234<T> : IAsyncStateMachine // TypeDefIndex: 2558
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public int timeout; // 0x0
	public Func<CancellationToken, Task<T>> func; // 0x0
	private Task <timeoutTask>5__1; // 0x0
	private CancellationTokenSource <cts>5__2; // 0x0
	public Action abort; // 0x0
	private Task<T> <workerTask>5__3; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31642A0 Offset: 0x31643A1 VA: 0x31642A0
	|-HttpWebRequest.<RunWithTimeout>d__234<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x3164CE0 Offset: 0x3164DE1 VA: 0x3164CE0
	|-HttpWebRequest.<RunWithTimeout>d__234<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x32790 Offset: 0x32891 VA: 0x32790
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3164C90 Offset: 0x3164D91 VA: 0x3164C90
	|-HttpWebRequest.<RunWithTimeout>d__234<ValueTuple<int, int>>.SetStateMachine
	|
	|-RVA: 0x31656D0 Offset: 0x31657D1 VA: 0x31656D0
	|-HttpWebRequest.<RunWithTimeout>d__234<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31020 Offset: 0x31121 VA: 0x31020
private struct HttpWebRequest.<GetResponseFromData>d__237 : IAsyncStateMachine // TypeDefIndex: 2560
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x31790 Offset: 0x31891 VA: 0x31790
	public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public WebResponseStream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private WebException <throwMe>5__1; // 0x38
	private Task<BufferOffsetSize> <rewriteHandler>5__2; // 0x40
	private bool <redirect>5__3; // 0x48
	private HttpWebResponse <response>5__4; // 0x50
	private BufferOffsetSize <writeBuffer>5__5; // 0x58
	private bool <mustReadAll>5__6; // 0x60
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x68
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize> <>u__2; // 0x78

	// Methods

	// RVA: 0x1918CB0 Offset: 0x1918DB1 VA: 0x1918CB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x327B0 Offset: 0x328B1 VA: 0x327B0
	// RVA: 0x19194B0 Offset: 0x19195B1 VA: 0x19194B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

