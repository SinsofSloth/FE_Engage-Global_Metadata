// Namespace: FUtility
[Il2CppSetOptionAttribute] // RVA: 0x5B130 Offset: 0x5B231 VA: 0x5B130
[Il2CppSetOptionAttribute] // RVA: 0x5B130 Offset: 0x5B231 VA: 0x5B130
[Il2CppSetOptionAttribute] // RVA: 0x5B130 Offset: 0x5B231 VA: 0x5B130
public sealed class TaskSystem<T> // TypeDefIndex: 6342
{
	// Fields
	private Task<T> top; // 0x0
	private Task<T> end; // 0x0
	private int capacity; // 0x0
	private int freeCount; // 0x0
	private int actCount; // 0x0
	private Task<T>[] taskPool; // 0x0
	private Task<T>[] activeTask; // 0x0

	// Properties
	public T first { get; }
	public T last { get; }
	public int count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_first() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3986C30 Offset: 0x3986D31 VA: 0x3986C30
	|-TaskSystem<NativeBlock>.get_first
	|
	|-RVA: 0x39873E0 Offset: 0x39874E1 VA: 0x39873E0
	|-TaskSystem<object>.get_first
	*/

	// RVA: -1 Offset: -1
	public T get_last() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3986C50 Offset: 0x3986D51 VA: 0x3986C50
	|-TaskSystem<NativeBlock>.get_last
	|
	|-RVA: 0x3987400 Offset: 0x3987501 VA: 0x3987400
	|-TaskSystem<object>.get_last
	*/

	// RVA: -1 Offset: -1
	public int get_count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3986C70 Offset: 0x3986D71 VA: 0x3986C70
	|-TaskSystem<NativeBlock>.get_count
	|
	|-RVA: 0x3987420 Offset: 0x3987521 VA: 0x3987420
	|-TaskSystem<object>.get_count
	|-TaskSystem<SpringJobManager>.get_count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3986C80 Offset: 0x3986D81 VA: 0x3986C80
	|-TaskSystem<NativeBlock>..ctor
	|
	|-RVA: 0x3987430 Offset: 0x3987531 VA: 0x3987430
	|-TaskSystem<object>..ctor
	|-TaskSystem<SpringJobManager>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3986E50 Offset: 0x3986F51 VA: 0x3986E50
	|-TaskSystem<NativeBlock>.Clear
	|
	|-RVA: 0x3987600 Offset: 0x3987701 VA: 0x3987600
	|-TaskSystem<object>.Clear
	|-TaskSystem<SpringJobManager>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Attach(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3986F70 Offset: 0x3987071 VA: 0x3986F70
	|-TaskSystem<NativeBlock>.Attach
	|
	|-RVA: 0x3987720 Offset: 0x3987821 VA: 0x3987720
	|-TaskSystem<object>.Attach
	|-TaskSystem<SpringJobManager>.Attach
	*/

	// RVA: -1 Offset: -1
	internal void Detach(Task<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39870E0 Offset: 0x39871E1 VA: 0x39870E0
	|-TaskSystem<NativeBlock>.Detach
	|
	|-RVA: 0x39878A0 Offset: 0x39879A1 VA: 0x39878A0
	|-TaskSystem<object>.Detach
	*/

	// RVA: -1 Offset: -1
	public bool Detach(MatchHandler<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39871D0 Offset: 0x39872D1 VA: 0x39871D0
	|-TaskSystem<NativeBlock>.Detach
	|
	|-RVA: 0x3987990 Offset: 0x3987A91 VA: 0x3987990
	|-TaskSystem<object>.Detach
	|-TaskSystem<SpringJobManager>.Detach
	*/

	// RVA: -1 Offset: -1
	public void Order(OrderHandler<T> order) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987290 Offset: 0x3987391 VA: 0x3987290
	|-TaskSystem<NativeBlock>.Order
	|
	|-RVA: 0x3987A50 Offset: 0x3987B51 VA: 0x3987A50
	|-TaskSystem<object>.Order
	|-TaskSystem<SpringJobManager>.Order
	*/

	// RVA: -1 Offset: -1
	public bool Pickup(MatchHandler<T> match, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987340 Offset: 0x3987441 VA: 0x3987340
	|-TaskSystem<NativeBlock>.Pickup
	|
	|-RVA: 0x3987B00 Offset: 0x3987C01 VA: 0x3987B00
	|-TaskSystem<object>.Pickup
	*/
}

