// Namespace: UniRx.Async
public interface IAsyncValueChangedEventHandler<T> : IDisposable // TypeDefIndex: 5149
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UniTask<T> OnValueChangedAsync();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncValueChangedEventHandler<object>.OnValueChangedAsync
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract UniTask<ValueTuple<bool, T>> OnValueChangedAsyncSuppressCancellationThrow();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncValueChangedEventHandler<object>.OnValueChangedAsyncSuppressCancellationThrow
	*/
}

