// Namespace: NexPlugin
public static class Utility // TypeDefIndex: 15023
{
	// Methods

	// RVA: 0x2A3ECC0 Offset: 0x2A3EDC1 VA: 0x2A3ECC0
	public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.AcquireNexUniqueIdCB callback) { }

	// RVA: 0x2A3ECD0 Offset: 0x2A3EDD1 VA: 0x2A3ECD0
	public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.AcquireNexUniqueIdWithPasswordCB callback) { }

	// RVA: 0x2A3ECE0 Offset: 0x2A3EDE1 VA: 0x2A3ECE0
	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo uniqueIdInfo, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x2A3ECF0 Offset: 0x2A3EDF1 VA: 0x2A3ECF0
	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> uniqueIdInfo, int timeOut = 0, AsyncResultCB callback) { }

	// RVA: 0x2A3ED00 Offset: 0x2A3EE01 VA: 0x2A3ED00
	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback) { }

	// RVA: 0x2A3ED10 Offset: 0x2A3EE11 VA: 0x2A3ED10
	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback) { }

	// RVA: 0x2A3ED20 Offset: 0x2A3EE21 VA: 0x2A3ED20
	public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0, Utility.GetIntegerSettingsCB callback) { }

	// RVA: 0x2A3ED30 Offset: 0x2A3EE31 VA: 0x2A3ED30
	public static extern bool IsValidNexUniqueId(ulong nexUniqueId) { }
}

