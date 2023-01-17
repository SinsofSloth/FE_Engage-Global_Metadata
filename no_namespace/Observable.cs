// Namespace: 
private class Observable.ConnectableObservable.Connection<T> : IDisposable // TypeDefIndex: 6486
{
	// Fields
	private readonly Observable.ConnectableObservable<T> parent; // 0x0
	private IDisposable subscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Observable.ConnectableObservable<T> parent, IDisposable subscription) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250AED0 Offset: 0x250AFD1 VA: 0x250AED0
	|-Observable.ConnectableObservable.Connection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250AF20 Offset: 0x250B021 VA: 0x250AF20
	|-Observable.ConnectableObservable.Connection<object>.Dispose
	*/
}

// Namespace: 
private class Observable.EveryAfterUpdateInvoker : IEnumerator // TypeDefIndex: 6488
{
	// Fields
	private long count; // 0x10
	private readonly IObserver<long> observer; // 0x18
	private readonly CancellationToken cancellationToken; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1AFEBF0 Offset: 0x1AFECF1 VA: 0x1AFEBF0
	public void .ctor(IObserver<long> observer, CancellationToken cancellationToken) { }

	// RVA: 0x1B00D10 Offset: 0x1B00E11 VA: 0x1B00D10 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1B00E10 Offset: 0x1B00F11 VA: 0x1B00E10 Slot: 5
	public object get_Current() { }

