// Namespace: UniRx.Operators
internal class WhereObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7139
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Func<T, bool> predicate; // 0x0
	private readonly Func<T, int, bool> predicateWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C98A0 Offset: 0x39C99A1 VA: 0x39C98A0
	|-WhereObservable<bool>..ctor
	|
	|-RVA: 0x39C9C70 Offset: 0x39C9D71 VA: 0x39C9C70
	|-WhereObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, int, bool> predicateWithIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C9920 Offset: 0x39C9A21 VA: 0x39C9920
	|-WhereObservable<bool>..ctor
	|
	|-RVA: 0x39C9CF0 Offset: 0x39C9DF1 VA: 0x39C9CF0
	|-WhereObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> CombinePredicate(Func<T, bool> combinePredicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C99A0 Offset: 0x39C9AA1 VA: 0x39C99A0
	|-WhereObservable<bool>.CombinePredicate
	|
	|-RVA: 0x39C9D70 Offset: 0x39C9E71 VA: 0x39C9D70
	|-WhereObservable<object>.CombinePredicate
	*/

	// RVA: -1 Offset: -1
	public IObservable<TR> CombineSelector<TR>(Func<T, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557910 Offset: 0x2557A11 VA: 0x2557910
	|-WhereObservable<object>.CombineSelector<bool>
	|
	|-RVA: 0x25579E0 Offset: 0x2557AE1 VA: 0x25579E0
	|-WhereObservable<object>.CombineSelector<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C9AE0 Offset: 0x39C9BE1 VA: 0x39C9AE0
	|-WhereObservable<bool>.SubscribeCore
	|
	|-RVA: 0x39C9EB0 Offset: 0x39C9FB1 VA: 0x39C9EB0
	|-WhereObservable<object>.SubscribeCore
	*/
}

