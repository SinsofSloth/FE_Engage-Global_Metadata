// Namespace: 
private class RepeatUntilObservable.RepeatUntil<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7217
{
	// Fields
	private readonly RepeatUntilObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private IEnumerator<IObservable<T>> e; // 0x0
	private SerialDisposable subscription; // 0x0
	private SingleAssignmentDisposable schedule; // 0x0
	private Action nextSelf; // 0x0
	private bool isStopped; // 0x0
	private bool isDisposed; // 0x0
	private bool isFirstSubscribe; // 0x0
	private IDisposable stopper; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(RepeatUntilObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF56A0 Offset: 0x2FF57A1 VA: 0x2FF56A0
	|-RepeatUntilObservable.RepeatUntil<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5760 Offset: 0x2FF5861 VA: 0x2FF5760
	|-RepeatUntilObservable.RepeatUntil<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void RecursiveRun(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5C90 Offset: 0x2FF5D91 VA: 0x2FF5C90
	|-RepeatUntilObservable.RepeatUntil<object>.RecursiveRun
	*/

	[IteratorStateMachineAttribute] // RVA: 0x18510 Offset: 0x18611 VA: 0x18510
	// RVA: -1 Offset: -1
	private static IEnumerator SubscribeAfterEndOfFrame(SingleAssignmentDisposable d, IObservable<T> source, IObserver<T> observer, GameObject lifeTimeChecker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6410 Offset: 0x2FF6511 VA: 0x2FF6410
	|-RepeatUntilObservable.RepeatUntil<object>.SubscribeAfterEndOfFrame
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6520 Offset: 0x2FF6621 VA: 0x2FF6520
	|-RepeatUntilObservable.RepeatUntil<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF65D0 Offset: 0x2FF66D1 VA: 0x2FF65D0
	|-RepeatUntilObservable.RepeatUntil<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6710 Offset: 0x2FF6811 VA: 0x2FF6710
	|-RepeatUntilObservable.RepeatUntil<object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18580 Offset: 0x18681 VA: 0x18580
	// RVA: -1 Offset: -1
	private void <Run>b__11_0(Unit _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF68F0 Offset: 0x2FF69F1 VA: 0x2FF68F0
	|-RepeatUntilObservable.RepeatUntil<object>.<Run>b__11_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18590 Offset: 0x18691 VA: 0x18590
	// RVA: -1 Offset: -1
	private void <Run>b__11_1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF6AF0 Offset: 0x2FF6BF1 VA: 0x2FF6AF0
	|-RepeatUntilObservable.RepeatUntil<object>.<Run>b__11_1
	*/
}

