// Namespace: System
[ComVisibleAttribute] // RVA: 0x470470 Offset: 0x470571 VA: 0x470470
[Serializable]
public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 258
{
	// Fields
	internal short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x340E990 Offset: 0x340EA91 VA: 0x340E990 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x340EA70 Offset: 0x340EB71 VA: 0x340EA70 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x340EA80 Offset: 0x340EB81 VA: 0x340EA80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x340EB10 Offset: 0x340EC11 VA: 0x340EB10 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x340EB20 Offset: 0x340EC21 VA: 0x340EB20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x340EB30 Offset: 0x340EC31 VA: 0x340EB30 Slot: 3
	public override string ToString() { }

	// RVA: 0x340EB70 Offset: 0x340EC71 VA: 0x340EB70 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x340EBB0 Offset: 0x340ECB1 VA: 0x340EBB0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x340EC70 Offset: 0x340ED71 VA: 0x340EC70
	private string ToString(string format, NumberFormatInfo info) { }

	// RVA: 0x340ED20 Offset: 0x340EE21 VA: 0x340ED20
	public static short Parse(string s) { }

	// RVA: 0x340EEB0 Offset: 0x340EFB1 VA: 0x340EEB0
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x340EEF0 Offset: 0x340EFF1 VA: 0x340EEF0
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x340ED50 Offset: 0x340EE51 VA: 0x340ED50
	private static short Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x340EF40 Offset: 0x340F041 VA: 0x340EF40
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x340EFF0 Offset: 0x340F0F1 VA: 0x340EFF0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0x340F080 Offset: 0x340F181 VA: 0x340F080 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x340F090 Offset: 0x340F191 VA: 0x340F090 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x340F100 Offset: 0x340F201 VA: 0x340F100 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x340F170 Offset: 0x340F271 VA: 0x340F170 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x340F1E0 Offset: 0x340F2E1 VA: 0x340F1E0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x340F250 Offset: 0x340F351 VA: 0x340F250 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x340F260 Offset: 0x340F361 VA: 0x340F260 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x340F2D0 Offset: 0x340F3D1 VA: 0x340F2D0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x340F340 Offset: 0x340F441 VA: 0x340F340 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x340F3B0 Offset: 0x340F4B1 VA: 0x340F3B0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x340F420 Offset: 0x340F521 VA: 0x340F420 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x340F490 Offset: 0x340F591 VA: 0x340F490 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x340F500 Offset: 0x340F601 VA: 0x340F500 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x340F570 Offset: 0x340F671 VA: 0x340F570 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x340F5E0 Offset: 0x340F6E1 VA: 0x340F5E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x340F700 Offset: 0x340F801 VA: 0x340F700 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[ComVisibleAttribute] // RVA: 0x4704B0 Offset: 0x4705B1 VA: 0x4704B0
[Serializable]
public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 260
{
	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x3410360 Offset: 0x3410461 VA: 0x3410360 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3410460 Offset: 0x3410561 VA: 0x3410460 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x3410480 Offset: 0x3410581 VA: 0x3410480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3410510 Offset: 0x3410611 VA: 0x3410510 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x3410520 Offset: 0x3410621 VA: 0x3410520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3410530 Offset: 0x3410631 VA: 0x3410530 Slot: 3
	public override string ToString() { }

	// RVA: 0x3410570 Offset: 0x3410671 VA: 0x3410570 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x34105B0 Offset: 0x34106B1 VA: 0x34105B0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x34105F0 Offset: 0x34106F1 VA: 0x34105F0
	public static long Parse(string s) { }

	// RVA: 0x3410630 Offset: 0x3410731 VA: 0x3410630
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x3410670 Offset: 0x3410771 VA: 0x3410670
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x34106D0 Offset: 0x34107D1 VA: 0x34106D0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x3410710 Offset: 0x3410811 VA: 0x3410710
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x3410770 Offset: 0x3410871 VA: 0x3410770 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3410780 Offset: 0x3410881 VA: 0x3410780 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x34107F0 Offset: 0x34108F1 VA: 0x34107F0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3410860 Offset: 0x3410961 VA: 0x3410860 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x34108D0 Offset: 0x34109D1 VA: 0x34108D0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3410940 Offset: 0x3410A41 VA: 0x3410940 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x34109B0 Offset: 0x3410AB1 VA: 0x34109B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3410A20 Offset: 0x3410B21 VA: 0x3410A20 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3410A90 Offset: 0x3410B91 VA: 0x3410A90 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3410B00 Offset: 0x3410C01 VA: 0x3410B00 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3410B10 Offset: 0x3410C11 VA: 0x3410B10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3410B80 Offset: 0x3410C81 VA: 0x3410B80 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3410BF0 Offset: 0x3410CF1 VA: 0x3410BF0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3410C60 Offset: 0x3410D61 VA: 0x3410C60 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3410CD0 Offset: 0x3410DD1 VA: 0x3410CD0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3410DB0 Offset: 0x3410EB1 VA: 0x3410DB0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
internal enum Int32Enum // TypeDefIndex: 364
{
	// Fields
	public int value__; // 0x0
}

