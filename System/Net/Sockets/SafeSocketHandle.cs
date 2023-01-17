// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2636
{
	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x2D03EB0 Offset: 0x2D03FB1 VA: 0x2D03EB0
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x2D03FB0 Offset: 0x2D040B1 VA: 0x2D03FB0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x2D045F0 Offset: 0x2D046F1 VA: 0x2D045F0
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x2D04970 Offset: 0x2D04A71 VA: 0x2D04970
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x2D04B50 Offset: 0x2D04C51 VA: 0x2D04B50
	private static void .cctor() { }
}

