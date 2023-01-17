// Namespace: System.Globalization
[Serializable]
internal class GregorianCalendarHelper // TypeDefIndex: 697
{
	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalFieldAttribute] // RVA: 0x478BC0 Offset: 0x478CC1 VA: 0x478BC0
	internal int m_maxYear; // 0x10
	[OptionalFieldAttribute] // RVA: 0x478C00 Offset: 0x478D01 VA: 0x478C00
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalFieldAttribute] // RVA: 0x478C40 Offset: 0x478D41 VA: 0x478C40
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalFieldAttribute] // RVA: 0x478C80 Offset: 0x478D81 VA: 0x478C80
	internal int[] m_eras; // 0x28
	[OptionalFieldAttribute] // RVA: 0x478CC0 Offset: 0x478DC1 VA: 0x478CC0
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x38B8E60 Offset: 0x38B8F61 VA: 0x38B8E60
	internal int get_MaxYear() { }

	// RVA: 0x38B8E70 Offset: 0x38B8F71 VA: 0x38B8E70
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x38B8F20 Offset: 0x38B9021 VA: 0x38B8F20
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x38B9150 Offset: 0x38B9251 VA: 0x38B9150
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x38B9220 Offset: 0x38B9321 VA: 0x38B9220 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x38B9620 Offset: 0x38B9721 VA: 0x38B9620
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x38B9830 Offset: 0x38B9931 VA: 0x38B9830
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x38B98D0 Offset: 0x38B99D1 VA: 0x38B98D0
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x38B9470 Offset: 0x38B9571 VA: 0x38B9470
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x38B9AC0 Offset: 0x38B9BC1 VA: 0x38B9AC0
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x38B9B10 Offset: 0x38B9C11 VA: 0x38B9B10
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x38B9BA0 Offset: 0x38B9CA1 VA: 0x38B9BA0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x38B9D60 Offset: 0x38B9E61 VA: 0x38B9D60
	public int GetEra(DateTime time) { }

	// RVA: 0x38B9E30 Offset: 0x38B9F31 VA: 0x38B9E30
	public int[] get_Eras() { }

	// RVA: 0x38B9F40 Offset: 0x38BA041 VA: 0x38B9F40
	public int GetMonth(DateTime time) { }

	// RVA: 0x38B9F90 Offset: 0x38BA091 VA: 0x38B9F90
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x38B9FB0 Offset: 0x38BA0B1 VA: 0x38B9FB0
	public int GetYear(DateTime time) { }

	// RVA: 0x38BA0A0 Offset: 0x38BA1A1 VA: 0x38BA0A0
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x38BA100 Offset: 0x38BA201 VA: 0x38BA100
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x38BA260 Offset: 0x38BA361 VA: 0x38BA260
	private static void .cctor() { }
}

