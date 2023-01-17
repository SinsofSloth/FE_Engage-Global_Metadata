// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31080 Offset: 0x31181 VA: 0x31080
private struct WebConnection.<Connect>d__16 : IAsyncStateMachine // TypeDefIndex: 2584
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebConnection <>4__this; // 0x20
	public WebOperation operation; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private Exception <connectException>5__1; // 0x38
	private IPAddress[] <>7__wrap1; // 0x40
	private int <>7__wrap2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x1925C80 Offset: 0x1925D81 VA: 0x1925C80 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32BA0 Offset: 0x32CA1 VA: 0x32BA0
	// RVA: 0x1926380 Offset: 0x1926481 VA: 0x1926380 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31090 Offset: 0x31191 VA: 0x31090
private struct WebConnection.<CreateStream>d__18 : IAsyncStateMachine // TypeDefIndex: 2585
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public WebConnection <>4__this; // 0x20
	public WebOperation operation; // 0x28
	public bool reused; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private NetworkStream <stream>5__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x58

	// Methods

	// RVA: 0x1926390 Offset: 0x1926491 VA: 0x1926390 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32BB0 Offset: 0x32CB1 VA: 0x32BB0
	// RVA: 0x1926A40 Offset: 0x1926B41 VA: 0x1926A40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x310A0 Offset: 0x311A1 VA: 0x310A0
private struct WebConnection.<InitConnection>d__19 : IAsyncStateMachine // TypeDefIndex: 2586
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder; // 0x8
	public WebOperation operation; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public WebConnection <>4__this; // 0x30
	private bool <reused>5__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x50

	// Methods

	// RVA: 0x1926AA0 Offset: 0x1926BA1 VA: 0x1926AA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32BC0 Offset: 0x32CC1 VA: 0x32BC0
	// RVA: 0x1926F60 Offset: 0x1927061 VA: 0x1926F60 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

