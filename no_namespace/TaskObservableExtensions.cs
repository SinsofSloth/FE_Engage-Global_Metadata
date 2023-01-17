// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12F40 Offset: 0x13041 VA: 0x12F40
private sealed class TaskObservableExtensions.<>c__DisplayClass3_0 // TypeDefIndex: 6652
{
	// Fields
	public Task task; // 0x10
	public AsyncSubject<Unit> subject; // 0x18

	// Methods

	// RVA: 0x1AF8990 Offset: 0x1AF8A91 VA: 0x1AF8990
	public void .ctor() { }

	// RVA: 0x1B0A490 Offset: 0x1B0A591 VA: 0x1B0A490
	internal void <ToObservableSlow>b__0(Task t) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12F60 Offset: 0x13061 VA: 0x12F60
private sealed class TaskObservableExtensions.<>c__DisplayClass15_0<TResult> // TypeDefIndex: 6654
{
	// Fields
	public SingleAssignmentDisposable disposable; // 0x0
	public TaskCompletionSource<TResult> tcs; // 0x0
	public CancellationToken cancellationToken; // 0x0
	public bool hasValue; // 0x0
	public TResult lastValue; // 0x0
	public CancellationTokenRegistration ctr; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38890 Offset: 0x2B38991 VA: 0x2B38890
	|-TaskObservableExtensions.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ToTask>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B388A0 Offset: 0x2B389A1 VA: 0x2B388A0
	|-TaskObservableExtensions.<>c__DisplayClass15_0<object>.<ToTask>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <ToTask>b__1(TResult value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B388E0 Offset: 0x2B389E1 VA: 0x2B388E0
	|-TaskObservableExtensions.<>c__DisplayClass15_0<object>.<ToTask>b__1
	*/

	// RVA: -1 Offset: -1
	internal void <ToTask>b__2(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B388F0 Offset: 0x2B389F1 VA: 0x2B388F0
	|-TaskObservableExtensions.<>c__DisplayClass15_0<object>.<ToTask>b__2
	*/

	// RVA: -1 Offset: -1
	internal void <ToTask>b__3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38940 Offset: 0x2B38A41 VA: 0x2B38940
	|-TaskObservableExtensions.<>c__DisplayClass15_0<object>.<ToTask>b__3
	*/
}

