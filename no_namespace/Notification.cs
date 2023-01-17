// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x12C40 Offset: 0x12D41 VA: 0x12C40
[Serializable]
internal sealed class Notification.OnNextNotification<T> : Notification<T> // TypeDefIndex: 6551
{
	// Fields
	private T value; // 0x0

	// Properties
	public override T Value { get; }
	public override Exception Exception { get; }
	public override bool HasValue { get; }
	public override NotificationKind Kind { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715B10 Offset: 0x3715C11 VA: 0x3715B10
	|-Notification.OnNextNotification<object>..ctor
	|
	|-RVA: 0x3715F50 Offset: 0x3716051 VA: 0x3715F50
	|-Notification.OnNextNotification<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715B50 Offset: 0x3715C51 VA: 0x3715B50
	|-Notification.OnNextNotification<object>.get_Value
	|
	|-RVA: 0x3715F90 Offset: 0x3716091 VA: 0x3715F90
	|-Notification.OnNextNotification<Unit>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Exception get_Exception() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715B60 Offset: 0x3715C61 VA: 0x3715B60
	|-Notification.OnNextNotification<object>.get_Exception
	|
	|-RVA: 0x3715FA0 Offset: 0x37160A1 VA: 0x3715FA0
	|-Notification.OnNextNotification<Unit>.get_Exception
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715B70 Offset: 0x3715C71 VA: 0x3715B70
	|-Notification.OnNextNotification<object>.get_HasValue
	|
	|-RVA: 0x3715FB0 Offset: 0x37160B1 VA: 0x3715FB0
	|-Notification.OnNextNotification<Unit>.get_HasValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override NotificationKind get_Kind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715B80 Offset: 0x3715C81 VA: 0x3715B80
	|-Notification.OnNextNotification<object>.get_Kind
	|
	|-RVA: 0x3715FC0 Offset: 0x37160C1 VA: 0x3715FC0
	|-Notification.OnNextNotification<Unit>.get_Kind
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715B90 Offset: 0x3715C91 VA: 0x3715B90
	|-Notification.OnNextNotification<object>.GetHashCode
	|
	|-RVA: 0x3715FD0 Offset: 0x37160D1 VA: 0x3715FD0
	|-Notification.OnNextNotification<Unit>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override bool Equals(Notification<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715BF0 Offset: 0x3715CF1 VA: 0x3715BF0
	|-Notification.OnNextNotification<object>.Equals
	|
	|-RVA: 0x3716030 Offset: 0x3716131 VA: 0x3716030
	|-Notification.OnNextNotification<Unit>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715CC0 Offset: 0x3715DC1 VA: 0x3715CC0
	|-Notification.OnNextNotification<object>.ToString
	|
	|-RVA: 0x3716100 Offset: 0x3716201 VA: 0x3716100
	|-Notification.OnNextNotification<Unit>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void Accept(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715D70 Offset: 0x3715E71 VA: 0x3715D70
	|-Notification.OnNextNotification<object>.Accept
	|
	|-RVA: 0x37161E0 Offset: 0x37162E1 VA: 0x37161E0
	|-Notification.OnNextNotification<Unit>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override TResult Accept<TResult>(IObserver<T, TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553A70 Offset: 0x2553B71 VA: 0x2553A70
	|-Notification.OnNextNotification<object>.Accept<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3715E70 Offset: 0x3715F71 VA: 0x3715E70
	|-Notification.OnNextNotification<object>.Accept
	|
	|-RVA: 0x37162E0 Offset: 0x37163E1 VA: 0x37162E0
	|-Notification.OnNextNotification<Unit>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override TResult Accept<TResult>(Func<T, TResult> onNext, Func<Exception, TResult> onError, Func<TResult> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553B70 Offset: 0x2553C71 VA: 0x2553B70
	|-Notification.OnNextNotification<object>.Accept<object>
	*/
}

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
[DebuggerDisplayAttribute] // RVA: 0x12CC0 Offset: 0x12DC1 VA: 0x12CC0
[Serializable]
internal sealed class Notification.OnCompletedNotification<T> : Notification<T> // TypeDefIndex: 6553
{
	// Properties
	public override T Value { get; }
	public override Exception Exception { get; }
	public override bool HasValue { get; }
	public override NotificationKind Kind { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714B70 Offset: 0x3714C71 VA: 0x3714B70
	|-Notification.OnCompletedNotification<object>..ctor
	|
	|-RVA: 0x3714EF0 Offset: 0x3714FF1 VA: 0x3714EF0
	|-Notification.OnCompletedNotification<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714B90 Offset: 0x3714C91 VA: 0x3714B90
	|-Notification.OnCompletedNotification<object>.get_Value
	|
	|-RVA: 0x3714F10 Offset: 0x3715011 VA: 0x3714F10
	|-Notification.OnCompletedNotification<Unit>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Exception get_Exception() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714BF0 Offset: 0x3714CF1 VA: 0x3714BF0
	|-Notification.OnCompletedNotification<object>.get_Exception
	|
	|-RVA: 0x3714F70 Offset: 0x3715071 VA: 0x3714F70
	|-Notification.OnCompletedNotification<Unit>.get_Exception
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714C00 Offset: 0x3714D01 VA: 0x3714C00
	|-Notification.OnCompletedNotification<object>.get_HasValue
	|
	|-RVA: 0x3714F80 Offset: 0x3715081 VA: 0x3714F80
	|-Notification.OnCompletedNotification<Unit>.get_HasValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override NotificationKind get_Kind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714C10 Offset: 0x3714D11 VA: 0x3714C10
	|-Notification.OnCompletedNotification<object>.get_Kind
	|
	|-RVA: 0x3714F90 Offset: 0x3715091 VA: 0x3714F90
	|-Notification.OnCompletedNotification<Unit>.get_Kind
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714C20 Offset: 0x3714D21 VA: 0x3714C20
	|-Notification.OnCompletedNotification<object>.GetHashCode
	|
	|-RVA: 0x3714FA0 Offset: 0x37150A1 VA: 0x3714FA0
	|-Notification.OnCompletedNotification<Unit>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override bool Equals(Notification<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714CB0 Offset: 0x3714DB1 VA: 0x3714CB0
	|-Notification.OnCompletedNotification<object>.Equals
	|
	|-RVA: 0x3715030 Offset: 0x3715131 VA: 0x3715030
	|-Notification.OnCompletedNotification<Unit>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714D00 Offset: 0x3714E01 VA: 0x3714D00
	|-Notification.OnCompletedNotification<object>.ToString
	|
	|-RVA: 0x3715080 Offset: 0x3715181 VA: 0x3715080
	|-Notification.OnCompletedNotification<Unit>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void Accept(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714D50 Offset: 0x3714E51 VA: 0x3714D50
	|-Notification.OnCompletedNotification<object>.Accept
	|
	|-RVA: 0x37150D0 Offset: 0x37151D1 VA: 0x37150D0
	|-Notification.OnCompletedNotification<Unit>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override TResult Accept<TResult>(IObserver<T, TResult> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25536F0 Offset: 0x25537F1 VA: 0x25536F0
	|-Notification.OnCompletedNotification<object>.Accept<object>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3714E30 Offset: 0x3714F31 VA: 0x3714E30
	|-Notification.OnCompletedNotification<object>.Accept
	|
	|-RVA: 0x37151B0 Offset: 0x37152B1 VA: 0x37151B0
	|-Notification.OnCompletedNotification<Unit>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override TResult Accept<TResult>(Func<T, TResult> onNext, Func<Exception, TResult> onError, Func<TResult> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25537D0 Offset: 0x25538D1 VA: 0x25537D0
	|-Notification.OnCompletedNotification<object>.Accept<object>
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
[CompilerGeneratedAttribute] // RVA: 0x12D10 Offset: 0x12E11 VA: 0x12D10
private sealed class Notification.<>c__DisplayClass21_1<T> // TypeDefIndex: 6555
{
	// Fields
	public IObserver<T> observer; // 0x0
	public Notification.<>c__DisplayClass21_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AAD0 Offset: 0x2B3ABD1 VA: 0x2B3AAD0
	|-Notification.<>c__DisplayClass21_1<object>..ctor
	|
	|-RVA: 0x2B3ABB0 Offset: 0x2B3ACB1 VA: 0x2B3ABB0
	|-Notification.<>c__DisplayClass21_1<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ToObservable>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3AAE0 Offset: 0x2B3ABE1 VA: 0x2B3AAE0
	|-Notification.<>c__DisplayClass21_1<object>.<ToObservable>b__1
	|
	|-RVA: 0x2B3ABC0 Offset: 0x2B3ACC1 VA: 0x2B3ABC0
	|-Notification.<>c__DisplayClass21_1<Unit>.<ToObservable>b__1
	*/
}

// Namespace: 
public enum Notification.Message // TypeDefIndex: 7539
{
	// Fields
	public int value__; // 0x0
	public const Notification.Message FocusStateChanged = 15;
	public const Notification.Message Resume = 16;
	public const Notification.Message OperationModeChanged = 30;
	public const Notification.Message PerformanceModeChanged = 31;
	public const Notification.Message ExitRequest = 4;
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

// Namespace: 
public enum Notification.FocusHandlingMode // TypeDefIndex: 7541
{
	// Fields
	public int value__; // 0x0
	public const Notification.FocusHandlingMode Suspend = 0;
	public const Notification.FocusHandlingMode Notify = 1;
	public const Notification.FocusHandlingMode SuspendAndNotify = 2;
	public const Notification.FocusHandlingMode InFocusOnly = 3;
}

