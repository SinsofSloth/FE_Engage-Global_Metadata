// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x30A70 Offset: 0x30B71 VA: 0x30A70
[DebuggerDisplayAttribute] // RVA: 0x30A70 Offset: 0x30B71 VA: 0x30A70
[DebuggerTypeProxyAttribute] // RVA: 0x30A70 Offset: 0x30B71 VA: 0x30A70
[Serializable]
public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 2432
{
	// Fields
	private SortedDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private SortedDictionary.ValueCollection<TKey, TValue> _values; // 0x0
	private TreeSet<KeyValuePair<TKey, TValue>> _set; // 0x0

	// Properties
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public SortedDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	public SortedDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444BA0 Offset: 0x3444CA1 VA: 0x3444BA0
	|-SortedDictionary<int, bool>..ctor
	|
	|-RVA: 0x3446500 Offset: 0x3446601 VA: 0x3446500
	|-SortedDictionary<int, int>..ctor
	|
	|-RVA: 0x3447E40 Offset: 0x3447F41 VA: 0x3447E40
	|-SortedDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444BC0 Offset: 0x3444CC1 VA: 0x3444BC0
	|-SortedDictionary<int, bool>..ctor
	|
	|-RVA: 0x3446520 Offset: 0x3446621 VA: 0x3446520
	|-SortedDictionary<int, int>..ctor
	|
	|-RVA: 0x3447E60 Offset: 0x3447F61 VA: 0x3447E60
	|-SortedDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444C80 Offset: 0x3444D81 VA: 0x3444C80
	|-SortedDictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x34465E0 Offset: 0x34466E1 VA: 0x34465E0
	|-SortedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x3447F20 Offset: 0x3448021 VA: 0x3447F20
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444CA0 Offset: 0x3444DA1 VA: 0x3444CA0
	|-SortedDictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3446600 Offset: 0x3446701 VA: 0x3446600
	|-SortedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x3447F40 Offset: 0x3448041 VA: 0x3447F40
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444D50 Offset: 0x3444E51 VA: 0x3444D50
	|-SortedDictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x34466A0 Offset: 0x34467A1 VA: 0x34466A0
	|-SortedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x3447FF0 Offset: 0x34480F1 VA: 0x3447FF0
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444E20 Offset: 0x3444F21 VA: 0x3444E20
	|-SortedDictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x3446770 Offset: 0x3446871 VA: 0x3446770
	|-SortedDictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x34480C0 Offset: 0x34481C1 VA: 0x34480C0
	|-SortedDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444E30 Offset: 0x3444F31 VA: 0x3444E30
	|-SortedDictionary<int, bool>.get_Item
	|
	|-RVA: 0x3446780 Offset: 0x3446881 VA: 0x3446780
	|-SortedDictionary<int, int>.get_Item
	|
	|-RVA: 0x34480D0 Offset: 0x34481D1 VA: 0x34480D0
	|-SortedDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444EF0 Offset: 0x3444FF1 VA: 0x3444EF0
	|-SortedDictionary<int, bool>.set_Item
	|
	|-RVA: 0x3446830 Offset: 0x3446931 VA: 0x3446830
	|-SortedDictionary<int, int>.set_Item
	|
	|-RVA: 0x34481C0 Offset: 0x34482C1 VA: 0x34481C0
	|-SortedDictionary<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445020 Offset: 0x3445121 VA: 0x3445020
	|-SortedDictionary<int, bool>.get_Count
	|
	|-RVA: 0x3446960 Offset: 0x3446A61 VA: 0x3446960
	|-SortedDictionary<int, int>.get_Count
	|
	|-RVA: 0x3448340 Offset: 0x3448441 VA: 0x3448340
	|-SortedDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445040 Offset: 0x3445141 VA: 0x3445040
	|-SortedDictionary<int, bool>.get_Keys
	|
	|-RVA: 0x3446980 Offset: 0x3446A81 VA: 0x3446980
	|-SortedDictionary<int, int>.get_Keys
	|
	|-RVA: 0x3448360 Offset: 0x3448461 VA: 0x3448360
	|-SortedDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34450E0 Offset: 0x34451E1 VA: 0x34450E0
	|-SortedDictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3446A20 Offset: 0x3446B21 VA: 0x3446A20
	|-SortedDictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x3448400 Offset: 0x3448501 VA: 0x3448400
	|-SortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445100 Offset: 0x3445201 VA: 0x3445100
	|-SortedDictionary<int, bool>.get_Values
	|
	|-RVA: 0x3446A40 Offset: 0x3446B41 VA: 0x3446A40
	|-SortedDictionary<int, int>.get_Values
	|
	|-RVA: 0x3448420 Offset: 0x3448521 VA: 0x3448420
	|-SortedDictionary<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34451A0 Offset: 0x34452A1 VA: 0x34451A0
	|-SortedDictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x3446AE0 Offset: 0x3446BE1 VA: 0x3446AE0
	|-SortedDictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x34484C0 Offset: 0x34485C1 VA: 0x34484C0
	|-SortedDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34451C0 Offset: 0x34452C1 VA: 0x34451C0
	|-SortedDictionary<int, bool>.Add
	|
	|-RVA: 0x3446B00 Offset: 0x3446C01 VA: 0x3446B00
	|-SortedDictionary<int, int>.Add
	|
	|-RVA: 0x34484E0 Offset: 0x34485E1 VA: 0x34484E0
	|-SortedDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445220 Offset: 0x3445321 VA: 0x3445220
	|-SortedDictionary<int, bool>.Clear
	|
	|-RVA: 0x3446B60 Offset: 0x3446C61 VA: 0x3446B60
	|-SortedDictionary<int, int>.Clear
	|
	|-RVA: 0x3448590 Offset: 0x3448691 VA: 0x3448590
	|-SortedDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445240 Offset: 0x3445341 VA: 0x3445240
	|-SortedDictionary<int, bool>.ContainsKey
	|
	|-RVA: 0x3446B80 Offset: 0x3446C81 VA: 0x3446B80
	|-SortedDictionary<int, int>.ContainsKey
	|
	|-RVA: 0x34485B0 Offset: 0x34486B1 VA: 0x34485B0
	|-SortedDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34452A0 Offset: 0x34453A1 VA: 0x34452A0
	|-SortedDictionary<int, bool>.ContainsValue
	|
	|-RVA: 0x3446BE0 Offset: 0x3446CE1 VA: 0x3446BE0
	|-SortedDictionary<int, int>.ContainsValue
	|
	|-RVA: 0x3448660 Offset: 0x3448761 VA: 0x3448660
	|-SortedDictionary<object, object>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34453F0 Offset: 0x34454F1 VA: 0x34453F0
	|-SortedDictionary<int, bool>.CopyTo
	|
	|-RVA: 0x3446D30 Offset: 0x3446E31 VA: 0x3446D30
	|-SortedDictionary<int, int>.CopyTo
	|
	|-RVA: 0x3448820 Offset: 0x3448921 VA: 0x3448820
	|-SortedDictionary<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445410 Offset: 0x3445511 VA: 0x3445410
	|-SortedDictionary<int, bool>.GetEnumerator
	|
	|-RVA: 0x3446D50 Offset: 0x3446E51 VA: 0x3446D50
	|-SortedDictionary<int, int>.GetEnumerator
	|
	|-RVA: 0x3448840 Offset: 0x3448941 VA: 0x3448840
	|-SortedDictionary<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445480 Offset: 0x3445581 VA: 0x3445480
	|-SortedDictionary<int, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x3446DC0 Offset: 0x3446EC1 VA: 0x3446DC0
	|-SortedDictionary<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x34488B0 Offset: 0x34489B1 VA: 0x34488B0
	|-SortedDictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445510 Offset: 0x3445611 VA: 0x3445510
	|-SortedDictionary<int, bool>.Remove
	|
	|-RVA: 0x3446E50 Offset: 0x3446F51 VA: 0x3446E50
	|-SortedDictionary<int, int>.Remove
	|
	|-RVA: 0x3448940 Offset: 0x3448A41 VA: 0x3448940
	|-SortedDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445580 Offset: 0x3445681 VA: 0x3445580
	|-SortedDictionary<int, bool>.TryGetValue
	|
	|-RVA: 0x3446EC0 Offset: 0x3446FC1 VA: 0x3446EC0
	|-SortedDictionary<int, int>.TryGetValue
	|
	|-RVA: 0x34489F0 Offset: 0x3448AF1 VA: 0x34489F0
	|-SortedDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445620 Offset: 0x3445721 VA: 0x3445620
	|-SortedDictionary<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3446F60 Offset: 0x3447061 VA: 0x3446F60
	|-SortedDictionary<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3448AE0 Offset: 0x3448BE1 VA: 0x3448AE0
	|-SortedDictionary<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34456E0 Offset: 0x34457E1 VA: 0x34456E0
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3447020 Offset: 0x3447121 VA: 0x3447020
	|-SortedDictionary<int, int>.System.Collections.IDictionary.get_IsFixedSize
	|
	|-RVA: 0x3448BA0 Offset: 0x3448CA1 VA: 0x3448BA0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34456F0 Offset: 0x34457F1 VA: 0x34456F0
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3447030 Offset: 0x3447131 VA: 0x3447030
	|-SortedDictionary<int, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x3448BB0 Offset: 0x3448CB1 VA: 0x3448BB0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445700 Offset: 0x3445801 VA: 0x3445700
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3447040 Offset: 0x3447141 VA: 0x3447040
	|-SortedDictionary<int, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x3448BC0 Offset: 0x3448CC1 VA: 0x3448BC0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445720 Offset: 0x3445821 VA: 0x3445720
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3447060 Offset: 0x3447161 VA: 0x3447060
	|-SortedDictionary<int, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x3448BE0 Offset: 0x3448CE1 VA: 0x3448BE0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445740 Offset: 0x3445841 VA: 0x3445740
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3447080 Offset: 0x3447181 VA: 0x3447080
	|-SortedDictionary<int, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x3448C00 Offset: 0x3448D01 VA: 0x3448C00
	|-SortedDictionary<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445840 Offset: 0x3445941 VA: 0x3445840
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3447180 Offset: 0x3447281 VA: 0x3447180
	|-SortedDictionary<int, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x3448CD0 Offset: 0x3448DD1 VA: 0x3448CD0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3445C80 Offset: 0x3445D81 VA: 0x3445C80
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x34475C0 Offset: 0x34476C1 VA: 0x34475C0
	|-SortedDictionary<int, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x34490D0 Offset: 0x34491D1 VA: 0x34490D0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34460C0 Offset: 0x34461C1 VA: 0x34460C0
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x3447A00 Offset: 0x3447B01 VA: 0x3447A00
	|-SortedDictionary<int, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x34494D0 Offset: 0x34495D1 VA: 0x34494D0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34461A0 Offset: 0x34462A1 VA: 0x34461A0
	|-SortedDictionary<int, bool>.IsCompatibleKey
	|
	|-RVA: 0x3447AE0 Offset: 0x3447BE1 VA: 0x3447AE0
	|-SortedDictionary<int, int>.IsCompatibleKey
	|
	|-RVA: 0x34495A0 Offset: 0x34496A1 VA: 0x34495A0
	|-SortedDictionary<object, object>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3446250 Offset: 0x3446351 VA: 0x3446250
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3447B90 Offset: 0x3447C91 VA: 0x3447B90
	|-SortedDictionary<int, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x3449650 Offset: 0x3449751 VA: 0x3449650
	|-SortedDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34462E0 Offset: 0x34463E1 VA: 0x34462E0
	|-SortedDictionary<int, bool>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x3447C20 Offset: 0x3447D21 VA: 0x3447C20
	|-SortedDictionary<int, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x34496E0 Offset: 0x34497E1 VA: 0x34496E0
	|-SortedDictionary<object, object>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34463B0 Offset: 0x34464B1 VA: 0x34463B0
	|-SortedDictionary<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3447CF0 Offset: 0x3447DF1 VA: 0x3447CF0
	|-SortedDictionary<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x34497B0 Offset: 0x34498B1 VA: 0x34497B0
	|-SortedDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34463C0 Offset: 0x34464C1 VA: 0x34463C0
	|-SortedDictionary<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3447D00 Offset: 0x3447E01 VA: 0x3447D00
	|-SortedDictionary<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x34497C0 Offset: 0x34498C1 VA: 0x34497C0
	|-SortedDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3446470 Offset: 0x3446571 VA: 0x3446470
	|-SortedDictionary<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3447DB0 Offset: 0x3447EB1 VA: 0x3447DB0
	|-SortedDictionary<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3449870 Offset: 0x3449971 VA: 0x3449870
	|-SortedDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

