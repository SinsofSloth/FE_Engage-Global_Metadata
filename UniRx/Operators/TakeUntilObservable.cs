// Namespace: UniRx.Operators
internal class TakeUntilObservable<T, TOther> : OperatorObservableBase<T> // TypeDefIndex: 7092
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IObservable<TOther> other; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IObservable<TOther> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BD460 Offset: 0x34BD561 VA: 0x34BD460
	|-TakeUntilObservable<object, object>..ctor
	|
	|-RVA: 0x34BD5B0 Offset: 0x34BD6B1 VA: 0x34BD5B0
	|-TakeUntilObservable<object, Unit>..ctor
	|
	|-RVA: 0x34BD700 Offset: 0x34BD801 VA: 0x34BD700
	|-TakeUntilObservable<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BD510 Offset: 0x34BD611 VA: 0x34BD510
	|-TakeUntilObservable<object, object>.SubscribeCore
	|
	|-RVA: 0x34BD660 Offset: 0x34BD761 VA: 0x34BD660
	|-TakeUntilObservable<object, Unit>.SubscribeCore
	|
	|-RVA: 0x34BD7B0 Offset: 0x34BD8B1 VA: 0x34BD7B0
	|-TakeUntilObservable<Unit, object>.SubscribeCore
	*/
}

