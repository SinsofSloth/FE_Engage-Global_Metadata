// Namespace: 
public struct SortedDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 2418
{
	// Fields
	private SortedSet.Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	internal bool NotStartedOrEnded { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E600 Offset: 0x349E701 VA: 0x349E600
	|-SortedDictionary.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x34A2F00 Offset: 0x34A3001 VA: 0x34A2F00
	|-SortedDictionary.Enumerator<int, int>..ctor
	|
	|-RVA: 0x35D5530 Offset: 0x35D5631 VA: 0x35D5530
	|-SortedDictionary.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E6C0 Offset: 0x349E7C1 VA: 0x349E6C0
	|-SortedDictionary.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x34A2FC0 Offset: 0x34A30C1 VA: 0x34A2FC0
	|-SortedDictionary.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x35D55F0 Offset: 0x35D56F1 VA: 0x35D55F0
	|-SortedDictionary.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E700 Offset: 0x349E801 VA: 0x349E700
	|-SortedDictionary.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x34A3000 Offset: 0x34A3101 VA: 0x34A3000
	|-SortedDictionary.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x35D5630 Offset: 0x35D5731 VA: 0x35D5630
	|-SortedDictionary.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E740 Offset: 0x349E841 VA: 0x349E740
	|-SortedDictionary.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x34A3040 Offset: 0x34A3141 VA: 0x34A3040
	|-SortedDictionary.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x35D5670 Offset: 0x35D5771 VA: 0x35D5670
	|-SortedDictionary.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E780 Offset: 0x349E881 VA: 0x349E780
	|-SortedDictionary.Enumerator<int, bool>.get_NotStartedOrEnded
	|
	|-RVA: 0x34A3080 Offset: 0x34A3181 VA: 0x34A3080
	|-SortedDictionary.Enumerator<int, int>.get_NotStartedOrEnded
	|
	|-RVA: 0x35D56B0 Offset: 0x35D57B1 VA: 0x35D56B0
	|-SortedDictionary.Enumerator<object, object>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E7C0 Offset: 0x349E8C1 VA: 0x349E7C0
	|-SortedDictionary.Enumerator<int, bool>.Reset
	|
	|-RVA: 0x34A30C0 Offset: 0x34A31C1 VA: 0x34A30C0
	|-SortedDictionary.Enumerator<int, int>.Reset
	|
	|-RVA: 0x35D56F0 Offset: 0x35D57F1 VA: 0x35D56F0
	|-SortedDictionary.Enumerator<object, object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E800 Offset: 0x349E901 VA: 0x349E800
	|-SortedDictionary.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A3100 Offset: 0x34A3201 VA: 0x34A3100
	|-SortedDictionary.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D5730 Offset: 0x35D5831 VA: 0x35D5730
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349E840 Offset: 0x349E941 VA: 0x349E840
	|-SortedDictionary.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A3140 Offset: 0x34A3241 VA: 0x34A3140
	|-SortedDictionary.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D5770 Offset: 0x35D5871 VA: 0x35D5770
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349EB60 Offset: 0x349EC61 VA: 0x349EB60
	|-SortedDictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x34A3470 Offset: 0x34A3571 VA: 0x34A3470
	|-SortedDictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x35D59B0 Offset: 0x35D5AB1 VA: 0x35D59B0
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349ECD0 Offset: 0x349EDD1 VA: 0x349ECD0
	|-SortedDictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x34A35E0 Offset: 0x34A36E1 VA: 0x34A35E0
	|-SortedDictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x35D5AC0 Offset: 0x35D5BC1 VA: 0x35D5AC0
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349EE30 Offset: 0x349EF31 VA: 0x349EE30
	|-SortedDictionary.Enumerator<int, bool>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x34A3750 Offset: 0x34A3851 VA: 0x34A3750
	|-SortedDictionary.Enumerator<int, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x35D5BD0 Offset: 0x35D5CD1 VA: 0x35D5BD0
	|-SortedDictionary.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	*/
}

// Namespace: 
public struct SortedDictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 2419
{
	// Fields
	private SortedDictionary.Enumerator<TKey, TValue> _dictEnum; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F5A0 Offset: 0x349F6A1 VA: 0x349F5A0
	|-SortedDictionary.KeyCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x34A3ED0 Offset: 0x34A3FD1 VA: 0x34A3ED0
	|-SortedDictionary.KeyCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x35D6240 Offset: 0x35D6341 VA: 0x35D6240
	|-SortedDictionary.KeyCollection.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F660 Offset: 0x349F761 VA: 0x349F660
	|-SortedDictionary.KeyCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x34A3F90 Offset: 0x34A4091 VA: 0x34A3F90
	|-SortedDictionary.KeyCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x35D6300 Offset: 0x35D6401 VA: 0x35D6300
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F6C0 Offset: 0x349F7C1 VA: 0x349F6C0
	|-SortedDictionary.KeyCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x34A3FF0 Offset: 0x34A40F1 VA: 0x34A3FF0
	|-SortedDictionary.KeyCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x35D6360 Offset: 0x35D6461 VA: 0x35D6360
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F720 Offset: 0x349F821 VA: 0x349F720
	|-SortedDictionary.KeyCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x34A4050 Offset: 0x34A4151 VA: 0x34A4050
	|-SortedDictionary.KeyCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x35D63C0 Offset: 0x35D64C1 VA: 0x35D63C0
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F7A0 Offset: 0x349F8A1 VA: 0x349F7A0
	|-SortedDictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A40D0 Offset: 0x34A41D1 VA: 0x34A40D0
	|-SortedDictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D6440 Offset: 0x35D6541 VA: 0x35D6440
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F930 Offset: 0x349FA31 VA: 0x349F930
	|-SortedDictionary.KeyCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A4260 Offset: 0x34A4361 VA: 0x34A4260
	|-SortedDictionary.KeyCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D6570 Offset: 0x35D6671 VA: 0x35D6570
	|-SortedDictionary.KeyCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30BB0 Offset: 0x30CB1 VA: 0x30BB0
private sealed class SortedDictionary.KeyCollection.<>c__DisplayClass5_0<TKey, TValue> // TypeDefIndex: 2420
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3ED60 Offset: 0x2B3EE61 VA: 0x2B3ED60
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<int, bool>..ctor
	|
	|-RVA: 0x2B3EE70 Offset: 0x2B3EF71 VA: 0x2B3EE70
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<int, int>..ctor
	|
	|-RVA: 0x2B3EF70 Offset: 0x2B3F071 VA: 0x2B3EF70
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3ED70 Offset: 0x2B3EE71 VA: 0x2B3ED70
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<int, bool>.<CopyTo>b__0
	|
	|-RVA: 0x2B3EE80 Offset: 0x2B3EF81 VA: 0x2B3EE80
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<int, int>.<CopyTo>b__0
	|
	|-RVA: 0x2B3EF80 Offset: 0x2B3F081 VA: 0x2B3EF80
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<object, object>.<CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30BC0 Offset: 0x30CC1 VA: 0x30BC0
private sealed class SortedDictionary.KeyCollection.<>c__DisplayClass6_0<TKey, TValue> // TypeDefIndex: 2421
{
	// Fields
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F0B0 Offset: 0x2B3F1B1 VA: 0x2B3F0B0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<int, bool>..ctor
	|
	|-RVA: 0x2B3F0D0 Offset: 0x2B3F1D1 VA: 0x2B3F0D0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<int, int>..ctor
	|
	|-RVA: 0x2B3F0F0 Offset: 0x2B3F1F1 VA: 0x2B3F0F0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<object, object>..ctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30BD0 Offset: 0x30CD1 VA: 0x30BD0
private sealed class SortedDictionary.KeyCollection.<>c__DisplayClass6_1<TKey, TValue> // TypeDefIndex: 2422
{
	// Fields
	public object[] objects; // 0x0
	public SortedDictionary.KeyCollection.<>c__DisplayClass6_0<TKey, TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F8F0 Offset: 0x2B3F9F1 VA: 0x2B3F8F0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_1<int, bool>..ctor
	|
	|-RVA: 0x2B3FAC0 Offset: 0x2B3FBC1 VA: 0x2B3FAC0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_1<int, int>..ctor
	|
	|-RVA: 0x2B3FC90 Offset: 0x2B3FD91 VA: 0x2B3FC90
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_1<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F900 Offset: 0x2B3FA01 VA: 0x2B3F900
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_1<int, bool>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3FAD0 Offset: 0x2B3FBD1 VA: 0x2B3FAD0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_1<int, int>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3FCA0 Offset: 0x2B3FDA1 VA: 0x2B3FCA0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_1<object, object>.<System.Collections.ICollection.CopyTo>b__0
	*/
}

// Namespace: 
[DebuggerTypeProxyAttribute] // RVA: 0x30B20 Offset: 0x30C21 VA: 0x30B20
[DebuggerDisplayAttribute] // RVA: 0x30B20 Offset: 0x30C21 VA: 0x30B20
[Serializable]
public sealed class SortedDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 2423
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F82C60 Offset: 0x2F82D61 VA: 0x2F82C60
	|-SortedDictionary.KeyCollection<int, bool>..ctor
	|
	|-RVA: 0x2F85EE0 Offset: 0x2F85FE1 VA: 0x2F85EE0
	|-SortedDictionary.KeyCollection<int, int>..ctor
	|
	|-RVA: 0x288F2E0 Offset: 0x288F3E1 VA: 0x288F2E0
	|-SortedDictionary.KeyCollection<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F82CE0 Offset: 0x2F82DE1 VA: 0x2F82CE0
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2F85F60 Offset: 0x2F86061 VA: 0x2F85F60
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x288F360 Offset: 0x288F461 VA: 0x288F360
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F82D70 Offset: 0x2F82E71 VA: 0x2F82D70
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F85FF0 Offset: 0x2F860F1 VA: 0x2F85FF0
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x288F3F0 Offset: 0x288F4F1 VA: 0x288F3F0
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F82E00 Offset: 0x2F82F01 VA: 0x2F82E00
	|-SortedDictionary.KeyCollection<int, bool>.CopyTo
	|
	|-RVA: 0x2F86080 Offset: 0x2F86181 VA: 0x2F86080
	|-SortedDictionary.KeyCollection<int, int>.CopyTo
	|
	|-RVA: 0x288F480 Offset: 0x288F581 VA: 0x288F480
	|-SortedDictionary.KeyCollection<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F83020 Offset: 0x2F83121 VA: 0x2F83020
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2F862A0 Offset: 0x2F863A1 VA: 0x2F862A0
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x288F6A0 Offset: 0x288F7A1 VA: 0x288F6A0
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F83470 Offset: 0x2F83571 VA: 0x2F83470
	|-SortedDictionary.KeyCollection<int, bool>.get_Count
	|
	|-RVA: 0x2F866F0 Offset: 0x2F867F1 VA: 0x2F866F0
	|-SortedDictionary.KeyCollection<int, int>.get_Count
	|
	|-RVA: 0x288FAF0 Offset: 0x288FBF1 VA: 0x288FAF0
	|-SortedDictionary.KeyCollection<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F83490 Offset: 0x2F83591 VA: 0x2F83490
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2F86710 Offset: 0x2F86811 VA: 0x2F86710
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x288FB10 Offset: 0x288FC11 VA: 0x288FB10
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F834A0 Offset: 0x2F835A1 VA: 0x2F834A0
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2F86720 Offset: 0x2F86821 VA: 0x2F86720
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x288FB20 Offset: 0x288FC21 VA: 0x288FB20
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F83500 Offset: 0x2F83601 VA: 0x2F83500
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2F86780 Offset: 0x2F86881 VA: 0x2F86780
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x288FB80 Offset: 0x288FC81 VA: 0x288FB80
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F83560 Offset: 0x2F83661 VA: 0x2F83560
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2F867E0 Offset: 0x2F868E1 VA: 0x2F867E0
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x288FBE0 Offset: 0x288FCE1 VA: 0x288FBE0
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F83580 Offset: 0x2F83681 VA: 0x2F83580
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2F86800 Offset: 0x2F86901 VA: 0x2F86800
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x288FC00 Offset: 0x288FD01 VA: 0x288FC00
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F835E0 Offset: 0x2F836E1 VA: 0x2F835E0
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2F86860 Offset: 0x2F86961 VA: 0x2F86860
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x288FC60 Offset: 0x288FD61 VA: 0x288FC60
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F835F0 Offset: 0x2F836F1 VA: 0x2F835F0
	|-SortedDictionary.KeyCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2F86870 Offset: 0x2F86971 VA: 0x2F86870
	|-SortedDictionary.KeyCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x288FC70 Offset: 0x288FD71 VA: 0x288FC70
	|-SortedDictionary.KeyCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: 
public struct SortedDictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 2424
{
	// Fields
	private SortedDictionary.Enumerator<TKey, TValue> _dictEnum; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349F990 Offset: 0x349FA91 VA: 0x349F990
	|-SortedDictionary.ValueCollection.Enumerator<int, bool>..ctor
	|
	|-RVA: 0x34A42C0 Offset: 0x34A43C1 VA: 0x34A42C0
	|-SortedDictionary.ValueCollection.Enumerator<int, int>..ctor
	|
	|-RVA: 0x35D65D0 Offset: 0x35D66D1 VA: 0x35D65D0
	|-SortedDictionary.ValueCollection.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349FA50 Offset: 0x349FB51 VA: 0x349FA50
	|-SortedDictionary.ValueCollection.Enumerator<int, bool>.Dispose
	|
	|-RVA: 0x34A4380 Offset: 0x34A4481 VA: 0x34A4380
	|-SortedDictionary.ValueCollection.Enumerator<int, int>.Dispose
	|
	|-RVA: 0x35D6690 Offset: 0x35D6791 VA: 0x35D6690
	|-SortedDictionary.ValueCollection.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349FAB0 Offset: 0x349FBB1 VA: 0x349FAB0
	|-SortedDictionary.ValueCollection.Enumerator<int, bool>.MoveNext
	|
	|-RVA: 0x34A43E0 Offset: 0x34A44E1 VA: 0x34A43E0
	|-SortedDictionary.ValueCollection.Enumerator<int, int>.MoveNext
	|
	|-RVA: 0x35D66F0 Offset: 0x35D67F1 VA: 0x35D66F0
	|-SortedDictionary.ValueCollection.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349FB10 Offset: 0x349FC11 VA: 0x349FB10
	|-SortedDictionary.ValueCollection.Enumerator<int, bool>.get_Current
	|
	|-RVA: 0x34A4440 Offset: 0x34A4541 VA: 0x34A4440
	|-SortedDictionary.ValueCollection.Enumerator<int, int>.get_Current
	|
	|-RVA: 0x35D6750 Offset: 0x35D6851 VA: 0x35D6750
	|-SortedDictionary.ValueCollection.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349FBA0 Offset: 0x349FCA1 VA: 0x349FBA0
	|-SortedDictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34A44C0 Offset: 0x34A45C1 VA: 0x34A44C0
	|-SortedDictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x35D67D0 Offset: 0x35D68D1 VA: 0x35D67D0
	|-SortedDictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x349FD20 Offset: 0x349FE21 VA: 0x349FD20
	|-SortedDictionary.ValueCollection.Enumerator<int, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34A4650 Offset: 0x34A4751 VA: 0x34A4650
	|-SortedDictionary.ValueCollection.Enumerator<int, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x35D6900 Offset: 0x35D6A01 VA: 0x35D6900
	|-SortedDictionary.ValueCollection.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30C70 Offset: 0x30D71 VA: 0x30C70
private sealed class SortedDictionary.ValueCollection.<>c__DisplayClass5_0<TKey, TValue> // TypeDefIndex: 2425
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3EDE0 Offset: 0x2B3EEE1 VA: 0x2B3EDE0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<int, bool>..ctor
	|
	|-RVA: 0x2B3EEF0 Offset: 0x2B3EFF1 VA: 0x2B3EEF0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<int, int>..ctor
	|
	|-RVA: 0x2B3EFF0 Offset: 0x2B3F0F1 VA: 0x2B3EFF0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3EDF0 Offset: 0x2B3EEF1 VA: 0x2B3EDF0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<int, bool>.<CopyTo>b__0
	|
	|-RVA: 0x2B3EF00 Offset: 0x2B3F001 VA: 0x2B3EF00
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<int, int>.<CopyTo>b__0
	|
	|-RVA: 0x2B3F000 Offset: 0x2B3F101 VA: 0x2B3F000
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<object, object>.<CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30C80 Offset: 0x30D81 VA: 0x30C80
private sealed class SortedDictionary.ValueCollection.<>c__DisplayClass6_0<TKey, TValue> // TypeDefIndex: 2426
{
	// Fields
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F0C0 Offset: 0x2B3F1C1 VA: 0x2B3F0C0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<int, bool>..ctor
	|
	|-RVA: 0x2B3F0E0 Offset: 0x2B3F1E1 VA: 0x2B3F0E0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<int, int>..ctor
	|
	|-RVA: 0x2B3F100 Offset: 0x2B3F201 VA: 0x2B3F100
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<object, object>..ctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30C90 Offset: 0x30D91 VA: 0x30C90
private sealed class SortedDictionary.ValueCollection.<>c__DisplayClass6_1<TKey, TValue> // TypeDefIndex: 2427
{
	// Fields
	public object[] objects; // 0x0
	public SortedDictionary.ValueCollection.<>c__DisplayClass6_0<TKey, TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F9D0 Offset: 0x2B3FAD1 VA: 0x2B3F9D0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_1<int, bool>..ctor
	|
	|-RVA: 0x2B3FBA0 Offset: 0x2B3FCA1 VA: 0x2B3FBA0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_1<int, int>..ctor
	|
	|-RVA: 0x2B3FD40 Offset: 0x2B3FE41 VA: 0x2B3FD40
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_1<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F9E0 Offset: 0x2B3FAE1 VA: 0x2B3F9E0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_1<int, bool>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3FBB0 Offset: 0x2B3FCB1 VA: 0x2B3FBB0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_1<int, int>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0x2B3FD50 Offset: 0x2B3FE51 VA: 0x2B3FD50
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_1<object, object>.<System.Collections.ICollection.CopyTo>b__0
	*/
}

// Namespace: 
[DebuggerTypeProxyAttribute] // RVA: 0x30BE0 Offset: 0x30CE1 VA: 0x30BE0
[DebuggerDisplayAttribute] // RVA: 0x30BE0 Offset: 0x30CE1 VA: 0x30BE0
[Serializable]
public sealed class SortedDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 2428
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFD890 Offset: 0x2DFD991 VA: 0x2DFD890
	|-SortedDictionary.ValueCollection<int, bool>..ctor
	|
	|-RVA: 0x2E00C10 Offset: 0x2E00D11 VA: 0x2E00C10
	|-SortedDictionary.ValueCollection<int, int>..ctor
	|
	|-RVA: 0x3386750 Offset: 0x3386851 VA: 0x3386750
	|-SortedDictionary.ValueCollection<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFD910 Offset: 0x2DFDA11 VA: 0x2DFD910
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2E00C90 Offset: 0x2E00D91 VA: 0x2E00C90
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x33867D0 Offset: 0x33868D1 VA: 0x33867D0
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFD9A0 Offset: 0x2DFDAA1 VA: 0x2DFD9A0
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2E00D20 Offset: 0x2E00E21 VA: 0x2E00D20
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3386860 Offset: 0x3386961 VA: 0x3386860
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFDA30 Offset: 0x2DFDB31 VA: 0x2DFDA30
	|-SortedDictionary.ValueCollection<int, bool>.CopyTo
	|
	|-RVA: 0x2E00DB0 Offset: 0x2E00EB1 VA: 0x2E00DB0
	|-SortedDictionary.ValueCollection<int, int>.CopyTo
	|
	|-RVA: 0x33868F0 Offset: 0x33869F1 VA: 0x33868F0
	|-SortedDictionary.ValueCollection<object, object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFDC50 Offset: 0x2DFDD51 VA: 0x2DFDC50
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2E00FD0 Offset: 0x2E010D1 VA: 0x2E00FD0
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3386B10 Offset: 0x3386C11 VA: 0x3386B10
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE0A0 Offset: 0x2DFE1A1 VA: 0x2DFE0A0
	|-SortedDictionary.ValueCollection<int, bool>.get_Count
	|
	|-RVA: 0x2E01420 Offset: 0x2E01521 VA: 0x2E01420
	|-SortedDictionary.ValueCollection<int, int>.get_Count
	|
	|-RVA: 0x3386F60 Offset: 0x3387061 VA: 0x3386F60
	|-SortedDictionary.ValueCollection<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE0C0 Offset: 0x2DFE1C1 VA: 0x2DFE0C0
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2E01440 Offset: 0x2E01541 VA: 0x2E01440
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x3386F80 Offset: 0x3387081 VA: 0x3386F80
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE0D0 Offset: 0x2DFE1D1 VA: 0x2DFE0D0
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2E01450 Offset: 0x2E01551 VA: 0x2E01450
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x3386F90 Offset: 0x3387091 VA: 0x3386F90
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE130 Offset: 0x2DFE231 VA: 0x2DFE130
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2E014B0 Offset: 0x2E015B1 VA: 0x2E014B0
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x3386FF0 Offset: 0x33870F1 VA: 0x3386FF0
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE190 Offset: 0x2DFE291 VA: 0x2DFE190
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2E01510 Offset: 0x2E01611 VA: 0x2E01510
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x3387050 Offset: 0x3387151 VA: 0x3387050
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE1B0 Offset: 0x2DFE2B1 VA: 0x2DFE1B0
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2E01530 Offset: 0x2E01631 VA: 0x2E01530
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x3387070 Offset: 0x3387171 VA: 0x3387070
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE210 Offset: 0x2DFE311 VA: 0x2DFE210
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2E01590 Offset: 0x2E01691 VA: 0x2E01590
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x33870D0 Offset: 0x33871D1 VA: 0x33870D0
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DFE220 Offset: 0x2DFE321 VA: 0x2DFE220
	|-SortedDictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2E015A0 Offset: 0x2E016A1 VA: 0x2E015A0
	|-SortedDictionary.ValueCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x33870E0 Offset: 0x33871E1 VA: 0x33870E0
	|-SortedDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: 
[Serializable]
internal sealed class SortedDictionary.KeyValuePairComparer<TKey, TValue> : Comparer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 2429
{
	// Fields
	internal IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2899DC0 Offset: 0x2899EC1 VA: 0x2899DC0
	|-SortedDictionary.KeyValuePairComparer<int, bool>..ctor
	|
	|-RVA: 0x2899EF0 Offset: 0x2899FF1 VA: 0x2899EF0
	|-SortedDictionary.KeyValuePairComparer<int, int>..ctor
	|
	|-RVA: 0x289A020 Offset: 0x289A121 VA: 0x289A020
	|-SortedDictionary.KeyValuePairComparer<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2899E40 Offset: 0x2899F41 VA: 0x2899E40
	|-SortedDictionary.KeyValuePairComparer<int, bool>.Compare
	|
	|-RVA: 0x2899F70 Offset: 0x289A071 VA: 0x2899F70
	|-SortedDictionary.KeyValuePairComparer<int, int>.Compare
	|
	|-RVA: 0x289A0A0 Offset: 0x289A1A1 VA: 0x289A0A0
	|-SortedDictionary.KeyValuePairComparer<object, object>.Compare
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30CA0 Offset: 0x30DA1 VA: 0x30CA0
private sealed class SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> // TypeDefIndex: 2430
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C180 Offset: 0x2B3C281 VA: 0x2B3C180
	|-SortedDictionary.<>c__DisplayClass34_0<int, bool>..ctor
	|
	|-RVA: 0x2B3C1C0 Offset: 0x2B3C2C1 VA: 0x2B3C1C0
	|-SortedDictionary.<>c__DisplayClass34_0<int, int>..ctor
	|
	|-RVA: 0x2B3C200 Offset: 0x2B3C301 VA: 0x2B3C200
	|-SortedDictionary.<>c__DisplayClass34_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ContainsValue>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C190 Offset: 0x2B3C291 VA: 0x2B3C190
	|-SortedDictionary.<>c__DisplayClass34_0<int, bool>.<ContainsValue>b__0
	|
	|-RVA: 0x2B3C1D0 Offset: 0x2B3C2D1 VA: 0x2B3C1D0
	|-SortedDictionary.<>c__DisplayClass34_0<int, int>.<ContainsValue>b__0
	|
	|-RVA: 0x2B3C210 Offset: 0x2B3C311 VA: 0x2B3C210
	|-SortedDictionary.<>c__DisplayClass34_0<object, object>.<ContainsValue>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30CB0 Offset: 0x30DB1 VA: 0x30CB0
private sealed class SortedDictionary.<>c__DisplayClass34_1<TKey, TValue> // TypeDefIndex: 2431
{
	// Fields
	public EqualityComparer<TValue> valueComparer; // 0x0
	public SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C270 Offset: 0x2B3C371 VA: 0x2B3C270
	|-SortedDictionary.<>c__DisplayClass34_1<int, bool>..ctor
	|
	|-RVA: 0x2B3C300 Offset: 0x2B3C401 VA: 0x2B3C300
	|-SortedDictionary.<>c__DisplayClass34_1<int, int>..ctor
	|
	|-RVA: 0x2B3C380 Offset: 0x2B3C481 VA: 0x2B3C380
	|-SortedDictionary.<>c__DisplayClass34_1<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ContainsValue>b__1(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C280 Offset: 0x2B3C381 VA: 0x2B3C280
	|-SortedDictionary.<>c__DisplayClass34_1<int, bool>.<ContainsValue>b__1
	|
	|-RVA: 0x2B3C310 Offset: 0x2B3C411 VA: 0x2B3C310
	|-SortedDictionary.<>c__DisplayClass34_1<int, int>.<ContainsValue>b__1
	|
	|-RVA: 0x2B3C390 Offset: 0x2B3C491 VA: 0x2B3C390
	|-SortedDictionary.<>c__DisplayClass34_1<object, object>.<ContainsValue>b__1
	*/
}

