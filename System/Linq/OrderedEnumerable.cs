// Namespace: System.Linq
internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 2749
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x41960 Offset: 0x41A61 VA: 0x41960
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5E370 Offset: 0x2A5E471 VA: 0x2A5E370
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|
	|-RVA: 0x2A5E420 Offset: 0x2A5E521 VA: 0x2A5E420
	|-OrderedEnumerable<DiagnosticEvent>.GetEnumerator
	|
	|-RVA: 0x2A5E4D0 Offset: 0x2A5E5D1 VA: 0x2A5E4D0
	|-OrderedEnumerable<int>.GetEnumerator
	|
	|-RVA: 0x2A5E580 Offset: 0x2A5E681 VA: 0x2A5E580
	|-OrderedEnumerable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<object>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5E3F0 Offset: 0x2A5E4F1 VA: 0x2A5E3F0
	|-OrderedEnumerable<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A5E4A0 Offset: 0x2A5E5A1 VA: 0x2A5E4A0
	|-OrderedEnumerable<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A5E550 Offset: 0x2A5E651 VA: 0x2A5E550
	|-OrderedEnumerable<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A5E600 Offset: 0x2A5E701 VA: 0x2A5E600
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553C50 Offset: 0x2553D51 VA: 0x2553C50
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|
	|-RVA: 0x2553CF0 Offset: 0x2553DF1 VA: 0x2553CF0
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5E410 Offset: 0x2A5E511 VA: 0x2A5E410
	|-OrderedEnumerable<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2A5E4C0 Offset: 0x2A5E5C1 VA: 0x2A5E4C0
	|-OrderedEnumerable<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2A5E570 Offset: 0x2A5E671 VA: 0x2A5E570
	|-OrderedEnumerable<int>..ctor
	|
	|-RVA: 0x2A5E620 Offset: 0x2A5E721 VA: 0x2A5E620
	|-OrderedEnumerable<object>..ctor
	*/
}

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

