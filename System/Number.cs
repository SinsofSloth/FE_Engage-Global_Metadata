// Namespace: System
[FriendAccessAllowedAttribute] // RVA: 0x470700 Offset: 0x470801 VA: 0x470700
internal class Number // TypeDefIndex: 282
{
	// Methods

	// RVA: 0x3856E40 Offset: 0x3856F41 VA: 0x3856E40
	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	// RVA: 0x3856E50 Offset: 0x3856F51 VA: 0x3856E50
	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	// RVA: 0x3856E60 Offset: 0x3856F61 VA: 0x3856E60
	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	// RVA: 0x3856FC0 Offset: 0x38570C1 VA: 0x3856FC0
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x3857160 Offset: 0x3857261 VA: 0x3857160
	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	// RVA: 0x38572F0 Offset: 0x38573F1 VA: 0x38572F0
	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	// RVA: 0x3857480 Offset: 0x3857581 VA: 0x3857480
	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	// RVA: 0x3857610 Offset: 0x3857711 VA: 0x3857610
	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	// RVA: 0x38577A0 Offset: 0x38578A1 VA: 0x38577A0
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x3857940 Offset: 0x3857A41 VA: 0x3857940
	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x3857A90 Offset: 0x3857B91 VA: 0x3857A90
	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x38579F0 Offset: 0x3857AF1 VA: 0x38579F0
	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x3857B40 Offset: 0x3857C41 VA: 0x3857B40
	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x3857BE0 Offset: 0x3857CE1 VA: 0x3857BE0
	private static bool IsWhite(char ch) { }

	// RVA: 0x3857C10 Offset: 0x3857D11 VA: 0x3857C10
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x3857CA0 Offset: 0x3857DA1 VA: 0x3857CA0
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x3857D30 Offset: 0x3857E31 VA: 0x3857D30
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x3857DC0 Offset: 0x3857EC1 VA: 0x3857DC0
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x3857E50 Offset: 0x3857F51 VA: 0x3857E50
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x3857ED0 Offset: 0x3857FD1 VA: 0x3857ED0
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x3857F30 Offset: 0x3858031 VA: 0x3857F30
	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x38581F0 Offset: 0x38582F1 VA: 0x38581F0
	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x3858570 Offset: 0x3858671 VA: 0x3858570
	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x3858790 Offset: 0x3858891 VA: 0x3858790
	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x38589B0 Offset: 0x3858AB1 VA: 0x38589B0
	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x3859390 Offset: 0x3859491 VA: 0x3859390
	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x3859650 Offset: 0x3859751 VA: 0x3859650
	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x3859860 Offset: 0x3859961 VA: 0x3859860
	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x3858080 Offset: 0x3858181 VA: 0x3858080
	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x3859A80 Offset: 0x3859B81 VA: 0x3859A80
	private static bool TrailingZeros(string s, int index) { }

	// RVA: 0x3859AF0 Offset: 0x3859BF1 VA: 0x3859AF0
	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	// RVA: 0x3859C60 Offset: 0x3859D61 VA: 0x3859C60
	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	// RVA: 0x3859DD0 Offset: 0x3859ED1 VA: 0x3859DD0
	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	// RVA: 0x385A040 Offset: 0x385A141 VA: 0x385A040
	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	// RVA: 0x385A2B0 Offset: 0x385A3B1 VA: 0x385A2B0
	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	// RVA: 0x385A450 Offset: 0x385A551 VA: 0x385A450
	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	// RVA: 0x385A6B0 Offset: 0x385A7B1 VA: 0x385A6B0
	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x3858490 Offset: 0x3858591 VA: 0x3858490
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47A910 Offset: 0x47AA11 VA: 0x47A910
	// RVA: 0x385A910 Offset: 0x385AA11 VA: 0x385A910
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }
}

