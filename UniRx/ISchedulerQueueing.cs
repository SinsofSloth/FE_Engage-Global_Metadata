// Namespace: UniRx
public interface ISchedulerQueueing // TypeDefIndex: 6630
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISchedulerQueueing.ScheduleQueueing<Exception>
	|-ISchedulerQueueing.ScheduleQueueing<object>
	|-ISchedulerQueueing.ScheduleQueueing<Unit>
	*/
}

