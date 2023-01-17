// Namespace: UniRx.Operators
internal class SynchronizeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7082
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly object gate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, object gate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2E20 Offset: 0x34B2F21 VA: 0x34B2E20
	|-SynchronizeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2EA0 Offset: 0x34B2FA1 VA: 0x34B2EA0
	|-SynchronizeObservable<object>.SubscribeCore
	*/
}

