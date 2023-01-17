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
[CompilerGeneratedAttribute] // RVA: 0x139A0 Offset: 0x13AA1 VA: 0x139A0
private sealed class ObserveOnObservable.ObserveOn.<>c__DisplayClass10_0<T> // TypeDefIndex: 6997
{
	// Fields
	public ObserveOnObservable.ObserveOn<T> <>4__this; // 0x0
	public ObserveOnObservable.ObserveOn.SchedulableAction<T> action; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37750 Offset: 0x2B37851 VA: 0x2B37750
	|-ObserveOnObservable.ObserveOn.<>c__DisplayClass10_0<object>..ctor
	|
	|-RVA: 0x2B37B00 Offset: 0x2B37C01 VA: 0x2B37B00
	|-ObserveOnObservable.ObserveOn.<>c__DisplayClass10_0<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ProcessNext>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37760 Offset: 0x2B37861 VA: 0x2B37760
	|-ObserveOnObservable.ObserveOn.<>c__DisplayClass10_0<object>.<ProcessNext>b__0
	|
	|-RVA: 0x2B37B10 Offset: 0x2B37C11 VA: 0x2B37B10
	|-ObserveOnObservable.ObserveOn.<>c__DisplayClass10_0<Unit>.<ProcessNext>b__0
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

