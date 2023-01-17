// Namespace: 
private class BatchFrameObservable.BatchFrame.ReusableEnumerator<T> : IEnumerator // TypeDefIndex: 7196
{
	// Fields
	private readonly BatchFrameObservable.BatchFrame<T> parent; // 0x0
	private int currentFrame; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BatchFrameObservable.BatchFrame<T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9740 Offset: 0x2FF9841 VA: 0x2FF9740
	|-BatchFrameObservable.BatchFrame.ReusableEnumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9780 Offset: 0x2FF9881 VA: 0x2FF9780
	|-BatchFrameObservable.BatchFrame.ReusableEnumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF9790 Offset: 0x2FF9891 VA: 0x2FF9790
	|-BatchFrameObservable.BatchFrame.ReusableEnumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF99F0 Offset: 0x2FF9AF1 VA: 0x2FF99F0
	|-BatchFrameObservable.BatchFrame.ReusableEnumerator<object>.Reset
	*/
}

// Namespace: 
private class BatchFrameObservable.BatchFrame : OperatorObserverBase<Unit, Unit> // TypeDefIndex: 7200
{
	// Fields
	private readonly BatchFrameObservable parent; // 0x20
	private readonly object gate; // 0x28
	private readonly BooleanDisposable cancellationToken; // 0x30
	private readonly IEnumerator timer; // 0x38
	private bool isRunning; // 0x40
	private bool isCompleted; // 0x41

	// Methods

	// RVA: 0x1AFD450 Offset: 0x1AFD551 VA: 0x1AFD450
	public void .ctor(BatchFrameObservable parent, IObserver<Unit> observer, IDisposable cancel) { }

	// RVA: 0x1AFD5E0 Offset: 0x1AFD6E1 VA: 0x1AFD5E0
	public IDisposable Run() { }

	// RVA: 0x1AFD6A0 Offset: 0x1AFD7A1 VA: 0x1AFD6A0 Slot: 8
	public override void OnNext(Unit value) { }

	// RVA: 0x1AFD8D0 Offset: 0x1AFD9D1 VA: 0x1AFD8D0 Slot: 9
	public override void OnError(Exception error) { }

	// RVA: 0x1AFD9F0 Offset: 0x1AFDAF1 VA: 0x1AFD9F0 Slot: 10
	public override void OnCompleted() { }
}

