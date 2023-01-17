// Namespace: 
private class CastObservable.Cast<TSource, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 6882
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D0BB0 Offset: 0x30D0CB1 VA: 0x30D0BB0
	|-CastObservable.Cast<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D0BD0 Offset: 0x30D0CD1 VA: 0x30D0BD0
	|-CastObservable.Cast<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D0E50 Offset: 0x30D0F51 VA: 0x30D0E50
	|-CastObservable.Cast<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D0F90 Offset: 0x30D1091 VA: 0x30D0F90
	|-CastObservable.Cast<object, object>.OnCompleted
	*/
}

