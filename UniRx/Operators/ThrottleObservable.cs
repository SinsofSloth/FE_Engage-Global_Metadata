// Namespace: UniRx.Operators
internal class ThrottleObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7098
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly TimeSpan dueTime; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B940 Offset: 0x399BA41 VA: 0x399B940
	|-ThrottleObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399BA50 Offset: 0x399BB51 VA: 0x399BA50
	|-ThrottleObservable<object>.SubscribeCore
	*/
}

