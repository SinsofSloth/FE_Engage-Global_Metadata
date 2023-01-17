// Namespace: UniRx.Operators
internal class ZipLatestObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7179
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
	|-RVA: 0x3EF6DD0 Offset: 0x3EF6ED1 VA: 0x3EF6DD0
	|-ZipLatestObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF6E90 Offset: 0x3EF6F91 VA: 0x3EF6E90
	|-ZipLatestObservable<object, object, object>.SubscribeCore
	*/
}

