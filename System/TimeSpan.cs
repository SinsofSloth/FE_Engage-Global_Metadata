// Namespace: System
[ComVisibleAttribute] // RVA: 0x470B70 Offset: 0x470C71 VA: 0x470B70
[Serializable]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable // TypeDefIndex: 315
{
	// Fields
	public static readonly TimeSpan Zero; // 0x0
	public static readonly TimeSpan MaxValue; // 0x8
	public static readonly TimeSpan MinValue; // 0x10
	internal long _ticks; // 0x0
	private static bool _legacyConfigChecked; // 0x18
	private static bool _legacyMode; // 0x19

	// Properties
	public long Ticks { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public double TotalHours { get; }
	public double TotalMilliseconds { get; }
	public double TotalMinutes { get; }
	public double TotalSeconds { get; }
	private static bool LegacyMode { get; }

	// Methods

	// RVA: 0x1B17580 Offset: 0x1B17681 VA: 0x1B17580
	public void .ctor(long ticks) { }

	// RVA: 0x1B17590 Offset: 0x1B17691 VA: 0x1B17590
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x1B15050 Offset: 0x1B15151 VA: 0x1B15050
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x1B176D0 Offset: 0x1B177D1 VA: 0x1B176D0
	public long get_Ticks() { }

	// RVA: 0x1B176E0 Offset: 0x1B177E1 VA: 0x1B176E0
	public int get_Hours() { }

	// RVA: 0x1B17730 Offset: 0x1B17831 VA: 0x1B17730
	public int get_Minutes() { }

	// RVA: 0x1B17780 Offset: 0x1B17881 VA: 0x1B17780
	public double get_TotalHours() { }

	// RVA: 0x1B13AB0 Offset: 0x1B13BB1 VA: 0x1B13AB0
	public double get_TotalMilliseconds() { }

	// RVA: 0x1B177B0 Offset: 0x1B178B1 VA: 0x1B177B0
	public double get_TotalMinutes() { }

	// RVA: 0x1B177E0 Offset: 0x1B178E1 VA: 0x1B177E0
	public double get_TotalSeconds() { }

	// RVA: 0x1B17810 Offset: 0x1B17911 VA: 0x1B17810
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x1B17890 Offset: 0x1B17991 VA: 0x1B17890
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B178B0 Offset: 0x1B179B1 VA: 0x1B178B0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1B179A0 Offset: 0x1B17AA1 VA: 0x1B179A0 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x1B179C0 Offset: 0x1B17AC1 VA: 0x1B179C0
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x1B17BB0 Offset: 0x1B17CB1 VA: 0x1B17BB0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B17C40 Offset: 0x1B17D41 VA: 0x1B17C40 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x1B17C50 Offset: 0x1B17D51 VA: 0x1B17C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B17C60 Offset: 0x1B17D61 VA: 0x1B17C60
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x1B17A30 Offset: 0x1B17B31 VA: 0x1B17A30
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x1B17CD0 Offset: 0x1B17DD1 VA: 0x1B17CD0
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x1B17D40 Offset: 0x1B17E41 VA: 0x1B17D40
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x1B17DB0 Offset: 0x1B17EB1 VA: 0x1B17DB0
	public TimeSpan Negate() { }

	// RVA: 0x1B17E90 Offset: 0x1B17F91 VA: 0x1B17E90
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x1B17F00 Offset: 0x1B18001 VA: 0x1B17F00
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0x1B17F80 Offset: 0x1B18081 VA: 0x1B17F80
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x1B17620 Offset: 0x1B17721 VA: 0x1B17620
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x1B17F90 Offset: 0x1B18091 VA: 0x1B17F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B18250 Offset: 0x1B18351 VA: 0x1B18250
	public string ToString(string format) { }

	// RVA: 0x1B182D0 Offset: 0x1B183D1 VA: 0x1B182D0 Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1B184E0 Offset: 0x1B185E1 VA: 0x1B184E0
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18510 Offset: 0x1B18611 VA: 0x1B18510
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18540 Offset: 0x1B18641 VA: 0x1B18540
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18550 Offset: 0x1B18651 VA: 0x1B18550
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18560 Offset: 0x1B18661 VA: 0x1B18560
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18570 Offset: 0x1B18671 VA: 0x1B18570
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18580 Offset: 0x1B18681 VA: 0x1B18580
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B18590 Offset: 0x1B18691 VA: 0x1B18590
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1B185A0 Offset: 0x1B186A1 VA: 0x1B185A0
	private static bool GetLegacyFormatMode() { }

	// RVA: 0x1B183B0 Offset: 0x1B184B1 VA: 0x1B183B0
	private static bool get_LegacyMode() { }

	// RVA: 0x1B185F0 Offset: 0x1B186F1 VA: 0x1B185F0
	private static void .cctor() { }
}

