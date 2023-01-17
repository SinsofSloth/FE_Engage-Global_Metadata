// Namespace: UniRx.Operators
internal class LastObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6986
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly bool useDefault; // 0x0
	private readonly Func<T, bool> predicate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, bool useDefault) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289ED10 Offset: 0x289EE11 VA: 0x289ED10
	|-LastObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, bool> predicate, bool useDefault) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289ED90 Offset: 0x289EE91 VA: 0x289ED90
	|-LastObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289EE30 Offset: 0x289EF31 VA: 0x289EE30
	|-LastObservable<object>.SubscribeCore
	*/
}

