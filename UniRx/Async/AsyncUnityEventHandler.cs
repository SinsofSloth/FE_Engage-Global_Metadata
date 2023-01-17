// Namespace: UniRx.Async
public class AsyncUnityEventHandler : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IDisposable, IAsyncClickEventHandler // TypeDefIndex: 5151
{
	// Fields
	private static Action<object> cancellationCallback; // 0x0
	private readonly UnityAction action; // 0x10
	private readonly UnityEvent unityEvent; // 0x18
	private Action continuation; // 0x20
	private CancellationTokenRegistration registration; // 0x28
	private bool isDisposed; // 0x40
	private bool callOnce; // 0x41
	private Nullable<UniTask<bool>> suppressCancellationThrowTask; // 0x48

	// Properties
	private bool UniRx.Async.IAwaiter.IsCompleted { get; }
	private AwaiterStatus UniRx.Async.IAwaiter.Status { get; }

	// Methods

	// RVA: 0x2E7D6E0 Offset: 0x2E7D7E1 VA: 0x2E7D6E0
	public void .ctor(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce) { }

	// RVA: 0x2E7DA20 Offset: 0x2E7DB21 VA: 0x2E7DA20
	public UniTask OnInvokeAsync() { }

	// RVA: 0x2E7DA50 Offset: 0x2E7DB51 VA: 0x2E7DA50
	public UniTask<bool> OnInvokeAsyncSuppressCancellationThrow() { }

	// RVA: 0x2E7DD10 Offset: 0x2E7DE11 VA: 0x2E7DD10
	private void Invoke() { }

	// RVA: 0x2E7DD50 Offset: 0x2E7DE51 VA: 0x2E7DD50
	private static void CancellationCallback(object state) { }

	// RVA: 0x2E7DE30 Offset: 0x2E7DF31 VA: 0x2E7DE30 Slot: 9
	public void Dispose() { }

	// RVA: 0x2E7DE90 Offset: 0x2E7DF91 VA: 0x2E7DE90 Slot: 5
	private bool UniRx.Async.IAwaiter.get_IsCompleted() { }

	// RVA: 0x2E7DEA0 Offset: 0x2E7DFA1 VA: 0x2E7DEA0 Slot: 4
	private AwaiterStatus UniRx.Async.IAwaiter.get_Status() { }

	// RVA: 0x2E7DEC0 Offset: 0x2E7DFC1 VA: 0x2E7DEC0 Slot: 6
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x2E7DF50 Offset: 0x2E7E051 VA: 0x2E7DF50 Slot: 8
	private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action action) { }

	// RVA: 0x2E7E000 Offset: 0x2E7E101 VA: 0x2E7E000 Slot: 7
	private void System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted(Action action) { }

	// RVA: 0x2E7E090 Offset: 0x2E7E191 VA: 0x2E7E090 Slot: 10
	private UniTask UniRx.Async.IAsyncClickEventHandler.OnClickAsync() { }

	// RVA: 0x2E7E0C0 Offset: 0x2E7E1C1 VA: 0x2E7E0C0 Slot: 11
	private UniTask<bool> UniRx.Async.IAsyncClickEventHandler.OnClickAsyncSuppressCancellationThrow() { }

	// RVA: 0x2E7E0D0 Offset: 0x2E7E1D1 VA: 0x2E7E0D0
	private static void .cctor() { }
}

// Namespace: UniRx.Async
public class AsyncUnityEventHandler<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IDisposable, IAsyncValueChangedEventHandler<T>, IAsyncEndEditEventHandler<T> // TypeDefIndex: 5152
{
	// Fields
	private static Action<object> cancellationCallback; // 0x0
	private readonly UnityAction<T> action; // 0x0
	private readonly UnityEvent<T> unityEvent; // 0x0
	private Action continuation; // 0x0
	private CancellationTokenRegistration registration; // 0x0
	private bool isDisposed; // 0x0
	private T eventValue; // 0x0
	private bool callOnce; // 0x0
	private Nullable<UniTask<ValueTuple<bool, T>>> suppressCancellationThrowTask; // 0x0

