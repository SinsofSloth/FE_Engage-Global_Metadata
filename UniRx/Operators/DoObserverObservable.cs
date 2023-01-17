// Namespace: UniRx.Operators
internal class DoObserverObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6947
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IObserver<T> observer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634290 Offset: 0x2634391 VA: 0x2634290
	|-DoObserverObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634310 Offset: 0x2634411 VA: 0x2634310
	|-DoObserverObservable<object>.SubscribeCore
	*/
}

