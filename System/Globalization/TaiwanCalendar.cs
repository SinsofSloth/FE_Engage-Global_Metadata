// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472FE0 Offset: 0x4730E1 VA: 0x472FE0
[Serializable]
public class TaiwanCalendar : Calendar // TypeDefIndex: 709
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DFA0 Offset: 0x47E0A1 VA: 0x47DFA0
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x47DFC0 Offset: 0x47E0C1 VA: 0x47DFC0
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x365EBA0 Offset: 0x365ECA1 VA: 0x365EBA0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x365EE60 Offset: 0x365EF61 VA: 0x365EE60 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x365EED0 Offset: 0x365EFD1 VA: 0x365EED0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x365ECA0 Offset: 0x365EDA1 VA: 0x365ECA0
	public void .ctor() { }

	// RVA: 0x365EF40 Offset: 0x365F041 VA: 0x365EF40 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x365EF50 Offset: 0x365F051 VA: 0x365EF50 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x365EF60 Offset: 0x365F061 VA: 0x365EF60 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x365EF70 Offset: 0x365F071 VA: 0x365EF70 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x365EF80 Offset: 0x365F081 VA: 0x365EF80 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x365EF90 Offset: 0x365F091 VA: 0x365EF90 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x365EFA0 Offset: 0x365F0A1 VA: 0x365EFA0 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x365EFB0 Offset: 0x365F0B1 VA: 0x365EFB0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x365EFC0 Offset: 0x365F0C1 VA: 0x365EFC0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x365EFD0 Offset: 0x365F0D1 VA: 0x365EFD0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x365EFF0 Offset: 0x365F0F1 VA: 0x365EFF0 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x365F000 Offset: 0x365F101 VA: 0x365F000 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x365F060 Offset: 0x365F161 VA: 0x365F060 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x365F1D0 Offset: 0x365F2D1 VA: 0x365F1D0
	private static void .cctor() { }
}

