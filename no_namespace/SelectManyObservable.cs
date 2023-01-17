// Namespace: 
private class SelectManyObservable.SelectManyEnumerableObserverWithIndex<TSource, TCollection, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 7055
{
	// Fields
	private readonly SelectManyObservable<TSource, TCollection, TResult> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable<TSource, TCollection, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300A3C0 Offset: 0x300A4C1 VA: 0x300A3C0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, long, object>..ctor
	|
	|-RVA: 0x300AE20 Offset: 0x300AF21 VA: 0x300AE20
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object, object>..ctor
	|
	|-RVA: 0x300B880 Offset: 0x300B981 VA: 0x300B880
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300A410 Offset: 0x300A511 VA: 0x300A410
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, long, object>.Run
	|
	|-RVA: 0x300AE70 Offset: 0x300AF71 VA: 0x300AE70
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object, object>.Run
	|
	|-RVA: 0x300B8D0 Offset: 0x300B9D1 VA: 0x300B8D0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300A4B0 Offset: 0x300A5B1 VA: 0x300A4B0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, long, object>.OnNext
	|
	|-RVA: 0x300AF10 Offset: 0x300B011 VA: 0x300AF10
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object, object>.OnNext
	|
	|-RVA: 0x300B970 Offset: 0x300BA71 VA: 0x300B970
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300ABB0 Offset: 0x300ACB1 VA: 0x300ABB0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, long, object>.OnError
	|
	|-RVA: 0x300B610 Offset: 0x300B711 VA: 0x300B610
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object, object>.OnError
	|
	|-RVA: 0x300C070 Offset: 0x300C171 VA: 0x300C070
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300ACF0 Offset: 0x300ADF1 VA: 0x300ACF0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, long, object>.OnCompleted
	|
	|-RVA: 0x300B750 Offset: 0x300B851 VA: 0x300B750
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object, object>.OnCompleted
	|
	|-RVA: 0x300C1B0 Offset: 0x300C2B1 VA: 0x300C1B0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit, object>.OnCompleted
	*/
}

