// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472EC0 Offset: 0x472FC1 VA: 0x472EC0
[Serializable]
public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 688
{
	// Fields
	private static DateTimeFormatInfo invariantInfo; // 0x0
	private CultureData m_cultureData; // 0x10
	[OptionalFieldAttribute] // RVA: 0x478600 Offset: 0x478701 VA: 0x478600
	internal string m_name; // 0x18
	private string m_langName; // 0x20
	private CompareInfo m_compareInfo; // 0x28
	private CultureInfo m_cultureInfo; // 0x30
	internal string amDesignator; // 0x38
	internal string pmDesignator; // 0x40
	[OptionalFieldAttribute] // RVA: 0x478640 Offset: 0x478741 VA: 0x478640
	internal string dateSeparator; // 0x48
	[OptionalFieldAttribute] // RVA: 0x478680 Offset: 0x478781 VA: 0x478680
	internal string generalShortTimePattern; // 0x50
	[OptionalFieldAttribute] // RVA: 0x4786C0 Offset: 0x4787C1 VA: 0x4786C0
	internal string generalLongTimePattern; // 0x58
	[OptionalFieldAttribute] // RVA: 0x478700 Offset: 0x478801 VA: 0x478700
	internal string timeSeparator; // 0x60
	internal string monthDayPattern; // 0x68
	[OptionalFieldAttribute] // RVA: 0x478740 Offset: 0x478841 VA: 0x478740
	internal string dateTimeOffsetPattern; // 0x70
	internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	internal const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	internal const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	internal Calendar calendar; // 0x78
	internal int firstDayOfWeek; // 0x80
	internal int calendarWeekRule; // 0x84
	[OptionalFieldAttribute] // RVA: 0x478780 Offset: 0x478881 VA: 0x478780
	internal string fullDateTimePattern; // 0x88
	internal string[] abbreviatedDayNames; // 0x90
	[OptionalFieldAttribute] // RVA: 0x4787C0 Offset: 0x4788C1 VA: 0x4787C0
	internal string[] m_superShortDayNames; // 0x98
	internal string[] dayNames; // 0xA0
	internal string[] abbreviatedMonthNames; // 0xA8
	internal string[] monthNames; // 0xB0
	[OptionalFieldAttribute] // RVA: 0x478800 Offset: 0x478901 VA: 0x478800
	internal string[] genitiveMonthNames; // 0xB8
	[OptionalFieldAttribute] // RVA: 0x478840 Offset: 0x478941 VA: 0x478840
	internal string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	[OptionalFieldAttribute] // RVA: 0x478880 Offset: 0x478981 VA: 0x478880
	internal string[] leapYearMonthNames; // 0xC8
	internal string longDatePattern; // 0xD0
	internal string shortDatePattern; // 0xD8
	internal string yearMonthPattern; // 0xE0
	internal string longTimePattern; // 0xE8
	internal string shortTimePattern; // 0xF0
	[OptionalFieldAttribute] // RVA: 0x4788C0 Offset: 0x4789C1 VA: 0x4788C0
	private string[] allYearMonthPatterns; // 0xF8
	internal string[] allShortDatePatterns; // 0x100
	internal string[] allLongDatePatterns; // 0x108
	internal string[] allShortTimePatterns; // 0x110
	internal string[] allLongTimePatterns; // 0x118
	internal string[] m_eraNames; // 0x120
	internal string[] m_abbrevEraNames; // 0x128
	internal string[] m_abbrevEnglishEraNames; // 0x130
	internal int[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool m_isReadOnly; // 0x140
	[OptionalFieldAttribute] // RVA: 0x478900 Offset: 0x478A01 VA: 0x478900
	internal DateTimeFormatFlags formatFlags; // 0x144
	internal static bool preferExistingTokens; // 0x8
	[OptionalFieldAttribute] // RVA: 0x478940 Offset: 0x478A41 VA: 0x478940
	private int CultureID; // 0x148
	[OptionalFieldAttribute] // RVA: 0x478980 Offset: 0x478A81 VA: 0x478980
	private bool m_useUserOverride; // 0x14C
	[OptionalFieldAttribute] // RVA: 0x4789C0 Offset: 0x478AC1 VA: 0x4789C0
	private bool bUseCalendarInfo; // 0x14D
	[OptionalFieldAttribute] // RVA: 0x478A00 Offset: 0x478B01 VA: 0x478A00
	private int nDataItem; // 0x150
	[OptionalFieldAttribute] // RVA: 0x478A40 Offset: 0x478B41 VA: 0x478A40
	internal bool m_isDefaultCalendar; // 0x154
	[OptionalFieldAttribute] // RVA: 0x478A80 Offset: 0x478B81 VA: 0x478A80
	private static Hashtable s_calendarNativeNames; // 0x10
	[OptionalFieldAttribute] // RVA: 0x478AC0 Offset: 0x478BC1 VA: 0x478AC0
	internal string[] m_dateWords; // 0x158
	private string m_fullTimeSpanPositivePattern; // 0x160
	private string m_fullTimeSpanNegativePattern; // 0x168
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private TokenHashValue[] m_dtfiTokenHash; // 0x170
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string LocalTimeMark = "T";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x18
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x20

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private int[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; set; }
	public string LongTimePattern { get; set; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; set; }
	public string ShortTimePattern { get; set; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; set; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	[ComVisibleAttribute] // RVA: 0x47DF00 Offset: 0x47E001 VA: 0x47DF00
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x35B95E0 Offset: 0x35B96E1 VA: 0x35B95E0
	private static bool InitPreferExistingTokens() { }

	// RVA: 0x35B95F0 Offset: 0x35B96F1 VA: 0x35B95F0
	private string get_CultureName() { }

	// RVA: 0x35B9640 Offset: 0x35B9741 VA: 0x35B9640
	private CultureInfo get_Culture() { }

	// RVA: 0x35B9710 Offset: 0x35B9811 VA: 0x35B9710
	private string get_LanguageName() { }

	// RVA: 0x35B9760 Offset: 0x35B9861 VA: 0x35B9760
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x35B97E0 Offset: 0x35B98E1 VA: 0x35B97E0
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x35B9860 Offset: 0x35B9961 VA: 0x35B9860
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x35B98E0 Offset: 0x35B99E1 VA: 0x35B98E0
	private string[] internalGetMonthNames() { }

	// RVA: 0x35B9960 Offset: 0x35B9A61 VA: 0x35B9960
	public void .ctor() { }

	// RVA: 0x35B9A40 Offset: 0x35B9B41 VA: 0x35B9A40
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x35B9AA0 Offset: 0x35B9BA1 VA: 0x35B9AA0
	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] // RVA: 0x47C420 Offset: 0x47C521 VA: 0x47C420
	// RVA: 0x35B9C40 Offset: 0x35B9D41 VA: 0x35B9C40
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x47C430 Offset: 0x47C531 VA: 0x47C430
	// RVA: 0x35BA3F0 Offset: 0x35BA4F1 VA: 0x35BA3F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x35B8660 Offset: 0x35B8761 VA: 0x35B8660
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x35B3490 Offset: 0x35B3591 VA: 0x35B3490
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x35B2BC0 Offset: 0x35B2CC1 VA: 0x35B2BC0
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x35BAA90 Offset: 0x35BAB91 VA: 0x35BAA90 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x35B8780 Offset: 0x35B8881 VA: 0x35B8780 Slot: 4
	public object Clone() { }

	// RVA: 0x35BAB40 Offset: 0x35BAC41 VA: 0x35BAB40
	public string get_AMDesignator() { }

	// RVA: 0x35BAB50 Offset: 0x35BAC51 VA: 0x35BAB50
	public Calendar get_Calendar() { }

	// RVA: 0x35B8870 Offset: 0x35B8971 VA: 0x35B8870
	public void set_Calendar(Calendar value) { }

	// RVA: 0x35BAB60 Offset: 0x35BAC61 VA: 0x35BAB60
	private int[] get_OptionalCalendars() { }

	// RVA: 0x35BAC00 Offset: 0x35BAD01 VA: 0x35BAC00
	internal string[] get_EraNames() { }

	// RVA: 0x35B6DC0 Offset: 0x35B6EC1 VA: 0x35B6DC0
	public string GetEraName(int era) { }

	// RVA: 0x35BAC80 Offset: 0x35BAD81 VA: 0x35BAC80
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x35BAD00 Offset: 0x35BAE01 VA: 0x35BAD00
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x35BAE40 Offset: 0x35BAF41 VA: 0x35BAE40
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x35BAEC0 Offset: 0x35BAFC1 VA: 0x35BAEC0
	public string get_DateSeparator() { }

	// RVA: 0x35B7CF0 Offset: 0x35B7DF1 VA: 0x35B7CF0
	public string get_FullDateTimePattern() { }

	// RVA: 0x35B7BA0 Offset: 0x35B7CA1 VA: 0x35B7BA0
	public string get_LongDatePattern() { }

	// RVA: 0x35B9EC0 Offset: 0x35B9FC1 VA: 0x35B9EC0
	public void set_LongDatePattern(string value) { }

	// RVA: 0x35B80E0 Offset: 0x35B81E1 VA: 0x35B80E0
	public string get_LongTimePattern() { }

	// RVA: 0x35BA1D0 Offset: 0x35BA2D1 VA: 0x35BA1D0
	public void set_LongTimePattern(string value) { }

	// RVA: 0x35B7FC0 Offset: 0x35B80C1 VA: 0x35B7FC0
	public string get_MonthDayPattern() { }

	// RVA: 0x35BAFB0 Offset: 0x35BB0B1 VA: 0x35BAFB0
	public string get_PMDesignator() { }

	// RVA: 0x35B8040 Offset: 0x35B8141 VA: 0x35B8040
	public string get_RFC1123Pattern() { }

	// RVA: 0x35B7AF0 Offset: 0x35B7BF1 VA: 0x35B7AF0
	public string get_ShortDatePattern() { }

	// RVA: 0x35B9FC0 Offset: 0x35BA0C1 VA: 0x35B9FC0
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x35B7C50 Offset: 0x35B7D51 VA: 0x35B7C50
	public string get_ShortTimePattern() { }

	// RVA: 0x35BA2F0 Offset: 0x35BA3F1 VA: 0x35BA2F0
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x35B8090 Offset: 0x35B8191 VA: 0x35B8090
	public string get_SortableDateTimePattern() { }

	// RVA: 0x35B7DE0 Offset: 0x35B7EE1 VA: 0x35B7DE0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x35B7ED0 Offset: 0x35B7FD1 VA: 0x35B7ED0
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x35B8F10 Offset: 0x35B9011 VA: 0x35B8F10
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x35BB0A0 Offset: 0x35BB1A1 VA: 0x35BB0A0
	public string get_TimeSeparator() { }

	// RVA: 0x35B8180 Offset: 0x35B8281 VA: 0x35B8180
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x35B81D0 Offset: 0x35B82D1 VA: 0x35B81D0
	public string get_YearMonthPattern() { }

	// RVA: 0x35BA0E0 Offset: 0x35BA1E1 VA: 0x35BA0E0
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x35BB130 Offset: 0x35BB231 VA: 0x35BB130
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x35BB210 Offset: 0x35BB311 VA: 0x35BB210
	public string[] get_DayNames() { }

	// RVA: 0x35BB2F0 Offset: 0x35BB3F1 VA: 0x35BB2F0
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x35BB3D0 Offset: 0x35BB4D1 VA: 0x35BB3D0
	public string[] get_MonthNames() { }

	// RVA: 0x35BB4B0 Offset: 0x35BB5B1 VA: 0x35BB4B0
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x35BB4D0 Offset: 0x35BB5D1 VA: 0x35BB4D0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x35B57C0 Offset: 0x35B58C1 VA: 0x35B57C0
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x35BB4F0 Offset: 0x35BB5F1 VA: 0x35BB4F0
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x35BB5A0 Offset: 0x35BB6A1 VA: 0x35BB5A0
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x35B5090 Offset: 0x35B5191 VA: 0x35B5090
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x35BB620 Offset: 0x35BB721 VA: 0x35BB620
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x35BB7B0 Offset: 0x35BB8B1 VA: 0x35BB7B0
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x35B5220 Offset: 0x35B5321 VA: 0x35B5220
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x35B53D0 Offset: 0x35B54D1 VA: 0x35B53D0
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x35B5570 Offset: 0x35B5671 VA: 0x35B5570
	public string GetMonthName(int month) { }

	// RVA: 0x35BBBC0 Offset: 0x35BBCC1 VA: 0x35BBBC0
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x35BA9D0 Offset: 0x35BAAD1 VA: 0x35BA9D0
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x35BA910 Offset: 0x35BAA11 VA: 0x35BA910
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x35BA7F0 Offset: 0x35BA8F1 VA: 0x35BA7F0
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x35BA730 Offset: 0x35BA831 VA: 0x35BA730
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x35BA610 Offset: 0x35BA711 VA: 0x35BA610
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x35BB0B0 Offset: 0x35BB1B1 VA: 0x35BB0B0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x35BAFC0 Offset: 0x35BB0C1 VA: 0x35BAFC0
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x35BAED0 Offset: 0x35BAFD1 VA: 0x35BAED0
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x35BB040 Offset: 0x35BB141 VA: 0x35BB040
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x35BAF50 Offset: 0x35BB051 VA: 0x35BAF50
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x35BBDF0 Offset: 0x35BBEF1 VA: 0x35BBDF0
	public bool get_IsReadOnly() { }

	// RVA: 0x35BBE00 Offset: 0x35BBF01 VA: 0x35BBE00
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x35BBEE0 Offset: 0x35BBFE1 VA: 0x35BBEE0
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x35BBFE0 Offset: 0x35BC0E1 VA: 0x35BBFE0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x35BC070 Offset: 0x35BC171 VA: 0x35BC070
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x35B3190 Offset: 0x35B3291 VA: 0x35B3190
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x35B6EF0 Offset: 0x35B6FF1 VA: 0x35B6EF0
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x35B7130 Offset: 0x35B7231 VA: 0x35B7130
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x35BC240 Offset: 0x35BC341 VA: 0x35BC240
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x35BC260 Offset: 0x35BC361 VA: 0x35BC260
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x35BC380 Offset: 0x35BC481 VA: 0x35BC380
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x35BC4E0 Offset: 0x35BC5E1 VA: 0x35BC4E0
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x35BABC0 Offset: 0x35BACC1 VA: 0x35BABC0
	private void ClearTokenHashTable() { }

	// RVA: 0x35BC640 Offset: 0x35BC741 VA: 0x35BC640
	internal TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x35BEC70 Offset: 0x35BED71 VA: 0x35BEC70
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x35BEDA0 Offset: 0x35BEEA1 VA: 0x35BEDA0
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x35BEF10 Offset: 0x35BF011 VA: 0x35BEF10
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x35BEF30 Offset: 0x35BF031 VA: 0x35BEF30
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x35BF330 Offset: 0x35BF431 VA: 0x35BF330
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x35BE1A0 Offset: 0x35BE2A1 VA: 0x35BE1A0
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x35BF540 Offset: 0x35BF641 VA: 0x35BF540
	private static void .cctor() { }
}

