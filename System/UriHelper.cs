// Namespace: System
internal static class UriHelper // TypeDefIndex: 2228
{
	// Fields
	private static readonly char[] HexUpperChars; // 0x0

	// Methods

	// RVA: 0x19428F0 Offset: 0x19429F1 VA: 0x19428F0
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x1942F40 Offset: 0x1943041 VA: 0x1942F40
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x1943550 Offset: 0x1943651 VA: 0x1943550
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1943640 Offset: 0x1943741 VA: 0x1943640
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1944340 Offset: 0x1944441 VA: 0x1944340
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x1943060 Offset: 0x1943161 VA: 0x1943060
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x1943190 Offset: 0x1943291 VA: 0x1943190
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x19442B0 Offset: 0x19443B1 VA: 0x19442B0
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x19433B0 Offset: 0x19434B1 VA: 0x19433B0
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x1943250 Offset: 0x1943351 VA: 0x1943250
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x1944920 Offset: 0x1944A21 VA: 0x1944920
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x19449F0 Offset: 0x1944AF1 VA: 0x19449F0
	private static void .cctor() { }
}

