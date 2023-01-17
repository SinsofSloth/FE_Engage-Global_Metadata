// Namespace: UniRx.Operators
internal class ThrowObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7103
{
	// Fields
	private readonly Exception error; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Exception error, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399C2D0 Offset: 0x399C3D1 VA: 0x399C2D0
	|-ThrowObservable<object>..ctor
	|
	|-RVA: 0x399C670 Offset: 0x399C771 VA: 0x399C670
	|-ThrowObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399C390 Offset: 0x399C491 VA: 0x399C390
	|-ThrowObservable<object>.SubscribeCore
	|
	|-RVA: 0x399C730 Offset: 0x399C831 VA: 0x399C730
	|-ThrowObservable<Unit>.SubscribeCore
	*/
}

