// Namespace: System.Threading.Tasks
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 857
{
	// Fields
	private readonly TaskScheduler m_scheduler; // 0x20

	// Methods

	// RVA: 0x3665970 Offset: 0x3665A71 VA: 0x3665970
	internal void .ctor(TaskScheduler scheduler, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x366A9A0 Offset: 0x366AAA1 VA: 0x366A9A0 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }
}

