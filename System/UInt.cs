// Namespace: System
[ComVisibleAttribute] // RVA: 0x470DC0 Offset: 0x470EC1 VA: 0x470DC0
[CLSCompliantAttribute] // RVA: 0x470DC0 Offset: 0x470EC1 VA: 0x470DC0
[Serializable]
public struct UInt16 : IComparable, IFormattable, IConvertible, IComparable<ushort>, IEquatable<ushort> // TypeDefIndex: 329
{
	// Fields
	private ushort m_value; // 0x0
	public const ushort MaxValue = 65535;
	public const ushort MinValue = 0;

	// Methods

	// RVA: 0x3646590 Offset: 0x3646691 VA: 0x3646590 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3646670 Offset: 0x3646771 VA: 0x3646670 Slot: 23
	public int CompareTo(ushort value) { }

	// RVA: 0x3646680 Offset: 0x3646781 VA: 0x3646680 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3646710 Offset: 0x3646811 VA: 0x3646710 Slot: 24
	public bool Equals(ushort obj) { }

	// RVA: 0x3646720 Offset: 0x3646821 VA: 0x3646720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3646730 Offset: 0x3646831 VA: 0x3646730 Slot: 3
	public override string ToString() { }

	// RVA: 0x3646770 Offset: 0x3646871 VA: 0x3646770 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x36467B0 Offset: 0x36468B1 VA: 0x36467B0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AD60 Offset: 0x47AE61 VA: 0x47AD60
	// RVA: 0x36467F0 Offset: 0x36468F1 VA: 0x36467F0
	public static ushort Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x47AD80 Offset: 0x47AE81 VA: 0x47AD80
	// RVA: 0x3646970 Offset: 0x3646A71 VA: 0x3646970
	public static ushort Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47ADA0 Offset: 0x47AEA1 VA: 0x47ADA0
	// RVA: 0x36469B0 Offset: 0x3646AB1 VA: 0x36469B0
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x3646820 Offset: 0x3646921 VA: 0x3646820
	private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x47ADC0 Offset: 0x47AEC1 VA: 0x47ADC0
	// RVA: 0x3646A00 Offset: 0x3646B01 VA: 0x3646A00
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	// RVA: 0x3646AA0 Offset: 0x3646BA1 VA: 0x3646AA0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	// RVA: 0x3646B00 Offset: 0x3646C01 VA: 0x3646B00 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3646B10 Offset: 0x3646C11 VA: 0x3646B10 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3646B80 Offset: 0x3646C81 VA: 0x3646B80 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3646BF0 Offset: 0x3646CF1 VA: 0x3646BF0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3646C60 Offset: 0x3646D61 VA: 0x3646C60 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3646CD0 Offset: 0x3646DD1 VA: 0x3646CD0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x3646D40 Offset: 0x3646E41 VA: 0x3646D40 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3646D50 Offset: 0x3646E51 VA: 0x3646D50 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3646DC0 Offset: 0x3646EC1 VA: 0x3646DC0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3646E30 Offset: 0x3646F31 VA: 0x3646E30 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3646EA0 Offset: 0x3646FA1 VA: 0x3646EA0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3646F10 Offset: 0x3647011 VA: 0x3646F10 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3646F80 Offset: 0x3647081 VA: 0x3646F80 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3646FF0 Offset: 0x36470F1 VA: 0x3646FF0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3647060 Offset: 0x3647161 VA: 0x3647060 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3647140 Offset: 0x3647241 VA: 0x3647140 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[CLSCompliantAttribute] // RVA: 0x470E00 Offset: 0x470F01 VA: 0x470E00
[ComVisibleAttribute] // RVA: 0x470E00 Offset: 0x470F01 VA: 0x470E00
[Serializable]
public struct UInt32 : IComparable, IFormattable, IConvertible, IComparable<uint>, IEquatable<uint> // TypeDefIndex: 330
{
	// Fields
	private uint m_value; // 0x0
	public const uint MaxValue = 4294967295;
	public const uint MinValue = 0;

	// Methods

	// RVA: 0x3647200 Offset: 0x3647301 VA: 0x3647200 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3647300 Offset: 0x3647401 VA: 0x3647300 Slot: 23
	public int CompareTo(uint value) { }

	// RVA: 0x3647320 Offset: 0x3647421 VA: 0x3647320 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x36473B0 Offset: 0x36474B1 VA: 0x36473B0 Slot: 24
	public bool Equals(uint obj) { }

	// RVA: 0x36473C0 Offset: 0x36474C1 VA: 0x36473C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x36473D0 Offset: 0x36474D1 VA: 0x36473D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3647410 Offset: 0x3647511 VA: 0x3647410 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3647450 Offset: 0x3647551 VA: 0x3647450
	public string ToString(string format) { }

