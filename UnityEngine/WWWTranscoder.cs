// Namespace: UnityEngine
[VisibleToOtherModulesAttribute] // RVA: 0x6BC40 Offset: 0x6BD41 VA: 0x6BC40
internal class WWWTranscoder // TypeDefIndex: 4439
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x1C4D2A0 Offset: 0x1C4D3A1 VA: 0x1C4D2A0
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x1C4D360 Offset: 0x1C4D461 VA: 0x1C4D360
	private static byte[] Byte2Hex(byte b, byte[] hexChars) { }

	// RVA: 0x1C4D220 Offset: 0x1C4D321 VA: 0x1C4D220
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x1C4D150 Offset: 0x1C4D251 VA: 0x1C4D150
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x1C4D420 Offset: 0x1C4D521 VA: 0x1C4D420
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x1C4D7A0 Offset: 0x1C4D8A1 VA: 0x1C4D7A0
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x1C4D7E0 Offset: 0x1C4D8E1 VA: 0x1C4D7E0
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x1C4DBF0 Offset: 0x1C4DCF1 VA: 0x1C4DBF0
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x1C4D860 Offset: 0x1C4D961 VA: 0x1C4D860
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x1C4D070 Offset: 0x1C4D171 VA: 0x1C4D070
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x1C4DC70 Offset: 0x1C4DD71 VA: 0x1C4DC70
	public static bool SevenBitClean(byte[] input) { }

	// RVA: 0x1C4DCE0 Offset: 0x1C4DDE1 VA: 0x1C4DCE0
	private static void .cctor() { }
}

