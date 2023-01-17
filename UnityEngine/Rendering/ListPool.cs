// Namespace: UnityEngine.Rendering
public static class ListPool<T> // TypeDefIndex: 4536
{
	// Fields
	private static readonly ObjectPool<List<T>> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B06A40 Offset: 0x3B06B41 VA: 0x3B06A40
	|-ListPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<List<T>> Get(out List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B06BD0 Offset: 0x3B06CD1 VA: 0x3B06BD0
	|-ListPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B06D60 Offset: 0x3B06E61 VA: 0x3B06D60
	|-ListPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B06EF0 Offset: 0x3B06FF1 VA: 0x3B06EF0
	|-ListPool<object>..cctor
	*/
}

