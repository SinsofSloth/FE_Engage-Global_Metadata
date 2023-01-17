// Namespace: 
private class WhereObservable.Where_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7137
{
	// Fields
	private readonly WhereObservable<T> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhereObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD410 Offset: 0x39DD511 VA: 0x39DD410
	|-WhereObservable.Where_<bool>..ctor
	|
	|-RVA: 0x39DD950 Offset: 0x39DDA51 VA: 0x39DD950
	|-WhereObservable.Where_<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD470 Offset: 0x39DD571 VA: 0x39DD470
	|-WhereObservable.Where_<bool>.OnNext
	|
	|-RVA: 0x39DD9B0 Offset: 0x39DDAB1 VA: 0x39DD9B0
	|-WhereObservable.Where_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD6E0 Offset: 0x39DD7E1 VA: 0x39DD6E0
	|-WhereObservable.Where_<bool>.OnError
	|
	|-RVA: 0x39DDC20 Offset: 0x39DDD21 VA: 0x39DDC20
	|-WhereObservable.Where_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD820 Offset: 0x39DD921 VA: 0x39DD820
	|-WhereObservable.Where_<bool>.OnCompleted
	|
	|-RVA: 0x39DDD60 Offset: 0x39DDE61 VA: 0x39DDD60
	|-WhereObservable.Where_<object>.OnCompleted
	*/
}

