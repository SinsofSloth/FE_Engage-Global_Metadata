// Namespace: UniRx
public class ScheduledNotifier<T> : IObservable<T>, IProgress<T> // TypeDefIndex: 6574
{
	// Fields
	private readonly IScheduler scheduler; // 0x0
	private readonly Subject<T> trigger; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30007D0 Offset: 0x30008D1 VA: 0x30007D0
	|-ScheduledNotifier<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000870 Offset: 0x3000971 VA: 0x3000870
	|-ScheduledNotifier<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Report(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000950 Offset: 0x3000A51 VA: 0x3000950
	|-ScheduledNotifier<object>.Report
	*/

	// RVA: -1 Offset: -1
	public IDisposable Report(T value, TimeSpan dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000AA0 Offset: 0x3000BA1 VA: 0x3000AA0
	|-ScheduledNotifier<object>.Report
	*/

	// RVA: -1 Offset: -1
	public IDisposable Report(T value, DateTimeOffset dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000C00 Offset: 0x3000D01 VA: 0x3000C00
	|-ScheduledNotifier<object>.Report
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000D30 Offset: 0x3000E31 VA: 0x3000D30
	|-ScheduledNotifier<object>.Subscribe
	*/
}

