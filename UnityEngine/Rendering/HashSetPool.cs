// Namespace: UnityEngine.Rendering
public static class HashSetPool<T> // TypeDefIndex: 4538
{
	// Fields
	private static readonly ObjectPool<HashSet<T>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static HashSet<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB3CB0 Offset: 0x3EB3DB1 VA: 0x3EB3CB0
	|-HashSetPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<HashSet<T>> Get(out HashSet<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB3E40 Offset: 0x3EB3F41 VA: 0x3EB3E40
	|-HashSetPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(HashSet<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB3FD0 Offset: 0x3EB40D1 VA: 0x3EB3FD0
	|-HashSetPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4160 Offset: 0x3EB4261 VA: 0x3EB4160
	|-HashSetPool<object>..cctor
	*/
}

