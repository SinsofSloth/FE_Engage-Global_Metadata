// Namespace: UniRx.Operators
internal class CombineLatestObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 6896
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
	|-RVA: 0x30E31B0 Offset: 0x30E32B1 VA: 0x30E31B0
	|-CombineLatestObservable<bool, bool, bool>..ctor
	|
	|-RVA: 0x30E3310 Offset: 0x30E3411 VA: 0x30E3310
	|-CombineLatestObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3270 Offset: 0x30E3371 VA: 0x30E3270
	|-CombineLatestObservable<bool, bool, bool>.SubscribeCore
	|
	|-RVA: 0x30E33D0 Offset: 0x30E34D1 VA: 0x30E33D0
	|-CombineLatestObservable<object, object, object>.SubscribeCore
	*/
}

