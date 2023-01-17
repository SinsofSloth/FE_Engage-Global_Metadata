// Namespace: System.Net
public static class Dns // TypeDefIndex: 2543
{
	// Methods

	// RVA: 0x1AD9660 Offset: 0x1AD9761 VA: 0x1AD9660
	private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x1AD9670 Offset: 0x1AD9771 VA: 0x1AD9670
	private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x1AD9680 Offset: 0x1AD9781 VA: 0x1AD9680
	private static bool GetHostName_internal(out string h_name) { }

	// RVA: 0x1AD9690 Offset: 0x1AD9791 VA: 0x1AD9690
	private static void Error_11001(string hostName) { }

	// RVA: 0x1AD9700 Offset: 0x1AD9801 VA: 0x1AD9700
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x1AD9AF0 Offset: 0x1AD9BF1 VA: 0x1AD9AF0
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x1AD9C70 Offset: 0x1AD9D71 VA: 0x1AD9C70
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x1AD9ED0 Offset: 0x1AD9FD1 VA: 0x1AD9ED0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	[ObsoleteAttribute] // RVA: 0x32440 Offset: 0x32541 VA: 0x32440
	// RVA: 0x1AD9F50 Offset: 0x1ADA051 VA: 0x1AD9F50
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x1ADA050 Offset: 0x1ADA151 VA: 0x1ADA050
	public static string GetHostName() { }
}

