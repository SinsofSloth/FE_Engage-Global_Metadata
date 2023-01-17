// Namespace: System.Linq
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 2750
{
	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5E630 Offset: 0x2A5E731 VA: 0x2A5E630
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x2A5E800 Offset: 0x2A5E901 VA: 0x2A5E800
	|-OrderedEnumerable<DiagnosticEvent, int>..ctor
	|
	|-RVA: 0x2A5E9D0 Offset: 0x2A5EAD1 VA: 0x2A5E9D0
	|-OrderedEnumerable<int, int>..ctor
	|
	|-RVA: 0x2A5EBA0 Offset: 0x2A5ECA1 VA: 0x2A5EBA0
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x2A5ED70 Offset: 0x2A5EE71 VA: 0x2A5ED70
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x2A5EF40 Offset: 0x2A5F041 VA: 0x2A5EF40
	|-OrderedEnumerable<object, uint>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5E730 Offset: 0x2A5E831 VA: 0x2A5E730
	|-OrderedEnumerable<KeyValuePair<object, int>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2A5E900 Offset: 0x2A5EA01 VA: 0x2A5E900
	|-OrderedEnumerable<DiagnosticEvent, int>.GetEnumerableSorter
	|
	|-RVA: 0x2A5EAD0 Offset: 0x2A5EBD1 VA: 0x2A5EAD0
	|-OrderedEnumerable<int, int>.GetEnumerableSorter
	|
	|-RVA: 0x2A5ECA0 Offset: 0x2A5EDA1 VA: 0x2A5ECA0
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|
	|-RVA: 0x2A5EE70 Offset: 0x2A5EF71 VA: 0x2A5EE70
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|
	|-RVA: 0x2A5F040 Offset: 0x2A5F141 VA: 0x2A5F040
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	*/
}

