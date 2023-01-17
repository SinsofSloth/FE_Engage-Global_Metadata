// Namespace: UniRx.Operators
internal class SampleObservable<T, T2> : OperatorObservableBase<T> // TypeDefIndex: 7034
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IObservable<T2> intervalSource; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IObservable<T2> intervalSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE9B0 Offset: 0x2FFEAB1 VA: 0x2FFE9B0
	|-SampleObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFEA30 Offset: 0x2FFEB31 VA: 0x2FFEA30
	|-SampleObservable<object, object>.SubscribeCore
	*/
}

