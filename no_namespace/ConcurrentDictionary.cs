// Namespace: 
private sealed class ConcurrentDictionary.Tables<TKey, TValue> // TypeDefIndex: 1388
{
	// Fields
	internal readonly ConcurrentDictionary.Node<TKey, TValue>[] _buckets; // 0x0
	internal readonly object[] _locks; // 0x0
	internal int[] _countPerLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary.Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8620 Offset: 0x34B8721 VA: 0x34B8620
	|-ConcurrentDictionary.Tables<object, object>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.Node<TKey, TValue> // TypeDefIndex: 1389
{
	// Fields
	internal readonly TKey _key; // 0x0
	internal TValue _value; // 0x0
	internal ConcurrentDictionary.Node<TKey, TValue> _next; // 0x0
	internal readonly int _hashcode; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TKey key, TValue value, int hashcode, ConcurrentDictionary.Node<TKey, TValue> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7DE0 Offset: 0x31A7EE1 VA: 0x31A7DE0
	|-ConcurrentDictionary.Node<object, object>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1390
{
	// Fields
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251ADE0 Offset: 0x251AEE1 VA: 0x251ADE0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251AE40 Offset: 0x251AF41 VA: 0x251AE40
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251AF80 Offset: 0x251B081 VA: 0x251AF80
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B010 Offset: 0x251B111 VA: 0x251B010
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B0B0 Offset: 0x251B1B1 VA: 0x251B0B0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B130 Offset: 0x251B231 VA: 0x251B130
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B1E0 Offset: 0x251B2E1 VA: 0x251B1E0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.Reset
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4774A0 Offset: 0x4775A1 VA: 0x4774A0
private sealed class ConcurrentDictionary.<GetEnumerator>d__32<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 1391
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public ConcurrentDictionary<TKey, TValue> <>4__this; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue>[] <buckets>5__1; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue> <current>5__2; // 0x0
	private int <i>5__3; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x47D970 Offset: 0x47DA71 VA: 0x47D970
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150430 Offset: 0x3150531 VA: 0x3150430
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x47D980 Offset: 0x47DA81 VA: 0x47D980
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150460 Offset: 0x3150561 VA: 0x3150460
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150470 Offset: 0x3150571 VA: 0x3150470
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x47D990 Offset: 0x47DA91 VA: 0x47D990
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31505C0 Offset: 0x31506C1 VA: 0x31505C0
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x47D9A0 Offset: 0x47DAA1 VA: 0x47D9A0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31505D0 Offset: 0x31506D1 VA: 0x31505D0
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x47D9B0 Offset: 0x47DAB1 VA: 0x47D9B0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150610 Offset: 0x3150711 VA: 0x3150610
	|-ConcurrentDictionary.<GetEnumerator>d__32<object, object>.System.Collections.IEnumerator.get_Current
	*/
}

