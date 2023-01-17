// Namespace: System.Text.RegularExpressions
internal sealed class RegexBoyerMoore // TypeDefIndex: 2250
{
	// Fields
	internal int[] _positive; // 0x10
	internal int[] _negativeASCII; // 0x18
	internal int[][] _negativeUnicode; // 0x20
	internal string _pattern; // 0x28
	internal int _lowASCII; // 0x30
	internal int _highASCII; // 0x34
	internal bool _rightToLeft; // 0x38
	internal bool _caseInsensitive; // 0x39
	internal CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x3C019F0 Offset: 0x3C01AF1 VA: 0x3C019F0
	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x3C01FB0 Offset: 0x3C020B1 VA: 0x3C01FB0
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x3C020C0 Offset: 0x3C021C1 VA: 0x3C020C0
	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x3C02120 Offset: 0x3C02221 VA: 0x3C02120
	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x3C02470 Offset: 0x3C02571 VA: 0x3C02470 Slot: 3
	public override string ToString() { }
}

