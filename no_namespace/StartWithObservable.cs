// Namespace: 
private class StartWithObservable.StartWith<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7074
{
	// Fields
	private readonly StartWithObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(StartWithObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C3570 Offset: 0x36C3671 VA: 0x36C3570
	|-StartWithObservable.StartWith<int>..ctor
	|
	|-RVA: 0x36C3BB0 Offset: 0x36C3CB1 VA: 0x36C3BB0
	|-StartWithObservable.StartWith<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C35C0 Offset: 0x36C36C1 VA: 0x36C35C0
	|-StartWithObservable.StartWith<int>.Run
	|
	|-RVA: 0x36C3C00 Offset: 0x36C3D01 VA: 0x36C3C00
	|-StartWithObservable.StartWith<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C3890 Offset: 0x36C3991 VA: 0x36C3890
	|-StartWithObservable.StartWith<int>.OnNext
	|
	|-RVA: 0x36C3ED0 Offset: 0x36C3FD1 VA: 0x36C3ED0
	|-StartWithObservable.StartWith<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C3940 Offset: 0x36C3A41 VA: 0x36C3940
	|-StartWithObservable.StartWith<int>.OnError
	|
	|-RVA: 0x36C3F80 Offset: 0x36C4081 VA: 0x36C3F80
	|-StartWithObservable.StartWith<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C3A80 Offset: 0x36C3B81 VA: 0x36C3A80
	|-StartWithObservable.StartWith<int>.OnCompleted
	|
	|-RVA: 0x36C40C0 Offset: 0x36C41C1 VA: 0x36C40C0
	|-StartWithObservable.StartWith<object>.OnCompleted
	*/
}

