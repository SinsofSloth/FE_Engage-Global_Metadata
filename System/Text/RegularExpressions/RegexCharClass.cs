// Namespace: System.Text.RegularExpressions
internal sealed class RegexCharClass // TypeDefIndex: 2255
{
	// Fields
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28
	private static readonly string InternalRegexIgnoreCase; // 0x0
	private static readonly string Space; // 0x8
	private static readonly string NotSpace; // 0x10
	private static readonly string Word; // 0x18
	private static readonly string NotWord; // 0x20
	internal static readonly string SpaceClass; // 0x28
	internal static readonly string NotSpaceClass; // 0x30
	internal static readonly string WordClass; // 0x38
	internal static readonly string NotWordClass; // 0x40
	internal static readonly string DigitClass; // 0x48
	internal static readonly string NotDigitClass; // 0x50
	private static Dictionary<string, string> _definedCategories; // 0x58
	private static readonly string[,] _propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] _lcTable; // 0x68

	// Properties
	internal bool CanMerge { get; }
	internal bool Negate { set; }

	// Methods

	// RVA: 0x3C02480 Offset: 0x3C02581 VA: 0x3C02480
	private static void .cctor() { }

	// RVA: 0x3C08A60 Offset: 0x3C08B61 VA: 0x3C08A60
	internal void .ctor() { }

	// RVA: 0x3C08B40 Offset: 0x3C08C41 VA: 0x3C08B40
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x3C08BC0 Offset: 0x3C08CC1 VA: 0x3C08BC0
	internal bool get_CanMerge() { }

	// RVA: 0x3C08BE0 Offset: 0x3C08CE1 VA: 0x3C08BE0
	internal void set_Negate(bool value) { }

	// RVA: 0x3C08BF0 Offset: 0x3C08CF1 VA: 0x3C08BF0
	internal void AddChar(char c) { }

	// RVA: 0x3C08CF0 Offset: 0x3C08DF1 VA: 0x3C08CF0
	internal void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x3C08FD0 Offset: 0x3C090D1 VA: 0x3C08FD0
	private void AddSet(string set) { }

	// RVA: 0x3C09210 Offset: 0x3C09311 VA: 0x3C09210
	internal void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x3C08C00 Offset: 0x3C08D01 VA: 0x3C08C00
	internal void AddRange(char first, char last) { }

	// RVA: 0x3C09220 Offset: 0x3C09321 VA: 0x3C09220
	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x3C09740 Offset: 0x3C09841 VA: 0x3C09740
	private void AddCategory(string category) { }

	// RVA: 0x3C09750 Offset: 0x3C09851 VA: 0x3C09750
	internal void AddLowercase(CultureInfo culture) { }

	// RVA: 0x3C09880 Offset: 0x3C09981 VA: 0x3C09880
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x3C09B00 Offset: 0x3C09C01 VA: 0x3C09B00
	internal void AddWord(bool ecma, bool negate) { }

	// RVA: 0x3C09C00 Offset: 0x3C09D01 VA: 0x3C09C00
	internal void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x3C09D00 Offset: 0x3C09E01 VA: 0x3C09D00
	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x3C09DD0 Offset: 0x3C09ED1 VA: 0x3C09DD0
	internal static char SingletonChar(string set) { }

	// RVA: 0x3C09DE0 Offset: 0x3C09EE1 VA: 0x3C09DE0
	internal static bool IsMergeable(string charClass) { }

	// RVA: 0x3C09F70 Offset: 0x3C0A071 VA: 0x3C09F70
	internal static bool IsEmpty(string charClass) { }

	// RVA: 0x3C0A070 Offset: 0x3C0A171 VA: 0x3C0A070
	internal static bool IsSingleton(string set) { }

	// RVA: 0x3C0A1D0 Offset: 0x3C0A2D1 VA: 0x3C0A1D0
	internal static bool IsSingletonInverse(string set) { }

	// RVA: 0x3C09F10 Offset: 0x3C0A011 VA: 0x3C09F10
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x3C09EE0 Offset: 0x3C09FE1 VA: 0x3C09EE0
	internal static bool IsNegated(string set) { }

	// RVA: 0x3C0A330 Offset: 0x3C0A431 VA: 0x3C0A330
	internal static bool IsECMAWordChar(char ch) { }

	// RVA: 0x3C0A490 Offset: 0x3C0A591 VA: 0x3C0A490
	internal static bool IsWordChar(char ch) { }

	// RVA: 0x3C0A410 Offset: 0x3C0A511 VA: 0x3C0A410
	internal static bool CharInClass(char ch, string set) { }

	// RVA: 0x3C0A570 Offset: 0x3C0A671 VA: 0x3C0A570
	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x3C0A6C0 Offset: 0x3C0A7C1 VA: 0x3C0A6C0
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x3C0A7E0 Offset: 0x3C0A8E1 VA: 0x3C0A7E0
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x3C0AA30 Offset: 0x3C0AB31 VA: 0x3C0AA30
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x3C08990 Offset: 0x3C08A91 VA: 0x3C08990
	private static string NegateCategory(string category) { }

	// RVA: 0x3C0AB00 Offset: 0x3C0AC01 VA: 0x3C0AB00
	internal static RegexCharClass Parse(string charClass) { }

	// RVA: 0x3C0AB70 Offset: 0x3C0AC71 VA: 0x3C0AB70
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x3C08F10 Offset: 0x3C09011 VA: 0x3C08F10
	private int RangeCount() { }

	// RVA: 0x3C0AE00 Offset: 0x3C0AF01 VA: 0x3C0AE00
	internal string ToStringClass() { }

	// RVA: 0x3C08F60 Offset: 0x3C09061 VA: 0x3C08F60
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x3C0AFC0 Offset: 0x3C0B0C1 VA: 0x3C0AFC0
	private void Canonicalize() { }

	// RVA: 0x3C09450 Offset: 0x3C09551 VA: 0x3C09450
	private static string SetFromProperty(string capname, bool invert, string pattern) { }
}

