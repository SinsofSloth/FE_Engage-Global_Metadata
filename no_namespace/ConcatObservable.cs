// Namespace: 
private class ConcatObservable.Concat<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6913
{
	// Fields
	private readonly ConcatObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool isDisposed; // 0x0
	private IEnumerator<IObservable<T>> e; // 0x0
	private SerialDisposable subscription; // 0x0
	private Action nextSelf; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ConcatObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502150 Offset: 0x2502251 VA: 0x2502150
	|-ConcatObservable.Concat<object>..ctor
	|
	|-RVA: 0x2502F00 Offset: 0x2503001 VA: 0x2502F00
	|-ConcatObservable.Concat<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502210 Offset: 0x2502311 VA: 0x2502210
	|-ConcatObservable.Concat<object>.Run
	|
	|-RVA: 0x2502FC0 Offset: 0x25030C1 VA: 0x2502FC0
	|-ConcatObservable.Concat<Unit>.Run
	*/

	// RVA: -1 Offset: -1
	private void RecursiveRun(Action self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502450 Offset: 0x2502551 VA: 0x2502450
	|-ConcatObservable.Concat<object>.RecursiveRun
	|
	|-RVA: 0x2503200 Offset: 0x2503301 VA: 0x2503200
	|-ConcatObservable.Concat<Unit>.RecursiveRun
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502BA0 Offset: 0x2502CA1 VA: 0x2502BA0
	|-ConcatObservable.Concat<object>.OnNext
	|
	|-RVA: 0x2503950 Offset: 0x2503A51 VA: 0x2503950
	|-ConcatObservable.Concat<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502C50 Offset: 0x2502D51 VA: 0x2502C50
	|-ConcatObservable.Concat<object>.OnError
	|
	|-RVA: 0x2503A00 Offset: 0x2503B01 VA: 0x2503A00
	|-ConcatObservable.Concat<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502D90 Offset: 0x2502E91 VA: 0x2502D90
	|-ConcatObservable.Concat<object>.OnCompleted
	|
	|-RVA: 0x2503B40 Offset: 0x2503C41 VA: 0x2503B40
	|-ConcatObservable.Concat<Unit>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18320 Offset: 0x18421 VA: 0x18320
	// RVA: -1 Offset: -1
	private void <Run>b__7_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502DA0 Offset: 0x2502EA1 VA: 0x2502DA0
	|-ConcatObservable.Concat<object>.<Run>b__7_0
	|
	|-RVA: 0x2503B50 Offset: 0x2503C51 VA: 0x2503B50
	|-ConcatObservable.Concat<Unit>.<Run>b__7_0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13960 Offset: 0x13A61 VA: 0x13960
private sealed class ConcatObservable.<CombineSources>d__3<T> : IEnumerable<IObservable<T>>, IEnumerable, IEnumerator<IObservable<T>>, IEnumerator, IDisposable // TypeDefIndex: 6914
{
	// Fields
	private int <>1__state; // 0x0
	private IObservable<T> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<IObservable<T>> first; // 0x0
	public IEnumerable<IObservable<T>> <>3__first; // 0x0
	private IEnumerable<IObservable<T>> second; // 0x0
	public IEnumerable<IObservable<T>> <>3__second; // 0x0
	private IEnumerator<IObservable<T>> <>7__wrap1; // 0x0

	// Properties
	private IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x18330 Offset: 0x18431 VA: 0x18330
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46990 Offset: 0x2B46A91 VA: 0x2B46990
	|-ConcatObservable.<CombineSources>d__3<object>..ctor
	|
	|-RVA: 0x2B471B0 Offset: 0x2B472B1 VA: 0x2B471B0
	|-ConcatObservable.<CombineSources>d__3<Unit>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18340 Offset: 0x18441 VA: 0x18340
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B469D0 Offset: 0x2B46AD1 VA: 0x2B469D0
	|-ConcatObservable.<CombineSources>d__3<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B471F0 Offset: 0x2B472F1 VA: 0x2B471F0
	|-ConcatObservable.<CombineSources>d__3<Unit>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46AA0 Offset: 0x2B46BA1 VA: 0x2B46AA0
	|-ConcatObservable.<CombineSources>d__3<object>.MoveNext
	|
	|-RVA: 0x2B472C0 Offset: 0x2B473C1 VA: 0x2B472C0
	|-ConcatObservable.<CombineSources>d__3<Unit>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46EF0 Offset: 0x2B46FF1 VA: 0x2B46EF0
	|-ConcatObservable.<CombineSources>d__3<object>.<>m__Finally1
	|
	|-RVA: 0x2B47710 Offset: 0x2B47811 VA: 0x2B47710
	|-ConcatObservable.<CombineSources>d__3<Unit>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46FB0 Offset: 0x2B470B1 VA: 0x2B46FB0
	|-ConcatObservable.<CombineSources>d__3<object>.<>m__Finally2
	|
	|-RVA: 0x2B477D0 Offset: 0x2B478D1 VA: 0x2B477D0
	|-ConcatObservable.<CombineSources>d__3<Unit>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18350 Offset: 0x18451 VA: 0x18350
	// RVA: -1 Offset: -1 Slot: 6
	private IObservable<T> System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47070 Offset: 0x2B47171 VA: 0x2B47070
	|-ConcatObservable.<CombineSources>d__3<object>.System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current
	|
	|-RVA: 0x2B47890 Offset: 0x2B47991 VA: 0x2B47890
	|-ConcatObservable.<CombineSources>d__3<Unit>.System.Collections.Generic.IEnumerator<System.IObservable<T>>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18360 Offset: 0x18461 VA: 0x18360
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47080 Offset: 0x2B47181 VA: 0x2B47080
	|-ConcatObservable.<CombineSources>d__3<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B478A0 Offset: 0x2B479A1 VA: 0x2B478A0
	|-ConcatObservable.<CombineSources>d__3<Unit>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18370 Offset: 0x18471 VA: 0x18370
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B470C0 Offset: 0x2B471C1 VA: 0x2B470C0
	|-ConcatObservable.<CombineSources>d__3<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B478E0 Offset: 0x2B479E1 VA: 0x2B478E0
	|-ConcatObservable.<CombineSources>d__3<Unit>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18380 Offset: 0x18481 VA: 0x18380
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<IObservable<T>> System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B470D0 Offset: 0x2B471D1 VA: 0x2B470D0
	|-ConcatObservable.<CombineSources>d__3<object>.System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator
	|
	|-RVA: 0x2B478F0 Offset: 0x2B479F1 VA: 0x2B478F0
	|-ConcatObservable.<CombineSources>d__3<Unit>.System.Collections.Generic.IEnumerable<System.IObservable<T>>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x18390 Offset: 0x18491 VA: 0x18390
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47190 Offset: 0x2B47291 VA: 0x2B47190
	|-ConcatObservable.<CombineSources>d__3<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B479B0 Offset: 0x2B47AB1 VA: 0x2B479B0
	|-ConcatObservable.<CombineSources>d__3<Unit>.System.Collections.IEnumerable.GetEnumerator
	*/
}

