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

