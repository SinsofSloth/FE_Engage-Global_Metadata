// Namespace: UniRx.Operators
internal class RangeObservable : OperatorObservableBase<int> // TypeDefIndex: 7012
{
	// Fields
	private readonly int start; // 0x14
	private readonly int count; // 0x18
	private readonly IScheduler scheduler; // 0x20

	// Methods

	// RVA: 0x19D76A0 Offset: 0x19D77A1 VA: 0x19D76A0
	public void .ctor(int start, int count, IScheduler scheduler) { }

	// RVA: 0x19ED1B0 Offset: 0x19ED2B1 VA: 0x19ED1B0 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<int> observer, IDisposable cancel) { }
}

