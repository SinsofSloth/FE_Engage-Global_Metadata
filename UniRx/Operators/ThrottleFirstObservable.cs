// Namespace: UniRx.Operators
internal class ThrottleFirstObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7100
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
	|-RVA: 0x399AB90 Offset: 0x399AC91 VA: 0x399AB90
	|-ThrottleFirstObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399ACA0 Offset: 0x399ADA1 VA: 0x399ACA0
	|-ThrottleFirstObservable<object>.SubscribeCore
	*/
}

