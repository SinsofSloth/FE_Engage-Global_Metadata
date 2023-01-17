// Namespace: System.Net
internal static class NclUtilities // TypeDefIndex: 2465
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x1ACE520 Offset: 0x1ACE621 VA: 0x1ACE520
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1ACEB00 Offset: 0x1ACEC01 VA: 0x1ACEB00
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x1ACE5C0 Offset: 0x1ACE6C1 VA: 0x1ACE5C0
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1ACEB20 Offset: 0x1ACEC21 VA: 0x1ACEB20
	private static object get_LocalAddressesLock() { }
}

