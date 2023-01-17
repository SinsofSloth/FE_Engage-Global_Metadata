// Namespace: 
private class DistinctUntilChangedObservable.DistinctUntilChanged<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6940
{
	// Fields
	private readonly DistinctUntilChangedObservable<T> parent; // 0x0
	private bool isFirst; // 0x0
	private T prevKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DistinctUntilChangedObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631710 Offset: 0x2631811 VA: 0x2631710
	|-DistinctUntilChangedObservable.DistinctUntilChanged<bool>..ctor
	|
	|-RVA: 0x2631CD0 Offset: 0x2631DD1 VA: 0x2631CD0
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631770 Offset: 0x2631871 VA: 0x2631770
	|-DistinctUntilChangedObservable.DistinctUntilChanged<bool>.OnNext
	|
	|-RVA: 0x2631D30 Offset: 0x2631E31 VA: 0x2631D30
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631A60 Offset: 0x2631B61 VA: 0x2631A60
	|-DistinctUntilChangedObservable.DistinctUntilChanged<bool>.OnError
	|
	|-RVA: 0x2632020 Offset: 0x2632121 VA: 0x2632020
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631BA0 Offset: 0x2631CA1 VA: 0x2631BA0
	|-DistinctUntilChangedObservable.DistinctUntilChanged<bool>.OnCompleted
	|
	|-RVA: 0x2632160 Offset: 0x2632261 VA: 0x2632160
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object>.OnCompleted
	*/
}

// Namespace: 
private class DistinctUntilChangedObservable.DistinctUntilChanged<T, TKey> : OperatorObserverBase<T, T> // TypeDefIndex: 6942
{
	// Fields
	private readonly DistinctUntilChangedObservable<T, TKey> parent; // 0x0
	private bool isFirst; // 0x0
	private TKey prevKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DistinctUntilChangedObservable<T, TKey> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632290 Offset: 0x2632391 VA: 0x2632290
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26322F0 Offset: 0x26323F1 VA: 0x26322F0
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632770 Offset: 0x2632871 VA: 0x2632770
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26328B0 Offset: 0x26329B1 VA: 0x26328B0
	|-DistinctUntilChangedObservable.DistinctUntilChanged<object, object>.OnCompleted
	*/
}

