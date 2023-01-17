// Namespace: UniRx.Operators
internal class DelayObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6929
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
	|-RVA: 0x2513880 Offset: 0x2513981 VA: 0x2513880
	|-DelayObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2513990 Offset: 0x2513A91 VA: 0x2513990
	|-DelayObservable<object>.SubscribeCore
	*/
}

