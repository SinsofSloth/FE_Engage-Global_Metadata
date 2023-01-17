// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x4750E0 Offset: 0x4751E1 VA: 0x4750E0
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 1185
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78
	internal static ContextCallback ccb; // 0x0

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x356A490 Offset: 0x356A591 VA: 0x356A490
	internal void .ctor() { }

	// RVA: 0x356A4A0 Offset: 0x356A5A1 VA: 0x356A4A0
	internal void .ctor(WaitCallback cb, object state, bool capture_context) { }

	// RVA: 0x356A5D0 Offset: 0x356A6D1 VA: 0x356A5D0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x356A660 Offset: 0x356A761 VA: 0x356A660 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x356A670 Offset: 0x356A771 VA: 0x356A670 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x356A7B0 Offset: 0x356A8B1 VA: 0x356A7B0 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x356A7C0 Offset: 0x356A8C1 VA: 0x356A7C0 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x356A7D0 Offset: 0x356A8D1 VA: 0x356A7D0
	public bool get_EndInvokeCalled() { }

	// RVA: 0x356A7E0 Offset: 0x356A8E1 VA: 0x356A7E0
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x356A7F0 Offset: 0x356A8F1 VA: 0x356A7F0 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x356A800 Offset: 0x356A901 VA: 0x356A800 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x356A810 Offset: 0x356A911 VA: 0x356A810 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x356A850 Offset: 0x356A951 VA: 0x356A850 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x356A860 Offset: 0x356A961 VA: 0x356A860 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x356A870 Offset: 0x356A971 VA: 0x356A870
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x356A880 Offset: 0x356A981 VA: 0x356A880
	internal IMessage EndInvoke() { }

	// RVA: 0x356A9A0 Offset: 0x356AAA1 VA: 0x356A9A0 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x356AB30 Offset: 0x356AC31 VA: 0x356AB30
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x356AB40 Offset: 0x356AC41 VA: 0x356AB40
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x356AB50 Offset: 0x356AC51 VA: 0x356AB50 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x356AB70 Offset: 0x356AC71 VA: 0x356AB70 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x356AB60 Offset: 0x356AC61 VA: 0x356AB60
	internal object Invoke() { }

	// RVA: 0x356AB80 Offset: 0x356AC81 VA: 0x356AB80
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x47D2B0 Offset: 0x47D3B1 VA: 0x47D2B0
	// RVA: 0x356AC20 Offset: 0x356AD21 VA: 0x356AC20
	private void <.ctor>b__17_0(object <p0>) { }
}

