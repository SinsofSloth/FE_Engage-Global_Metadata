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

