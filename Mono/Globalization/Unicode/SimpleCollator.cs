// Namespace: Mono.Globalization.Unicode
internal class SimpleCollator // TypeDefIndex: 42
{
	// Fields
	private static bool QuickCheckDisabled; // 0x0
	private static SimpleCollator invariant; // 0x8
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C
	private const int UnsafeFlagLength = 96;

	// Methods

	// RVA: 0x361CAC0 Offset: 0x361CBC1 VA: 0x361CAC0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x361CE40 Offset: 0x361CF41 VA: 0x361CE40
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x361CF80 Offset: 0x361D081 VA: 0x361CF80
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x361CFF0 Offset: 0x361D0F1 VA: 0x361CFF0
	private byte Category(int cp) { }

	// RVA: 0x361D0A0 Offset: 0x361D1A1 VA: 0x361D0A0
	private byte Level1(int cp) { }

	// RVA: 0x361D150 Offset: 0x361D251 VA: 0x361D150
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x361D2B0 Offset: 0x361D3B1 VA: 0x361D2B0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x361D340 Offset: 0x361D441 VA: 0x361D340
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x361D410 Offset: 0x361D511 VA: 0x361D410
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x361D530 Offset: 0x361D631 VA: 0x361D530
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x361D600 Offset: 0x361D701 VA: 0x361D600
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x361D7F0 Offset: 0x361D8F1 VA: 0x361D7F0
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x361D900 Offset: 0x361DA01 VA: 0x361D900
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x361DA10 Offset: 0x361DB11 VA: 0x361DA10
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x361DA30 Offset: 0x361DB31 VA: 0x361DA30
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x361DC50 Offset: 0x361DD51 VA: 0x361DC50
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x361DD00 Offset: 0x361DE01 VA: 0x361DD00
	private bool IsSafe(int i) { }

	// RVA: 0x361DD70 Offset: 0x361DE71 VA: 0x361DD70
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x361DD80 Offset: 0x361DE81 VA: 0x361DD80
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x361DE50 Offset: 0x361DF51 VA: 0x361DE50
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x361E4A0 Offset: 0x361E5A1 VA: 0x361E4A0
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x361E8E0 Offset: 0x361E9E1 VA: 0x361E8E0
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x361E990 Offset: 0x361EA91 VA: 0x361E990
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x361E440 Offset: 0x361E541 VA: 0x361E440
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x361EA90 Offset: 0x361EB91 VA: 0x361EA90
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3620460 Offset: 0x3620561 VA: 0x3620460
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x3620480 Offset: 0x3620581 VA: 0x3620480
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x3620490 Offset: 0x3620591 VA: 0x3620490
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x36205D0 Offset: 0x36206D1 VA: 0x36205D0
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3620640 Offset: 0x3620741 VA: 0x3620640
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x3620650 Offset: 0x3620751 VA: 0x3620650
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x3620A20 Offset: 0x3620B21 VA: 0x3620A20
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x3620B90 Offset: 0x3620C91 VA: 0x3620B90
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x3621540 Offset: 0x3621641 VA: 0x3621540
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x3621630 Offset: 0x3621731 VA: 0x3621630
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x36216B0 Offset: 0x36217B1 VA: 0x36216B0
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3620E60 Offset: 0x3620F61 VA: 0x3620E60
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3620760 Offset: 0x3620861 VA: 0x3620760
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x3621A10 Offset: 0x3621B11 VA: 0x3621A10
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x36222A0 Offset: 0x36223A1 VA: 0x36222A0
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3621B60 Offset: 0x3621C61 VA: 0x3621B60
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3621770 Offset: 0x3621871 VA: 0x3621770
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3622620 Offset: 0x3622721 VA: 0x3622620
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3622A70 Offset: 0x3622B71 VA: 0x3622A70
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x3622360 Offset: 0x3622461 VA: 0x3622360
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3622CF0 Offset: 0x3622DF1 VA: 0x3622CF0
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x3623350 Offset: 0x3623451 VA: 0x3623350
	private static void .cctor() { }
}

