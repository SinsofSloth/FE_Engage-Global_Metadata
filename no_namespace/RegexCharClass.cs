// Namespace: 
private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 2252
{
	// Fields
	internal char _chMin; // 0x0
	internal char _chMax; // 0x2
	internal int _lcOp; // 0x4
	internal int _data; // 0x8

	// Methods

	// RVA: 0x191EC10 Offset: 0x191ED11 VA: 0x191EC10
	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }
}

// Namespace: 
private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 2253
{
	// Methods

	// RVA: 0x191EC60 Offset: 0x191ED61 VA: 0x191EC60 Slot: 4
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	// RVA: 0x191EC80 Offset: 0x191ED81 VA: 0x191EC80
	public void .ctor() { }
}

// Namespace: 
private sealed class RegexCharClass.SingleRange // TypeDefIndex: 2254
{
	// Fields
	internal char _first; // 0x10
	internal char _last; // 0x12

	// Methods

	// RVA: 0x191EC20 Offset: 0x191ED21 VA: 0x191EC20
	internal void .ctor(char first, char last) { }
}

