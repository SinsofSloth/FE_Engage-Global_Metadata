// Namespace: UniRx.Operators
internal class RepeatUntilObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7218
{
	// Fields
	private readonly IEnumerable<IObservable<T>> sources; // 0x0
	private readonly IObservable<Unit> trigger; // 0x0
	private readonly GameObject lifeTimeChecker; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<IObservable<T>> sources, IObservable<Unit> trigger, GameObject lifeTimeChecker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6C50 Offset: 0x2FF6D51 VA: 0x2FF6C50
	|-RepeatUntilObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6CD0 Offset: 0x2FF6DD1 VA: 0x2FF6CD0
	|-RepeatUntilObservable<object>.SubscribeCore
	*/
}

