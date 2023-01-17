// Namespace: UniRx.Async.Internal
public abstract class ReusablePromise<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5219
{
	// Fields
	private T result; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private object continuation; // 0x0
	private AwaiterStatus status; // 0x0

	// Properties
	public UniTask<T> Task { get; }
	public virtual bool IsCompleted { get; }
	protected T RawResult { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: -1 Offset: -1
	public UniTask<T> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9A00 Offset: 0x2FF9B01 VA: 0x2FF9A00
	|-ReusablePromise<AsyncUnit>.get_Task
	|
	|-RVA: 0x2FFA1A0 Offset: 0x2FFA2A1 VA: 0x2FFA1A0
	|-ReusablePromise<int>.get_Task
	|
	|-RVA: 0x2FFA940 Offset: 0x2FFAA41 VA: 0x2FFA940
	|-ReusablePromise<object>.get_Task
	|
	|-RVA: 0x2FFB0F0 Offset: 0x2FFB1F1 VA: 0x2FFB0F0
	|-ReusablePromise<float>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9A40 Offset: 0x2FF9B41 VA: 0x2FF9A40
	|-ReusablePromise<AsyncUnit>.get_IsCompleted
	|
	|-RVA: 0x2FFA1E0 Offset: 0x2FFA2E1 VA: 0x2FFA1E0
	|-ReusablePromise<int>.get_IsCompleted
	|
	|-RVA: 0x2FFA980 Offset: 0x2FFAA81 VA: 0x2FFA980
	|-ReusablePromise<object>.get_IsCompleted
	|
	|-RVA: 0x2FFB130 Offset: 0x2FFB231 VA: 0x2FFB130
	|-ReusablePromise<float>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	protected T get_RawResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9A50 Offset: 0x2FF9B51 VA: 0x2FF9A50
	|-ReusablePromise<AsyncUnit>.get_RawResult
	|
	|-RVA: 0x2FFA1F0 Offset: 0x2FFA2F1 VA: 0x2FFA1F0
	|-ReusablePromise<int>.get_RawResult
	|
	|-RVA: 0x2FFA990 Offset: 0x2FFAA91 VA: 0x2FFA990
	|-ReusablePromise<object>.get_RawResult
	|
	|-RVA: 0x2FFB140 Offset: 0x2FFB241 VA: 0x2FFB140
	|-ReusablePromise<float>.get_RawResult
	*/

	// RVA: -1 Offset: -1
	protected void ForceSetResult(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9A60 Offset: 0x2FF9B61 VA: 0x2FF9A60
	|-ReusablePromise<AsyncUnit>.ForceSetResult
	|
	|-RVA: 0x2FFA200 Offset: 0x2FFA301 VA: 0x2FFA200
	|-ReusablePromise<int>.ForceSetResult
	|
	|-RVA: 0x2FFA9A0 Offset: 0x2FFAAA1 VA: 0x2FFA9A0
	|-ReusablePromise<object>.ForceSetResult
	|
	|-RVA: 0x2FFB150 Offset: 0x2FFB251 VA: 0x2FFB150
	|-ReusablePromise<float>.ForceSetResult
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9A70 Offset: 0x2FF9B71 VA: 0x2FF9A70
	|-ReusablePromise<AsyncUnit>.GetResult
	|
	|-RVA: 0x2FFA210 Offset: 0x2FFA311 VA: 0x2FFA210
	|-ReusablePromise<int>.GetResult
	|
	|-RVA: 0x2FFA9B0 Offset: 0x2FFAAB1 VA: 0x2FFA9B0
	|-ReusablePromise<object>.GetResult
	|
	|-RVA: 0x2FFB160 Offset: 0x2FFB261 VA: 0x2FFB160
	|-ReusablePromise<float>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9B80 Offset: 0x2FF9C81 VA: 0x2FF9B80
	|-ReusablePromise<AsyncUnit>.get_Status
	|
	|-RVA: 0x2FFA320 Offset: 0x2FFA421 VA: 0x2FFA320
	|-ReusablePromise<int>.get_Status
	|
	|-RVA: 0x2FFAAC0 Offset: 0x2FFABC1 VA: 0x2FFAAC0
	|-ReusablePromise<object>.get_Status
	|
	|-RVA: 0x2FFB270 Offset: 0x2FFB371 VA: 0x2FFB270
	|-ReusablePromise<float>.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9B90 Offset: 0x2FF9C91 VA: 0x2FF9B90
	|-ReusablePromise<AsyncUnit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2FFA330 Offset: 0x2FFA431 VA: 0x2FFA330
	|-ReusablePromise<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2FFAAD0 Offset: 0x2FFABD1 VA: 0x2FFAAD0
	|-ReusablePromise<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2FFB280 Offset: 0x2FFB381 VA: 0x2FFB280
	|-ReusablePromise<float>.UniRx.Async.IAwaiter.GetResult
	*/

	// RVA: -1 Offset: -1
	public void ResetStatus(bool forceReset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9BA0 Offset: 0x2FF9CA1 VA: 0x2FF9BA0
	|-ReusablePromise<AsyncUnit>.ResetStatus
	|
	|-RVA: 0x2FFA340 Offset: 0x2FFA441 VA: 0x2FFA340
	|-ReusablePromise<int>.ResetStatus
	|
	|-RVA: 0x2FFAAE0 Offset: 0x2FFABE1 VA: 0x2FFAAE0
	|-ReusablePromise<object>.ResetStatus
	|
	|-RVA: 0x2FFB290 Offset: 0x2FFB391 VA: 0x2FFB290
	|-ReusablePromise<float>.ResetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9BC0 Offset: 0x2FF9CC1 VA: 0x2FF9BC0
	|-ReusablePromise<AsyncUnit>.TrySetCanceled
	|
	|-RVA: 0x2FFA360 Offset: 0x2FFA461 VA: 0x2FFA360
	|-ReusablePromise<int>.TrySetCanceled
	|
	|-RVA: 0x2FFAB00 Offset: 0x2FFAC01 VA: 0x2FFAB00
	|-ReusablePromise<object>.TrySetCanceled
	|
	|-RVA: 0x2FFB2B0 Offset: 0x2FFB3B1 VA: 0x2FFB2B0
	|-ReusablePromise<float>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool TrySetException(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9C10 Offset: 0x2FF9D11 VA: 0x2FF9C10
	|-ReusablePromise<AsyncUnit>.TrySetException
	|
	|-RVA: 0x2FFA3B0 Offset: 0x2FFA4B1 VA: 0x2FFA3B0
	|-ReusablePromise<int>.TrySetException
	|
	|-RVA: 0x2FFAB50 Offset: 0x2FFAC51 VA: 0x2FFAB50
	|-ReusablePromise<object>.TrySetException
	|
	|-RVA: 0x2FFB300 Offset: 0x2FFB401 VA: 0x2FFB300
	|-ReusablePromise<float>.TrySetException
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool TrySetResult(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9C90 Offset: 0x2FF9D91 VA: 0x2FF9C90
	|-ReusablePromise<AsyncUnit>.TrySetResult
	|
	|-RVA: 0x2FFA430 Offset: 0x2FFA531 VA: 0x2FFA430
	|-ReusablePromise<int>.TrySetResult
	|
	|-RVA: 0x2FFABD0 Offset: 0x2FFACD1 VA: 0x2FFABD0
	|-ReusablePromise<object>.TrySetResult
	|
	|-RVA: 0x2FFB380 Offset: 0x2FFB481 VA: 0x2FFB380
	|-ReusablePromise<float>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	protected void TryInvokeContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9CF0 Offset: 0x2FF9DF1 VA: 0x2FF9CF0
	|-ReusablePromise<AsyncUnit>.TryInvokeContinuation
	|
	|-RVA: 0x2FFA490 Offset: 0x2FFA591 VA: 0x2FFA490
	|-ReusablePromise<int>.TryInvokeContinuation
	|
	|-RVA: 0x2FFAC40 Offset: 0x2FFAD41 VA: 0x2FFAC40
	|-ReusablePromise<object>.TryInvokeContinuation
	|
	|-RVA: 0x2FFB3E0 Offset: 0x2FFB4E1 VA: 0x2FFB3E0
	|-ReusablePromise<float>.TryInvokeContinuation
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void OnCompleted(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9EB0 Offset: 0x2FF9FB1 VA: 0x2FF9EB0
	|-ReusablePromise<AsyncUnit>.OnCompleted
	|
	|-RVA: 0x2FFA650 Offset: 0x2FFA751 VA: 0x2FFA650
	|-ReusablePromise<int>.OnCompleted
	|
	|-RVA: 0x2FFAE00 Offset: 0x2FFAF01 VA: 0x2FFAE00
	|-ReusablePromise<object>.OnCompleted
	|
	|-RVA: 0x2FFB5A0 Offset: 0x2FFB6A1 VA: 0x2FFB5A0
	|-ReusablePromise<float>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void UnsafeOnCompleted(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9ED0 Offset: 0x2FF9FD1 VA: 0x2FF9ED0
	|-ReusablePromise<AsyncUnit>.UnsafeOnCompleted
	|
	|-RVA: 0x2FFA670 Offset: 0x2FFA771 VA: 0x2FFA670
	|-ReusablePromise<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2FFAE20 Offset: 0x2FFAF21 VA: 0x2FFAE20
	|-ReusablePromise<object>.UnsafeOnCompleted
	|
	|-RVA: 0x2FFB5C0 Offset: 0x2FFB6C1 VA: 0x2FFB5C0
	|-ReusablePromise<float>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFA190 Offset: 0x2FFA291 VA: 0x2FFA190
	|-ReusablePromise<AsyncUnit>..ctor
	|
	|-RVA: 0x2FFA930 Offset: 0x2FFAA31 VA: 0x2FFA930
	|-ReusablePromise<int>..ctor
	|
	|-RVA: 0x2FFB0E0 Offset: 0x2FFB1E1 VA: 0x2FFB0E0
	|-ReusablePromise<object>..ctor
	|
	|-RVA: 0x2FFB880 Offset: 0x2FFB981 VA: 0x2FFB880
	|-ReusablePromise<float>..ctor
	*/
}

