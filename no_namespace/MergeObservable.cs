// Namespace: 
private class MergeObservable.MergeConcurrentObserver.Merge<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6991
{
	// Fields
	private readonly MergeObservable.MergeConcurrentObserver<T> parent; // 0x0
	private readonly IDisposable cancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MergeObservable.MergeConcurrentObserver<T> parent, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A920 Offset: 0x293AA21 VA: 0x293A920
	|-MergeObservable.MergeConcurrentObserver.Merge<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A9A0 Offset: 0x293AAA1 VA: 0x293A9A0
	|-MergeObservable.MergeConcurrentObserver.Merge<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293AB00 Offset: 0x293AC01 VA: 0x293AB00
	|-MergeObservable.MergeConcurrentObserver.Merge<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293ACE0 Offset: 0x293ADE1 VA: 0x293ACE0
	|-MergeObservable.MergeConcurrentObserver.Merge<object>.OnCompleted
	*/
}

