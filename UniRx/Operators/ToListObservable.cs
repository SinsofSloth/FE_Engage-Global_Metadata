// Namespace: UniRx.Operators
internal class ToListObservable<TSource> : OperatorObservableBase<IList<TSource>> // TypeDefIndex: 7121
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356EE00 Offset: 0x356EF01 VA: 0x356EE00
	|-ToListObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IList<TSource>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356EE70 Offset: 0x356EF71 VA: 0x356EE70
	|-ToListObservable<object>.SubscribeCore
	*/
}

