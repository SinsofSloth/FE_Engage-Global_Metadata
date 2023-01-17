// Namespace: 
private class DoOnCancelObservable.DoOnCancel<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6956
{
	// Fields
	private readonly DoOnCancelObservable<T> parent; // 0x0
	private bool isCompletedCall; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoOnCancelObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26343B0 Offset: 0x26344B1 VA: 0x26343B0
	|-DoOnCancelObservable.DoOnCancel<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634400 Offset: 0x2634501 VA: 0x2634400
	|-DoOnCancelObservable.DoOnCancel<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634550 Offset: 0x2634651 VA: 0x2634550
	|-DoOnCancelObservable.DoOnCancel<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634600 Offset: 0x2634701 VA: 0x2634600
	|-DoOnCancelObservable.DoOnCancel<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634740 Offset: 0x2634841 VA: 0x2634740
	|-DoOnCancelObservable.DoOnCancel<object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x183A0 Offset: 0x184A1 VA: 0x183A0
	// RVA: -1 Offset: -1
	private void <Run>b__3_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634880 Offset: 0x2634981 VA: 0x2634880
	|-DoOnCancelObservable.DoOnCancel<object>.<Run>b__3_0
	*/
}

