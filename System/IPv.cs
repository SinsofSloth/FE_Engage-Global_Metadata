// Namespace: System
internal static class IPv4AddressHelper // TypeDefIndex: 2234
{
	// Methods

	// RVA: 0x1ABEBF0 Offset: 0x1ABECF1 VA: 0x1ABEBF0
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x1ABEFC0 Offset: 0x1ABF0C1 VA: 0x1ABEFC0
	internal static int ParseHostNumber(string str, int start, int end) { }

	// RVA: 0x1ABF1D0 Offset: 0x1ABF2D1 VA: 0x1ABF1D0
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x1ABF210 Offset: 0x1ABF311 VA: 0x1ABF210
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x1ABF4F0 Offset: 0x1ABF5F1 VA: 0x1ABF4F0
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x1ABEF40 Offset: 0x1ABF041 VA: 0x1ABEF40
	private static bool Parse(string name, byte* numbers, int start, int end) { }

	// RVA: 0x1ABF000 Offset: 0x1ABF101 VA: 0x1ABF000
	private static bool ParseCanonical(string name, byte* numbers, int start, int end) { }
}

