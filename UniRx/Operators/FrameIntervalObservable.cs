// Namespace: UniRx.Operators
internal class FrameIntervalObservable<T> : OperatorObservableBase<FrameInterval<T>> // TypeDefIndex: 7209
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEA30 Offset: 0x33DEB31 VA: 0x33DEA30
	|-FrameIntervalObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<FrameInterval<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEAA0 Offset: 0x33DEBA1 VA: 0x33DEAA0
	|-FrameIntervalObservable<object>.SubscribeCore
	*/
}

