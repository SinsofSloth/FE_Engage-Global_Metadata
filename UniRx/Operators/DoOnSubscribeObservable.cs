// Namespace: UniRx.Operators
internal class DoOnSubscribeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6955
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action onSubscribe; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action onSubscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635D10 Offset: 0x2635E11 VA: 0x2635D10
	|-DoOnSubscribeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635D90 Offset: 0x2635E91 VA: 0x2635D90
	|-DoOnSubscribeObservable<object>.SubscribeCore
	*/
}

