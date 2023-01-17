// Namespace: UniRx.Operators
internal class DoOnTerminateObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6953
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action onTerminate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action onTerminate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26364F0 Offset: 0x26365F1 VA: 0x26364F0
	|-DoOnTerminateObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636570 Offset: 0x2636671 VA: 0x2636570
	|-DoOnTerminateObservable<object>.SubscribeCore
	*/
}

