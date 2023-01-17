// Namespace: 
private class BufferObservable.Buffer<T> : OperatorObserverBase<T, IList<T>> // TypeDefIndex: 6870
{
	// Fields
	private readonly BufferObservable<T> parent; // 0x0
	private List<T> list; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC8A0 Offset: 0x30BC9A1 VA: 0x30BC8A0
	|-BufferObservable.Buffer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC8F0 Offset: 0x30BC9F1 VA: 0x30BC8F0
	|-BufferObservable.Buffer<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BC9F0 Offset: 0x30BCAF1 VA: 0x30BC9F0
	|-BufferObservable.Buffer<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BCB50 Offset: 0x30BCC51 VA: 0x30BCB50
	|-BufferObservable.Buffer<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BCC90 Offset: 0x30BCD91 VA: 0x30BCC90
	|-BufferObservable.Buffer<object>.OnCompleted
	*/
}

// Namespace: 
private class BufferObservable.Buffer_<T> : OperatorObserverBase<T, IList<T>> // TypeDefIndex: 6871
{
	// Fields
	private readonly BufferObservable<T> parent; // 0x0
	private Queue<List<T>> q; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C0770 Offset: 0x30C0871 VA: 0x30C0770
	|-BufferObservable.Buffer_<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C07C0 Offset: 0x30C08C1 VA: 0x30C07C0
	|-BufferObservable.Buffer_<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C08C0 Offset: 0x30C09C1 VA: 0x30C08C0
	|-BufferObservable.Buffer_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C0AB0 Offset: 0x30C0BB1 VA: 0x30C0AB0
	|-BufferObservable.Buffer_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C0BF0 Offset: 0x30C0CF1 VA: 0x30C0BF0
	|-BufferObservable.Buffer_<object>.OnCompleted
	*/
}

// Namespace: 
private class BufferObservable.BufferT.Buffer<T> : IObserver<long> // TypeDefIndex: 6872
{
	// Fields
	private BufferObservable.BufferT<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable.BufferT<T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BCE60 Offset: 0x30BCF61 VA: 0x30BCE60
	|-BufferObservable.BufferT.Buffer<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BCEA0 Offset: 0x30BCFA1 VA: 0x30BCEA0
	|-BufferObservable.BufferT.Buffer<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD140 Offset: 0x30BD241 VA: 0x30BD140
	|-BufferObservable.BufferT.Buffer<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD150 Offset: 0x30BD251 VA: 0x30BD150
	|-BufferObservable.BufferT.Buffer<object>.OnCompleted
	*/
}

// Namespace: 
private class BufferObservable.BufferT<T> : OperatorObserverBase<T, IList<T>> // TypeDefIndex: 6873
{
	// Fields
	private static readonly T[] EmptyArray; // 0x0
	private readonly BufferObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private List<T> list; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE010 Offset: 0x30BE111 VA: 0x30BE010
	|-BufferObservable.BufferT<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE0D0 Offset: 0x30BE1D1 VA: 0x30BE0D0
	|-BufferObservable.BufferT<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE2F0 Offset: 0x30BE3F1 VA: 0x30BE2F0
	|-BufferObservable.BufferT<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE3E0 Offset: 0x30BE4E1 VA: 0x30BE3E0
	|-BufferObservable.BufferT<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE520 Offset: 0x30BE621 VA: 0x30BE520
	|-BufferObservable.BufferT<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE780 Offset: 0x30BE881 VA: 0x30BE780
	|-BufferObservable.BufferT<object>..cctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13940 Offset: 0x13A41 VA: 0x13940
private sealed class BufferObservable.BufferTS.<>c__DisplayClass9_0<T> // TypeDefIndex: 6874
{
	// Fields
	public BufferObservable.BufferTS<T> <>4__this; // 0x0
	public bool isShift; // 0x0
	public bool isSpan; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B423D0 Offset: 0x2B424D1 VA: 0x2B423D0
	|-BufferObservable.BufferTS.<>c__DisplayClass9_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateTimer>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B423E0 Offset: 0x2B424E1 VA: 0x2B423E0
	|-BufferObservable.BufferTS.<>c__DisplayClass9_0<object>.<CreateTimer>b__0
	*/
}

// Namespace: 
private class BufferObservable.BufferTS<T> : OperatorObserverBase<T, IList<T>> // TypeDefIndex: 6875
{
	// Fields
	private readonly BufferObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private Queue<IList<T>> q; // 0x0
	private TimeSpan totalTime; // 0x0
	private TimeSpan nextShift; // 0x0
	private TimeSpan nextSpan; // 0x0
	private SerialDisposable timerD; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BF8F0 Offset: 0x30BF9F1 VA: 0x30BF8F0
	|-BufferObservable.BufferTS<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BF9B0 Offset: 0x30BFAB1 VA: 0x30BF9B0
	|-BufferObservable.BufferTS<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void CreateTimer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BFBD0 Offset: 0x30BFCD1 VA: 0x30BFBD0
	|-BufferObservable.BufferTS<object>.CreateTimer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BFEE0 Offset: 0x30BFFE1 VA: 0x30BFEE0
	|-BufferObservable.BufferTS<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C01F0 Offset: 0x30C02F1 VA: 0x30C01F0
	|-BufferObservable.BufferTS<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C0330 Offset: 0x30C0431 VA: 0x30C0330
	|-BufferObservable.BufferTS<object>.OnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13950 Offset: 0x13A51 VA: 0x13950
private sealed class BufferObservable.BufferTC.<>c__DisplayClass8_0<T> // TypeDefIndex: 6876
{
	// Fields
	public BufferObservable.BufferTC<T> <>4__this; // 0x0
	public long currentTimerId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41D80 Offset: 0x2B41E81 VA: 0x2B41D80
	|-BufferObservable.BufferTC.<>c__DisplayClass8_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateTimer>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41D90 Offset: 0x2B41E91 VA: 0x2B41D90
	|-BufferObservable.BufferTC.<>c__DisplayClass8_0<object>.<CreateTimer>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <CreateTimer>b__1(Action<TimeSpan> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41DB0 Offset: 0x2B41EB1 VA: 0x2B41DB0
	|-BufferObservable.BufferTC.<>c__DisplayClass8_0<object>.<CreateTimer>b__1
	*/
}

// Namespace: 
private class BufferObservable.BufferTC<T> : OperatorObserverBase<T, IList<T>> // TypeDefIndex: 6877
{
	// Fields
	private static readonly T[] EmptyArray; // 0x0
	private readonly BufferObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private List<T> list; // 0x0
	private long timerId; // 0x0
	private SerialDisposable timerD; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE810 Offset: 0x30BE911 VA: 0x30BE810
	|-BufferObservable.BufferTC<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BE8D0 Offset: 0x30BE9D1 VA: 0x30BE8D0
	|-BufferObservable.BufferTC<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void CreateTimer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BEA40 Offset: 0x30BEB41 VA: 0x30BEA40
	|-BufferObservable.BufferTC<object>.CreateTimer
	*/

