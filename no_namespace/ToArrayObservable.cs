// Namespace: 
private class ToArrayObservable.ToArray<TSource> : OperatorObserverBase<TSource, TSource[]> // TypeDefIndex: 7118
{
	// Fields
	private readonly List<TSource> list; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<TSource[]> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DE10 Offset: 0x356DF11 VA: 0x356DE10
	|-ToArrayObservable.ToArray<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DEB0 Offset: 0x356DFB1 VA: 0x356DEB0
	|-ToArrayObservable.ToArray<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E080 Offset: 0x356E181 VA: 0x356E080
	|-ToArrayObservable.ToArray<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E1C0 Offset: 0x356E2C1 VA: 0x356E1C0
	|-ToArrayObservable.ToArray<object>.OnCompleted
	*/
}

