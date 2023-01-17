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
private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 2555
{
	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x191ABE0 Offset: 0x191ACE1 VA: 0x191ABE0
	public bool get_IsCompleted() { }

	// RVA: 0x191ABF0 Offset: 0x191ACF1 VA: 0x191ABF0
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1919490 Offset: 0x1919591 VA: 0x1919490
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x191AC00 Offset: 0x191AD01 VA: 0x191AC00
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x191AC40 Offset: 0x191AD41 VA: 0x191AC40
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x191AF70 Offset: 0x191B071 VA: 0x191AF70
	public void Reset() { }

	// RVA: 0x191B000 Offset: 0x191B101 VA: 0x191B000 Slot: 3
	public override string ToString() { }
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
[CompilerGeneratedAttribute] // RVA: 0x30FF0 Offset: 0x310F1 VA: 0x30FF0
[Serializable]
private sealed class HttpWebRequest.<>c__234<T> // TypeDefIndex: 2557
{
	// Fields
	public static readonly HttpWebRequest.<>c__234<T> <>9; // 0x0
	public static Func<Task<T>, Nullable<int>> <>9__234_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B359E0 Offset: 0x2B35AE1 VA: 0x2B359E0
	|-HttpWebRequest.<>c__234<ValueTuple<int, int>>..cctor
	|
	|-RVA: 0x2B35B50 Offset: 0x2B35C51 VA: 0x2B35B50
	|-HttpWebRequest.<>c__234<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B35AC0 Offset: 0x2B35BC1 VA: 0x2B35AC0
	|-HttpWebRequest.<>c__234<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2B35C30 Offset: 0x2B35D31 VA: 0x2B35C30
	|-HttpWebRequest.<>c__234<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Nullable<int> <RunWithTimeout>b__234_0(Task<T> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B35AD0 Offset: 0x2B35BD1 VA: 0x2B35AD0
	|-HttpWebRequest.<>c__234<ValueTuple<int, int>>.<RunWithTimeout>b__234_0
	|
	|-RVA: 0x2B35C40 Offset: 0x2B35D41 VA: 0x2B35C40
	|-HttpWebRequest.<>c__234<object>.<RunWithTimeout>b__234_0
	*/
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
[CompilerGeneratedAttribute] // RVA: 0x31010 Offset: 0x31111 VA: 0x31010
private struct HttpWebRequest.<MyGetResponseAsync>d__236 : IAsyncStateMachine // TypeDefIndex: 2559
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private WebOperation <operation>5__1; // 0x30
	private WebException <throwMe>5__2; // 0x38
	private WebCompletionSource <completion>5__3; // 0x40
	private bool <redirect>5__4; // 0x48
	private HttpWebResponse <response>5__5; // 0x50
	private WebOperation <ntlm>5__6; // 0x58
	private bool <mustReadAll>5__7; // 0x60
	private WebResponseStream <stream>5__8; // 0x68
	private BufferOffsetSize <writeBuffer>5__9; // 0x70
	private TaskAwaiter<WebRequestStream> <>u__1; // 0x78
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x80
	private TaskAwaiter<WebResponseStream> <>u__3; // 0x90
	[TupleElementNamesAttribute] // RVA: 0x31690 Offset: 0x31791 VA: 0x31690
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>u__4; // 0x98

	// Methods

	// RVA: 0x1919B70 Offset: 0x1919C71 VA: 0x1919B70 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x327A0 Offset: 0x328A1 VA: 0x327A0
	// RVA: 0x191AB80 Offset: 0x191AC81 VA: 0x191AB80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31030 Offset: 0x31131 VA: 0x31030
private struct HttpWebRequest.<<GetRewriteHandler>b__263_0>d : IAsyncStateMachine // TypeDefIndex: 2561
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	private MemoryStream <ms>5__1; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1918890 Offset: 0x1918991 VA: 0x1918890 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x327C0 Offset: 0x328C1 VA: 0x327C0
	// RVA: 0x1918C50 Offset: 0x1918D51 VA: 0x1918C50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

