// Namespace: UniRx.Operators
internal class RepeatObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7019
{
	// Fields
	private readonly T value; // 0x0
	private readonly Nullable<int> repeatCount; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, Nullable<int> repeatCount, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF40B0 Offset: 0x2FF41B1 VA: 0x2FF40B0
	|-RepeatObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF4180 Offset: 0x2FF4281 VA: 0x2FF4180
	|-RepeatObservable<object>.SubscribeCore
	*/
}

