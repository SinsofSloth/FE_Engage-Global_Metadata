// Namespace: UniRx
[Serializable]
public abstract class Notification<T> : IEquatable<Notification<T>> // TypeDefIndex: 6556
{
	// Properties
	public abstract T Value { get; }
	public abstract bool HasValue { get; }
	public abstract Exception Exception { get; }
	public abstract NotificationKind Kind { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7E60 Offset: 0x31A7F61 VA: 0x31A7E60
	|-Notification<object>..ctor
	|
	|-RVA: 0x31A81B0 Offset: 0x31A82B1 VA: 0x31A81B0
	|-Notification<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract T get_Value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_HasValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.get_HasValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Exception get_Exception();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.get_Exception
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract NotificationKind get_Kind();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.get_Kind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Equals(Notification<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Notification<T> left, Notification<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7E70 Offset: 0x31A7F71 VA: 0x31A7E70
	|-Notification<object>.op_Equality
	|
	|-RVA: 0x31A81C0 Offset: 0x31A82C1 VA: 0x31A81C0
	|-Notification<Unit>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Notification<T> left, Notification<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7EA0 Offset: 0x31A7FA1 VA: 0x31A7EA0
	|-Notification<object>.op_Inequality
	|
	|-RVA: 0x31A81F0 Offset: 0x31A82F1 VA: 0x31A81F0
	|-Notification<Unit>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7F30 Offset: 0x31A8031 VA: 0x31A7F30
	|-Notification<object>.Equals
	|
	|-RVA: 0x31A8280 Offset: 0x31A8381 VA: 0x31A8280
	|-Notification<Unit>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Accept(IObserver<T> observer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract TResult Accept<TResult>(IObserver<T, TResult> observer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.Accept<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract TResult Accept<TResult>(Func<T, TResult> onNext, Func<Exception, TResult> onError, Func<TResult> onCompleted);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Notification<object>.Accept<object>
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> ToObservable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7F90 Offset: 0x31A8091 VA: 0x31A7F90
	|-Notification<object>.ToObservable
	|
	|-RVA: 0x31A82E0 Offset: 0x31A83E1 VA: 0x31A82E0
	|-Notification<Unit>.ToObservable
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> ToObservable(IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A8020 Offset: 0x31A8121 VA: 0x31A8020
	|-Notification<object>.ToObservable
	|
	|-RVA: 0x31A8370 Offset: 0x31A8471 VA: 0x31A8370
	|-Notification<Unit>.ToObservable
	*/
}

