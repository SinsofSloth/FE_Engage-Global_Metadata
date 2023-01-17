// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 855
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x365D530 Offset: 0x365D631 VA: 0x365D530
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x365D580 Offset: 0x365D681 VA: 0x365D580 Slot: 4
	internal sealed override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x365D810 Offset: 0x365D911 VA: 0x365D810
	private static void PostAction(object state) { }

	// RVA: 0x365D8B0 Offset: 0x365D9B1 VA: 0x365D8B0
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x365D9B0 Offset: 0x365DAB1 VA: 0x365D9B0
	private static void .cctor() { }
}

