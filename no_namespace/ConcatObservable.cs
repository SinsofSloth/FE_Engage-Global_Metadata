// Namespace: 
private class ConcatObservable.Concat<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6913
{
	// Fields
	private readonly ConcatObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool isDisposed; // 0x0
	private IEnumerator<IObservable<T>> e; // 0x0
	private SerialDisposable subscription; // 0x0
	private Action nextSelf; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ConcatObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502150 Offset: 0x2502251 VA: 0x2502150
	|-ConcatObservable.Concat<object>..ctor
	|
	|-RVA: 0x2502F00 Offset: 0x2503001 VA: 0x2502F00
	|-ConcatObservable.Concat<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502210 Offset: 0x2502311 VA: 0x2502210
	|-ConcatObservable.Concat<object>.Run
	|
	|-RVA: 0x2502FC0 Offset: 0x25030C1 VA: 0x2502FC0
	|-ConcatObservable.Concat<Unit>.Run
	*/

	// RVA: -1 Offset: -1
	private void RecursiveRun(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502450 Offset: 0x2502551 VA: 0x2502450
	|-ConcatObservable.Concat<object>.RecursiveRun
	|
	|-RVA: 0x2503200 Offset: 0x2503301 VA: 0x2503200
	|-ConcatObservable.Concat<Unit>.RecursiveRun
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502BA0 Offset: 0x2502CA1 VA: 0x2502BA0
	|-ConcatObservable.Concat<object>.OnNext
	|
	|-RVA: 0x2503950 Offset: 0x2503A51 VA: 0x2503950
	|-ConcatObservable.Concat<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502C50 Offset: 0x2502D51 VA: 0x2502C50
	|-ConcatObservable.Concat<object>.OnError
	|
	|-RVA: 0x2503A00 Offset: 0x2503B01 VA: 0x2503A00
	|-ConcatObservable.Concat<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502D90 Offset: 0x2502E91 VA: 0x2502D90
	|-ConcatObservable.Concat<object>.OnCompleted
	|
	|-RVA: 0x2503B40 Offset: 0x2503C41 VA: 0x2503B40
	|-ConcatObservable.Concat<Unit>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18320 Offset: 0x18421 VA: 0x18320
	// RVA: -1 Offset: -1
	private void <Run>b__7_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502DA0 Offset: 0x2502EA1 VA: 0x2502DA0
	|-ConcatObservable.Concat<object>.<Run>b__7_0
	|
	|-RVA: 0x2503B50 Offset: 0x2503C51 VA: 0x2503B50
	|-ConcatObservable.Concat<Unit>.<Run>b__7_0
	*/
}

