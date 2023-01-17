// Namespace: 
private class SelectManyObservable.SelectManyOuterObserver<TSource, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 7044
{
	// Fields
	private readonly SelectManyObservable<TSource, TResult> parent; // 0x0
	private CompositeDisposable collectionDisposable; // 0x0
	private SingleAssignmentDisposable sourceDisposable; // 0x0
	private object gate; // 0x0
	private bool isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable<TSource, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342BB50 Offset: 0x342BC51 VA: 0x342BB50
	|-SelectManyObservable.SelectManyOuterObserver<object, object>..ctor
	|
	|-RVA: 0x342C460 Offset: 0x342C561 VA: 0x342C460
	|-SelectManyObservable.SelectManyOuterObserver<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342BC10 Offset: 0x342BD11 VA: 0x342BC10
	|-SelectManyObservable.SelectManyOuterObserver<object, object>.Run
	|
	|-RVA: 0x342C520 Offset: 0x342C621 VA: 0x342C520
	|-SelectManyObservable.SelectManyOuterObserver<object, Unit>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342BD80 Offset: 0x342BE81 VA: 0x342BD80
	|-SelectManyObservable.SelectManyOuterObserver<object, object>.OnNext
	|
	|-RVA: 0x342C690 Offset: 0x342C791 VA: 0x342C690
	|-SelectManyObservable.SelectManyOuterObserver<object, Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342C080 Offset: 0x342C181 VA: 0x342C080
	|-SelectManyObservable.SelectManyOuterObserver<object, object>.OnError
	|
	|-RVA: 0x342C990 Offset: 0x342CA91 VA: 0x342C990
	|-SelectManyObservable.SelectManyOuterObserver<object, Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342C260 Offset: 0x342C361 VA: 0x342C260
	|-SelectManyObservable.SelectManyOuterObserver<object, object>.OnCompleted
	|
	|-RVA: 0x342CB70 Offset: 0x342CC71 VA: 0x342CB70
	|-SelectManyObservable.SelectManyOuterObserver<object, Unit>.OnCompleted
	*/
}

// Namespace: 
private class SelectManyObservable.SelectManyObserverWithIndex<TSource, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 7046
{
	// Fields
	private readonly SelectManyObservable<TSource, TResult> parent; // 0x0
	private CompositeDisposable collectionDisposable; // 0x0
	private int index; // 0x0
	private object gate; // 0x0
	private bool isStopped; // 0x0
	private SingleAssignmentDisposable sourceDisposable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable<TSource, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3429050 Offset: 0x3429151 VA: 0x3429050
	|-SelectManyObservable.SelectManyObserverWithIndex<object, object>..ctor
	|
	|-RVA: 0x3429970 Offset: 0x3429A71 VA: 0x3429970
	|-SelectManyObservable.SelectManyObserverWithIndex<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3429110 Offset: 0x3429211 VA: 0x3429110
	|-SelectManyObservable.SelectManyObserverWithIndex<object, object>.Run
	|
	|-RVA: 0x3429A30 Offset: 0x3429B31 VA: 0x3429A30
	|-SelectManyObservable.SelectManyObserverWithIndex<object, Unit>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3429280 Offset: 0x3429381 VA: 0x3429280
	|-SelectManyObservable.SelectManyObserverWithIndex<object, object>.OnNext
	|
	|-RVA: 0x3429BA0 Offset: 0x3429CA1 VA: 0x3429BA0
	|-SelectManyObservable.SelectManyObserverWithIndex<object, Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3429590 Offset: 0x3429691 VA: 0x3429590
	|-SelectManyObservable.SelectManyObserverWithIndex<object, object>.OnError
	|
	|-RVA: 0x3429EB0 Offset: 0x3429FB1 VA: 0x3429EB0
	|-SelectManyObservable.SelectManyObserverWithIndex<object, Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3429770 Offset: 0x3429871 VA: 0x3429770
	|-SelectManyObservable.SelectManyObserverWithIndex<object, object>.OnCompleted
	|
	|-RVA: 0x342A090 Offset: 0x342A191 VA: 0x342A090
	|-SelectManyObservable.SelectManyObserverWithIndex<object, Unit>.OnCompleted
	*/
}

