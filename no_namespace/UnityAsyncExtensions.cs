// Namespace: 
public struct UnityAsyncExtensions.AsyncOperationAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5140
{
	// Fields
	private AsyncOperation asyncOperation; // 0x0
	private Action<AsyncOperation> continuationAction; // 0x8
	private AwaiterStatus status; // 0x10

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2BCA0 Offset: 0x1C2BDA1 VA: 0x1C2BCA0
	public void .ctor(AsyncOperation asyncOperation) { }

	// RVA: 0x1C2BD00 Offset: 0x1C2BE01 VA: 0x1C2BD00 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x1C2BD10 Offset: 0x1C2BE11 VA: 0x1C2BD10 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2BD20 Offset: 0x1C2BE21 VA: 0x1C2BD20 Slot: 6
	public void GetResult() { }

	// RVA: 0x1C2BDB0 Offset: 0x1C2BEB1 VA: 0x1C2BDB0 Slot: 8
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2BDC0 Offset: 0x1C2BEC1 VA: 0x1C2BDC0 Slot: 7
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: 
public struct UnityAsyncExtensions.ResourceRequestAwaiter : IAwaiter<Object>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5142
{
	// Fields
	private ResourceRequest asyncOperation; // 0x0
	private Action<AsyncOperation> continuationAction; // 0x8
	private AwaiterStatus status; // 0x10
	private Object result; // 0x18

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2C780 Offset: 0x1C2C881 VA: 0x1C2C780
	public void .ctor(ResourceRequest asyncOperation) { }

	// RVA: 0x1C2C800 Offset: 0x1C2C901 VA: 0x1C2C800 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C2C810 Offset: 0x1C2C911 VA: 0x1C2C810 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2C820 Offset: 0x1C2C921 VA: 0x1C2C820 Slot: 4
	public Object GetResult() { }

	// RVA: 0x1C2C8E0 Offset: 0x1C2C9E1 VA: 0x1C2C8E0 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x1C2C8F0 Offset: 0x1C2C9F1 VA: 0x1C2C8F0 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2C900 Offset: 0x1C2CA01 VA: 0x1C2C900 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: 
private class UnityAsyncExtensions.WWWConfiguredAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem // TypeDefIndex: 5144
{
	// Fields
	private WWW asyncOperation; // 0x10
	private IProgress<float> progress; // 0x18
	private CancellationToken cancellationToken; // 0x20
	private AwaiterStatus status; // 0x28
	private Action continuation; // 0x30

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2D6E0 Offset: 0x1C2D7E1 VA: 0x1C2D6E0
	public void .ctor(WWW asyncOperation, IProgress<float> progress, CancellationToken cancellationToken) { }

	// RVA: 0x1C2D7A0 Offset: 0x1C2D8A1 VA: 0x1C2D7A0 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x1C2D7B0 Offset: 0x1C2D8B1 VA: 0x1C2D7B0 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2D7C0 Offset: 0x1C2D8C1 VA: 0x1C2D7C0 Slot: 6
	public void GetResult() { }

	// RVA: 0x1C2D800 Offset: 0x1C2D901 VA: 0x1C2D800 Slot: 9
	public bool MoveNext() { }

	// RVA: 0x1C2D910 Offset: 0x1C2DA11 VA: 0x1C2D910
	private void InvokeContinuation(AwaiterStatus status) { }

	// RVA: 0x1C2D9F0 Offset: 0x1C2DAF1 VA: 0x1C2D9F0 Slot: 8
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2DA90 Offset: 0x1C2DB91 VA: 0x1C2DA90 Slot: 7
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: 
private class UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredAwaiter : IAwaiter<UnityWebRequest>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem // TypeDefIndex: 5146
{
	// Fields
	private UnityWebRequestAsyncOperation asyncOperation; // 0x10
	private IProgress<float> progress; // 0x18
	private CancellationToken cancellationToken; // 0x20
	private AwaiterStatus status; // 0x28
	private Action continuation; // 0x30
	private UnityWebRequest result; // 0x38

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2D190 Offset: 0x1C2D291 VA: 0x1C2D190
	public void .ctor(UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken) { }

	// RVA: 0x1C2D280 Offset: 0x1C2D381 VA: 0x1C2D280 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C2D290 Offset: 0x1C2D391 VA: 0x1C2D290 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2D2A0 Offset: 0x1C2D3A1 VA: 0x1C2D2A0 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x1C2D310 Offset: 0x1C2D411 VA: 0x1C2D310 Slot: 4
	public UnityWebRequest GetResult() { }

	// RVA: 0x1C2D390 Offset: 0x1C2D491 VA: 0x1C2D390 Slot: 10
	public bool MoveNext() { }

	// RVA: 0x1C2D4C0 Offset: 0x1C2D5C1 VA: 0x1C2D4C0
	private void InvokeContinuation(AwaiterStatus status) { }

	// RVA: 0x1C2D5A0 Offset: 0x1C2D6A1 VA: 0x1C2D5A0 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2D640 Offset: 0x1C2D741 VA: 0x1C2D640 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
}

