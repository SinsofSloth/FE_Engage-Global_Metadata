// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13AD0 Offset: 0x13BD1 VA: 0x13AD0
private sealed class RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7216
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public SingleAssignmentDisposable d; // 0x0
	public GameObject lifeTimeChecker; // 0x0
	public IObservable<T> source; // 0x0
	public IObserver<T> observer; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x185A0 Offset: 0x186A1 VA: 0x185A0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB7B0 Offset: 0x1FBB8B1 VA: 0x1FBB7B0
	|-RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x185B0 Offset: 0x186B1 VA: 0x185B0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB7E0 Offset: 0x1FBB8E1 VA: 0x1FBB7E0
	|-RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB7F0 Offset: 0x1FBB8F1 VA: 0x1FBB7F0
	|-RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x185C0 Offset: 0x186C1 VA: 0x185C0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB990 Offset: 0x1FBBA91 VA: 0x1FBB990
	|-RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x185D0 Offset: 0x186D1 VA: 0x185D0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB9A0 Offset: 0x1FBBAA1 VA: 0x1FBB9A0
	|-RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x185E0 Offset: 0x186E1 VA: 0x185E0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB9E0 Offset: 0x1FBBAE1 VA: 0x1FBB9E0
	|-RepeatUntilObservable.RepeatUntil.<SubscribeAfterEndOfFrame>d__13<object>.System.Collections.IEnumerator.get_Current
	*/
}

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

