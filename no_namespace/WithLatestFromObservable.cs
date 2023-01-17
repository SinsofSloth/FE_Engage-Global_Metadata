// Namespace: 
private class WithLatestFromObservable.WithLatestFrom.RightObserver<TLeft, TRight, TResult> : IObserver<TRight> // TypeDefIndex: 7143
{
	// Fields
	private readonly WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent; // 0x0
	private readonly IDisposable selfSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent, IDisposable subscription) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFBEF0 Offset: 0x2FFBFF1 VA: 0x2FFBEF0
	|-WithLatestFromObservable.WithLatestFrom.RightObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TRight value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFBF40 Offset: 0x2FFC041 VA: 0x2FFBF40
	|-WithLatestFromObservable.WithLatestFrom.RightObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFBF80 Offset: 0x2FFC081 VA: 0x2FFBF80
	|-WithLatestFromObservable.WithLatestFrom.RightObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC070 Offset: 0x2FFC171 VA: 0x2FFC070
	|-WithLatestFromObservable.WithLatestFrom.RightObserver<object, object, object>.OnCompleted
	*/
}

