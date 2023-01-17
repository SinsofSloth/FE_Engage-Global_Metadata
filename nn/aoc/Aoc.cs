// Namespace: nn.aoc
public static class Aoc // TypeDefIndex: 14778
{
	// Methods

	// RVA: 0x2101750 Offset: 0x2101851 VA: 0x2101750
	public static extern int CountAddOnContent() { }

	// RVA: 0x2101760 Offset: 0x2101861 VA: 0x2101760
	public static extern int ListAddOnContent(int[] outIndices, int offset, int count) { }

	// RVA: 0x2101770 Offset: 0x2101871 VA: 0x2101770
	public static extern void GetAddOnContentListChangedEvent() { }

	// RVA: 0x2101780 Offset: 0x2101881 VA: 0x2101780
	public static extern bool IsAddOnContentListChanged() { }

	// RVA: 0x21017A0 Offset: 0x21018A1 VA: 0x21017A0
	public static extern void DestroyAddOnContentListChangedEvent() { }

	// RVA: 0x21017B0 Offset: 0x21018B1 VA: 0x21017B0
	public static void ShowAddOnContentLostError(int[] indices) { }

	// RVA: 0x21017D0 Offset: 0x21018D1 VA: 0x21017D0
	private static extern void ShowAddOnContentLostError(int[] indices, int count) { }
}

