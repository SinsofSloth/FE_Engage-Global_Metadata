// Namespace: 
private class AsyncSubject.Subscription<T> : IDisposable // TypeDefIndex: 6631
{
	// Fields
	private readonly object gate; // 0x0
	private AsyncSubject<T> parent; // 0x0
	private IObserver<T> unsubscribeTarget; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AsyncSubject<T> parent, IObserver<T> unsubscribeTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AFD00 Offset: 0x34AFE01 VA: 0x34AFD00
	|-AsyncSubject.Subscription<object>..ctor
	|
	|-RVA: 0x34B1020 Offset: 0x34B1121 VA: 0x34B1020
	|-AsyncSubject.Subscription<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AFDB0 Offset: 0x34AFEB1 VA: 0x34AFDB0
	|-AsyncSubject.Subscription<object>.Dispose
	|
	|-RVA: 0x34B10D0 Offset: 0x34B11D1 VA: 0x34B10D0
	|-AsyncSubject.Subscription<Unit>.Dispose
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12EF0 Offset: 0x12FF1 VA: 0x12EF0
[Serializable]
private sealed class AsyncSubject.AwaitObserver.<>c<T> // TypeDefIndex: 6632
{
	// Fields
	public static readonly AsyncSubject.AwaitObserver.<>c<T> <>9; // 0x0
	public static SendOrPostCallback <>9__6_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33B90 Offset: 0x2B33C91 VA: 0x2B33B90
	|-AsyncSubject.AwaitObserver.<>c<object>..cctor
	|
	|-RVA: 0x2B34970 Offset: 0x2B34A71 VA: 0x2B34970
	|-AsyncSubject.AwaitObserver.<>c<Unit>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33C70 Offset: 0x2B33D71 VA: 0x2B33C70
	|-AsyncSubject.AwaitObserver.<>c<object>..ctor
	|
	|-RVA: 0x2B34A50 Offset: 0x2B34B51 VA: 0x2B34A50
	|-AsyncSubject.AwaitObserver.<>c<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <InvokeOnOriginalContext>b__6_0(object c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33C80 Offset: 0x2B33D81 VA: 0x2B33C80
	|-AsyncSubject.AwaitObserver.<>c<object>.<InvokeOnOriginalContext>b__6_0
	|
	|-RVA: 0x2B34A60 Offset: 0x2B34B61 VA: 0x2B34A60
	|-AsyncSubject.AwaitObserver.<>c<Unit>.<InvokeOnOriginalContext>b__6_0
	*/
}

// Namespace: 
private class AsyncSubject.AwaitObserver<T> : IObserver<T> // TypeDefIndex: 6633
{
	// Fields
	private readonly SynchronizationContext _context; // 0x0
	private readonly Action _callback; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action callback, bool originalContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EBE0 Offset: 0x2F5ECE1 VA: 0x2F5EBE0
	|-AsyncSubject.AwaitObserver<object>..ctor
	|
	|-RVA: 0x2F5EEA0 Offset: 0x2F5EFA1 VA: 0x2F5EEA0
	|-AsyncSubject.AwaitObserver<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC40 Offset: 0x2F5ED41 VA: 0x2F5EC40
	|-AsyncSubject.AwaitObserver<object>.OnCompleted
	|
	|-RVA: 0x2F5EF00 Offset: 0x2F5F001 VA: 0x2F5EF00
	|-AsyncSubject.AwaitObserver<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC60 Offset: 0x2F5ED61 VA: 0x2F5EC60
	|-AsyncSubject.AwaitObserver<object>.OnError
	|
	|-RVA: 0x2F5EF20 Offset: 0x2F5F021 VA: 0x2F5EF20
	|-AsyncSubject.AwaitObserver<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC80 Offset: 0x2F5ED81 VA: 0x2F5EC80
	|-AsyncSubject.AwaitObserver<object>.OnNext
	|
	|-RVA: 0x2F5EF40 Offset: 0x2F5F041 VA: 0x2F5EF40
	|-AsyncSubject.AwaitObserver<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1
	private void InvokeOnOriginalContext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EC90 Offset: 0x2F5ED91 VA: 0x2F5EC90
	|-AsyncSubject.AwaitObserver<object>.InvokeOnOriginalContext
	|
	|-RVA: 0x2F5EF50 Offset: 0x2F5F051 VA: 0x2F5EF50
	|-AsyncSubject.AwaitObserver<Unit>.InvokeOnOriginalContext
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12F00 Offset: 0x13001 VA: 0x12F00
private sealed class AsyncSubject.<>c__DisplayClass25_0<T> // TypeDefIndex: 6634
{
	// Fields
	public ManualResetEvent e; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3ACF0 Offset: 0x2B3ADF1 VA: 0x2B3ACF0
	|-AsyncSubject.<>c__DisplayClass25_0<object>..ctor
	|
	|-RVA: 0x2B3AD10 Offset: 0x2B3AE11 VA: 0x2B3AD10
	|-AsyncSubject.<>c__DisplayClass25_0<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <GetResult>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AD00 Offset: 0x2B3AE01 VA: 0x2B3AD00
	|-AsyncSubject.<>c__DisplayClass25_0<object>.<GetResult>b__0
	|
	|-RVA: 0x2B3AD20 Offset: 0x2B3AE21 VA: 0x2B3AD20
	|-AsyncSubject.<>c__DisplayClass25_0<Unit>.<GetResult>b__0
	*/
}

