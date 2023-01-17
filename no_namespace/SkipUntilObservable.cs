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

