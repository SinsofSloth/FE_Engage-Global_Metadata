// Namespace: 
private class SwitchObservable.SwitchObserver.Switch<T> : IObserver<T> // TypeDefIndex: 7078
{
	// Fields
	private readonly SwitchObservable.SwitchObserver<T> parent; // 0x0
	private readonly ulong id; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SwitchObservable.SwitchObserver<T> observer, ulong id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1B70 Offset: 0x34B1C71 VA: 0x34B1B70
	|-SwitchObservable.SwitchObserver.Switch<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1BC0 Offset: 0x34B1CC1 VA: 0x34B1BC0
	|-SwitchObservable.SwitchObserver.Switch<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1D30 Offset: 0x34B1E31 VA: 0x34B1D30
	|-SwitchObservable.SwitchObserver.Switch<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1EA0 Offset: 0x34B1FA1 VA: 0x34B1EA0
	|-SwitchObservable.SwitchObserver.Switch<object>.OnCompleted
	*/
}

