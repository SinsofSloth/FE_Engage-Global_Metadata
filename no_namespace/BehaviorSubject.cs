// Namespace: 
private class BehaviorSubject.Subscription<T> : IDisposable // TypeDefIndex: 6636
{
	// Fields
	private readonly object gate; // 0x0
	private BehaviorSubject<T> parent; // 0x0
	private IObserver<T> unsubscribeTarget; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BehaviorSubject<T> parent, IObserver<T> unsubscribeTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B0090 Offset: 0x34B0191 VA: 0x34B0090
	|-BehaviorSubject.Subscription<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B0140 Offset: 0x34B0241 VA: 0x34B0140
	|-BehaviorSubject.Subscription<object>.Dispose
	*/
}

