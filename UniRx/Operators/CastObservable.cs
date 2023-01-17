// Namespace: UniRx.Operators
internal class CastObservable<TSource, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 6883
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D1DA0 Offset: 0x30D1EA1 VA: 0x30D1DA0
	|-CastObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D1E10 Offset: 0x30D1F11 VA: 0x30D1E10
	|-CastObservable<object, object>.SubscribeCore
	*/
}

