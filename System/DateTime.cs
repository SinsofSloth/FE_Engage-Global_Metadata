// Namespace: System
[Serializable]
public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime> // TypeDefIndex: 196
{
	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] DaysToMonth365; // 0x0
	private static readonly int[] DaysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private ulong dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int DayOfYear { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public static DateTime UtcNow { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x35B0400 Offset: 0x35B0501 VA: 0x35B0400
	public void .ctor(long ticks) { }

	// RVA: 0x35B04A0 Offset: 0x35B05A1 VA: 0x35B04A0
	private void .ctor(ulong dateData) { }

	// RVA: 0x35B04B0 Offset: 0x35B05B1 VA: 0x35B04B0
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x35B05B0 Offset: 0x35B06B1 VA: 0x35B05B0
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x35B0660 Offset: 0x35B0761 VA: 0x35B0660
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x35B08D0 Offset: 0x35B09D1 VA: 0x35B08D0
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x35B0A80 Offset: 0x35B0B81 VA: 0x35B0A80
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x35B0BC0 Offset: 0x35B0CC1 VA: 0x35B0BC0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x35B0DE0 Offset: 0x35B0EE1 VA: 0x35B0DE0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35B10A0 Offset: 0x35B11A1 VA: 0x35B10A0
	internal long get_InternalTicks() { }

	// RVA: 0x35B10B0 Offset: 0x35B11B1 VA: 0x35B10B0
	private ulong get_InternalKind() { }

	// RVA: 0x35B10C0 Offset: 0x35B11C1 VA: 0x35B10C0
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x35B1190 Offset: 0x35B1291 VA: 0x35B1190
	private DateTime Add(double value, int scale) { }

	// RVA: 0x35B1350 Offset: 0x35B1451 VA: 0x35B1350
	public DateTime AddDays(double value) { }

	// RVA: 0x35B1360 Offset: 0x35B1461 VA: 0x35B1360
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x35B1370 Offset: 0x35B1471 VA: 0x35B1370
	public DateTime AddMonths(int months) { }

	// RVA: 0x35B1A10 Offset: 0x35B1B11 VA: 0x35B1A10
	public DateTime AddSeconds(double value) { }

	// RVA: 0x35B10D0 Offset: 0x35B11D1 VA: 0x35B10D0
	public DateTime AddTicks(long value) { }

	// RVA: 0x35B1A20 Offset: 0x35B1B21 VA: 0x35B1A20
	public DateTime AddYears(int value) { }

	// RVA: 0x35B1AB0 Offset: 0x35B1BB1 VA: 0x35B1AB0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x35B1BA0 Offset: 0x35B1CA1 VA: 0x35B1BA0 Slot: 24
	public int CompareTo(DateTime value) { }

	// RVA: 0x35B06F0 Offset: 0x35B07F1 VA: 0x35B06F0
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x35B0990 Offset: 0x35B0A91 VA: 0x35B0990
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x35B18B0 Offset: 0x35B19B1 VA: 0x35B18B0
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x35B1CA0 Offset: 0x35B1DA1 VA: 0x35B1CA0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x35B1D40 Offset: 0x35B1E41 VA: 0x35B1D40 Slot: 25
	public bool Equals(DateTime value) { }

	// RVA: 0x35B1D60 Offset: 0x35B1E61 VA: 0x35B1D60
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x35B1F60 Offset: 0x35B2061 VA: 0x35B1F60
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x35B1FF0 Offset: 0x35B20F1 VA: 0x35B1FF0
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x35B2110 Offset: 0x35B2211 VA: 0x35B2110
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x35B22A0 Offset: 0x35B23A1 VA: 0x35B22A0 Slot: 23
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35B2380 Offset: 0x35B2481 VA: 0x35B2380
	public bool IsDaylightSavingTime() { }

	// RVA: 0x35B2400 Offset: 0x35B2501 VA: 0x35B2400
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x35B2430 Offset: 0x35B2531 VA: 0x35B2430
	public long ToBinary() { }

	// RVA: 0x35B24B0 Offset: 0x35B25B1 VA: 0x35B24B0
	internal long ToBinaryRaw() { }

	// RVA: 0x35B24C0 Offset: 0x35B25C1 VA: 0x35B24C0
	public DateTime get_Date() { }

	// RVA: 0x35B1670 Offset: 0x35B1771 VA: 0x35B1670
	private int GetDatePart(int part) { }

	// RVA: 0x35B2500 Offset: 0x35B2601 VA: 0x35B2500
	public int get_Day() { }

	// RVA: 0x35B2510 Offset: 0x35B2611 VA: 0x35B2510
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x35B2560 Offset: 0x35B2661 VA: 0x35B2560
	public int get_DayOfYear() { }

	// RVA: 0x35B2680 Offset: 0x35B2781 VA: 0x35B2680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x35B2690 Offset: 0x35B2791 VA: 0x35B2690
	public int get_Hour() { }

	// RVA: 0x35B26D0 Offset: 0x35B27D1 VA: 0x35B26D0
	internal bool IsAmbiguousDaylightSavingTime() { }

	// RVA: 0x35B23D0 Offset: 0x35B24D1 VA: 0x35B23D0
	public DateTimeKind get_Kind() { }

	// RVA: 0x35B26F0 Offset: 0x35B27F1 VA: 0x35B26F0
	public int get_Millisecond() { }

	// RVA: 0x35B2740 Offset: 0x35B2841 VA: 0x35B2740
	public int get_Minute() { }

	// RVA: 0x35B2780 Offset: 0x35B2881 VA: 0x35B2780
	public int get_Month() { }

	// RVA: 0x35B2790 Offset: 0x35B2891 VA: 0x35B2790
	public static DateTime get_Now() { }

	// RVA: 0x35B28E0 Offset: 0x35B29E1 VA: 0x35B28E0
	public static DateTime get_UtcNow() { }

	// RVA: 0x35B2950 Offset: 0x35B2A51 VA: 0x35B2950
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x35B2960 Offset: 0x35B2A61 VA: 0x35B2960
	public int get_Second() { }

	// RVA: 0x35B24A0 Offset: 0x35B25A1 VA: 0x35B24A0
	public long get_Ticks() { }

	// RVA: 0x35B29A0 Offset: 0x35B2AA1 VA: 0x35B29A0
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x35B29E0 Offset: 0x35B2AE1 VA: 0x35B29E0
	public int get_Year() { }

	// RVA: 0x35B1BD0 Offset: 0x35B1CD1 VA: 0x35B1BD0
	public static bool IsLeapYear(int year) { }

	// RVA: 0x35B2B10 Offset: 0x35B2C11 VA: 0x35B2B10
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x35B2EC0 Offset: 0x35B2FC1 VA: 0x35B2EC0
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x35B30A0 Offset: 0x35B31A1 VA: 0x35B30A0
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x35B3240 Offset: 0x35B3341 VA: 0x35B3240
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x35B21D0 Offset: 0x35B22D1 VA: 0x35B21D0
	public DateTime ToLocalTime() { }

	// RVA: 0x35B3260 Offset: 0x35B3361 VA: 0x35B3260
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x35B3390 Offset: 0x35B3491 VA: 0x35B3390 Slot: 3
	public override string ToString() { }

	// RVA: 0x35B3620 Offset: 0x35B3721 VA: 0x35B3620
	public string ToString(string format) { }

	// RVA: 0x35B3730 Offset: 0x35B3831 VA: 0x35B3730 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x35B3840 Offset: 0x35B3941 VA: 0x35B3840 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x35B3950 Offset: 0x35B3A51 VA: 0x35B3950
	public DateTime ToUniversalTime() { }

	// RVA: 0x35B3960 Offset: 0x35B3A61 VA: 0x35B3960
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x35B3B80 Offset: 0x35B3C81 VA: 0x35B3B80
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x35B3C30 Offset: 0x35B3D31 VA: 0x35B3C30
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x35B3CE0 Offset: 0x35B3DE1 VA: 0x35B3CE0
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x35B3CF0 Offset: 0x35B3DF1 VA: 0x35B3CF0
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x35B3D00 Offset: 0x35B3E01 VA: 0x35B3D00
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x35B3D10 Offset: 0x35B3E11 VA: 0x35B3D10
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x35B3D30 Offset: 0x35B3E31 VA: 0x35B3D30
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x35B3D50 Offset: 0x35B3E51 VA: 0x35B3D50
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x35B3D70 Offset: 0x35B3E71 VA: 0x35B3D70
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x35B3D90 Offset: 0x35B3E91 VA: 0x35B3D90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x35B3DA0 Offset: 0x35B3EA1 VA: 0x35B3DA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x35B3E80 Offset: 0x35B3F81 VA: 0x35B3E80 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x35B3F60 Offset: 0x35B4061 VA: 0x35B3F60 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x35B4040 Offset: 0x35B4141 VA: 0x35B4040 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x35B4120 Offset: 0x35B4221 VA: 0x35B4120 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x35B4200 Offset: 0x35B4301 VA: 0x35B4200 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x35B42E0 Offset: 0x35B43E1 VA: 0x35B42E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x35B43C0 Offset: 0x35B44C1 VA: 0x35B43C0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x35B44A0 Offset: 0x35B45A1 VA: 0x35B44A0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x35B4580 Offset: 0x35B4681 VA: 0x35B4580 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x35B4660 Offset: 0x35B4761 VA: 0x35B4660 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x35B4740 Offset: 0x35B4841 VA: 0x35B4740 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x35B4820 Offset: 0x35B4921 VA: 0x35B4820 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x35B4900 Offset: 0x35B4A01 VA: 0x35B4900 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x35B4910 Offset: 0x35B4A11 VA: 0x35B4910 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x35B49D0 Offset: 0x35B4AD1 VA: 0x35B49D0
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x35B4C00 Offset: 0x35B4D01 VA: 0x35B4C00
	private static void .cctor() { }
}

