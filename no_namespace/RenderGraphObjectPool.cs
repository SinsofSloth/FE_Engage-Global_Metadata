// Namespace: 
private class RenderGraphObjectPool.SharedObjectPool<T> // TypeDefIndex: 4479
{
	// Fields
	private Stack<T> m_Pool; // 0x0
	private static readonly Lazy<RenderGraphObjectPool.SharedObjectPool<T>> s_Instance; // 0x0

	// Properties
	public static RenderGraphObjectPool.SharedObjectPool<T> sharedPool { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3432F00 Offset: 0x3433001 VA: 0x3432F00
	|-RenderGraphObjectPool.SharedObjectPool<MaterialPropertyBlock>.Get
	|-RenderGraphObjectPool.SharedObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3432F70 Offset: 0x3433071 VA: 0x3432F70
	|-RenderGraphObjectPool.SharedObjectPool<MaterialPropertyBlock>.Release
	|-RenderGraphObjectPool.SharedObjectPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	public static RenderGraphObjectPool.SharedObjectPool<T> get_sharedPool() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3432F90 Offset: 0x3433091 VA: 0x3432F90
	|-RenderGraphObjectPool.SharedObjectPool<MaterialPropertyBlock>.get_sharedPool
	|-RenderGraphObjectPool.SharedObjectPool<object>.get_sharedPool
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3433120 Offset: 0x3433221 VA: 0x3433120
	|-RenderGraphObjectPool.SharedObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34331A0 Offset: 0x34332A1 VA: 0x34331A0
	|-RenderGraphObjectPool.SharedObjectPool<object>..cctor
	*/
}

