// Namespace: 
private class ObserveOnObservable.ObserveOn.SchedulableAction<T> : IDisposable // TypeDefIndex: 6996
{
	// Fields
	public Notification<T> data; // 0x0
	public LinkedListNode<ObserveOnObservable.ObserveOn.SchedulableAction<T>> node; // 0x0
	public IDisposable schedule; // 0x0

	// Properties
	public bool IsScheduled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000550 Offset: 0x3000651 VA: 0x3000550
	|-ObserveOnObservable.ObserveOn.SchedulableAction<object>.Dispose
	|
	|-RVA: 0x3000690 Offset: 0x3000791 VA: 0x3000690
	|-ObserveOnObservable.ObserveOn.SchedulableAction<Unit>.Dispose
	*/

	// RVA: -1 Offset: -1
	public bool get_IsScheduled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000670 Offset: 0x3000771 VA: 0x3000670
	|-ObserveOnObservable.ObserveOn.SchedulableAction<object>.get_IsScheduled
	|
	|-RVA: 0x30007B0 Offset: 0x30008B1 VA: 0x30007B0
	|-ObserveOnObservable.ObserveOn.SchedulableAction<Unit>.get_IsScheduled
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000680 Offset: 0x3000781 VA: 0x3000680
	|-ObserveOnObservable.ObserveOn.SchedulableAction<object>..ctor
	|
	|-RVA: 0x30007C0 Offset: 0x30008C1 VA: 0x30007C0
	|-ObserveOnObservable.ObserveOn.SchedulableAction<Unit>..ctor
	*/
}

// Namespace: 
private class ObserveOnObservable.ObserveOn<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6998
{
	// Fields
	private readonly ObserveOnObservable<T> parent; // 0x0
	private readonly LinkedList<ObserveOnObservable.ObserveOn.SchedulableAction<T>> actions; // 0x0
	private bool isDisposed; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObserveOnObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F300 Offset: 0x370F401 VA: 0x370F300
	|-ObserveOnObservable.ObserveOn<object>..ctor
	|
	|-RVA: 0x370FC00 Offset: 0x370FD01 VA: 0x370FC00
	|-ObserveOnObservable.ObserveOn<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F3C0 Offset: 0x370F4C1 VA: 0x370F3C0
	|-ObserveOnObservable.ObserveOn<object>.Run
	|
	|-RVA: 0x370FCC0 Offset: 0x370FDC1 VA: 0x370FCC0
	|-ObserveOnObservable.ObserveOn<Unit>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F510 Offset: 0x370F611 VA: 0x370F510
	|-ObserveOnObservable.ObserveOn<object>.OnNext
	|
	|-RVA: 0x370FE10 Offset: 0x370FF11 VA: 0x370FE10
	|-ObserveOnObservable.ObserveOn<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F5A0 Offset: 0x370F6A1 VA: 0x370F5A0
	|-ObserveOnObservable.ObserveOn<object>.OnError
	|
	|-RVA: 0x370FEA0 Offset: 0x370FFA1 VA: 0x370FEA0
	|-ObserveOnObservable.ObserveOn<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F630 Offset: 0x370F731 VA: 0x370F630
	|-ObserveOnObservable.ObserveOn<object>.OnCompleted
	|
	|-RVA: 0x370FF30 Offset: 0x3710031 VA: 0x370FF30
	|-ObserveOnObservable.ObserveOn<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private void QueueAction(Notification<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F6B0 Offset: 0x370F7B1 VA: 0x370F6B0
	|-ObserveOnObservable.ObserveOn<object>.QueueAction
	|
	|-RVA: 0x370FFB0 Offset: 0x37100B1 VA: 0x370FFB0
	|-ObserveOnObservable.ObserveOn<Unit>.QueueAction
	*/

	// RVA: -1 Offset: -1
	private void ProcessNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370F820 Offset: 0x370F921 VA: 0x370F820
	|-ObserveOnObservable.ObserveOn<object>.ProcessNext
	|
	|-RVA: 0x3710120 Offset: 0x3710221 VA: 0x3710120
	|-ObserveOnObservable.ObserveOn<Unit>.ProcessNext
	*/

	[CompilerGeneratedAttribute] // RVA: 0x183C0 Offset: 0x184C1 VA: 0x183C0
	// RVA: -1 Offset: -1
	private void <Run>b__5_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370FAC0 Offset: 0x370FBC1 VA: 0x370FAC0
	|-ObserveOnObservable.ObserveOn<object>.<Run>b__5_0
	|
	|-RVA: 0x37103C0 Offset: 0x37104C1 VA: 0x37103C0
	|-ObserveOnObservable.ObserveOn<Unit>.<Run>b__5_0
	*/
}

