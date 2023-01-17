// Namespace: 
private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 868
{
	// Fields
	internal readonly Task Task; // 0x10
	private readonly object m_state; // 0x18
	private readonly bool m_completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0x1C07120 Offset: 0x1C07221 VA: 0x1C07120
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x1C07180 Offset: 0x1C07281 VA: 0x1C07180 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0x1C07190 Offset: 0x1C07291 VA: 0x1C07190 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x1C071A0 Offset: 0x1C072A1 VA: 0x1C071A0 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x1C071B0 Offset: 0x1C072B1 VA: 0x1C071B0 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }
}

