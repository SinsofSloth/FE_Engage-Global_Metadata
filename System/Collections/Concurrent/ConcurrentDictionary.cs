// Namespace: System.Collections.Concurrent
[DefaultMemberAttribute] // RVA: 0x4773F0 Offset: 0x4774F1 VA: 0x4773F0
[DebuggerTypeProxyAttribute] // RVA: 0x4773F0 Offset: 0x4774F1 VA: 0x4773F0
[DebuggerDisplayAttribute] // RVA: 0x4773F0 Offset: 0x4774F1 VA: 0x4773F0
[Serializable]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1392
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TKey Item { set; }
	public int Count { get; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504170 Offset: 0x2504271 VA: 0x2504170
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504290 Offset: 0x2504391 VA: 0x2504290
	|-ConcurrentDictionary<MemberHolder, MemberInfo[]>..ctor
	|-ConcurrentDictionary<object, object>..ctor
	|-ConcurrentDictionary<string, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504360 Offset: 0x2504461 VA: 0x2504360
	|-ConcurrentDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504630 Offset: 0x2504731 VA: 0x2504630
	|-ConcurrentDictionary<object, object>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25047B0 Offset: 0x25048B1 VA: 0x25047B0
	|-ConcurrentDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504890 Offset: 0x2504991 VA: 0x2504890
	|-ConcurrentDictionary<object, object>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504970 Offset: 0x2504A71 VA: 0x2504970
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504E40 Offset: 0x2504F41 VA: 0x2504E40
	|-ConcurrentDictionary<object, object>.TryGetValue
	|-ConcurrentDictionary<string, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2504FA0 Offset: 0x25050A1 VA: 0x2504FA0
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2505170 Offset: 0x2505271 VA: 0x2505170
	|-ConcurrentDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25053B0 Offset: 0x25054B1 VA: 0x25053B0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2505630 Offset: 0x2505731 VA: 0x2505630
	|-ConcurrentDictionary<object, object>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2505720 Offset: 0x2505821 VA: 0x2505720
	|-ConcurrentDictionary<object, object>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2505800 Offset: 0x2505901 VA: 0x2505800
	|-ConcurrentDictionary<object, object>.CopyToObjects
	*/

	[IteratorStateMachineAttribute] // RVA: 0x47D900 Offset: 0x47DA01 VA: 0x47D900
	// RVA: -1 Offset: -1 Slot: 14
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2505940 Offset: 0x2505A41 VA: 0x2505940
	|-ConcurrentDictionary<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25059C0 Offset: 0x2505AC1 VA: 0x25059C0
	|-ConcurrentDictionary<object, object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506050 Offset: 0x2506151 VA: 0x2506050
	|-ConcurrentDictionary<object, object>.set_Item
	|-ConcurrentDictionary<string, object>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25061D0 Offset: 0x25062D1 VA: 0x25061D0
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506230 Offset: 0x2506331 VA: 0x2506230
	|-ConcurrentDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506330 Offset: 0x2506431 VA: 0x2506330
	|-ConcurrentDictionary<object, object>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25063E0 Offset: 0x25064E1 VA: 0x25063E0
	|-ConcurrentDictionary<MemberHolder, MemberInfo[]>.GetOrAdd
	|-ConcurrentDictionary<object, object>.GetOrAdd
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25065F0 Offset: 0x25066F1 VA: 0x25065F0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506670 Offset: 0x2506771 VA: 0x2506670
	|-ConcurrentDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506690 Offset: 0x2506791 VA: 0x2506690
	|-ConcurrentDictionary<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25066B0 Offset: 0x25067B1 VA: 0x25066B0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506760 Offset: 0x2506861 VA: 0x2506760
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25067E0 Offset: 0x25068E1 VA: 0x25067E0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25067F0 Offset: 0x25068F1 VA: 0x25067F0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25068A0 Offset: 0x25069A1 VA: 0x25068A0
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25068C0 Offset: 0x25069C1 VA: 0x25068C0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506BA0 Offset: 0x2506CA1 VA: 0x2506BA0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506D00 Offset: 0x2506E01 VA: 0x2506D00
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506D70 Offset: 0x2506E71 VA: 0x2506D70
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506D80 Offset: 0x2506E81 VA: 0x2506D80
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506D90 Offset: 0x2506E91 VA: 0x2506D90
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506DB0 Offset: 0x2506EB1 VA: 0x2506DB0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506F00 Offset: 0x2507001 VA: 0x2506F00
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2506F20 Offset: 0x2507021 VA: 0x2506F20
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507080 Offset: 0x2507181 VA: 0x2507080
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25072B0 Offset: 0x25073B1 VA: 0x25072B0
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507690 Offset: 0x2507791 VA: 0x2507690
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25076A0 Offset: 0x25077A1 VA: 0x25076A0
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507700 Offset: 0x2507801 VA: 0x2507700
	|-ConcurrentDictionary<object, object>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507F40 Offset: 0x2508041 VA: 0x2507F40
	|-ConcurrentDictionary<object, object>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507F50 Offset: 0x2508051 VA: 0x2507F50
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507F70 Offset: 0x2508071 VA: 0x2507F70
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2507F80 Offset: 0x2508081 VA: 0x2507F80
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25080A0 Offset: 0x25081A1 VA: 0x25080A0
	|-ConcurrentDictionary<object, object>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25081F0 Offset: 0x25082F1 VA: 0x25081F0
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TKey> GetKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2508270 Offset: 0x2508371 VA: 0x2508270
	|-ConcurrentDictionary<object, object>.GetKeys
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TValue> GetValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25084D0 Offset: 0x25085D1 VA: 0x25084D0
	|-ConcurrentDictionary<object, object>.GetValues
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2508730 Offset: 0x2508831 VA: 0x2508730
	|-ConcurrentDictionary<object, object>..cctor
	*/
}

