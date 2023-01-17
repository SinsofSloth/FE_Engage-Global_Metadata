// Namespace: 
private class ZipLatestObservable.ZipLatest.LeftObserver<TLeft, TRight, TResult> : IObserver<TLeft> // TypeDefIndex: 7176
{
	// Fields
	private readonly ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4E70 Offset: 0x2AD4F71 VA: 0x2AD4E70
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TLeft value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4EB0 Offset: 0x2AD4FB1 VA: 0x2AD4EB0
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4FC0 Offset: 0x2AD50C1 VA: 0x2AD4FC0
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD50B0 Offset: 0x2AD51B1 VA: 0x2AD50B0
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest.RightObserver<TLeft, TRight, TResult> : IObserver<TRight> // TypeDefIndex: 7177
{
	// Fields
	private readonly ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC120 Offset: 0x2FFC221 VA: 0x2FFC120
	|-ZipLatestObservable.ZipLatest.RightObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TRight value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC160 Offset: 0x2FFC261 VA: 0x2FFC160
	|-ZipLatestObservable.ZipLatest.RightObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC270 Offset: 0x2FFC371 VA: 0x2FFC270
	|-ZipLatestObservable.ZipLatest.RightObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFC360 Offset: 0x2FFC461 VA: 0x2FFC360
	|-ZipLatestObservable.ZipLatest.RightObserver<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> : OperatorObserverBase<TResult, TResult> // TypeDefIndex: 7178
{
	// Fields
	private readonly ZipLatestObservable<TLeft, TRight, TResult> parent; // 0x0
	private readonly object gate; // 0x0
	private TLeft leftValue; // 0x0
	private bool leftStarted; // 0x0
	private bool leftCompleted; // 0x0
	private TRight rightValue; // 0x0
	private bool rightStarted; // 0x0
	private bool rightCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable<TLeft, TRight, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF18B0 Offset: 0x3EF19B1 VA: 0x3EF18B0
	|-ZipLatestObservable.ZipLatest<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1970 Offset: 0x3EF1A71 VA: 0x3EF1970
	|-ZipLatestObservable.ZipLatest<object, object, object>.Run
	*/

	// RVA: -1 Offset: -1
	public void Publish() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1B30 Offset: 0x3EF1C31 VA: 0x3EF1B30
	|-ZipLatestObservable.ZipLatest<object, object, object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TResult value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1F50 Offset: 0x3EF2051 VA: 0x3EF1F50
	|-ZipLatestObservable.ZipLatest<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2000 Offset: 0x3EF2101 VA: 0x3EF2000
	|-ZipLatestObservable.ZipLatest<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2140 Offset: 0x3EF2241 VA: 0x3EF2140
	|-ZipLatestObservable.ZipLatest<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest.ZipLatestObserver<T> : IObserver<T> // TypeDefIndex: 7180
{
	// Fields
	private readonly ZipLatestObservable.ZipLatest<T> parent; // 0x0
	private readonly int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable.ZipLatest<T> parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7920 Offset: 0x3EF7A21 VA: 0x3EF7920
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7970 Offset: 0x3EF7A71 VA: 0x3EF7970
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7AA0 Offset: 0x3EF7BA1 VA: 0x3EF7AA0
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7B90 Offset: 0x3EF7C91 VA: 0x3EF7B90
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<T> : OperatorObserverBase<IList<T>, IList<T>> // TypeDefIndex: 7181
{
	// Fields
	private readonly ZipLatestObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private int length; // 0x0
	private T[] values; // 0x0
	private bool[] isStarted; // 0x0
	private bool[] isCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF0EE0 Offset: 0x3EF0FE1 VA: 0x3EF0EE0
	|-ZipLatestObservable.ZipLatest<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF0FA0 Offset: 0x3EF10A1 VA: 0x3EF0FA0
	|-ZipLatestObservable.ZipLatest<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void Publish(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1200 Offset: 0x3EF1301 VA: 0x3EF1200
	|-ZipLatestObservable.ZipLatest<object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1590 Offset: 0x3EF1691 VA: 0x3EF1590
	|-ZipLatestObservable.ZipLatest<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1640 Offset: 0x3EF1741 VA: 0x3EF1640
	|-ZipLatestObservable.ZipLatest<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1780 Offset: 0x3EF1881 VA: 0x3EF1780
	|-ZipLatestObservable.ZipLatest<object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<T1, T2, T3, TR> : NthZipLatestObserverBase<TR> // TypeDefIndex: 7183
{
	// Fields
	private readonly ZipLatestObservable<T1, T2, T3, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private ZipLatestObserver<T1> c1; // 0x0
	private ZipLatestObserver<T2> c2; // 0x0
	private ZipLatestObserver<T3> c3; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, ZipLatestObservable<T1, T2, T3, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2270 Offset: 0x3EF2371 VA: 0x3EF2270
	|-ZipLatestObservable.ZipLatest<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2340 Offset: 0x3EF2441 VA: 0x3EF2340
	|-ZipLatestObservable.ZipLatest<object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2640 Offset: 0x3EF2741 VA: 0x3EF2640
	|-ZipLatestObservable.ZipLatest<object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF26F0 Offset: 0x3EF27F1 VA: 0x3EF26F0
	|-ZipLatestObservable.ZipLatest<object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF27A0 Offset: 0x3EF28A1 VA: 0x3EF27A0
	|-ZipLatestObservable.ZipLatest<object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF28E0 Offset: 0x3EF29E1 VA: 0x3EF28E0
	|-ZipLatestObservable.ZipLatest<object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<T1, T2, T3, T4, TR> : NthZipLatestObserverBase<TR> // TypeDefIndex: 7185
{
	// Fields
	private readonly ZipLatestObservable<T1, T2, T3, T4, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private ZipLatestObserver<T1> c1; // 0x0
	private ZipLatestObserver<T2> c2; // 0x0
	private ZipLatestObserver<T3> c3; // 0x0
	private ZipLatestObserver<T4> c4; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, ZipLatestObservable<T1, T2, T3, T4, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2A10 Offset: 0x3EF2B11 VA: 0x3EF2A10
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2AE0 Offset: 0x3EF2BE1 VA: 0x3EF2AE0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2ED0 Offset: 0x3EF2FD1 VA: 0x3EF2ED0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2FA0 Offset: 0x3EF30A1 VA: 0x3EF2FA0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3050 Offset: 0x3EF3151 VA: 0x3EF3050
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3190 Offset: 0x3EF3291 VA: 0x3EF3190
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, TR> : NthZipLatestObserverBase<TR> // TypeDefIndex: 7187
{
	// Fields
	private readonly ZipLatestObservable<T1, T2, T3, T4, T5, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private ZipLatestObserver<T1> c1; // 0x0
	private ZipLatestObserver<T2> c2; // 0x0
	private ZipLatestObserver<T3> c3; // 0x0
	private ZipLatestObserver<T4> c4; // 0x0
	private ZipLatestObserver<T5> c5; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, ZipLatestObservable<T1, T2, T3, T4, T5, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF32C0 Offset: 0x3EF33C1 VA: 0x3EF32C0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3390 Offset: 0x3EF3491 VA: 0x3EF3390
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF39B0 Offset: 0x3EF3AB1 VA: 0x3EF39B0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3AA0 Offset: 0x3EF3BA1 VA: 0x3EF3AA0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3B50 Offset: 0x3EF3C51 VA: 0x3EF3B50
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3C90 Offset: 0x3EF3D91 VA: 0x3EF3C90
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, T6, TR> : NthZipLatestObserverBase<TR> // TypeDefIndex: 7189
{
	// Fields
	private readonly ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private ZipLatestObserver<T1> c1; // 0x0
	private ZipLatestObserver<T2> c2; // 0x0
	private ZipLatestObserver<T3> c3; // 0x0
	private ZipLatestObserver<T4> c4; // 0x0
	private ZipLatestObserver<T5> c5; // 0x0
	private ZipLatestObserver<T6> c6; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3DC0 Offset: 0x3EF3EC1 VA: 0x3EF3DC0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF3E90 Offset: 0x3EF3F91 VA: 0x3EF3E90
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF45D0 Offset: 0x3EF46D1 VA: 0x3EF45D0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF46E0 Offset: 0x3EF47E1 VA: 0x3EF46E0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF4790 Offset: 0x3EF4891 VA: 0x3EF4790
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF48D0 Offset: 0x3EF49D1 VA: 0x3EF48D0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, T6, T7, TR> : NthZipLatestObserverBase<TR> // TypeDefIndex: 7191
{
	// Fields
	private readonly ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private ZipLatestObserver<T1> c1; // 0x0
	private ZipLatestObserver<T2> c2; // 0x0
	private ZipLatestObserver<T3> c3; // 0x0
	private ZipLatestObserver<T4> c4; // 0x0
	private ZipLatestObserver<T5> c5; // 0x0
	private ZipLatestObserver<T6> c6; // 0x0
	private ZipLatestObserver<T7> c7; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF4A00 Offset: 0x3EF4B01 VA: 0x3EF4A00
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF4AD0 Offset: 0x3EF4BD1 VA: 0x3EF4AD0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5330 Offset: 0x3EF5431 VA: 0x3EF5330
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5480 Offset: 0x3EF5581 VA: 0x3EF5480
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5530 Offset: 0x3EF5631 VA: 0x3EF5530
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5670 Offset: 0x3EF5771 VA: 0x3EF5670
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.OnCompleted
	*/
}

