// Namespace: UniRx.Operators
internal class AsUnitObservableObservable<T> : OperatorObservableBase<Unit> // TypeDefIndex: 6869
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2290 Offset: 0x32D2391 VA: 0x32D2290
	|-AsUnitObservableObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2320 Offset: 0x32D2421 VA: 0x32D2320
	|-AsUnitObservableObservable<object>.SubscribeCore
	*/
}

