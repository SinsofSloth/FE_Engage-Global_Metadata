// Namespace: 
private class UnityAsyncExtensions.JobHandleAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem // TypeDefIndex: 5139
{
	// Fields
	private JobHandle jobHandle; // 0x10
	private CancellationToken cancellationToken; // 0x20
	private AwaiterStatus status; // 0x28
	private Action continuation; // 0x30

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2C2F0 Offset: 0x1C2C3F1 VA: 0x1C2C2F0
	public void .ctor(JobHandle jobHandle, CancellationToken cancellationToken, int skipFrame = 2) { }

	// RVA: 0x1C2C3A0 Offset: 0x1C2C4A1 VA: 0x1C2C3A0 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x1C2C3B0 Offset: 0x1C2C4B1 VA: 0x1C2C3B0 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2C3C0 Offset: 0x1C2C4C1 VA: 0x1C2C3C0 Slot: 6
	public void GetResult() { }

	// RVA: 0x1C2C400 Offset: 0x1C2C501 VA: 0x1C2C400 Slot: 9
	public bool MoveNext() { }

	// RVA: 0x1C2C580 Offset: 0x1C2C681 VA: 0x1C2C580
	private void InvokeContinuation(AwaiterStatus status) { }

	// RVA: 0x1C2C640 Offset: 0x1C2C741 VA: 0x1C2C640 Slot: 8
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2C6E0 Offset: 0x1C2C7E1 VA: 0x1C2C6E0 Slot: 7
	public void UnsafeOnCompleted(Action continuation) { }
}

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
private class UnityAsyncExtensions.AsyncOperationConfiguredAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem // TypeDefIndex: 5141
{
	// Fields
	private AsyncOperation asyncOperation; // 0x10
	private IProgress<float> progress; // 0x18
	private CancellationToken cancellationToken; // 0x20
	private AwaiterStatus status; // 0x28
	private Action continuation; // 0x30

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2BEA0 Offset: 0x1C2BFA1 VA: 0x1C2BEA0
	public void .ctor(AsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken) { }

	// RVA: 0x1C2BF60 Offset: 0x1C2C061 VA: 0x1C2BF60 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x1C2BF70 Offset: 0x1C2C071 VA: 0x1C2BF70 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2BF80 Offset: 0x1C2C081 VA: 0x1C2BF80 Slot: 6
	public void GetResult() { }

	// RVA: 0x1C2BFC0 Offset: 0x1C2C0C1 VA: 0x1C2BFC0 Slot: 9
	public bool MoveNext() { }

	// RVA: 0x1C2C0D0 Offset: 0x1C2C1D1 VA: 0x1C2C0D0
	private void InvokeContinuation(AwaiterStatus status) { }

	// RVA: 0x1C2C1B0 Offset: 0x1C2C2B1 VA: 0x1C2C1B0 Slot: 8
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2C250 Offset: 0x1C2C351 VA: 0x1C2C250 Slot: 7
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
private class UnityAsyncExtensions.ResourceRequestConfiguredAwaiter : IAwaiter<Object>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem // TypeDefIndex: 5143
{
	// Fields
	private ResourceRequest asyncOperation; // 0x10
	private IProgress<float> progress; // 0x18
	private CancellationToken cancellationToken; // 0x20
	private AwaiterStatus status; // 0x28
	private Action continuation; // 0x30
	private Object result; // 0x38

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2C9E0 Offset: 0x1C2CAE1 VA: 0x1C2C9E0
	public void .ctor(ResourceRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken) { }

	// RVA: 0x1C2CAD0 Offset: 0x1C2CBD1 VA: 0x1C2CAD0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C2CAE0 Offset: 0x1C2CBE1 VA: 0x1C2CAE0 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2CAF0 Offset: 0x1C2CBF1 VA: 0x1C2CAF0 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x1C2CB60 Offset: 0x1C2CC61 VA: 0x1C2CB60 Slot: 4
	public Object GetResult() { }

	// RVA: 0x1C2CBE0 Offset: 0x1C2CCE1 VA: 0x1C2CBE0 Slot: 10
	public bool MoveNext() { }

	// RVA: 0x1C2CD10 Offset: 0x1C2CE11 VA: 0x1C2CD10
	private void InvokeContinuation(AwaiterStatus status) { }

	// RVA: 0x1C2CDF0 Offset: 0x1C2CEF1 VA: 0x1C2CDF0 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2CE90 Offset: 0x1C2CF91 VA: 0x1C2CE90 Slot: 8
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
public struct UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter : IAwaiter<UnityWebRequest>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5145
{
	// Fields
	private UnityWebRequestAsyncOperation asyncOperation; // 0x0
	private Action<AsyncOperation> continuationAction; // 0x8
	private AwaiterStatus status; // 0x10
	private UnityWebRequest result; // 0x18

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2CF30 Offset: 0x1C2D031 VA: 0x1C2CF30
	public void .ctor(UnityWebRequestAsyncOperation asyncOperation) { }

	// RVA: 0x1C2CFB0 Offset: 0x1C2D0B1 VA: 0x1C2CFB0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C2CFC0 Offset: 0x1C2D0C1 VA: 0x1C2CFC0 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2CFD0 Offset: 0x1C2D0D1 VA: 0x1C2CFD0 Slot: 4
	public UnityWebRequest GetResult() { }

	// RVA: 0x1C2D090 Offset: 0x1C2D191 VA: 0x1C2D090 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x1C2D0A0 Offset: 0x1C2D1A1 VA: 0x1C2D0A0 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2D0B0 Offset: 0x1C2D1B1 VA: 0x1C2D0B0 Slot: 8
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

