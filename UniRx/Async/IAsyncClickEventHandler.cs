// Namespace: UniRx.Async
public interface IAsyncClickEventHandler : IDisposable // TypeDefIndex: 5148
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UniTask OnClickAsync();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract UniTask<bool> OnClickAsyncSuppressCancellationThrow();
}