	// RVA: 0x1B00E20 Offset: 0x1B00F21 VA: 0x1B00E20 Slot: 6
	public void Reset() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12960 Offset: 0x12A61 VA: 0x12960
private sealed class Observable.<>c__DisplayClass13_0<T> // TypeDefIndex: 6490
{
	// Fields
	public IDisposable subscription; // 0x0
	public AsyncSubject<T> subject; // 0x0
	public CancellationToken token; // 0x0
	public CancellationTokenRegistration ctr; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37F10 Offset: 0x2B38011 VA: 0x2B37F10
	|-Observable.<>c__DisplayClass13_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterCancelation>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37F20 Offset: 0x2B38021 VA: 0x2B37F20
	|-Observable.<>c__DisplayClass13_0<object>.<RegisterCancelation>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <RegisterCancelation>b__1(Exception _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38020 Offset: 0x2B38121 VA: 0x2B38020
	|-Observable.<>c__DisplayClass13_0<object>.<RegisterCancelation>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12980 Offset: 0x12A81 VA: 0x12980
private sealed class Observable.<RepeatInfinite>d__130<T> : IEnumerable<IObservable<T>>, IEnumerable, IEnumerator<IObservable<T>>, IEnumerator, IDisposable // TypeDefIndex: 6492
{
	// Fields
	private int <>1__state; // 0x0
	private IObservable<T> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IObservable<T> source; // 0x0
	public IObservable<T> <>3__source; // 0x0

	// Properties
	private IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15480 Offset: 0x15581 VA: 0x15480
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153360 Offset: 0x3153461 VA: 0x3153360
	|-Observable.<RepeatInfinite>d__130<object>..ctor
	|
	|-RVA: 0x3153540 Offset: 0x3153641 VA: 0x3153540
	|-Observable.<RepeatInfinite>d__130<Unit>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15490 Offset: 0x15591 VA: 0x15490
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31533A0 Offset: 0x31534A1 VA: 0x31533A0
	|-Observable.<RepeatInfinite>d__130<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x3153580 Offset: 0x3153681 VA: 0x3153580
	|-Observable.<RepeatInfinite>d__130<Unit>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31533B0 Offset: 0x31534B1 VA: 0x31533B0
	|-Observable.<RepeatInfinite>d__130<object>.MoveNext
	|
	|-RVA: 0x3153590 Offset: 0x3153691 VA: 0x3153590
	|-Observable.<RepeatInfinite>d__130<Unit>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x154A0 Offset: 0x155A1 VA: 0x154A0
	// RVA: -1 Offset: -1 Slot: 6
	private IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153410 Offset: 0x3153511 VA: 0x3153410
	|-Observable.<RepeatInfinite>d__130<object>.System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current
	|
	|-RVA: 0x31535F0 Offset: 0x31536F1 VA: 0x31535F0
	|-Observable.<RepeatInfinite>d__130<Unit>.System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x154B0 Offset: 0x155B1 VA: 0x154B0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153420 Offset: 0x3153521 VA: 0x3153420
	|-Observable.<RepeatInfinite>d__130<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3153600 Offset: 0x3153701 VA: 0x3153600
	|-Observable.<RepeatInfinite>d__130<Unit>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x154C0 Offset: 0x155C1 VA: 0x154C0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153460 Offset: 0x3153561 VA: 0x3153460
	|-Observable.<RepeatInfinite>d__130<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3153640 Offset: 0x3153741 VA: 0x3153640
	|-Observable.<RepeatInfinite>d__130<Unit>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x154D0 Offset: 0x155D1 VA: 0x154D0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153470 Offset: 0x3153571 VA: 0x3153470
	|-Observable.<RepeatInfinite>d__130<object>.System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator
	|
	|-RVA: 0x3153650 Offset: 0x3153751 VA: 0x3153650
	|-Observable.<RepeatInfinite>d__130<Unit>.System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x154E0 Offset: 0x155E1 VA: 0x154E0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153520 Offset: 0x3153621 VA: 0x3153520
	|-Observable.<RepeatInfinite>d__130<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3153700 Offset: 0x3153801 VA: 0x3153700
	|-Observable.<RepeatInfinite>d__130<Unit>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x129A0 Offset: 0x12AA1 VA: 0x129A0
private sealed class Observable.<>c__DisplayClass142_1<T> // TypeDefIndex: 6494
{
	// Fields
	public AsyncSubject<T> subject; // 0x0
	public Observable.<>c__DisplayClass142_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38220 Offset: 0x2B38321 VA: 0x2B38220
	|-Observable.<>c__DisplayClass142_1<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ToAsync>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38230 Offset: 0x2B38331 VA: 0x2B38230
	|-Observable.<>c__DisplayClass142_1<object>.<ToAsync>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x129C0 Offset: 0x12AC1 VA: 0x129C0
private sealed class Observable.<>c__DisplayClass144_1 // TypeDefIndex: 6496
{
	// Fields
	public AsyncSubject<Unit> subject; // 0x10
	public Observable.<>c__DisplayClass144_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1AFEEC0 Offset: 0x1AFEFC1 VA: 0x1AFEEC0
	public void .ctor() { }

	// RVA: 0x1AFEED0 Offset: 0x1AFEFD1 VA: 0x1AFEED0
	internal void <ToAsync>b__1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x129E0 Offset: 0x12AE1 VA: 0x129E0
private sealed class Observable.<>c__DisplayClass157_0<TSource, TException> // TypeDefIndex: 6498
{
	// Fields
	public TimeSpan delay; // 0x0
	public IObservable<TSource> source; // 0x0
	public Action<TException> onError; // 0x0
	public int retryCount; // 0x0
	public IScheduler delayScheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38450 Offset: 0x2B38551 VA: 0x2B38450
	|-Observable.<>c__DisplayClass157_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TSource> <OnErrorRetry>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38460 Offset: 0x2B38561 VA: 0x2B38460
	|-Observable.<>c__DisplayClass157_0<object, object>.<OnErrorRetry>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12A00 Offset: 0x12B01 VA: 0x12A00
private sealed class Observable.<>c__DisplayClass163_0<TResult> // TypeDefIndex: 6500
{
	// Fields
	public Func<AsyncCallback, object, IAsyncResult> begin; // 0x0
	public Func<IAsyncResult, TResult> end; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38A10 Offset: 0x2B38B11 VA: 0x2B38A10
	|-Observable.<>c__DisplayClass163_0<object>..ctor
	|
	|-RVA: 0x2B38C90 Offset: 0x2B38D91 VA: 0x2B38C90
	|-Observable.<>c__DisplayClass163_0<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TResult> <FromAsyncPattern>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38A20 Offset: 0x2B38B21 VA: 0x2B38A20
	|-Observable.<>c__DisplayClass163_0<object>.<FromAsyncPattern>b__0
	|
	|-RVA: 0x2B38CA0 Offset: 0x2B38DA1 VA: 0x2B38CA0
	|-Observable.<>c__DisplayClass163_0<Unit>.<FromAsyncPattern>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12A20 Offset: 0x12B21 VA: 0x12A20
private sealed class Observable.<>c__DisplayClass164_0<T1, TResult> // TypeDefIndex: 6502
{
	// Fields
	public Func<T1, AsyncCallback, object, IAsyncResult> begin; // 0x0
	public Func<IAsyncResult, TResult> end; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B39150 Offset: 0x2B39251 VA: 0x2B39150
	|-Observable.<>c__DisplayClass164_0<object, object>..ctor
	|
	|-RVA: 0x2B393E0 Offset: 0x2B394E1 VA: 0x2B393E0
	|-Observable.<>c__DisplayClass164_0<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TResult> <FromAsyncPattern>b__0(T1 x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B39160 Offset: 0x2B39261 VA: 0x2B39160
	|-Observable.<>c__DisplayClass164_0<object, object>.<FromAsyncPattern>b__0
	|
	|-RVA: 0x2B393F0 Offset: 0x2B394F1 VA: 0x2B393F0
	|-Observable.<>c__DisplayClass164_0<object, Unit>.<FromAsyncPattern>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12A40 Offset: 0x12B41 VA: 0x12A40
private sealed class Observable.<>c__DisplayClass165_0<T1, T2, TResult> // TypeDefIndex: 6504
{
	// Fields
	public Func<T1, T2, AsyncCallback, object, IAsyncResult> begin; // 0x0
	public Func<IAsyncResult, TResult> end; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B398B0 Offset: 0x2B399B1 VA: 0x2B398B0
	|-Observable.<>c__DisplayClass165_0<object, object, object>..ctor
	|
	|-RVA: 0x2B39B40 Offset: 0x2B39C41 VA: 0x2B39B40
	|-Observable.<>c__DisplayClass165_0<object, object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TResult> <FromAsyncPattern>b__0(T1 x, T2 y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B398C0 Offset: 0x2B399C1 VA: 0x2B398C0
	|-Observable.<>c__DisplayClass165_0<object, object, object>.<FromAsyncPattern>b__0
	|
	|-RVA: 0x2B39B50 Offset: 0x2B39C51 VA: 0x2B39B50
	|-Observable.<>c__DisplayClass165_0<object, object, Unit>.<FromAsyncPattern>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12A60 Offset: 0x12B61 VA: 0x12A60
private sealed class Observable.<>c__DisplayClass166_0 // TypeDefIndex: 6506
{
	// Fields
	public Action<IAsyncResult> end; // 0x10

	// Methods

	// RVA: 0x1AFF090 Offset: 0x1AFF191 VA: 0x1AFF090
	public void .ctor() { }

	// RVA: 0x1AFF0A0 Offset: 0x1AFF1A1 VA: 0x1AFF0A0
	internal Unit <FromAsyncPattern>b__0(IAsyncResult iar) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12A80 Offset: 0x12B81 VA: 0x12A80
private sealed class Observable.<>c__DisplayClass168_0<T1, T2> // TypeDefIndex: 6508
{
	// Fields
	public Action<IAsyncResult> end; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A120 Offset: 0x2B3A221 VA: 0x2B3A120
	|-Observable.<>c__DisplayClass168_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Unit <FromAsyncPattern>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A130 Offset: 0x2B3A231 VA: 0x2B3A130
	|-Observable.<>c__DisplayClass168_0<object, object>.<FromAsyncPattern>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12AA0 Offset: 0x12BA1 VA: 0x12AA0
private sealed class Observable.<>c__DisplayClass248_0<T, TR> // TypeDefIndex: 6510
{
	// Fields
	public IObservable<TR> other; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3ACB0 Offset: 0x2B3ADB1 VA: 0x2B3ACB0
	|-Observable.<>c__DisplayClass248_0<object, object>..ctor
	|
	|-RVA: 0x2B3ACD0 Offset: 0x2B3ADD1 VA: 0x2B3ACD0
	|-Observable.<>c__DisplayClass248_0<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TR> <SelectMany>b__0(T _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3ACC0 Offset: 0x2B3ADC1 VA: 0x2B3ACC0
	|-Observable.<>c__DisplayClass248_0<object, object>.<SelectMany>b__0
	|
	|-RVA: 0x2B3ACE0 Offset: 0x2B3ADE1 VA: 0x2B3ACE0
	|-Observable.<>c__DisplayClass248_0<object, Unit>.<SelectMany>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12AC0 Offset: 0x12BC1 VA: 0x12AC0
private sealed class Observable.<>c__DisplayClass288_0 // TypeDefIndex: 6512
{
	// Fields
	public Func<CancellationToken, IEnumerator> coroutine; // 0x10
	public bool publishEveryYield; // 0x18

	// Methods

	// RVA: 0x1AFF270 Offset: 0x1AFF371 VA: 0x1AFF270
	public void .ctor() { }

	// RVA: 0x1AFF280 Offset: 0x1AFF381 VA: 0x1AFF280
	internal IEnumerator <FromCoroutine>b__0(IObserver<Unit> observer, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12AE0 Offset: 0x12BE1 VA: 0x12AE0
private sealed class Observable.<>c__DisplayClass290_0 // TypeDefIndex: 6514
{
	// Fields
	public Func<CancellationToken, IEnumerator> coroutine; // 0x10
	public bool publishEveryYield; // 0x18

	// Methods

	// RVA: 0x1AFF410 Offset: 0x1AFF511 VA: 0x1AFF410
	public void .ctor() { }

	// RVA: 0x1AFF420 Offset: 0x1AFF521 VA: 0x1AFF420
	internal IEnumerator <FromMicroCoroutine>b__0(IObserver<Unit> observer, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12B00 Offset: 0x12C01 VA: 0x12B00
private sealed class Observable.<>c__DisplayClass292_0<T> // TypeDefIndex: 6516
{
	// Fields
	public Func<IEnumerator> coroutine; // 0x0
	public bool nullAsNextUpdate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AD30 Offset: 0x2B3AE31 VA: 0x2B3AD30
	|-Observable.<>c__DisplayClass292_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <FromCoroutineValue>b__0(IObserver<T> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AD40 Offset: 0x2B3AE41 VA: 0x2B3AD40
	|-Observable.<>c__DisplayClass292_0<object>.<FromCoroutineValue>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12B20 Offset: 0x12C21 VA: 0x12B20
private sealed class Observable.<WrapEnumeratorYieldValue>d__294<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6518
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public IEnumerator enumerator; // 0x0
	public IObserver<T> observer; // 0x0
	public bool nullAsNextUpdate; // 0x0
	public CancellationToken cancellationToken; // 0x0
	private bool <hasNext>5__2; // 0x0
	private object <current>5__3; // 0x0
	private bool <raisedError>5__4; // 0x0
	private ICustomYieldInstructionErrorHandler <customHandler>5__5; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15540 Offset: 0x15641 VA: 0x15540
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC23B0 Offset: 0x1FC24B1 VA: 0x1FC23B0
	|-Observable.<WrapEnumeratorYieldValue>d__294<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15550 Offset: 0x15651 VA: 0x15550
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC23E0 Offset: 0x1FC24E1 VA: 0x1FC23E0
	|-Observable.<WrapEnumeratorYieldValue>d__294<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC23F0 Offset: 0x1FC24F1 VA: 0x1FC23F0
	|-Observable.<WrapEnumeratorYieldValue>d__294<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15560 Offset: 0x15661 VA: 0x15560
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC2FD0 Offset: 0x1FC30D1 VA: 0x1FC2FD0
	|-Observable.<WrapEnumeratorYieldValue>d__294<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15570 Offset: 0x15671 VA: 0x15570
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC2FE0 Offset: 0x1FC30E1 VA: 0x1FC2FE0
	|-Observable.<WrapEnumeratorYieldValue>d__294<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15580 Offset: 0x15681 VA: 0x15580
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3020 Offset: 0x1FC3121 VA: 0x1FC3020
	|-Observable.<WrapEnumeratorYieldValue>d__294<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12B40 Offset: 0x12C41 VA: 0x12B40
private sealed class Observable.<>c__DisplayClass296_0<T> // TypeDefIndex: 6520
{
	// Fields
	public Func<IObserver<T>, IEnumerator> coroutine; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AFC0 Offset: 0x2B3B0C1 VA: 0x2B3AFC0
	|-Observable.<>c__DisplayClass296_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <FromMicroCoroutine>b__0(IObserver<T> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AFD0 Offset: 0x2B3B0D1 VA: 0x2B3AFD0
	|-Observable.<>c__DisplayClass296_0<object>.<FromMicroCoroutine>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12B60 Offset: 0x12C61 VA: 0x12B60
private sealed class Observable.<>c__DisplayClass300_0<T> // TypeDefIndex: 6522
{
	// Fields
	public IEnumerator coroutine; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3BF80 Offset: 0x2B3C081 VA: 0x2B3BF80
	|-Observable.<>c__DisplayClass300_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <SelectMany>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3BF90 Offset: 0x2B3C091 VA: 0x2B3BF90
	|-Observable.<>c__DisplayClass300_0<object>.<SelectMany>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12B80 Offset: 0x12C81 VA: 0x12B80
private sealed class Observable.<>c__DisplayClass302_0<T> // TypeDefIndex: 6524
{
	// Fields
	public Func<T, IEnumerator> selector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C010 Offset: 0x2B3C111 VA: 0x2B3C010
	|-Observable.<>c__DisplayClass302_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<Unit> <SelectMany>b__0(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C020 Offset: 0x2B3C121 VA: 0x2B3C020
	|-Observable.<>c__DisplayClass302_0<object>.<SelectMany>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12BA0 Offset: 0x12CA1 VA: 0x12BA0
private sealed class Observable.<>c__DisplayClass303_0 // TypeDefIndex: 6526
{
	// Fields
	public IEnumerator coroutine; // 0x10
	public bool publishEveryYield; // 0x18

	// Methods

	// RVA: 0x1AFF4E0 Offset: 0x1AFF5E1 VA: 0x1AFF4E0
	public void .ctor() { }

	// RVA: 0x1AFF4F0 Offset: 0x1AFF5F1 VA: 0x1AFF4F0
	internal IEnumerator <ToObservable>b__0(IObserver<Unit> observer, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12BC0 Offset: 0x12CC1 VA: 0x12BC0
private sealed class Observable.<EveryCycleCore>d__311 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6528
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CancellationToken cancellationToken; // 0x20
	public IObserver<long> observer; // 0x28
	private long <count>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x155E0 Offset: 0x156E1 VA: 0x155E0
	// RVA: 0x1AFF6D0 Offset: 0x1AFF7D1 VA: 0x1AFF6D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x155F0 Offset: 0x156F1 VA: 0x155F0
	// RVA: 0x1AFF700 Offset: 0x1AFF801 VA: 0x1AFF700 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AFF710 Offset: 0x1AFF811 VA: 0x1AFF710 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15600 Offset: 0x15701 VA: 0x15600
	// RVA: 0x1AFF840 Offset: 0x1AFF941 VA: 0x1AFF840 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15610 Offset: 0x15711 VA: 0x15610
	// RVA: 0x1AFF850 Offset: 0x1AFF951 VA: 0x1AFF850 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15620 Offset: 0x15721 VA: 0x15620
	// RVA: 0x1AFF890 Offset: 0x1AFF991 VA: 0x1AFF890 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12BE0 Offset: 0x12CE1 VA: 0x12BE0
private sealed class Observable.<>c__DisplayClass318_0 // TypeDefIndex: 6530
{
	// Fields
	public int dueTimeFrameCount; // 0x10

	// Methods

	// RVA: 0x1AFF590 Offset: 0x1AFF691 VA: 0x1AFF590
	public void .ctor() { }

	// RVA: 0x1AFF5A0 Offset: 0x1AFF6A1 VA: 0x1AFF5A0
	internal IEnumerator <TimerFrame>b__0(IObserver<long> observer, CancellationToken cancellation) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12C00 Offset: 0x12D01 VA: 0x12C00
private sealed class Observable.<TimerFrameCore>d__320 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6532
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int dueTimeFrameCount; // 0x20
	public IObserver<long> observer; // 0x28
	public CancellationToken cancel; // 0x30
	private int <currentFrame>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15680 Offset: 0x15781 VA: 0x15680
	// RVA: 0x1AFFB20 Offset: 0x1AFFC21 VA: 0x1AFFB20
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15690 Offset: 0x15791 VA: 0x15690
	// RVA: 0x1AFFB50 Offset: 0x1AFFC51 VA: 0x1AFFB50 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AFFB60 Offset: 0x1AFFC61 VA: 0x1AFFB60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x156A0 Offset: 0x157A1 VA: 0x156A0
	// RVA: 0x1AFFD10 Offset: 0x1AFFE11 VA: 0x1AFFD10 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x156B0 Offset: 0x157B1 VA: 0x156B0
	// RVA: 0x1AFFD20 Offset: 0x1AFFE21 VA: 0x1AFFD20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x156C0 Offset: 0x157C1 VA: 0x156C0
	// RVA: 0x1AFFD60 Offset: 0x1AFFE61 VA: 0x1AFFD60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12C20 Offset: 0x12D21 VA: 0x12C20
private sealed class Observable.<ToAwaitableEnumerator>d__336<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6534
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public IObservable<T> source; // 0x0
	public CancellationToken cancel; // 0x0
	public Action<T> onResult; // 0x0
	public Action<Exception> onError; // 0x0
	private ObservableYieldInstruction<T> <enumerator>5__2; // 0x0
	private IEnumerator<T> <e>5__3; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15720 Offset: 0x15821 VA: 0x15720
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD4E0 Offset: 0x1FBD5E1 VA: 0x1FBD4E0
	|-Observable.<ToAwaitableEnumerator>d__336<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15730 Offset: 0x15831 VA: 0x15730
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD510 Offset: 0x1FBD611 VA: 0x1FBD510
	|-Observable.<ToAwaitableEnumerator>d__336<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD520 Offset: 0x1FBD621 VA: 0x1FBD520
	|-Observable.<ToAwaitableEnumerator>d__336<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15740 Offset: 0x15841 VA: 0x15740
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD780 Offset: 0x1FBD881 VA: 0x1FBD780
	|-Observable.<ToAwaitableEnumerator>d__336<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15750 Offset: 0x15851 VA: 0x15750
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD790 Offset: 0x1FBD891 VA: 0x1FBD790
	|-Observable.<ToAwaitableEnumerator>d__336<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15760 Offset: 0x15861 VA: 0x15760
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD7D0 Offset: 0x1FBD8D1 VA: 0x1FBD7D0
	|-Observable.<ToAwaitableEnumerator>d__336<object>.System.Collections.IEnumerator.get_Current
	*/
}

