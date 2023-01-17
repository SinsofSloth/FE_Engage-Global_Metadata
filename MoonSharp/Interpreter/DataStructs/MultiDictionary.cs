// Namespace: MoonSharp.Interpreter.DataStructs
internal class MultiDictionary<K, V> // TypeDefIndex: 6223
{
	// Fields
	private Dictionary<K, List<V>> m_Map; // 0x0
	private V[] m_DefaultRet; // 0x0

	// Properties
	public IEnumerable<K> Keys { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29491E0 Offset: 0x29492E1 VA: 0x29491E0
	|-MultiDictionary<object, object>..ctor
	|-MultiDictionary<string, IOverloadableMemberDescriptor>..ctor
	|-MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<K> eqComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29492A0 Offset: 0x29493A1 VA: 0x29492A0
	|-MultiDictionary<object, Closure>..ctor
	|-MultiDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(K key, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949360 Offset: 0x2949461 VA: 0x2949360
	|-MultiDictionary<object, Closure>.Add
	|-MultiDictionary<object, object>.Add
	|-MultiDictionary<string, IOverloadableMemberDescriptor>.Add
	|-MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod>.Add
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<V> Find(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949460 Offset: 0x2949561 VA: 0x2949460
	|-MultiDictionary<object, Closure>.Find
	|-MultiDictionary<object, object>.Find
	|-MultiDictionary<string, IOverloadableMemberDescriptor>.Find
	|-MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod>.Find
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29494C0 Offset: 0x29495C1 VA: 0x29494C0
	|-MultiDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<K> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29494E0 Offset: 0x29495E1 VA: 0x29494E0
	|-MultiDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949500 Offset: 0x2949601 VA: 0x2949500
	|-MultiDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Remove(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949520 Offset: 0x2949621 VA: 0x2949520
	|-MultiDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool RemoveValue(K key, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949540 Offset: 0x2949641 VA: 0x2949540
	|-MultiDictionary<object, Closure>.RemoveValue
	|-MultiDictionary<object, object>.RemoveValue
	*/
}

