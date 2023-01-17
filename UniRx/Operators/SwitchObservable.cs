// Namespace: UniRx.Operators
internal class SwitchObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7080
{
	// Fields
	private readonly IObservable<IObservable<T>> sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2010 Offset: 0x34B2111 VA: 0x34B2010
	|-SwitchObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2060 Offset: 0x34B2161 VA: 0x34B2060
	|-SwitchObservable<object>.SubscribeCore
	*/
}

