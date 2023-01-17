// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x477750 Offset: 0x477851 VA: 0x477750
public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1431
{
	// Properties
	public abstract ICollection<TKey> Keys { get; }
	public abstract ICollection<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ICollection<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ICollection<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Add(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<object, object>.Add
	*/
}

