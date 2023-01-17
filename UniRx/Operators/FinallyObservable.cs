// Namespace: UniRx.Operators
internal class FinallyObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6962
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action finallyAction; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action finallyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D6BA0 Offset: 0x33D6CA1 VA: 0x33D6BA0
	|-FinallyObservable<long>..ctor
	|
	|-RVA: 0x33D6CC0 Offset: 0x33D6DC1 VA: 0x33D6CC0
	|-FinallyObservable<object>..ctor
	|
	|-RVA: 0x33D6DE0 Offset: 0x33D6EE1 VA: 0x33D6DE0
	|-FinallyObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D6C20 Offset: 0x33D6D21 VA: 0x33D6C20
	|-FinallyObservable<long>.SubscribeCore
	|
	|-RVA: 0x33D6D40 Offset: 0x33D6E41 VA: 0x33D6D40
	|-FinallyObservable<object>.SubscribeCore
	|
	|-RVA: 0x33D6E60 Offset: 0x33D6F61 VA: 0x33D6E60
	|-FinallyObservable<Unit>.SubscribeCore
	*/
}