	// RVA: -1 Offset: -1
	private void OnNextTick(long currentTimerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BEC90 Offset: 0x30BED91 VA: 0x30BEC90
	|-BufferObservable.BufferTC<object>.OnNextTick
	*/

	// RVA: -1 Offset: -1
	private void OnNextRecursive(long currentTimerId, Action<TimeSpan> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BEF60 Offset: 0x30BF061 VA: 0x30BEF60
	|-BufferObservable.BufferTC<object>.OnNextRecursive
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BF270 Offset: 0x30BF371 VA: 0x30BF270
	|-BufferObservable.BufferTC<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BF4B0 Offset: 0x30BF5B1 VA: 0x30BF4B0
	|-BufferObservable.BufferTC<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BF5F0 Offset: 0x30BF6F1 VA: 0x30BF5F0
	|-BufferObservable.BufferTC<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BF860 Offset: 0x30BF961 VA: 0x30BF860
	|-BufferObservable.BufferTC<object>..cctor
	*/
}

// Namespace: 
private class BufferObservable.Buffer.Buffer_<TSource, TWindowBoundary> : IObserver<TWindowBoundary> // TypeDefIndex: 6879
{
	// Fields
	private readonly BufferObservable.Buffer<TSource, TWindowBoundary> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable.Buffer<TSource, TWindowBoundary> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C0F50 Offset: 0x30C1051 VA: 0x30C0F50
	|-BufferObservable.Buffer.Buffer_<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TWindowBoundary value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C0F90 Offset: 0x30C1091 VA: 0x30C0F90
	|-BufferObservable.Buffer.Buffer_<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C12A0 Offset: 0x30C13A1 VA: 0x30C12A0
	|-BufferObservable.Buffer.Buffer_<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C12B0 Offset: 0x30C13B1 VA: 0x30C12B0
	|-BufferObservable.Buffer.Buffer_<object, object>.OnCompleted
	*/
}

// Namespace: 
private class BufferObservable.Buffer<TSource, TWindowBoundary> : OperatorObserverBase<TSource, IList<TSource>> // TypeDefIndex: 6880
{
	// Fields
	private static readonly TSource[] EmptyArray; // 0x0
	private readonly BufferObservable<TSource, TWindowBoundary> parent; // 0x0
	private object gate; // 0x0
	private List<TSource> list; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BufferObservable<TSource, TWindowBoundary> parent, IObserver<IList<TSource>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD160 Offset: 0x30BD261 VA: 0x30BD160
	|-BufferObservable.Buffer<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD220 Offset: 0x30BD321 VA: 0x30BD220
	|-BufferObservable.Buffer<object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD3F0 Offset: 0x30BD4F1 VA: 0x30BD3F0
	|-BufferObservable.Buffer<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD4E0 Offset: 0x30BD5E1 VA: 0x30BD4E0
	|-BufferObservable.Buffer<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD6C0 Offset: 0x30BD7C1 VA: 0x30BD6C0
	|-BufferObservable.Buffer<object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD950 Offset: 0x30BDA51 VA: 0x30BD950
	|-BufferObservable.Buffer<object, object>..cctor
	*/
}

