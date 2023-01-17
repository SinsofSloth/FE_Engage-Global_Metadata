// Namespace: UniRx.Async.Triggers
public interface ICancelablePromise // TypeDefIndex: 5188
{
	// Properties
	public abstract CancellationToken RegisteredCancellationToken { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CancellationToken get_RegisteredCancellationToken();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TrySetCanceled();
}

