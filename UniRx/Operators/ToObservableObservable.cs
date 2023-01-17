// Namespace: UniRx.Operators
internal class ToObservableObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7124
{
	// Fields
	private readonly IEnumerable<T> source; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FA60 Offset: 0x356FB61 VA: 0x356FA60
	|-ToObservableObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FB20 Offset: 0x356FC21 VA: 0x356FB20
	|-ToObservableObservable<object>.SubscribeCore
	*/
}

