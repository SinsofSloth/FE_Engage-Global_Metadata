// Namespace: System.Text.RegularExpressions
[Serializable]
public class Regex : ISerializable // TypeDefIndex: 2245
{
	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0x31540 Offset: 0x31641 VA: 0x31540
	protected internal TimeSpan internalMatchTimeout; // 0x28
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x3BFE6F0 Offset: 0x3BFE7F1 VA: 0x3BFE6F0
	protected void .ctor() { }

	// RVA: 0x3BFE770 Offset: 0x3BFE871 VA: 0x3BFE770
	public void .ctor(string pattern) { }

	// RVA: 0x3BFECD0 Offset: 0x3BFEDD1 VA: 0x3BFECD0
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x3BFE800 Offset: 0x3BFE901 VA: 0x3BFE800
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x3BFF910 Offset: 0x3BFFA11 VA: 0x3BFF910
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3BFFAE0 Offset: 0x3BFFBE1 VA: 0x3BFFAE0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x3BFED60 Offset: 0x3BFEE61 VA: 0x3BFED60
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x3BFFBE0 Offset: 0x3BFFCE1 VA: 0x3BFFBE0
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x3BFFE70 Offset: 0x3BFFF71 VA: 0x3BFFE70
	public static string Escape(string str) { }

	// RVA: 0x3C00250 Offset: 0x3C00351 VA: 0x3C00250
	public RegexOptions get_Options() { }

	// RVA: 0x3C00260 Offset: 0x3C00361 VA: 0x3C00260
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x3C00270 Offset: 0x3C00371 VA: 0x3C00270
	public bool get_RightToLeft() { }

	// RVA: 0x3C00290 Offset: 0x3C00391 VA: 0x3C00290 Slot: 3
	public override string ToString() { }

	// RVA: 0x3C002A0 Offset: 0x3C003A1 VA: 0x3C002A0
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x3C00420 Offset: 0x3C00521 VA: 0x3C00420
	public int GroupNumberFromName(string name) { }

	// RVA: 0x3C005A0 Offset: 0x3C006A1 VA: 0x3C005A0
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x3C00660 Offset: 0x3C00761 VA: 0x3C00660
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x3C006F0 Offset: 0x3C007F1 VA: 0x3C006F0
	public bool IsMatch(string input) { }

	// RVA: 0x3C00770 Offset: 0x3C00871 VA: 0x3C00770
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x3C00B40 Offset: 0x3C00C41 VA: 0x3C00B40
	public static Match Match(string input, string pattern) { }

	// RVA: 0x3C00C00 Offset: 0x3C00D01 VA: 0x3C00C00
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x3C00C90 Offset: 0x3C00D91 VA: 0x3C00C90
	public Match Match(string input) { }

	// RVA: 0x3C00D10 Offset: 0x3C00E11 VA: 0x3C00D10
	public Match Match(string input, int startat) { }

	// RVA: 0x3C00D90 Offset: 0x3C00E91 VA: 0x3C00D90
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x3C00E50 Offset: 0x3C00F51 VA: 0x3C00E50
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x3C00EE0 Offset: 0x3C00FE1 VA: 0x3C00EE0
	public MatchCollection Matches(string input) { }

	// RVA: 0x3C00F60 Offset: 0x3C01061 VA: 0x3C00F60
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x3C01040 Offset: 0x3C01141 VA: 0x3C01040
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x3C01110 Offset: 0x3C01211 VA: 0x3C01110
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x3C011B0 Offset: 0x3C012B1 VA: 0x3C011B0
	public string Replace(string input, string replacement) { }

	// RVA: 0x3C01240 Offset: 0x3C01341 VA: 0x3C01240
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x3C01570 Offset: 0x3C01671 VA: 0x3C01570
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x3C01640 Offset: 0x3C01741 VA: 0x3C01640
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x3C016E0 Offset: 0x3C017E1 VA: 0x3C016E0
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x3C01770 Offset: 0x3C01871 VA: 0x3C01770
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x3BFF380 Offset: 0x3BFF481 VA: 0x3BFF380
	protected void InitializeReferences() { }

	// RVA: 0x3C00800 Offset: 0x3C00901 VA: 0x3C00800
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x3BFEEE0 Offset: 0x3BFEFE1 VA: 0x3BFEEE0
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x3BFF490 Offset: 0x3BFF591 VA: 0x3BFF490
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x3C00280 Offset: 0x3C00381 VA: 0x3C00280
	protected bool UseOptionR() { }

	// RVA: 0x3C017E0 Offset: 0x3C018E1 VA: 0x3C017E0
	internal bool UseOptionInvariant() { }

	// RVA: 0x3C01890 Offset: 0x3C01991 VA: 0x3C01890
	private static void .cctor() { }
}

