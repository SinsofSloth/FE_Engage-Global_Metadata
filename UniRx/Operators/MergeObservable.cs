// Namespace: UniRx.Operators
internal class MergeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6993
{
	// Fields
	private readonly IObservable<IObservable<T>> sources; // 0x0
	private readonly int maxConcurrent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<IObservable<T>> sources, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293BE40 Offset: 0x293BF41 VA: 0x293BE40
	|-MergeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<IObservable<T>> sources, int maxConcurrent, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293BE90 Offset: 0x293BF91 VA: 0x293BE90
	|-MergeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293BEF0 Offset: 0x293BFF1 VA: 0x293BEF0
	|-MergeObservable<object>.SubscribeCore
	*/
}

