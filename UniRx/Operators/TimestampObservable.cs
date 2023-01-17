// Namespace: UniRx.Operators
internal class TimestampObservable<T> : OperatorObservableBase<Timestamped<T>> // TypeDefIndex: 7117
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356D700 Offset: 0x356D801 VA: 0x356D700
	|-TimestampObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Timestamped<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356D800 Offset: 0x356D901 VA: 0x356D800
	|-TimestampObservable<object>.SubscribeCore
	*/
}

