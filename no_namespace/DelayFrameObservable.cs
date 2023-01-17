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

