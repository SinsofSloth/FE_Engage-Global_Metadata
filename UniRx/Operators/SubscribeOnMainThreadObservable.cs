// Namespace: UniRx.Operators
internal class SubscribeOnMainThreadObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7223
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IObservable<long> subscribeTrigger; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IObservable<long> subscribeTrigger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E3EC0 Offset: 0x36E3FC1 VA: 0x36E3EC0
	|-SubscribeOnMainThreadObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E3F40 Offset: 0x36E4041 VA: 0x36E3F40
	|-SubscribeOnMainThreadObservable<object>.SubscribeCore
	*/
}

