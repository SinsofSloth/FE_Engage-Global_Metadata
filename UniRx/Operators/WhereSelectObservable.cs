// Namespace: UniRx.Operators
internal class WhereSelectObservable<T, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7141
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Func<T, bool> predicate; // 0x0
	private readonly Func<T, TR> selector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, bool> predicate, Func<T, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DCF30 Offset: 0x39DD031 VA: 0x39DCF30
	|-WhereSelectObservable<bool, bool>..ctor
	|
	|-RVA: 0x39DD0D0 Offset: 0x39DD1D1 VA: 0x39DD0D0
	|-WhereSelectObservable<object, bool>..ctor
	|
	|-RVA: 0x39DD270 Offset: 0x39DD371 VA: 0x39DD270
	|-WhereSelectObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DCFD0 Offset: 0x39DD0D1 VA: 0x39DCFD0
	|-WhereSelectObservable<bool, bool>.SubscribeCore
	|
	|-RVA: 0x39DD170 Offset: 0x39DD271 VA: 0x39DD170
	|-WhereSelectObservable<object, bool>.SubscribeCore
	|
	|-RVA: 0x39DD310 Offset: 0x39DD411 VA: 0x39DD310
	|-WhereSelectObservable<object, object>.SubscribeCore
	*/
}

