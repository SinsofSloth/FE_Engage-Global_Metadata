// Namespace: UniRx.Operators
internal class FrameTimeIntervalObservable<T> : OperatorObservableBase<TimeInterval<T>> // TypeDefIndex: 7211
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly bool ignoreTimeScale; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, bool ignoreTimeScale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF4E0 Offset: 0x33DF5E1 VA: 0x33DF4E0
	|-FrameTimeIntervalObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TimeInterval<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF560 Offset: 0x33DF661 VA: 0x33DF560
	|-FrameTimeIntervalObservable<object>.SubscribeCore
	*/
}

