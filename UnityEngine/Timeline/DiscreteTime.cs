// Namespace: UnityEngine.Timeline
internal struct DiscreteTime : IComparable // TypeDefIndex: 5654
{
	// Fields
	private const double k_Tick = 1E-12;
	public static readonly DiscreteTime kMaxTime; // 0x0
	private readonly long m_DiscreteTime; // 0x0

	// Properties
	public static double tickValue { get; }

	// Methods

	// RVA: 0x36A4560 Offset: 0x36A4661 VA: 0x36A4560
	public static double get_tickValue() { }

	// RVA: 0x36A4580 Offset: 0x36A4681 VA: 0x36A4580
	private void .ctor(long time) { }

	// RVA: 0x36A4590 Offset: 0x36A4691 VA: 0x36A4590
	public void .ctor(double time) { }

	// RVA: 0x36A4750 Offset: 0x36A4851 VA: 0x36A4750
	public void .ctor(int time) { }

	// RVA: 0x36A48E0 Offset: 0x36A49E1 VA: 0x36A48E0
	public DiscreteTime OneTickBefore() { }

	// RVA: 0x36A48F0 Offset: 0x36A49F1 VA: 0x36A48F0
	public DiscreteTime OneTickAfter() { }

	// RVA: 0x36A4900 Offset: 0x36A4A01 VA: 0x36A4900
	public static DiscreteTime FromTicks(long ticks) { }

	// RVA: 0x36A4910 Offset: 0x36A4A11 VA: 0x36A4910 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x36A49B0 Offset: 0x36A4AB1 VA: 0x36A49B0
	public bool Equals(DiscreteTime other) { }

	// RVA: 0x36A49C0 Offset: 0x36A4AC1 VA: 0x36A49C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x36A46A0 Offset: 0x36A47A1 VA: 0x36A46A0
	private static long DoubleToDiscreteTime(double time) { }

	// RVA: 0x36A47D0 Offset: 0x36A48D1 VA: 0x36A47D0
	private static long IntToDiscreteTime(int time) { }

	// RVA: 0x36A4A50 Offset: 0x36A4B51 VA: 0x36A4A50
	private static double ToDouble(long time) { }

	// RVA: 0x36A4A70 Offset: 0x36A4B71 VA: 0x36A4A70
	public static double op_Explicit(DiscreteTime b) { }

	// RVA: 0x36A4AF0 Offset: 0x36A4BF1 VA: 0x36A4AF0
	public static DiscreteTime op_Explicit(double time) { }

	// RVA: 0x36A4B20 Offset: 0x36A4C21 VA: 0x36A4B20
	public static DiscreteTime op_Implicit(int time) { }

	// RVA: 0x36A4B90 Offset: 0x36A4C91 VA: 0x36A4B90
	public static bool op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x36A4BA0 Offset: 0x36A4CA1 VA: 0x36A4BA0
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x36A4C10 Offset: 0x36A4D11 VA: 0x36A4C10
	public static bool op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x36A4C20 Offset: 0x36A4D21 VA: 0x36A4C20
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x36A4C30 Offset: 0x36A4D31 VA: 0x36A4C30
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x36A4C40 Offset: 0x36A4D41 VA: 0x36A4C40 Slot: 3
	public override string ToString() { }

	// RVA: 0x36A4C70 Offset: 0x36A4D71 VA: 0x36A4C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x36A4CA0 Offset: 0x36A4DA1 VA: 0x36A4CA0
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x36A4D20 Offset: 0x36A4E21 VA: 0x36A4D20
	public static long GetNearestTick(double time) { }

	// RVA: 0x36A4E20 Offset: 0x36A4F21 VA: 0x36A4E20
	private static void .cctor() { }
}

