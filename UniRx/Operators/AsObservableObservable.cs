// Namespace: UniRx.Operators
internal class AsObservableObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6865
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D1550 Offset: 0x32D1651 VA: 0x32D1550
	|-AsObservableObservable<bool>..ctor
	|
	|-RVA: 0x32D16B0 Offset: 0x32D17B1 VA: 0x32D16B0
	|-AsObservableObservable<object>..ctor
	|
	|-RVA: 0x32D1810 Offset: 0x32D1911 VA: 0x32D1810
	|-AsObservableObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D15C0 Offset: 0x32D16C1 VA: 0x32D15C0
	|-AsObservableObservable<bool>.SubscribeCore
	|
	|-RVA: 0x32D1720 Offset: 0x32D1821 VA: 0x32D1720
	|-AsObservableObservable<object>.SubscribeCore
	|
	|-RVA: 0x32D1880 Offset: 0x32D1981 VA: 0x32D1880
	|-AsObservableObservable<Unit>.SubscribeCore
	*/
}

