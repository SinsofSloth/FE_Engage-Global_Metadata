// Namespace: 
private class WhereObservable.Where<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7136
{
	// Fields
	private readonly WhereObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhereObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C4E80 Offset: 0x39C4F81 VA: 0x39C4E80
	|-WhereObservable.Where<bool>..ctor
	|
	|-RVA: 0x39C53A0 Offset: 0x39C54A1 VA: 0x39C53A0
	|-WhereObservable.Where<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C4ED0 Offset: 0x39C4FD1 VA: 0x39C4ED0
	|-WhereObservable.Where<bool>.OnNext
	|
	|-RVA: 0x39C53F0 Offset: 0x39C54F1 VA: 0x39C53F0
	|-WhereObservable.Where<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5130 Offset: 0x39C5231 VA: 0x39C5130
	|-WhereObservable.Where<bool>.OnError
	|
	|-RVA: 0x39C5650 Offset: 0x39C5751 VA: 0x39C5650
	|-WhereObservable.Where<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5270 Offset: 0x39C5371 VA: 0x39C5270
	|-WhereObservable.Where<bool>.OnCompleted
	|
	|-RVA: 0x39C5790 Offset: 0x39C5891 VA: 0x39C5790
	|-WhereObservable.Where<object>.OnCompleted
	*/
}

// Namespace: 
private class WhereObservable.Where_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7137
{
	// Fields
	private readonly WhereObservable<T> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhereObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD410 Offset: 0x39DD511 VA: 0x39DD410
	|-WhereObservable.Where_<bool>..ctor
	|
	|-RVA: 0x39DD950 Offset: 0x39DDA51 VA: 0x39DD950
	|-WhereObservable.Where_<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD470 Offset: 0x39DD571 VA: 0x39DD470
	|-WhereObservable.Where_<bool>.OnNext
	|
	|-RVA: 0x39DD9B0 Offset: 0x39DDAB1 VA: 0x39DD9B0
	|-WhereObservable.Where_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD6E0 Offset: 0x39DD7E1 VA: 0x39DD6E0
	|-WhereObservable.Where_<bool>.OnError
	|
	|-RVA: 0x39DDC20 Offset: 0x39DDD21 VA: 0x39DDC20
	|-WhereObservable.Where_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DD820 Offset: 0x39DD921 VA: 0x39DD820
	|-WhereObservable.Where_<bool>.OnCompleted
	|
	|-RVA: 0x39DDD60 Offset: 0x39DDE61 VA: 0x39DDD60
	|-WhereObservable.Where_<object>.OnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13AA0 Offset: 0x13BA1 VA: 0x13AA0
private sealed class WhereObservable.<>c__DisplayClass5_0<T> // TypeDefIndex: 7138
{
	// Fields
	public WhereObservable<T> <>4__this; // 0x0
	public Func<T, bool> combinePredicate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3EC10 Offset: 0x2B3ED11 VA: 0x2B3EC10
	|-WhereObservable.<>c__DisplayClass5_0<bool>..ctor
	|
	|-RVA: 0x2B3ECD0 Offset: 0x2B3EDD1 VA: 0x2B3ECD0
	|-WhereObservable.<>c__DisplayClass5_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CombinePredicate>b__0(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3EC20 Offset: 0x2B3ED21 VA: 0x2B3EC20
	|-WhereObservable.<>c__DisplayClass5_0<bool>.<CombinePredicate>b__0
	|
	|-RVA: 0x2B3ECE0 Offset: 0x2B3EDE1 VA: 0x2B3ECE0
	|-WhereObservable.<>c__DisplayClass5_0<object>.<CombinePredicate>b__0
	*/
}

