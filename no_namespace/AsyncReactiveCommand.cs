// Namespace: 
private class AsyncReactiveCommand.Subscription<T> : IDisposable // TypeDefIndex: 6750
{
	// Fields
	private readonly AsyncReactiveCommand<T> parent; // 0x0
	private readonly Func<T, IObservable<Unit>> asyncAction; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AsyncReactiveCommand<T> parent, Func<T, IObservable<Unit>> asyncAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AFBB0 Offset: 0x34AFCB1 VA: 0x34AFBB0
	|-AsyncReactiveCommand.Subscription<object>..ctor
	|
	|-RVA: 0x34B0ED0 Offset: 0x34B0FD1 VA: 0x34B0ED0
	|-AsyncReactiveCommand.Subscription<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AFC00 Offset: 0x34AFD01 VA: 0x34AFC00
	|-AsyncReactiveCommand.Subscription<object>.Dispose
	|
	|-RVA: 0x34B0F20 Offset: 0x34B1021 VA: 0x34B0F20
	|-AsyncReactiveCommand.Subscription<Unit>.Dispose
	*/
}

