// Namespace: System
[ComVisibleAttribute] // RVA: 0x470030 Offset: 0x470131 VA: 0x470030
[Serializable]
public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<Decimal>, IEquatable<Decimal> // TypeDefIndex: 201
{
	// Fields
	private const int SignMask = -2147483648;
	private const byte DECIMAL_NEG = 128;
	private const byte DECIMAL_ADD = 0;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	private const int MaxInt32Scale = 9;
	private static uint[] Powers10; // 0x0
	[DecimalConstantAttribute] // RVA: 0x477F00 Offset: 0x478001 VA: 0x477F00
	public static readonly Decimal Zero; // 0x8
	[DecimalConstantAttribute] // RVA: 0x477F30 Offset: 0x478031 VA: 0x477F30
	public static readonly Decimal One; // 0x18
	[DecimalConstantAttribute] // RVA: 0x477F60 Offset: 0x478061 VA: 0x477F60
	public static readonly Decimal MinusOne; // 0x28
	[DecimalConstantAttribute] // RVA: 0x477F90 Offset: 0x478091 VA: 0x477F90
	public static readonly Decimal MaxValue; // 0x38
	[DecimalConstantAttribute] // RVA: 0x477FC0 Offset: 0x4780C1 VA: 0x477FC0
	public static readonly Decimal MinValue; // 0x48
	[DecimalConstantAttribute] // RVA: 0x477FF0 Offset: 0x4780F1 VA: 0x477FF0
	private static readonly Decimal NearNegativeZero; // 0x58
	[DecimalConstantAttribute] // RVA: 0x478020 Offset: 0x478121 VA: 0x478020
	private static readonly Decimal NearPositiveZero; // 0x68
	private int flags; // 0x0
	private int hi; // 0x4
	private int lo; // 0x8
	private int mid; // 0xC

	// Methods

	// RVA: 0x371A460 Offset: 0x371A561 VA: 0x371A460
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47A290 Offset: 0x47A391 VA: 0x47A290
	// RVA: 0x371A490 Offset: 0x371A591 VA: 0x371A490
	public void .ctor(uint value) { }

	// RVA: 0x371A4A0 Offset: 0x371A5A1 VA: 0x371A4A0
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A2B0 Offset: 0x47A3B1 VA: 0x47A2B0
	// RVA: 0x371A4D0 Offset: 0x371A5D1 VA: 0x371A4D0
	public void .ctor(ulong value) { }

	// RVA: 0x371A4E0 Offset: 0x371A5E1 VA: 0x371A4E0
	public void .ctor(float value) { }

	// RVA: 0x371A4F0 Offset: 0x371A5F1 VA: 0x371A4F0
	public void .ctor(double value) { }

	// RVA: 0x371A500 Offset: 0x371A601 VA: 0x371A500
	public void .ctor(int[] bits) { }

	// RVA: 0x371A620 Offset: 0x371A721 VA: 0x371A620
	private void SetBits(int[] bits) { }

	// RVA: 0x371A740 Offset: 0x371A841 VA: 0x371A740
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[OnSerializingAttribute] // RVA: 0x47A2D0 Offset: 0x47A3D1 VA: 0x47A2D0
	// RVA: 0x371A7F0 Offset: 0x371A8F1 VA: 0x371A7F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x371A9E0 Offset: 0x371AAE1 VA: 0x371A9E0 Slot: 23
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x371AB30 Offset: 0x371AC31 VA: 0x371AB30
	private void .ctor(int lo, int mid, int hi, int flags) { }

	// RVA: 0x371ABC0 Offset: 0x371ACC1 VA: 0x371ABC0
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x371AC40 Offset: 0x371AD41 VA: 0x371AC40
	private static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign) { }

	[ReliabilityContractAttribute] // RVA: 0x47A2E0 Offset: 0x47A3E1 VA: 0x47A2E0
	// RVA: 0x371AC50 Offset: 0x371AD51 VA: 0x371AC50
	private static int FCallCompare(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x371AC60 Offset: 0x371AD61 VA: 0x371AC60 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x371AD60 Offset: 0x371AE61 VA: 0x371AD60 Slot: 24
	public int CompareTo(Decimal value) { }

	// RVA: 0x371ADE0 Offset: 0x371AEE1 VA: 0x371ADE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x371AEA0 Offset: 0x371AFA1 VA: 0x371AEA0 Slot: 25
	public bool Equals(Decimal value) { }

	// RVA: 0x371AF30 Offset: 0x371B031 VA: 0x371AF30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x371AF40 Offset: 0x371B041 VA: 0x371AF40 Slot: 3
	public override string ToString() { }

	// RVA: 0x371AF80 Offset: 0x371B081 VA: 0x371AF80 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x371AFC0 Offset: 0x371B0C1 VA: 0x371AFC0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x371B010 Offset: 0x371B111 VA: 0x371B010
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x371B050 Offset: 0x371B151 VA: 0x371B050
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x371B0B0 Offset: 0x371B1B1 VA: 0x371B0B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x371A940 Offset: 0x371AA41 VA: 0x371A940
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x371B110 Offset: 0x371B211 VA: 0x371B110
	internal static Decimal ToDecimal(byte[] buffer) { }

	// RVA: 0x371B2A0 Offset: 0x371B3A1 VA: 0x371B2A0
	private static void FCallMultiply(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x371B2B0 Offset: 0x371B3B1 VA: 0x371B2B0
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x371B330 Offset: 0x371B431 VA: 0x371B330
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x371B3B0 Offset: 0x371B4B1 VA: 0x371B3B0
	private static void FCallRound(ref Decimal d, int decimals) { }

	// RVA: 0x371B3C0 Offset: 0x371B4C1 VA: 0x371B3C0
	public static byte ToByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x47A300 Offset: 0x47A401 VA: 0x47A300
	// RVA: 0x371B660 Offset: 0x371B761 VA: 0x371B660
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x371B900 Offset: 0x371BA01 VA: 0x371B900
	public static short ToInt16(Decimal value) { }

	// RVA: 0x371BAA0 Offset: 0x371BBA1 VA: 0x371BAA0
	public static double ToDouble(Decimal d) { }

	// RVA: 0x371BAB0 Offset: 0x371BBB1 VA: 0x371BAB0
	internal static int FCallToInt32(Decimal d) { }

	// RVA: 0x371B800 Offset: 0x371B901 VA: 0x371B800
	public static int ToInt32(Decimal d) { }

	// RVA: 0x371BAD0 Offset: 0x371BBD1 VA: 0x371BAD0
	public static long ToInt64(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x47A320 Offset: 0x47A421 VA: 0x47A320
	// RVA: 0x371BBD0 Offset: 0x371BCD1 VA: 0x371BBD0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x47A340 Offset: 0x47A441 VA: 0x47A340
	// RVA: 0x371B560 Offset: 0x371B661 VA: 0x371B560
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliantAttribute] // RVA: 0x47A360 Offset: 0x47A461 VA: 0x47A360
	// RVA: 0x371BD70 Offset: 0x371BE71 VA: 0x371BD70
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x371BE60 Offset: 0x371BF61 VA: 0x371BE60
	public static float ToSingle(Decimal d) { }

	// RVA: 0x371BE70 Offset: 0x371BF71 VA: 0x371BE70
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x371BAC0 Offset: 0x371BBC1 VA: 0x371BAC0
	private static void FCallTruncate(ref Decimal d) { }

	// RVA: 0x371BEE0 Offset: 0x371BFE1 VA: 0x371BEE0
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x47A380 Offset: 0x47A481 VA: 0x47A380
	// RVA: 0x371BEF0 Offset: 0x371BFF1 VA: 0x371BEF0
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x371BF10 Offset: 0x371C011 VA: 0x371BF10
	public static Decimal op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x47A3A0 Offset: 0x47A4A1 VA: 0x47A3A0
	// RVA: 0x371BF30 Offset: 0x371C031 VA: 0x371BF30
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x371BF40 Offset: 0x371C041 VA: 0x371BF40
	public static Decimal op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47A3C0 Offset: 0x47A4C1 VA: 0x47A3C0
	// RVA: 0x371BF60 Offset: 0x371C061 VA: 0x371BF60
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x371BF70 Offset: 0x371C071 VA: 0x371BF70
	public static Decimal op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A3E0 Offset: 0x47A4E1 VA: 0x47A3E0
	// RVA: 0x371BF90 Offset: 0x371C091 VA: 0x371BF90
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x371BFA0 Offset: 0x371C0A1 VA: 0x371BFA0
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x371BFD0 Offset: 0x371C0D1 VA: 0x371BFD0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x371C000 Offset: 0x371C101 VA: 0x371C000
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x371C070 Offset: 0x371C171 VA: 0x371C070
	public static long op_Explicit(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x47A400 Offset: 0x47A501 VA: 0x47A400
	// RVA: 0x371C0E0 Offset: 0x371C1E1 VA: 0x371C0E0
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x371C150 Offset: 0x371C251 VA: 0x371C150
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x371C1C0 Offset: 0x371C2C1 VA: 0x371C1C0
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x371C230 Offset: 0x371C331 VA: 0x371C230
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x371C300 Offset: 0x371C401 VA: 0x371C300
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x371C380 Offset: 0x371C481 VA: 0x371C380
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x371C400 Offset: 0x371C501 VA: 0x371C400
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x371C480 Offset: 0x371C581 VA: 0x371C480
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x371C500 Offset: 0x371C601 VA: 0x371C500
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x371C580 Offset: 0x371C681 VA: 0x371C580
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x371C600 Offset: 0x371C701 VA: 0x371C600
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x371C680 Offset: 0x371C781 VA: 0x371C680
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x371C700 Offset: 0x371C801 VA: 0x371C700
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x371C780 Offset: 0x371C881 VA: 0x371C780 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x371C790 Offset: 0x371C891 VA: 0x371C790 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x371C810 Offset: 0x371C911 VA: 0x371C810 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x371C8F0 Offset: 0x371C9F1 VA: 0x371C8F0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x371C970 Offset: 0x371CA71 VA: 0x371C970 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x371C9F0 Offset: 0x371CAF1 VA: 0x371C9F0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x371CA70 Offset: 0x371CB71 VA: 0x371CA70 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x371CAF0 Offset: 0x371CBF1 VA: 0x371CAF0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x371CB70 Offset: 0x371CC71 VA: 0x371CB70 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x371CBF0 Offset: 0x371CCF1 VA: 0x371CBF0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x371CC70 Offset: 0x371CD71 VA: 0x371CC70 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x371CCF0 Offset: 0x371CDF1 VA: 0x371CCF0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x371CD70 Offset: 0x371CE71 VA: 0x371CD70 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x371CDF0 Offset: 0x371CEF1 VA: 0x371CDF0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x371CE00 Offset: 0x371CF01 VA: 0x371CE00 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x371CEE0 Offset: 0x371CFE1 VA: 0x371CEE0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x371CFA0 Offset: 0x371D0A1 VA: 0x371CFA0
	private static void .cctor() { }
}

