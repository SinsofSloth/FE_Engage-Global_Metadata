// Namespace: 
private class SkipWhileObservable.SkipWhile<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7069
{
	// Fields
	private readonly SkipWhileObservable<T> parent; // 0x0
	private bool endSkip; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipWhileObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442E90 Offset: 0x3442F91 VA: 0x3442E90
	|-SkipWhileObservable.SkipWhile<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442EE0 Offset: 0x3442FE1 VA: 0x3442EE0
	|-SkipWhileObservable.SkipWhile<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442F80 Offset: 0x3443081 VA: 0x3442F80
	|-SkipWhileObservable.SkipWhile<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443200 Offset: 0x3443301 VA: 0x3443200
	|-SkipWhileObservable.SkipWhile<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443340 Offset: 0x3443441 VA: 0x3443340
	|-SkipWhileObservable.SkipWhile<object>.OnCompleted
	*/
}

// Namespace: 
private class SkipWhileObservable.SkipWhile_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7070
{
	// Fields
	private readonly SkipWhileObservable<T> parent; // 0x0
	private bool endSkip; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipWhileObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443660 Offset: 0x3443761 VA: 0x3443660
	|-SkipWhileObservable.SkipWhile_<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34436B0 Offset: 0x34437B1 VA: 0x34436B0
	|-SkipWhileObservable.SkipWhile_<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443750 Offset: 0x3443851 VA: 0x3443750
	|-SkipWhileObservable.SkipWhile_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34439D0 Offset: 0x3443AD1 VA: 0x34439D0
	|-SkipWhileObservable.SkipWhile_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443B10 Offset: 0x3443C11 VA: 0x3443B10
	|-SkipWhileObservable.SkipWhile_<object>.OnCompleted
	*/
}

