// Namespace: 
private class ThrowObservable.Throw<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7101
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399BAF0 Offset: 0x399BBF1 VA: 0x399BAF0
	|-ThrowObservable.Throw<object>..ctor
	|
	|-RVA: 0x399BEE0 Offset: 0x399BFE1 VA: 0x399BEE0
	|-ThrowObservable.Throw<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399BB10 Offset: 0x399BC11 VA: 0x399BB10
	|-ThrowObservable.Throw<object>.OnNext
	|
	|-RVA: 0x399BF00 Offset: 0x399C001 VA: 0x399BF00
	|-ThrowObservable.Throw<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399BC70 Offset: 0x399BD71 VA: 0x399BC70
	|-ThrowObservable.Throw<object>.OnError
	|
	|-RVA: 0x399C060 Offset: 0x399C161 VA: 0x399C060
	|-ThrowObservable.Throw<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399BDB0 Offset: 0x399BEB1 VA: 0x399BDB0
	|-ThrowObservable.Throw<object>.OnCompleted
	|
	|-RVA: 0x399C1A0 Offset: 0x399C2A1 VA: 0x399C1A0
	|-ThrowObservable.Throw<Unit>.OnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A30 Offset: 0x13B31 VA: 0x13A30
private sealed class ThrowObservable.<>c__DisplayClass3_0<T> // TypeDefIndex: 7102
{
	// Fields
	public IObserver<T> observer; // 0x0
	public ThrowObservable<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3D640 Offset: 0x2B3D741 VA: 0x2B3D640
	|-ThrowObservable.<>c__DisplayClass3_0<object>..ctor
	|
	|-RVA: 0x2B3D960 Offset: 0x2B3DA61 VA: 0x2B3D960
	|-ThrowObservable.<>c__DisplayClass3_0<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <SubscribeCore>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3D650 Offset: 0x2B3D751 VA: 0x2B3D650
	|-ThrowObservable.<>c__DisplayClass3_0<object>.<SubscribeCore>b__0
	|
	|-RVA: 0x2B3D970 Offset: 0x2B3DA71 VA: 0x2B3D970
	|-ThrowObservable.<>c__DisplayClass3_0<Unit>.<SubscribeCore>b__0
	*/
}

