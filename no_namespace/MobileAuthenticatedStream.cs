// Namespace: 
private enum MobileAuthenticatedStream.OperationType // TypeDefIndex: 2192
{
	// Fields
	public int value__; // 0x0
	public const MobileAuthenticatedStream.OperationType Read = 0;
	public const MobileAuthenticatedStream.OperationType Write = 1;
	public const MobileAuthenticatedStream.OperationType Shutdown = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FB40 Offset: 0x2FC41 VA: 0x2FB40
private struct MobileAuthenticatedStream.<StartOperation>d__58 : IAsyncStateMachine // TypeDefIndex: 2194
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public MobileAuthenticatedStream.OperationType type; // 0x28
	public AsyncProtocolRequest asyncRequest; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x40

	// Methods

	// RVA: 0x191C890 Offset: 0x191C991 VA: 0x191C890 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32100 Offset: 0x32201 VA: 0x32100
	// RVA: 0x191D020 Offset: 0x191D121 VA: 0x191D020 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FB60 Offset: 0x2FC61 VA: 0x2FB60
private struct MobileAuthenticatedStream.<InnerRead>d__66 : IAsyncStateMachine // TypeDefIndex: 2196
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public int requestedSize; // 0x30
	public bool sync; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x191B7B0 Offset: 0x191B8B1 VA: 0x191B7B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32110 Offset: 0x32211 VA: 0x32110
	// RVA: 0x191BBE0 Offset: 0x191BCE1 VA: 0x191BBE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

