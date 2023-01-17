// Namespace: System.Threading
public static class ThreadPool // TypeDefIndex: 794
{
	// Methods

	// RVA: 0x1B14E10 Offset: 0x1B14F11 VA: 0x1B14E10
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1B15180 Offset: 0x1B15281 VA: 0x1B15180
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { }

	// RVA: 0x1B15210 Offset: 0x1B15311 VA: 0x1B15210
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1B15120 Offset: 0x1B15221 VA: 0x1B15120
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x1B15440 Offset: 0x1B15541 VA: 0x1B15440
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x1B15150 Offset: 0x1B15251 VA: 0x1B15150
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x1B15320 Offset: 0x1B15421 VA: 0x1B15320
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1B156A0 Offset: 0x1B157A1 VA: 0x1B156A0
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x1B15720 Offset: 0x1B15821 VA: 0x1B15720
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x1B158A0 Offset: 0x1B159A1 VA: 0x1B158A0
	internal static bool RequestWorkerThread() { }

	// RVA: 0x1B15480 Offset: 0x1B15581 VA: 0x1B15480
	private static void EnsureVMInitialized() { }

	// RVA: 0x1B158C0 Offset: 0x1B159C1 VA: 0x1B158C0
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x1B158D0 Offset: 0x1B159D1 VA: 0x1B158D0
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x1B158E0 Offset: 0x1B159E1 VA: 0x1B158E0
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x1B15990 Offset: 0x1B15A91 VA: 0x1B15990
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x1B159A0 Offset: 0x1B15AA1 VA: 0x1B159A0
	internal static bool IsThreadPoolHosted() { }

	// RVA: 0x1B158B0 Offset: 0x1B159B1 VA: 0x1B158B0
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }
}

