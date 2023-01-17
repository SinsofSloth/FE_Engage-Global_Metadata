// Namespace: 
private class TimeIntervalObservable.TimeInterval<T> : OperatorObserverBase<T, TimeInterval<T>> // TypeDefIndex: 7104
{
	// Fields
	private readonly TimeIntervalObservable<T> parent; // 0x0
	private DateTimeOffset lastTime; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TimeIntervalObservable<T> parent, IObserver<TimeInterval<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CC50 Offset: 0x399CD51 VA: 0x399CC50
	|-TimeIntervalObservable.TimeInterval<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CD50 Offset: 0x399CE51 VA: 0x399CD50
	|-TimeIntervalObservable.TimeInterval<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399CEE0 Offset: 0x399CFE1 VA: 0x399CEE0
	|-TimeIntervalObservable.TimeInterval<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D020 Offset: 0x399D121 VA: 0x399D020
	|-TimeIntervalObservable.TimeInterval<object>.OnCompleted
	*/
}

