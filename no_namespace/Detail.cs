// Namespace: 
public static class Detail.Utility // TypeDefIndex: 14855
{
	// Methods

	// RVA: 0x1EFA020 Offset: 0x1EFA121 VA: 0x1EFA020
	private static extern bool Utility_AcquireNexUniqueIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA040 Offset: 0x1EFA141 VA: 0x1EFA040
	public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.AcquireNexUniqueIdCB callback) { }

	// RVA: 0x1EFA110 Offset: 0x1EFA211 VA: 0x1EFA110
	private static extern bool Utility_AcquireNexUniqueIdWithPasswordAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA130 Offset: 0x1EFA231 VA: 0x1EFA130
	public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.AcquireNexUniqueIdWithPasswordCB callback) { }

	// RVA: 0x1EFA200 Offset: 0x1EFA301 VA: 0x1EFA200
	private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.Utility.UniqueIdInfoInt pParam, int timeOut) { }

	// RVA: 0x1EFA220 Offset: 0x1EFA321 VA: 0x1EFA220
	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EFA320 Offset: 0x1EFA421 VA: 0x1EFA320
	private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, ref Detail.CppArray pParam, int timeOut) { }

	// RVA: 0x1EFA340 Offset: 0x1EFA441 VA: 0x1EFA340
	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> param, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x1EFA5B0 Offset: 0x1EFA6B1 VA: 0x1EFA5B0
	private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA5D0 Offset: 0x1EFA6D1 VA: 0x1EFA5D0
	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback) { }

	// RVA: 0x1EFA6A0 Offset: 0x1EFA7A1 VA: 0x1EFA6A0
	private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, int timeOut) { }

	// RVA: 0x1EFA6C0 Offset: 0x1EFA7C1 VA: 0x1EFA6C0
	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback) { }

	// RVA: 0x1EFA790 Offset: 0x1EFA891 VA: 0x1EFA790
	private static extern bool Utility_GetIntegerSettingsAsync(uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut) { }

	// RVA: 0x1EFA7B0 Offset: 0x1EFA8B1 VA: 0x1EFA7B0
	public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0, Utility.GetIntegerSettingsCB callback) { }

	// RVA: 0x1EFA890 Offset: 0x1EFA991 VA: 0x1EFA890
	private static void AcquireNexUniqueIdResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFA950 Offset: 0x1EFAA51 VA: 0x1EFA950
	private static void AcquireNexUniqueIdWithPasswordResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAA10 Offset: 0x1EFAB11 VA: 0x1EFAA10
	private static void GetAssociatedNexUniqueIdWithMyPrincipalIdResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAAD0 Offset: 0x1EFABD1 VA: 0x1EFAAD0
	private static void GetAssociatedNexUniqueIdWithMyPrincipalIdListResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAC20 Offset: 0x1EFAD21 VA: 0x1EFAC20
	private static void GetIntegerSettingsResult(ref Detail.AsyncResultInt asyncResult, object callback) { }

	// RVA: 0x1EFAEB0 Offset: 0x1EFAFB1 VA: 0x1EFAEB0
	public static void Callback(Detail.AsyncResultInt res, object callback) { }
}

