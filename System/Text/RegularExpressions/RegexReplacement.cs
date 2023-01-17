// Namespace: System.Text.RegularExpressions
internal sealed class RegexReplacement // TypeDefIndex: 2272
{
	// Fields
	internal string _rep; // 0x10
	internal List<string> _strings; // 0x18
	internal List<int> _rules; // 0x20

	// Properties
	internal string Pattern { get; }

	// Methods

	// RVA: 0x2CFFD00 Offset: 0x2CFFE01 VA: 0x2CFFD00
	internal void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x2D00180 Offset: 0x2D00281 VA: 0x2D00180
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x2D00300 Offset: 0x2D00401 VA: 0x2D00300
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x2D004A0 Offset: 0x2D005A1 VA: 0x2D004A0
	internal string get_Pattern() { }

	// RVA: 0x2D004B0 Offset: 0x2D005B1 VA: 0x2D004B0
	internal string Replace(Regex regex, string input, int count, int startat) { }

	// RVA: 0x2D00830 Offset: 0x2D00931 VA: 0x2D00830
	internal static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }
}

