// Namespace: NexPlugin
public static class Common // TypeDefIndex: 14868
{
	// Fields
	public const ulong INVALID_PRINCIPALID = 0;
	public const ulong INVALID_UNIQUEID = 0;
	public const int DEFAULT_CORE_NO = 1;
	public const uint INFINITE_TIME_INTERVAL = 2147483647;

	// Methods

	// RVA: 0x257A780 Offset: 0x257A881 VA: 0x257A780
	public static extern bool IsInitializedNex() { }

	// RVA: 0x257A7A0 Offset: 0x257A8A1 VA: 0x257A7A0
	public static extern bool IsNetworkConnected() { }

	// RVA: 0x257A7C0 Offset: 0x257A8C1 VA: 0x257A7C0
	public static extern bool InitializeNexPlugin(uint pluginMemSize) { }

	// RVA: 0x257A7E0 Offset: 0x257A8E1 VA: 0x257A7E0
	public static extern bool FinalizeNexPlugin() { }

	// RVA: 0x257A800 Offset: 0x257A901 VA: 0x257A800
	public static bool InitializeNexAsync(out uint asyncId, Common.ThreadMode threadMode, AsyncResultCB callback) { }

	// RVA: 0x257A810 Offset: 0x257A911 VA: 0x257A810
	public static extern bool InitializeNex(Common.ThreadMode threadMode) { }

	// RVA: 0x257A830 Offset: 0x257A931 VA: 0x257A830
	public static bool FinalizeNexAsync(out uint asyncId, AsyncResultCB callback) { }

	// RVA: 0x257A840 Offset: 0x257A941 VA: 0x257A840
	public static extern bool FinalizeNex() { }

	// RVA: 0x257A860 Offset: 0x257A961 VA: 0x257A860
	public static void SetTerminateImmediately(bool bTerminate) { }

	// RVA: 0x257A870 Offset: 0x257A971 VA: 0x257A870
	public static extern bool GetTerminateImmediately() { }

	// RVA: 0x257A890 Offset: 0x257A991 VA: 0x257A890
	public static extern bool SetThreadCoreNo(int coreNo) { }

	// RVA: 0x257A8B0 Offset: 0x257A9B1 VA: 0x257A8B0
	public static uint Dispatch(uint dispatchTimeout, Nullable<Common.DispachFlag> dispatchFlags) { }

	// RVA: 0x257A8C0 Offset: 0x257A9C1 VA: 0x257A8C0
	public static void DispatchAll() { }

	// RVA: 0x257A8D0 Offset: 0x257A9D1 VA: 0x257A8D0
	public static uint GetReadyJobsSize() { }

	// RVA: 0x257A8E0 Offset: 0x257A9E1 VA: 0x257A8E0
	public static bool UpdateAsyncResult() { }

	// RVA: 0x257A8F0 Offset: 0x257A9F1 VA: 0x257A8F0
	public static void Wait(uint dispatchTimeout = 0, Nullable<Common.DispachFlag> dispatchFlags) { }

	// RVA: 0x257A900 Offset: 0x257AA01 VA: 0x257A900
	public static extern void DumpMemory() { }

	// RVA: 0x257A910 Offset: 0x257AA11 VA: 0x257A910
	public static int GetNexAsyncCallCount() { }

	// RVA: 0x257A980 Offset: 0x257AA81 VA: 0x257A980
	public static void DumpNexAsyncCallList() { }

	// RVA: 0x257A9F0 Offset: 0x257AAF1 VA: 0x257A9F0
	public static int GetAllocedCount() { }

	// RVA: 0x257AA00 Offset: 0x257AB01 VA: 0x257AA00
	public static int GetUsedAllocsize() { }
}

