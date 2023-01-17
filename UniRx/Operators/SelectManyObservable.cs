// Namespace: UniRx.Operators
internal class SelectManyObservable<TSource, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7049
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly Func<TSource, IObservable<TResult>> selector; // 0x0
	private readonly Func<TSource, int, IObservable<TResult>> selectorWithIndex; // 0x0
	private readonly Func<TSource, IEnumerable<TResult>> selectorEnumerable; // 0x0
	private readonly Func<TSource, int, IEnumerable<TResult>> selectorEnumerableWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, IObservable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300C2E0 Offset: 0x300C3E1 VA: 0x300C2E0
	|-SelectManyObservable<object, object>..ctor
	|
	|-RVA: 0x300C6D0 Offset: 0x300C7D1 VA: 0x300C6D0
	|-SelectManyObservable<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, int, IObservable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300C360 Offset: 0x300C461 VA: 0x300C360
	|-SelectManyObservable<object, object>..ctor
	|
	|-RVA: 0x300C750 Offset: 0x300C851 VA: 0x300C750
	|-SelectManyObservable<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300C3E0 Offset: 0x300C4E1 VA: 0x300C3E0
	|-SelectManyObservable<object, object>..ctor
	|
	|-RVA: 0x300C7D0 Offset: 0x300C8D1 VA: 0x300C7D0
	|-SelectManyObservable<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300C460 Offset: 0x300C561 VA: 0x300C460
	|-SelectManyObservable<object, object>..ctor
	|
	|-RVA: 0x300C850 Offset: 0x300C951 VA: 0x300C850
	|-SelectManyObservable<object, Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300C4E0 Offset: 0x300C5E1 VA: 0x300C4E0
	|-SelectManyObservable<object, object>.SubscribeCore
	|
	|-RVA: 0x300C8D0 Offset: 0x300C9D1 VA: 0x300C8D0
	|-SelectManyObservable<object, Unit>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class SelectManyObservable<TSource, TCollection, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7056
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly Func<TSource, IObservable<TCollection>> collectionSelector; // 0x0
	private readonly Func<TSource, int, IObservable<TCollection>> collectionSelectorWithIndex; // 0x0
	private readonly Func<TSource, IEnumerable<TCollection>> collectionSelectorEnumerable; // 0x0
	private readonly Func<TSource, int, IEnumerable<TCollection>> collectionSelectorEnumerableWithIndex; // 0x0
	private readonly Func<TSource, TCollection, TResult> resultSelector; // 0x0
	private readonly Func<TSource, int, TCollection, int, TResult> resultSelectorWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, IObservable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300CAC0 Offset: 0x300CBC1 VA: 0x300CAC0
	|-SelectManyObservable<object, long, object>..ctor
	|
	|-RVA: 0x300CF30 Offset: 0x300D031 VA: 0x300CF30
	|-SelectManyObservable<object, object, object>..ctor
	|
	|-RVA: 0x300D3A0 Offset: 0x300D4A1 VA: 0x300D3A0
	|-SelectManyObservable<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, int, IObservable<TCollection>> collectionSelector, Func<TSource, int, TCollection, int, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300CB60 Offset: 0x300CC61 VA: 0x300CB60
	|-SelectManyObservable<object, long, object>..ctor
	|
	|-RVA: 0x300CFD0 Offset: 0x300D0D1 VA: 0x300CFD0
	|-SelectManyObservable<object, object, object>..ctor
	|
	|-RVA: 0x300D440 Offset: 0x300D541 VA: 0x300D440
	|-SelectManyObservable<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300CC00 Offset: 0x300CD01 VA: 0x300CC00
	|-SelectManyObservable<object, long, object>..ctor
	|
	|-RVA: 0x300D070 Offset: 0x300D171 VA: 0x300D070
	|-SelectManyObservable<object, object, object>..ctor
	|
	|-RVA: 0x300D4E0 Offset: 0x300D5E1 VA: 0x300D4E0
	|-SelectManyObservable<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, int, TCollection, int, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300CCA0 Offset: 0x300CDA1 VA: 0x300CCA0
	|-SelectManyObservable<object, long, object>..ctor
	|
	|-RVA: 0x300D110 Offset: 0x300D211 VA: 0x300D110
	|-SelectManyObservable<object, object, object>..ctor
	|
	|-RVA: 0x300D580 Offset: 0x300D681 VA: 0x300D580
	|-SelectManyObservable<object, Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x300CD40 Offset: 0x300CE41 VA: 0x300CD40
	|-SelectManyObservable<object, long, object>.SubscribeCore
	|
	|-RVA: 0x300D1B0 Offset: 0x300D2B1 VA: 0x300D1B0
	|-SelectManyObservable<object, object, object>.SubscribeCore
	|
	|-RVA: 0x300D620 Offset: 0x300D721 VA: 0x300D620
	|-SelectManyObservable<object, Unit, object>.SubscribeCore
	*/
}

