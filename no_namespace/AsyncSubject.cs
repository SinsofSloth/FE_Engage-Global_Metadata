// Namespace: 
private class AsyncSubject.AwaitObserver<T> : IObserver<T> // TypeDefIndex: 6633
{
	// Fields
	private readonly SynchronizationContext _context; // 0x0
	private readonly Action _callback; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action callback, bool originalContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EBE0 Offset: 0x2F5ECE1 VA: 0x2F5EBE0
	|-AsyncSubject.AwaitObserver<object>..ctor
	|
	|-RVA: 0x2F5EEA0 Offset: 0x2F5EFA1 VA: 0x2F5EEA0
	|-AsyncSubject.AwaitObserver<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC40 Offset: 0x2F5ED41 VA: 0x2F5EC40
	|-AsyncSubject.AwaitObserver<object>.OnCompleted
	|
	|-RVA: 0x2F5EF00 Offset: 0x2F5F001 VA: 0x2F5EF00
	|-AsyncSubject.AwaitObserver<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC60 Offset: 0x2F5ED61 VA: 0x2F5EC60
	|-AsyncSubject.AwaitObserver<object>.OnError
	|
	|-RVA: 0x2F5EF20 Offset: 0x2F5F021 VA: 0x2F5EF20
	|-AsyncSubject.AwaitObserver<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC80 Offset: 0x2F5ED81 VA: 0x2F5EC80
	|-AsyncSubject.AwaitObserver<object>.OnNext
	|
	|-RVA: 0x2F5EF40 Offset: 0x2F5F041 VA: 0x2F5EF40
	|-AsyncSubject.AwaitObserver<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1
	private void InvokeOnOriginalContext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC90 Offset: 0x2F5ED91 VA: 0x2F5EC90
	|-AsyncSubject.AwaitObserver<object>.InvokeOnOriginalContext
	|
	|-RVA: 0x2F5EF50 Offset: 0x2F5F051 VA: 0x2F5EF50
	|-AsyncSubject.AwaitObserver<Unit>.InvokeOnOriginalContext
	*/
}

