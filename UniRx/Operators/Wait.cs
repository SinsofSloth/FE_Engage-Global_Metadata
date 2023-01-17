// Namespace: UniRx.Operators
internal class Wait<T> : IObserver<T> // TypeDefIndex: 7125
{
	// Fields
	private static readonly TimeSpan InfiniteTimeSpan; // 0x0
	private readonly IObservable<T> source; // 0x0
	private readonly TimeSpan timeout; // 0x0
	private ManualResetEvent semaphore; // 0x0
	private bool seenValue; // 0x0
	private T value; // 0x0
	private Exception ex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9A40 Offset: 0x2FD9B41 VA: 0x2FD9A40
	|-Wait<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9A90 Offset: 0x2FD9B91 VA: 0x2FD9A90
	|-Wait<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9E40 Offset: 0x2FD9F41 VA: 0x2FD9E40
	|-Wait<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9E50 Offset: 0x2FD9F51 VA: 0x2FD9E50
	|-Wait<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9E80 Offset: 0x2FD9F81 VA: 0x2FD9E80
	|-Wait<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9E90 Offset: 0x2FD9F91 VA: 0x2FD9E90
	|-Wait<object>..cctor
	*/
}

