// Namespace: UniRx.Async
public interface IAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4918
{
	// Properties
	public abstract AwaiterStatus Status { get; }
	public abstract bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AwaiterStatus get_Status();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsCompleted();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult();
}

