// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13AB0 Offset: 0x13BB1 VA: 0x13AB0
private sealed class DelayFrameObservable.DelayFrame.<DrainQueue>d__14<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7202
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public DelayFrameObservable.DelayFrame<T> <>4__this; // 0x0
	public int frameCount; // 0x0
	public Queue<T> q; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x184C0 Offset: 0x185C1 VA: 0x184C0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B940 Offset: 0x2B4BA41 VA: 0x2B4B940
	|-DelayFrameObservable.DelayFrame.<DrainQueue>d__14<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x184D0 Offset: 0x185D1 VA: 0x184D0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B970 Offset: 0x2B4BA71 VA: 0x2B4B970
	|-DelayFrameObservable.DelayFrame.<DrainQueue>d__14<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B980 Offset: 0x2B4BA81 VA: 0x2B4B980
	|-DelayFrameObservable.DelayFrame.<DrainQueue>d__14<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x184E0 Offset: 0x185E1 VA: 0x184E0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C190 Offset: 0x2B4C291 VA: 0x2B4C190
	|-DelayFrameObservable.DelayFrame.<DrainQueue>d__14<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x184F0 Offset: 0x185F1 VA: 0x184F0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C1A0 Offset: 0x2B4C2A1 VA: 0x2B4C1A0
	|-DelayFrameObservable.DelayFrame.<DrainQueue>d__14<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18500 Offset: 0x18601 VA: 0x18500
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C1E0 Offset: 0x2B4C2E1 VA: 0x2B4C1E0
	|-DelayFrameObservable.DelayFrame.<DrainQueue>d__14<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
private class DelayFrameObservable.DelayFrame<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7203
{
	// Fields
	private readonly DelayFrameObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly DelayFrameObservable.QueuePool<T> pool; // 0x0
	private int runningEnumeratorCount; // 0x0
	private bool readyDrainEnumerator; // 0x0
	private bool running; // 0x0
	private IDisposable sourceSubscription; // 0x0
	private Queue<T> currentQueueReference; // 0x0
	private bool calledCompleted; // 0x0
	private bool hasError; // 0x0
	private Exception error; // 0x0
	private BooleanDisposable cancelationToken; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DelayFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2512790 Offset: 0x2512891 VA: 0x2512790
	|-DelayFrameObservable.DelayFrame<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25128A0 Offset: 0x25129A1 VA: 0x25128A0
	|-DelayFrameObservable.DelayFrame<object>.Run
	*/

	[IteratorStateMachineAttribute] // RVA: 0x18450 Offset: 0x18551 VA: 0x18450
	// RVA: -1 Offset: -1
	private IEnumerator DrainQueue(Queue<T> q, int frameCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2512A00 Offset: 0x2512B01 VA: 0x2512A00
	|-DelayFrameObservable.DelayFrame<object>.DrainQueue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2512AA0 Offset: 0x2512BA1 VA: 0x2512AA0
	|-DelayFrameObservable.DelayFrame<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2512E00 Offset: 0x2512F01 VA: 0x2512E00
	|-DelayFrameObservable.DelayFrame<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25130E0 Offset: 0x25131E1 VA: 0x25130E0
	|-DelayFrameObservable.DelayFrame<object>.OnCompleted
	*/
}

// Namespace: 
private class DelayFrameObservable.QueuePool<T> // TypeDefIndex: 7204
{
	// Fields
	private readonly object gate; // 0x0
	private readonly Queue<Queue<T>> pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public Queue<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87750 Offset: 0x2A87851 VA: 0x2A87750
	|-DelayFrameObservable.QueuePool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Return(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A878B0 Offset: 0x2A879B1 VA: 0x2A878B0
	|-DelayFrameObservable.QueuePool<object>.Return
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A879A0 Offset: 0x2A87AA1 VA: 0x2A879A0
	|-DelayFrameObservable.QueuePool<object>..ctor
	*/
}

