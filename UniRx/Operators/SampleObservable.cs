// Namespace: UniRx.Operators
internal class SampleObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7031
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly TimeSpan interval; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan interval, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE820 Offset: 0x2FFE921 VA: 0x2FFE820
	|-SampleObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE910 Offset: 0x2FFEA11 VA: 0x2FFE910
	|-SampleObservable<object>.SubscribeCore
	*/
}

