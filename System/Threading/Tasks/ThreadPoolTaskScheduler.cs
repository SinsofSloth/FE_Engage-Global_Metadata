// Namespace: System.Threading.Tasks
internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 871
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x1B15B00 Offset: 0x1B15C01 VA: 0x1B15B00
	internal void .ctor() { }

	// RVA: 0x1B15B80 Offset: 0x1B15C81 VA: 0x1B15B80
	private static void LongRunningThreadWork(object obj) { }

	// RVA: 0x1B15C10 Offset: 0x1B15D11 VA: 0x1B15C10 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x1B15D60 Offset: 0x1B15E61 VA: 0x1B15D60 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x1B15E50 Offset: 0x1B15F51 VA: 0x1B15E50 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x1B15E60 Offset: 0x1B15F61 VA: 0x1B15E60 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x1B15E70 Offset: 0x1B15F71 VA: 0x1B15E70 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1B15E80 Offset: 0x1B15F81 VA: 0x1B15E80
	private static void .cctor() { }
}

