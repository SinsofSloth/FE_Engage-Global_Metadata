// Namespace: 
private class PairwiseObservable.Pairwise<T, TR> : OperatorObserverBase<T, TR> // TypeDefIndex: 7006
{
	// Fields
	private readonly PairwiseObservable<T, TR> parent; // 0x0
	private T prev; // 0x0
	private bool isFirst; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PairwiseObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5FF80 Offset: 0x2A60081 VA: 0x2A5FF80
	|-PairwiseObservable.Pairwise<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5FFE0 Offset: 0x2A600E1 VA: 0x2A5FFE0
	|-PairwiseObservable.Pairwise<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60280 Offset: 0x2A60381 VA: 0x2A60280
	|-PairwiseObservable.Pairwise<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A603C0 Offset: 0x2A604C1 VA: 0x2A603C0
	|-PairwiseObservable.Pairwise<object, object>.OnCompleted
	*/
}

// Namespace: 
private class PairwiseObservable.Pairwise<T> : OperatorObserverBase<T, Pair<T>> // TypeDefIndex: 7008
{
	// Fields
	private T prev; // 0x0
	private bool isFirst; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<Pair<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F870 Offset: 0x2A5F971 VA: 0x2A5F870
	|-PairwiseObservable.Pairwise<int>..ctor
	|
	|-RVA: 0x2A5FBD0 Offset: 0x2A5FCD1 VA: 0x2A5FBD0
	|-PairwiseObservable.Pairwise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F890 Offset: 0x2A5F991 VA: 0x2A5F890
	|-PairwiseObservable.Pairwise<int>.OnNext
	|
	|-RVA: 0x2A5FBF0 Offset: 0x2A5FCF1 VA: 0x2A5FBF0
	|-PairwiseObservable.Pairwise<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F960 Offset: 0x2A5FA61 VA: 0x2A5F960
	|-PairwiseObservable.Pairwise<int>.OnError
	|
	|-RVA: 0x2A5FD10 Offset: 0x2A5FE11 VA: 0x2A5FD10
	|-PairwiseObservable.Pairwise<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5FAA0 Offset: 0x2A5FBA1 VA: 0x2A5FAA0
	|-PairwiseObservable.Pairwise<int>.OnCompleted
	|
	|-RVA: 0x2A5FE50 Offset: 0x2A5FF51 VA: 0x2A5FE50
	|-PairwiseObservable.Pairwise<object>.OnCompleted
	*/
}

