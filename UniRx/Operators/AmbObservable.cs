// Namespace: UniRx.Operators
internal class AmbObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6863
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IObservable<T> second; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IObservable<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7B70 Offset: 0x1FF7C71 VA: 0x1FF7B70
	|-AmbObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7C20 Offset: 0x1FF7D21 VA: 0x1FF7C20
	|-AmbObservable<object>.SubscribeCore
	*/
}

