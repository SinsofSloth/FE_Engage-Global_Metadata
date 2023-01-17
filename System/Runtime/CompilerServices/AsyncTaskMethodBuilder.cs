// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder // TypeDefIndex: 1236
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x356AEE0 Offset: 0x356AFE1 VA: 0x356AEE0
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x47D320 Offset: 0x47D421 VA: 0x47D320
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2736200 Offset: 0x2736301 VA: 0x2736200
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x2736390 Offset: 0x2736491 VA: 0x2736390
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2736470 Offset: 0x2736571 VA: 0x2736470
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x2736550 Offset: 0x2736651 VA: 0x2736550
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x2736630 Offset: 0x2736731 VA: 0x2736630
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x2736710 Offset: 0x2736811 VA: 0x2736710
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0x27367F0 Offset: 0x27368F1 VA: 0x27367F0
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x27368D0 Offset: 0x27369D1 VA: 0x27368D0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__30>
	|
	|-RVA: 0x27369B0 Offset: 0x2736AB1 VA: 0x27369B0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x2736A90 Offset: 0x2736B91 VA: 0x2736A90
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__32>
	|
	|-RVA: 0x2736B70 Offset: 0x2736C71 VA: 0x2736B70
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__35>
	|
	|-RVA: 0x2736C50 Offset: 0x2736D51 VA: 0x2736C50
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x2736D30 Offset: 0x2736E31 VA: 0x2736D30
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x2736E10 Offset: 0x2736F11 VA: 0x2736E10
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__37>
	|
	|-RVA: 0x2736EF0 Offset: 0x2736FF1 VA: 0x2736EF0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x2736FD0 Offset: 0x27370D1 VA: 0x2736FD0
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x27370B0 Offset: 0x27371B1 VA: 0x27370B0
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<Initialize>d__56>
	|
	|-RVA: 0x2737190 Offset: 0x2737291 VA: 0x2737190
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__57>
	*/

	// RVA: 0x356AEF0 Offset: 0x356AFF1 VA: 0x356AEF0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2736040 Offset: 0x2736141 VA: 0x2736040
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x2736050 Offset: 0x2736151 VA: 0x2736050
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2736060 Offset: 0x2736161 VA: 0x2736060
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2736070 Offset: 0x2736171 VA: 0x2736070
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x2736090 Offset: 0x2736191 VA: 0x2736090
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x2736080 Offset: 0x2736181 VA: 0x2736080
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x27360A0 Offset: 0x27361A1 VA: 0x27360A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__38>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x27360B0 Offset: 0x27361B1 VA: 0x27360B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__57>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, WebResponseStream.<ReadAllAsync>d__57>
	|
	|-RVA: 0x27360C0 Offset: 0x27361C1 VA: 0x27360C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WebResponseStream.<ReadAllAsync>d__57>
	|
	|-RVA: 0x27360D0 Offset: 0x27361D1 VA: 0x27360D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x27360E0 Offset: 0x27361E1 VA: 0x27360E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x27360F0 Offset: 0x27361F1 VA: 0x27360F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x2736100 Offset: 0x2736201 VA: 0x2736100
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x2736110 Offset: 0x2736211 VA: 0x2736110
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2736120 Offset: 0x2736221 VA: 0x2736120
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x2736130 Offset: 0x2736231 VA: 0x2736130
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x2736140 Offset: 0x2736241 VA: 0x2736140
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x2736150 Offset: 0x2736251 VA: 0x2736150
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x2736160 Offset: 0x2736261 VA: 0x2736160
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__30>
	|
	|-RVA: 0x2736170 Offset: 0x2736271 VA: 0x2736170
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x2736180 Offset: 0x2736281 VA: 0x2736180
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__32>
	|
	|-RVA: 0x2736190 Offset: 0x2736291 VA: 0x2736190
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__35>
	|
	|-RVA: 0x27361A0 Offset: 0x27362A1 VA: 0x27361A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x27361B0 Offset: 0x27362B1 VA: 0x27361B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x27361C0 Offset: 0x27362C1 VA: 0x27361C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__37>
	|
	|-RVA: 0x27361D0 Offset: 0x27362D1 VA: 0x27361D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x27361E0 Offset: 0x27362E1 VA: 0x27361E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x27361F0 Offset: 0x27362F1 VA: 0x27361F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebResponseStream.<Initialize>d__56>
	*/

	// RVA: 0x356AF50 Offset: 0x356B051 VA: 0x356AF50
	public Task get_Task() { }

	// RVA: 0x356AFB0 Offset: 0x356B0B1 VA: 0x356AFB0
	public void SetResult() { }

	// RVA: 0x356B040 Offset: 0x356B141 VA: 0x356B040
	public void SetException(Exception exception) { }

	// RVA: 0x356B0A0 Offset: 0x356B1A1 VA: 0x356B0A0
	private static void .cctor() { }
}

