// Namespace: 
private class SkipObservable.Skip<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7062
{
	// Fields
	private int remaining; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440F00 Offset: 0x3441001 VA: 0x3440F00
	|-SkipObservable.Skip<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440F50 Offset: 0x3441051 VA: 0x3440F50
	|-SkipObservable.Skip<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3441020 Offset: 0x3441121 VA: 0x3441020
	|-SkipObservable.Skip<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3441160 Offset: 0x3441261 VA: 0x3441160
	|-SkipObservable.Skip<object>.OnCompleted
	*/
}

