// Namespace: UniRx.Operators
internal class ReturnObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7024
{
	// Fields
	private readonly T value; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF8F00 Offset: 0x2FF9001 VA: 0x2FF8F00
	|-ReturnObservable<object>..ctor
	|
	|-RVA: 0x2FF9320 Offset: 0x2FF9421 VA: 0x2FF9320
	|-ReturnObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF8FC0 Offset: 0x2FF90C1 VA: 0x2FF8FC0
	|-ReturnObservable<object>.SubscribeCore
	|
	|-RVA: 0x2FF93E0 Offset: 0x2FF94E1 VA: 0x2FF93E0
	|-ReturnObservable<Unit>.SubscribeCore
	*/
}

