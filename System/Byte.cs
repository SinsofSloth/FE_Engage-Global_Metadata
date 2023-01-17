// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FE70 Offset: 0x46FF71 VA: 0x46FE70
[Serializable]
public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 180
{
	// Fields
	private byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x350D1F0 Offset: 0x350D2F1 VA: 0x350D1F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x350D2D0 Offset: 0x350D3D1 VA: 0x350D2D0 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x350D2E0 Offset: 0x350D3E1 VA: 0x350D2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x350D370 Offset: 0x350D471 VA: 0x350D370 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x350D380 Offset: 0x350D481 VA: 0x350D380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x350D390 Offset: 0x350D491 VA: 0x350D390
	public static byte Parse(string s) { }

	// RVA: 0x350D510 Offset: 0x350D611 VA: 0x350D510
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x350D550 Offset: 0x350D651 VA: 0x350D550
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x350D3C0 Offset: 0x350D4C1 VA: 0x350D3C0
	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x350D5A0 Offset: 0x350D6A1 VA: 0x350D5A0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x350D640 Offset: 0x350D741 VA: 0x350D640
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x350D6A0 Offset: 0x350D7A1 VA: 0x350D6A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x350D6E0 Offset: 0x350D7E1 VA: 0x350D6E0
	public string ToString(string format) { }

	// RVA: 0x350D720 Offset: 0x350D821 VA: 0x350D720 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x350D760 Offset: 0x350D861 VA: 0x350D760 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x350D7A0 Offset: 0x350D8A1 VA: 0x350D7A0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x350D7B0 Offset: 0x350D8B1 VA: 0x350D7B0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x350D820 Offset: 0x350D921 VA: 0x350D820 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x350D890 Offset: 0x350D991 VA: 0x350D890 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x350D900 Offset: 0x350DA01 VA: 0x350D900 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x350D910 Offset: 0x350DA11 VA: 0x350D910 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x350D980 Offset: 0x350DA81 VA: 0x350D980 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x350D9F0 Offset: 0x350DAF1 VA: 0x350D9F0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x350DA60 Offset: 0x350DB61 VA: 0x350DA60 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x350DAD0 Offset: 0x350DBD1 VA: 0x350DAD0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x350DB40 Offset: 0x350DC41 VA: 0x350DB40 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x350DBB0 Offset: 0x350DCB1 VA: 0x350DBB0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x350DC20 Offset: 0x350DD21 VA: 0x350DC20 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x350DC90 Offset: 0x350DD91 VA: 0x350DC90 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x350DD00 Offset: 0x350DE01 VA: 0x350DD00 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x350DDE0 Offset: 0x350DEE1 VA: 0x350DDE0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

