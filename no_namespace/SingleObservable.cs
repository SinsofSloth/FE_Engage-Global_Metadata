// Namespace: 
private class SingleObservable.Single_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7060
{
	// Fields
	private readonly SingleObservable<T> parent; // 0x0
	private bool seenValue; // 0x0
	private T lastValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SingleObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34372C0 Offset: 0x34373C1 VA: 0x34372C0
	|-SingleObservable.Single_<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437320 Offset: 0x3437421 VA: 0x3437320
	|-SingleObservable.Single_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437670 Offset: 0x3437771 VA: 0x3437670
	|-SingleObservable.Single_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34377B0 Offset: 0x34378B1 VA: 0x34377B0
	|-SingleObservable.Single_<object>.OnCompleted
	*/
}

