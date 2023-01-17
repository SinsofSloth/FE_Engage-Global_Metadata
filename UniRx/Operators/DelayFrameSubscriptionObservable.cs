// Namespace: UniRx.Operators
internal class DelayFrameSubscriptionObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7207
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
	|-RVA: 0x2513560 Offset: 0x2513661 VA: 0x2513560
	|-DelayFrameSubscriptionObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25135F0 Offset: 0x25136F1 VA: 0x25135F0
	|-DelayFrameSubscriptionObservable<object>.SubscribeCore
	*/
}

