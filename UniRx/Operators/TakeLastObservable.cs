// Namespace: UniRx.Operators
internal class TakeLastObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7089
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly int count; // 0x0
	private readonly TimeSpan duration; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B9F50 Offset: 0x34BA051 VA: 0x34B9F50
	|-TakeLastObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan duration, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B9FD0 Offset: 0x34BA0D1 VA: 0x34B9FD0
	|-TakeLastObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BA0E0 Offset: 0x34BA1E1 VA: 0x34BA0E0
	|-TakeLastObservable<object>.SubscribeCore
	*/
}

