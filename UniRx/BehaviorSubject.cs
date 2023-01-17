// Namespace: UniRx
public sealed class BehaviorSubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IDisposable, IOptimizedObservable<T> // TypeDefIndex: 6637
{
	// Fields
	private object observerLock; // 0x0
	private bool isStopped; // 0x0
	private bool isDisposed; // 0x0
	private T lastValue; // 0x0
	private Exception lastError; // 0x0
	private IObserver<T> outObserver; // 0x0

	// Properties
	public T Value { get; }
	public bool HasObservers { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFAFC0 Offset: 0x1DFB0C1 VA: 0x1DFAFC0
	|-BehaviorSubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFB100 Offset: 0x1DFB201 VA: 0x1DFB100
	|-BehaviorSubject<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public bool get_HasObservers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFB150 Offset: 0x1DFB251 VA: 0x1DFB150
	|-BehaviorSubject<object>.get_HasObservers
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFB1D0 Offset: 0x1DFB2D1 VA: 0x1DFB1D0
	|-BehaviorSubject<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFB420 Offset: 0x1DFB521 VA: 0x1DFB420
	|-BehaviorSubject<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFB6F0 Offset: 0x1DFB7F1 VA: 0x1DFB6F0
	|-BehaviorSubject<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFB880 Offset: 0x1DFB981 VA: 0x1DFB880
	|-BehaviorSubject<object>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFBE00 Offset: 0x1DFBF01 VA: 0x1DFBE00
	|-BehaviorSubject<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFBF90 Offset: 0x1DFC091 VA: 0x1DFBF90
	|-BehaviorSubject<object>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFC000 Offset: 0x1DFC101 VA: 0x1DFC000
	|-BehaviorSubject<object>.IsRequiredSubscribeOnCurrentThread
	*/
}

