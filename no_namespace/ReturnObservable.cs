// Namespace: 
private class ReturnObservable.Return<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7022
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF8720 Offset: 0x2FF8821 VA: 0x2FF8720
	|-ReturnObservable.Return<object>..ctor
	|
	|-RVA: 0x2FF8B10 Offset: 0x2FF8C11 VA: 0x2FF8B10
	|-ReturnObservable.Return<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF8740 Offset: 0x2FF8841 VA: 0x2FF8740
	|-ReturnObservable.Return<object>.OnNext
	|
	|-RVA: 0x2FF8B30 Offset: 0x2FF8C31 VA: 0x2FF8B30
	|-ReturnObservable.Return<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF88A0 Offset: 0x2FF89A1 VA: 0x2FF88A0
	|-ReturnObservable.Return<object>.OnError
	|
	|-RVA: 0x2FF8C90 Offset: 0x2FF8D91 VA: 0x2FF8C90
	|-ReturnObservable.Return<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF89E0 Offset: 0x2FF8AE1 VA: 0x2FF89E0
	|-ReturnObservable.Return<object>.OnCompleted
	|
	|-RVA: 0x2FF8DD0 Offset: 0x2FF8ED1 VA: 0x2FF8DD0
	|-ReturnObservable.Return<Unit>.OnCompleted
	*/
}

