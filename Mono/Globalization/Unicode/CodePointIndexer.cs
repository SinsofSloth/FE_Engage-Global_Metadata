// Namespace: Mono.Globalization.Unicode
internal class CodePointIndexer // TypeDefIndex: 29
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x33A6C40 Offset: 0x33A6D41 VA: 0x33A6C40
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x33A6E00 Offset: 0x33A6F01 VA: 0x33A6E00
	public int ToIndex(int cp) { }
}

