// Namespace: System
internal static class IriHelper // TypeDefIndex: 2214
{
	// Methods

	// RVA: 0x1AC1670 Offset: 0x1AC1771 VA: 0x1AC1670
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x1AC16E0 Offset: 0x1AC17E1 VA: 0x1AC16E0
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x1AC1D20 Offset: 0x1AC1E21 VA: 0x1AC1D20
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x1AC1E90 Offset: 0x1AC1F91 VA: 0x1AC1E90
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }
}

