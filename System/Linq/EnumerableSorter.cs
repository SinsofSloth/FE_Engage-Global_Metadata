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

