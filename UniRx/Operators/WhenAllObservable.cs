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

// Namespace: UniRx.Operators
internal class WhenAllObservable : OperatorObservableBase<Unit> // TypeDefIndex: 7135
{
	// Fields
	private readonly IObservable<Unit>[] sources; // 0x18
	private readonly IEnumerable<IObservable<Unit>> sourcesEnumerable; // 0x20

	// Methods

	// RVA: 0x1AFC550 Offset: 0x1AFC651 VA: 0x1AFC550
	public void .ctor(IObservable<Unit>[] sources) { }

	// RVA: 0x1AFC5C0 Offset: 0x1AFC6C1 VA: 0x1AFC5C0
	public void .ctor(IEnumerable<IObservable<Unit>> sources) { }

	// RVA: 0x1AFC630 Offset: 0x1AFC731 VA: 0x1AFC630 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
}

