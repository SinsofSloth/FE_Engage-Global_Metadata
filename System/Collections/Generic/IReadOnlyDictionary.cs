// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x477870 Offset: 0x477971 VA: 0x477870
public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1437
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<object, object>.TryGetValue
	*/
}

