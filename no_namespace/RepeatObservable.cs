// Namespace: 
private class RepeatObservable.Repeat<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7016
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3CC0 Offset: 0x2FF3DC1 VA: 0x2FF3CC0
	|-RepeatObservable.Repeat<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3CE0 Offset: 0x2FF3DE1 VA: 0x2FF3CE0
	|-RepeatObservable.Repeat<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3E40 Offset: 0x2FF3F41 VA: 0x2FF3E40
	|-RepeatObservable.Repeat<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3F80 Offset: 0x2FF4081 VA: 0x2FF3F80
	|-RepeatObservable.Repeat<object>.OnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x139E0 Offset: 0x13AE1 VA: 0x139E0
private sealed class RepeatObservable.<>c__DisplayClass4_0<T> // TypeDefIndex: 7017
{
	// Fields
	public IObserver<T> observer; // 0x0
	public RepeatObservable<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3DBB0 Offset: 0x2B3DCB1 VA: 0x2B3DBB0
	|-RepeatObservable.<>c__DisplayClass4_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <SubscribeCore>b__0(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3DBC0 Offset: 0x2B3DCC1 VA: 0x2B3DBC0
	|-RepeatObservable.<>c__DisplayClass4_0<object>.<SubscribeCore>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x139F0 Offset: 0x13AF1 VA: 0x139F0
private sealed class RepeatObservable.<>c__DisplayClass4_1<T> // TypeDefIndex: 7018
{
	// Fields
	public int currentCount; // 0x0
	public RepeatObservable.<>c__DisplayClass4_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3DCF0 Offset: 0x2B3DDF1 VA: 0x2B3DCF0
	|-RepeatObservable.<>c__DisplayClass4_1<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <SubscribeCore>b__1(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3DD00 Offset: 0x2B3DE01 VA: 0x2B3DD00
	|-RepeatObservable.<>c__DisplayClass4_1<object>.<SubscribeCore>b__1
	*/
}

