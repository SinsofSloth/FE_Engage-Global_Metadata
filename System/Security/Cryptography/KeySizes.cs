// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473CE0 Offset: 0x473DE1 VA: 0x473CE0
public sealed class KeySizes // TypeDefIndex: 906
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x341B450 Offset: 0x341B551 VA: 0x341B450
	public int get_MinSize() { }

	// RVA: 0x341B460 Offset: 0x341B561 VA: 0x341B460
	public int get_MaxSize() { }

	// RVA: 0x341B470 Offset: 0x341B571 VA: 0x341B470
	public int get_SkipSize() { }

	// RVA: 0x341B480 Offset: 0x341B581 VA: 0x341B480
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x341B4C0 Offset: 0x341B5C1 VA: 0x341B4C0
	internal bool IsLegal(int keySize) { }

	// RVA: 0x341B510 Offset: 0x341B611 VA: 0x341B510
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}

