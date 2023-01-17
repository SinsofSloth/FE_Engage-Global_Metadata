// Namespace: App
public class EachDictionary<TKey, TValue> // TypeDefIndex: 9190
{
	// Fields
	private Dictionary<TKey, Dictionary<TKey, TValue>> m_Dictionary; // 0x0
	private int m_Capacity; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity = 32) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26398B0 Offset: 0x26399B1 VA: 0x26398B0
	|-EachDictionary<int, object>..ctor
	|-EachDictionary<int, UnitRelianceData>..ctor
	|
	|-RVA: 0x2639C10 Offset: 0x2639D11 VA: 0x2639C10
	|-EachDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2639940 Offset: 0x2639A41 VA: 0x2639940
	|-EachDictionary<int, object>.Clear
	|-EachDictionary<int, UnitRelianceData>.Clear
	|
	|-RVA: 0x2639CA0 Offset: 0x2639DA1 VA: 0x2639CA0
	|-EachDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey keyA, TKey keyB, TValue data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2639960 Offset: 0x2639A61 VA: 0x2639960
	|-EachDictionary<int, object>.Add
	|-EachDictionary<int, UnitRelianceData>.Add
	|
	|-RVA: 0x2639CC0 Offset: 0x2639DC1 VA: 0x2639CC0
	|-EachDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey keyA, TKey keyB) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2639B10 Offset: 0x2639C11 VA: 0x2639B10
	|-EachDictionary<int, object>.ContainsKey
	|
	|-RVA: 0x2639E70 Offset: 0x2639F71 VA: 0x2639E70
	|-EachDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey keyA, TKey keyB, out TValue data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2639B90 Offset: 0x2639C91 VA: 0x2639B90
	|-EachDictionary<int, object>.TryGetValue
	|-EachDictionary<int, UnitRelianceData>.TryGetValue
	|
	|-RVA: 0x2639EF0 Offset: 0x2639FF1 VA: 0x2639EF0
	|-EachDictionary<object, object>.TryGetValue
	*/
}

