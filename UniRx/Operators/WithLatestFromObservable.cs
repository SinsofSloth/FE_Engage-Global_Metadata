// Namespace: UniRx.Operators
internal class WithLatestFromObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7145
{
	// Fields
	private readonly IObservable<TLeft> left; // 0x0
	private readonly IObservable<TRight> right; // 0x0
	private readonly Func<TLeft, TRight, TResult> selector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE480 Offset: 0x39DE581 VA: 0x39DE480
	|-WithLatestFromObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE540 Offset: 0x39DE641 VA: 0x39DE540
	|-WithLatestFromObservable<object, object, object>.SubscribeCore
	*/
}

