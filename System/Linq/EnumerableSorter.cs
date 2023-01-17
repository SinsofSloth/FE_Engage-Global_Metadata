// Namespace: System.Linq
internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 2751
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<object>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29CC0 Offset: 0x1D29DC1 VA: 0x1D29CC0
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x1D29FB0 Offset: 0x1D2A0B1 VA: 0x1D29FB0
	|-EnumerableSorter<DiagnosticEvent>.Sort
	|
	|-RVA: 0x1D2A2A0 Offset: 0x1D2A3A1 VA: 0x1D2A2A0
	|-EnumerableSorter<int>.Sort
	|
	|-RVA: 0x1D2A590 Offset: 0x1D2A691 VA: 0x1D2A590
	|-EnumerableSorter<object>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29DB0 Offset: 0x1D29EB1 VA: 0x1D29DB0
	|-EnumerableSorter<KeyValuePair<object, int>>.QuickSort
	|
	|-RVA: 0x1D2A0A0 Offset: 0x1D2A1A1 VA: 0x1D2A0A0
	|-EnumerableSorter<DiagnosticEvent>.QuickSort
	|
	|-RVA: 0x1D2A390 Offset: 0x1D2A491 VA: 0x1D2A390
	|-EnumerableSorter<int>.QuickSort
	|
	|-RVA: 0x1D2A680 Offset: 0x1D2A781 VA: 0x1D2A680
	|-EnumerableSorter<object>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29FA0 Offset: 0x1D2A0A1 VA: 0x1D29FA0
	|-EnumerableSorter<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x1D2A290 Offset: 0x1D2A391 VA: 0x1D2A290
	|-EnumerableSorter<DiagnosticEvent>..ctor
	|
	|-RVA: 0x1D2A580 Offset: 0x1D2A681 VA: 0x1D2A580
	|-EnumerableSorter<int>..ctor
	|
	|-RVA: 0x1D2A870 Offset: 0x1D2A971 VA: 0x1D2A870
	|-EnumerableSorter<object>..ctor
	*/
}

// Namespace: System.Linq
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 2752
{
	// Fields
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0
	internal EnumerableSorter<TElement> next; // 0x0
	internal TKey[] keys; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2A880 Offset: 0x1D2A981 VA: 0x1D2A880
	|-EnumerableSorter<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x1D2AB80 Offset: 0x1D2AC81 VA: 0x1D2AB80
	|-EnumerableSorter<DiagnosticEvent, int>..ctor
	|
	|-RVA: 0x1D2AE90 Offset: 0x1D2AF91 VA: 0x1D2AE90
	|-EnumerableSorter<int, int>..ctor
	|
	|-RVA: 0x1D2B190 Offset: 0x1D2B291 VA: 0x1D2B190
	|-EnumerableSorter<object, int>..ctor
	|
	|-RVA: 0x1D2B490 Offset: 0x1D2B591 VA: 0x1D2B490
	|-EnumerableSorter<object, object>..ctor
	|
	|-RVA: 0x1D2B790 Offset: 0x1D2B891 VA: 0x1D2B790
	|-EnumerableSorter<object, uint>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void ComputeKeys(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2A910 Offset: 0x1D2AA11 VA: 0x1D2A910
	|-EnumerableSorter<KeyValuePair<object, int>, int>.ComputeKeys
	|
	|-RVA: 0x1D2AC10 Offset: 0x1D2AD11 VA: 0x1D2AC10
	|-EnumerableSorter<DiagnosticEvent, int>.ComputeKeys
	|
	|-RVA: 0x1D2AF20 Offset: 0x1D2B021 VA: 0x1D2AF20
	|-EnumerableSorter<int, int>.ComputeKeys
	|
	|-RVA: 0x1D2B220 Offset: 0x1D2B321 VA: 0x1D2B220
	|-EnumerableSorter<object, int>.ComputeKeys
	|
	|-RVA: 0x1D2B520 Offset: 0x1D2B621 VA: 0x1D2B520
	|-EnumerableSorter<object, object>.ComputeKeys
	|
	|-RVA: 0x1D2B820 Offset: 0x1D2B921 VA: 0x1D2B820
	|-EnumerableSorter<object, uint>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override int CompareKeys(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D2AA40 Offset: 0x1D2AB41 VA: 0x1D2AA40
	|-EnumerableSorter<KeyValuePair<object, int>, int>.CompareKeys
	|
	|-RVA: 0x1D2AD50 Offset: 0x1D2AE51 VA: 0x1D2AD50
	|-EnumerableSorter<DiagnosticEvent, int>.CompareKeys
	|
	|-RVA: 0x1D2B050 Offset: 0x1D2B151 VA: 0x1D2B050
	|-EnumerableSorter<int, int>.CompareKeys
	|
	|-RVA: 0x1D2B350 Offset: 0x1D2B451 VA: 0x1D2B350
	|-EnumerableSorter<object, int>.CompareKeys
	|
	|-RVA: 0x1D2B650 Offset: 0x1D2B751 VA: 0x1D2B650
	|-EnumerableSorter<object, object>.CompareKeys
	|
	|-RVA: 0x1D2B950 Offset: 0x1D2BA51 VA: 0x1D2B950
	|-EnumerableSorter<object, uint>.CompareKeys
	*/
}

