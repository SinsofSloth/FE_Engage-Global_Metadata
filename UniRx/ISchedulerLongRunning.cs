// Namespace: UniRx
public interface ISchedulerLongRunning // TypeDefIndex: 6629
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDisposable ScheduleLongRunning(Action<ICancelable> action);
}

