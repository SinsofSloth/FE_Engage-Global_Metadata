// Namespace: UniRx.Operators
internal class SynchronizedObserver<T> : IObserver<T> // TypeDefIndex: 7083
{
	// Fields
	private readonly IObserver<T> observer; // 0x0
	private readonly object gate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, object gate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2FA0 Offset: 0x34B30A1 VA: 0x34B2FA0
	|-SynchronizedObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2FF0 Offset: 0x34B30F1 VA: 0x34B2FF0
	|-SynchronizedObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3140 Offset: 0x34B3241 VA: 0x34B3140
	|-SynchronizedObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3290 Offset: 0x34B3391 VA: 0x34B3290
	|-SynchronizedObserver<object>.OnCompleted
	*/
}

