// Namespace: System
internal static class DateTimeFormat // TypeDefIndex: 225
{
	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static string[] fixedNumberFormats; // 0x10

	// Methods

	// RVA: 0x35B4D80 Offset: 0x35B4E81 VA: 0x35B4D80
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x35B4EB0 Offset: 0x35B4FB1 VA: 0x35B4EB0
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x35B4F80 Offset: 0x35B5081 VA: 0x35B4F80
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x35B5000 Offset: 0x35B5101 VA: 0x35B5000
	internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

	// RVA: 0x35B5070 Offset: 0x35B5171 VA: 0x35B5070
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35B53B0 Offset: 0x35B54B1 VA: 0x35B53B0
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35B5710 Offset: 0x35B5811 VA: 0x35B5710
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35B5A20 Offset: 0x35B5B21 VA: 0x35B5A20
	internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

	// RVA: 0x35B5BD0 Offset: 0x35B5CD1 VA: 0x35B5BD0
	internal static int ParseNextChar(string format, int pos) { }

	// RVA: 0x35B5C10 Offset: 0x35B5D11 VA: 0x35B5C10
	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x35B5D70 Offset: 0x35B5E71 VA: 0x35B5D70
	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x35B7160 Offset: 0x35B7261 VA: 0x35B7160
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x35B74E0 Offset: 0x35B75E1 VA: 0x35B74E0
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x35B7740 Offset: 0x35B7841 VA: 0x35B7740
	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35B8280 Offset: 0x35B8381 VA: 0x35B8280
	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x35B3590 Offset: 0x35B3691 VA: 0x35B3590
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35B8C80 Offset: 0x35B8D81 VA: 0x35B8C80
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x35B8770 Offset: 0x35B8871 VA: 0x35B8770
	internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

	// RVA: 0x35B7730 Offset: 0x35B7831 VA: 0x35B7730
	internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

	// RVA: 0x35B9230 Offset: 0x35B9331 VA: 0x35B9230
	private static void .cctor() { }
}

