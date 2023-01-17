// Namespace: UniRx.Operators
internal class RepeatSafeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7021
{
	// Fields
	private readonly IEnumerable<IObservable<T>> sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<IObservable<T>> sources, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF55B0 Offset: 0x2FF56B1 VA: 0x2FF55B0
	|-RepeatSafeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5600 Offset: 0x2FF5701 VA: 0x2FF5600
	|-RepeatSafeObservable<object>.SubscribeCore
	*/
}

