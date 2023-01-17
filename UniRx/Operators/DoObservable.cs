// Namespace: UniRx.Operators
internal class DoObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6945
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action<T> onNext; // 0x0
	private readonly Action<Exception> onError; // 0x0
	private readonly Action onCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634140 Offset: 0x2634241 VA: 0x2634140
	|-DoObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26341F0 Offset: 0x26342F1 VA: 0x26341F0
	|-DoObservable<object>.SubscribeCore
	*/
}

