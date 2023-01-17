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

