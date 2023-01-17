// Namespace: System
[ComVisibleAttribute] // RVA: 0x4709B0 Offset: 0x470AB1 VA: 0x4709B0
[Serializable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 302
{
	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3.4028235E+38;
	public const float Epsilon = 1E-45;
	public const float MaxValue = 3.4028235E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = NaN;

	// Methods

	// RVA: 0x38245B0 Offset: 0x38246B1 VA: 0x38245B0
	public static bool IsInfinity(float f) { }

	// RVA: 0x38245D0 Offset: 0x38246D1 VA: 0x38245D0
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x38245F0 Offset: 0x38246F1 VA: 0x38245F0
	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x47AA60 Offset: 0x47AB61 VA: 0x47AA60
	// RVA: 0x3824600 Offset: 0x3824701 VA: 0x3824600
	public static bool IsNaN(float f) { }

	// RVA: 0x3824620 Offset: 0x3824721 VA: 0x3824620 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3824760 Offset: 0x3824861 VA: 0x3824760 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x38247C0 Offset: 0x38248C1 VA: 0x38247C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3824890 Offset: 0x3824991 VA: 0x3824890 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x38248E0 Offset: 0x38249E1 VA: 0x38248E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3824900 Offset: 0x3824A01 VA: 0x3824900 Slot: 3
	public override string ToString() { }

	// RVA: 0x3824940 Offset: 0x3824A41 VA: 0x3824940 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3824980 Offset: 0x3824A81 VA: 0x3824980
	public string ToString(string format) { }

	// RVA: 0x38249C0 Offset: 0x3824AC1 VA: 0x38249C0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x3824A10 Offset: 0x3824B11 VA: 0x3824A10
	public static float Parse(string s) { }

	// RVA: 0x3824A60 Offset: 0x3824B61 VA: 0x3824A60
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x3824AA0 Offset: 0x3824BA1 VA: 0x3824AA0
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x3824A50 Offset: 0x3824B51 VA: 0x3824A50
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x3824B00 Offset: 0x3824C01 VA: 0x3824B00
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x3824C90 Offset: 0x3824D91 VA: 0x3824C90
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x3824B40 Offset: 0x3824C41 VA: 0x3824B40
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x3824D90 Offset: 0x3824E91 VA: 0x3824D90 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3824DA0 Offset: 0x3824EA1 VA: 0x3824DA0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3824E20 Offset: 0x3824F21 VA: 0x3824E20 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3824F00 Offset: 0x3825001 VA: 0x3824F00 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3824F80 Offset: 0x3825081 VA: 0x3824F80 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3825000 Offset: 0x3825101 VA: 0x3825000 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x3825080 Offset: 0x3825181 VA: 0x3825080 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3825100 Offset: 0x3825201 VA: 0x3825100 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3825180 Offset: 0x3825281 VA: 0x3825180 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3825200 Offset: 0x3825301 VA: 0x3825200 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3825280 Offset: 0x3825381 VA: 0x3825280 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3825300 Offset: 0x3825401 VA: 0x3825300 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3825310 Offset: 0x3825411 VA: 0x3825310 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3825390 Offset: 0x3825491 VA: 0x3825390 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3825410 Offset: 0x3825511 VA: 0x3825410 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x38254F0 Offset: 0x38255F1 VA: 0x38254F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

