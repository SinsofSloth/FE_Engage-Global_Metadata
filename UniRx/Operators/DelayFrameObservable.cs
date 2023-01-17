// Namespace: UniRx.Operators
internal class DelayFrameObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7205
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly int frameCount; // 0x0
	private readonly FrameCountType frameCountType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, int frameCount, FrameCountType frameCountType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2513430 Offset: 0x2513531 VA: 0x2513430
	|-DelayFrameObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25134C0 Offset: 0x25135C1 VA: 0x25134C0
	|-DelayFrameObservable<object>.SubscribeCore
	*/
}

