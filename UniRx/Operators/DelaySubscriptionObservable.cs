// Namespace: UniRx.Operators
internal class DelaySubscriptionObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6933
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IScheduler scheduler; // 0x0
	private readonly Nullable<TimeSpan> dueTimeT; // 0x0
	private readonly Nullable<DateTimeOffset> dueTimeD; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2513A30 Offset: 0x2513B31 VA: 0x2513A30
	|-DelaySubscriptionObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2513B60 Offset: 0x2513C61 VA: 0x2513B60
	|-DelaySubscriptionObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2513CA0 Offset: 0x2513DA1 VA: 0x2513CA0
	|-DelaySubscriptionObservable<object>.SubscribeCore
	*/
}

