// Namespace: 
private class SampleObservable.Sample<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7030
{
	// Fields
	private readonly SampleObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private T latestValue; // 0x0
	private bool isUpdated; // 0x0
	private bool isCompleted; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SampleObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC780 Offset: 0x2FFC881 VA: 0x2FFC780
	|-SampleObservable.Sample<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC840 Offset: 0x2FFC941 VA: 0x2FFC840
	|-SampleObservable.Sample<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNextTick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFCAD0 Offset: 0x2FFCBD1 VA: 0x2FFCAD0
	|-SampleObservable.Sample<object>.OnNextTick
	*/

	// RVA: -1 Offset: -1
	private void OnNextRecursive(Action<TimeSpan> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFCDA0 Offset: 0x2FFCEA1 VA: 0x2FFCDA0
	|-SampleObservable.Sample<object>.OnNextRecursive
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD0C0 Offset: 0x2FFD1C1 VA: 0x2FFD0C0
	|-SampleObservable.Sample<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD1A0 Offset: 0x2FFD2A1 VA: 0x2FFD1A0
	|-SampleObservable.Sample<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD380 Offset: 0x2FFD481 VA: 0x2FFD380
	|-SampleObservable.Sample<object>.OnCompleted
	*/
}

// Namespace: 
private class SampleObservable.Sample.SampleTick<T, T2> : IObserver<T2> // TypeDefIndex: 7032
{
	// Fields
	private readonly SampleObservable.Sample<T, T2> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SampleObservable.Sample<T, T2> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFEAD0 Offset: 0x2FFEBD1 VA: 0x2FFEAD0
	|-SampleObservable.Sample.SampleTick<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFEB10 Offset: 0x2FFEC11 VA: 0x2FFEB10
	|-SampleObservable.Sample.SampleTick<object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFEDC0 Offset: 0x2FFEEC1 VA: 0x2FFEDC0
	|-SampleObservable.Sample.SampleTick<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T2 _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFEDD0 Offset: 0x2FFEED1 VA: 0x2FFEDD0
	|-SampleObservable.Sample.SampleTick<object, object>.OnNext
	*/
}

// Namespace: 
private class SampleObservable.Sample<T, T2> : OperatorObserverBase<T, T> // TypeDefIndex: 7033
{
	// Fields
	private readonly SampleObservable<T, T2> parent; // 0x0
	private readonly object gate; // 0x0
	private T latestValue; // 0x0
	private bool isUpdated; // 0x0
	private bool isCompleted; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SampleObservable<T, T2> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD460 Offset: 0x2FFD561 VA: 0x2FFD460
	|-SampleObservable.Sample<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD520 Offset: 0x2FFD621 VA: 0x2FFD520
	|-SampleObservable.Sample<object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD700 Offset: 0x2FFD801 VA: 0x2FFD700
	|-SampleObservable.Sample<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD7E0 Offset: 0x2FFD8E1 VA: 0x2FFD7E0
	|-SampleObservable.Sample<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD9C0 Offset: 0x2FFDAC1 VA: 0x2FFD9C0
	|-SampleObservable.Sample<object, object>.OnCompleted
	*/
}

