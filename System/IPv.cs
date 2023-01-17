// Namespace: System
internal static class IPv6AddressHelper // TypeDefIndex: 2235
{
	// Methods

	// RVA: 0x1AC0010 Offset: 0x1AC0111 VA: 0x1AC0010
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x1AC0700 Offset: 0x1AC0801 VA: 0x1AC0700
	internal static string CreateCanonicalName(ushort* numbers) { }

	// RVA: 0x1AC0F50 Offset: 0x1AC1051 VA: 0x1AC0F50
	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	// RVA: 0x1AC1120 Offset: 0x1AC1221 VA: 0x1AC1120
	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	// RVA: 0x1AC11B0 Offset: 0x1AC12B1 VA: 0x1AC11B0
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x1AC1590 Offset: 0x1AC1691 VA: 0x1AC1590
	internal static bool IsValid(char* name, int start, ref int end) { }

	// RVA: 0x1AC15A0 Offset: 0x1AC16A1 VA: 0x1AC15A0
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x1AC00E0 Offset: 0x1AC01E1 VA: 0x1AC00E0
	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }
}

