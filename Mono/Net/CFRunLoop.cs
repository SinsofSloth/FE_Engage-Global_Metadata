// Namespace: Mono.Net
internal class CFRunLoop : CFObject // TypeDefIndex: 2169
{
	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0x1B47800 Offset: 0x1B47901 VA: 0x1B47800
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1B478A0 Offset: 0x1B479A1 VA: 0x1B478A0
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x1B47940 Offset: 0x1B47A41 VA: 0x1B47940
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1B479E0 Offset: 0x1B47AE1 VA: 0x1B479E0
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0x1B47A50 Offset: 0x1B47B51 VA: 0x1B47A50
	private static extern void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0x1B47AD0 Offset: 0x1B47BD1 VA: 0x1B47AD0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x1B44C50 Offset: 0x1B44D51 VA: 0x1B44C50
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0x1B44EA0 Offset: 0x1B44FA1 VA: 0x1B44EA0
	public void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0x1B44FE0 Offset: 0x1B450E1 VA: 0x1B44FE0
	public void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0x1B44F40 Offset: 0x1B45041 VA: 0x1B44F40
	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x1B47B70 Offset: 0x1B47C71 VA: 0x1B47B70
	public void Stop() { }
}

