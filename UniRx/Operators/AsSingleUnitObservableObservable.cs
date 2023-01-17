// Namespace: UniRx.Operators
internal class AsSingleUnitObservableObservable<T> : OperatorObservableBase<Unit> // TypeDefIndex: 6867
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D1D20 Offset: 0x32D1E21 VA: 0x32D1D20
	|-AsSingleUnitObservableObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D1DB0 Offset: 0x32D1EB1 VA: 0x32D1DB0
	|-AsSingleUnitObservableObservable<object>.SubscribeCore
	*/
}

