// Namespace: UniRx.Operators
internal class DematerializeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6935
{
	// Fields
	private readonly IObservable<Notification<T>> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<Notification<T>> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25187E0 Offset: 0x25188E1 VA: 0x25187E0
	|-DematerializeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518850 Offset: 0x2518951 VA: 0x2518850
	|-DematerializeObservable<object>.SubscribeCore
	*/
}

