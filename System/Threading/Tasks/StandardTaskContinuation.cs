// Namespace: System.Threading.Tasks
internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 853
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x3831750 Offset: 0x3831851 VA: 0x3831750
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x3831900 Offset: 0x3831A01 VA: 0x3831900 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}

