// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FEB0 Offset: 0x46FFB1 VA: 0x46FEB0
[Serializable]
public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char> // TypeDefIndex: 182
{
	// Fields
	internal char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x339D6B0 Offset: 0x339D7B1 VA: 0x339D6B0
	private static bool IsLatin1(char ch) { }

	// RVA: 0x339D6C0 Offset: 0x339D7C1 VA: 0x339D6C0
	private static bool IsAscii(char ch) { }

	// RVA: 0x339D6D0 Offset: 0x339D7D1 VA: 0x339D6D0
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x339D760 Offset: 0x339D861 VA: 0x339D760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x339D770 Offset: 0x339D871 VA: 0x339D770 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x339D800 Offset: 0x339D901 VA: 0x339D800 Slot: 23
	public bool Equals(char obj) { }

	// RVA: 0x339D810 Offset: 0x339D911 VA: 0x339D810 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x339D8F0 Offset: 0x339D9F1 VA: 0x339D8F0 Slot: 22
	public int CompareTo(char value) { }

	// RVA: 0x339D900 Offset: 0x339DA01 VA: 0x339D900 Slot: 3
	public override string ToString() { }

	// RVA: 0x339D9A0 Offset: 0x339DAA1 VA: 0x339D9A0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x339D980 Offset: 0x339DA81 VA: 0x339D980
	public static string ToString(char c) { }

	// RVA: 0x339DA20 Offset: 0x339DB21 VA: 0x339DA20
	public static char Parse(string s) { }

	// RVA: 0x339DAF0 Offset: 0x339DBF1 VA: 0x339DAF0
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x339DB50 Offset: 0x339DC51 VA: 0x339DB50
	public static bool IsDigit(char c) { }

	// RVA: 0x339DD00 Offset: 0x339DE01 VA: 0x339DD00
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x339DD10 Offset: 0x339DE11 VA: 0x339DD10
	public static bool IsLetter(char c) { }

	// RVA: 0x339DEB0 Offset: 0x339DFB1 VA: 0x339DEB0
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x339DF00 Offset: 0x339E001 VA: 0x339DF00
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x339E0F0 Offset: 0x339E1F1 VA: 0x339E0F0
	public static bool IsUpper(char c) { }

	// RVA: 0x339E280 Offset: 0x339E381 VA: 0x339E280
	public static bool IsLower(char c) { }

	// RVA: 0x339E410 Offset: 0x339E511 VA: 0x339E410
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x339E420 Offset: 0x339E521 VA: 0x339E420
	public static bool IsPunctuation(char c) { }

	// RVA: 0x339E580 Offset: 0x339E681 VA: 0x339E580
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x339E5A0 Offset: 0x339E6A1 VA: 0x339E5A0
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x339E720 Offset: 0x339E821 VA: 0x339E720
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x339E7B0 Offset: 0x339E8B1 VA: 0x339E7B0
	public static char ToUpper(char c) { }

	// RVA: 0x339E860 Offset: 0x339E961 VA: 0x339E860
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x339E910 Offset: 0x339EA11 VA: 0x339E910
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x339E9A0 Offset: 0x339EAA1 VA: 0x339E9A0
	public static char ToLower(char c) { }

	// RVA: 0x339EA50 Offset: 0x339EB51 VA: 0x339EA50
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x339EB00 Offset: 0x339EC01 VA: 0x339EB00 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x339EB10 Offset: 0x339EC11 VA: 0x339EB10 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x339EBF0 Offset: 0x339ECF1 VA: 0x339EBF0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x339EC00 Offset: 0x339ED01 VA: 0x339EC00 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x339ED40 Offset: 0x339EE41 VA: 0x339ED40 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x339EE80 Offset: 0x339EF81 VA: 0x339EE80 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x339EFB0 Offset: 0x339F0B1 VA: 0x339EFB0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x339F030 Offset: 0x339F131 VA: 0x339F030 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x339F0B0 Offset: 0x339F1B1 VA: 0x339F0B0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x339F130 Offset: 0x339F231 VA: 0x339F130 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x339F1B0 Offset: 0x339F2B1 VA: 0x339F1B0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x339F230 Offset: 0x339F331 VA: 0x339F230 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x339F310 Offset: 0x339F411 VA: 0x339F310 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x339F3F0 Offset: 0x339F4F1 VA: 0x339F3F0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x339F4D0 Offset: 0x339F5D1 VA: 0x339F4D0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x339F5B0 Offset: 0x339F6B1 VA: 0x339F5B0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x33A08F0 Offset: 0x33A09F1 VA: 0x33A08F0
	public static bool IsControl(char c) { }

	// RVA: 0x33A0A30 Offset: 0x33A0B31 VA: 0x33A0A30
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x33A0A40 Offset: 0x33A0B41 VA: 0x33A0A40
	public static bool IsNumber(char c) { }

	// RVA: 0x33A0BE0 Offset: 0x33A0CE1 VA: 0x33A0BE0
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x33A0F20 Offset: 0x33A1021 VA: 0x33A0F20
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x33A0F30 Offset: 0x33A1031 VA: 0x33A0F30
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x33A0F50 Offset: 0x33A1051 VA: 0x33A0F50
	public static bool IsSeparator(char c) { }

	// RVA: 0x33A1060 Offset: 0x33A1161 VA: 0x33A1060
	public static bool IsSurrogate(char c) { }

	// RVA: 0x33A1070 Offset: 0x33A1171 VA: 0x33A1070
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x33A1190 Offset: 0x33A1291 VA: 0x33A1190
	internal static bool CheckSymbol(UnicodeCategory uc) { }

	// RVA: 0x33A11A0 Offset: 0x33A12A1 VA: 0x33A11A0
	public static bool IsSymbol(char c) { }

	// RVA: 0x33A1300 Offset: 0x33A1401 VA: 0x33A1300
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x33A1500 Offset: 0x33A1601 VA: 0x33A1500
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x33A1820 Offset: 0x33A1921 VA: 0x33A1820
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x33A1830 Offset: 0x33A1931 VA: 0x33A1830
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x33A1950 Offset: 0x33A1A51 VA: 0x33A1950
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x33A1960 Offset: 0x33A1A61 VA: 0x33A1960
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x33A1990 Offset: 0x33A1A91 VA: 0x33A1990
	public static string ConvertFromUtf32(int utf32) { }

	// RVA: 0x33A1AF0 Offset: 0x33A1BF1 VA: 0x33A1AF0
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x33A1C40 Offset: 0x33A1D41 VA: 0x33A1C40
	private static void .cctor() { }
}

