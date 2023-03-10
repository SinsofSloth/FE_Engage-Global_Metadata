// Namespace: 
private enum WebConnectionTunnel.NtlmAuthState // TypeDefIndex: 2589
{
	// Fields
	public int value__; // 0x0
	public const WebConnectionTunnel.NtlmAuthState None = 0;
	public const WebConnectionTunnel.NtlmAuthState Challenge = 1;
	public const WebConnectionTunnel.NtlmAuthState Response = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x310B0 Offset: 0x311B1 VA: 0x310B0
private struct WebConnectionTunnel.<Initialize>d__42 : IAsyncStateMachine // TypeDefIndex: 2590
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebConnectionTunnel <>4__this; // 0x20
	public Stream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private bool <have_auth>5__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>> <>u__2; // 0x50

	// Methods

	// RVA: 0x1926FC0 Offset: 0x19270C1 VA: 0x1926FC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32E00 Offset: 0x32F01 VA: 0x32E00
	// RVA: 0x1927DA0 Offset: 0x1927EA1 VA: 0x1927DA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x310C0 Offset: 0x311C1 VA: 0x310C0
private struct WebConnectionTunnel.<ReadHeaders>d__43 : IAsyncStateMachine // TypeDefIndex: 2591
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public Stream stream; // 0x28
	private byte[] <buffer>5__1; // 0x30
	private MemoryStream <ms>5__2; // 0x38
	public WebConnectionTunnel <>4__this; // 0x40
	private byte[] <retBuffer>5__3; // 0x48
	private int <status>5__4; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x58

	// Methods

	// RVA: 0x1927DB0 Offset: 0x1927EB1 VA: 0x1927DB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32E10 Offset: 0x32F11 VA: 0x32E10
	// RVA: 0x19285B0 Offset: 0x19286B1 VA: 0x19285B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

