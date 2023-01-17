// Namespace: System
[Serializable]
internal class __Filters // TypeDefIndex: 135
{
	// Fields
	internal static readonly __Filters Instance; // 0x0

	// Methods

	// RVA: 0x35DF700 Offset: 0x35DF801 VA: 0x35DF700 Slot: 4
	internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) { }

	// RVA: 0x35DFA80 Offset: 0x35DFB81 VA: 0x35DFA80 Slot: 5
	internal virtual bool FilterName(MemberInfo m, object filterCriteria) { }

	// RVA: 0x35DFC00 Offset: 0x35DFD01 VA: 0x35DFC00 Slot: 6
	internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) { }

	// RVA: 0x35DFD90 Offset: 0x35DFE91 VA: 0x35DFD90
	public void .ctor() { }

	// RVA: 0x35DFDA0 Offset: 0x35DFEA1 VA: 0x35DFDA0
	private static void .cctor() { }
}

// Namespace: System
internal struct __DTString // TypeDefIndex: 231
{
	// Fields
	internal string Value; // 0x0
	internal int Index; // 0x8
	internal int len; // 0xC
	internal char m_current; // 0x10
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x35DD7F0 Offset: 0x35DD8F1 VA: 0x35DD7F0
	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x35DD820 Offset: 0x35DD921 VA: 0x35DD820
	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35DD8E0 Offset: 0x35DD9E1 VA: 0x35DD8E0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x35DD8F0 Offset: 0x35DD9F1 VA: 0x35DD8F0
	internal bool GetNext() { }

	// RVA: 0x35DD950 Offset: 0x35DDA51 VA: 0x35DD950
	internal bool AtEnd() { }

	// RVA: 0x35DD960 Offset: 0x35DDA61 VA: 0x35DD960
	internal bool Advance(int count) { }

	// RVA: 0x35DD9C0 Offset: 0x35DDAC1 VA: 0x35DD9C0
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x35DDC60 Offset: 0x35DDD61 VA: 0x35DDC60
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x35DDE70 Offset: 0x35DDF71 VA: 0x35DDE70
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x35DDEE0 Offset: 0x35DDFE1 VA: 0x35DDEE0
	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	// RVA: 0x35DDF60 Offset: 0x35DE061 VA: 0x35DDF60
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x35DE2A0 Offset: 0x35DE3A1 VA: 0x35DE2A0
	internal bool Match(string str) { }

	// RVA: 0x35DE370 Offset: 0x35DE471 VA: 0x35DE370
	internal bool Match(char ch) { }

	// RVA: 0x35DE3F0 Offset: 0x35DE4F1 VA: 0x35DE3F0
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x35DE4C0 Offset: 0x35DE5C1 VA: 0x35DE4C0
	internal int GetRepeatCount() { }

	// RVA: 0x35DE540 Offset: 0x35DE641 VA: 0x35DE540
	internal bool GetNextDigit() { }

	// RVA: 0x35DE5E0 Offset: 0x35DE6E1 VA: 0x35DE5E0
	internal char GetChar() { }

	// RVA: 0x35DE600 Offset: 0x35DE701 VA: 0x35DE600
	internal int GetDigit() { }

	// RVA: 0x35DE630 Offset: 0x35DE731 VA: 0x35DE630
	internal void SkipWhiteSpaces() { }

	// RVA: 0x35DDD60 Offset: 0x35DDE61 VA: 0x35DDD60
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x35DE6E0 Offset: 0x35DE7E1 VA: 0x35DE6E0
	internal void TrimTail() { }

	// RVA: 0x35DE7C0 Offset: 0x35DE8C1 VA: 0x35DE7C0
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x35DE910 Offset: 0x35DEA11 VA: 0x35DE910
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x35DEA30 Offset: 0x35DEB31 VA: 0x35DEA30
	internal DTSubString GetSubString() { }

	// RVA: 0x35DEB50 Offset: 0x35DEC51 VA: 0x35DEB50
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x35DEBA0 Offset: 0x35DECA1 VA: 0x35DEBA0
	private static void .cctor() { }
}

// Namespace: System
internal class __ComObject // TypeDefIndex: 431
{
	// Methods

	// RVA: 0x35DD7A0 Offset: 0x35DD8A1 VA: 0x35DD7A0
	private void .ctor() { }
}

// Namespace: System
internal class __Il2CppComObject // TypeDefIndex: 1512
{
	// Methods

	// RVA: 0x35DFE60 Offset: 0x35DFF61 VA: 0x35DFE60 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System
internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 1513
{
	// Methods

	// RVA: 0x35DFE10 Offset: 0x35DFF11 VA: 0x35DFE10 Slot: 1
	protected override void Finalize() { }
}

