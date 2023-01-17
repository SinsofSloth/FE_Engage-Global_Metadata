// Namespace: System.Runtime.CompilerServices
public struct AsyncVoidMethodBuilder // TypeDefIndex: 1235
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	private Task Task { get; }

	// Methods

	// RVA: 0x356B130 Offset: 0x356B231 VA: 0x356B130
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x47D310 Offset: 0x47D411 VA: 0x47D310
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2298D30 Offset: 0x2298E31 VA: 0x2298D30
	|-AsyncVoidMethodBuilder.Start<object>
	|
	|-RVA: 0x2298EC0 Offset: 0x2298FC1 VA: 0x2298EC0
	|-AsyncVoidMethodBuilder.Start<ServicePointScheduler.<StartScheduler>d__32>
	|
	|-RVA: 0x2298FA0 Offset: 0x22990A1 VA: 0x2298FA0
	|-AsyncVoidMethodBuilder.Start<WebOperation.<FinishReading>d__55>
	|
	|-RVA: 0x2299080 Offset: 0x2299181 VA: 0x2299080
	|-AsyncVoidMethodBuilder.Start<WebOperation.<Run>d__54>
	*/

	// RVA: 0x356B1A0 Offset: 0x356B2A1 VA: 0x356B1A0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2297E20 Offset: 0x2297F21 VA: 0x2297E20
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebOperation.<FinishReading>d__55>
	|
	|-RVA: 0x2298170 Offset: 0x2298271 VA: 0x2298170
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<StartScheduler>d__32>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, ServicePointScheduler.<StartScheduler>d__32>
	|
	|-RVA: 0x22984D0 Offset: 0x22985D1 VA: 0x22984D0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<Run>d__54>
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream>, WebOperation.<Run>d__54>
	|
	|-RVA: 0x2298830 Offset: 0x2298931 VA: 0x2298830
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x2298A70 Offset: 0x2298B71 VA: 0x2298A70
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebOperation.<Run>d__54>
	*/

	// RVA: 0x356B1B0 Offset: 0x356B2B1 VA: 0x356B1B0
	public void SetResult() { }

	// RVA: 0x356B300 Offset: 0x356B401 VA: 0x356B300
	public void SetException(Exception exception) { }

	// RVA: 0x356B250 Offset: 0x356B351 VA: 0x356B250
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x356B1C0 Offset: 0x356B2C1 VA: 0x356B1C0
	private Task get_Task() { }
}

