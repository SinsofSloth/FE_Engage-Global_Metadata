// Namespace: 
private class TakeWhileObservable.TakeWhile<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7093
{
	// Fields
	private readonly TakeWhileObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeWhileObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BEF30 Offset: 0x34BF031 VA: 0x34BEF30
	|-TakeWhileObservable.TakeWhile<long>..ctor
	|
	|-RVA: 0x34BF5E0 Offset: 0x34BF6E1 VA: 0x34BF5E0
	|-TakeWhileObservable.TakeWhile<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BEF80 Offset: 0x34BF081 VA: 0x34BEF80
	|-TakeWhileObservable.TakeWhile<long>.Run
	|
	|-RVA: 0x34BF630 Offset: 0x34BF731 VA: 0x34BF630
	|-TakeWhileObservable.TakeWhile<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BF020 Offset: 0x34BF121 VA: 0x34BF020
	|-TakeWhileObservable.TakeWhile<long>.OnNext
	|
	|-RVA: 0x34BF6D0 Offset: 0x34BF7D1 VA: 0x34BF6D0
	|-TakeWhileObservable.TakeWhile<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BF370 Offset: 0x34BF471 VA: 0x34BF370
	|-TakeWhileObservable.TakeWhile<long>.OnError
	|
	|-RVA: 0x34BFA20 Offset: 0x34BFB21 VA: 0x34BFA20
	|-TakeWhileObservable.TakeWhile<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BF4B0 Offset: 0x34BF5B1 VA: 0x34BF4B0
	|-TakeWhileObservable.TakeWhile<long>.OnCompleted
	|
	|-RVA: 0x34BFB60 Offset: 0x34BFC61 VA: 0x34BFB60
	|-TakeWhileObservable.TakeWhile<object>.OnCompleted
	*/
}

