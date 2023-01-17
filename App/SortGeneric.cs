// Namespace: App
public class SortGeneric : SortConstant // TypeDefIndex: 9229
{
	// Methods

	// RVA: -1 Offset: -1
	public static void InsertionSort<T>(IList<T> list, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201D430 Offset: 0x201D531 VA: 0x201D430
	|-SortGeneric.InsertionSort<object>
	|-SortGeneric.InsertionSort<DebugCommandline.Property>
	|-SortGeneric.InsertionSort<SortieEntrustUnitData.WeaponKindExp>
	*/

	// RVA: -1 Offset: -1
	public static void InsertionSort<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201CF00 Offset: 0x201D001 VA: 0x201CF00
	|-SortGeneric.InsertionSort<object>
	*/

	// RVA: -1 Offset: -1
	public static void InsertionSort<T>(IList<T> list, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201CF70 Offset: 0x201D071 VA: 0x201CF70
	|-SortGeneric.InsertionSort<object>
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSortPartly<T>(IList<T> list, int first, int last, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201D4B0 Offset: 0x201D5B1 VA: 0x201D4B0
	|-SortGeneric.InsertionSortPartly<object>
	*/

	// RVA: -1 Offset: -1
	public static void MergeSort<T>(IList<T> list, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201DC40 Offset: 0x201DD41 VA: 0x201DC40
	|-SortGeneric.MergeSort<BasicMenuItem>
	|-SortGeneric.MergeSort<object>
	|-SortGeneric.MergeSort<HelpManager.Item>
	*/

	// RVA: -1 Offset: -1
	public static void MergeSort<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201D930 Offset: 0x201DA31 VA: 0x201D930
	|-SortGeneric.MergeSort<object>
	*/

	// RVA: -1 Offset: -1
	public static void MergeSort<T>(IList<T> list, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201DAD0 Offset: 0x201DBD1 VA: 0x201DAD0
	|-SortGeneric.MergeSort<object>
	*/

	// RVA: -1 Offset: -1
	private static void MergeSortPartly<T>(IList<T> list, int begin, int end, T[] work, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201E3D0 Offset: 0x201E4D1 VA: 0x201E3D0
	|-SortGeneric.MergeSortPartly<object>
	*/

	// RVA: -1 Offset: -1
	private static void MergeSortMerge<T>(IList<T> list, int begin, int middle, int end, T[] work, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201DDF0 Offset: 0x201DEF1 VA: 0x201DDF0
	|-SortGeneric.MergeSortMerge<object>
	*/

	// RVA: 0x27EC640 Offset: 0x27EC741 VA: 0x27EC640
	public void .ctor() { }
}