// Namespace: 
private class SelectManyObservable.SelectManyEnumerableObserverWithIndex<TSource, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 7048
{
	// Fields
	private readonly SelectManyObservable<TSource, TResult> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable<TSource, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30091A0 Offset: 0x30092A1 VA: 0x30091A0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object>..ctor
	|
	|-RVA: 0x3009AB0 Offset: 0x3009BB1 VA: 0x3009AB0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30091F0 Offset: 0x30092F1 VA: 0x30091F0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object>.Run
	|
	|-RVA: 0x3009B00 Offset: 0x3009C01 VA: 0x3009B00
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3009290 Offset: 0x3009391 VA: 0x3009290
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object>.OnNext
	|
	|-RVA: 0x3009BA0 Offset: 0x3009CA1 VA: 0x3009BA0
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3009840 Offset: 0x3009941 VA: 0x3009840
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object>.OnError
	|
	|-RVA: 0x300A150 Offset: 0x300A251 VA: 0x300A150
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3009980 Offset: 0x3009A81 VA: 0x3009980
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, object>.OnCompleted
	|
	|-RVA: 0x300A290 Offset: 0x300A391 VA: 0x300A290
	|-SelectManyObservable.SelectManyEnumerableObserverWithIndex<object, Unit>.OnCompleted
	*/
}

// Namespace: 
private class SelectManyObservable.SelectManyOuterObserver.SelectMany<TSource, TCollection, TResult> : OperatorObserverBase<TCollection, TResult> // TypeDefIndex: 7050
{
	// Fields
	private readonly SelectManyObservable.SelectManyOuterObserver<TSource, TCollection, TResult> parent; // 0x0
	private readonly TSource sourceValue; // 0x0
	private readonly IDisposable cancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable.SelectManyOuterObserver<TSource, TCollection, TResult> parent, TSource value, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3004BB0 Offset: 0x3004CB1 VA: 0x3004BB0
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, long, object>..ctor
	|
	|-RVA: 0x3005230 Offset: 0x3005331 VA: 0x3005230
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, object, object>..ctor
	|
	|-RVA: 0x30058B0 Offset: 0x30059B1 VA: 0x30058B0
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3004C40 Offset: 0x3004D41 VA: 0x3004C40
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, long, object>.OnNext
	|
	|-RVA: 0x30052C0 Offset: 0x30053C1 VA: 0x30052C0
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, object, object>.OnNext
	|
	|-RVA: 0x3005940 Offset: 0x3005A41 VA: 0x3005940
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3004E50 Offset: 0x3004F51 VA: 0x3004E50
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, long, object>.OnError
	|
	|-RVA: 0x30054D0 Offset: 0x30055D1 VA: 0x30054D0
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, object, object>.OnError
	|
	|-RVA: 0x3005B50 Offset: 0x3005C51 VA: 0x3005B50
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3005030 Offset: 0x3005131 VA: 0x3005030
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, long, object>.OnCompleted
	|
	|-RVA: 0x30056B0 Offset: 0x30057B1 VA: 0x30056B0
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, object, object>.OnCompleted
	|
	|-RVA: 0x3005D30 Offset: 0x3005E31 VA: 0x3005D30
	|-SelectManyObservable.SelectManyOuterObserver.SelectMany<object, Unit, object>.OnCompleted
	*/
}

