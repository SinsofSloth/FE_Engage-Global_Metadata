// Namespace: UniRx.Async
public interface IAwaiter<T> : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4919
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T GetResult();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAwaiter<object>.GetResult
	*/
}

