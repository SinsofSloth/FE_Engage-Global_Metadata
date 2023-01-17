// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC // TypeDefIndex: 2258
{
	// Fields
	internal RegexCharClass _cc; // 0x10
	internal bool _nullable; // 0x18
	internal bool _caseInsensitive; // 0x19

	// Methods

	// RVA: 0x3C0B3D0 Offset: 0x3C0B4D1 VA: 0x3C0B3D0
	internal void .ctor(bool nullable) { }

	// RVA: 0x3C0B460 Offset: 0x3C0B561 VA: 0x3C0B460
	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x3C0B560 Offset: 0x3C0B661 VA: 0x3C0B560
	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x3C0B660 Offset: 0x3C0B761 VA: 0x3C0B660
	internal bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x3C0B720 Offset: 0x3C0B821 VA: 0x3C0B720
	internal string GetFirstChars(CultureInfo culture) { }

	// RVA: 0x3C0B750 Offset: 0x3C0B851 VA: 0x3C0B750
	internal bool IsCaseInsensitive() { }
}

