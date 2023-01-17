// Namespace: 
private class FinallyObservable.Finally<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6961
{
	// Fields
	private readonly FinallyObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FinallyObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5B80 Offset: 0x33D5C81 VA: 0x33D5B80
	|-FinallyObservable.Finally<long>..ctor
	|
	|-RVA: 0x33D60E0 Offset: 0x33D61E1 VA: 0x33D60E0
	|-FinallyObservable.Finally<object>..ctor
	|
	|-RVA: 0x33D6640 Offset: 0x33D6741 VA: 0x33D6640
	|-FinallyObservable.Finally<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5BD0 Offset: 0x33D5CD1 VA: 0x33D5BD0
	|-FinallyObservable.Finally<long>.Run
	|
	|-RVA: 0x33D6130 Offset: 0x33D6231 VA: 0x33D6130
	|-FinallyObservable.Finally<object>.Run
	|
	|-RVA: 0x33D6690 Offset: 0x33D6791 VA: 0x33D6690
	|-FinallyObservable.Finally<Unit>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5DB0 Offset: 0x33D5EB1 VA: 0x33D5DB0
	|-FinallyObservable.Finally<long>.OnNext
	|
	|-RVA: 0x33D6310 Offset: 0x33D6411 VA: 0x33D6310
	|-FinallyObservable.Finally<object>.OnNext
	|
	|-RVA: 0x33D6870 Offset: 0x33D6971 VA: 0x33D6870
	|-FinallyObservable.Finally<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5E60 Offset: 0x33D5F61 VA: 0x33D5E60
	|-FinallyObservable.Finally<long>.OnError
	|
	|-RVA: 0x33D63C0 Offset: 0x33D64C1 VA: 0x33D63C0
	|-FinallyObservable.Finally<object>.OnError
	|
	|-RVA: 0x33D6920 Offset: 0x33D6A21 VA: 0x33D6920
	|-FinallyObservable.Finally<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5FA0 Offset: 0x33D60A1 VA: 0x33D5FA0
	|-FinallyObservable.Finally<long>.OnCompleted
	|
	|-RVA: 0x33D6500 Offset: 0x33D6601 VA: 0x33D6500
	|-FinallyObservable.Finally<object>.OnCompleted
	|
	|-RVA: 0x33D6A60 Offset: 0x33D6B61 VA: 0x33D6A60
	|-FinallyObservable.Finally<Unit>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x183B0 Offset: 0x184B1 VA: 0x183B0
	// RVA: -1 Offset: -1
	private void <Run>b__2_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D60D0 Offset: 0x33D61D1 VA: 0x33D60D0
	|-FinallyObservable.Finally<long>.<Run>b__2_0
	|
	|-RVA: 0x33D6630 Offset: 0x33D6731 VA: 0x33D6630
	|-FinallyObservable.Finally<object>.<Run>b__2_0
	|
	|-RVA: 0x33D6B90 Offset: 0x33D6C91 VA: 0x33D6B90
	|-FinallyObservable.Finally<Unit>.<Run>b__2_0
	*/
}

