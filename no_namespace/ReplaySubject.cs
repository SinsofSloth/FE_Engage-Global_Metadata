// Namespace: 
private class ReplaySubject.Subscription<T> : IDisposable // TypeDefIndex: 6641
{
	// Fields
	private readonly object gate; // 0x0
	private ReplaySubject<T> parent; // 0x0
	private IObserver<T> unsubscribeTarget; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ReplaySubject<T> parent, IObserver<T> unsubscribeTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B0420 Offset: 0x34B0521 VA: 0x34B0420
	|-ReplaySubject.Subscription<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B04D0 Offset: 0x34B05D1 VA: 0x34B04D0
	|-ReplaySubject.Subscription<object>.Dispose
	*/
}

