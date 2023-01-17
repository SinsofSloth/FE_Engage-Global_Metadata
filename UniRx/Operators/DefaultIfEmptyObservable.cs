// Namespace: UniRx.Operators
internal class DefaultIfEmptyObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6925
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly T defaultValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510CE0 Offset: 0x2510DE1 VA: 0x2510CE0
	|-DefaultIfEmptyObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510D60 Offset: 0x2510E61 VA: 0x2510D60
	|-DefaultIfEmptyObservable<object>.SubscribeCore
	*/
}

