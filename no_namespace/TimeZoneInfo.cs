// Namespace: 
[TypeForwardedFromAttribute] // RVA: 0x470BE0 Offset: 0x470CE1 VA: 0x470BE0
[Serializable]
public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 317
{
	// Fields
	private DateTime m_dateStart; // 0x10
	private DateTime m_dateEnd; // 0x18
	private TimeSpan m_daylightDelta; // 0x20
	private TimeZoneInfo.TransitionTime m_daylightTransitionStart; // 0x28
	private TimeZoneInfo.TransitionTime m_daylightTransitionEnd; // 0x40
	private TimeSpan m_baseUtcOffsetDelta; // 0x58

	// Properties
	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }

	// Methods

	// RVA: 0x1C09AF0 Offset: 0x1C09BF1 VA: 0x1C09AF0
	public DateTime get_DateStart() { }

	// RVA: 0x1C09B00 Offset: 0x1C09C01 VA: 0x1C09B00
	public DateTime get_DateEnd() { }

	// RVA: 0x1C09B10 Offset: 0x1C09C11 VA: 0x1C09B10
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x1C09B20 Offset: 0x1C09C21 VA: 0x1C09B20
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x1C09B40 Offset: 0x1C09C41 VA: 0x1C09B40
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x1C09B60 Offset: 0x1C09C61 VA: 0x1C09B60 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x1C09F40 Offset: 0x1C0A041 VA: 0x1C09F40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C09F50 Offset: 0x1C0A051 VA: 0x1C09F50
	private void .ctor() { }

	// RVA: 0x1C09F60 Offset: 0x1C0A061 VA: 0x1C09F60
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x1C0A4B0 Offset: 0x1C0A5B1 VA: 0x1C0A4B0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1C0A090 Offset: 0x1C0A191 VA: 0x1C0A090
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x1C0A510 Offset: 0x1C0A611 VA: 0x1C0A510 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1C0A630 Offset: 0x1C0A731 VA: 0x1C0A630 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0A850 Offset: 0x1C0A951 VA: 0x1C0A850
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[TypeForwardedFromAttribute] // RVA: 0x470C20 Offset: 0x470D21 VA: 0x470C20
[Serializable]
public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 318
{
	// Fields
	private DateTime m_timeOfDay; // 0x0
	private byte m_month; // 0x8
	private byte m_week; // 0x9
	private byte m_day; // 0xA
	private DayOfWeek m_dayOfWeek; // 0xC
	private bool m_isFixedDateRule; // 0x10

	// Properties
	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }

	// Methods

	// RVA: 0x1C0ABE0 Offset: 0x1C0ACE1 VA: 0x1C0ABE0
	public DateTime get_TimeOfDay() { }

	// RVA: 0x1C0ABF0 Offset: 0x1C0ACF1 VA: 0x1C0ABF0
	public int get_Month() { }

	// RVA: 0x1C0AC00 Offset: 0x1C0AD01 VA: 0x1C0AC00
	public int get_Week() { }

	// RVA: 0x1C0AC10 Offset: 0x1C0AD11 VA: 0x1C0AC10
	public int get_Day() { }

	// RVA: 0x1C0AC20 Offset: 0x1C0AD21 VA: 0x1C0AC20
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x1C0AC30 Offset: 0x1C0AD31 VA: 0x1C0AC30
	public bool get_IsFixedDateRule() { }

	// RVA: 0x1C0AC40 Offset: 0x1C0AD41 VA: 0x1C0AC40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C0AD90 Offset: 0x1C0AE91 VA: 0x1C0AD90
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x1C09E40 Offset: 0x1C09F41 VA: 0x1C09E40 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x1C0AE90 Offset: 0x1C0AF91 VA: 0x1C0AE90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C0AEA0 Offset: 0x1C0AFA1 VA: 0x1C0AEA0
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x1C0AF90 Offset: 0x1C0B091 VA: 0x1C0AF90
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x1C0AF10 Offset: 0x1C0B011 VA: 0x1C0AF10
	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x1C0B000 Offset: 0x1C0B101 VA: 0x1C0B000
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x1C0B270 Offset: 0x1C0B371 VA: 0x1C0B270 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1C0B370 Offset: 0x1C0B471 VA: 0x1C0B370 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0B530 Offset: 0x1C0B631 VA: 0x1C0B530
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
internal struct TimeZoneInfo.SYSTEMTIME // TypeDefIndex: 319
{
	// Fields
	internal ushort wYear; // 0x0
	internal ushort wMonth; // 0x2
	internal ushort wDayOfWeek; // 0x4
	internal ushort wDay; // 0x6
	internal ushort wHour; // 0x8
	internal ushort wMinute; // 0xA
	internal ushort wSecond; // 0xC
	internal ushort wMilliseconds; // 0xE
}

// Namespace: 
internal struct TimeZoneInfo.TIME_ZONE_INFORMATION // TypeDefIndex: 320
{
	// Fields
	internal int Bias; // 0x0
	internal string StandardName; // 0x8
	internal TimeZoneInfo.SYSTEMTIME StandardDate; // 0x10
	internal int StandardBias; // 0x20
	internal string DaylightName; // 0x28
	internal TimeZoneInfo.SYSTEMTIME DaylightDate; // 0x30
	internal int DaylightBias; // 0x40
}

// Namespace: 
internal struct TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 321
{
	// Fields
	internal TimeZoneInfo.TIME_ZONE_INFORMATION TZI; // 0x0
	internal string TimeZoneKeyName; // 0x48
	internal byte DynamicDaylightTimeDisabled; // 0x50
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x470C60 Offset: 0x470D61 VA: 0x470C60
[Serializable]
private sealed class TimeZoneInfo.<>c // TypeDefIndex: 322
{
	// Fields
	public static readonly TimeZoneInfo.<>c <>9; // 0x0
	public static Comparison<TimeZoneInfo.AdjustmentRule> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x1C09A40 Offset: 0x1C09B41 VA: 0x1C09A40
	private static void .cctor() { }

	// RVA: 0x1C09AB0 Offset: 0x1C09BB1 VA: 0x1C09AB0
	public void .ctor() { }

	// RVA: 0x1C09AC0 Offset: 0x1C09BC1 VA: 0x1C09AC0
	internal int <CreateLocalUnity>b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2) { }
}

