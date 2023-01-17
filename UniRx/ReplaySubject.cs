// Namespace: UniRx
public sealed class ReplaySubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IOptimizedObservable<T>, IDisposable // TypeDefIndex: 6642
{
	// Fields
	private object observerLock; // 0x0
	private bool isStopped; // 0x0
	private bool isDisposed; // 0x0
	private Exception lastError; // 0x0
	private IObserver<T> outObserver; // 0x0
	private readonly int bufferSize; // 0x0
	private readonly TimeSpan window; // 0x0
	private readonly DateTimeOffset startTime; // 0x0
	private readonly IScheduler scheduler; // 0x0
	private Queue<TimeInterval<T>> queue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6D70 Offset: 0x2FF6E71 VA: 0x2FF6D70
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6E10 Offset: 0x2FF6F11 VA: 0x2FF6E10
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int bufferSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6EB0 Offset: 0x2FF6FB1 VA: 0x2FF6EB0
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int bufferSize, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6F60 Offset: 0x2FF7061 VA: 0x2FF6F60
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TimeSpan window) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7000 Offset: 0x2FF7101 VA: 0x2FF7000
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TimeSpan window, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7060 Offset: 0x2FF7161 VA: 0x2FF7060
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int bufferSize, TimeSpan window, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7090 Offset: 0x2FF7191 VA: 0x2FF7090
	|-ReplaySubject<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7390 Offset: 0x2FF7491 VA: 0x2FF7390
	|-ReplaySubject<object>.Trim
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF75B0 Offset: 0x2FF76B1 VA: 0x2FF75B0
	|-ReplaySubject<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7820 Offset: 0x2FF7921 VA: 0x2FF7820
	|-ReplaySubject<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7AF0 Offset: 0x2FF7BF1 VA: 0x2FF7AF0
	|-ReplaySubject<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF7DD0 Offset: 0x2FF7ED1 VA: 0x2FF7DD0
	|-ReplaySubject<object>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF8510 Offset: 0x2FF8611 VA: 0x2FF8510
	|-ReplaySubject<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF86A0 Offset: 0x2FF87A1 VA: 0x2FF86A0
	|-ReplaySubject<object>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF8710 Offset: 0x2FF8811 VA: 0x2FF8710
	|-ReplaySubject<object>.IsRequiredSubscribeOnCurrentThread
	*/
}

