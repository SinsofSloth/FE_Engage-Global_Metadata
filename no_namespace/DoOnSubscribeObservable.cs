// Namespace: 
private class DoOnSubscribeObservable.DoOnSubscribe<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6954
{
	// Fields
	private readonly DoOnSubscribeObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoOnSubscribeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635700 Offset: 0x2635801 VA: 0x2635700
	|-DoOnSubscribeObservable.DoOnSubscribe<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635750 Offset: 0x2635851 VA: 0x2635750
	|-DoOnSubscribeObservable.DoOnSubscribe<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26359F0 Offset: 0x2635AF1 VA: 0x26359F0
	|-DoOnSubscribeObservable.DoOnSubscribe<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635AA0 Offset: 0x2635BA1 VA: 0x2635AA0
	|-DoOnSubscribeObservable.DoOnSubscribe<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635BE0 Offset: 0x2635CE1 VA: 0x2635BE0
	|-DoOnSubscribeObservable.DoOnSubscribe<object>.OnCompleted
	*/
}

