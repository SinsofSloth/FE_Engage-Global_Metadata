// Namespace: UniRx.Operators
internal class RefCountObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7015
{
	// Fields
	private readonly IConnectableObservable<T> source; // 0x0
	private readonly object gate; // 0x0
	private int refCount; // 0x0
	private IDisposable connection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IConnectableObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9CA0 Offset: 0x2FE9DA1 VA: 0x2FE9CA0
	|-RefCountObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9D60 Offset: 0x2FE9E61 VA: 0x2FE9D60
	|-RefCountObservable<object>.SubscribeCore
	*/
}

