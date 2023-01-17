// Namespace: UniRx.Async.Internal
public class WeakDictionary<TKey, TValue> // TypeDefIndex: 5226
{
	// Fields
	private WeakDictionary.Entry<TKey, TValue>[] buckets; // 0x0
	private int size; // 0x0
	private SpinLock gate; // 0x0
	private readonly float loadFactor; // 0x0
	private readonly IEqualityComparer<TKey> keyEqualityComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 4, float loadFactor = 0.75, IEqualityComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9F10 Offset: 0x2FDA011 VA: 0x2FD9F10
	|-WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>>..ctor
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>..ctor
	|
	|-RVA: 0x2FDAF10 Offset: 0x2FDB011 VA: 0x2FDAF10
	|-WeakDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDA010 Offset: 0x2FDA111 VA: 0x2FDA010
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.TryAdd
	|
	|-RVA: 0x2FDB010 Offset: 0x2FDB111 VA: 0x2FDB010
	|-WeakDictionary<object, object>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDA140 Offset: 0x2FDA241 VA: 0x2FDA140
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.TryGetValue
	|
	|-RVA: 0x2FDB120 Offset: 0x2FDB221 VA: 0x2FDB120
	|-WeakDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDA230 Offset: 0x2FDA331 VA: 0x2FDA230
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.TryRemove
	|
	|-RVA: 0x2FDB200 Offset: 0x2FDB301 VA: 0x2FDB200
	|-WeakDictionary<object, object>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDA310 Offset: 0x2FDA411 VA: 0x2FDA310
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.TryAddInternal
	|
	|-RVA: 0x2FDB2E0 Offset: 0x2FDB3E1 VA: 0x2FDB2E0
	|-WeakDictionary<object, object>.TryAddInternal
	*/

	// RVA: -1 Offset: -1
	private bool AddToBuckets(WeakDictionary.Entry<TKey, TValue>[] targetBuckets, TKey newKey, TValue value, int keyHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDA570 Offset: 0x2FDA671 VA: 0x2FDA570
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.AddToBuckets
	|
	|-RVA: 0x2FDB500 Offset: 0x2FDB601 VA: 0x2FDB500
	|-WeakDictionary<object, object>.AddToBuckets
	*/

	// RVA: -1 Offset: -1
	private bool TryGetEntry(TKey key, out int hashIndex, out WeakDictionary.Entry<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDA8F0 Offset: 0x2FDA9F1 VA: 0x2FDA8F0
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.TryGetEntry
	|
	|-RVA: 0x2FDB860 Offset: 0x2FDB961 VA: 0x2FDB860
	|-WeakDictionary<object, object>.TryGetEntry
	*/

	// RVA: -1 Offset: -1
	private void Remove(int hashIndex, WeakDictionary.Entry<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDAAF0 Offset: 0x2FDABF1 VA: 0x2FDAAF0
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.Remove
	|
	|-RVA: 0x2FDBA60 Offset: 0x2FDBB61 VA: 0x2FDBA60
	|-WeakDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public List<KeyValuePair<TKey, TValue>> ToList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDABE0 Offset: 0x2FDACE1 VA: 0x2FDABE0
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.ToList
	|
	|-RVA: 0x2FDBB50 Offset: 0x2FDBC51 VA: 0x2FDBB50
	|-WeakDictionary<object, object>.ToList
	*/

	// RVA: -1 Offset: -1
	public int ToList(ref List<KeyValuePair<TKey, TValue>> list, bool clear = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDAC80 Offset: 0x2FDAD81 VA: 0x2FDAC80
	|-WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>>.ToList
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.ToList
	|
	|-RVA: 0x2FDBBF0 Offset: 0x2FDBCF1 VA: 0x2FDBBF0
	|-WeakDictionary<object, object>.ToList
	*/

	// RVA: -1 Offset: -1
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDAEC0 Offset: 0x2FDAFC1 VA: 0x2FDAEC0
	|-WeakDictionary<object, ValueTuple<int, DateTime, object>>.CalculateCapacity
	|
	|-RVA: 0x2FDBDD0 Offset: 0x2FDBED1 VA: 0x2FDBDD0
	|-WeakDictionary<object, object>.CalculateCapacity
	*/
}

