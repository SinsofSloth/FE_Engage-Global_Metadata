// Namespace: System
public interface IObserver<T> // TypeDefIndex: 266
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNext(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnError(Exception error);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCompleted();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObserver<object>.OnCompleted
	*/
}

