// Namespace: System
internal static class DateTimeParse // TypeDefIndex: 230
{
	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x35B2F80 Offset: 0x35B3081 VA: 0x35B2F80
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x35C2150 Offset: 0x35C2251 VA: 0x35C2150
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x35C2AC0 Offset: 0x35C2BC1 VA: 0x35C2AC0
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x35C2BF0 Offset: 0x35C2CF1 VA: 0x35C2BF0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x35C2CD0 Offset: 0x35C2DD1 VA: 0x35C2CD0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x35C2CF0 Offset: 0x35C2DF1 VA: 0x35C2CF0
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x35C2DE0 Offset: 0x35C2EE1 VA: 0x35C2DE0
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x35C3040 Offset: 0x35C3141 VA: 0x35C3040
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x35C31E0 Offset: 0x35C32E1 VA: 0x35C31E0
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x35C4490 Offset: 0x35C4591 VA: 0x35C4490
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x35C4600 Offset: 0x35C4701 VA: 0x35C4600
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x35C48D0 Offset: 0x35C49D1 VA: 0x35C48D0
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x35C4AA0 Offset: 0x35C4BA1 VA: 0x35C4AA0
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x35C4CC0 Offset: 0x35C4DC1 VA: 0x35C4CC0
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x35C4D90 Offset: 0x35C4E91 VA: 0x35C4D90
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x35C4E10 Offset: 0x35C4F11 VA: 0x35C4E10
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x35C4EE0 Offset: 0x35C4FE1 VA: 0x35C4EE0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x35C4FB0 Offset: 0x35C50B1 VA: 0x35C4FB0
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x35C5080 Offset: 0x35C5181 VA: 0x35C5080
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x35C52B0 Offset: 0x35C53B1 VA: 0x35C52B0
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C55A0 Offset: 0x35C56A1 VA: 0x35C55A0
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C59F0 Offset: 0x35C5AF1 VA: 0x35C59F0
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C5D90 Offset: 0x35C5E91 VA: 0x35C5D90
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C5F90 Offset: 0x35C6091 VA: 0x35C5F90
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6330 Offset: 0x35C6431 VA: 0x35C6330
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6660 Offset: 0x35C6761 VA: 0x35C6660
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6830 Offset: 0x35C6931 VA: 0x35C6830
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6A40 Offset: 0x35C6B41 VA: 0x35C6A40
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6B60 Offset: 0x35C6C61 VA: 0x35C6B60
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6C70 Offset: 0x35C6D71 VA: 0x35C6C70
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C6D70 Offset: 0x35C6E71 VA: 0x35C6D70
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x35C6DD0 Offset: 0x35C6ED1 VA: 0x35C6DD0
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x35C6E20 Offset: 0x35C6F21 VA: 0x35C6E20
	private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x35C6EE0 Offset: 0x35C6FE1 VA: 0x35C6EE0
	private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x35C6FA0 Offset: 0x35C70A1 VA: 0x35C6FA0
	private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x35C7070 Offset: 0x35C7171 VA: 0x35C7070
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x35C7130 Offset: 0x35C7231 VA: 0x35C7130
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x35C7220 Offset: 0x35C7321 VA: 0x35C7220
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C74B0 Offset: 0x35C75B1 VA: 0x35C74B0
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x35C75C0 Offset: 0x35C76C1 VA: 0x35C75C0
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35C3F50 Offset: 0x35C4051 VA: 0x35C3F50
	internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35B2DA0 Offset: 0x35B2EA1 VA: 0x35B2DA0
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x35B3A50 Offset: 0x35B3B51 VA: 0x35B3A50
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x35C79F0 Offset: 0x35C7AF1 VA: 0x35C79F0
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x35C8D10 Offset: 0x35C8E11 VA: 0x35C8D10
	private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x35C8FA0 Offset: 0x35C90A1 VA: 0x35C8FA0
	private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x35C9230 Offset: 0x35C9331 VA: 0x35C9230
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x35C9300 Offset: 0x35C9401 VA: 0x35C9300
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x35C8270 Offset: 0x35C8371 VA: 0x35C8270
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x35C96A0 Offset: 0x35C97A1 VA: 0x35C96A0
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x35C94F0 Offset: 0x35C95F1 VA: 0x35C94F0
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x35C9790 Offset: 0x35C9891 VA: 0x35C9790
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x35C9860 Offset: 0x35C9961 VA: 0x35C9860
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x35C99A0 Offset: 0x35C9AA1 VA: 0x35C99A0
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x35C9A20 Offset: 0x35C9B21 VA: 0x35C9A20
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x35C9D00 Offset: 0x35C9E01 VA: 0x35C9D00
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x35C9EF0 Offset: 0x35C9FF1 VA: 0x35C9EF0
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x35CA110 Offset: 0x35CA211 VA: 0x35CA110
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x35CA4B0 Offset: 0x35CA5B1 VA: 0x35CA4B0
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x35CA850 Offset: 0x35CA951 VA: 0x35CA850
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x35CA980 Offset: 0x35CAA81 VA: 0x35CA980
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x35CAA80 Offset: 0x35CAB81 VA: 0x35CAA80
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x35CAB50 Offset: 0x35CAC51 VA: 0x35CAB50
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x35C5120 Offset: 0x35C5221 VA: 0x35C5120
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x35C8A30 Offset: 0x35C8B31 VA: 0x35C8A30
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x35CAC20 Offset: 0x35CAD21 VA: 0x35CAC20
	private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x35CB040 Offset: 0x35CB141 VA: 0x35CB040
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x35CC350 Offset: 0x35CC451 VA: 0x35CC350
	internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x35C2460 Offset: 0x35C2561 VA: 0x35C2460
	private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x35C22C0 Offset: 0x35C23C1 VA: 0x35C22C0
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x35CC440 Offset: 0x35CC541 VA: 0x35CC440
	private static void .cctor() { }
}

