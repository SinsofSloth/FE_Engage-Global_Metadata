// Namespace: System.Globalization
internal class CultureData // TypeDefIndex: 716
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal int ILANGUAGE { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x37DC720 Offset: 0x37DC821 VA: 0x37DC720
	private void .ctor(string name) { }

	// RVA: 0x37DC760 Offset: 0x37DC861 VA: 0x37DC760
	public static CultureData get_Invariant() { }

	// RVA: 0x37DCC20 Offset: 0x37DCD21 VA: 0x37DCC20
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x37DCD20 Offset: 0x37DCE21 VA: 0x37DCD20
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x37DCE80 Offset: 0x37DCF81 VA: 0x37DCE80
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x37DCE70 Offset: 0x37DCF71 VA: 0x37DCE70
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x37DCE90 Offset: 0x37DCF91 VA: 0x37DCE90
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x37DCFF0 Offset: 0x37DD0F1 VA: 0x37DCFF0
	internal string[] get_LongTimes() { }

	// RVA: 0x37DD020 Offset: 0x37DD121 VA: 0x37DD020
	internal string[] get_ShortTimes() { }

	// RVA: 0x37DD050 Offset: 0x37DD151 VA: 0x37DD050
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x37DD060 Offset: 0x37DD161 VA: 0x37DD060
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x37DD070 Offset: 0x37DD171 VA: 0x37DD070
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x37DD080 Offset: 0x37DD181 VA: 0x37DD080
	internal string get_SAM1159() { }

	// RVA: 0x37DD090 Offset: 0x37DD191 VA: 0x37DD090
	internal string get_SPM2359() { }

	// RVA: 0x37DD0A0 Offset: 0x37DD1A1 VA: 0x37DD0A0
	internal string get_TimeSeparator() { }

	// RVA: 0x37DD0B0 Offset: 0x37DD1B1 VA: 0x37DD0B0
	internal int[] get_CalendarIds() { }

	// RVA: 0x37DD220 Offset: 0x37DD321 VA: 0x37DD220
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x37DD230 Offset: 0x37DD331 VA: 0x37DD230
	internal string get_CultureName() { }

	// RVA: 0x37DD240 Offset: 0x37DD341 VA: 0x37DD240
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x37DD290 Offset: 0x37DD391 VA: 0x37DD290
	internal string get_STEXTINFO() { }

	// RVA: 0x37DD2A0 Offset: 0x37DD3A1 VA: 0x37DD2A0
	internal int get_ILANGUAGE() { }

	// RVA: 0x37DD2B0 Offset: 0x37DD3B1 VA: 0x37DD2B0
	internal bool get_UseUserOverride() { }

	// RVA: 0x37DD2C0 Offset: 0x37DD3C1 VA: 0x37DD2C0
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x37DD2E0 Offset: 0x37DD3E1 VA: 0x37DD2E0
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x37DD300 Offset: 0x37DD401 VA: 0x37DD300
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x37DD320 Offset: 0x37DD421 VA: 0x37DD320
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x37DD340 Offset: 0x37DD441 VA: 0x37DD340
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x37DD360 Offset: 0x37DD461 VA: 0x37DD360
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x37DD380 Offset: 0x37DD481 VA: 0x37DD380
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x37DD3A0 Offset: 0x37DD4A1 VA: 0x37DD3A0
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x37DD3C0 Offset: 0x37DD4C1 VA: 0x37DD3C0
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x37DD3E0 Offset: 0x37DD4E1 VA: 0x37DD3E0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x37DD400 Offset: 0x37DD501 VA: 0x37DD400
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x37DD420 Offset: 0x37DD521 VA: 0x37DD420
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x37DD440 Offset: 0x37DD541 VA: 0x37DD440
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x37DD460 Offset: 0x37DD561 VA: 0x37DD460
	internal string MonthDay(int calendarId) { }

	// RVA: 0x37DD480 Offset: 0x37DD581 VA: 0x37DD480
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x37DD4F0 Offset: 0x37DD5F1 VA: 0x37DD4F0
	private static string GetDateSeparator(string format) { }

	// RVA: 0x37DD550 Offset: 0x37DD651 VA: 0x37DD550
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x37DD650 Offset: 0x37DD751 VA: 0x37DD650
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x37DD750 Offset: 0x37DD851 VA: 0x37DD750
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x37DD8E0 Offset: 0x37DD9E1 VA: 0x37DD8E0
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x37DD8F0 Offset: 0x37DD9F1 VA: 0x37DD8F0
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x37DD900 Offset: 0x37DDA01 VA: 0x37DD900
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x37DD970 Offset: 0x37DDA71 VA: 0x37DD970
	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }
}

