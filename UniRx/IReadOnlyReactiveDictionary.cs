// Namespace: UniRx
[DefaultMemberAttribute] // RVA: 0x13430 Offset: 0x13531 VA: 0x13430
public interface IReadOnlyReactiveDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 6760
{
	// Properties
	public abstract int Count { get; }
	public abstract TValue Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TValue get_Item(TKey index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IObservable<DictionaryAddEvent<TKey, TValue>> ObserveAdd();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.ObserveAdd
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IObservable<int> ObserveCountChanged(bool notifyCurrentCount = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.ObserveCountChanged
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IObservable<DictionaryRemoveEvent<TKey, TValue>> ObserveRemove();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.ObserveRemove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IObservable<DictionaryReplaceEvent<TKey, TValue>> ObserveReplace();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.ObserveReplace
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IObservable<Unit> ObserveReset();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveDictionary<object, object>.ObserveReset
	*/
}

