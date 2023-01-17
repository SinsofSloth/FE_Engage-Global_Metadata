// Namespace: UniRx.Operators
internal class MaterializeObservable<T> : OperatorObservableBase<Notification<T>> // TypeDefIndex: 6988
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A170 Offset: 0x293A271 VA: 0x293A170
	|-MaterializeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Notification<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A1E0 Offset: 0x293A2E1 VA: 0x293A1E0
	|-MaterializeObservable<object>.SubscribeCore
	*/
}

