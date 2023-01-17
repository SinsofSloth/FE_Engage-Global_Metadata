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
private struct SimpleCollator.Escape // TypeDefIndex: 40
{
	// Fields
	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14
}