// Namespace: 
private class SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<TSource, TCollection, TResult> : OperatorObserverBase<TCollection, TResult> // TypeDefIndex: 7052
{
	// Fields
	private readonly SelectManyObservable.SelectManyObserverWithIndex<TSource, TCollection, TResult> parent; // 0x0
	private readonly TSource sourceValue; // 0x0
	private readonly int sourceIndex; // 0x0
	private readonly IDisposable cancel; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable.SelectManyObserverWithIndex<TSource, TCollection, TResult> parent, TSource value, int index, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3427970 Offset: 0x3427A71 VA: 0x3427970
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, long, object>..ctor
	|
	|-RVA: 0x3428110 Offset: 0x3428211 VA: 0x3428110
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, object, object>..ctor
	|
	|-RVA: 0x34288B0 Offset: 0x34289B1 VA: 0x34288B0
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3427A10 Offset: 0x3427B11 VA: 0x3427A10
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, long, object>.OnNext
	|
	|-RVA: 0x34281B0 Offset: 0x34282B1 VA: 0x34281B0
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, object, object>.OnNext
	|
	|-RVA: 0x3428950 Offset: 0x3428A51 VA: 0x3428950
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3427D30 Offset: 0x3427E31 VA: 0x3427D30
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, long, object>.OnError
	|
	|-RVA: 0x34284D0 Offset: 0x34285D1 VA: 0x34284D0
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, object, object>.OnError
	|
	|-RVA: 0x3428C70 Offset: 0x3428D71 VA: 0x3428C70
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3427F10 Offset: 0x3428011 VA: 0x3427F10
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, long, object>.OnCompleted
	|
	|-RVA: 0x34286B0 Offset: 0x34287B1 VA: 0x34286B0
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, object, object>.OnCompleted
	|
	|-RVA: 0x3428E50 Offset: 0x3428F51 VA: 0x3428E50
	|-SelectManyObservable.SelectManyObserverWithIndex.SelectManyObserver<object, Unit, object>.OnCompleted
	*/
}

// Namespace: 
private class SelectManyObservable.SelectManyEnumerableObserver<TSource, TCollection, TResult> : OperatorObserverBase<TSource, TResult> // TypeDefIndex: 7054
{
	// Fields
	private readonly SelectManyObservable<TSource, TCollection, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectManyObservable<TSource, TCollection, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3007310 Offset: 0x3007411 VA: 0x3007310
	|-SelectManyObservable.SelectManyEnumerableObserver<object, long, object>..ctor
	|
	|-RVA: 0x3007D40 Offset: 0x3007E41 VA: 0x3007D40
	|-SelectManyObservable.SelectManyEnumerableObserver<object, object, object>..ctor
	|
	|-RVA: 0x3008770 Offset: 0x3008871 VA: 0x3008770
	|-SelectManyObservable.SelectManyEnumerableObserver<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3007360 Offset: 0x3007461 VA: 0x3007360
	|-SelectManyObservable.SelectManyEnumerableObserver<object, long, object>.Run
	|
	|-RVA: 0x3007D90 Offset: 0x3007E91 VA: 0x3007D90
	|-SelectManyObservable.SelectManyEnumerableObserver<object, object, object>.Run
	|
	|-RVA: 0x30087C0 Offset: 0x30088C1 VA: 0x30087C0
	|-SelectManyObservable.SelectManyEnumerableObserver<object, Unit, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3007400 Offset: 0x3007501 VA: 0x3007400
	|-SelectManyObservable.SelectManyEnumerableObserver<object, long, object>.OnNext
	|
	|-RVA: 0x3007E30 Offset: 0x3007F31 VA: 0x3007E30
	|-SelectManyObservable.SelectManyEnumerableObserver<object, object, object>.OnNext
	|
	|-RVA: 0x3008860 Offset: 0x3008961 VA: 0x3008860
	|-SelectManyObservable.SelectManyEnumerableObserver<object, Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3007AD0 Offset: 0x3007BD1 VA: 0x3007AD0
	|-SelectManyObservable.SelectManyEnumerableObserver<object, long, object>.OnError
	|
	|-RVA: 0x3008500 Offset: 0x3008601 VA: 0x3008500
	|-SelectManyObservable.SelectManyEnumerableObserver<object, object, object>.OnError
	|
	|-RVA: 0x3008F30 Offset: 0x3009031 VA: 0x3008F30
	|-SelectManyObservable.SelectManyEnumerableObserver<object, Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3007C10 Offset: 0x3007D11 VA: 0x3007C10
	|-SelectManyObservable.SelectManyEnumerableObserver<object, long, object>.OnCompleted
	|
	|-RVA: 0x3008640 Offset: 0x3008741 VA: 0x3008640
	|-SelectManyObservable.SelectManyEnumerableObserver<object, object, object>.OnCompleted
	|
	|-RVA: 0x3009070 Offset: 0x3009171 VA: 0x3009070
	|-SelectManyObservable.SelectManyEnumerableObserver<object, Unit, object>.OnCompleted
	*/
}

