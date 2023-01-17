// Namespace: 
private class ServicePointScheduler.ConnectionGroup // TypeDefIndex: 2573
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x318B0 Offset: 0x319B1 VA: 0x318B0
	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x318C0 Offset: 0x319C1 VA: 0x318C0
	private readonly string <Name>k__BackingField; // 0x18
	private static int nextId; // 0x0
	public readonly int ID; // 0x20
	private LinkedList<WebConnection> connections; // 0x28
	private LinkedList<WebOperation> queue; // 0x30

	// Properties
	public ServicePointScheduler Scheduler { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x32900 Offset: 0x32A01 VA: 0x32900
	// RVA: 0x19200F0 Offset: 0x19201F1 VA: 0x19200F0
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1920100 Offset: 0x1920201 VA: 0x1920100
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x191FAC0 Offset: 0x191FBC1 VA: 0x191FAC0
	public bool IsEmpty() { }

	// RVA: 0x1920250 Offset: 0x1920351 VA: 0x1920250
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x19202D0 Offset: 0x19203D1 VA: 0x19202D0
	public void Cleanup() { }

	// RVA: 0x19203B0 Offset: 0x19204B1 VA: 0x19203B0
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x1920410 Offset: 0x1920511 VA: 0x1920410
	public WebOperation GetNextOperation() { }

	// RVA: 0x19204F0 Offset: 0x19205F1 VA: 0x19204F0
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x1920840 Offset: 0x1920941 VA: 0x1920840
	public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31040 Offset: 0x31141 VA: 0x31040
private struct ServicePointScheduler.AsyncManualResetEvent.<WaitAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 2574
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public int millisecondTimeout; // 0x20
	public ServicePointScheduler.AsyncManualResetEvent <>4__this; // 0x28
	private Task <timeoutTask>5__1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x38

	// Methods

	// RVA: 0x1C15610 Offset: 0x1C15711 VA: 0x1C15610 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32980 Offset: 0x32A81 VA: 0x32980
	// RVA: 0x1C15960 Offset: 0x1C15A61 VA: 0x1C15960 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31050 Offset: 0x31151 VA: 0x31050
[Serializable]
private sealed class ServicePointScheduler.AsyncManualResetEvent.<>c // TypeDefIndex: 2575
{
	// Fields
	public static readonly ServicePointScheduler.AsyncManualResetEvent.<>c <>9; // 0x0
	public static Func<object, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1C154F0 Offset: 0x1C155F1 VA: 0x1C154F0
	private static void .cctor() { }

	// RVA: 0x1C15560 Offset: 0x1C15661 VA: 0x1C15560
	public void .ctor() { }

	// RVA: 0x1C15570 Offset: 0x1C15671 VA: 0x1C15570
	internal bool <Set>b__4_0(object s) { }
}

// Namespace: 
private class ServicePointScheduler.AsyncManualResetEvent // TypeDefIndex: 2576
{
	// Fields
	private TaskCompletionSource<bool> m_tcs; // 0x10

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x32910 Offset: 0x32A11 VA: 0x32910
	// RVA: 0x191FC00 Offset: 0x191FD01 VA: 0x191FC00
	public Task<bool> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x191FD90 Offset: 0x191FE91 VA: 0x191FD90
	public void Set() { }

	// RVA: 0x191FB40 Offset: 0x191FC41 VA: 0x191FB40
	public void Reset() { }

	// RVA: 0x1920030 Offset: 0x1920131 VA: 0x1920030
	public void .ctor(bool state) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x31060 Offset: 0x31161 VA: 0x31060
private struct ServicePointScheduler.<StartScheduler>d__32 : IAsyncStateMachine // TypeDefIndex: 2577
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ServicePointScheduler <>4__this; // 0x28
	private List<Task> <taskList>5__1; // 0x30
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2; // 0x38
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x48

	// Methods

	// RVA: 0x191F0A0 Offset: 0x191F1A1 VA: 0x191F0A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x32990 Offset: 0x32A91 VA: 0x32990
	// RVA: 0x191FD80 Offset: 0x191FE81 VA: 0x191FD80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

