// Namespace: 
private class LastObservable.Last<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6984
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
	|-RVA: 0x289E640 Offset: 0x289E741 VA: 0x289E640
	|-LastObservable.Last<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E6A0 Offset: 0x289E7A1 VA: 0x289E6A0
	|-LastObservable.Last<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E6B0 Offset: 0x289E7B1 VA: 0x289E6B0
	|-LastObservable.Last<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E7F0 Offset: 0x289E8F1 VA: 0x289E7F0
	|-LastObservable.Last<object>.OnCompleted
	*/
}

