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
private class Observable.ConnectableObservable<T> : IConnectableObservable<T>, IObservable<T> // TypeDefIndex: 6487
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly ISubject<T> subject; // 0x0
	private readonly object gate; // 0x0
	private Observable.ConnectableObservable.Connection<T> connection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, ISubject<T> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250AB60 Offset: 0x250AC61 VA: 0x250AB60
	|-Observable.ConnectableObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Connect() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250AC60 Offset: 0x250AD61 VA: 0x250AC60
	|-Observable.ConnectableObservable<object>.Connect
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250AE30 Offset: 0x250AF31 VA: 0x250AE30
	|-Observable.ConnectableObservable<object>.Subscribe
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
[CompilerGeneratedAttribute] // RVA: 0x12950 Offset: 0x12A51 VA: 0x12950
private sealed class Observable.<>c__DisplayClass0_0<T> // TypeDefIndex: 6489
{
	// Fields
	public RefCountDisposable r; // 0x0
	public IObservable<T> xs; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37150 Offset: 0x2B37251 VA: 0x2B37150
	|-Observable.<>c__DisplayClass0_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IDisposable <AddRef>b__0(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37160 Offset: 0x2B37261 VA: 0x2B37160
	|-Observable.<>c__DisplayClass0_0<object>.<AddRef>b__0
	*/
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
[CompilerGeneratedAttribute] // RVA: 0x12970 Offset: 0x12A71 VA: 0x12970
private sealed class Observable.<CombineSources>d__29<T> : IEnumerable<IObservable<T>>, IEnumerable, IEnumerator<IObservable<T>>, IEnumerator, IDisposable // TypeDefIndex: 6491
{
	// Fields
	private int <>1__state; // 0x0
	private IObservable<T> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IObservable<T> first; // 0x0
	public IObservable<T> <>3__first; // 0x0
	private IObservable<T>[] seconds; // 0x0
	public IObservable<T>[] <>3__seconds; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15410 Offset: 0x15511 VA: 0x15410
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46710 Offset: 0x2B46811 VA: 0x2B46710
	|-Observable.<CombineSources>d__29<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15420 Offset: 0x15521 VA: 0x15420
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46750 Offset: 0x2B46851 VA: 0x2B46750
	|-Observable.<CombineSources>d__29<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46760 Offset: 0x2B46861 VA: 0x2B46760
	|-Observable.<CombineSources>d__29<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15430 Offset: 0x15531 VA: 0x15430
	// RVA: -1 Offset: -1 Slot: 6
	private IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46850 Offset: 0x2B46951 VA: 0x2B46850
	|-Observable.<CombineSources>d__29<object>.System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15440 Offset: 0x15541 VA: 0x15440
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46860 Offset: 0x2B46961 VA: 0x2B46860
	|-Observable.<CombineSources>d__29<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15450 Offset: 0x15551 VA: 0x15450
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B468A0 Offset: 0x2B469A1 VA: 0x2B468A0
	|-Observable.<CombineSources>d__29<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15460 Offset: 0x15561 VA: 0x15460
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B468B0 Offset: 0x2B469B1 VA: 0x2B468B0
	|-Observable.<CombineSources>d__29<object>.System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15470 Offset: 0x15571 VA: 0x15470
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46970 Offset: 0x2B46A71 VA: 0x2B46970
	|-Observable.<CombineSources>d__29<object>.System.Collections.IEnumerable.GetEnumerator
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
[CompilerGeneratedAttribute] // RVA: 0x12990 Offset: 0x12A91 VA: 0x12990
private sealed class Observable.<>c__DisplayClass142_0<T> // TypeDefIndex: 6493
{
	// Fields
	public IScheduler scheduler; // 0x0
	public Func<T> function; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38030 Offset: 0x2B38131 VA: 0x2B38030
	|-Observable.<>c__DisplayClass142_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<T> <ToAsync>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38040 Offset: 0x2B38141 VA: 0x2B38040
	|-Observable.<>c__DisplayClass142_0<object>.<ToAsync>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x129B0 Offset: 0x12AB1 VA: 0x129B0
private sealed class Observable.<>c__DisplayClass144_0 // TypeDefIndex: 6495
{
	// Fields
	public IScheduler scheduler; // 0x10
	public Action action; // 0x18

	// Methods

	// RVA: 0x1AFECD0 Offset: 0x1AFEDD1 VA: 0x1AFECD0
	public void .ctor() { }

	// RVA: 0x1AFECE0 Offset: 0x1AFEDE1 VA: 0x1AFECE0
	internal IObservable<Unit> <ToAsync>b__0() { }
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
[CompilerGeneratedAttribute] // RVA: 0x129D0 Offset: 0x12AD1 VA: 0x129D0
private sealed class Observable.<>c__DisplayClass149_0<TSource, TException> // TypeDefIndex: 6497
{
	// Fields
	public Action<TException> errorAction; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38340 Offset: 0x2B38441 VA: 0x2B38340
	|-Observable.<>c__DisplayClass149_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TSource> <CatchIgnore>b__0(TException ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38350 Offset: 0x2B38451 VA: 0x2B38350
	|-Observable.<>c__DisplayClass149_0<object, object>.<CatchIgnore>b__0
	*/
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
[CompilerGeneratedAttribute] // RVA: 0x129F0 Offset: 0x12AF1 VA: 0x129F0
private sealed class Observable.<>c__DisplayClass157_1<TSource, TException> // TypeDefIndex: 6499
{
	// Fields
	public int count; // 0x0
	public TimeSpan dueTime; // 0x0
	public IObservable<TSource> self; // 0x0
	public Observable.<>c__DisplayClass157_0<TSource, TException> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B385F0 Offset: 0x2B386F1 VA: 0x2B385F0
	|-Observable.<>c__DisplayClass157_1<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TSource> <OnErrorRetry>b__1(TException ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38600 Offset: 0x2B38701 VA: 0x2B38600
	|-Observable.<>c__DisplayClass157_1<object, object>.<OnErrorRetry>b__1
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
[CompilerGeneratedAttribute] // RVA: 0x12A10 Offset: 0x12B11 VA: 0x12A10
private sealed class Observable.<>c__DisplayClass163_1<TResult> // TypeDefIndex: 6501
{
	// Fields
	public AsyncSubject<TResult> subject; // 0x0
	public Observable.<>c__DisplayClass163_0<TResult> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38F10 Offset: 0x2B39011 VA: 0x2B38F10
	|-Observable.<>c__DisplayClass163_1<object>..ctor
	|
	|-RVA: 0x2B39030 Offset: 0x2B39131 VA: 0x2B39030
	|-Observable.<>c__DisplayClass163_1<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncPattern>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38F20 Offset: 0x2B39021 VA: 0x2B38F20
	|-Observable.<>c__DisplayClass163_1<object>.<FromAsyncPattern>b__1
	|
	|-RVA: 0x2B39040 Offset: 0x2B39141 VA: 0x2B39040
	|-Observable.<>c__DisplayClass163_1<Unit>.<FromAsyncPattern>b__1
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
[CompilerGeneratedAttribute] // RVA: 0x12A30 Offset: 0x12B31 VA: 0x12A30
private sealed class Observable.<>c__DisplayClass164_1<T1, TResult> // TypeDefIndex: 6503
{
	// Fields
	public AsyncSubject<TResult> subject; // 0x0
	public Observable.<>c__DisplayClass164_0<T1, TResult> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B39670 Offset: 0x2B39771 VA: 0x2B39670
	|-Observable.<>c__DisplayClass164_1<object, object>..ctor
	|
	|-RVA: 0x2B39790 Offset: 0x2B39891 VA: 0x2B39790
	|-Observable.<>c__DisplayClass164_1<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncPattern>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B39680 Offset: 0x2B39781 VA: 0x2B39680
	|-Observable.<>c__DisplayClass164_1<object, object>.<FromAsyncPattern>b__1
	|
	|-RVA: 0x2B397A0 Offset: 0x2B398A1 VA: 0x2B397A0
	|-Observable.<>c__DisplayClass164_1<object, Unit>.<FromAsyncPattern>b__1
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
[CompilerGeneratedAttribute] // RVA: 0x12A50 Offset: 0x12B51 VA: 0x12A50
private sealed class Observable.<>c__DisplayClass165_1<T1, T2, TResult> // TypeDefIndex: 6505
{
	// Fields
	public AsyncSubject<TResult> subject; // 0x0
	public Observable.<>c__DisplayClass165_0<T1, T2, TResult> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B39DD0 Offset: 0x2B39ED1 VA: 0x2B39DD0
	|-Observable.<>c__DisplayClass165_1<object, object, object>..ctor
	|
	|-RVA: 0x2B39EF0 Offset: 0x2B39FF1 VA: 0x2B39EF0
	|-Observable.<>c__DisplayClass165_1<object, object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncPattern>b__1(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B39DE0 Offset: 0x2B39EE1 VA: 0x2B39DE0
	|-Observable.<>c__DisplayClass165_1<object, object, object>.<FromAsyncPattern>b__1
	|
	|-RVA: 0x2B39F00 Offset: 0x2B3A001 VA: 0x2B39F00
	|-Observable.<>c__DisplayClass165_1<object, object, Unit>.<FromAsyncPattern>b__1
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
[CompilerGeneratedAttribute] // RVA: 0x12A70 Offset: 0x12B71 VA: 0x12A70
private sealed class Observable.<>c__DisplayClass167_0<T1> // TypeDefIndex: 6507
{
	// Fields
	public Action<IAsyncResult> end; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A010 Offset: 0x2B3A111 VA: 0x2B3A010
	|-Observable.<>c__DisplayClass167_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Unit <FromAsyncPattern>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A020 Offset: 0x2B3A121 VA: 0x2B3A020
	|-Observable.<>c__DisplayClass167_0<object>.<FromAsyncPattern>b__0
	*/
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
[CompilerGeneratedAttribute] // RVA: 0x12A90 Offset: 0x12B91 VA: 0x12A90
private sealed class Observable.<>c__DisplayClass246_0<T, TR> // TypeDefIndex: 6509
{
	// Fields
	public IObservable<TR> other; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AC90 Offset: 0x2B3AD91 VA: 0x2B3AC90
	|-Observable.<>c__DisplayClass246_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<TR> <ContinueWith>b__0(T _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3ACA0 Offset: 0x2B3ADA1 VA: 0x2B3ACA0
	|-Observable.<>c__DisplayClass246_0<object, object>.<ContinueWith>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x12AB0 Offset: 0x12BB1 VA: 0x12AB0
private sealed class Observable.<>c__DisplayClass287_0 // TypeDefIndex: 6511
{
	// Fields
	public Func<IEnumerator> coroutine; // 0x10
	public bool publishEveryYield; // 0x18

	// Methods

	// RVA: 0x1AFF1A0 Offset: 0x1AFF2A1 VA: 0x1AFF1A0
	public void .ctor() { }

	// RVA: 0x1AFF1B0 Offset: 0x1AFF2B1 VA: 0x1AFF1B0
	internal IEnumerator <FromCoroutine>b__0(IObserver<Unit> observer, CancellationToken cancellationToken) { }
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
[CompilerGeneratedAttribute] // RVA: 0x12AD0 Offset: 0x12BD1 VA: 0x12AD0
private sealed class Observable.<>c__DisplayClass289_0 // TypeDefIndex: 6513
{
	// Fields
	public Func<IEnumerator> coroutine; // 0x10
	public bool publishEveryYield; // 0x18

	// Methods

	// RVA: 0x1AFF340 Offset: 0x1AFF441 VA: 0x1AFF340
	public void .ctor() { }

	// RVA: 0x1AFF350 Offset: 0x1AFF451 VA: 0x1AFF350
	internal IEnumerator <FromMicroCoroutine>b__0(IObserver<Unit> observer, CancellationToken cancellationToken) { }
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
[CompilerGeneratedAttribute] // RVA: 0x12AF0 Offset: 0x12BF1 VA: 0x12AF0
private sealed class Observable.<WrapEnumerator>d__291 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6515
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public IEnumerator enumerator; // 0x20
	public IObserver<Unit> observer; // 0x28
	public bool publishEveryYield; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private bool <hasNext>5__2; // 0x40
	private bool <raisedError>5__3; // 0x41
	private ICustomYieldInstructionErrorHandler <customHandler>5__4; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x154F0 Offset: 0x155F1 VA: 0x154F0
	// RVA: 0x1B00080 Offset: 0x1B00181 VA: 0x1B00080
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15500 Offset: 0x15601 VA: 0x15500
	// RVA: 0x1B000B0 Offset: 0x1B001B1 VA: 0x1B000B0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B000C0 Offset: 0x1B001C1 VA: 0x1B000C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15510 Offset: 0x15611 VA: 0x15510
	// RVA: 0x1B00CB0 Offset: 0x1B00DB1 VA: 0x1B00CB0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15520 Offset: 0x15621 VA: 0x15520
	// RVA: 0x1B00CC0 Offset: 0x1B00DC1 VA: 0x1B00CC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15530 Offset: 0x15631 VA: 0x15530
	// RVA: 0x1B00D00 Offset: 0x1B00E01 VA: 0x1B00D00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
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
[CompilerGeneratedAttribute] // RVA: 0x12B10 Offset: 0x12C11 VA: 0x12B10
private sealed class Observable.<>c__DisplayClass293_0<T> // TypeDefIndex: 6517
{
	// Fields
	public Func<CancellationToken, IEnumerator> coroutine; // 0x0
	public bool nullAsNextUpdate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AE10 Offset: 0x2B3AF11 VA: 0x2B3AE10
	|-Observable.<>c__DisplayClass293_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <FromCoroutineValue>b__0(IObserver<T> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AE20 Offset: 0x2B3AF21 VA: 0x2B3AE20
	|-Observable.<>c__DisplayClass293_0<object>.<FromCoroutineValue>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x12B30 Offset: 0x12C31 VA: 0x12B30
private sealed class Observable.<>c__DisplayClass295_0<T> // TypeDefIndex: 6519
{
	// Fields
	public Func<IObserver<T>, IEnumerator> coroutine; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AEF0 Offset: 0x2B3AFF1 VA: 0x2B3AEF0
	|-Observable.<>c__DisplayClass295_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <FromCoroutine>b__0(IObserver<T> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AF00 Offset: 0x2B3B001 VA: 0x2B3AF00
	|-Observable.<>c__DisplayClass295_0<object>.<FromCoroutine>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x12B50 Offset: 0x12C51 VA: 0x12B50
private sealed class Observable.<WrapToCancellableEnumerator>d__297<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6521
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public IEnumerator enumerator; // 0x0
	public IObserver<T> observer; // 0x0
	public CancellationToken cancellationToken; // 0x0
	private bool <hasNext>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15590 Offset: 0x15691 VA: 0x15590
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3030 Offset: 0x1FC3131 VA: 0x1FC3030
	|-Observable.<WrapToCancellableEnumerator>d__297<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x155A0 Offset: 0x156A1 VA: 0x155A0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3060 Offset: 0x1FC3161 VA: 0x1FC3060
	|-Observable.<WrapToCancellableEnumerator>d__297<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3070 Offset: 0x1FC3171 VA: 0x1FC3070
	|-Observable.<WrapToCancellableEnumerator>d__297<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x155B0 Offset: 0x156B1 VA: 0x155B0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3470 Offset: 0x1FC3571 VA: 0x1FC3470
	|-Observable.<WrapToCancellableEnumerator>d__297<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x155C0 Offset: 0x156C1 VA: 0x155C0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3480 Offset: 0x1FC3581 VA: 0x1FC3480
	|-Observable.<WrapToCancellableEnumerator>d__297<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x155D0 Offset: 0x156D1 VA: 0x155D0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC34C0 Offset: 0x1FC35C1 VA: 0x1FC34C0
	|-Observable.<WrapToCancellableEnumerator>d__297<object>.System.Collections.IEnumerator.get_Current
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
[CompilerGeneratedAttribute] // RVA: 0x12B70 Offset: 0x12C71 VA: 0x12B70
private sealed class Observable.<>c__DisplayClass301_0<T> // TypeDefIndex: 6523
{
	// Fields
	public Func<IEnumerator> selector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3BFA0 Offset: 0x2B3C0A1 VA: 0x2B3BFA0
	|-Observable.<>c__DisplayClass301_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <SelectMany>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3BFB0 Offset: 0x2B3C0B1 VA: 0x2B3BFB0
	|-Observable.<>c__DisplayClass301_0<object>.<SelectMany>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x12B90 Offset: 0x12C91 VA: 0x12B90
private sealed class Observable.<>c__DisplayClass302_1<T> // TypeDefIndex: 6525
{
	// Fields
	public T x; // 0x0
	public Observable.<>c__DisplayClass302_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C150 Offset: 0x2B3C251 VA: 0x2B3C150
	|-Observable.<>c__DisplayClass302_1<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <SelectMany>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3C160 Offset: 0x2B3C261 VA: 0x2B3C160
	|-Observable.<>c__DisplayClass302_1<object>.<SelectMany>b__1
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
[CompilerGeneratedAttribute] // RVA: 0x12BB0 Offset: 0x12CB1 VA: 0x12BB0
[Serializable]
private sealed class Observable.<>c // TypeDefIndex: 6527
{
	// Fields
	public static readonly Observable.<>c <>9; // 0x0
	public static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__308_0; // 0x8
	public static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__309_0; // 0x10
	public static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__310_0; // 0x18
	public static Func<long, Unit, long> <>9__312_0; // 0x20
	public static Func<long, Unit, long> <>9__313_0; // 0x28
	public static Func<IObserver<long>, CancellationToken, IEnumerator> <>9__314_0; // 0x30
	public static Func<IObserver<Unit>, CancellationToken, IEnumerator> <>9__315_0; // 0x38

	// Methods

	// RVA: 0x1AFE940 Offset: 0x1AFEA41 VA: 0x1AFE940
	private static void .cctor() { }

	// RVA: 0x1AFE9B0 Offset: 0x1AFEAB1 VA: 0x1AFE9B0
	public void .ctor() { }

	// RVA: 0x1AFE9C0 Offset: 0x1AFEAC1 VA: 0x1AFE9C0
	internal IEnumerator <EveryUpdate>b__308_0(IObserver<long> observer, CancellationToken cancellationToken) { }

	// RVA: 0x1AFEA40 Offset: 0x1AFEB41 VA: 0x1AFEA40
	internal IEnumerator <EveryFixedUpdate>b__309_0(IObserver<long> observer, CancellationToken cancellationToken) { }

	// RVA: 0x1AFEAC0 Offset: 0x1AFEBC1 VA: 0x1AFEAC0
	internal IEnumerator <EveryEndOfFrame>b__310_0(IObserver<long> observer, CancellationToken cancellationToken) { }

	// RVA: 0x1AFEB40 Offset: 0x1AFEC41 VA: 0x1AFEB40
	internal long <EveryGameObjectUpdate>b__312_0(long x, Unit y) { }

	// RVA: 0x1AFEB50 Offset: 0x1AFEC51 VA: 0x1AFEB50
	internal long <EveryLateUpdate>b__313_0(long x, Unit y) { }

	// RVA: 0x1AFEB60 Offset: 0x1AFEC61 VA: 0x1AFEB60
	internal IEnumerator <EveryAfterUpdate>b__314_0(IObserver<long> observer, CancellationToken cancellationToken) { }

	// RVA: 0x1AFEC50 Offset: 0x1AFED51 VA: 0x1AFEC50
	internal IEnumerator <NextFrame>b__315_0(IObserver<Unit> observer, CancellationToken cancellation) { }
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
[CompilerGeneratedAttribute] // RVA: 0x12BD0 Offset: 0x12CD1 VA: 0x12BD0
private sealed class Observable.<NextFrameCore>d__316 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6529
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CancellationToken cancellation; // 0x20
	public IObserver<Unit> observer; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15630 Offset: 0x15731 VA: 0x15630
	// RVA: 0x1AFF8A0 Offset: 0x1AFF9A1 VA: 0x1AFF8A0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15640 Offset: 0x15741 VA: 0x15640
	// RVA: 0x1AFF8D0 Offset: 0x1AFF9D1 VA: 0x1AFF8D0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AFF8E0 Offset: 0x1AFF9E1 VA: 0x1AFF8E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15650 Offset: 0x15751 VA: 0x15650
	// RVA: 0x1AFFAC0 Offset: 0x1AFFBC1 VA: 0x1AFFAC0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15660 Offset: 0x15761 VA: 0x15660
	// RVA: 0x1AFFAD0 Offset: 0x1AFFBD1 VA: 0x1AFFAD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15670 Offset: 0x15771 VA: 0x15670
	// RVA: 0x1AFFB10 Offset: 0x1AFFC11 VA: 0x1AFFB10 Slot: 7
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
[CompilerGeneratedAttribute] // RVA: 0x12BF0 Offset: 0x12CF1 VA: 0x12BF0
private sealed class Observable.<>c__DisplayClass319_0 // TypeDefIndex: 6531
{
	// Fields
	public int dueTimeFrameCount; // 0x10
	public int periodFrameCount; // 0x14

	// Methods

	// RVA: 0x1AFF630 Offset: 0x1AFF731 VA: 0x1AFF630
	public void .ctor() { }

	// RVA: 0x1AFF640 Offset: 0x1AFF741 VA: 0x1AFF640
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
[CompilerGeneratedAttribute] // RVA: 0x12C10 Offset: 0x12D11 VA: 0x12C10
private sealed class Observable.<TimerFrameCore>d__321 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6533
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int dueTimeFrameCount; // 0x20
	public int periodFrameCount; // 0x24
	public IObserver<long> observer; // 0x28
	public CancellationToken cancel; // 0x30
	private long <sendCount>5__2; // 0x38
	private int <currentFrame>5__3; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x156D0 Offset: 0x157D1 VA: 0x156D0
	// RVA: 0x1AFFD70 Offset: 0x1AFFE71 VA: 0x1AFFD70
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x156E0 Offset: 0x157E1 VA: 0x156E0
	// RVA: 0x1AFFDA0 Offset: 0x1AFFEA1 VA: 0x1AFFDA0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AFFDB0 Offset: 0x1AFFEB1 VA: 0x1AFFDB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x156F0 Offset: 0x157F1 VA: 0x156F0
	// RVA: 0x1B00020 Offset: 0x1B00121 VA: 0x1B00020 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15700 Offset: 0x15801 VA: 0x15700
	// RVA: 0x1B00030 Offset: 0x1B00131 VA: 0x1B00030 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15710 Offset: 0x15811 VA: 0x15710
	// RVA: 0x1B00070 Offset: 0x1B00171 VA: 0x1B00070 Slot: 7
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12C30 Offset: 0x12D31 VA: 0x12C30
[Serializable]
private sealed class Observable.<>c__342<T> // TypeDefIndex: 6535
{
	// Fields
	public static readonly Observable.<>c__342<T> <>9; // 0x0
	public static Func<T, IObservable<long>> <>9__342_0; // 0x0
	public static Func<T, long, T> <>9__342_1; // 0x0
	public static Func<T, IObservable<long>> <>9__342_2; // 0x0
	public static Func<T, long, T> <>9__342_3; // 0x0
	public static Func<T, IObservable<Unit>> <>9__342_4; // 0x0
	public static Func<T, Unit, T> <>9__342_5; // 0x0
	public static Func<T, IObservable<Unit>> <>9__342_6; // 0x0
	public static Func<T, Unit, T> <>9__342_7; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36220 Offset: 0x2B36321 VA: 0x2B36220
	|-Observable.<>c__342<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36300 Offset: 0x2B36401 VA: 0x2B36300
	|-Observable.<>c__342<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IObservable<long> <ObserveOnMainThread>b__342_0(T _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36310 Offset: 0x2B36411 VA: 0x2B36310
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_0
	*/

	// RVA: -1 Offset: -1
	internal T <ObserveOnMainThread>b__342_1(T x, long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36390 Offset: 0x2B36491 VA: 0x2B36390
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_1
	*/

	// RVA: -1 Offset: -1
	internal IObservable<long> <ObserveOnMainThread>b__342_2(T _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B363A0 Offset: 0x2B364A1 VA: 0x2B363A0
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_2
	*/

	// RVA: -1 Offset: -1
	internal T <ObserveOnMainThread>b__342_3(T x, long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36420 Offset: 0x2B36521 VA: 0x2B36420
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_3
	*/

	// RVA: -1 Offset: -1
	internal IObservable<Unit> <ObserveOnMainThread>b__342_4(T _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36430 Offset: 0x2B36531 VA: 0x2B36430
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_4
	*/

	// RVA: -1 Offset: -1
	internal T <ObserveOnMainThread>b__342_5(T x, Unit _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B364F0 Offset: 0x2B365F1 VA: 0x2B364F0
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_5
	*/

	// RVA: -1 Offset: -1
	internal IObservable<Unit> <ObserveOnMainThread>b__342_6(T _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36500 Offset: 0x2B36601 VA: 0x2B36500
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_6
	*/

	// RVA: -1 Offset: -1
	internal T <ObserveOnMainThread>b__342_7(T x, Unit _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B365C0 Offset: 0x2B366C1 VA: 0x2B365C0
	|-Observable.<>c__342<object>.<ObserveOnMainThread>b__342_7
	*/
}

