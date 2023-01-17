// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x139D0 Offset: 0x13AD1 VA: 0x139D0
private sealed class RefCountObservable.RefCount.<>c__DisplayClass2_0<T> // TypeDefIndex: 7013
{
	// Fields
	public IDisposable subcription; // 0x0
	public RefCountObservable.RefCount<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3B090 Offset: 0x2B3B191 VA: 0x2B3B090
	|-RefCountObservable.RefCount.<>c__DisplayClass2_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Run>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3B0A0 Offset: 0x2B3B1A1 VA: 0x2B3B0A0
	|-RefCountObservable.RefCount.<>c__DisplayClass2_0<object>.<Run>b__0
	*/
}

// Namespace: 
private class RefCountObservable.RefCount<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7014
{
	// Fields
	private readonly RefCountObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(RefCountObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9650 Offset: 0x2FE9751 VA: 0x2FE9650
	|-RefCountObservable.RefCount<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE96A0 Offset: 0x2FE97A1 VA: 0x2FE96A0
	|-RefCountObservable.RefCount<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9980 Offset: 0x2FE9A81 VA: 0x2FE9980
	|-RefCountObservable.RefCount<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9A30 Offset: 0x2FE9B31 VA: 0x2FE9A30
	|-RefCountObservable.RefCount<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9B70 Offset: 0x2FE9C71 VA: 0x2FE9B70
	|-RefCountObservable.RefCount<object>.OnCompleted
	*/
}

