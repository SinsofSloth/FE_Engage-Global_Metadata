// Namespace: UniRx
public interface IScheduler // TypeDefIndex: 6627
{
	// Properties
	public abstract DateTimeOffset Now { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTimeOffset get_Now();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDisposable Schedule(Action action);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IDisposable Schedule(TimeSpan dueTime, Action action);
}

