// Namespace: System.Text.RegularExpressions
internal sealed class RegexPrefix // TypeDefIndex: 2259
{
	// Fields
	internal string _prefix; // 0x10
	internal bool _caseInsensitive; // 0x18
	internal static RegexPrefix _empty; // 0x0

	// Properties
	internal string Prefix { get; }
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }

	// Methods

	// RVA: 0x2CFFB80 Offset: 0x2CFFC81 VA: 0x2CFFB80
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x2CFFBD0 Offset: 0x2CFFCD1 VA: 0x2CFFBD0
	internal string get_Prefix() { }

	// RVA: 0x2CFFBE0 Offset: 0x2CFFCE1 VA: 0x2CFFBE0
	internal bool get_CaseInsensitive() { }

	// RVA: 0x2CFFBF0 Offset: 0x2CFFCF1 VA: 0x2CFFBF0
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x2CFFC60 Offset: 0x2CFFD61 VA: 0x2CFFC60
	private static void .cctor() { }
}

