// Namespace: Net
internal static class Nex // TypeDefIndex: 8355
{
	// Fields
	private const uint PluginMemorySize = 1048576;
	private const Common.ThreadMode ThreadMode = 1;
	private const uint GameServerId = 567443968;
	private const string GameServerAccessKey = "a404f53f";
	private const int LoginTimeoutMsec = 30000;
	private const int SearchTimeoutMsec = 0;
	private const int PostTimeoutMsec = 0;
	private const int PostMetaTimeoutMsec = 0;
	private const int CompleteSuspendedPostTimeoutMsec = 0;
	private const int GetTimeoutMsec = 0;
	private const int GetMetaTimeoutMsec = 0;
	private const int GetPersistenceInfoTimeoutMsec = 0;
	private const int UpdateTimeoutMsec = 0;
	private const int ChangeMetaTimeoutMsec = 0;
	private const int RateTimeoutMsec = 0;
	private const int DeleteTimeoutMsec = 0;
	private const int UnperpetuateTimeoutMsec = 0;
	private const uint MaxBatchPost = 16;
	private const uint MaxBatch = 100;
	private const int GetIntegerSettingsTimeoutMsec = 0;
	private const uint MaxIntegerSettingsIndex = 19;
	private const uint MinIntegerSettingsIndex = 0;

	// Methods

	// RVA: 0x2355130 Offset: 0x2355231 VA: 0x2355130
	public static bool IsEnable() { }

	// RVA: 0x2355140 Offset: 0x2355241 VA: 0x2355140
	public static void TryInitialize() { }

	// RVA: 0x23551C0 Offset: 0x23552C1 VA: 0x23551C0
	public static void TryCleanup() { }

	// RVA: 0x2355240 Offset: 0x2355341 VA: 0x2355240
	public static Nex.Result InitializeNexAsync(AsyncResultCB callback) { }

	// RVA: 0x23552F0 Offset: 0x23553F1 VA: 0x23552F0
	public static void CleanupNex() { }

	// RVA: 0x2355390 Offset: 0x2355491 VA: 0x2355390
	public static bool IsInitializedNex() { }

	// RVA: 0x2355430 Offset: 0x2355531 VA: 0x2355430
	public static bool IsNetworkConnected() { }

	// RVA: 0x23554D0 Offset: 0x23555D1 VA: 0x23554D0
	public static int GetAsyncCallCount() { }

	// RVA: 0x2355570 Offset: 0x2355671 VA: 0x2355570
	public static bool IsRunningAutoLogout() { }

	// RVA: 0x2355580 Offset: 0x2355681 VA: 0x2355580
	public static void KeepAliveOn() { }

	// RVA: 0x2355620 Offset: 0x2355721 VA: 0x2355620
	public static void KeepAliveOff() { }
}

