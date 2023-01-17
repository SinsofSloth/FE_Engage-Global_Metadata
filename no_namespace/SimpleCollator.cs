// Namespace: 
internal struct SimpleCollator.Context // TypeDefIndex: 38
{
	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x1C021A0 Offset: 0x1C022A1 VA: 0x1C021A0
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }
}

// Namespace: 
private struct SimpleCollator.PreviousInfo // TypeDefIndex: 39
{
	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x1C021C0 Offset: 0x1C022C1 VA: 0x1C021C0
	public void .ctor(bool dummy) { }
}

// Namespace: 
private struct SimpleCollator.Escape // TypeDefIndex: 40
{
	// Fields
	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14
}

// Namespace: 
private enum SimpleCollator.ExtenderType // TypeDefIndex: 41
{
	// Fields
	public int value__; // 0x0
	public const SimpleCollator.ExtenderType None = 0;
	public const SimpleCollator.ExtenderType Simple = 1;
	public const SimpleCollator.ExtenderType Voiced = 2;
	public const SimpleCollator.ExtenderType Conditional = 3;
	public const SimpleCollator.ExtenderType Buggy = 4;
}

