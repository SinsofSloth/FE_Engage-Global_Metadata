// Namespace: UniRx.Operators
internal class SkipWhileObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7071
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
	|-RVA: 0x3443470 Offset: 0x3443571 VA: 0x3443470
	|-SkipWhileObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, int, bool> predicateWithIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34434F0 Offset: 0x34435F1 VA: 0x34434F0
	|-SkipWhileObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443570 Offset: 0x3443671 VA: 0x3443570
	|-SkipWhileObservable<object>.SubscribeCore
	*/
}

