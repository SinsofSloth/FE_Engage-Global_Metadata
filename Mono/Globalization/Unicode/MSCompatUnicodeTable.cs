// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTable // TypeDefIndex: 35
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x34258E0 Offset: 0x34259E1 VA: 0x34258E0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x3425A10 Offset: 0x3425B11 VA: 0x3425A10
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x34260F0 Offset: 0x34261F1 VA: 0x34260F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x34263D0 Offset: 0x34264D1 VA: 0x34263D0
	public static byte Category(int cp) { }

	// RVA: 0x3426490 Offset: 0x3426591 VA: 0x3426490
	public static byte Level1(int cp) { }

	// RVA: 0x3426550 Offset: 0x3426651 VA: 0x3426550
	public static byte Level2(int cp) { }

	// RVA: 0x3426610 Offset: 0x3426711 VA: 0x3426610
	public static byte Level3(int cp) { }

	// RVA: 0x34266D0 Offset: 0x34267D1 VA: 0x34266D0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x3426830 Offset: 0x3426931 VA: 0x3426830
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x34268A0 Offset: 0x34269A1 VA: 0x34268A0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x34268C0 Offset: 0x34269C1 VA: 0x34268C0
	public static int ToWidthCompat(int i) { }

	// RVA: 0x3426A50 Offset: 0x3426B51 VA: 0x3426A50
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x3426AF0 Offset: 0x3426BF1 VA: 0x3426AF0
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x3426B10 Offset: 0x3426C11 VA: 0x3426B10
	public static bool IsHiragana(char c) { }

	// RVA: 0x3426B30 Offset: 0x3426C31 VA: 0x3426B30
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x3426C20 Offset: 0x3426D21 VA: 0x3426C20
	public static bool get_IsReady() { }

	// RVA: 0x3426C90 Offset: 0x3426D91 VA: 0x3426C90
	private static IntPtr GetResource(string name) { }

	// RVA: 0x3426D10 Offset: 0x3426E11 VA: 0x3426D10
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x3426D40 Offset: 0x3426E41 VA: 0x3426D40
	private static void .cctor() { }

	// RVA: 0x3427200 Offset: 0x3427301 VA: 0x3427200
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x3427390 Offset: 0x3427491 VA: 0x3427390
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

