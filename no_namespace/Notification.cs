// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x12C80 Offset: 0x12D81 VA: 0x12C80
[Serializable]
internal sealed class Notification.OnErrorNotification<T> : Notification<T> // TypeDefIndex: 6552
{
	// Fields
	private Exception exception; // 0x0

	// Properties
	public override T Value { get; }
	public override Exception Exception { get; }
	public override bool HasValue { get; }
	public override NotificationKind Kind { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715270 Offset: 0x3715371 VA: 0x3715270
	|-Notification.OnErrorNotification<object>..ctor
	|
	|-RVA: 0x37156C0 Offset: 0x37157C1 VA: 0x37156C0
	|-Notification.OnErrorNotification<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37152B0 Offset: 0x37153B1 VA: 0x37152B0
	|-Notification.OnErrorNotification<object>.get_Value
	|
	|-RVA: 0x3715700 Offset: 0x3715801 VA: 0x3715700
	|-Notification.OnErrorNotification<Unit>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Exception get_Exception() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37152F0 Offset: 0x37153F1 VA: 0x37152F0
	|-Notification.OnErrorNotification<object>.get_Exception
	|
	|-RVA: 0x3715740 Offset: 0x3715841 VA: 0x3715740
	|-Notification.OnErrorNotification<Unit>.get_Exception
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715300 Offset: 0x3715401 VA: 0x3715300
	|-Notification.OnErrorNotification<object>.get_HasValue
	|
	|-RVA: 0x3715750 Offset: 0x3715851 VA: 0x3715750
	|-Notification.OnErrorNotification<Unit>.get_HasValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override NotificationKind get_Kind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715310 Offset: 0x3715411 VA: 0x3715310
	|-Notification.OnErrorNotification<object>.get_Kind
	|
	|-RVA: 0x3715760 Offset: 0x3715861 VA: 0x3715760
	|-Notification.OnErrorNotification<Unit>.get_Kind
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715320 Offset: 0x3715421 VA: 0x3715320
	|-Notification.OnErrorNotification<object>.GetHashCode
	|
	|-RVA: 0x3715770 Offset: 0x3715871 VA: 0x3715770
	|-Notification.OnErrorNotification<Unit>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override bool Equals(Notification<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715350 Offset: 0x3715451 VA: 0x3715350
	|-Notification.OnErrorNotification<object>.Equals
	|
	|-RVA: 0x37157A0 Offset: 0x37158A1 VA: 0x37157A0
	|-Notification.OnErrorNotification<Unit>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37153F0 Offset: 0x37154F1 VA: 0x37153F0
	|-Notification.OnErrorNotification<object>.ToString
	|
	|-RVA: 0x3715840 Offset: 0x3715941 VA: 0x3715840
	|-Notification.OnErrorNotification<Unit>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void Accept(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37154B0 Offset: 0x37155B1 VA: 0x37154B0
	|-Notification.OnErrorNotification<object>.Accept
	|
	|-RVA: 0x3715900 Offset: 0x3715A01 VA: 0x3715900
	|-Notification.OnErrorNotification<Unit>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override TResult Accept<TResult>(IObserver<T, TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553890 Offset: 0x2553991 VA: 0x2553890
	|-Notification.OnErrorNotification<object>.Accept<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37155B0 Offset: 0x37156B1 VA: 0x37155B0
	|-Notification.OnErrorNotification<object>.Accept
	|
	|-RVA: 0x3715A00 Offset: 0x3715B01 VA: 0x3715A00
	|-Notification.OnErrorNotification<Unit>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override TResult Accept<TResult>(Func<T, TResult> onNext, Func<Exception, TResult> onError, Func<TResult> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553990 Offset: 0x2553A91 VA: 0x2553990
	|-Notification.OnErrorNotification<object>.Accept<object>
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12D00 Offset: 0x12E01 VA: 0x12D00
private sealed class Notification.<>c__DisplayClass21_0<T> // TypeDefIndex: 6554
{
	// Fields
	public IScheduler scheduler; // 0x0
	public Notification<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A810 Offset: 0x2B3A911 VA: 0x2B3A810
	|-Notification.<>c__DisplayClass21_0<object>..ctor
	|
	|-RVA: 0x2B3A970 Offset: 0x2B3AA71 VA: 0x2B3A970
	|-Notification.<>c__DisplayClass21_0<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IDisposable <ToObservable>b__0(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A820 Offset: 0x2B3A921 VA: 0x2B3A820
	|-Notification.<>c__DisplayClass21_0<object>.<ToObservable>b__0
	|
	|-RVA: 0x2B3A980 Offset: 0x2B3AA81 VA: 0x2B3A980
	|-Notification.<>c__DisplayClass21_0<Unit>.<ToObservable>b__0
	*/
}

// Namespace: 
public enum Notification.FocusState // TypeDefIndex: 7540
{
	// Fields
	public int value__; // 0x0
	public const Notification.FocusState InFocus = 1;
	public const Notification.FocusState OutOfFocus = 2;
	public const Notification.FocusState Background = 3;
}

