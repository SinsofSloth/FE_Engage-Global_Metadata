// Namespace: UniRx.Operators
internal class DoOnErrorObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6949
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action<Exception> onError; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action<Exception> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26355E0 Offset: 0x26356E1 VA: 0x26355E0
	|-DoOnErrorObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635660 Offset: 0x2635761 VA: 0x2635660
	|-DoOnErrorObservable<object>.SubscribeCore
	*/
}

