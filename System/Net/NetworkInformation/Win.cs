// Namespace: System.Net.NetworkInformation
internal class Win32IPGlobalProperties : IPGlobalProperties // TypeDefIndex: 2657
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x1955B60 Offset: 0x1955C61 VA: 0x1955B60 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x1955DE0 Offset: 0x1955EE1 VA: 0x1955DE0
	public void .ctor() { }
}

// Namespace: System.Net.NetworkInformation
internal class Win32NetworkInterface // TypeDefIndex: 2658
{
	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x1955DF0 Offset: 0x1955EF1 VA: 0x1955DF0
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x1955B90 Offset: 0x1955C91 VA: 0x1955B90
	public static Win32_FIXED_INFO get_FixedInfo() { }
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_FIXED_INFO // TypeDefIndex: 2659
{
	// Fields
	public string HostName; // 0x0
	public string DomainName; // 0x8
	public IntPtr CurrentDnsServer; // 0x10
	public Win32_IP_ADDR_STRING DnsServerList; // 0x18
	public NetBiosNodeType NodeType; // 0x38
	public string ScopeId; // 0x40
	public uint EnableRouting; // 0x48
	public uint EnableProxy; // 0x4C
	public uint EnableDns; // 0x50
}

// Namespace: System.Net.NetworkInformation
internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 2660
{
	// Fields
	public IntPtr Next; // 0x0
	public string IpAddress; // 0x8
	public string IpMask; // 0x10
	public uint Context; // 0x18
}

