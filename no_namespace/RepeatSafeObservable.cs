// Namespace: 
private class RepeatSafeObservable.RepeatSafe<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7020
{
	// Fields
	private readonly RepeatSafeObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private IEnumerator<IObservable<T>> e; // 0x0
	private SerialDisposable subscription; // 0x0
	private Action nextSelf; // 0x0
	private bool isDisposed; // 0x0
	private bool isRunNext; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(RepeatSafeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF45C0 Offset: 0x2FF46C1 VA: 0x2FF45C0
	|-RepeatSafeObservable.RepeatSafe<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF4680 Offset: 0x2FF4781 VA: 0x2FF4680
	|-RepeatSafeObservable.RepeatSafe<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void RecursiveRun(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF48C0 Offset: 0x2FF49C1 VA: 0x2FF48C0
	|-RepeatSafeObservable.RepeatSafe<object>.RecursiveRun
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5080 Offset: 0x2FF5181 VA: 0x2FF5080
	|-RepeatSafeObservable.RepeatSafe<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5130 Offset: 0x2FF5231 VA: 0x2FF5130
	|-RepeatSafeObservable.RepeatSafe<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5270 Offset: 0x2FF5371 VA: 0x2FF5270
	|-RepeatSafeObservable.RepeatSafe<object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x183D0 Offset: 0x184D1 VA: 0x183D0
	// RVA: -1 Offset: -1
	private void <Run>b__8_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF5450 Offset: 0x2FF5551 VA: 0x2FF5450
	|-RepeatSafeObservable.RepeatSafe<object>.<Run>b__8_0
	*/
}

