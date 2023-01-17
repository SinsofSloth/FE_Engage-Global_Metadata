// Namespace: UniRx.Operators
internal class TimeoutObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7109
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Nullable<TimeSpan> dueTime; // 0x0
	private readonly Nullable<DateTimeOffset> dueTimeDT; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F0A0 Offset: 0x399F1A1 VA: 0x399F0A0
	|-TimeoutObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F1D0 Offset: 0x399F2D1 VA: 0x399F1D0
	|-TimeoutObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F310 Offset: 0x399F411 VA: 0x399F310
	|-TimeoutObservable<object>.SubscribeCore
	*/
}

