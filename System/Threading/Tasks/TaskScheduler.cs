// Namespace: System.Threading.Tasks
[DebuggerTypeProxyAttribute] // RVA: 0x473960 Offset: 0x473A61 VA: 0x473960
[DebuggerDisplayAttribute] // RVA: 0x473960 Offset: 0x473A61 VA: 0x473960
public abstract class TaskScheduler // TypeDefIndex: 864
{
	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly object _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x3665FE0 Offset: 0x36660E1 VA: 0x3665FE0
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x366A610 Offset: 0x366A711 VA: 0x366A610 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x366A620 Offset: 0x366A721 VA: 0x366A620 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x366A630 Offset: 0x366A731 VA: 0x366A630 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x3662B10 Offset: 0x3662C11 VA: 0x3662B10
	internal void InternalQueueTask(Task task) { }

	// RVA: 0x365DBD0 Offset: 0x365DCD1 VA: 0x365DBD0
	protected void .ctor() { }

	// RVA: 0x366A640 Offset: 0x366A741 VA: 0x366A640
	private void AddToActiveTaskSchedulers() { }

	// RVA: 0x366A750 Offset: 0x366A851 VA: 0x366A750
	public static TaskScheduler get_Default() { }

	// RVA: 0x3666910 Offset: 0x3666A11 VA: 0x3666910
	public static TaskScheduler get_Current() { }

	// RVA: 0x3665830 Offset: 0x3665931 VA: 0x3665830
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x366A7C0 Offset: 0x366A8C1 VA: 0x366A7C0
	public static TaskScheduler FromCurrentSynchronizationContext() { }

	// RVA: 0x366A820 Offset: 0x366A921 VA: 0x366A820
	public int get_Id() { }

	// RVA: 0x365DD50 Offset: 0x365DE51 VA: 0x365DD50
	protected bool TryExecuteTask(Task task) { }

	// RVA: 0x36697E0 Offset: 0x36698E1 VA: 0x36697E0
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x366A8E0 Offset: 0x366A9E1 VA: 0x366A8E0
	private static void .cctor() { }
}

