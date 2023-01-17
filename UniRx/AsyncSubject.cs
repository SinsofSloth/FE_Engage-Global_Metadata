// Namespace: UniRx
public sealed class AsyncSubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IOptimizedObservable<T>, IDisposable, INotifyCompletion // TypeDefIndex: 6635
{
	// Fields
	private object observerLock; // 0x0
	private T lastValue; // 0x0
	private bool hasValue; // 0x0
	private bool isStopped; // 0x0
	private bool isDisposed; // 0x0
	private Exception lastError; // 0x0
	private IObserver<T> outObserver; // 0x0

	// Properties
	public T Value { get; }
	public bool HasObservers { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E6EA0 Offset: 0x32E6FA1 VA: 0x32E6EA0
	|-AsyncSubject<object>.get_Value
	|
	|-RVA: 0x2F45C20 Offset: 0x2F45D21 VA: 0x2F45C20
	|-AsyncSubject<Unit>.get_Value
	*/

	// RVA: -1 Offset: -1
	public bool get_HasObservers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E6F40 Offset: 0x32E7041 VA: 0x32E6F40
	|-AsyncSubject<object>.get_HasObservers
	|
	|-RVA: 0x2F45CC0 Offset: 0x2F45DC1 VA: 0x2F45CC0
	|-AsyncSubject<Unit>.get_HasObservers
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E6FC0 Offset: 0x32E70C1 VA: 0x32E6FC0
	|-AsyncSubject<object>.get_IsCompleted
	|
	|-RVA: 0x2F45D40 Offset: 0x2F45E41 VA: 0x2F45D40
	|-AsyncSubject<Unit>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E6FD0 Offset: 0x32E70D1 VA: 0x32E6FD0
	|-AsyncSubject<object>.OnCompleted
	|
	|-RVA: 0x2F45D50 Offset: 0x2F45E51 VA: 0x2F45D50
	|-AsyncSubject<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7300 Offset: 0x32E7401 VA: 0x32E7300
	|-AsyncSubject<object>.OnError
	|
	|-RVA: 0x2F46080 Offset: 0x2F46181 VA: 0x2F46080
	|-AsyncSubject<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E75D0 Offset: 0x32E76D1 VA: 0x32E75D0
	|-AsyncSubject<object>.OnNext
	|
	|-RVA: 0x2F46350 Offset: 0x2F46451 VA: 0x2F46350
	|-AsyncSubject<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7700 Offset: 0x32E7801 VA: 0x32E7700
	|-AsyncSubject<object>.Subscribe
	|
	|-RVA: 0x2F46470 Offset: 0x2F46571 VA: 0x2F46470
	|-AsyncSubject<Unit>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7D20 Offset: 0x32E7E21 VA: 0x32E7D20
	|-AsyncSubject<object>.Dispose
	|
	|-RVA: 0x2F46A90 Offset: 0x2F46B91 VA: 0x2F46A90
	|-AsyncSubject<Unit>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7EB0 Offset: 0x32E7FB1 VA: 0x32E7EB0
	|-AsyncSubject<object>.ThrowIfDisposed
	|
	|-RVA: 0x2F46C20 Offset: 0x2F46D21 VA: 0x2F46C20
	|-AsyncSubject<Unit>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7F20 Offset: 0x32E8021 VA: 0x32E7F20
	|-AsyncSubject<object>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x2F46C90 Offset: 0x2F46D91 VA: 0x2F46C90
	|-AsyncSubject<Unit>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1
	public AsyncSubject<T> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7F30 Offset: 0x32E8031 VA: 0x32E7F30
	|-AsyncSubject<object>.GetAwaiter
	|
	|-RVA: 0x2F46CA0 Offset: 0x2F46DA1 VA: 0x2F46CA0
	|-AsyncSubject<Unit>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7F40 Offset: 0x32E8041 VA: 0x32E7F40
	|-AsyncSubject<object>.OnCompleted
	|
	|-RVA: 0x2F46CB0 Offset: 0x2F46DB1 VA: 0x2F46CB0
	|-AsyncSubject<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private void OnCompleted(Action continuation, bool originalContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E7FC0 Offset: 0x32E80C1 VA: 0x32E7FC0
	|-AsyncSubject<object>.OnCompleted
	|
	|-RVA: 0x2F46D30 Offset: 0x2F46E31 VA: 0x2F46D30
	|-AsyncSubject<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E8060 Offset: 0x32E8161 VA: 0x32E8060
	|-AsyncSubject<object>.GetResult
	|
	|-RVA: 0x2F46DD0 Offset: 0x2F46ED1 VA: 0x2F46DD0
	|-AsyncSubject<Unit>.GetResult
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E8210 Offset: 0x32E8311 VA: 0x32E8210
	|-AsyncSubject<object>..ctor
	|
	|-RVA: 0x2F46F80 Offset: 0x2F47081 VA: 0x2F46F80
	|-AsyncSubject<Unit>..ctor
	*/
}

