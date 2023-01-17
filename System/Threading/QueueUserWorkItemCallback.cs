// Namespace: System.Threading
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 793
{
	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x3B67AE0 Offset: 0x3B67BE1 VA: 0x3B67AE0
	private static void .cctor() { }

	// RVA: 0x3B67B80 Offset: 0x3B67C81 VA: 0x3B67B80
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x3B67C90 Offset: 0x3B67D91 VA: 0x3B67C90 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3B67D80 Offset: 0x3B67E81 VA: 0x3B67D80 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x3B67D90 Offset: 0x3B67E91 VA: 0x3B67D90
	private static void WaitCallback_Context(object state) { }
}

