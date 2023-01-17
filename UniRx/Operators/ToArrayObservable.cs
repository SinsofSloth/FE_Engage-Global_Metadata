// Namespace: UniRx.Operators
internal class ToArrayObservable<TSource> : OperatorObservableBase<TSource[]> // TypeDefIndex: 7119
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E500 Offset: 0x356E601 VA: 0x356E500
	|-ToArrayObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TSource[]> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E570 Offset: 0x356E671 VA: 0x356E570
	|-ToArrayObservable<object>.SubscribeCore
	*/
}

