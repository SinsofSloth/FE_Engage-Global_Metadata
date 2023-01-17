// Namespace: UniRx.Operators
internal class ObserveOnObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7000
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710500 Offset: 0x3710601 VA: 0x3710500
	|-ObserveOnObservable<object>..ctor
	|
	|-RVA: 0x37106B0 Offset: 0x37107B1 VA: 0x37106B0
	|-ObserveOnObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710580 Offset: 0x3710681 VA: 0x3710580
	|-ObserveOnObservable<object>.SubscribeCore
	|
	|-RVA: 0x3710730 Offset: 0x3710831 VA: 0x3710730
	|-ObserveOnObservable<Unit>.SubscribeCore
	*/
}

