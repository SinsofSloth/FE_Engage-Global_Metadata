// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A90 Offset: 0x13B91 VA: 0x13A90
private sealed class ToObservableObservable.ToObservable.<>c__DisplayClass2_0<T> // TypeDefIndex: 7122
{
	// Fields
	public SingleAssignmentDisposable flag; // 0x0
	public IEnumerator<T> e; // 0x0
	public ToObservableObservable.ToObservable<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3B280 Offset: 0x2B3B381 VA: 0x2B3B280
	|-ToObservableObservable.ToObservable.<>c__DisplayClass2_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Run>b__0(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3B290 Offset: 0x2B3B391 VA: 0x2B3B290
	|-ToObservableObservable.ToObservable.<>c__DisplayClass2_0<object>.<Run>b__0
	*/
}

// Namespace: 
private class ToObservableObservable.ToObservable<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7123
{
	// Fields
	private readonly ToObservableObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ToObservableObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356EF60 Offset: 0x356F061 VA: 0x356EF60
	|-ToObservableObservable.ToObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356EFB0 Offset: 0x356F0B1 VA: 0x356EFB0
	|-ToObservableObservable.ToObservable<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356F7E0 Offset: 0x356F8E1 VA: 0x356F7E0
	|-ToObservableObservable.ToObservable<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356F7F0 Offset: 0x356F8F1 VA: 0x356F7F0
	|-ToObservableObservable.ToObservable<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356F930 Offset: 0x356FA31 VA: 0x356F930
	|-ToObservableObservable.ToObservable<object>.OnCompleted
	*/
}

