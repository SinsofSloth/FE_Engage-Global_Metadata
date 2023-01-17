// Namespace: UniRx.Operators
internal class SelectWhereObservable<T, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7058
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Func<T, TR> selector; // 0x0
	private readonly Func<TR, bool> predicate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, TR> selector, Func<TR, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3430430 Offset: 0x3430531 VA: 0x3430430
	|-SelectWhereObservable<bool, bool>..ctor
	|
	|-RVA: 0x34305D0 Offset: 0x34306D1 VA: 0x34305D0
	|-SelectWhereObservable<object, bool>..ctor
	|
	|-RVA: 0x3430770 Offset: 0x3430871 VA: 0x3430770
	|-SelectWhereObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34304D0 Offset: 0x34305D1 VA: 0x34304D0
	|-SelectWhereObservable<bool, bool>.SubscribeCore
	|
	|-RVA: 0x3430670 Offset: 0x3430771 VA: 0x3430670
	|-SelectWhereObservable<object, bool>.SubscribeCore
	|
	|-RVA: 0x3430810 Offset: 0x3430911 VA: 0x3430810
	|-SelectWhereObservable<object, object>.SubscribeCore
	*/
}

