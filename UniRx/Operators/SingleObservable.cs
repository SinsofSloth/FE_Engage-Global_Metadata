// Namespace: UniRx.Operators
internal class SingleObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7061
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
	|-RVA: 0x3437010 Offset: 0x3437111 VA: 0x3437010
	|-SingleObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, bool> predicate, bool useDefault) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437090 Offset: 0x3437191 VA: 0x3437090
	|-SingleObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3437130 Offset: 0x3437231 VA: 0x3437130
	|-SingleObservable<object>.SubscribeCore
	*/
}

