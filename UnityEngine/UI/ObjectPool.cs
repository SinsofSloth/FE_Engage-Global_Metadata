// Namespace: UnityEngine.UI
internal class ObjectPool<T> // TypeDefIndex: 4359
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x457D0 Offset: 0x458D1 VA: 0x457D0
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x46230 Offset: 0x46331 VA: 0x46230
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D400 Offset: 0x370D501 VA: 0x370D400
	|-ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x46240 Offset: 0x46341 VA: 0x46240
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D410 Offset: 0x370D511 VA: 0x370D410
	|-ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D420 Offset: 0x370D521 VA: 0x370D420
	|-ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D480 Offset: 0x370D581 VA: 0x370D480
	|-ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D4A0 Offset: 0x370D5A1 VA: 0x370D4A0
	|-ObjectPool<List<IEventSystemHandler>>..ctor
	|-ObjectPool<LayoutRebuilder>..ctor
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D550 Offset: 0x370D651 VA: 0x370D550
	|-ObjectPool<List<IEventSystemHandler>>.Get
	|-ObjectPool<LayoutRebuilder>.Get
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D630 Offset: 0x370D731 VA: 0x370D630
	|-ObjectPool<List<IEventSystemHandler>>.Release
	|-ObjectPool<LayoutRebuilder>.Release
	|-ObjectPool<object>.Release
	*/
}

