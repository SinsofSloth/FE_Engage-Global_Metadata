// Namespace: UniRx.Operators
internal class IgnoreElementsObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6983
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0240 Offset: 0x1EB0341 VA: 0x1EB0240
	|-IgnoreElementsObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB02B0 Offset: 0x1EB03B1 VA: 0x1EB02B0
	|-IgnoreElementsObservable<object>.SubscribeCore
	*/
}

