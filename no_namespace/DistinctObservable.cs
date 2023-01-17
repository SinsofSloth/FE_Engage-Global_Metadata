// Namespace: 
private class DistinctObservable.Distinct<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6936
{
	// Fields
	private readonly HashSet<T> hashSet; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DistinctObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2630880 Offset: 0x2630981 VA: 0x2630880
	|-DistinctObservable.Distinct<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2630950 Offset: 0x2630A51 VA: 0x2630950
	|-DistinctObservable.Distinct<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2630BB0 Offset: 0x2630CB1 VA: 0x2630BB0
	|-DistinctObservable.Distinct<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2630CF0 Offset: 0x2630DF1 VA: 0x2630CF0
	|-DistinctObservable.Distinct<object>.OnCompleted
	*/
}

// Namespace: 
private class DistinctObservable.Distinct<T, TKey> : OperatorObserverBase<T, T> // TypeDefIndex: 6938
{
	// Fields
	private readonly DistinctObservable<T, TKey> parent; // 0x0
	private readonly HashSet<TKey> hashSet; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DistinctObservable<T, TKey> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2630E20 Offset: 0x2630F21 VA: 0x2630E20
	|-DistinctObservable.Distinct<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2630F00 Offset: 0x2631001 VA: 0x2630F00
	|-DistinctObservable.Distinct<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631180 Offset: 0x2631281 VA: 0x2631180
	|-DistinctObservable.Distinct<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26312C0 Offset: 0x26313C1 VA: 0x26312C0
	|-DistinctObservable.Distinct<object, object>.OnCompleted
	*/
}

