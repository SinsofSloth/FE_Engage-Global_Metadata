// Namespace: System
[ComVisibleAttribute] // RVA: 0x4700A0 Offset: 0x4701A1 VA: 0x4700A0
[Serializable]
public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double> // TypeDefIndex: 207
{
	// Fields
	internal double m_value; // 0x0
	public const double MinValue = -1.7976931348623157E+308;
	public const double MaxValue = 1.7976931348623157E+308;
	public const double Epsilon = 5E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = NaN;
	internal static double NegativeZero; // 0x0

	// Methods

	// RVA: 0x372A6E0 Offset: 0x372A7E1 VA: 0x372A6E0
	public static bool IsInfinity(double d) { }

	// RVA: 0x372A700 Offset: 0x372A801 VA: 0x372A700
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x372A720 Offset: 0x372A821 VA: 0x372A720
	public static bool IsNegativeInfinity(double d) { }

	// RVA: 0x372A740 Offset: 0x372A841 VA: 0x372A740
	internal static bool IsNegative(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x47A420 Offset: 0x47A521 VA: 0x47A420
	// RVA: 0x372A750 Offset: 0x372A851 VA: 0x372A750
	public static bool IsNaN(double d) { }

	// RVA: 0x372A770 Offset: 0x372A871 VA: 0x372A770 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x372A8C0 Offset: 0x372A9C1 VA: 0x372A8C0 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x372A9C0 Offset: 0x372AAC1 VA: 0x372A9C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x372AAB0 Offset: 0x372ABB1 VA: 0x372AAB0 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x372AB90 Offset: 0x372AC91 VA: 0x372AB90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x372ABB0 Offset: 0x372ACB1 VA: 0x372ABB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x372ABF0 Offset: 0x372ACF1 VA: 0x372ABF0
	public string ToString(string format) { }

	// RVA: 0x372AC30 Offset: 0x372AD31 VA: 0x372AC30 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x372AC70 Offset: 0x372AD71 VA: 0x372AC70 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x372ACC0 Offset: 0x372ADC1 VA: 0x372ACC0
	public static double Parse(string s) { }

	// RVA: 0x372AD50 Offset: 0x372AE51 VA: 0x372AD50
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x372ADE0 Offset: 0x372AEE1 VA: 0x372ADE0
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x372AD40 Offset: 0x372AE41 VA: 0x372AD40
	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x372AE80 Offset: 0x372AF81 VA: 0x372AE80
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x372B080 Offset: 0x372B181 VA: 0x372B080
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x372AFB0 Offset: 0x372B0B1 VA: 0x372AFB0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x372B1B0 Offset: 0x372B2B1 VA: 0x372B1B0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x372B1C0 Offset: 0x372B2C1 VA: 0x372B1C0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x372B240 Offset: 0x372B341 VA: 0x372B240 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x372B320 Offset: 0x372B421 VA: 0x372B320 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x372B3A0 Offset: 0x372B4A1 VA: 0x372B3A0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x372B420 Offset: 0x372B521 VA: 0x372B420 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x372B4A0 Offset: 0x372B5A1 VA: 0x372B4A0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x372B520 Offset: 0x372B621 VA: 0x372B520 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x372B5A0 Offset: 0x372B6A1 VA: 0x372B5A0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x372B620 Offset: 0x372B721 VA: 0x372B620 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x372B6A0 Offset: 0x372B7A1 VA: 0x372B6A0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x372B720 Offset: 0x372B821 VA: 0x372B720 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x372B7A0 Offset: 0x372B8A1 VA: 0x372B7A0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x372B7B0 Offset: 0x372B8B1 VA: 0x372B7B0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x372B830 Offset: 0x372B931 VA: 0x372B830 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x372B910 Offset: 0x372BA11 VA: 0x372B910 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x372B9D0 Offset: 0x372BAD1 VA: 0x372B9D0
	private static void .cctor() { }
}

