// Namespace: UniRx.Async
public interface IAsyncEndEditEventHandler<T> : IDisposable // TypeDefIndex: 5150
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UniTask<T> OnEndEditAsync();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncEndEditEventHandler<object>.OnEndEditAsync
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract UniTask<ValueTuple<bool, T>> OnEndEditAsyncSuppressCancellationThrow();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncEndEditEventHandler<object>.OnEndEditAsyncSuppressCancellationThrow
	*/
}

