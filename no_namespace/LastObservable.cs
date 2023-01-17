// Namespace: 
private class LastObservable.Last_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6985
{
	// Fields
	private readonly LastObservable<T> parent; // 0x0
	private bool notPublished; // 0x0
	private T lastValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(LastObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289EFC0 Offset: 0x289F0C1 VA: 0x289EFC0
	|-LastObservable.Last_<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F020 Offset: 0x289F121 VA: 0x289F020
	|-LastObservable.Last_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F210 Offset: 0x289F311 VA: 0x289F210
	|-LastObservable.Last_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F350 Offset: 0x289F451 VA: 0x289F350
	|-LastObservable.Last_<object>.OnCompleted
	*/
}

