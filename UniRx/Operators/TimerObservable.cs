// Namespace: UniRx.Operators
internal class TimerObservable : OperatorObservableBase<long> // TypeDefIndex: 7115
{
	// Fields
	private readonly Nullable<DateTimeOffset> dueTimeA; // 0x18
	private readonly Nullable<TimeSpan> dueTimeB; // 0x30
	private readonly Nullable<TimeSpan> period; // 0x40
	private readonly IScheduler scheduler; // 0x50

	// Methods

	// RVA: 0x1AF9620 Offset: 0x1AF9721 VA: 0x1AF9620
	public void .ctor(DateTimeOffset dueTime, Nullable<TimeSpan> period, IScheduler scheduler) { }

	// RVA: 0x1AF9740 Offset: 0x1AF9841 VA: 0x1AF9740
	public void .ctor(TimeSpan dueTime, Nullable<TimeSpan> period, IScheduler scheduler) { }

	// RVA: 0x1AF9850 Offset: 0x1AF9951 VA: 0x1AF9850 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<long> observer, IDisposable cancel) { }
}