	// Properties
	private bool UniRx.Async.IAwaiter.IsCompleted { get; }
	private AwaiterStatus UniRx.Async.IAwaiter.Status { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UnityEvent<T> unityEvent, CancellationToken cancellationToken, bool callOnce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5B980 Offset: 0x2F5BA81 VA: 0x2F5B980
	|-AsyncUnityEventHandler<bool>..ctor
	|
	|-RVA: 0x2F5C290 Offset: 0x2F5C391 VA: 0x2F5C290
	|-AsyncUnityEventHandler<int>..ctor
	|
	|-RVA: 0x2F5CBA0 Offset: 0x2F5CCA1 VA: 0x2F5CBA0
	|-AsyncUnityEventHandler<object>..ctor
	|-AsyncUnityEventHandler<string>..ctor
	|
	|-RVA: 0x2F5D540 Offset: 0x2F5D641 VA: 0x2F5D540
	|-AsyncUnityEventHandler<float>..ctor
	|
	|-RVA: 0x2F5DE50 Offset: 0x2F5DF51 VA: 0x2F5DE50
	|-AsyncUnityEventHandler<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public UniTask<T> OnInvokeAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BBA0 Offset: 0x2F5BCA1 VA: 0x2F5BBA0
	|-AsyncUnityEventHandler<bool>.OnInvokeAsync
	|
	|-RVA: 0x2F5C4B0 Offset: 0x2F5C5B1 VA: 0x2F5C4B0
	|-AsyncUnityEventHandler<int>.OnInvokeAsync
	|
	|-RVA: 0x2F5CDC0 Offset: 0x2F5CEC1 VA: 0x2F5CDC0
	|-AsyncUnityEventHandler<object>.OnInvokeAsync
	|-AsyncUnityEventHandler<string>.OnInvokeAsync
	|
	|-RVA: 0x2F5D760 Offset: 0x2F5D861 VA: 0x2F5D760
	|-AsyncUnityEventHandler<float>.OnInvokeAsync
	|
	|-RVA: 0x2F5E070 Offset: 0x2F5E171 VA: 0x2F5E070
	|-AsyncUnityEventHandler<Vector2>.OnInvokeAsync
	*/

	// RVA: -1 Offset: -1
	public UniTask<ValueTuple<bool, T>> OnInvokeAsyncSuppressCancellationThrow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BBE0 Offset: 0x2F5BCE1 VA: 0x2F5BBE0
	|-AsyncUnityEventHandler<bool>.OnInvokeAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5C4F0 Offset: 0x2F5C5F1 VA: 0x2F5C4F0
	|-AsyncUnityEventHandler<int>.OnInvokeAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5CE00 Offset: 0x2F5CF01 VA: 0x2F5CE00
	|-AsyncUnityEventHandler<object>.OnInvokeAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5D7A0 Offset: 0x2F5D8A1 VA: 0x2F5D7A0
	|-AsyncUnityEventHandler<float>.OnInvokeAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5E0B0 Offset: 0x2F5E1B1 VA: 0x2F5E0B0
	|-AsyncUnityEventHandler<Vector2>.OnInvokeAsyncSuppressCancellationThrow
	*/

	// RVA: -1 Offset: -1
	private void Invoke(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BCB0 Offset: 0x2F5BDB1 VA: 0x2F5BCB0
	|-AsyncUnityEventHandler<bool>.Invoke
	|
	|-RVA: 0x2F5C5C0 Offset: 0x2F5C6C1 VA: 0x2F5C5C0
	|-AsyncUnityEventHandler<int>.Invoke
	|
	|-RVA: 0x2F5CF00 Offset: 0x2F5D001 VA: 0x2F5CF00
	|-AsyncUnityEventHandler<object>.Invoke
	|
	|-RVA: 0x2F5D870 Offset: 0x2F5D971 VA: 0x2F5D870
	|-AsyncUnityEventHandler<float>.Invoke
	|
	|-RVA: 0x2F5E1B0 Offset: 0x2F5E2B1 VA: 0x2F5E1B0
	|-AsyncUnityEventHandler<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1
	private static void CancellationCallback(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BD00 Offset: 0x2F5BE01 VA: 0x2F5BD00
	|-AsyncUnityEventHandler<bool>.CancellationCallback
	|
	|-RVA: 0x2F5C610 Offset: 0x2F5C711 VA: 0x2F5C610
	|-AsyncUnityEventHandler<int>.CancellationCallback
	|
	|-RVA: 0x2F5CF50 Offset: 0x2F5D051 VA: 0x2F5CF50
	|-AsyncUnityEventHandler<object>.CancellationCallback
	|
	|-RVA: 0x2F5D8C0 Offset: 0x2F5D9C1 VA: 0x2F5D8C0
	|-AsyncUnityEventHandler<float>.CancellationCallback
	|
	|-RVA: 0x2F5E200 Offset: 0x2F5E301 VA: 0x2F5E200
	|-AsyncUnityEventHandler<Vector2>.CancellationCallback
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BE50 Offset: 0x2F5BF51 VA: 0x2F5BE50
	|-AsyncUnityEventHandler<bool>.Dispose
	|
	|-RVA: 0x2F5C760 Offset: 0x2F5C861 VA: 0x2F5C760
	|-AsyncUnityEventHandler<int>.Dispose
	|
	|-RVA: 0x2F5D0A0 Offset: 0x2F5D1A1 VA: 0x2F5D0A0
	|-AsyncUnityEventHandler<object>.Dispose
	|
	|-RVA: 0x2F5DA10 Offset: 0x2F5DB11 VA: 0x2F5DA10
	|-AsyncUnityEventHandler<float>.Dispose
	|
	|-RVA: 0x2F5E350 Offset: 0x2F5E451 VA: 0x2F5E350
	|-AsyncUnityEventHandler<Vector2>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool UniRx.Async.IAwaiter.get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BEC0 Offset: 0x2F5BFC1 VA: 0x2F5BEC0
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x2F5C7D0 Offset: 0x2F5C8D1 VA: 0x2F5C7D0
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x2F5D110 Offset: 0x2F5D211 VA: 0x2F5D110
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x2F5DA80 Offset: 0x2F5DB81 VA: 0x2F5DA80
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x2F5E3C0 Offset: 0x2F5E4C1 VA: 0x2F5E3C0
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAwaiter.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private AwaiterStatus UniRx.Async.IAwaiter.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BED0 Offset: 0x2F5BFD1 VA: 0x2F5BED0
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x2F5C7E0 Offset: 0x2F5C8E1 VA: 0x2F5C7E0
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x2F5D120 Offset: 0x2F5D221 VA: 0x2F5D120
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x2F5DA90 Offset: 0x2F5DB91 VA: 0x2F5DA90
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x2F5E3D0 Offset: 0x2F5E4D1 VA: 0x2F5E3D0
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAwaiter.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T UniRx.Async.IAwaiter<T>.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BEF0 Offset: 0x2F5BFF1 VA: 0x2F5BEF0
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x2F5C800 Offset: 0x2F5C901 VA: 0x2F5C800
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x2F5D140 Offset: 0x2F5D241 VA: 0x2F5D140
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x2F5DAB0 Offset: 0x2F5DBB1 VA: 0x2F5DAB0
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x2F5E3F0 Offset: 0x2F5E4F1 VA: 0x2F5E3F0
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAwaiter<T>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BF70 Offset: 0x2F5C071 VA: 0x2F5BF70
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5C880 Offset: 0x2F5C981 VA: 0x2F5C880
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5D1C0 Offset: 0x2F5D2C1 VA: 0x2F5D1C0
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5DB30 Offset: 0x2F5DC31 VA: 0x2F5DB30
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5E470 Offset: 0x2F5E571 VA: 0x2F5E470
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAwaiter.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5BFF0 Offset: 0x2F5C0F1 VA: 0x2F5BFF0
	|-AsyncUnityEventHandler<bool>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x2F5C900 Offset: 0x2F5CA01 VA: 0x2F5C900
	|-AsyncUnityEventHandler<int>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x2F5D240 Offset: 0x2F5D341 VA: 0x2F5D240
	|-AsyncUnityEventHandler<object>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x2F5DBB0 Offset: 0x2F5DCB1 VA: 0x2F5DBB0
	|-AsyncUnityEventHandler<float>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x2F5E4F0 Offset: 0x2F5E5F1 VA: 0x2F5E4F0
	|-AsyncUnityEventHandler<Vector2>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5C0A0 Offset: 0x2F5C1A1 VA: 0x2F5C0A0
	|-AsyncUnityEventHandler<bool>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x2F5C9B0 Offset: 0x2F5CAB1 VA: 0x2F5C9B0
	|-AsyncUnityEventHandler<int>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x2F5D2F0 Offset: 0x2F5D3F1 VA: 0x2F5D2F0
	|-AsyncUnityEventHandler<object>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x2F5DC60 Offset: 0x2F5DD61 VA: 0x2F5DC60
	|-AsyncUnityEventHandler<float>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x2F5E5A0 Offset: 0x2F5E6A1 VA: 0x2F5E5A0
	|-AsyncUnityEventHandler<Vector2>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private UniTask<T> UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5C140 Offset: 0x2F5C241 VA: 0x2F5C140
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync
	|
	|-RVA: 0x2F5CA50 Offset: 0x2F5CB51 VA: 0x2F5CA50
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync
	|
	|-RVA: 0x2F5D390 Offset: 0x2F5D491 VA: 0x2F5D390
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync
	|
	|-RVA: 0x2F5DD00 Offset: 0x2F5DE01 VA: 0x2F5DD00
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync
	|
	|-RVA: 0x2F5E640 Offset: 0x2F5E741 VA: 0x2F5E640
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsync
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private UniTask<ValueTuple<bool, T>> UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5C160 Offset: 0x2F5C261 VA: 0x2F5C160
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5CA70 Offset: 0x2F5CB71 VA: 0x2F5CA70
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5D3B0 Offset: 0x2F5D4B1 VA: 0x2F5D3B0
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5DD20 Offset: 0x2F5DE21 VA: 0x2F5DD20
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5E660 Offset: 0x2F5E761 VA: 0x2F5E660
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAsyncValueChangedEventHandler<T>.OnValueChangedAsyncSuppressCancellationThrow
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private UniTask<T> UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5C180 Offset: 0x2F5C281 VA: 0x2F5C180
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsync
	|
	|-RVA: 0x2F5CA90 Offset: 0x2F5CB91 VA: 0x2F5CA90
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsync
	|
	|-RVA: 0x2F5D400 Offset: 0x2F5D501 VA: 0x2F5D400
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsync
	|
	|-RVA: 0x2F5DD40 Offset: 0x2F5DE41 VA: 0x2F5DD40
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsync
	|
	|-RVA: 0x2F5E6B0 Offset: 0x2F5E7B1 VA: 0x2F5E6B0
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsync
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private UniTask<ValueTuple<bool, T>> UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5C1A0 Offset: 0x2F5C2A1 VA: 0x2F5C1A0
	|-AsyncUnityEventHandler<bool>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5CAB0 Offset: 0x2F5CBB1 VA: 0x2F5CAB0
	|-AsyncUnityEventHandler<int>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5D420 Offset: 0x2F5D521 VA: 0x2F5D420
	|-AsyncUnityEventHandler<object>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5DD60 Offset: 0x2F5DE61 VA: 0x2F5DD60
	|-AsyncUnityEventHandler<float>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow
	|
	|-RVA: 0x2F5E6D0 Offset: 0x2F5E7D1 VA: 0x2F5E6D0
	|-AsyncUnityEventHandler<Vector2>.UniRx.Async.IAsyncEndEditEventHandler<T>.OnEndEditAsyncSuppressCancellationThrow
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5C1C0 Offset: 0x2F5C2C1 VA: 0x2F5C1C0
	|-AsyncUnityEventHandler<bool>..cctor
	|
	|-RVA: 0x2F5CAD0 Offset: 0x2F5CBD1 VA: 0x2F5CAD0
	|-AsyncUnityEventHandler<int>..cctor
	|
	|-RVA: 0x2F5D470 Offset: 0x2F5D571 VA: 0x2F5D470
	|-AsyncUnityEventHandler<object>..cctor
	|
	|-RVA: 0x2F5DD80 Offset: 0x2F5DE81 VA: 0x2F5DD80
	|-AsyncUnityEventHandler<float>..cctor
	|
	|-RVA: 0x2F5E720 Offset: 0x2F5E821 VA: 0x2F5E720
	|-AsyncUnityEventHandler<Vector2>..cctor
	*/
}

