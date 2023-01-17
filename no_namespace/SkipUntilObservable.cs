// Namespace: 
private class SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<T, TOther> : IObserver<T> // TypeDefIndex: 7065
{
	// Fields
	public IObserver<T> observer; // 0x0
	private readonly SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent; // 0x0
	private readonly IDisposable subscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent, IDisposable subscription) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34416F0 Offset: 0x34417F1 VA: 0x34416F0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<object, object>..ctor
	|
	|-RVA: 0x3441B80 Offset: 0x3441C81 VA: 0x3441B80
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34417F0 Offset: 0x34418F1 VA: 0x34417F0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<object, object>.OnNext
	|
	|-RVA: 0x3441C80 Offset: 0x3441D81 VA: 0x3441C80
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34418A0 Offset: 0x34419A1 VA: 0x34418A0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<object, object>.OnError
	|
	|-RVA: 0x3441D30 Offset: 0x3441E31 VA: 0x3441D30
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34419E0 Offset: 0x3441AE1 VA: 0x34419E0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<object, object>.OnCompleted
	|
	|-RVA: 0x3441E70 Offset: 0x3441F71 VA: 0x3441E70
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<Unit, object>.OnCompleted
	*/
}

// Namespace: 
private class SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<T, TOther> : IObserver<TOther> // TypeDefIndex: 7066
{
	// Fields
	private readonly SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent; // 0x0
	private readonly SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<T, TOther> sourceObserver; // 0x0
	private readonly IDisposable subscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipUntilObservable.SkipUntilOuterObserver<T, TOther> parent, SkipUntilObservable.SkipUntilOuterObserver.SkipUntil<T, TOther> sourceObserver, IDisposable subscription) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34422B0 Offset: 0x34423B1 VA: 0x34422B0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<object, object>..ctor
	|
	|-RVA: 0x34425E0 Offset: 0x34426E1 VA: 0x34425E0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TOther value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442320 Offset: 0x3442421 VA: 0x3442320
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<object, object>.OnNext
	|
	|-RVA: 0x3442650 Offset: 0x3442751 VA: 0x3442650
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34423F0 Offset: 0x34424F1 VA: 0x34423F0
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<object, object>.OnError
	|
	|-RVA: 0x3442720 Offset: 0x3442821 VA: 0x3442720
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442530 Offset: 0x3442631 VA: 0x3442530
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<object, object>.OnCompleted
	|
	|-RVA: 0x3442860 Offset: 0x3442961 VA: 0x3442860
	|-SkipUntilObservable.SkipUntilOuterObserver.SkipUntilOther<Unit, object>.OnCompleted
	*/
}

// Namespace: 
private class SkipUntilObservable.SkipUntilOuterObserver<T, TOther> : OperatorObserverBase<T, T> // TypeDefIndex: 7067
{
	// Fields
	private readonly SkipUntilObservable<T, TOther> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipUntilObservable<T, TOther> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442910 Offset: 0x3442A11 VA: 0x3442910
	|-SkipUntilObservable.SkipUntilOuterObserver<object, object>..ctor
	|
	|-RVA: 0x3442BD0 Offset: 0x3442CD1 VA: 0x3442BD0
	|-SkipUntilObservable.SkipUntilOuterObserver<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442960 Offset: 0x3442A61 VA: 0x3442960
	|-SkipUntilObservable.SkipUntilOuterObserver<object, object>.Run
	|
	|-RVA: 0x3442C20 Offset: 0x3442D21 VA: 0x3442C20
	|-SkipUntilObservable.SkipUntilOuterObserver<Unit, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442BA0 Offset: 0x3442CA1 VA: 0x3442BA0
	|-SkipUntilObservable.SkipUntilOuterObserver<object, object>.OnNext
	|
	|-RVA: 0x3442E60 Offset: 0x3442F61 VA: 0x3442E60
	|-SkipUntilObservable.SkipUntilOuterObserver<Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442BB0 Offset: 0x3442CB1 VA: 0x3442BB0
	|-SkipUntilObservable.SkipUntilOuterObserver<object, object>.OnError
	|
	|-RVA: 0x3442E70 Offset: 0x3442F71 VA: 0x3442E70
	|-SkipUntilObservable.SkipUntilOuterObserver<Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442BC0 Offset: 0x3442CC1 VA: 0x3442BC0
	|-SkipUntilObservable.SkipUntilOuterObserver<object, object>.OnCompleted
	|
	|-RVA: 0x3442E80 Offset: 0x3442F81 VA: 0x3442E80
	|-SkipUntilObservable.SkipUntilOuterObserver<Unit, object>.OnCompleted
	*/
}

