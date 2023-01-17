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
internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 2660
{
	// Fields
	public IntPtr Next; // 0x0
	public string IpAddress; // 0x8
	public string IpMask; // 0x10
	public uint Context; // 0x18
}

