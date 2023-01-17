// Namespace: UniRx.Operators
internal class ThrottleFirstFrameObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7226
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
	|-RVA: 0x399A930 Offset: 0x399AA31 VA: 0x399A930
	|-ThrottleFirstFrameObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399A9C0 Offset: 0x399AAC1 VA: 0x399A9C0
	|-ThrottleFirstFrameObservable<object>.SubscribeCore
	*/
}

