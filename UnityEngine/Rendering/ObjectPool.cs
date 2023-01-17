// Namespace: UnityEngine.Rendering
public class ObjectPool<T> // TypeDefIndex: 4532
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	private readonly bool m_CollectionCheck; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3CA30 Offset: 0x3CB31 VA: 0x3CA30
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D690 Offset: 0x3D791 VA: 0x3D690
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D0C0 Offset: 0x370D1C1 VA: 0x370D0C0
	|-ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D6A0 Offset: 0x3D7A1 VA: 0x3D6A0
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D0D0 Offset: 0x370D1D1 VA: 0x370D0D0
	|-ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D0E0 Offset: 0x370D1E1 VA: 0x370D0E0
	|-ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D140 Offset: 0x370D241 VA: 0x370D140
	|-ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D160 Offset: 0x370D261 VA: 0x370D160
	|-ObjectPool<CommandBuffer>..ctor
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D230 Offset: 0x370D331 VA: 0x370D230
	|-ObjectPool<CommandBuffer>.Get
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public ObjectPool.PooledObject<T> Get(out T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D310 Offset: 0x370D411 VA: 0x370D310
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D390 Offset: 0x370D491 VA: 0x370D390
	|-ObjectPool<CommandBuffer>.Release
	|-ObjectPool<object>.Release
	*/
}

