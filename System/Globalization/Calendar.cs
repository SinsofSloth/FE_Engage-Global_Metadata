// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472E00 Offset: 0x472F01 VA: 0x472E00
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 681
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0x478500 Offset: 0x478601 VA: 0x478500
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DEA0 Offset: 0x47DFA1 VA: 0x47DEA0
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x47DEC0 Offset: 0x47DFC1 VA: 0x47DEC0
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x3513020 Offset: 0x3513121 VA: 0x3513020 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x3513090 Offset: 0x3513191 VA: 0x3513090 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x3513100 Offset: 0x3513201 VA: 0x3513100
	protected void .ctor() { }

	// RVA: 0x3513120 Offset: 0x3513221 VA: 0x3513120 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x3513130 Offset: 0x3513231 VA: 0x3513130 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0x47C3D0 Offset: 0x47C4D1 VA: 0x47C3D0
	// RVA: 0x3513140 Offset: 0x3513241 VA: 0x3513140 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x35131D0 Offset: 0x35132D1 VA: 0x35131D0
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x35131E0 Offset: 0x35132E1 VA: 0x35131E0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time);

	// RVA: 0x3513350 Offset: 0x3513451 VA: 0x3513350 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x3513370 Offset: 0x3513471 VA: 0x3513370 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x35134F0 Offset: 0x35135F1 VA: 0x35134F0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x3513580 Offset: 0x3513681 VA: 0x3513580 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x3513600 Offset: 0x3513701 VA: 0x3513600 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x3513690 Offset: 0x3513791 VA: 0x3513690 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x35136A0 Offset: 0x35137A1 VA: 0x35136A0 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x35137B0 Offset: 0x35138B1 VA: 0x35137B0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