	// RVA: 0x3647490 Offset: 0x3647591 VA: 0x3647490 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47ADE0 Offset: 0x47AEE1 VA: 0x47ADE0
	// RVA: 0x36474D0 Offset: 0x36475D1 VA: 0x36474D0
	public static uint Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x47AE00 Offset: 0x47AF01 VA: 0x47AE00
	// RVA: 0x3647510 Offset: 0x3647611 VA: 0x3647510
	public static uint Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AE20 Offset: 0x47AF21 VA: 0x47AE20
	// RVA: 0x3647550 Offset: 0x3647651 VA: 0x3647550
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AE40 Offset: 0x47AF41 VA: 0x47AE40
	// RVA: 0x36475B0 Offset: 0x36476B1 VA: 0x36475B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	// RVA: 0x3647610 Offset: 0x3647711 VA: 0x3647610 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3647620 Offset: 0x3647721 VA: 0x3647620 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3647690 Offset: 0x3647791 VA: 0x3647690 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3647700 Offset: 0x3647801 VA: 0x3647700 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3647770 Offset: 0x3647871 VA: 0x3647770 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x36477E0 Offset: 0x36478E1 VA: 0x36477E0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x3647850 Offset: 0x3647951 VA: 0x3647850 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x36478C0 Offset: 0x36479C1 VA: 0x36478C0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3647930 Offset: 0x3647A31 VA: 0x3647930 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3647940 Offset: 0x3647A41 VA: 0x3647940 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x36479B0 Offset: 0x3647AB1 VA: 0x36479B0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3647A20 Offset: 0x3647B21 VA: 0x3647A20 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3647A90 Offset: 0x3647B91 VA: 0x3647A90 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3647B00 Offset: 0x3647C01 VA: 0x3647B00 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3647B70 Offset: 0x3647C71 VA: 0x3647B70 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3647C50 Offset: 0x3647D51 VA: 0x3647C50 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[CLSCompliantAttribute] // RVA: 0x470E40 Offset: 0x470F41 VA: 0x470E40
[ComVisibleAttribute] // RVA: 0x470E40 Offset: 0x470F41 VA: 0x470E40
[Serializable]
public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 331
{
	// Fields
	private ulong m_value; // 0x0
	public const ulong MaxValue = 18446744073709551615;
	public const ulong MinValue = 0;

	// Methods

	// RVA: 0x3647D10 Offset: 0x3647E11 VA: 0x3647D10 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x3647E10 Offset: 0x3647F11 VA: 0x3647E10 Slot: 23
	public int CompareTo(ulong value) { }

	// RVA: 0x3647E30 Offset: 0x3647F31 VA: 0x3647E30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3647EC0 Offset: 0x3647FC1 VA: 0x3647EC0 Slot: 24
	public bool Equals(ulong obj) { }

	// RVA: 0x3647ED0 Offset: 0x3647FD1 VA: 0x3647ED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3647EE0 Offset: 0x3647FE1 VA: 0x3647EE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3647F20 Offset: 0x3648021 VA: 0x3647F20 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3647F60 Offset: 0x3648061 VA: 0x3647F60
	public string ToString(string format) { }

	// RVA: 0x3647FA0 Offset: 0x36480A1 VA: 0x3647FA0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AE60 Offset: 0x47AF61 VA: 0x47AE60
	// RVA: 0x3647FE0 Offset: 0x36480E1 VA: 0x3647FE0
	public static ulong Parse(string s) { }

	[CLSCompliantAttribute] // RVA: 0x47AE80 Offset: 0x47AF81 VA: 0x47AE80
	// RVA: 0x3648020 Offset: 0x3648121 VA: 0x3648020
	public static ulong Parse(string s, NumberStyles style) { }

	[CLSCompliantAttribute] // RVA: 0x47AEA0 Offset: 0x47AFA1 VA: 0x47AEA0
	// RVA: 0x3648070 Offset: 0x3648171 VA: 0x3648070
	public static ulong Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AEC0 Offset: 0x47AFC1 VA: 0x47AEC0
	// RVA: 0x36480B0 Offset: 0x36481B1 VA: 0x36480B0
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47AEE0 Offset: 0x47AFE1 VA: 0x47AEE0
	// RVA: 0x3648110 Offset: 0x3648211 VA: 0x3648110
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	// RVA: 0x3648170 Offset: 0x3648271 VA: 0x3648170 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3648180 Offset: 0x3648281 VA: 0x3648180 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x36481F0 Offset: 0x36482F1 VA: 0x36481F0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3648260 Offset: 0x3648361 VA: 0x3648260 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x36482D0 Offset: 0x36483D1 VA: 0x36482D0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3648340 Offset: 0x3648441 VA: 0x3648340 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x36483B0 Offset: 0x36484B1 VA: 0x36483B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3648420 Offset: 0x3648521 VA: 0x3648420 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3648490 Offset: 0x3648591 VA: 0x3648490 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3648500 Offset: 0x3648601 VA: 0x3648500 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3648570 Offset: 0x3648671 VA: 0x3648570 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3648580 Offset: 0x3648681 VA: 0x3648580 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x36485F0 Offset: 0x36486F1 VA: 0x36485F0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3648660 Offset: 0x3648761 VA: 0x3648660 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x36486D0 Offset: 0x36487D1 VA: 0x36486D0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x36487B0 Offset: 0x36488B1 VA: 0x36487B0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
internal enum UInt16Enum // TypeDefIndex: 367
{
	// Fields
	public ushort value__; // 0x0
}

// Namespace: System
internal enum UInt32Enum // TypeDefIndex: 368
{
	// Fields
	public uint value__; // 0x0
}

// Namespace: System
internal enum UInt64Enum // TypeDefIndex: 369
{
	// Fields
	public ulong value__; // 0x0
}

