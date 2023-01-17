// Namespace: App
public class Sort : SortConstant // TypeDefIndex: 9226
{
	// Methods

	// RVA: 0x27EB450 Offset: 0x27EB551 VA: 0x27EB450
	public static void InsertionSort(IList list) { }

	// RVA: 0x27EB4C0 Offset: 0x27EB5C1 VA: 0x27EB4C0
	public static void InsertionSort(IList list, IComparer comparer) { }

	// RVA: 0x27EB900 Offset: 0x27EBA01 VA: 0x27EB900
	private static void InsertionSortPartly(IList list, int first, int last, IComparer comparer) { }

	// RVA: 0x27EBCF0 Offset: 0x27EBDF1 VA: 0x27EBCF0
	public static void MergeSort(IList list) { }

	// RVA: 0x27EBF30 Offset: 0x27EC031 VA: 0x27EBF30
	public static void MergeSort(IList list, IComparer comparer) { }

	// RVA: 0x27EBE70 Offset: 0x27EBF71 VA: 0x27EBE70
	private static void MergeSortPartly(IList list, int begin, int end, object[] work, IComparer comparer) { }

	// RVA: 0x27EC080 Offset: 0x27EC181 VA: 0x27EC080
	private static void MergeSortMerge(IList list, int begin, int middle, int end, object[] work, IComparer comparer) { }

	// RVA: 0x27EC620 Offset: 0x27EC721 VA: 0x27EC620
	public void .ctor() { }
}

