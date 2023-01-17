// Namespace: 
private enum WebCompletionSource.State // TypeDefIndex: 2579
{
	// Fields
	public int value__; // 0x0
	public const WebCompletionSource.State Running = 0;
	public const WebCompletionSource.State Completed = 1;
	public const WebCompletionSource.State Canceled = 2;
	public const WebCompletionSource.State Faulted = 3;
}

// Namespace: 
private class WebCompletionSource.Result // TypeDefIndex: 2580
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x318D0 Offset: 0x319D1 VA: 0x318D0
	private readonly WebCompletionSource.State <State>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x318E0 Offset: 0x319E1 VA: 0x318E0
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Properties
	public WebCompletionSource.State State { get; }
	public ExceptionDispatchInfo Error { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x32A10 Offset: 0x32B11 VA: 0x32A10
	// RVA: 0x1925C10 Offset: 0x1925D11 VA: 0x1925C10
	public WebCompletionSource.State get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x32A20 Offset: 0x32B21 VA: 0x32A20
	// RVA: 0x1925C20 Offset: 0x1925D21 VA: 0x1925C20
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x1925C30 Offset: 0x1925D31 VA: 0x1925C30
	public void .ctor(WebCompletionSource.State state, ExceptionDispatchInfo error) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31070 Offset: 0x31171 VA: 0x31070
private struct WebCompletionSource.<WaitForCompletion>d__8 : IAsyncStateMachine // TypeDefIndex: 2581
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public WebCompletionSource <>4__this; // 0x20
	public bool throwOnError; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebCompletionSource.Result> <>u__1; // 0x30

	// Methods

	// RVA: 0x1925960 Offset: 0x1925A61 VA: 0x1925960 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32A30 Offset: 0x32B31 VA: 0x32A30
	// RVA: 0x1925BB0 Offset: 0x1925CB1 VA: 0x1925BB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

