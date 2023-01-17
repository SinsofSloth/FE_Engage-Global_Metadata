// Namespace: UnityEngine.Rendering
public static class UnsafeGenericPool<T> // TypeDefIndex: 4534
{
	// Fields
	private static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8D00 Offset: 0x2DF8E01 VA: 0x2DF8D00
	|-UnsafeGenericPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<T> Get(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8E90 Offset: 0x2DF8F91 VA: 0x2DF8E90
	|-UnsafeGenericPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF9020 Offset: 0x2DF9121 VA: 0x2DF9020
	|-UnsafeGenericPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF91B0 Offset: 0x2DF92B1 VA: 0x2DF91B0
	|-UnsafeGenericPool<object>..cctor
	*/
}

