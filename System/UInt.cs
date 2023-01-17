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
internal enum UInt32Enum // TypeDefIndex: 368
{
	// Fields
	public uint value__; // 0x0
}

