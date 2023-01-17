// Namespace: UniRx.Operators
internal class DoOnCancelObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6957
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action onCancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action onCancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26348A0 Offset: 0x26349A1 VA: 0x26348A0
	|-DoOnCancelObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634920 Offset: 0x2634A21 VA: 0x2634920
	|-DoOnCancelObservable<object>.SubscribeCore
	*/
}

