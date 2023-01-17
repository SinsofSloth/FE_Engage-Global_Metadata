// Namespace: 
private class ObserveOnObservable.ObserveOn_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6999
{
	// Fields
	private readonly ObserveOnObservable<T> parent; // 0x0
	private readonly ISchedulerQueueing scheduler; // 0x0
	private readonly BooleanDisposable isDisposed; // 0x0
	private readonly Action<T> onNext; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObserveOnObservable<T> parent, ISchedulerQueueing scheduler, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710860 Offset: 0x3710961 VA: 0x3710860
	|-ObserveOnObservable.ObserveOn_<object>..ctor
	|
	|-RVA: 0x3711100 Offset: 0x3711201 VA: 0x3711100
	|-ObserveOnObservable.ObserveOn_<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710990 Offset: 0x3710A91 VA: 0x3710990
	|-ObserveOnObservable.ObserveOn_<object>.Run
	|
	|-RVA: 0x3711230 Offset: 0x3711331 VA: 0x3711230
	|-ObserveOnObservable.ObserveOn_<Unit>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNext_(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710A40 Offset: 0x3710B41 VA: 0x3710A40
	|-ObserveOnObservable.ObserveOn_<object>.OnNext_
	|
	|-RVA: 0x37112E0 Offset: 0x37113E1 VA: 0x37112E0
	|-ObserveOnObservable.ObserveOn_<Unit>.OnNext_
	*/

	// RVA: -1 Offset: -1
	private void OnError_(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710AF0 Offset: 0x3710BF1 VA: 0x3710AF0
	|-ObserveOnObservable.ObserveOn_<object>.OnError_
	|
	|-RVA: 0x3711390 Offset: 0x3711491 VA: 0x3711390
	|-ObserveOnObservable.ObserveOn_<Unit>.OnError_
	*/

	// RVA: -1 Offset: -1
	private void OnCompleted_(Unit _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710C30 Offset: 0x3710D31 VA: 0x3710C30
	|-ObserveOnObservable.ObserveOn_<object>.OnCompleted_
	|
	|-RVA: 0x37114D0 Offset: 0x37115D1 VA: 0x37114D0
	|-ObserveOnObservable.ObserveOn_<Unit>.OnCompleted_
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710D60 Offset: 0x3710E61 VA: 0x3710D60
	|-ObserveOnObservable.ObserveOn_<object>.OnNext
	|
	|-RVA: 0x3711600 Offset: 0x3711701 VA: 0x3711600
	|-ObserveOnObservable.ObserveOn_<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710E20 Offset: 0x3710F21 VA: 0x3710E20
	|-ObserveOnObservable.ObserveOn_<object>.OnError
	|
	|-RVA: 0x37116C0 Offset: 0x37117C1 VA: 0x37116C0
	|-ObserveOnObservable.ObserveOn_<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3710F50 Offset: 0x3711051 VA: 0x3710F50
	|-ObserveOnObservable.ObserveOn_<object>.OnCompleted
	|
	|-RVA: 0x37117F0 Offset: 0x37118F1 VA: 0x37117F0
	|-ObserveOnObservable.ObserveOn_<Unit>.OnCompleted
	*/
}

