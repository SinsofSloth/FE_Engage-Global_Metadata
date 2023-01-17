// Namespace: 
private class ZipObservable.Zip.RightZipObserver<TLeft, TRight, TResult> : IObserver<TRight> // TypeDefIndex: 7152
{
	// Fields
	private readonly ZipObservable.Zip<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable.Zip<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC450 Offset: 0x2FFC551 VA: 0x2FFC450
	|-ZipObservable.Zip.RightZipObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TRight value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC490 Offset: 0x2FFC591 VA: 0x2FFC490
	|-ZipObservable.Zip.RightZipObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC5A0 Offset: 0x2FFC6A1 VA: 0x2FFC5A0
	|-ZipObservable.Zip.RightZipObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC690 Offset: 0x2FFC791 VA: 0x2FFC690
	|-ZipObservable.Zip.RightZipObserver<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipObservable.Zip<T> : OperatorObserverBase<IList<T>, IList<T>> // TypeDefIndex: 7156
{
	// Fields
	private readonly ZipObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private Queue<T>[] queues; // 0x0
	private bool[] isDone; // 0x0
	private int length; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE5E0 Offset: 0x39DE6E1 VA: 0x39DE5E0
	|-ZipObservable.Zip<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DE6A0 Offset: 0x39DE7A1 VA: 0x39DE6A0
	|-ZipObservable.Zip<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void Dequeue(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DEA20 Offset: 0x39DEB21 VA: 0x39DEA20
	|-ZipObservable.Zip<object>.Dequeue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DECC0 Offset: 0x39DEDC1 VA: 0x39DECC0
	|-ZipObservable.Zip<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DED70 Offset: 0x39DEE71 VA: 0x39DED70
	|-ZipObservable.Zip<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DEEB0 Offset: 0x39DEFB1 VA: 0x39DEEB0
	|-ZipObservable.Zip<object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x183F0 Offset: 0x184F1 VA: 0x183F0
	// RVA: -1 Offset: -1
	private void <Run>b__6_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DEFE0 Offset: 0x39DF0E1 VA: 0x39DEFE0
	|-ZipObservable.Zip<object>.<Run>b__6_0
	*/
}

// Namespace: 
private class ZipObservable.Zip<T1, T2, T3, TR> : NthZipObserverBase<TR> // TypeDefIndex: 7158
{
	// Fields
	private readonly ZipObservable<T1, T2, T3, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly Queue<T1> q1; // 0x0
	private readonly Queue<T2> q2; // 0x0
	private readonly Queue<T3> q3; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable<T1, T2, T3, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DFC50 Offset: 0x39DFD51 VA: 0x39DFC50
	|-ZipObservable.Zip<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DFDF0 Offset: 0x39DFEF1 VA: 0x39DFDF0
	|-ZipObservable.Zip<object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E0240 Offset: 0x39E0341 VA: 0x39E0240
	|-ZipObservable.Zip<object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E02F0 Offset: 0x39E03F1 VA: 0x39E02F0
	|-ZipObservable.Zip<object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E03A0 Offset: 0x39E04A1 VA: 0x39E03A0
	|-ZipObservable.Zip<object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E04E0 Offset: 0x39E05E1 VA: 0x39E04E0
	|-ZipObservable.Zip<object, object, object, object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18400 Offset: 0x18501 VA: 0x18400
	// RVA: -1 Offset: -1
	private void <Run>b__6_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E0610 Offset: 0x39E0711 VA: 0x39E0610
	|-ZipObservable.Zip<object, object, object, object>.<Run>b__6_0
	*/
}

// Namespace: 
private class ZipObservable.Zip<T1, T2, T3, T4, TR> : NthZipObserverBase<TR> // TypeDefIndex: 7160
{
	// Fields
	private readonly ZipObservable<T1, T2, T3, T4, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly Queue<T1> q1; // 0x0
	private readonly Queue<T2> q2; // 0x0
	private readonly Queue<T3> q3; // 0x0
	private readonly Queue<T4> q4; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable<T1, T2, T3, T4, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E0730 Offset: 0x39E0831 VA: 0x39E0730
	|-ZipObservable.Zip<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E0920 Offset: 0x39E0A21 VA: 0x39E0920
	|-ZipObservable.Zip<object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E0FA0 Offset: 0x39E10A1 VA: 0x39E0FA0
	|-ZipObservable.Zip<object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1070 Offset: 0x39E1171 VA: 0x39E1070
	|-ZipObservable.Zip<object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1120 Offset: 0x39E1221 VA: 0x39E1120
	|-ZipObservable.Zip<object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1260 Offset: 0x39E1361 VA: 0x39E1260
	|-ZipObservable.Zip<object, object, object, object, object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18410 Offset: 0x18511 VA: 0x18410
	// RVA: -1 Offset: -1
	private void <Run>b__7_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1390 Offset: 0x39E1491 VA: 0x39E1390
	|-ZipObservable.Zip<object, object, object, object, object>.<Run>b__7_0
	*/
}

// Namespace: 
private class ZipObservable.Zip<T1, T2, T3, T4, T5, TR> : NthZipObserverBase<TR> // TypeDefIndex: 7162
{
	// Fields
	private readonly ZipObservable<T1, T2, T3, T4, T5, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly Queue<T1> q1; // 0x0
	private readonly Queue<T2> q2; // 0x0
	private readonly Queue<T3> q3; // 0x0
	private readonly Queue<T4> q4; // 0x0
	private readonly Queue<T5> q5; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable<T1, T2, T3, T4, T5, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E14D0 Offset: 0x39E15D1 VA: 0x39E14D0
	|-ZipObservable.Zip<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1710 Offset: 0x39E1811 VA: 0x39E1710
	|-ZipObservable.Zip<object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1ED0 Offset: 0x39E1FD1 VA: 0x39E1ED0
	|-ZipObservable.Zip<object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E1FC0 Offset: 0x39E20C1 VA: 0x39E1FC0
	|-ZipObservable.Zip<object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E2070 Offset: 0x39E2171 VA: 0x39E2070
	|-ZipObservable.Zip<object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E21B0 Offset: 0x39E22B1 VA: 0x39E21B0
	|-ZipObservable.Zip<object, object, object, object, object, object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18420 Offset: 0x18521 VA: 0x18420
	// RVA: -1 Offset: -1
	private void <Run>b__8_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E22E0 Offset: 0x39E23E1 VA: 0x39E22E0
	|-ZipObservable.Zip<object, object, object, object, object, object>.<Run>b__8_0
	*/
}

// Namespace: 
private class ZipObservable.Zip<T1, T2, T3, T4, T5, T6, TR> : NthZipObserverBase<TR> // TypeDefIndex: 7164
{
	// Fields
	private readonly ZipObservable<T1, T2, T3, T4, T5, T6, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly Queue<T1> q1; // 0x0
	private readonly Queue<T2> q2; // 0x0
	private readonly Queue<T3> q3; // 0x0
	private readonly Queue<T4> q4; // 0x0
	private readonly Queue<T5> q5; // 0x0
	private readonly Queue<T6> q6; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable<T1, T2, T3, T4, T5, T6, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EED540 Offset: 0x3EED641 VA: 0x3EED540
	|-ZipObservable.Zip<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EED7D0 Offset: 0x3EED8D1 VA: 0x3EED7D0
	|-ZipObservable.Zip<object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE0E0 Offset: 0x3EEE1E1 VA: 0x3EEE0E0
	|-ZipObservable.Zip<object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE1F0 Offset: 0x3EEE2F1 VA: 0x3EEE1F0
	|-ZipObservable.Zip<object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE2A0 Offset: 0x3EEE3A1 VA: 0x3EEE2A0
	|-ZipObservable.Zip<object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE3E0 Offset: 0x3EEE4E1 VA: 0x3EEE3E0
	|-ZipObservable.Zip<object, object, object, object, object, object, object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18430 Offset: 0x18531 VA: 0x18430
	// RVA: -1 Offset: -1
	private void <Run>b__9_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE510 Offset: 0x3EEE611 VA: 0x3EEE510
	|-ZipObservable.Zip<object, object, object, object, object, object, object>.<Run>b__9_0
	*/
}

// Namespace: 
private class ZipObservable.Zip<T1, T2, T3, T4, T5, T6, T7, TR> : NthZipObserverBase<TR> // TypeDefIndex: 7166
{
	// Fields
	private readonly ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly Queue<T1> q1; // 0x0
	private readonly Queue<T2> q2; // 0x0
	private readonly Queue<T3> q3; // 0x0
	private readonly Queue<T4> q4; // 0x0
	private readonly Queue<T5> q5; // 0x0
	private readonly Queue<T6> q6; // 0x0
	private readonly Queue<T7> q7; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE680 Offset: 0x3EEE781 VA: 0x3EEE680
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEE950 Offset: 0x3EEEA51 VA: 0x3EEE950
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEF3A0 Offset: 0x3EEF4A1 VA: 0x3EEF3A0
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEF4F0 Offset: 0x3EEF5F1 VA: 0x3EEF4F0
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEF5A0 Offset: 0x3EEF6A1 VA: 0x3EEF5A0
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEF6E0 Offset: 0x3EEF7E1 VA: 0x3EEF6E0
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>.OnCompleted
	*/

	[CompilerGeneratedAttribute] // RVA: 0x18440 Offset: 0x18541 VA: 0x18440
	// RVA: -1 Offset: -1
	private void <Run>b__10_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EEF810 Offset: 0x3EEF911 VA: 0x3EEF810
	|-ZipObservable.Zip<object, object, object, object, object, object, object, object>.<Run>b__10_0
	*/
}

