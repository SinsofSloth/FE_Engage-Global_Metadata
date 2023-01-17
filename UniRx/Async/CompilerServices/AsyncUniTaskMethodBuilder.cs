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

// Namespace: UniRx.Async.CompilerServices
public struct AsyncUniTaskMethodBuilder<T> // TypeDefIndex: 5228
{
	// Fields
	private T result; // 0x0
	private UniTaskCompletionSource<T> promise; // 0x0
	private Action moveNext; // 0x0

	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F330 Offset: 0x2F431 VA: 0x2F330
	public UniTask<T> Task { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2EBA0 Offset: 0x2ECA1 VA: 0x2EBA0
	// RVA: -1 Offset: -1
	public static AsyncUniTaskMethodBuilder<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54890 Offset: 0x2F54991 VA: 0x2F54890
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Create
	|
	|-RVA: 0x2F54D40 Offset: 0x2F54E41 VA: 0x2F54D40
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2F55220 Offset: 0x2F55321 VA: 0x2F55220
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.Create
	|
	|-RVA: 0x2F556C0 Offset: 0x2F557C1 VA: 0x2F556C0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|
	|-RVA: 0x2F55BA0 Offset: 0x2F55CA1 VA: 0x2F55BA0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.Create
	|
	|-RVA: 0x2F56080 Offset: 0x2F56181 VA: 0x2F56080
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.Create
	|
	|-RVA: 0x2F56550 Offset: 0x2F56651 VA: 0x2F56550
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2F56A80 Offset: 0x2F56B81 VA: 0x2F56A80
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.Create
	|
	|-RVA: 0x2F56F60 Offset: 0x2F57061 VA: 0x2F56F60
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2F574C0 Offset: 0x2F575C1 VA: 0x2F574C0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.Create
	|
	|-RVA: 0x2F579C0 Offset: 0x2F57AC1 VA: 0x2F579C0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2F57F60 Offset: 0x2F58061 VA: 0x2F57F60
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.Create
	|
	|-RVA: 0x2F58490 Offset: 0x2F58591 VA: 0x2F58490
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2F58A60 Offset: 0x2F58B61 VA: 0x2F58A60
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.Create
	|
	|-RVA: 0x2F58FA0 Offset: 0x2F590A1 VA: 0x2F58FA0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2F595C0 Offset: 0x2F596C1 VA: 0x2F595C0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.Create
	|
	|-RVA: 0x2F59B20 Offset: 0x2F59C21 VA: 0x2F59B20
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2F5A170 Offset: 0x2F5A271 VA: 0x2F5A170
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2F5A6E0 Offset: 0x2F5A7E1 VA: 0x2F5A6E0
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.Create
	|
	|-RVA: 0x2F5AB80 Offset: 0x2F5AC81 VA: 0x2F5AB80
	|-AsyncUniTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x2F5B030 Offset: 0x2F5B131 VA: 0x2F5B030
	|-AsyncUniTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x2F5B4D0 Offset: 0x2F5B5D1 VA: 0x2F5B4D0
	|-AsyncUniTaskMethodBuilder<object>.Create
	*/

	// RVA: -1 Offset: -1
	public UniTask<T> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F548A0 Offset: 0x2F549A1 VA: 0x2F548A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Task
	|
	|-RVA: 0x2F54D50 Offset: 0x2F54E51 VA: 0x2F54D50
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x2F55230 Offset: 0x2F55331 VA: 0x2F55230
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.get_Task
	|
	|-RVA: 0x2F556D0 Offset: 0x2F557D1 VA: 0x2F556D0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x2F55BB0 Offset: 0x2F55CB1 VA: 0x2F55BB0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.get_Task
	|
	|-RVA: 0x2F56090 Offset: 0x2F56191 VA: 0x2F56090
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.get_Task
	|
	|-RVA: 0x2F56570 Offset: 0x2F56671 VA: 0x2F56570
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x2F56A90 Offset: 0x2F56B91 VA: 0x2F56A90
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.get_Task
	|
	|-RVA: 0x2F56F80 Offset: 0x2F57081 VA: 0x2F56F80
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x2F574D0 Offset: 0x2F575D1 VA: 0x2F574D0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.get_Task
	|
	|-RVA: 0x2F579E0 Offset: 0x2F57AE1 VA: 0x2F579E0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x2F57F80 Offset: 0x2F58081 VA: 0x2F57F80
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.get_Task
	|
	|-RVA: 0x2F584B0 Offset: 0x2F585B1 VA: 0x2F584B0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x2F58A80 Offset: 0x2F58B81 VA: 0x2F58A80
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.get_Task
	|
	|-RVA: 0x2F58FD0 Offset: 0x2F590D1 VA: 0x2F58FD0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x2F595E0 Offset: 0x2F596E1 VA: 0x2F595E0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.get_Task
	|
	|-RVA: 0x2F59B50 Offset: 0x2F59C51 VA: 0x2F59B50
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Task
	|
	|-RVA: 0x2F5A1A0 Offset: 0x2F5A2A1 VA: 0x2F5A1A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Task
	|
	|-RVA: 0x2F5A6F0 Offset: 0x2F5A7F1 VA: 0x2F5A6F0
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.get_Task
	|
	|-RVA: 0x2F5AB90 Offset: 0x2F5AC91 VA: 0x2F5AB90
	|-AsyncUniTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x2F5B040 Offset: 0x2F5B141 VA: 0x2F5B040
	|-AsyncUniTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x2F5B4E0 Offset: 0x2F5B5E1 VA: 0x2F5B4E0
	|-AsyncUniTaskMethodBuilder<object>.get_Task
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EBB0 Offset: 0x2ECB1 VA: 0x2EBB0
	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54A10 Offset: 0x2F54B11 VA: 0x2F54A10
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.SetException
	|
	|-RVA: 0x2F54EF0 Offset: 0x2F54FF1 VA: 0x2F54EF0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.SetException
	|
	|-RVA: 0x2F553A0 Offset: 0x2F554A1 VA: 0x2F553A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.SetException
	|
	|-RVA: 0x2F55860 Offset: 0x2F55961 VA: 0x2F55860
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|
	|-RVA: 0x2F55D40 Offset: 0x2F55E41 VA: 0x2F55D40
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.SetException
	|
	|-RVA: 0x2F56220 Offset: 0x2F56321 VA: 0x2F56220
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.SetException
	|
	|-RVA: 0x2F56740 Offset: 0x2F56841 VA: 0x2F56740
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetException
	|
	|-RVA: 0x2F56C30 Offset: 0x2F56D31 VA: 0x2F56C30
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.SetException
	|
	|-RVA: 0x2F57170 Offset: 0x2F57271 VA: 0x2F57170
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetException
	|
	|-RVA: 0x2F57690 Offset: 0x2F57791 VA: 0x2F57690
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.SetException
	|
	|-RVA: 0x2F57C00 Offset: 0x2F57D01 VA: 0x2F57C00
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetException
	|
	|-RVA: 0x2F58150 Offset: 0x2F58251 VA: 0x2F58150
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.SetException
	|
	|-RVA: 0x2F586F0 Offset: 0x2F587F1 VA: 0x2F586F0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetException
	|
	|-RVA: 0x2F58C60 Offset: 0x2F58D61 VA: 0x2F58C60
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.SetException
	|
	|-RVA: 0x2F59230 Offset: 0x2F59331 VA: 0x2F59230
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetException
	|
	|-RVA: 0x2F597D0 Offset: 0x2F598D1 VA: 0x2F597D0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.SetException
	|
	|-RVA: 0x2F59DD0 Offset: 0x2F59ED1 VA: 0x2F59DD0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.SetException
	|
	|-RVA: 0x2F5A3A0 Offset: 0x2F5A4A1 VA: 0x2F5A3A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SetException
	|
	|-RVA: 0x2F5A860 Offset: 0x2F5A961 VA: 0x2F5A860
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.SetException
	|
	|-RVA: 0x2F5AD00 Offset: 0x2F5AE01 VA: 0x2F5AD00
	|-AsyncUniTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x2F5B1B0 Offset: 0x2F5B2B1 VA: 0x2F5B1B0
	|-AsyncUniTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x2F5B650 Offset: 0x2F5B751 VA: 0x2F5B650
	|-AsyncUniTaskMethodBuilder<object>.SetException
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EBC0 Offset: 0x2ECC1 VA: 0x2EBC0
	// RVA: -1 Offset: -1
	public void SetResult(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54BB0 Offset: 0x2F54CB1 VA: 0x2F54BB0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.SetResult
	|
	|-RVA: 0x2F55090 Offset: 0x2F55191 VA: 0x2F55090
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.SetResult
	|
	|-RVA: 0x2F55540 Offset: 0x2F55641 VA: 0x2F55540
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.SetResult
	|
	|-RVA: 0x2F55A00 Offset: 0x2F55B01 VA: 0x2F55A00
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x2F55EE0 Offset: 0x2F55FE1 VA: 0x2F55EE0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.SetResult
	|
	|-RVA: 0x2F563C0 Offset: 0x2F564C1 VA: 0x2F563C0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.SetResult
	|
	|-RVA: 0x2F568E0 Offset: 0x2F569E1 VA: 0x2F568E0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetResult
	|
	|-RVA: 0x2F56DD0 Offset: 0x2F56ED1 VA: 0x2F56DD0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.SetResult
	|
	|-RVA: 0x2F57310 Offset: 0x2F57411 VA: 0x2F57310
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetResult
	|
	|-RVA: 0x2F57830 Offset: 0x2F57931 VA: 0x2F57830
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.SetResult
	|
	|-RVA: 0x2F57DA0 Offset: 0x2F57EA1 VA: 0x2F57DA0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetResult
	|
	|-RVA: 0x2F582F0 Offset: 0x2F583F1 VA: 0x2F582F0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.SetResult
	|
	|-RVA: 0x2F58890 Offset: 0x2F58991 VA: 0x2F58890
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetResult
	|
	|-RVA: 0x2F58E00 Offset: 0x2F58F01 VA: 0x2F58E00
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.SetResult
	|
	|-RVA: 0x2F593D0 Offset: 0x2F594D1 VA: 0x2F593D0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetResult
	|
	|-RVA: 0x2F59970 Offset: 0x2F59A71 VA: 0x2F59970
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.SetResult
	|
	|-RVA: 0x2F59F70 Offset: 0x2F5A071 VA: 0x2F59F70
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.SetResult
	|
	|-RVA: 0x2F5A540 Offset: 0x2F5A641 VA: 0x2F5A540
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SetResult
	|
	|-RVA: 0x2F5AA00 Offset: 0x2F5AB01 VA: 0x2F5AA00
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.SetResult
	|
	|-RVA: 0x2F5AEA0 Offset: 0x2F5AFA1 VA: 0x2F5AEA0
	|-AsyncUniTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x2F5B350 Offset: 0x2F5B451 VA: 0x2F5B350
	|-AsyncUniTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x2F5B7F0 Offset: 0x2F5B8F1 VA: 0x2F5B7F0
	|-AsyncUniTaskMethodBuilder<object>.SetResult
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EBD0 Offset: 0x2ECD1 VA: 0x2EBD0
	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x254FF30 Offset: 0x2550031 VA: 0x254FF30
	|-AsyncUniTaskMethodBuilder<object>.AwaitOnCompleted<object, object>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EBE0 Offset: 0x2ECE1 VA: 0x2EBE0
	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x254B600 Offset: 0x254B701 VA: 0x254B600
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.AwaitUnsafeOnCompleted<UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, AsyncUnit>>, UniTask.<WhenAny>d__71<ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x254B970 Offset: 0x254BA71 VA: 0x254B970
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.AwaitUnsafeOnCompleted<UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, object>>, UniTask.<WhenAny>d__71<ValueTuple<bool, object>>>
	|
	|-RVA: 0x254BD00 Offset: 0x254BE01 VA: 0x254BD00
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>, UniTaskExtensions.<TimeoutWithoutException>d__16<AsyncUnit>>
	|
	|-RVA: 0x254C090 Offset: 0x254C191 VA: 0x254C090
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>, UniTaskExtensions.<TimeoutWithoutException>d__16<object>>
	|
	|-RVA: 0x254C2F0 Offset: 0x254C3F1 VA: 0x254C2F0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<UniTask.UnitWhenAnyPromise.Awaiter<object>, UniTask.<WhenAny>d__71<object>>
	|
	|-RVA: 0x254C7D0 Offset: 0x254C8D1 VA: 0x254C7D0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object>, UniTask.<WhenAny>d__72<object>>
	|
	|-RVA: 0x254CB40 Offset: 0x254CC41 VA: 0x254CB40
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object, object>, UniTask.<WhenAll>d__39<object, object>>
	|
	|-RVA: 0x254CEC0 Offset: 0x254CFC1 VA: 0x254CEC0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object>, UniTask.<WhenAny>d__57<object, object>>
	|
	|-RVA: 0x254D260 Offset: 0x254D361 VA: 0x254D260
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object, object, object>, UniTask.<WhenAll>d__40<object, object, object>>
	|
	|-RVA: 0x254D600 Offset: 0x254D701 VA: 0x254D600
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object, object>, UniTask.<WhenAny>d__58<object, object, object>>
	|
	|-RVA: 0x254D950 Offset: 0x254DA51 VA: 0x254D950
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object, object, object, object>, UniTask.<WhenAll>d__41<object, object, object, object>>
	|
	|-RVA: 0x254DD00 Offset: 0x254DE01 VA: 0x254DD00
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object, object, object>, UniTask.<WhenAny>d__59<object, object, object, object>>
	|
	|-RVA: 0x254E050 Offset: 0x254E151 VA: 0x254E050
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object, object, object, object, object>, UniTask.<WhenAll>d__42<object, object, object, object, object>>
	|
	|-RVA: 0x254E3A0 Offset: 0x254E4A1 VA: 0x254E3A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object>, UniTask.<WhenAny>d__60<object, object, object, object, object>>
	|
	|-RVA: 0x254E6F0 Offset: 0x254E7F1 VA: 0x254E6F0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object>, UniTask.<WhenAll>d__43<object, object, object, object, object, object>>
	|
	|-RVA: 0x254EA40 Offset: 0x254EB41 VA: 0x254EA40
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object>, UniTask.<WhenAny>d__61<object, object, object, object, object, object>>
	|
	|-RVA: 0x254ED90 Offset: 0x254EE91 VA: 0x254ED90
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object, object>, UniTask.<WhenAll>d__44<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x254F0E0 Offset: 0x254F1E1 VA: 0x254F0E0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object>, UniTask.<WhenAny>d__62<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x254F430 Offset: 0x254F531 VA: 0x254F430
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object, object>, UniTask.<WhenAny>d__63<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x254F780 Offset: 0x254F881 VA: 0x254F780
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>, UniTaskExtensions.<Timeout>d__14<AsyncUnit>>
	|
	|-RVA: 0x254FB10 Offset: 0x254FC11 VA: 0x254FB10
	|-AsyncUniTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>, UniTaskExtensions.<TimeoutWithoutException>d__15>
	|
	|-RVA: 0x254FD70 Offset: 0x254FE71 VA: 0x254FD70
	|-AsyncUniTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<UniTask.WhenAnyPromise.Awaiter, UniTask.<WhenAny>d__73>
	|
	|-RVA: 0x2550140 Offset: 0x2550241 VA: 0x2550140
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<UniTask<object>>, UniTaskExtensions.<Unwrap>d__37<object>>
	|
	|-RVA: 0x25503A0 Offset: 0x25504A1 VA: 0x25503A0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>, UniTaskExtensions.<Timeout>d__14<object>>
	|
	|-RVA: 0x2550600 Offset: 0x2550701 VA: 0x2550600
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ConfigureAwait>d__36<object>>
	|
	|-RVA: 0x2550850 Offset: 0x2550951 VA: 0x2550850
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ContinueWith>d__27<object, object>>
	|
	|-RVA: 0x2550AA0 Offset: 0x2550BA1 VA: 0x2550AA0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ContinueWith>d__28<object, object>>
	|
	|-RVA: 0x2550CF0 Offset: 0x2550DF1 VA: 0x2550CF0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<ContinueWith>d__32<object>>
	|
	|-RVA: 0x2550F40 Offset: 0x2551041 VA: 0x2550F40
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter<object>, UniTaskExtensions.<Unwrap>d__37<object>>
	|
	|-RVA: 0x2551190 Offset: 0x2551291 VA: 0x2551190
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object>, UniTask.<WhenAll>d__51<object>>
	|
	|-RVA: 0x25513E0 Offset: 0x25514E1 VA: 0x25513E0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.WhenAllPromise.Awaiter<object>, UniTask.<WhenAll>d__52<object>>
	|
	|-RVA: 0x2551630 Offset: 0x2551731 VA: 0x2551630
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, UniTaskExtensions.<ConfigureAwait>d__34<object>>
	|
	|-RVA: 0x2551880 Offset: 0x2551981 VA: 0x2551880
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x2551A90 Offset: 0x2551B91 VA: 0x2551A90
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<SwitchToThreadPoolAwaitable.Awaiter, UniTask.<Run>d__26<object>>
	|
	|-RVA: 0x2551C40 Offset: 0x2551D41 VA: 0x2551C40
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<SwitchToThreadPoolAwaitable.Awaiter, UniTask.<Run>d__27<object>>
	|
	|-RVA: 0x2551DF0 Offset: 0x2551EF1 VA: 0x2551DF0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ContinueWith>d__31<object>>
	|
	|-RVA: 0x2551FA0 Offset: 0x25520A1 VA: 0x2551FA0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<UniTask.Awaiter, UniTaskExtensions.<ContinueWith>d__32<object>>
	|
	|-RVA: 0x2552150 Offset: 0x2552251 VA: 0x2552150
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTaskExtensions.<ConfigureAwait>d__34<object>>
	|
	|-RVA: 0x2552300 Offset: 0x2552401 VA: 0x2552300
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTaskExtensions.<ConfigureAwait>d__36<object>>
	|
	|-RVA: 0x25524B0 Offset: 0x25525B1 VA: 0x25524B0
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTask.<Run>d__26<object>>
	|
	|-RVA: 0x2552660 Offset: 0x2552761 VA: 0x2552660
	|-AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<YieldAwaitable.Awaiter, UniTask.<Run>d__27<object>>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EBF0 Offset: 0x2ECF1 VA: 0x2EBF0
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x254B850 Offset: 0x254B951 VA: 0x254B850
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Start<UniTask.<WhenAny>d__71<ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x254BBC0 Offset: 0x254BCC1 VA: 0x254BBC0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.Start<UniTask.<WhenAny>d__71<ValueTuple<bool, object>>>
	|
	|-RVA: 0x254BF50 Offset: 0x254C051 VA: 0x254BF50
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.Start<UniTaskExtensions.<TimeoutWithoutException>d__16<AsyncUnit>>
	|
	|-RVA: 0x254C540 Offset: 0x254C641 VA: 0x254C540
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.Start<UniTaskExtensions.<TimeoutWithoutException>d__16<object>>
	|
	|-RVA: 0x254C6A0 Offset: 0x254C7A1 VA: 0x254C6A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.Start<UniTask.<WhenAny>d__71<object>>
	|
	|-RVA: 0x254CA20 Offset: 0x254CB21 VA: 0x254CA20
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.Start<UniTask.<WhenAny>d__72<object>>
	|
	|-RVA: 0x254CD90 Offset: 0x254CE91 VA: 0x254CD90
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.Start<UniTask.<WhenAll>d__39<object, object>>
	|
	|-RVA: 0x254D110 Offset: 0x254D211 VA: 0x254D110
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Start<UniTask.<WhenAny>d__57<object, object>>
	|
	|-RVA: 0x254D4B0 Offset: 0x254D5B1 VA: 0x254D4B0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.Start<UniTask.<WhenAll>d__40<object, object, object>>
	|
	|-RVA: 0x254D850 Offset: 0x254D951 VA: 0x254D850
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Start<UniTask.<WhenAny>d__58<object, object, object>>
	|
	|-RVA: 0x254DBA0 Offset: 0x254DCA1 VA: 0x254DBA0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.Start<UniTask.<WhenAll>d__41<object, object, object, object>>
	|
	|-RVA: 0x254DF50 Offset: 0x254E051 VA: 0x254DF50
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Start<UniTask.<WhenAny>d__59<object, object, object, object>>
	|
	|-RVA: 0x254E2A0 Offset: 0x254E3A1 VA: 0x254E2A0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.Start<UniTask.<WhenAll>d__42<object, object, object, object, object>>
	|
	|-RVA: 0x254E5F0 Offset: 0x254E6F1 VA: 0x254E5F0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Start<UniTask.<WhenAny>d__60<object, object, object, object, object>>
	|
	|-RVA: 0x254E940 Offset: 0x254EA41 VA: 0x254E940
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.Start<UniTask.<WhenAll>d__43<object, object, object, object, object, object>>
	|
	|-RVA: 0x254EC90 Offset: 0x254ED91 VA: 0x254EC90
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Start<UniTask.<WhenAny>d__61<object, object, object, object, object, object>>
	|
	|-RVA: 0x254EFE0 Offset: 0x254F0E1 VA: 0x254EFE0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.Start<UniTask.<WhenAll>d__44<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x254F330 Offset: 0x254F431 VA: 0x254F330
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Start<UniTask.<WhenAny>d__62<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x254F680 Offset: 0x254F781 VA: 0x254F680
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Start<UniTask.<WhenAny>d__63<object, object, object, object, object, object, object, object>>
	|
	|-RVA: 0x254F9D0 Offset: 0x254FAD1 VA: 0x254F9D0
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.Start<UniTaskExtensions.<Timeout>d__14<AsyncUnit>>
	|
	|-RVA: 0x254FD60 Offset: 0x254FE61 VA: 0x254FD60
	|-AsyncUniTaskMethodBuilder<bool>.Start<UniTaskExtensions.<TimeoutWithoutException>d__15>
	|
	|-RVA: 0x254FF20 Offset: 0x2550021 VA: 0x254FF20
	|-AsyncUniTaskMethodBuilder<int>.Start<UniTask.<WhenAny>d__73>
	|
	|-RVA: 0x2552810 Offset: 0x2552911 VA: 0x2552810
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<ConfigureAwait>d__34<object>>
	|
	|-RVA: 0x2552940 Offset: 0x2552A41 VA: 0x2552940
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<ConfigureAwait>d__36<object>>
	|
	|-RVA: 0x2552A80 Offset: 0x2552B81 VA: 0x2552A80
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<ContinueWith>d__27<object, object>>
	|
	|-RVA: 0x2552BB0 Offset: 0x2552CB1 VA: 0x2552BB0
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<ContinueWith>d__28<object, object>>
	|
	|-RVA: 0x2552CF0 Offset: 0x2552DF1 VA: 0x2552CF0
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<ContinueWith>d__31<object>>
	|
	|-RVA: 0x2552E10 Offset: 0x2552F11 VA: 0x2552E10
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<ContinueWith>d__32<object>>
	|
	|-RVA: 0x2552F40 Offset: 0x2553041 VA: 0x2552F40
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTask.<Run>d__26<object>>
	|
	|-RVA: 0x2553060 Offset: 0x2553161 VA: 0x2553060
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTask.<Run>d__27<object>>
	|
	|-RVA: 0x2553190 Offset: 0x2553291 VA: 0x2553190
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<Timeout>d__14<object>>
	|
	|-RVA: 0x25532E0 Offset: 0x25533E1 VA: 0x25532E0
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTaskExtensions.<Unwrap>d__37<object>>
	|
	|-RVA: 0x2553420 Offset: 0x2553521 VA: 0x2553420
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTask.<WhenAll>d__51<object>>
	|
	|-RVA: 0x2553530 Offset: 0x2553631 VA: 0x2553530
	|-AsyncUniTaskMethodBuilder<object>.Start<UniTask.<WhenAll>d__52<object>>
	|
	|-RVA: 0x2553640 Offset: 0x2553741 VA: 0x2553640
	|-AsyncUniTaskMethodBuilder<object>.Start<object>
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2EC00 Offset: 0x2ED01 VA: 0x2EC00
	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F54D30 Offset: 0x2F54E31 VA: 0x2F54D30
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.SetStateMachine
	|
	|-RVA: 0x2F55210 Offset: 0x2F55311 VA: 0x2F55210
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, ValueTuple<bool, object>>>.SetStateMachine
	|
	|-RVA: 0x2F556B0 Offset: 0x2F557B1 VA: 0x2F556B0
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, AsyncUnit>>.SetStateMachine
	|
	|-RVA: 0x2F55B90 Offset: 0x2F55C91 VA: 0x2F55B90
	|-AsyncUniTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x2F56070 Offset: 0x2F56171 VA: 0x2F56070
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, object>>.SetStateMachine
	|
	|-RVA: 0x2F56540 Offset: 0x2F56641 VA: 0x2F56540
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object>>.SetStateMachine
	|
	|-RVA: 0x2F56A70 Offset: 0x2F56B71 VA: 0x2F56A70
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetStateMachine
	|
	|-RVA: 0x2F56F50 Offset: 0x2F57051 VA: 0x2F56F50
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object>>.SetStateMachine
	|
	|-RVA: 0x2F574B0 Offset: 0x2F575B1 VA: 0x2F574B0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetStateMachine
	|
	|-RVA: 0x2F579B0 Offset: 0x2F57AB1 VA: 0x2F579B0
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object>>.SetStateMachine
	|
	|-RVA: 0x2F57F50 Offset: 0x2F58051 VA: 0x2F57F50
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetStateMachine
	|
	|-RVA: 0x2F58480 Offset: 0x2F58581 VA: 0x2F58480
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object>>.SetStateMachine
	|
	|-RVA: 0x2F58A50 Offset: 0x2F58B51 VA: 0x2F58A50
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetStateMachine
	|
	|-RVA: 0x2F58F90 Offset: 0x2F59091 VA: 0x2F58F90
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object>>.SetStateMachine
	|
	|-RVA: 0x2F595B0 Offset: 0x2F596B1 VA: 0x2F595B0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SetStateMachine
	|
	|-RVA: 0x2F59B10 Offset: 0x2F59C11 VA: 0x2F59B10
	|-AsyncUniTaskMethodBuilder<ValueTuple<object, object, object, object, object, object, object>>.SetStateMachine
	|
	|-RVA: 0x2F5A160 Offset: 0x2F5A261 VA: 0x2F5A160
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.SetStateMachine
	|
	|-RVA: 0x2F5A6D0 Offset: 0x2F5A7D1 VA: 0x2F5A6D0
	|-AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SetStateMachine
	|
	|-RVA: 0x2F5AB70 Offset: 0x2F5AC71 VA: 0x2F5AB70
	|-AsyncUniTaskMethodBuilder<AsyncUnit>.SetStateMachine
	|
	|-RVA: 0x2F5B020 Offset: 0x2F5B121 VA: 0x2F5B020
	|-AsyncUniTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x2F5B4C0 Offset: 0x2F5B5C1 VA: 0x2F5B4C0
	|-AsyncUniTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x2F5B970 Offset: 0x2F5BA71 VA: 0x2F5B970
	|-AsyncUniTaskMethodBuilder<object>.SetStateMachine
	*/
}

