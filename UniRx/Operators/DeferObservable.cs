// Namespace: UniRx.Operators
internal class DeferObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6927
{
	// Fields
	private readonly Func<IObservable<T>> observableFactory; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<IObservable<T>> observableFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511260 Offset: 0x2511361 VA: 0x2511260
	|-DeferObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25112B0 Offset: 0x25113B1 VA: 0x25112B0
	|-DeferObservable<object>.SubscribeCore
	*/
}

