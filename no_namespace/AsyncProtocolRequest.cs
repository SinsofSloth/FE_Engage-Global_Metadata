// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FB00 Offset: 0x2FC01 VA: 0x2FB00
private struct AsyncProtocolRequest.<StartOperation>d__23 : IAsyncStateMachine // TypeDefIndex: 2182
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1915C70 Offset: 0x1915D71 VA: 0x1915C70 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x31EA0 Offset: 0x31FA1 VA: 0x31EA0
	// RVA: 0x1916020 Offset: 0x1916121 VA: 0x1916020 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FB10 Offset: 0x2FC11 VA: 0x2FB10
private struct AsyncProtocolRequest.<ProcessOperation>d__24 : IAsyncStateMachine // TypeDefIndex: 2183
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public AsyncProtocolRequest <>4__this; // 0x28
	private AsyncOperationStatus <status>5__1; // 0x30
	private AsyncOperationStatus <newStatus>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1915880 Offset: 0x1915981 VA: 0x1915880 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x31EB0 Offset: 0x31FB1 VA: 0x31EB0
	// RVA: 0x1915C60 Offset: 0x1915D61 VA: 0x1915C60 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FB20 Offset: 0x2FC21 VA: 0x2FB20
private struct AsyncProtocolRequest.<InnerRead>d__25 : IAsyncStateMachine // TypeDefIndex: 2184
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<int>> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private int <requestedSize>5__1; // 0x30
	private Nullable<int> <totalRead>5__2; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x19154E0 Offset: 0x19155E1 VA: 0x19154E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x31EC0 Offset: 0x31FC1 VA: 0x31EC0
	// RVA: 0x1915820 Offset: 0x1915921 VA: 0x1915820 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

