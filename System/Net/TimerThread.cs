// Namespace: System.Net
internal static class TimerThread // TypeDefIndex: 2504
{
	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static Hashtable s_QueuesCache; // 0x30

	// Methods

	// RVA: 0x2D13F30 Offset: 0x2D14031 VA: 0x2D13F30
	private static void .cctor() { }

	// RVA: 0x2D141F0 Offset: 0x2D142F1 VA: 0x2D141F0
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x2D14440 Offset: 0x2D14541 VA: 0x2D14440
	private static void StopTimerThread() { }

	// RVA: 0x2D144C0 Offset: 0x2D145C1 VA: 0x2D144C0
	private static void OnDomainUnload(object sender, EventArgs e) { }
}

