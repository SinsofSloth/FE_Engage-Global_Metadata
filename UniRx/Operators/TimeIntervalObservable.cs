// Namespace: UniRx.Operators
internal class TimeIntervalObservable<T> : OperatorObservableBase<TimeInterval<T>> // TypeDefIndex: 7105
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D150 Offset: 0x399D251 VA: 0x399D150
	|-TimeIntervalObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TimeInterval<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D250 Offset: 0x399D351 VA: 0x399D250
	|-TimeIntervalObservable<object>.SubscribeCore
	*/
}

