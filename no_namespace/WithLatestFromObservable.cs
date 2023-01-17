// Namespace: 
private class WithLatestFromObservable.WithLatestFrom.LeftObserver<TLeft, TRight, TResult> : IObserver<TLeft> // TypeDefIndex: 7142
{
	// Fields
	private readonly WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4A10 Offset: 0x2AD4B11 VA: 0x2AD4A10
	|-WithLatestFromObservable.WithLatestFrom.LeftObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TLeft value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4A50 Offset: 0x2AD4B51 VA: 0x2AD4A50
	|-WithLatestFromObservable.WithLatestFrom.LeftObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4CA0 Offset: 0x2AD4DA1 VA: 0x2AD4CA0
	|-WithLatestFromObservable.WithLatestFrom.LeftObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4D90 Offset: 0x2AD4E91 VA: 0x2AD4D90
	|-WithLatestFromObservable.WithLatestFrom.LeftObserver<object, object, object>.OnCompleted
	*/
}

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

// Namespace: 
private class WithLatestFromObservable.WithLatestFrom<TLeft, TRight, TResult> : OperatorObserverBase<TResult, TResult> // TypeDefIndex: 7144
{
	// Fields
	private readonly WithLatestFromObservable<TLeft, TRight, TResult> parent; // 0x0
	private readonly object gate; // 0x0
	private bool hasLatest; // 0x0
	private TRight latestValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WithLatestFromObservable<TLeft, TRight, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DDE90 Offset: 0x39DDF91 VA: 0x39DDE90
	|-WithLatestFromObservable.WithLatestFrom<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DDF50 Offset: 0x39DE051 VA: 0x39DDF50
	|-WithLatestFromObservable.WithLatestFrom<object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TResult value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE160 Offset: 0x39DE261 VA: 0x39DE160
	|-WithLatestFromObservable.WithLatestFrom<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE210 Offset: 0x39DE311 VA: 0x39DE210
	|-WithLatestFromObservable.WithLatestFrom<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE350 Offset: 0x39DE451 VA: 0x39DE350
	|-WithLatestFromObservable.WithLatestFrom<object, object, object>.OnCompleted
	*/
}

