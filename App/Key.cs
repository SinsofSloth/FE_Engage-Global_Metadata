// Namespace: App
public class Key3Dictionary<TKey, TValue> // TypeDefIndex: 9192
{
	// Fields
	private Dictionary<TKey, Dictionary<TKey, Dictionary<TKey, TValue>>> m_Dictionary; // 0x0
	private int m_Capacity; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 32) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7EC10 Offset: 0x2F7ED11 VA: 0x2F7EC10
	|-Key3Dictionary<object, object>..ctor
	|-Key3Dictionary<string, string>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7ECA0 Offset: 0x2F7EDA1 VA: 0x2F7ECA0
	|-Key3Dictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey keyA, TKey keyB, TKey keyC, TValue data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7ECC0 Offset: 0x2F7EDC1 VA: 0x2F7ECC0
	|-Key3Dictionary<object, object>.Add
	|-Key3Dictionary<string, string>.Add
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey keyA, TKey keyB, TKey keyC) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7EE50 Offset: 0x2F7EF51 VA: 0x2F7EE50
	|-Key3Dictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey keyA, TKey keyB, TKey keyC, out TValue data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7EF00 Offset: 0x2F7F001 VA: 0x2F7EF00
	|-Key3Dictionary<object, object>.TryGetValue
	|-Key3Dictionary<string, string>.TryGetValue
	*/
}

