// Namespace: System.Globalization
internal class CalendarData // TypeDefIndex: 682
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0

	// Methods

	// RVA: 0x3513830 Offset: 0x3513931 VA: 0x3513830
	private void .ctor() { }

	// RVA: 0x3513840 Offset: 0x3513941 VA: 0x3513840
	private static void .cctor() { }

	// RVA: 0x3514DA0 Offset: 0x3514EA1 VA: 0x3514DA0
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x3515520 Offset: 0x3515621 VA: 0x3515520
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x3515A10 Offset: 0x3515B11 VA: 0x3515A10
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x3513290 Offset: 0x3513391 VA: 0x3513290
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x3515D80 Offset: 0x3515E81 VA: 0x3515D80
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x3513820 Offset: 0x3513921 VA: 0x3513820
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x35154E0 Offset: 0x35155E1 VA: 0x35154E0
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x3515E60 Offset: 0x3515F61 VA: 0x3515E60
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}

