// Namespace: 
private class AsyncMessageBroker.Subscription<T> : IDisposable // TypeDefIndex: 6569
{
	// Fields
	private readonly AsyncMessageBroker parent; // 0x0
	private readonly Func<T, IObservable<Unit>> asyncMessageReceiver; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AsyncMessageBroker parent, Func<T, IObservable<Unit>> asyncMessageReceiver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1740 Offset: 0x34B1841 VA: 0x34B1740
	|-AsyncMessageBroker.Subscription<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1790 Offset: 0x34B1891 VA: 0x34B1790
	|-AsyncMessageBroker.Subscription<object>.Dispose
	*/
}

