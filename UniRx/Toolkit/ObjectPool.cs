// Namespace: UniRx.Toolkit
public abstract class ObjectPool<T> : IDisposable // TypeDefIndex: 6842
{
	// Fields
	private bool isDisposed; // 0x0
	private Queue<T> q; // 0x0

	// Properties
	protected int MaxPoolCount { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected int get_MaxPoolCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C440 Offset: 0x370C541 VA: 0x370C440
	|-ObjectPool<object>.get_MaxPoolCount
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract T CreateInstance();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ObjectPool<object>.CreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnBeforeRent(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C450 Offset: 0x370C551 VA: 0x370C450
	|-ObjectPool<MapInfoIconLocatorRoot>.OnBeforeRent
	|-ObjectPool<object>.OnBeforeRent
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnBeforeReturn(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C480 Offset: 0x370C581 VA: 0x370C480
	|-ObjectPool<MapInfoIconLocatorRoot>.OnBeforeReturn
	|-ObjectPool<object>.OnBeforeReturn
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void OnClear(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C4B0 Offset: 0x370C5B1 VA: 0x370C4B0
	|-ObjectPool<MapInfoIconLocatorRoot>.OnClear
	|-ObjectPool<object>.OnClear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C5A0 Offset: 0x370C6A1 VA: 0x370C5A0
	|-ObjectPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C5C0 Offset: 0x370C6C1 VA: 0x370C5C0
	|-ObjectPool<MapInfoIconLocatorRoot>.Rent
	|-ObjectPool<object>.Rent
	*/

	// RVA: -1 Offset: -1
	public void Return(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C700 Offset: 0x370C801 VA: 0x370C700
	|-ObjectPool<MapInfoIconLocatorRoot>.Return
	|-ObjectPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool callOnBeforeRent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370C910 Offset: 0x370CA11 VA: 0x370C910
	|-ObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Shrink(float instanceCountRatio, int minSize, bool callOnBeforeRent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370CA10 Offset: 0x370CB11 VA: 0x370CA10
	|-ObjectPool<object>.Shrink
	*/

	// RVA: -1 Offset: -1
	public IDisposable StartShrinkTimer(TimeSpan checkInterval, float instanceCountRatio, int minSize, bool callOnBeforeRent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370CBE0 Offset: 0x370CCE1 VA: 0x370CBE0
	|-ObjectPool<object>.StartShrinkTimer
	*/

	// RVA: -1 Offset: -1
	public IObservable<Unit> PreloadAsync(int preloadCount, int threshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370CDD0 Offset: 0x370CED1 VA: 0x370CDD0
	|-ObjectPool<object>.PreloadAsync
	*/

	[IteratorStateMachineAttribute] // RVA: 0x17E30 Offset: 0x17F31 VA: 0x17E30
	// RVA: -1 Offset: -1
	private IEnumerator PreloadCore(int preloadCount, int threshold, IObserver<Unit> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370CF70 Offset: 0x370D071 VA: 0x370CF70
	|-ObjectPool<object>.PreloadCore
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D040 Offset: 0x370D141 VA: 0x370D040
	|-ObjectPool<MapInfoIconLocatorRoot>.Dispose
	|-ObjectPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D0A0 Offset: 0x370D1A1 VA: 0x370D0A0
	|-ObjectPool<MapInfoIconLocatorRoot>.Dispose
	|-ObjectPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D0B0 Offset: 0x370D1B1 VA: 0x370D0B0
	|-ObjectPool<MapInfoIconLocatorRoot>..ctor
	|-ObjectPool<object>..ctor
	*/
}

