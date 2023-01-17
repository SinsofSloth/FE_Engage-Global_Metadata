// Namespace: System.Collections.Generic
internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 1399
{
	// Fields
	private static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDB20 Offset: 0x32CDC21 VA: 0x32CDB20
	|-ArraySortHelper<object, object>.get_Default
	|
	|-RVA: 0x32CF390 Offset: 0x32CF491 VA: 0x32CF390
	|-ArraySortHelper<ulong, object>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static ArraySortHelper<TKey, TValue> CreateArraySortHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDC00 Offset: 0x32CDD01 VA: 0x32CDC00
	|-ArraySortHelper<object, object>.CreateArraySortHelper
	|
	|-RVA: 0x32CF470 Offset: 0x32CF571 VA: 0x32CF470
	|-ArraySortHelper<ulong, object>.CreateArraySortHelper
	*/

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDD20 Offset: 0x32CDE21 VA: 0x32CDD20
	|-ArraySortHelper<object, object>.Sort
	|
	|-RVA: 0x32CF590 Offset: 0x32CF691 VA: 0x32CF590
	|-ArraySortHelper<ulong, object>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CDEC0 Offset: 0x32CDFC1 VA: 0x32CDEC0
	|-ArraySortHelper<object, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x32CF730 Offset: 0x32CF831 VA: 0x32CF730
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE0D0 Offset: 0x32CE1D1 VA: 0x32CE0D0
	|-ArraySortHelper<object, object>.Swap
	|
	|-RVA: 0x32CF920 Offset: 0x32CFA21 VA: 0x32CF920
	|-ArraySortHelper<ulong, object>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE1E0 Offset: 0x32CE2E1 VA: 0x32CE1E0
	|-ArraySortHelper<object, object>.IntrospectiveSort
	|
	|-RVA: 0x32CFA00 Offset: 0x32CFB01 VA: 0x32CFA00
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE2C0 Offset: 0x32CE3C1 VA: 0x32CE2C0
	|-ArraySortHelper<object, object>.IntroSort
	|
	|-RVA: 0x32CFAE0 Offset: 0x32CFBE1 VA: 0x32CFAE0
	|-ArraySortHelper<ulong, object>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CE680 Offset: 0x32CE781 VA: 0x32CE680
	|-ArraySortHelper<object, object>.PickPivotAndPartition
	|
	|-RVA: 0x32CFEA0 Offset: 0x32CFFA1 VA: 0x32CFEA0
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CEAE0 Offset: 0x32CEBE1 VA: 0x32CEAE0
	|-ArraySortHelper<object, object>.Heapsort
	|
	|-RVA: 0x32D0300 Offset: 0x32D0401 VA: 0x32D0300
	|-ArraySortHelper<ulong, object>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CEC90 Offset: 0x32CED91 VA: 0x32CEC90
	|-ArraySortHelper<object, object>.DownHeap
	|
	|-RVA: 0x32D04B0 Offset: 0x32D05B1 VA: 0x32D04B0
	|-ArraySortHelper<ulong, object>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CF010 Offset: 0x32CF111 VA: 0x32CF010
	|-ArraySortHelper<object, object>.InsertionSort
	|
	|-RVA: 0x32D0820 Offset: 0x32D0921 VA: 0x32D0820
	|-ArraySortHelper<ulong, object>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32CF380 Offset: 0x32CF481 VA: 0x32CF380
	|-ArraySortHelper<object, object>..ctor
	|
	|-RVA: 0x32D0B80 Offset: 0x32D0C81 VA: 0x32D0B80
	|-ArraySortHelper<ulong, object>..ctor
	*/
}

