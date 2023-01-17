// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472F20 Offset: 0x473021 VA: 0x472F20
[Serializable]
public class GregorianCalendar : Calendar // TypeDefIndex: 695
{
	// Fields
	internal GregorianCalendarTypes m_type; // 0x1C
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DF20 Offset: 0x47E021 VA: 0x47DF20
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x47DF40 Offset: 0x47E041 VA: 0x47DF40
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	[OnDeserializedAttribute] // RVA: 0x47C440 Offset: 0x47C541 VA: 0x47C440
	// RVA: 0x38B7B20 Offset: 0x38B7C21 VA: 0x38B7B20
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x38B7C40 Offset: 0x38B7D41 VA: 0x38B7C40 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x38B7CB0 Offset: 0x38B7DB1 VA: 0x38B7CB0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x38B7D20 Offset: 0x38B7E21 VA: 0x38B7D20
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x38B7E30 Offset: 0x38B7F31 VA: 0x38B7E30
	public void .ctor() { }

	// RVA: 0x38B7E60 Offset: 0x38B7F61 VA: 0x38B7E60
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x38B7FA0 Offset: 0x38B80A1 VA: 0x38B7FA0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x38B7FB0 Offset: 0x38B80B1 VA: 0x38B7FB0 Slot: 28
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x38B81F0 Offset: 0x38B82F1 VA: 0x38B81F0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x38B8240 Offset: 0x38B8341 VA: 0x38B8240 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x38B82C0 Offset: 0x38B83C1 VA: 0x38B82C0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x38B8580 Offset: 0x38B8681 VA: 0x38B8580 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x38B8590 Offset: 0x38B8691 VA: 0x38B8590 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x38B8600 Offset: 0x38B8701 VA: 0x38B8600 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x38B8650 Offset: 0x38B8751 VA: 0x38B8650 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x38B87D0 Offset: 0x38B88D1 VA: 0x38B87D0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x38B8820 Offset: 0x38B8921 VA: 0x38B8820 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x38B89F0 Offset: 0x38B8AF1 VA: 0x38B89F0 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x38B8A90 Offset: 0x38B8B91 VA: 0x38B8A90 Slot: 22
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x38B8BB0 Offset: 0x38B8CB1 VA: 0x38B8BB0 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x38B8C10 Offset: 0x38B8D11 VA: 0x38B8C10 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x38B8D70 Offset: 0x38B8E71 VA: 0x38B8D70
	private static void .cctor() { }
}

