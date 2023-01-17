// Namespace: UniRx
public interface IObserver<TValue, TResult> // TypeDefIndex: 6549
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TResult OnNext(TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObserver<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TResult OnError(Exception exception);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObserver<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult OnCompleted();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObserver<object, object>.OnCompleted
	*/
}

