// Namespace: UniRx.Operators
internal class WhenAllObservable<T> : OperatorObservableBase<T[]> // TypeDefIndex: 7130
{
	// Fields
	private readonly IObservable<T>[] sources; // 0x0
	private readonly IEnumerable<IObservable<T>> sourcesEnumerable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD3C0 Offset: 0x2FDD4C1 VA: 0x2FDD3C0
	|-WhenAllObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD410 Offset: 0x2FDD511 VA: 0x2FDD410
	|-WhenAllObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T[]> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD460 Offset: 0x2FDD561 VA: 0x2FDD460
	|-WhenAllObservable<object>.SubscribeCore
	*/
}

