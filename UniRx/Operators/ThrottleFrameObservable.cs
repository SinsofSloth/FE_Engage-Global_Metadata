// Namespace: UniRx.Operators
internal class ThrottleFrameObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7229
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
	|-RVA: 0x399B610 Offset: 0x399B711 VA: 0x399B610
	|-ThrottleFrameObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B6A0 Offset: 0x399B7A1 VA: 0x399B6A0
	|-ThrottleFrameObservable<object>.SubscribeCore
	*/
}

