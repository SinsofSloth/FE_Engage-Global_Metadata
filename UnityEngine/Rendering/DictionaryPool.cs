// Namespace: UnityEngine.Rendering
public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 4540
{
	// Fields
	private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TValue> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B290 Offset: 0x251B391 VA: 0x251B290
	|-DictionaryPool<object, object>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<Dictionary<TKey, TValue>> Get(out Dictionary<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B420 Offset: 0x251B521 VA: 0x251B420
	|-DictionaryPool<object, object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(Dictionary<TKey, TValue> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B5B0 Offset: 0x251B6B1 VA: 0x251B5B0
	|-DictionaryPool<object, object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B740 Offset: 0x251B841 VA: 0x251B740
	|-DictionaryPool<object, object>..cctor
	*/
}

