// Namespace: System.Net
internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 2495
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x31650 Offset: 0x31751 VA: 0x31650
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_UserEvent; // 0x34
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }

	// Methods

	// RVA: 0x1AC2FB0 Offset: 0x1AC30B1 VA: 0x1AC2FB0
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1AC3060 Offset: 0x1AC3161 VA: 0x1AC3060
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1AC3130 Offset: 0x1AC3231 VA: 0x1AC3130
	internal object get_AsyncObject() { }

	// RVA: 0x1AC3140 Offset: 0x1AC3241 VA: 0x1AC3140 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1AC3150 Offset: 0x1AC3251 VA: 0x1AC3150 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1AC3210 Offset: 0x1AC3311 VA: 0x1AC3210
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1AC3410 Offset: 0x1AC3511 VA: 0x1AC3410 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1AC3460 Offset: 0x1AC3561 VA: 0x1AC3460 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1AC3400 Offset: 0x1AC3501 VA: 0x1AC3400
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x1AC34B0 Offset: 0x1AC35B1 VA: 0x1AC34B0
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1AC36C0 Offset: 0x1AC37C1 VA: 0x1AC36C0
	internal void InvokeCallback(object result) { }

	// RVA: 0x1AC3720 Offset: 0x1AC3821 VA: 0x1AC3720 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1AC3890 Offset: 0x1AC3991 VA: 0x1AC3890
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x1AC3940 Offset: 0x1AC3A41 VA: 0x1AC3940 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x1AC3950 Offset: 0x1AC3A51 VA: 0x1AC3950
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1AC3960 Offset: 0x1AC3A61 VA: 0x1AC3960
	private object WaitForCompletion(bool snap) { }
}

