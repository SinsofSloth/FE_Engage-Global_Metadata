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

