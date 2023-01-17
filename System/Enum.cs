// Namespace: System
[ComVisibleAttribute] // RVA: 0x4700E0 Offset: 0x4701E1 VA: 0x4700E0
[Serializable]
public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible // TypeDefIndex: 213
{
	// Fields
	private static readonly char[] enumSeperatorCharArray; // 0x0
	private const string enumSeperator = ", ";

	// Methods

	// RVA: 0x3B58C90 Offset: 0x3B58D91 VA: 0x3B58C90
	private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	// RVA: 0x3B58E20 Offset: 0x3B58F21 VA: 0x3B58E20
	private static string InternalFormattedHexString(object value) { }

	// RVA: 0x3B59300 Offset: 0x3B59401 VA: 0x3B59300
	private static string InternalFormat(RuntimeType eT, object value) { }

	// RVA: 0x3B59530 Offset: 0x3B59631 VA: 0x3B59530
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	// RVA: 0x3B59750 Offset: 0x3B59851 VA: 0x3B59750
	internal static ulong ToUInt64(object value) { }

	// RVA: 0x3B598F0 Offset: 0x3B599F1 VA: 0x3B598F0
	private static int InternalCompareTo(object o1, object o2) { }

	// RVA: 0x3B59900 Offset: 0x3B59A01 VA: 0x3B59900
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	// RVA: 0x3B58E10 Offset: 0x3B58F11 VA: 0x3B58E10
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	// RVA: 0x3B59910 Offset: 0x3B59A11 VA: 0x3B59910
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1DF0 Offset: 0x22A1EF1 VA: 0x22A1DF0
	|-Enum.TryParse<CameraPosition>
	|-Enum.TryParse<Int32Enum>
	*/

	[ComVisibleAttribute] // RVA: 0x47A440 Offset: 0x47A541 VA: 0x47A440
	// RVA: 0x3B59920 Offset: 0x3B59A21 VA: 0x3B59920
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	// RVA: 0x3B59A00 Offset: 0x3B59B01 VA: 0x3B59A00
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult) { }

	[ComVisibleAttribute] // RVA: 0x47A460 Offset: 0x47A561 VA: 0x47A460
	// RVA: 0x3B5A1F0 Offset: 0x3B5A2F1 VA: 0x3B5A1F0
	public static Type GetUnderlyingType(Type enumType) { }

	[ComVisibleAttribute] // RVA: 0x47A480 Offset: 0x47A581 VA: 0x47A480
	// RVA: 0x3B5AA60 Offset: 0x3B5AB61 VA: 0x3B5AA60
	public static Array GetValues(Type enumType) { }

	// RVA: 0x3B5AB30 Offset: 0x3B5AC31 VA: 0x3B5AB30
	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0x47A4A0 Offset: 0x47A5A1 VA: 0x47A4A0
	// RVA: 0x3B59450 Offset: 0x3B59551 VA: 0x3B59450
	public static string GetName(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x47A4C0 Offset: 0x47A5C1 VA: 0x47A4C0
	// RVA: 0x3B5ABB0 Offset: 0x3B5ACB1 VA: 0x3B5ABB0
	public static string[] GetNames(Type enumType) { }

	// RVA: 0x3B5AC80 Offset: 0x3B5AD81 VA: 0x3B5AC80
	internal static string[] InternalGetNames(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0x47A4E0 Offset: 0x47A5E1 VA: 0x47A4E0
	// RVA: 0x3B5A2C0 Offset: 0x3B5A3C1 VA: 0x3B5A2C0
	public static object ToObject(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0x47A500 Offset: 0x47A601 VA: 0x47A500
	// RVA: 0x3B5BE80 Offset: 0x3B5BF81 VA: 0x3B5BE80
	public static bool IsDefined(Type enumType, object value) { }

	// RVA: 0x3B5BF60 Offset: 0x3B5C061 VA: 0x3B5BF60
	private object get_value() { }

	// RVA: 0x3B5BF70 Offset: 0x3B5C071 VA: 0x3B5BF70
	internal object GetValue() { }

	// RVA: 0x3B5BF80 Offset: 0x3B5C081 VA: 0x3B5BF80
	private bool InternalHasFlag(Enum flags) { }

	// RVA: 0x3B5BF90 Offset: 0x3B5C091 VA: 0x3B5BF90
	private int get_hashcode() { }

	// RVA: 0x3B5BFA0 Offset: 0x3B5C0A1 VA: 0x3B5BFA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3B5BFB0 Offset: 0x3B5C0B1 VA: 0x3B5BFB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3B5BFC0 Offset: 0x3B5C0C1 VA: 0x3B5BFC0 Slot: 3
	public override string ToString() { }

	[ObsoleteAttribute] // RVA: 0x47A520 Offset: 0x47A621 VA: 0x47A520
	// RVA: 0x3B5C0A0 Offset: 0x3B5C1A1 VA: 0x3B5C0A0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x3B5C310 Offset: 0x3B5C411 VA: 0x3B5C310 Slot: 4
	public int CompareTo(object target) { }

	// RVA: 0x3B5C0B0 Offset: 0x3B5C1B1 VA: 0x3B5C0B0
	public string ToString(string format) { }

	[ObsoleteAttribute] // RVA: 0x47A560 Offset: 0x47A661 VA: 0x47A560
	// RVA: 0x3B5C570 Offset: 0x3B5C671 VA: 0x3B5C570 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x3B5C580 Offset: 0x3B5C681 VA: 0x3B5C580
	public bool HasFlag(Enum flag) { }

	// RVA: 0x3B5C6F0 Offset: 0x3B5C7F1 VA: 0x3B5C6F0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x3B5CBB0 Offset: 0x3B5CCB1 VA: 0x3B5CBB0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x3B5CC70 Offset: 0x3B5CD71 VA: 0x3B5CC70 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x3B5CD30 Offset: 0x3B5CE31 VA: 0x3B5CD30 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x3B5CDF0 Offset: 0x3B5CEF1 VA: 0x3B5CDF0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x3B5CEB0 Offset: 0x3B5CFB1 VA: 0x3B5CEB0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x3B5CF70 Offset: 0x3B5D071 VA: 0x3B5CF70 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3B5D030 Offset: 0x3B5D131 VA: 0x3B5D030 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x3B5D0F0 Offset: 0x3B5D1F1 VA: 0x3B5D0F0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3B5D1B0 Offset: 0x3B5D2B1 VA: 0x3B5D1B0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x3B5D270 Offset: 0x3B5D371 VA: 0x3B5D270 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x3B5D330 Offset: 0x3B5D431 VA: 0x3B5D330 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x3B5D3F0 Offset: 0x3B5D4F1 VA: 0x3B5D3F0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x3B5D4B0 Offset: 0x3B5D5B1 VA: 0x3B5D4B0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3B5D570 Offset: 0x3B5D671 VA: 0x3B5D570 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x3B5D650 Offset: 0x3B5D751 VA: 0x3B5D650 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47A5A0 Offset: 0x47A6A1 VA: 0x47A5A0
	[ComVisibleAttribute] // RVA: 0x47A5A0 Offset: 0x47A6A1 VA: 0x47A5A0
	// RVA: 0x3B5AEF0 Offset: 0x3B5AFF1 VA: 0x3B5AEF0
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisibleAttribute] // RVA: 0x47A5E0 Offset: 0x47A6E1 VA: 0x47A5E0
	// RVA: 0x3B5B0E0 Offset: 0x3B5B1E1 VA: 0x3B5B0E0
	public static object ToObject(Type enumType, short value) { }

	[ComVisibleAttribute] // RVA: 0x47A600 Offset: 0x47A701 VA: 0x47A600
	// RVA: 0x3B5AD00 Offset: 0x3B5AE01 VA: 0x3B5AD00
	public static object ToObject(Type enumType, int value) { }

	[ComVisibleAttribute] // RVA: 0x47A620 Offset: 0x47A721 VA: 0x47A620
	// RVA: 0x3B5B6B0 Offset: 0x3B5B7B1 VA: 0x3B5B6B0
	public static object ToObject(Type enumType, byte value) { }

	[ComVisibleAttribute] // RVA: 0x47A640 Offset: 0x47A741 VA: 0x47A640
	[CLSCompliantAttribute] // RVA: 0x47A640 Offset: 0x47A741 VA: 0x47A640
	// RVA: 0x3B5B8A0 Offset: 0x3B5B9A1 VA: 0x3B5B8A0
	public static object ToObject(Type enumType, ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x47A680 Offset: 0x47A781 VA: 0x47A680
	[ComVisibleAttribute] // RVA: 0x47A680 Offset: 0x47A781 VA: 0x47A680
	// RVA: 0x3B5B4C0 Offset: 0x3B5B5C1 VA: 0x3B5B4C0
	public static object ToObject(Type enumType, uint value) { }

	[ComVisibleAttribute] // RVA: 0x47A6C0 Offset: 0x47A7C1 VA: 0x47A6C0
	// RVA: 0x3B5B2D0 Offset: 0x3B5B3D1 VA: 0x3B5B2D0
	public static object ToObject(Type enumType, long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A6E0 Offset: 0x47A7E1 VA: 0x47A6E0
	[ComVisibleAttribute] // RVA: 0x47A6E0 Offset: 0x47A7E1 VA: 0x47A6E0
	// RVA: 0x3B5A870 Offset: 0x3B5A971 VA: 0x3B5A870
	public static object ToObject(Type enumType, ulong value) { }

	// RVA: 0x3B5BA90 Offset: 0x3B5BB91 VA: 0x3B5BA90
	private static object ToObject(Type enumType, char value) { }

	// RVA: 0x3B5BC80 Offset: 0x3B5BD81 VA: 0x3B5BC80
	private static object ToObject(Type enumType, bool value) { }

	// RVA: 0x3B5D6E0 Offset: 0x3B5D7E1 VA: 0x3B5D6E0
	protected void .ctor() { }

	// RVA: 0x3B5D6F0 Offset: 0x3B5D7F1 VA: 0x3B5D6F0
	private static void .cctor() { }
}

