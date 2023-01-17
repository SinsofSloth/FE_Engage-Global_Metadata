// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472F60 Offset: 0x473061 VA: 0x472F60
[Serializable]
public class JapaneseCalendar : Calendar // TypeDefIndex: 705
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DF60 Offset: 0x47E061 VA: 0x47DF60
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x47DF80 Offset: 0x47E081 VA: 0x47DF80
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x3413660 Offset: 0x3413761 VA: 0x3413660 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x34136D0 Offset: 0x34137D1 VA: 0x34136D0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x3413740 Offset: 0x3413841 VA: 0x3413740
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x3413B80 Offset: 0x3413C81 VA: 0x3413B80
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x3413B90 Offset: 0x3413C91 VA: 0x3413B90
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x3413C90 Offset: 0x3413D91 VA: 0x3413C90
	public void .ctor() { }

	// RVA: 0x3413E50 Offset: 0x3413F51 VA: 0x3413E50 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x3413E60 Offset: 0x3413F61 VA: 0x3413E60 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x3413E70 Offset: 0x3413F71 VA: 0x3413E70 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x3413E80 Offset: 0x3413F81 VA: 0x3413E80 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x3413E90 Offset: 0x3413F91 VA: 0x3413E90 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x3413EA0 Offset: 0x3413FA1 VA: 0x3413EA0 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x3413EB0 Offset: 0x3413FB1 VA: 0x3413EB0 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x3413EC0 Offset: 0x3413FC1 VA: 0x3413EC0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x3413ED0 Offset: 0x3413FD1 VA: 0x3413ED0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x3413EE0 Offset: 0x3413FE1 VA: 0x3413EE0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x3413F00 Offset: 0x3414001 VA: 0x3413F00 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x3414070 Offset: 0x3414171 VA: 0x3414070 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x3414080 Offset: 0x3414181 VA: 0x3414080
	internal static string[] EraNames() { }

	// RVA: 0x34141C0 Offset: 0x34142C1 VA: 0x34141C0
	internal static string[] AbbrevEraNames() { }

	// RVA: 0x3414300 Offset: 0x3414401 VA: 0x3414300
	internal static string[] EnglishEraNames() { }

	// RVA: 0x3414440 Offset: 0x3414541 VA: 0x3414440 Slot: 23
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x3414450 Offset: 0x3414551 VA: 0x3414450 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x34144B0 Offset: 0x34145B1 VA: 0x34144B0
	private static void .cctor() { }
}

