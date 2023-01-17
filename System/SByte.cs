// Namespace: System
[CLSCompliantAttribute] // RVA: 0x470920 Offset: 0x470A21 VA: 0x470920
[ComVisibleAttribute] // RVA: 0x470920 Offset: 0x470A21 VA: 0x470920
[Serializable]
public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 299
{
	// Fields
	private sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x36080A0 Offset: 0x36081A1 VA: 0x36080A0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x3608180 Offset: 0x3608281 VA: 0x3608180 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x3608190 Offset: 0x3608291 VA: 0x3608190 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3608220 Offset: 0x3608321 VA: 0x3608220 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x3608230 Offset: 0x3608331 VA: 0x3608230 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3608240 Offset: 0x3608341 VA: 0x3608240 Slot: 3
	public override string ToString() { }

	// RVA: 0x3608280 Offset: 0x3608381 VA: 0x3608280 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x36082C0 Offset: 0x36083C1 VA: 0x36082C0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x3608380 Offset: 0x3608481 VA: 0x3608380
	private string ToString(string format, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x47A9E0 Offset: 0x47AAE1 VA: 0x47A9E0
	// RVA: 0x3608430 Offset: 0x3608531 VA: 0x3608430
	public static sbyte Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x47AA00 Offset: 0x47AB01 VA: 0x47AA00
	// RVA: 0x36085C0 Offset: 0x36086C1 VA: 0x36085C0
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AA20 Offset: 0x47AB21 VA: 0x47AA20
	// RVA: 0x3608600 Offset: 0x3608701 VA: 0x3608600
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x3608460 Offset: 0x3608561 VA: 0x3608460
	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x47AA40 Offset: 0x47AB41 VA: 0x47AA40
	// RVA: 0x3608650 Offset: 0x3608751 VA: 0x3608650
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x3608700 Offset: 0x3608801 VA: 0x3608700
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x3608790 Offset: 0x3608891 VA: 0x3608790 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x36087A0 Offset: 0x36088A1 VA: 0x36087A0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3608810 Offset: 0x3608911 VA: 0x3608810 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3608880 Offset: 0x3608981 VA: 0x3608880 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3608890 Offset: 0x3608991 VA: 0x3608890 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3608900 Offset: 0x3608A01 VA: 0x3608900 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x3608970 Offset: 0x3608A71 VA: 0x3608970 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x36089E0 Offset: 0x3608AE1 VA: 0x36089E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x36089F0 Offset: 0x3608AF1 VA: 0x36089F0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3608A60 Offset: 0x3608B61 VA: 0x3608A60 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3608AD0 Offset: 0x3608BD1 VA: 0x3608AD0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3608B40 Offset: 0x3608C41 VA: 0x3608B40 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3608BB0 Offset: 0x3608CB1 VA: 0x3608BB0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3608C20 Offset: 0x3608D21 VA: 0x3608C20 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3608C90 Offset: 0x3608D91 VA: 0x3608C90 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3608D70 Offset: 0x3608E71 VA: 0x3608D70 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

