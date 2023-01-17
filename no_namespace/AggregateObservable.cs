// Namespace: 
private class AggregateObservable.Aggregate<TSource, TAccumulate, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 6857
{
	// Fields
	private readonly AggregateObservable<TSource, TAccumulate, TResult> parent; // 0x0
	private TAccumulate accumulation; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AggregateObservable<TSource, TAccumulate, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5F60 Offset: 0x1FF6061 VA: 0x1FF5F60
	|-AggregateObservable.Aggregate<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5FC0 Offset: 0x1FF60C1 VA: 0x1FF5FC0
	|-AggregateObservable.Aggregate<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF61B0 Offset: 0x1FF62B1 VA: 0x1FF61B0
	|-AggregateObservable.Aggregate<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF62F0 Offset: 0x1FF63F1 VA: 0x1FF62F0
	|-AggregateObservable.Aggregate<object, object, object>.OnCompleted
	*/
}

