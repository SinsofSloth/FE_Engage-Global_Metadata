// Namespace: System.Collections.Generic
[DebuggerDisplayAttribute] // RVA: 0x30CC0 Offset: 0x30DC1 VA: 0x30CC0
[DebuggerTypeProxyAttribute] // RVA: 0x30CC0 Offset: 0x30DC1 VA: 0x30CC0
[Serializable]
public class SortedSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 2439
{
	// Fields
	private SortedSet.Node<T> root; // 0x0
	private IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449900 Offset: 0x3449A01 VA: 0x3449900
	|-SortedSet<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x344B760 Offset: 0x344B861 VA: 0x344B760
	|-SortedSet<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x344D5C0 Offset: 0x344D6C1 VA: 0x344D5C0
	|-SortedSet<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x344F470 Offset: 0x344F571 VA: 0x344F470
	|-SortedSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449950 Offset: 0x3449A51 VA: 0x3449950
	|-SortedSet<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x344B7B0 Offset: 0x344B8B1 VA: 0x344B7B0
	|-SortedSet<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x344D610 Offset: 0x344D711 VA: 0x344D610
	|-SortedSet<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x344F4C0 Offset: 0x344F5C1 VA: 0x344F4C0
	|-SortedSet<object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34499B0 Offset: 0x3449AB1 VA: 0x34499B0
	|-SortedSet<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x344B810 Offset: 0x344B911 VA: 0x344B810
	|-SortedSet<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x344D670 Offset: 0x344D771 VA: 0x344D670
	|-SortedSet<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x344F520 Offset: 0x344F621 VA: 0x344F520
	|-SortedSet<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34499F0 Offset: 0x3449AF1 VA: 0x34499F0
	|-SortedSet<KeyValuePair<int, bool>>.InOrderTreeWalk
	|
	|-RVA: 0x344B850 Offset: 0x344B951 VA: 0x344B850
	|-SortedSet<KeyValuePair<int, int>>.InOrderTreeWalk
	|
	|-RVA: 0x344D6B0 Offset: 0x344D7B1 VA: 0x344D6B0
	|-SortedSet<KeyValuePair<object, object>>.InOrderTreeWalk
	|
	|-RVA: 0x344F560 Offset: 0x344F661 VA: 0x344F560
	|-SortedSet<object>.InOrderTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449BB0 Offset: 0x3449CB1 VA: 0x3449BB0
	|-SortedSet<KeyValuePair<int, bool>>.get_Count
	|
	|-RVA: 0x344BA10 Offset: 0x344BB11 VA: 0x344BA10
	|-SortedSet<KeyValuePair<int, int>>.get_Count
	|
	|-RVA: 0x344D870 Offset: 0x344D971 VA: 0x344D870
	|-SortedSet<KeyValuePair<object, object>>.get_Count
	|
	|-RVA: 0x344F720 Offset: 0x344F821 VA: 0x344F720
	|-SortedSet<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449BE0 Offset: 0x3449CE1 VA: 0x3449BE0
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x344BA40 Offset: 0x344BB41 VA: 0x344BA40
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x344D8A0 Offset: 0x344D9A1 VA: 0x344D8A0
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x344F750 Offset: 0x344F851 VA: 0x344F750
	|-SortedSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449BF0 Offset: 0x3449CF1 VA: 0x3449BF0
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x344BA50 Offset: 0x344BB51 VA: 0x344BA50
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x344D8B0 Offset: 0x344D9B1 VA: 0x344D8B0
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x344F760 Offset: 0x344F861 VA: 0x344F760
	|-SortedSet<object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449C00 Offset: 0x3449D01 VA: 0x3449C00
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x344BA60 Offset: 0x344BB61 VA: 0x344BA60
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x344D8C0 Offset: 0x344D9C1 VA: 0x344D8C0
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x344F770 Offset: 0x344F871 VA: 0x344F770
	|-SortedSet<object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal virtual void VersionCheck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449C90 Offset: 0x3449D91 VA: 0x3449C90
	|-SortedSet<KeyValuePair<int, bool>>.VersionCheck
	|
	|-RVA: 0x344BAF0 Offset: 0x344BBF1 VA: 0x344BAF0
	|-SortedSet<KeyValuePair<int, int>>.VersionCheck
	|
	|-RVA: 0x344D950 Offset: 0x344DA51 VA: 0x344D950
	|-SortedSet<KeyValuePair<object, object>>.VersionCheck
	|
	|-RVA: 0x344F800 Offset: 0x344F901 VA: 0x344F800
	|-SortedSet<object>.VersionCheck
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal virtual bool IsWithinRange(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449CA0 Offset: 0x3449DA1 VA: 0x3449CA0
	|-SortedSet<KeyValuePair<int, bool>>.IsWithinRange
	|
	|-RVA: 0x344BB00 Offset: 0x344BC01 VA: 0x344BB00
	|-SortedSet<KeyValuePair<int, int>>.IsWithinRange
	|
	|-RVA: 0x344D960 Offset: 0x344DA61 VA: 0x344D960
	|-SortedSet<KeyValuePair<object, object>>.IsWithinRange
	|
	|-RVA: 0x344F810 Offset: 0x344F911 VA: 0x344F810
	|-SortedSet<object>.IsWithinRange
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449CB0 Offset: 0x3449DB1 VA: 0x3449CB0
	|-SortedSet<KeyValuePair<int, bool>>.Add
	|
	|-RVA: 0x344BB10 Offset: 0x344BC11 VA: 0x344BB10
	|-SortedSet<KeyValuePair<int, int>>.Add
	|
	|-RVA: 0x344D970 Offset: 0x344DA71 VA: 0x344D970
	|-SortedSet<KeyValuePair<object, object>>.Add
	|
	|-RVA: 0x344F820 Offset: 0x344F921 VA: 0x344F820
	|-SortedSet<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449CC0 Offset: 0x3449DC1 VA: 0x3449CC0
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x344BB20 Offset: 0x344BC21 VA: 0x344BB20
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x344D980 Offset: 0x344DA81 VA: 0x344D980
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x344F830 Offset: 0x344F931 VA: 0x344F830
	|-SortedSet<object>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 24
	internal virtual bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3449CE0 Offset: 0x3449DE1 VA: 0x3449CE0
	|-SortedSet<KeyValuePair<int, bool>>.AddIfNotPresent
	|
	|-RVA: 0x344BB40 Offset: 0x344BC41 VA: 0x344BB40
	|-SortedSet<KeyValuePair<int, int>>.AddIfNotPresent
	|
	|-RVA: 0x344D9A0 Offset: 0x344DAA1 VA: 0x344D9A0
	|-SortedSet<KeyValuePair<object, object>>.AddIfNotPresent
	|
	|-RVA: 0x344F850 Offset: 0x344F951 VA: 0x344F850
	|-SortedSet<object>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A020 Offset: 0x344A121 VA: 0x344A020
	|-SortedSet<KeyValuePair<int, bool>>.Remove
	|
	|-RVA: 0x344BE80 Offset: 0x344BF81 VA: 0x344BE80
	|-SortedSet<KeyValuePair<int, int>>.Remove
	|
	|-RVA: 0x344DD00 Offset: 0x344DE01 VA: 0x344DD00
	|-SortedSet<KeyValuePair<object, object>>.Remove
	|
	|-RVA: 0x344FB90 Offset: 0x344FC91 VA: 0x344FB90
	|-SortedSet<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	internal virtual bool DoRemove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A030 Offset: 0x344A131 VA: 0x344A030
	|-SortedSet<KeyValuePair<int, bool>>.DoRemove
	|
	|-RVA: 0x344BE90 Offset: 0x344BF91 VA: 0x344BE90
	|-SortedSet<KeyValuePair<int, int>>.DoRemove
	|
	|-RVA: 0x344DD10 Offset: 0x344DE11 VA: 0x344DD10
	|-SortedSet<KeyValuePair<object, object>>.DoRemove
	|
	|-RVA: 0x344FBA0 Offset: 0x344FCA1 VA: 0x344FBA0
	|-SortedSet<object>.DoRemove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A440 Offset: 0x344A541 VA: 0x344A440
	|-SortedSet<KeyValuePair<int, bool>>.Clear
	|
	|-RVA: 0x344C2A0 Offset: 0x344C3A1 VA: 0x344C2A0
	|-SortedSet<KeyValuePair<int, int>>.Clear
	|
	|-RVA: 0x344E140 Offset: 0x344E241 VA: 0x344E140
	|-SortedSet<KeyValuePair<object, object>>.Clear
	|
	|-RVA: 0x344FFB0 Offset: 0x34500B1 VA: 0x344FFB0
	|-SortedSet<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A480 Offset: 0x344A581 VA: 0x344A480
	|-SortedSet<KeyValuePair<int, bool>>.Contains
	|
	|-RVA: 0x344C2E0 Offset: 0x344C3E1 VA: 0x344C2E0
	|-SortedSet<KeyValuePair<int, int>>.Contains
	|
	|-RVA: 0x344E180 Offset: 0x344E281 VA: 0x344E180
	|-SortedSet<KeyValuePair<object, object>>.Contains
	|
	|-RVA: 0x344FFF0 Offset: 0x34500F1 VA: 0x344FFF0
	|-SortedSet<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A4B0 Offset: 0x344A5B1 VA: 0x344A4B0
	|-SortedSet<KeyValuePair<int, bool>>.CopyTo
	|
	|-RVA: 0x344C310 Offset: 0x344C411 VA: 0x344C310
	|-SortedSet<KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x344E1B0 Offset: 0x344E2B1 VA: 0x344E1B0
	|-SortedSet<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3450020 Offset: 0x3450121 VA: 0x3450020
	|-SortedSet<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A520 Offset: 0x344A621 VA: 0x344A520
	|-SortedSet<KeyValuePair<int, bool>>.CopyTo
	|
	|-RVA: 0x344C380 Offset: 0x344C481 VA: 0x344C380
	|-SortedSet<KeyValuePair<int, int>>.CopyTo
	|
	|-RVA: 0x344E220 Offset: 0x344E321 VA: 0x344E220
	|-SortedSet<KeyValuePair<object, object>>.CopyTo
	|
	|-RVA: 0x3450090 Offset: 0x3450191 VA: 0x3450090
	|-SortedSet<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344A780 Offset: 0x344A881 VA: 0x344A780
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x344C5E0 Offset: 0x344C6E1 VA: 0x344C5E0
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x344E480 Offset: 0x344E581 VA: 0x344E480
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x34502F0 Offset: 0x34503F1 VA: 0x34502F0
	|-SortedSet<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344ABC0 Offset: 0x344ACC1 VA: 0x344ABC0
	|-SortedSet<KeyValuePair<int, bool>>.GetEnumerator
	|
	|-RVA: 0x344CA20 Offset: 0x344CB21 VA: 0x344CA20
	|-SortedSet<KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x344E8C0 Offset: 0x344E9C1 VA: 0x344E8C0
	|-SortedSet<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x3450730 Offset: 0x3450831 VA: 0x3450730
	|-SortedSet<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344AC30 Offset: 0x344AD31 VA: 0x344AC30
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x344CA90 Offset: 0x344CB91 VA: 0x344CA90
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x344E930 Offset: 0x344EA31 VA: 0x344E930
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x34507A0 Offset: 0x34508A1 VA: 0x34507A0
	|-SortedSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344ACC0 Offset: 0x344ADC1 VA: 0x344ACC0
	|-SortedSet<KeyValuePair<int, bool>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x344CB20 Offset: 0x344CC21 VA: 0x344CB20
	|-SortedSet<KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x344E9C0 Offset: 0x344EAC1 VA: 0x344E9C0
	|-SortedSet<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3450830 Offset: 0x3450931 VA: 0x3450830
	|-SortedSet<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void InsertionBalance(SortedSet.Node<T> current, ref SortedSet.Node<T> parent, SortedSet.Node<T> grandParent, SortedSet.Node<T> greatGrandParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344AD50 Offset: 0x344AE51 VA: 0x344AD50
	|-SortedSet<KeyValuePair<int, bool>>.InsertionBalance
	|
	|-RVA: 0x344CBB0 Offset: 0x344CCB1 VA: 0x344CBB0
	|-SortedSet<KeyValuePair<int, int>>.InsertionBalance
	|
	|-RVA: 0x344EA50 Offset: 0x344EB51 VA: 0x344EA50
	|-SortedSet<KeyValuePair<object, object>>.InsertionBalance
	|
	|-RVA: 0x34508C0 Offset: 0x34509C1 VA: 0x34508C0
	|-SortedSet<object>.InsertionBalance
	*/

	// RVA: -1 Offset: -1
	private void ReplaceChildOrRoot(SortedSet.Node<T> parent, SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344AEA0 Offset: 0x344AFA1 VA: 0x344AEA0
	|-SortedSet<KeyValuePair<int, bool>>.ReplaceChildOrRoot
	|
	|-RVA: 0x344CD00 Offset: 0x344CE01 VA: 0x344CD00
	|-SortedSet<KeyValuePair<int, int>>.ReplaceChildOrRoot
	|
	|-RVA: 0x344EBA0 Offset: 0x344ECA1 VA: 0x344EBA0
	|-SortedSet<KeyValuePair<object, object>>.ReplaceChildOrRoot
	|
	|-RVA: 0x3450A10 Offset: 0x3450B11 VA: 0x3450A10
	|-SortedSet<object>.ReplaceChildOrRoot
	*/

	// RVA: -1 Offset: -1
	private void ReplaceNode(SortedSet.Node<T> match, SortedSet.Node<T> parentOfMatch, SortedSet.Node<T> successor, SortedSet.Node<T> parentOfSuccessor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344AEE0 Offset: 0x344AFE1 VA: 0x344AEE0
	|-SortedSet<KeyValuePair<int, bool>>.ReplaceNode
	|
	|-RVA: 0x344CD40 Offset: 0x344CE41 VA: 0x344CD40
	|-SortedSet<KeyValuePair<int, int>>.ReplaceNode
	|
	|-RVA: 0x344EBE0 Offset: 0x344ECE1 VA: 0x344EBE0
	|-SortedSet<KeyValuePair<object, object>>.ReplaceNode
	|
	|-RVA: 0x3450A50 Offset: 0x3450B51 VA: 0x3450A50
	|-SortedSet<object>.ReplaceNode
	*/

	// RVA: -1 Offset: -1 Slot: 28
	internal virtual SortedSet.Node<T> FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B070 Offset: 0x344B171 VA: 0x344B070
	|-SortedSet<KeyValuePair<int, bool>>.FindNode
	|
	|-RVA: 0x344CED0 Offset: 0x344CFD1 VA: 0x344CED0
	|-SortedSet<KeyValuePair<int, int>>.FindNode
	|
	|-RVA: 0x344ED70 Offset: 0x344EE71 VA: 0x344ED70
	|-SortedSet<KeyValuePair<object, object>>.FindNode
	|
	|-RVA: 0x3450BE0 Offset: 0x3450CE1 VA: 0x3450BE0
	|-SortedSet<object>.FindNode
	*/

	// RVA: -1 Offset: -1
	internal void UpdateVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B190 Offset: 0x344B291 VA: 0x344B190
	|-SortedSet<KeyValuePair<int, bool>>.UpdateVersion
	|
	|-RVA: 0x344CFF0 Offset: 0x344D0F1 VA: 0x344CFF0
	|-SortedSet<KeyValuePair<int, int>>.UpdateVersion
	|
	|-RVA: 0x344EEA0 Offset: 0x344EFA1 VA: 0x344EEA0
	|-SortedSet<KeyValuePair<object, object>>.UpdateVersion
	|
	|-RVA: 0x3450D00 Offset: 0x3450E01 VA: 0x3450D00
	|-SortedSet<object>.UpdateVersion
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B1A0 Offset: 0x344B2A1 VA: 0x344B1A0
	|-SortedSet<KeyValuePair<int, bool>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x344D000 Offset: 0x344D101 VA: 0x344D000
	|-SortedSet<KeyValuePair<int, int>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x344EEB0 Offset: 0x344EFB1 VA: 0x344EEB0
	|-SortedSet<KeyValuePair<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x3450D10 Offset: 0x3450E11 VA: 0x3450D10
	|-SortedSet<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B1B0 Offset: 0x344B2B1 VA: 0x344B1B0
	|-SortedSet<KeyValuePair<int, bool>>.GetObjectData
	|
	|-RVA: 0x344D010 Offset: 0x344D111 VA: 0x344D010
	|-SortedSet<KeyValuePair<int, int>>.GetObjectData
	|
	|-RVA: 0x344EEC0 Offset: 0x344EFC1 VA: 0x344EEC0
	|-SortedSet<KeyValuePair<object, object>>.GetObjectData
	|
	|-RVA: 0x3450D20 Offset: 0x3450E21 VA: 0x3450D20
	|-SortedSet<object>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B3F0 Offset: 0x344B4F1 VA: 0x344B3F0
	|-SortedSet<KeyValuePair<int, bool>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x344D250 Offset: 0x344D351 VA: 0x344D250
	|-SortedSet<KeyValuePair<int, int>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x344F100 Offset: 0x344F201 VA: 0x344F100
	|-SortedSet<KeyValuePair<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x3450F60 Offset: 0x3451061 VA: 0x3450F60
	|-SortedSet<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B400 Offset: 0x344B501 VA: 0x344B400
	|-SortedSet<KeyValuePair<int, bool>>.OnDeserialization
	|
	|-RVA: 0x344D260 Offset: 0x344D361 VA: 0x344D260
	|-SortedSet<KeyValuePair<int, int>>.OnDeserialization
	|
	|-RVA: 0x344F110 Offset: 0x344F211 VA: 0x344F110
	|-SortedSet<KeyValuePair<object, object>>.OnDeserialization
	|
	|-RVA: 0x3450F70 Offset: 0x3451071 VA: 0x3450F70
	|-SortedSet<object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private static int Log2(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x344B730 Offset: 0x344B831 VA: 0x344B730
	|-SortedSet<KeyValuePair<int, bool>>.Log2
	|
	|-RVA: 0x344D590 Offset: 0x344D691 VA: 0x344D590
	|-SortedSet<KeyValuePair<int, int>>.Log2
	|
	|-RVA: 0x344F440 Offset: 0x344F541 VA: 0x344F440
	|-SortedSet<KeyValuePair<object, object>>.Log2
	|
	|-RVA: 0x34512A0 Offset: 0x34513A1 VA: 0x34512A0
	|-SortedSet<object>.Log2
	*/
}

