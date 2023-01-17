// Namespace: UniRx.Operators
internal abstract class NthZipObserverBase<T> : OperatorObserverBase<T, T>, IZipObservable // TypeDefIndex: 7169
{
	// Fields
	private ICollection[] queues; // 0x0
	private bool[] isDone; // 0x0
	private int length; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9620 Offset: 0x31A9721 VA: 0x31A9620
	|-NthZipObserverBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void SetQueue(ICollection[] queues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9640 Offset: 0x31A9741 VA: 0x31A9640
	|-NthZipObserverBase<object>.SetQueue
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract T GetResult();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-NthZipObserverBase<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Dequeue(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A96C0 Offset: 0x31A97C1 VA: 0x31A96C0
	|-NthZipObserverBase<object>.Dequeue
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void Done(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9AB0 Offset: 0x31A9BB1 VA: 0x31A9AB0
	|-NthZipObserverBase<object>.Done
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Fail(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9C40 Offset: 0x31A9D41 VA: 0x31A9C40
	|-NthZipObserverBase<object>.Fail
	*/
}

