// Namespace: System.Text.RegularExpressions
internal sealed class RegexTree // TypeDefIndex: 2275
{
	// Fields
	internal RegexNode _root; // 0x10
	internal Hashtable _caps; // 0x18
	internal int[] _capnumlist; // 0x20
	internal Hashtable _capnames; // 0x28
	internal string[] _capslist; // 0x30
	internal RegexOptions _options; // 0x38
	internal int _captop; // 0x3C

	// Methods

	// RVA: 0x2D01C80 Offset: 0x2D01D81 VA: 0x2D01C80
	internal void .ctor(RegexNode root, Hashtable caps, int[] capnumlist, int captop, Hashtable capnames, string[] capslist, RegexOptions opts) { }
}

