// Namespace: UniRx.Operators
internal class ZipObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7154
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
	|-RVA: 0x3EF8280 Offset: 0x3EF8381 VA: 0x3EF8280
	|-ZipObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8340 Offset: 0x3EF8441 VA: 0x3EF8340
	|-ZipObservable<object, object, object>.SubscribeCore
	*/
}

