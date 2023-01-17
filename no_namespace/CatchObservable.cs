// Namespace: 
private class CatchObservable.Catch<T, TException> : OperatorObserverBase<T, T> // TypeDefIndex: 6884
{
	// Fields
	private readonly CatchObservable<T, TException> parent; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0
	private SingleAssignmentDisposable exceptionSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CatchObservable<T, TException> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2D90 Offset: 0x30D2E91 VA: 0x30D2D90
	|-CatchObservable.Catch<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2DE0 Offset: 0x30D2EE1 VA: 0x30D2DE0
	|-CatchObservable.Catch<object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2F30 Offset: 0x30D3031 VA: 0x30D2F30
	|-CatchObservable.Catch<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2FE0 Offset: 0x30D30E1 VA: 0x30D2FE0
	|-CatchObservable.Catch<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3480 Offset: 0x30D3581 VA: 0x30D3480
	|-CatchObservable.Catch<object, object>.OnCompleted
	*/
}

// Namespace: 
private class CatchObservable.Catch<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6886
{
	// Fields
	private readonly CatchObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool isDisposed; // 0x0
	private IEnumerator<IObservable<T>> e; // 0x0
	private SerialDisposable subscription; // 0x0
	private Exception lastException; // 0x0
	private Action nextSelf; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CatchObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D1F00 Offset: 0x30D2001 VA: 0x30D1F00
	|-CatchObservable.Catch<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D1FC0 Offset: 0x30D20C1 VA: 0x30D1FC0
	|-CatchObservable.Catch<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void RecursiveRun(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2200 Offset: 0x30D2301 VA: 0x30D2200
	|-CatchObservable.Catch<object>.RecursiveRun
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2A20 Offset: 0x30D2B21 VA: 0x30D2A20
	|-CatchObservable.Catch<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2AD0 Offset: 0x30D2BD1 VA: 0x30D2AD0
	|-CatchObservable.Catch<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2B00 Offset: 0x30D2C01 VA: 0x30D2B00
	|-CatchObservable.Catch<object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x182A0 Offset: 0x183A1 VA: 0x182A0
	// RVA: -1 Offset: -1
	private void <Run>b__8_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D2C30 Offset: 0x30D2D31 VA: 0x30D2C30
	|-CatchObservable.Catch<object>.<Run>b__8_0
	*/
}

