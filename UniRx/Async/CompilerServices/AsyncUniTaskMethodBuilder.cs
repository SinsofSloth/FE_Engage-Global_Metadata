// Namespace: UniRx.Async.CompilerServices
public struct AsyncUniTaskMethodBuilder // TypeDefIndex: 5227
{
	// Fields
	private UniTaskCompletionSource promise; // 0x0
	private Action moveNext; // 0x8

	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F320 Offset: 0x2F421 VA: 0x2F320
	public UniTask Task { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2EB30 Offset: 0x2EC31 VA: 0x2EB30
	// RVA: 0x2E7CD80 Offset: 0x2E7CE81 VA: 0x2E7CD80
	public static AsyncUniTaskMethodBuilder Create() { }

	// RVA: 0x2E7CD90 Offset: 0x2E7CE91 VA: 0x2E7CD90
	public UniTask get_Task() { }

	[DebuggerHiddenAttribute] // RVA: 0x2EB40 Offset: 0x2EC41 VA: 0x2EB40
	// RVA: 0x2E7CEA0 Offset: 0x2E7CFA1 VA: 0x2E7CEA0
	public void SetException(Exception exception) { }

	[DebuggerHiddenAttribute] // RVA: 0x2EB50 Offset: 0x2EC51 VA: 0x2EB50
	// RVA: 0x2E7D130 Offset: 0x2E7D231 VA: 0x2E7D130
	public void SetResult() { }

	[DebuggerHiddenAttribute] // RVA: 0x2EB60 Offset: 0x2EC61 VA: 0x2EB60
	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2738690 Offset: 0x2738791 VA: 0x2738690
	|-AsyncUniTaskMethodBuilder.AwaitOnCompleted<object, object>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EB70 Offset: 0x2EC71 VA: 0x2EB70
	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2738840 Offset: 0x2738941 VA: 0x2738840
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ContinueWith>d__25<object>>
	|
	|-RVA: 0x2738A30 Offset: 0x2738B31 VA: 0x2738A30
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ContinueWith>d__26<object>>
	|
	|-RVA: 0x2738C20 Offset: 0x2738D21 VA: 0x2738C20
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter<UniTask>, UniTaskExtensions.<Unwrap>d__38<object>>
	|
	|-RVA: 0x2738E10 Offset: 0x2738F11 VA: 0x2738E10
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x2738FC0 Offset: 0x27390C1 VA: 0x2738FC0
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, UniTaskExtensions.<ConfigureAwait>d__33>
	|
	|-RVA: 0x2739110 Offset: 0x2739211 VA: 0x2739110
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<SwitchToThreadPoolAwaitable.Awaiter, UniTask.<Run>d__24>
	|
	|-RVA: 0x2739260 Offset: 0x2739361 VA: 0x2739260
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<SwitchToThreadPoolAwaitable.Awaiter, UniTask.<Run>d__25>
	|
	|-RVA: 0x27393B0 Offset: 0x27394B1 VA: 0x27393B0
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ContinueWith>d__26<object>>
	|
	|-RVA: 0x2739500 Offset: 0x2739601 VA: 0x2739500
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<Unwrap>d__38<object>>
	|
	|-RVA: 0x2739650 Offset: 0x2739751 VA: 0x2739650
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ConfigureAwait>d__35>
	|
	|-RVA: 0x27397A0 Offset: 0x27398A1 VA: 0x27397A0
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ContinueWith>d__29>
	|
	|-RVA: 0x27398F0 Offset: 0x27399F1 VA: 0x27398F0
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ContinueWith>d__30>
	|
	|-RVA: 0x2739A40 Offset: 0x2739B41 VA: 0x2739A40
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTask.<Run>d__24>
	|
	|-RVA: 0x2739B90 Offset: 0x2739C91 VA: 0x2739B90
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTask.<Run>d__25>
	|
	|-RVA: 0x2739CE0 Offset: 0x2739DE1 VA: 0x2739CE0
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTaskExtensions.<ConfigureAwait>d__33>
	|
	|-RVA: 0x2739E30 Offset: 0x2739F31 VA: 0x2739E30
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTaskExtensions.<ConfigureAwait>d__35>
	|
	|-RVA: 0x2739F80 Offset: 0x273A081 VA: 0x2739F80
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter, UniTask.<WhenAll>d__53>
	|
	|-RVA: 0x273A0D0 Offset: 0x273A1D1 VA: 0x273A0D0
	|-AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter, UniTask.<WhenAll>d__54>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EB80 Offset: 0x2EC81 VA: 0x2EB80
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x273A220 Offset: 0x273A321 VA: 0x273A220
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<ContinueWith>d__25<object>>
	|
	|-RVA: 0x273A350 Offset: 0x273A451 VA: 0x273A350
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<ContinueWith>d__26<object>>
	|
	|-RVA: 0x273A480 Offset: 0x273A581 VA: 0x273A480
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<Unwrap>d__38<object>>
	|
	|-RVA: 0x273A5A0 Offset: 0x273A6A1 VA: 0x273A5A0
	|-AsyncUniTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x273A650 Offset: 0x273A751 VA: 0x273A650
	|-AsyncUniTaskMethodBuilder.Start<UniTask.<Run>d__24>
	|
	|-RVA: 0x273A660 Offset: 0x273A761 VA: 0x273A660
	|-AsyncUniTaskMethodBuilder.Start<UniTask.<Run>d__25>
	|
	|-RVA: 0x273A670 Offset: 0x273A771 VA: 0x273A670
	|-AsyncUniTaskMethodBuilder.Start<UniTask.<WhenAll>d__53>
	|
	|-RVA: 0x273A680 Offset: 0x273A781 VA: 0x273A680
	|-AsyncUniTaskMethodBuilder.Start<UniTask.<WhenAll>d__54>
	|
	|-RVA: 0x273A690 Offset: 0x273A791 VA: 0x273A690
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<ConfigureAwait>d__33>
	|
	|-RVA: 0x273A6A0 Offset: 0x273A7A1 VA: 0x273A6A0
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<ConfigureAwait>d__35>
	|
	|-RVA: 0x273A6B0 Offset: 0x273A7B1 VA: 0x273A6B0
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<ContinueWith>d__29>
	|
	|-RVA: 0x273A6C0 Offset: 0x273A7C1 VA: 0x273A6C0
	|-AsyncUniTaskMethodBuilder.Start<UniTaskExtensions.<ContinueWith>d__30>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EB90 Offset: 0x2EC91 VA: 0x2EB90
	// RVA: 0x2E7D1E0 Offset: 0x2E7D2E1 VA: 0x2E7D1E0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

