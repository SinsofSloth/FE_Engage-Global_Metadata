// Namespace: System.Threading.Tasks
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 859
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x356C8C0 Offset: 0x356C9C1 VA: 0x356C8C0
	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x356C990 Offset: 0x356CA91 VA: 0x356C990
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x356CA40 Offset: 0x356CB41 VA: 0x356CA40
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x356CAF0 Offset: 0x356CBF1 VA: 0x356CAF0 Slot: 4
	internal override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x356CC30 Offset: 0x356CD31 VA: 0x356CC30
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x356CFE0 Offset: 0x356D0E1 VA: 0x356CFE0
	private void ExecuteWorkItemHelper() { }

	// RVA: 0x356D160 Offset: 0x356D261 VA: 0x356D160 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x356D180 Offset: 0x356D281 VA: 0x356D180 Slot: 6
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x356D190 Offset: 0x356D291 VA: 0x356D190
	private static void InvokeAction(object state) { }

	// RVA: 0x356D200 Offset: 0x356D301 VA: 0x356D200
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x356CDE0 Offset: 0x356CEE1 VA: 0x356CDE0
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x356D460 Offset: 0x356D561 VA: 0x356D460
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x356D660 Offset: 0x356D761 VA: 0x356D660
	internal static void UnsafeScheduleAction(Action action, Task task) { }

	// RVA: 0x356D2D0 Offset: 0x356D3D1 VA: 0x356D2D0
	protected static void ThrowAsyncIfNecessary(Exception exc) { }
}

