// Namespace: 
internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 861
{
	// Fields
	private IList<Task> _tasks; // 0x58
	private int m_firstTaskAlreadyCompleted; // 0x60

	// Methods

	// RVA: 0x1C06BA0 Offset: 0x1C06CA1 VA: 0x1C06BA0
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x1C06CF0 Offset: 0x1C06DF1 VA: 0x1C06CF0 Slot: 20
	public void Invoke(Task completingTask) { }
}

