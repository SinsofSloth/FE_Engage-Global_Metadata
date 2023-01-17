// Namespace: UniRx.Operators
internal class CreateObservable<T, TState> : OperatorObservableBase<T> // TypeDefIndex: 6921
{
	// Fields
	private readonly TState state; // 0x0
	private readonly Func<TState, IObserver<T>, IDisposable> subscribe; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TState state, Func<TState, IObserver<T>, IDisposable> subscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250F720 Offset: 0x250F821 VA: 0x250F720
	|-CreateObservable<bool, object>..ctor
	|
	|-RVA: 0x250F8D0 Offset: 0x250F9D1 VA: 0x250F8D0
	|-CreateObservable<int, object>..ctor
	|
	|-RVA: 0x250FA80 Offset: 0x250FB81 VA: 0x250FA80
	|-CreateObservable<object, object>..ctor
	|
	|-RVA: 0x250FC30 Offset: 0x250FD31 VA: 0x250FC30
	|-CreateObservable<float, object>..ctor
	|
	|-RVA: 0x250FDE0 Offset: 0x250FEE1 VA: 0x250FDE0
	|-CreateObservable<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TState state, Func<TState, IObserver<T>, IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250F780 Offset: 0x250F881 VA: 0x250F780
	|-CreateObservable<bool, object>..ctor
	|
	|-RVA: 0x250F930 Offset: 0x250FA31 VA: 0x250F930
	|-CreateObservable<int, object>..ctor
	|
	|-RVA: 0x250FAE0 Offset: 0x250FBE1 VA: 0x250FAE0
	|-CreateObservable<object, object>..ctor
	|
	|-RVA: 0x250FC90 Offset: 0x250FD91 VA: 0x250FC90
	|-CreateObservable<float, object>..ctor
	|
	|-RVA: 0x250FE40 Offset: 0x250FF41 VA: 0x250FE40
	|-CreateObservable<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250F7E0 Offset: 0x250F8E1 VA: 0x250F7E0
	|-CreateObservable<bool, object>.SubscribeCore
	|
	|-RVA: 0x250F990 Offset: 0x250FA91 VA: 0x250F990
	|-CreateObservable<int, object>.SubscribeCore
	|
	|-RVA: 0x250FB40 Offset: 0x250FC41 VA: 0x250FB40
	|-CreateObservable<object, object>.SubscribeCore
	|
	|-RVA: 0x250FCF0 Offset: 0x250FDF1 VA: 0x250FCF0
	|-CreateObservable<float, object>.SubscribeCore
	|
	|-RVA: 0x250FEA0 Offset: 0x250FFA1 VA: 0x250FEA0
	|-CreateObservable<Vector2, object>.SubscribeCore
	*/
}

