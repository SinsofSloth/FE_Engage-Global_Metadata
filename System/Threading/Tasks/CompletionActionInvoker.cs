// Namespace: System.Threading.Tasks
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 837
{
	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x33AAB50 Offset: 0x33AAC51 VA: 0x33AAB50
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x33AABA0 Offset: 0x33AACA1 VA: 0x33AABA0 Slot: 4
	public void ExecuteWorkItem() { }

	// RVA: 0x33AAC50 Offset: 0x33AAD51 VA: 0x33AAC50 Slot: 5
	public void MarkAborted(ThreadAbortException tae) { }
}

