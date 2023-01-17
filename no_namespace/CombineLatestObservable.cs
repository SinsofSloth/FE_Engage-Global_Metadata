// Namespace: 
private class CombineLatestObservable.CombineLatest.LeftObserver<TLeft, TRight, TResult> : IObserver<TLeft> // TypeDefIndex: 6893
{
	// Fields
	private readonly CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD43B0 Offset: 0x2AD44B1 VA: 0x2AD43B0
	|-CombineLatestObservable.CombineLatest.LeftObserver<bool, bool, bool>..ctor
	|
	|-RVA: 0x2AD46E0 Offset: 0x2AD47E1 VA: 0x2AD46E0
	|-CombineLatestObservable.CombineLatest.LeftObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TLeft value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD43F0 Offset: 0x2AD44F1 VA: 0x2AD43F0
	|-CombineLatestObservable.CombineLatest.LeftObserver<bool, bool, bool>.OnNext
	|
	|-RVA: 0x2AD4720 Offset: 0x2AD4821 VA: 0x2AD4720
	|-CombineLatestObservable.CombineLatest.LeftObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4500 Offset: 0x2AD4601 VA: 0x2AD4500
	|-CombineLatestObservable.CombineLatest.LeftObserver<bool, bool, bool>.OnError
	|
	|-RVA: 0x2AD4830 Offset: 0x2AD4931 VA: 0x2AD4830
	|-CombineLatestObservable.CombineLatest.LeftObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD45F0 Offset: 0x2AD46F1 VA: 0x2AD45F0
	|-CombineLatestObservable.CombineLatest.LeftObserver<bool, bool, bool>.OnCompleted
	|
	|-RVA: 0x2AD4920 Offset: 0x2AD4A21 VA: 0x2AD4920
	|-CombineLatestObservable.CombineLatest.LeftObserver<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest.RightObserver<TLeft, TRight, TResult> : IObserver<TRight> // TypeDefIndex: 6894
{
	// Fields
	private readonly CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFB890 Offset: 0x2FFB991 VA: 0x2FFB890
	|-CombineLatestObservable.CombineLatest.RightObserver<bool, bool, bool>..ctor
	|
	|-RVA: 0x2FFBBC0 Offset: 0x2FFBCC1 VA: 0x2FFBBC0
	|-CombineLatestObservable.CombineLatest.RightObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TRight value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFB8D0 Offset: 0x2FFB9D1 VA: 0x2FFB8D0
	|-CombineLatestObservable.CombineLatest.RightObserver<bool, bool, bool>.OnNext
	|
	|-RVA: 0x2FFBC00 Offset: 0x2FFBD01 VA: 0x2FFBC00
	|-CombineLatestObservable.CombineLatest.RightObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFB9E0 Offset: 0x2FFBAE1 VA: 0x2FFB9E0
	|-CombineLatestObservable.CombineLatest.RightObserver<bool, bool, bool>.OnError
	|
	|-RVA: 0x2FFBD10 Offset: 0x2FFBE11 VA: 0x2FFBD10
	|-CombineLatestObservable.CombineLatest.RightObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFBAD0 Offset: 0x2FFBBD1 VA: 0x2FFBAD0
	|-CombineLatestObservable.CombineLatest.RightObserver<bool, bool, bool>.OnCompleted
	|
	|-RVA: 0x2FFBE00 Offset: 0x2FFBF01 VA: 0x2FFBE00
	|-CombineLatestObservable.CombineLatest.RightObserver<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<TLeft, TRight, TResult> : OperatorObserverBase<TResult, TResult> // TypeDefIndex: 6895
{
	// Fields
	private readonly CombineLatestObservable<TLeft, TRight, TResult> parent; // 0x0
	private readonly object gate; // 0x0
	private TLeft leftValue; // 0x0
	private bool leftStarted; // 0x0
	private bool leftCompleted; // 0x0
	private TRight rightValue; // 0x0
	private bool rightStarted; // 0x0
	private bool rightCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CombineLatestObservable<TLeft, TRight, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DD400 Offset: 0x30DD501 VA: 0x30DD400
	|-CombineLatestObservable.CombineLatest<bool, bool, bool>..ctor
	|
	|-RVA: 0x30DDCB0 Offset: 0x30DDDB1 VA: 0x30DDCB0
	|-CombineLatestObservable.CombineLatest<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DD4C0 Offset: 0x30DD5C1 VA: 0x30DD4C0
	|-CombineLatestObservable.CombineLatest<bool, bool, bool>.Run
	|
	|-RVA: 0x30DDD70 Offset: 0x30DDE71 VA: 0x30DDD70
	|-CombineLatestObservable.CombineLatest<object, object, object>.Run
	*/

	// RVA: -1 Offset: -1
	public void Publish() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DD680 Offset: 0x30DD781 VA: 0x30DD680
	|-CombineLatestObservable.CombineLatest<bool, bool, bool>.Publish
	|
	|-RVA: 0x30DDF30 Offset: 0x30DE031 VA: 0x30DDF30
	|-CombineLatestObservable.CombineLatest<object, object, object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TResult value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DD990 Offset: 0x30DDA91 VA: 0x30DD990
	|-CombineLatestObservable.CombineLatest<bool, bool, bool>.OnNext
	|
	|-RVA: 0x30DE240 Offset: 0x30DE341 VA: 0x30DE240
	|-CombineLatestObservable.CombineLatest<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DDA40 Offset: 0x30DDB41 VA: 0x30DDA40
	|-CombineLatestObservable.CombineLatest<bool, bool, bool>.OnError
	|
	|-RVA: 0x30DE2F0 Offset: 0x30DE3F1 VA: 0x30DE2F0
	|-CombineLatestObservable.CombineLatest<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DDB80 Offset: 0x30DDC81 VA: 0x30DDB80
	|-CombineLatestObservable.CombineLatest<bool, bool, bool>.OnCompleted
	|
	|-RVA: 0x30DE430 Offset: 0x30DE531 VA: 0x30DE430
	|-CombineLatestObservable.CombineLatest<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest.CombineLatestObserver<T> : IObserver<T> // TypeDefIndex: 6897
{
	// Fields
	private readonly CombineLatestObservable.CombineLatest<T> parent; // 0x0
	private readonly int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CombineLatestObservable.CombineLatest<T> parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3E60 Offset: 0x30E3F61 VA: 0x30E3E60
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<bool>..ctor
	|
	|-RVA: 0x30E4230 Offset: 0x30E4331 VA: 0x30E4230
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3EB0 Offset: 0x30E3FB1 VA: 0x30E3EB0
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<bool>.OnNext
	|
	|-RVA: 0x30E4280 Offset: 0x30E4381 VA: 0x30E4280
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3FE0 Offset: 0x30E40E1 VA: 0x30E3FE0
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<bool>.OnError
	|
	|-RVA: 0x30E43B0 Offset: 0x30E44B1 VA: 0x30E43B0
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E40D0 Offset: 0x30E41D1 VA: 0x30E40D0
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<bool>.OnCompleted
	|
	|-RVA: 0x30E44A0 Offset: 0x30E45A1 VA: 0x30E44A0
	|-CombineLatestObservable.CombineLatest.CombineLatestObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<T> : OperatorObserverBase<IList<T>, IList<T>> // TypeDefIndex: 6898
{
	// Fields
	private readonly CombineLatestObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private int length; // 0x0
	private T[] values; // 0x0
	private bool[] isStarted; // 0x0
	private bool[] isCompleted; // 0x0
	private bool isAllValueStarted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(CombineLatestObservable<T> parent, IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC300 Offset: 0x30DC401 VA: 0x30DC300
	|-CombineLatestObservable.CombineLatest<bool>..ctor
	|
	|-RVA: 0x30DCB80 Offset: 0x30DCC81 VA: 0x30DCB80
	|-CombineLatestObservable.CombineLatest<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC3C0 Offset: 0x30DC4C1 VA: 0x30DC3C0
	|-CombineLatestObservable.CombineLatest<bool>.Run
	|
	|-RVA: 0x30DCC40 Offset: 0x30DCD41 VA: 0x30DCC40
	|-CombineLatestObservable.CombineLatest<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void Publish(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC620 Offset: 0x30DC721 VA: 0x30DC620
	|-CombineLatestObservable.CombineLatest<bool>.Publish
	|
	|-RVA: 0x30DCEA0 Offset: 0x30DCFA1 VA: 0x30DCEA0
	|-CombineLatestObservable.CombineLatest<object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC860 Offset: 0x30DC961 VA: 0x30DC860
	|-CombineLatestObservable.CombineLatest<bool>.OnNext
	|
	|-RVA: 0x30DD0E0 Offset: 0x30DD1E1 VA: 0x30DD0E0
	|-CombineLatestObservable.CombineLatest<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC910 Offset: 0x30DCA11 VA: 0x30DC910
	|-CombineLatestObservable.CombineLatest<bool>.OnError
	|
	|-RVA: 0x30DD190 Offset: 0x30DD291 VA: 0x30DD190
	|-CombineLatestObservable.CombineLatest<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DCA50 Offset: 0x30DCB51 VA: 0x30DCA50
	|-CombineLatestObservable.CombineLatest<bool>.OnCompleted
	|
	|-RVA: 0x30DD2D0 Offset: 0x30DD3D1 VA: 0x30DD2D0
	|-CombineLatestObservable.CombineLatest<object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<T1, T2, T3, TR> : NthCombineLatestObserverBase<TR> // TypeDefIndex: 6900
{
	// Fields
	private readonly CombineLatestObservable<T1, T2, T3, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private CombineLatestObserver<T1> c1; // 0x0
	private CombineLatestObserver<T2> c2; // 0x0
	private CombineLatestObserver<T3> c3; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, CombineLatestObservable<T1, T2, T3, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DE560 Offset: 0x30DE661 VA: 0x30DE560
	|-CombineLatestObservable.CombineLatest<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DE630 Offset: 0x30DE731 VA: 0x30DE630
	|-CombineLatestObservable.CombineLatest<object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DE930 Offset: 0x30DEA31 VA: 0x30DE930
	|-CombineLatestObservable.CombineLatest<object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DE9E0 Offset: 0x30DEAE1 VA: 0x30DE9E0
	|-CombineLatestObservable.CombineLatest<object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DEA90 Offset: 0x30DEB91 VA: 0x30DEA90
	|-CombineLatestObservable.CombineLatest<object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DEBD0 Offset: 0x30DECD1 VA: 0x30DEBD0
	|-CombineLatestObservable.CombineLatest<object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<T1, T2, T3, T4, TR> : NthCombineLatestObserverBase<TR> // TypeDefIndex: 6902
{
	// Fields
	private readonly CombineLatestObservable<T1, T2, T3, T4, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private CombineLatestObserver<T1> c1; // 0x0
	private CombineLatestObserver<T2> c2; // 0x0
	private CombineLatestObserver<T3> c3; // 0x0
	private CombineLatestObserver<T4> c4; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, CombineLatestObservable<T1, T2, T3, T4, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DED00 Offset: 0x30DEE01 VA: 0x30DED00
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DEDD0 Offset: 0x30DEED1 VA: 0x30DEDD0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DF1C0 Offset: 0x30DF2C1 VA: 0x30DF1C0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DF290 Offset: 0x30DF391 VA: 0x30DF290
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DF340 Offset: 0x30DF441 VA: 0x30DF340
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DF480 Offset: 0x30DF581 VA: 0x30DF480
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<T1, T2, T3, T4, T5, TR> : NthCombineLatestObserverBase<TR> // TypeDefIndex: 6904
{
	// Fields
	private readonly CombineLatestObservable<T1, T2, T3, T4, T5, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private CombineLatestObserver<T1> c1; // 0x0
	private CombineLatestObserver<T2> c2; // 0x0
	private CombineLatestObserver<T3> c3; // 0x0
	private CombineLatestObserver<T4> c4; // 0x0
	private CombineLatestObserver<T5> c5; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, CombineLatestObservable<T1, T2, T3, T4, T5, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DF5B0 Offset: 0x30DF6B1 VA: 0x30DF5B0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DF680 Offset: 0x30DF781 VA: 0x30DF680
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DFCA0 Offset: 0x30DFDA1 VA: 0x30DFCA0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DFD90 Offset: 0x30DFE91 VA: 0x30DFD90
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DFE40 Offset: 0x30DFF41 VA: 0x30DFE40
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DFF80 Offset: 0x30E0081 VA: 0x30DFF80
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<T1, T2, T3, T4, T5, T6, TR> : NthCombineLatestObserverBase<TR> // TypeDefIndex: 6906
{
	// Fields
	private readonly CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private CombineLatestObserver<T1> c1; // 0x0
	private CombineLatestObserver<T2> c2; // 0x0
	private CombineLatestObserver<T3> c3; // 0x0
	private CombineLatestObserver<T4> c4; // 0x0
	private CombineLatestObserver<T5> c5; // 0x0
	private CombineLatestObserver<T6> c6; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E00B0 Offset: 0x30E01B1 VA: 0x30E00B0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E0180 Offset: 0x30E0281 VA: 0x30E0180
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E08C0 Offset: 0x30E09C1 VA: 0x30E08C0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E09D0 Offset: 0x30E0AD1 VA: 0x30E09D0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E0A80 Offset: 0x30E0B81 VA: 0x30E0A80
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E0BC0 Offset: 0x30E0CC1 VA: 0x30E0BC0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class CombineLatestObservable.CombineLatest<T1, T2, T3, T4, T5, T6, T7, TR> : NthCombineLatestObserverBase<TR> // TypeDefIndex: 6908
{
	// Fields
	private readonly CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private CombineLatestObserver<T1> c1; // 0x0
	private CombineLatestObserver<T2> c2; // 0x0
	private CombineLatestObserver<T3> c3; // 0x0
	private CombineLatestObserver<T4> c4; // 0x0
	private CombineLatestObserver<T5> c5; // 0x0
	private CombineLatestObserver<T6> c6; // 0x0
	private CombineLatestObserver<T7> c7; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E0CF0 Offset: 0x30E0DF1 VA: 0x30E0CF0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E0DC0 Offset: 0x30E0EC1 VA: 0x30E0DC0
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E1620 Offset: 0x30E1721 VA: 0x30E1620
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E1770 Offset: 0x30E1871 VA: 0x30E1770
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E1820 Offset: 0x30E1921 VA: 0x30E1820
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E1960 Offset: 0x30E1A61 VA: 0x30E1960
	|-CombineLatestObservable.CombineLatest<object, object, object, object, object, object, object, object>.OnCompleted
	*/
}

