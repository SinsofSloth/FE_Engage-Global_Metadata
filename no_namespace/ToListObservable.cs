// Namespace: 
private class ToListObservable.ToList<TSource> : OperatorObserverBase<TSource, IList<TSource>> // TypeDefIndex: 7120
{
	// Fields
	private readonly List<TSource> list; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<IList<TSource>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E8A0 Offset: 0x356E9A1 VA: 0x356E8A0
	|-ToListObservable.ToList<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E940 Offset: 0x356EA41 VA: 0x356E940
	|-ToListObservable.ToList<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356EB10 Offset: 0x356EC11 VA: 0x356EB10
	|-ToListObservable.ToList<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356EC50 Offset: 0x356ED51 VA: 0x356EC50
	|-ToListObservable.ToList<object>.OnCompleted
	*/
}

