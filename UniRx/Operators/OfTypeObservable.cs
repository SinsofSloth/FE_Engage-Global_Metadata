// Namespace: UniRx.Operators
internal class OfTypeObservable<TSource, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7002
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714A10 Offset: 0x3714B11 VA: 0x3714A10
	|-OfTypeObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714A80 Offset: 0x3714B81 VA: 0x3714A80
	|-OfTypeObservable<object, object>.SubscribeCore
	*/
}

