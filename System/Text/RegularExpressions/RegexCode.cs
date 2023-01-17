// Namespace: System.Text.RegularExpressions
internal sealed class RegexCode // TypeDefIndex: 2256
{
	// Fields
	internal int[] _codes; // 0x10
	internal string[] _strings; // 0x18
	internal int _trackcount; // 0x20
	internal Hashtable _caps; // 0x28
	internal int _capsize; // 0x30
	internal RegexPrefix _fcPrefix; // 0x38
	internal RegexBoyerMoore _bmPrefix; // 0x40
	internal int _anchors; // 0x48
	internal bool _rightToLeft; // 0x4C

	// Methods

	// RVA: 0x3C0B250 Offset: 0x3C0B351 VA: 0x3C0B250
	internal void .ctor(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x3C0B3A0 Offset: 0x3C0B4A1 VA: 0x3C0B3A0
	internal static bool OpcodeBacktracks(int Op) { }
}

