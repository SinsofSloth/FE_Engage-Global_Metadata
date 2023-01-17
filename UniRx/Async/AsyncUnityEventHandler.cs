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

