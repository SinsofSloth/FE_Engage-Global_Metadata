// Namespace: UniRx.Operators
internal class SubscribeOnObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7077
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E41D0 Offset: 0x36E42D1 VA: 0x36E41D0
	|-SubscribeOnObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E42D0 Offset: 0x36E43D1 VA: 0x36E42D0
	|-SubscribeOnObservable<object>.SubscribeCore
	*/
}

