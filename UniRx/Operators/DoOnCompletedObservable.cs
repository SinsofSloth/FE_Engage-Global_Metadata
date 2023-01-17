// Namespace: UniRx.Operators
internal class DoOnCompletedObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6951
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action onCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634F00 Offset: 0x2635001 VA: 0x2634F00
	|-DoOnCompletedObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634F80 Offset: 0x2635081 VA: 0x2634F80
	|-DoOnCompletedObservable<object>.SubscribeCore
	*/
}

