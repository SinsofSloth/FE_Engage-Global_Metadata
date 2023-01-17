// Namespace: UniRx.Toolkit
public abstract class AsyncObjectPool<T> : IDisposable // TypeDefIndex: 6846
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
	|-RVA: 0x32D28C0 Offset: 0x32D29C1 VA: 0x32D28C0
	|-AsyncObjectPool<object>.get_MaxPoolCount
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract IObservable<T> CreateInstanceAsync();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncObjectPool<object>.CreateInstanceAsync
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnBeforeRent(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D28D0 Offset: 0x32D29D1 VA: 0x32D28D0
	|-AsyncObjectPool<object>.OnBeforeRent
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnBeforeReturn(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2900 Offset: 0x32D2A01 VA: 0x32D2900
	|-AsyncObjectPool<object>.OnBeforeReturn
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void OnClear(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2930 Offset: 0x32D2A31 VA: 0x32D2930
	|-AsyncObjectPool<object>.OnClear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2A20 Offset: 0x32D2B21 VA: 0x32D2A20
	|-AsyncObjectPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> RentAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2A40 Offset: 0x32D2B41 VA: 0x32D2A40
	|-AsyncObjectPool<object>.RentAsync
	*/

	// RVA: -1 Offset: -1
	public void Return(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2C60 Offset: 0x32D2D61 VA: 0x32D2C60
	|-AsyncObjectPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	public void Shrink(float instanceCountRatio, int minSize, bool callOnBeforeRent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2E70 Offset: 0x32D2F71 VA: 0x32D2E70
	|-AsyncObjectPool<object>.Shrink
	*/

	// RVA: -1 Offset: -1
	public IDisposable StartShrinkTimer(TimeSpan checkInterval, float instanceCountRatio, int minSize, bool callOnBeforeRent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3040 Offset: 0x32D3141 VA: 0x32D3040
	|-AsyncObjectPool<object>.StartShrinkTimer
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool callOnBeforeRent = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3230 Offset: 0x32D3331 VA: 0x32D3230
	|-AsyncObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public IObservable<Unit> PreloadAsync(int preloadCount, int threshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3330 Offset: 0x32D3431 VA: 0x32D3330
	|-AsyncObjectPool<object>.PreloadAsync
	*/

	[IteratorStateMachineAttribute] // RVA: 0x17EF0 Offset: 0x17FF1 VA: 0x17EF0
	// RVA: -1 Offset: -1
	private IEnumerator PreloadCore(int preloadCount, int threshold, IObserver<Unit> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D34D0 Offset: 0x32D35D1 VA: 0x32D34D0
	|-AsyncObjectPool<object>.PreloadCore
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D35A0 Offset: 0x32D36A1 VA: 0x32D35A0
	|-AsyncObjectPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3600 Offset: 0x32D3701 VA: 0x32D3600
	|-AsyncObjectPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3610 Offset: 0x32D3711 VA: 0x32D3610
	|-AsyncObjectPool<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17F60 Offset: 0x18061 VA: 0x17F60
	// RVA: -1 Offset: -1
	private void <RentAsync>b__10_0(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3620 Offset: 0x32D3721 VA: 0x32D3620
	|-AsyncObjectPool<object>.<RentAsync>b__10_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17F70 Offset: 0x18071 VA: 0x17F70
	// RVA: -1 Offset: -1
	private void <PreloadCore>b__16_0(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3630 Offset: 0x32D3731 VA: 0x32D3630
	|-AsyncObjectPool<object>.<PreloadCore>b__16_0
	*/
}

