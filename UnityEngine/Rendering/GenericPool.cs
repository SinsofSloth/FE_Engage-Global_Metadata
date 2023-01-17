// Namespace: UnityEngine.Rendering
public static class GenericPool<T> // TypeDefIndex: 4533
{
	// Fields
	private static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0F8D0 Offset: 0x3A0F9D1 VA: 0x3A0F8D0
	|-GenericPool<object>.Get
	|-GenericPool<XRPass>.Get
	*/

	// RVA: -1 Offset: -1
	public static ObjectPool.PooledObject<T> Get(out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FA60 Offset: 0x3A0FB61 VA: 0x3A0FA60
	|-GenericPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FBF0 Offset: 0x3A0FCF1 VA: 0x3A0FBF0
	|-GenericPool<object>.Release
	|-GenericPool<XRPass>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A0FD80 Offset: 0x3A0FE81 VA: 0x3A0FD80
	|-GenericPool<object>..cctor
	*/
}

