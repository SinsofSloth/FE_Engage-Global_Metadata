// Namespace: UniRx.Operators
internal class SelectObservable<T, TR> : OperatorObservableBase<TR>, ISelect<TR> // TypeDefIndex: 7042
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Func<T, TR> selector; // 0x0
	private readonly Func<T, int, TR> selectorWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342E5D0 Offset: 0x342E6D1 VA: 0x342E5D0
	|-SelectObservable<bool, bool>..ctor
	|
	|-RVA: 0x342E940 Offset: 0x342EA41 VA: 0x342E940
	|-SelectObservable<object, bool>..ctor
	|
	|-RVA: 0x342ECB0 Offset: 0x342EDB1 VA: 0x342ECB0
	|-SelectObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, int, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342E650 Offset: 0x342E751 VA: 0x342E650
	|-SelectObservable<bool, bool>..ctor
	|
	|-RVA: 0x342E9C0 Offset: 0x342EAC1 VA: 0x342E9C0
	|-SelectObservable<object, bool>..ctor
	|
	|-RVA: 0x342ED30 Offset: 0x342EE31 VA: 0x342ED30
	|-SelectObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IObservable<TR> CombinePredicate(Func<TR, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342E6D0 Offset: 0x342E7D1 VA: 0x342E6D0
	|-SelectObservable<bool, bool>.CombinePredicate
	|
	|-RVA: 0x342EA40 Offset: 0x342EB41 VA: 0x342EA40
	|-SelectObservable<object, bool>.CombinePredicate
	|
	|-RVA: 0x342EDB0 Offset: 0x342EEB1 VA: 0x342EDB0
	|-SelectObservable<object, object>.CombinePredicate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342E7B0 Offset: 0x342E8B1 VA: 0x342E7B0
	|-SelectObservable<bool, bool>.SubscribeCore
	|
	|-RVA: 0x342EB20 Offset: 0x342EC21 VA: 0x342EB20
	|-SelectObservable<object, bool>.SubscribeCore
	|
	|-RVA: 0x342EE90 Offset: 0x342EF91 VA: 0x342EE90
	|-SelectObservable<object, object>.SubscribeCore
	*/
}

