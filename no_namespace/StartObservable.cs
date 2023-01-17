// Namespace: 
private class StartObservable.StartObserver<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7072
{
	// Fields
	private readonly StartObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(StartObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C2750 Offset: 0x36C2851 VA: 0x36C2750
	|-StartObservable.StartObserver<object>..ctor
	|
	|-RVA: 0x36C2E60 Offset: 0x36C2F61 VA: 0x36C2E60
	|-StartObservable.StartObserver<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C27A0 Offset: 0x36C28A1 VA: 0x36C27A0
	|-StartObservable.StartObserver<object>.Run
	|
	|-RVA: 0x36C2EB0 Offset: 0x36C2FB1 VA: 0x36C2EB0
	|-StartObservable.StartObserver<Unit>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C2A90 Offset: 0x36C2B91 VA: 0x36C2A90
	|-StartObservable.StartObserver<object>.OnNext
	|
	|-RVA: 0x36C31A0 Offset: 0x36C32A1 VA: 0x36C31A0
	|-StartObservable.StartObserver<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C2BF0 Offset: 0x36C2CF1 VA: 0x36C2BF0
	|-StartObservable.StartObserver<object>.OnError
	|
	|-RVA: 0x36C3300 Offset: 0x36C3401 VA: 0x36C3300
	|-StartObservable.StartObserver<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C2D30 Offset: 0x36C2E31 VA: 0x36C2D30
	|-StartObservable.StartObserver<object>.OnCompleted
	|
	|-RVA: 0x36C3440 Offset: 0x36C3541 VA: 0x36C3440
	|-StartObservable.StartObserver<Unit>.OnCompleted
	*/
}

