// Namespace: UniRx.Operators
internal class BufferObservable<TSource, TWindowBoundary> : OperatorObservableBase<IList<TSource>> // TypeDefIndex: 6881
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly IObservable<TWindowBoundary> windowBoundaries; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, IObservable<TWindowBoundary> windowBoundaries) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BDEF0 Offset: 0x30BDFF1 VA: 0x30BDEF0
	|-BufferObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IList<TSource>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BDF70 Offset: 0x30BE071 VA: 0x30BDF70
	|-BufferObservable<object, object>.SubscribeCore
	*/
}

