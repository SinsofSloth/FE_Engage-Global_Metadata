// Namespace: 
private class ContinueWithObservable.ContinueWith<TSource, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 6916
{
	// Fields
	private readonly ContinueWithObservable<TSource, TResult> parent; // 0x0
	private readonly SerialDisposable serialDisposable; // 0x0
	private bool seenValue; // 0x0
	private TSource lastValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ContinueWithObservable<TSource, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250CF90 Offset: 0x250D091 VA: 0x250CF90
	|-ContinueWithObservable.ContinueWith<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D050 Offset: 0x250D151 VA: 0x250D050
	|-ContinueWithObservable.ContinueWith<object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D160 Offset: 0x250D261 VA: 0x250D160
	|-ContinueWithObservable.ContinueWith<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D170 Offset: 0x250D271 VA: 0x250D170
	|-ContinueWithObservable.ContinueWith<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D2B0 Offset: 0x250D3B1 VA: 0x250D2B0
	|-ContinueWithObservable.ContinueWith<object, object>.OnCompleted
	*/
}

