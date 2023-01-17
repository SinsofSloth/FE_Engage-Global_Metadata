// Namespace: System
[DefaultMemberAttribute] // RVA: 0x4709F0 Offset: 0x470AF1 VA: 0x4709F0
[ComVisibleAttribute] // RVA: 0x4709F0 Offset: 0x470AF1 VA: 0x4709F0
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 304
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x3826A20 Offset: 0x3826B21 VA: 0x3826A20
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x47AA80 Offset: 0x47AB81 VA: 0x47AA80
	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2020080 Offset: 0x2020181 VA: 0x2020080
	|-String.Join<Int32Enum>
	|-String.Join<Cooking.ConversationType>
	|
	|-RVA: 0x2020650 Offset: 0x2020751 VA: 0x2020650
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x47AAA0 Offset: 0x47ABA1 VA: 0x47AAA0
	// RVA: 0x3836C70 Offset: 0x3836D71 VA: 0x3836C70
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x38369C0 Offset: 0x3836AC1 VA: 0x38369C0
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x3837170 Offset: 0x3837271 VA: 0x3837170
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x47AAC0 Offset: 0x47ABC1 VA: 0x47AAC0
	// RVA: 0x3837260 Offset: 0x3837361 VA: 0x3837260
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x38373B0 Offset: 0x38374B1 VA: 0x38373B0
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x47AAE0 Offset: 0x47ABE1 VA: 0x47AAE0
	// RVA: 0x3837570 Offset: 0x3837671 VA: 0x3837570 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x47AB00 Offset: 0x47AC01 VA: 0x47AB00
	// RVA: 0x3824D00 Offset: 0x3824E01 VA: 0x3824D00 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x3837660 Offset: 0x3837761 VA: 0x3837660
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x3837960 Offset: 0x3837A61 VA: 0x3837960
	public static bool Equals(string a, string b) { }

	// RVA: 0x38379A0 Offset: 0x3837AA1 VA: 0x38379A0
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x3829110 Offset: 0x3829211 VA: 0x3829110
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x38286A0 Offset: 0x38287A1 VA: 0x38286A0
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x38315A0 Offset: 0x38316A1 VA: 0x38315A0
	public char get_Chars(int index) { }

	// RVA: 0x3836620 Offset: 0x3836721 VA: 0x3836620
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x3837C80 Offset: 0x3837D81 VA: 0x3837C80
	public char[] ToCharArray() { }

	// RVA: 0x3837D20 Offset: 0x3837E21 VA: 0x3837D20
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x3837D40 Offset: 0x3837E41 VA: 0x3837D40
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x47AB20 Offset: 0x47AC21 VA: 0x47AB20
	// RVA: 0x3837E00 Offset: 0x3837F01 VA: 0x3837E00 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x47AB40 Offset: 0x47AC41 VA: 0x47AB40
	// RVA: 0x3837E80 Offset: 0x3837F81 VA: 0x3837E80
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x3837F00 Offset: 0x3838001 VA: 0x3837F00
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x47AB60 Offset: 0x47AC61 VA: 0x47AB60
	// RVA: 0x3838170 Offset: 0x3838271 VA: 0x3838170
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x47AB80 Offset: 0x47AC81 VA: 0x47AB80
	// RVA: 0x3837F10 Offset: 0x3838011 VA: 0x3837F10
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x3838780 Offset: 0x3838881 VA: 0x3838780
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x3838350 Offset: 0x3838451 VA: 0x3838350
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x3838180 Offset: 0x3838281 VA: 0x3838180
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x3838BD0 Offset: 0x3838CD1 VA: 0x3838BD0
	public string Substring(int startIndex) { }

	// RVA: 0x3838A50 Offset: 0x3838B51 VA: 0x3838A50
	public string Substring(int startIndex, int length) { }

	// RVA: 0x3838BE0 Offset: 0x3838CE1 VA: 0x3838BE0
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x3838C40 Offset: 0x3838D41 VA: 0x3838C40
	public string Trim(char[] trimChars) { }

	// RVA: 0x3839070 Offset: 0x3839171 VA: 0x3839070
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x3839090 Offset: 0x3839191 VA: 0x3839090
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x47ABA0 Offset: 0x47ACA1 VA: 0x47ABA0
	// RVA: 0x38390B0 Offset: 0x38391B1 VA: 0x38390B0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x47ABC0 Offset: 0x47ACC1 VA: 0x47ABC0
	// RVA: 0x38390C0 Offset: 0x38391C1 VA: 0x38390C0
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x47ABE0 Offset: 0x47ACE1 VA: 0x47ABE0
	// RVA: 0x38390D0 Offset: 0x38391D1 VA: 0x38390D0
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x38390E0 Offset: 0x38391E1 VA: 0x38390E0
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x38391B0 Offset: 0x38392B1 VA: 0x38391B0
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x3837160 Offset: 0x3837261 VA: 0x3837160
	internal static string FastAllocateString(int length) { }

	// RVA: 0x3839280 Offset: 0x3839381 VA: 0x3839280
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x3839300 Offset: 0x3839401 VA: 0x3839300
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x3839310 Offset: 0x3839411 VA: 0x3839310
	public void .ctor(char[] value) { }

	// RVA: 0x3837C70 Offset: 0x3837D71 VA: 0x3837C70
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x3839320 Offset: 0x3839421 VA: 0x3839320
	private string CtorCharArray(char[] value) { }

	// RVA: 0x38393D0 Offset: 0x38394D1 VA: 0x38393D0
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x3839590 Offset: 0x3839691 VA: 0x3839590
	private static int wcslen(char* ptr) { }

	// RVA: 0x3839620 Offset: 0x3839721 VA: 0x3839620
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x3839850 Offset: 0x3839951 VA: 0x3839850
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x3839A90 Offset: 0x3839B91 VA: 0x3839A90
	public void .ctor(char c, int count) { }

	// RVA: 0x3839AA0 Offset: 0x3839BA1 VA: 0x3839AA0
	public static int Compare(string strA, string strB) { }

	// RVA: 0x3839B30 Offset: 0x3839C31 VA: 0x3839B30
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x3839C10 Offset: 0x3839D11 VA: 0x3839C10
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x3839F30 Offset: 0x383A031 VA: 0x3839F30
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x3839FD0 Offset: 0x383A0D1 VA: 0x3839FD0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x383A0E0 Offset: 0x383A1E1 VA: 0x383A0E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x383A630 Offset: 0x383A731 VA: 0x383A630 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x383A7A0 Offset: 0x383A8A1 VA: 0x383A7A0 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x383A850 Offset: 0x383A951 VA: 0x383A850
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x383A8A0 Offset: 0x383A9A1 VA: 0x383A8A0
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x383A8D0 Offset: 0x383A9D1 VA: 0x383A8D0
	public bool Contains(string value) { }

	// RVA: 0x383A910 Offset: 0x383AA11 VA: 0x383A910
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x47AC00 Offset: 0x47AD01 VA: 0x47AC00
	// RVA: 0x383A920 Offset: 0x383AA21 VA: 0x383A920
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x383ABE0 Offset: 0x383ACE1 VA: 0x383ABE0
	internal bool EndsWith(char value) { }

	// RVA: 0x383AC70 Offset: 0x383AD71 VA: 0x383AC70
	public int IndexOf(char value) { }

	// RVA: 0x383ADA0 Offset: 0x383AEA1 VA: 0x383ADA0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x383ADB0 Offset: 0x383AEB1 VA: 0x383ADB0
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x383AFA0 Offset: 0x383B0A1 VA: 0x383AFA0
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x383AFB0 Offset: 0x383B0B1 VA: 0x383AFB0
	public int IndexOf(string value) { }

	// RVA: 0x383AFC0 Offset: 0x383B0C1 VA: 0x383AFC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x383A900 Offset: 0x383AA01 VA: 0x383A900
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x383AFD0 Offset: 0x383B0D1 VA: 0x383AFD0
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x383AFE0 Offset: 0x383B0E1 VA: 0x383AFE0
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x383B390 Offset: 0x383B491 VA: 0x383B390
	public int LastIndexOf(char value) { }

	// RVA: 0x383B4C0 Offset: 0x383B5C1 VA: 0x383B4C0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x383B4D0 Offset: 0x383B5D1 VA: 0x383B4D0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x383B6B0 Offset: 0x383B7B1 VA: 0x383B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x383B6C0 Offset: 0x383B7C1 VA: 0x383B6C0
	public int LastIndexOf(string value) { }

	// RVA: 0x383BAF0 Offset: 0x383BBF1 VA: 0x383BAF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x383B6D0 Offset: 0x383B7D1 VA: 0x383B6D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x383BB00 Offset: 0x383BC01 VA: 0x383BB00
	public string PadLeft(int totalWidth) { }

	// RVA: 0x383BD00 Offset: 0x383BE01 VA: 0x383BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x383BD10 Offset: 0x383BE11 VA: 0x383BD10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x383BD20 Offset: 0x383BE21 VA: 0x383BD20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x47AC20 Offset: 0x47AD21 VA: 0x47AC20
	// RVA: 0x383BD80 Offset: 0x383BE81 VA: 0x383BD80
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x383C040 Offset: 0x383C141 VA: 0x383C040
	public string ToLower() { }

	// RVA: 0x383C0C0 Offset: 0x383C1C1 VA: 0x383C0C0
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x383C150 Offset: 0x383C251 VA: 0x383C150
	public string ToLowerInvariant() { }

	// RVA: 0x383C1D0 Offset: 0x383C2D1 VA: 0x383C1D0
	public string ToUpper() { }

	// RVA: 0x383C250 Offset: 0x383C351 VA: 0x383C250
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x383C2E0 Offset: 0x383C3E1 VA: 0x383C2E0
	public string ToUpperInvariant() { }

	// RVA: 0x383C360 Offset: 0x383C461 VA: 0x383C360 Slot: 3
	public override string ToString() { }

	// RVA: 0x383C370 Offset: 0x383C471 VA: 0x383C370 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x383C380 Offset: 0x383C481 VA: 0x383C380 Slot: 5
	public object Clone() { }

	// RVA: 0x383C390 Offset: 0x383C491 VA: 0x383C390
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x3824CF0 Offset: 0x3824DF1 VA: 0x3824CF0
	public string Trim() { }

	// RVA: 0x3838C60 Offset: 0x3838D61 VA: 0x3838C60
	private string TrimHelper(int trimType) { }

	// RVA: 0x3838E80 Offset: 0x3838F81 VA: 0x3838E80
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x383C3A0 Offset: 0x383C4A1 VA: 0x383C3A0
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x383C450 Offset: 0x383C551 VA: 0x383C450
	public string Insert(int startIndex, string value) { }

	// RVA: 0x383C5C0 Offset: 0x383C6C1 VA: 0x383C5C0
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x382AD40 Offset: 0x382AE41 VA: 0x382AD40
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x383C880 Offset: 0x383C981 VA: 0x383C880
	public string Remove(int startIndex, int count) { }

	// RVA: 0x383CA10 Offset: 0x383CB11 VA: 0x383CA10
	public string Remove(int startIndex) { }

	// RVA: 0x3826A90 Offset: 0x3826B91 VA: 0x3826A90
	public static string Format(string format, object arg0) { }

	// RVA: 0x3827060 Offset: 0x3827161 VA: 0x3827060
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x3829150 Offset: 0x3829251 VA: 0x3829150
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x383CB80 Offset: 0x383CC81 VA: 0x383CB80
	public static string Format(string format, object[] args) { }

	// RVA: 0x383CC40 Offset: 0x383CD41 VA: 0x383CC40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x383CCA0 Offset: 0x383CDA1 VA: 0x383CCA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x383CD10 Offset: 0x383CE11 VA: 0x383CD10
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x383CD80 Offset: 0x383CE81 VA: 0x383CD80
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x383CAB0 Offset: 0x383CBB1 VA: 0x383CAB0
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x383CE40 Offset: 0x383CF41 VA: 0x383CE40
	public static string Copy(string str) { }

	// RVA: 0x383CEE0 Offset: 0x383CFE1 VA: 0x383CEE0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x383CF90 Offset: 0x383D091 VA: 0x383CF90
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x382B820 Offset: 0x382B921 VA: 0x382B820
	public static string Concat(object[] args) { }

	// RVA: 0x3828A00 Offset: 0x3828B01 VA: 0x3828A00
	public static string Concat(string str0, string str1) { }

	// RVA: 0x38297E0 Offset: 0x38298E1 VA: 0x38297E0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x3829DD0 Offset: 0x3829ED1 VA: 0x3829DD0
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x383D080 Offset: 0x383D181 VA: 0x383D080
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x383D170 Offset: 0x383D271 VA: 0x383D170
	public static string Concat(string[] values) { }

	// RVA: 0x383D340 Offset: 0x383D441 VA: 0x383D340 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x383D350 Offset: 0x383D451 VA: 0x383D350 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x383D3D0 Offset: 0x383D4D1 VA: 0x383D3D0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x383D450 Offset: 0x383D551 VA: 0x383D450 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x383D4D0 Offset: 0x383D5D1 VA: 0x383D4D0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x383D550 Offset: 0x383D651 VA: 0x383D550 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x383D5D0 Offset: 0x383D6D1 VA: 0x383D5D0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x383D650 Offset: 0x383D751 VA: 0x383D650 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x383D6D0 Offset: 0x383D7D1 VA: 0x383D6D0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x383D750 Offset: 0x383D851 VA: 0x383D750 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x383D7D0 Offset: 0x383D8D1 VA: 0x383D7D0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x383D850 Offset: 0x383D951 VA: 0x383D850 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x383D8D0 Offset: 0x383D9D1 VA: 0x383D8D0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x383D950 Offset: 0x383DA51 VA: 0x383D950 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x383D9D0 Offset: 0x383DAD1 VA: 0x383D9D0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x383DA50 Offset: 0x383DB51 VA: 0x383DA50 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x383DAE0 Offset: 0x383DBE1 VA: 0x383DAE0 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x383DB50 Offset: 0x383DC51 VA: 0x383DB50 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x383DBC0 Offset: 0x383DCC1 VA: 0x383DBC0
	public int get_Length() { }

	// RVA: 0x383DBD0 Offset: 0x383DCD1 VA: 0x383DBD0
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x383AC80 Offset: 0x383AD81 VA: 0x383AC80
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x383DD50 Offset: 0x383DE51 VA: 0x383DD50
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x383DF20 Offset: 0x383E021 VA: 0x383DF20
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x383ADC0 Offset: 0x383AEC1 VA: 0x383ADC0
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x383E020 Offset: 0x383E121 VA: 0x383E020
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x383B3A0 Offset: 0x383B4A1 VA: 0x383B3A0
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x383E100 Offset: 0x383E201 VA: 0x383E100
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x383B4E0 Offset: 0x383B5E1 VA: 0x383B4E0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x383E2D0 Offset: 0x383E3D1 VA: 0x383E2D0
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x383A510 Offset: 0x383A611 VA: 0x383A510
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x383C5D0 Offset: 0x383C6D1 VA: 0x383C5D0
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x383C760 Offset: 0x383C861 VA: 0x383C760
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x383E3C0 Offset: 0x383E4C1 VA: 0x383E3C0
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x383E8E0 Offset: 0x383E9E1 VA: 0x383E8E0
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x383BB10 Offset: 0x383BC11 VA: 0x383BB10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x383EAF0 Offset: 0x383EBF1 VA: 0x383EAF0
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x3837920 Offset: 0x3837A21 VA: 0x3837920
	internal bool IsAscii() { }

	// RVA: 0x383E370 Offset: 0x383E471 VA: 0x383E370
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x383EB40 Offset: 0x383EC41 VA: 0x383EB40
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x383EC80 Offset: 0x383ED81 VA: 0x383EC80
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x383EC90 Offset: 0x383ED91 VA: 0x383EC90
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x383EDA0 Offset: 0x383EEA1 VA: 0x383EDA0
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x383EDB0 Offset: 0x383EEB1 VA: 0x383EDB0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x383EDC0 Offset: 0x383EEC1 VA: 0x383EDC0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x383EDD0 Offset: 0x383EED1 VA: 0x383EDD0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x383EDE0 Offset: 0x383EEE1 VA: 0x383EDE0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x383EDF0 Offset: 0x383EEF1 VA: 0x383EDF0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x383EE00 Offset: 0x383EF01 VA: 0x383EE00
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x383EE10 Offset: 0x383EF11 VA: 0x383EE10
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x383EE20 Offset: 0x383EF21 VA: 0x383EE20
	private string CreateString(sbyte* value) { }

	// RVA: 0x383F1C0 Offset: 0x383F2C1 VA: 0x383F1C0
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x383F1D0 Offset: 0x383F2D1 VA: 0x383F1D0
	private string CreateString(char* value) { }

	// RVA: 0x383F1E0 Offset: 0x383F2E1 VA: 0x383F1E0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x38278A0 Offset: 0x38279A1 VA: 0x38278A0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x383F1F0 Offset: 0x383F2F1 VA: 0x383F1F0
	private string CreateString(char[] val) { }

	// RVA: 0x383F2A0 Offset: 0x383F3A1 VA: 0x383F2A0
	private string CreateString(char c, int count) { }

	// RVA: 0x383EEB0 Offset: 0x383EFB1 VA: 0x383EEB0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

