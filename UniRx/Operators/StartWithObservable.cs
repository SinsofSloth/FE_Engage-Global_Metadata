// Namespace: UniRx.Operators
internal class StartWithObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7075
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly T value; // 0x0
	private readonly Func<T> valueFactory; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C41F0 Offset: 0x36C42F1 VA: 0x36C41F0
	|-StartWithObservable<int>..ctor
	|
	|-RVA: 0x36C4390 Offset: 0x36C4491 VA: 0x36C4390
	|-StartWithObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4270 Offset: 0x36C4371 VA: 0x36C4270
	|-StartWithObservable<int>..ctor
	|
	|-RVA: 0x36C4410 Offset: 0x36C4511 VA: 0x36C4410
	|-StartWithObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C42F0 Offset: 0x36C43F1 VA: 0x36C42F0
	|-StartWithObservable<int>.SubscribeCore
	|
	|-RVA: 0x36C4490 Offset: 0x36C4591 VA: 0x36C4490
	|-StartWithObservable<object>.SubscribeCore
	*/
}

