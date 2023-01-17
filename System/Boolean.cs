// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FE30 Offset: 0x46FF31 VA: 0x46FE30
[Serializable]
public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 178
{
	// Fields
	private bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0x350B280 Offset: 0x350B381 VA: 0x350B280 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x350B290 Offset: 0x350B391 VA: 0x350B290 Slot: 3
	public override string ToString() { }

	// RVA: 0x350B300 Offset: 0x350B401 VA: 0x350B300 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x350B370 Offset: 0x350B471 VA: 0x350B370 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x350B400 Offset: 0x350B501 VA: 0x350B400 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x350B420 Offset: 0x350B521 VA: 0x350B420 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x350B530 Offset: 0x350B631 VA: 0x350B530 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x350B560 Offset: 0x350B661 VA: 0x350B560
	public static bool Parse(string value) { }

	// RVA: 0x350B680 Offset: 0x350B781 VA: 0x350B680
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x350B7C0 Offset: 0x350B8C1 VA: 0x350B7C0
	private static string TrimWhiteSpaceAndNull(string value) { }

	// RVA: 0x350B930 Offset: 0x350BA31 VA: 0x350B930 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x350B940 Offset: 0x350BA41 VA: 0x350B940 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x350B950 Offset: 0x350BA51 VA: 0x350B950 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x350BA30 Offset: 0x350BB31 VA: 0x350BA30 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x350BAB0 Offset: 0x350BBB1 VA: 0x350BAB0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x350BB30 Offset: 0x350BC31 VA: 0x350BB30 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x350BBB0 Offset: 0x350BCB1 VA: 0x350BBB0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x350BC30 Offset: 0x350BD31 VA: 0x350BC30 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x350BCB0 Offset: 0x350BDB1 VA: 0x350BCB0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x350BD30 Offset: 0x350BE31 VA: 0x350BD30 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x350BDB0 Offset: 0x350BEB1 VA: 0x350BDB0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x350BE30 Offset: 0x350BF31 VA: 0x350BE30 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x350BEB0 Offset: 0x350BFB1 VA: 0x350BEB0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x350BF30 Offset: 0x350C031 VA: 0x350BF30 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x350BFB0 Offset: 0x350C0B1 VA: 0x350BFB0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x350C090 Offset: 0x350C191 VA: 0x350C090 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x350C160 Offset: 0x350C261 VA: 0x350C160
	private static void .cctor() { }
}

