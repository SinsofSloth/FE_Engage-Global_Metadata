// Namespace: 
private class AggregateObservable.Aggregate<TSource> : OperatorObserverBase<TSource, TSource> // TypeDefIndex: 6853
{
	// Fields
	private readonly AggregateObservable<TSource> parent; // 0x0
	private TSource accumulation; // 0x0
	private bool seenValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AggregateObservable<TSource> parent, IObserver<TSource> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5460 Offset: 0x1FF5561 VA: 0x1FF5460
	|-AggregateObservable.Aggregate<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF54C0 Offset: 0x1FF55C1 VA: 0x1FF54C0
	|-AggregateObservable.Aggregate<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF56E0 Offset: 0x1FF57E1 VA: 0x1FF56E0
	|-AggregateObservable.Aggregate<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5820 Offset: 0x1FF5921 VA: 0x1FF5820
	|-AggregateObservable.Aggregate<object>.OnCompleted
	*/
}

// Namespace: 
private class AggregateObservable.Aggregate<TSource, TAccumulate> : OperatorObserverBase<TSource, TAccumulate> // TypeDefIndex: 6855
{
	// Fields
	private readonly AggregateObservable<TSource, TAccumulate> parent; // 0x0
	private TAccumulate accumulation; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AggregateObservable<TSource, TAccumulate> parent, IObserver<TAccumulate> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5A20 Offset: 0x1FF5B21 VA: 0x1FF5A20
	|-AggregateObservable.Aggregate<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5A80 Offset: 0x1FF5B81 VA: 0x1FF5A80
	|-AggregateObservable.Aggregate<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5C70 Offset: 0x1FF5D71 VA: 0x1FF5C70
	|-AggregateObservable.Aggregate<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF5DB0 Offset: 0x1FF5EB1 VA: 0x1FF5DB0
	|-AggregateObservable.Aggregate<object, object>.OnCompleted
	*/
}

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

