// Namespace: UniRx.Operators
internal class PairwiseObservable<T> : OperatorObservableBase<Pair<T>> // TypeDefIndex: 7009
{
	// Fields
	private readonly IObservable<T> source; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A604F0 Offset: 0x2A605F1 VA: 0x2A604F0
	|-PairwiseObservable<int>..ctor
	|
	|-RVA: 0x2A60650 Offset: 0x2A60751 VA: 0x2A60650
	|-PairwiseObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Pair<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60560 Offset: 0x2A60661 VA: 0x2A60560
	|-PairwiseObservable<int>.SubscribeCore
	|
	|-RVA: 0x2A606C0 Offset: 0x2A607C1 VA: 0x2A606C0
	|-PairwiseObservable<object>.SubscribeCore
	*/
}

