// Namespace: UniRx.Operators
internal class BatchFrameObservable : OperatorObservableBase<Unit> // TypeDefIndex: 7201
{
	// Fields
	private readonly IObservable<Unit> source; // 0x18
	private readonly int frameCount; // 0x20
	private readonly FrameCountType frameCountType; // 0x24

	// Methods

	// RVA: 0x19CD700 Offset: 0x19CD801 VA: 0x19CD700
	public void .ctor(IObservable<Unit> source, int frameCount, FrameCountType frameCountType) { }

	// RVA: 0x19CD7B0 Offset: 0x19CD8B1 VA: 0x19CD7B0 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
}

