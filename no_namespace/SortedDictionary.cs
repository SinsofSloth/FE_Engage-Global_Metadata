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

