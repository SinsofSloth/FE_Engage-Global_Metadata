// Namespace: 
private static class Scheduler.CurrentThreadScheduler.Trampoline // TypeDefIndex: 6595
{
	// Methods

	// RVA: 0x1B06650 Offset: 0x1B06751 VA: 0x1B06650
	public static void Run(SchedulerQueue queue) { }
}

// Namespace: 
private class Scheduler.CurrentThreadScheduler : IScheduler // TypeDefIndex: 6596
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x13B40 Offset: 0x13C41 VA: 0x13B40
	private static SchedulerQueue s_threadLocalQueue; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x13B50 Offset: 0x13C51 VA: 0x13B50
	private static Stopwatch s_clock; // 0x80000008

	// Properties
	private static TimeSpan Time { get; }
	[EditorBrowsableAttribute] // RVA: 0x18730 Offset: 0x18831 VA: 0x18730
	public static bool IsScheduleRequired { get; }
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1B06030 Offset: 0x1B06131 VA: 0x1B06030
	private static SchedulerQueue GetQueue() { }

	// RVA: 0x1B06080 Offset: 0x1B06181 VA: 0x1B06080
	private static void SetQueue(SchedulerQueue newQueue) { }

	// RVA: 0x1B060E0 Offset: 0x1B061E1 VA: 0x1B060E0
	private static TimeSpan get_Time() { }

	// RVA: 0x1AF58E0 Offset: 0x1AF59E1 VA: 0x1AF58E0
	public static bool get_IsScheduleRequired() { }

	// RVA: 0x1B06190 Offset: 0x1B06291 VA: 0x1B06190 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B06210 Offset: 0x1B06311 VA: 0x1B06210 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B06780 Offset: 0x1B06881 VA: 0x1B06780 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1AF6BF0 Offset: 0x1AF6CF1 VA: 0x1AF6BF0
	public void .ctor() { }
}

// Namespace: 
private class Scheduler.ImmediateScheduler : IScheduler // TypeDefIndex: 6597
{
	// Properties
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1AF6C00 Offset: 0x1AF6D01 VA: 0x1AF6C00
	public void .ctor() { }

	// RVA: 0x1B08740 Offset: 0x1B08841 VA: 0x1B08740 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1B087F0 Offset: 0x1B088F1 VA: 0x1B087F0 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B08870 Offset: 0x1B08971 VA: 0x1B08870 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }
}

// Namespace: 
public static class Scheduler.DefaultSchedulers // TypeDefIndex: 6598
{
	// Fields
	private static IScheduler constantTime; // 0x0
	private static IScheduler tailRecursion; // 0x8
	private static IScheduler iteration; // 0x10
	private static IScheduler timeBasedOperations; // 0x18
	private static IScheduler asyncConversions; // 0x20

	// Properties
	public static IScheduler ConstantTimeOperations { get; set; }
	public static IScheduler TailRecursion { get; set; }
	public static IScheduler Iteration { get; set; }
	public static IScheduler TimeBasedOperations { get; set; }
	public static IScheduler AsyncConversions { get; set; }

	// Methods

	// RVA: 0x1B06830 Offset: 0x1B06931 VA: 0x1B06830
	public static IScheduler get_ConstantTimeOperations() { }

	// RVA: 0x1B06900 Offset: 0x1B06A01 VA: 0x1B06900
	public static void set_ConstantTimeOperations(IScheduler value) { }

	// RVA: 0x1B06960 Offset: 0x1B06A61 VA: 0x1B06960
	public static IScheduler get_TailRecursion() { }

	// RVA: 0x1B06A30 Offset: 0x1B06B31 VA: 0x1B06A30
	public static void set_TailRecursion(IScheduler value) { }

	// RVA: 0x1B06A90 Offset: 0x1B06B91 VA: 0x1B06A90
	public static IScheduler get_Iteration() { }

	// RVA: 0x1B06B60 Offset: 0x1B06C61 VA: 0x1B06B60
	public static void set_Iteration(IScheduler value) { }

	// RVA: 0x1B06BC0 Offset: 0x1B06CC1 VA: 0x1B06BC0
	public static IScheduler get_TimeBasedOperations() { }

	// RVA: 0x1B06C80 Offset: 0x1B06D81 VA: 0x1B06C80
	public static void set_TimeBasedOperations(IScheduler value) { }

	// RVA: 0x1B06CE0 Offset: 0x1B06DE1 VA: 0x1B06CE0
	public static IScheduler get_AsyncConversions() { }

	// RVA: 0x1B06DB0 Offset: 0x1B06EB1 VA: 0x1B06DB0
	public static void set_AsyncConversions(IScheduler value) { }

	// RVA: 0x1B06E10 Offset: 0x1B06F11 VA: 0x1B06E10
	public static void SetDotNetCompatible() { }
}

// Namespace: 
private sealed class Scheduler.ThreadPoolScheduler.Timer : IDisposable // TypeDefIndex: 6599
{
	// Fields
	private static readonly HashSet<Timer> s_timers; // 0x0
	private readonly SingleAssignmentDisposable _disposable; // 0x10
	private Action _action; // 0x18
	private Timer _timer; // 0x20
	private bool _hasAdded; // 0x28
	private bool _hasRemoved; // 0x29

	// Methods

	// RVA: 0x1B095E0 Offset: 0x1B096E1 VA: 0x1B095E0
	public void .ctor(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B0E4E0 Offset: 0x1B0E5E1 VA: 0x1B0E4E0
	private void Tick(object state) { }

	// RVA: 0x1B0E560 Offset: 0x1B0E661 VA: 0x1B0E560
	private void Unroot() { }

	// RVA: 0x1B0E750 Offset: 0x1B0E851 VA: 0x1B0E750 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B0E760 Offset: 0x1B0E861 VA: 0x1B0E760
	private static void .cctor() { }
}

// Namespace: 
private sealed class Scheduler.ThreadPoolScheduler.PeriodicTimer : IDisposable // TypeDefIndex: 6600
{
	// Fields
	private static readonly HashSet<Timer> s_timers; // 0x0
	private Action _action; // 0x10
	private Timer _timer; // 0x18
	private readonly AsyncLock _gate; // 0x20

	// Methods

	// RVA: 0x1B099E0 Offset: 0x1B09AE1 VA: 0x1B099E0
	public void .ctor(TimeSpan period, Action action) { }

	// RVA: 0x1B0E1C0 Offset: 0x1B0E2C1 VA: 0x1B0E1C0
	private void Tick(object state) { }

	// RVA: 0x1B0E250 Offset: 0x1B0E351 VA: 0x1B0E250 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B0E430 Offset: 0x1B0E531 VA: 0x1B0E430
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x15940 Offset: 0x15A41 VA: 0x15940
	// RVA: 0x1B0E4D0 Offset: 0x1B0E5D1 VA: 0x1B0E4D0
	private void <Tick>b__5_0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12DD0 Offset: 0x12ED1 VA: 0x12DD0
private sealed class Scheduler.ThreadPoolScheduler.<>c__DisplayClass3_0 // TypeDefIndex: 6601
{
	// Fields
	public BooleanDisposable d; // 0x10
	public Action action; // 0x18

	// Methods

	// RVA: 0x1B09400 Offset: 0x1B09501 VA: 0x1B09400
	public void .ctor() { }

	// RVA: 0x1B0E1A0 Offset: 0x1B0E2A1 VA: 0x1B0E1A0
	internal void <Schedule>b__0(object _) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12DE0 Offset: 0x12EE1 VA: 0x12DE0
private sealed class Scheduler.ThreadPoolScheduler.<>c__DisplayClass7_0<T> // TypeDefIndex: 6602
{
	// Fields
	public ICancelable cancel; // 0x0
	public Action<T> action; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B40120 Offset: 0x2B40221 VA: 0x2B40120
	|-Scheduler.ThreadPoolScheduler.<>c__DisplayClass7_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ScheduleQueueing>b__0(object callBackState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B40130 Offset: 0x2B40231 VA: 0x2B40130
	|-Scheduler.ThreadPoolScheduler.<>c__DisplayClass7_0<object>.<ScheduleQueueing>b__0
	*/
}

// Namespace: 
private class Scheduler.ThreadPoolScheduler : IScheduler, ISchedulerPeriodic // TypeDefIndex: 6603
{
	// Properties
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1AF6C10 Offset: 0x1AF6D11 VA: 0x1AF6C10
	public void .ctor() { }

	// RVA: 0x1B09240 Offset: 0x1B09341 VA: 0x1B09240 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1B092F0 Offset: 0x1B093F1 VA: 0x1B092F0 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B09410 Offset: 0x1B09511 VA: 0x1B09410
	public IDisposable Schedule(DateTimeOffset dueTime, Action action) { }

	// RVA: 0x1B09570 Offset: 0x1B09671 VA: 0x1B09570 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B09970 Offset: 0x1B09A71 VA: 0x1B09970 Slot: 7
	public IDisposable SchedulePeriodic(TimeSpan period, Action action) { }

	// RVA: -1 Offset: -1
	public void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A7D0 Offset: 0x388A8D1 VA: 0x388A7D0
	|-Scheduler.ThreadPoolScheduler.ScheduleQueueing<object>
	*/
}

// Namespace: 
private static class Scheduler.MainThreadScheduler.QueuedAction<T> // TypeDefIndex: 6604
{
	// Fields
	public static readonly Action<object> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static void Invoke(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8C540 Offset: 0x2A8C641 VA: 0x2A8C540
	|-Scheduler.MainThreadScheduler.QueuedAction<object>.Invoke
	|
	|-RVA: 0x2A8CC00 Offset: 0x2A8CD01 VA: 0x2A8CC00
	|-Scheduler.MainThreadScheduler.QueuedAction<Unit>.Invoke
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8C7D0 Offset: 0x2A8C8D1 VA: 0x2A8C7D0
	|-Scheduler.MainThreadScheduler.QueuedAction<object>..cctor
	|
	|-RVA: 0x2A8CE90 Offset: 0x2A8CF91 VA: 0x2A8CE90
	|-Scheduler.MainThreadScheduler.QueuedAction<Unit>..cctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12DF0 Offset: 0x12EF1 VA: 0x12DF0
private sealed class Scheduler.MainThreadScheduler.<DelayAction>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6605
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan dueTime; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15A30 Offset: 0x15B31 VA: 0x15A30
	// RVA: 0x1B08A50 Offset: 0x1B08B51 VA: 0x1B08A50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15A40 Offset: 0x15B41 VA: 0x15A40
	// RVA: 0x1B0DC00 Offset: 0x1B0DD01 VA: 0x1B0DC00 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0DC10 Offset: 0x1B0DD11 VA: 0x1B0DC10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15A50 Offset: 0x15B51 VA: 0x15A50
	// RVA: 0x1B0DE00 Offset: 0x1B0DF01 VA: 0x1B0DE00 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15A60 Offset: 0x15B61 VA: 0x15A60
	// RVA: 0x1B0DE10 Offset: 0x1B0DF11 VA: 0x1B0DE10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15A70 Offset: 0x15B71 VA: 0x15A70
	// RVA: 0x1B0DE50 Offset: 0x1B0DF51 VA: 0x1B0DE50 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E00 Offset: 0x12F01 VA: 0x12E00
private sealed class Scheduler.MainThreadScheduler.<PeriodicAction>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6606
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan period; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private WaitForSeconds <yieldInstruction>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15A80 Offset: 0x15B81 VA: 0x15A80
	// RVA: 0x1B08B20 Offset: 0x1B08C21 VA: 0x1B08B20
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15A90 Offset: 0x15B91 VA: 0x15A90
	// RVA: 0x1B0DE60 Offset: 0x1B0DF61 VA: 0x1B0DE60 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0DE70 Offset: 0x1B0DF71 VA: 0x1B0DE70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15AA0 Offset: 0x15BA1 VA: 0x15AA0
	// RVA: 0x1B0E140 Offset: 0x1B0E241 VA: 0x1B0E140 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15AB0 Offset: 0x15BB1 VA: 0x15AB0
	// RVA: 0x1B0E150 Offset: 0x1B0E251 VA: 0x1B0E150 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15AC0 Offset: 0x15BC1 VA: 0x15AC0
	// RVA: 0x1B0E190 Offset: 0x1B0E291 VA: 0x1B0E190 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class Scheduler.MainThreadScheduler : IScheduler, ISchedulerPeriodic, ISchedulerQueueing // TypeDefIndex: 6607
{
	// Fields
	private readonly Action<object> scheduleAction; // 0x10

	// Properties
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1AF64D0 Offset: 0x1AF65D1 VA: 0x1AF64D0
	public void .ctor() { }

	[IteratorStateMachineAttribute] // RVA: 0x15950 Offset: 0x15A51 VA: 0x15950
	// RVA: 0x1B089B0 Offset: 0x1B08AB1 VA: 0x1B089B0
	private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation) { }

	[IteratorStateMachineAttribute] // RVA: 0x159C0 Offset: 0x15AC1 VA: 0x159C0
	// RVA: 0x1B08A80 Offset: 0x1B08B81 VA: 0x1B08A80
	private IEnumerator PeriodicAction(TimeSpan period, Action action, ICancelable cancellation) { }

	// RVA: 0x1B08B50 Offset: 0x1B08C51 VA: 0x1B08B50 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1B08C00 Offset: 0x1B08D01 VA: 0x1B08C00
	private void Schedule(object state) { }

	// RVA: 0x1B08CC0 Offset: 0x1B08DC1 VA: 0x1B08CC0 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B08DA0 Offset: 0x1B08EA1 VA: 0x1B08DA0
	public IDisposable Schedule(DateTimeOffset dueTime, Action action) { }

	// RVA: 0x1B08EC0 Offset: 0x1B08FC1 VA: 0x1B08EC0 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B09080 Offset: 0x1B09181 VA: 0x1B09080 Slot: 7
	public IDisposable SchedulePeriodic(TimeSpan period, Action action) { }

	// RVA: -1 Offset: -1
	private void ScheduleQueueing<T>(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A3D0 Offset: 0x388A4D1 VA: 0x388A3D0
	|-Scheduler.MainThreadScheduler.ScheduleQueueing<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A550 Offset: 0x388A651 VA: 0x388A550
	|-Scheduler.MainThreadScheduler.ScheduleQueueing<object>
	|
	|-RVA: 0x388A690 Offset: 0x388A791 VA: 0x388A690
	|-Scheduler.MainThreadScheduler.ScheduleQueueing<Unit>
	*/
}

// Namespace: 
private static class Scheduler.IgnoreTimeScaleMainThreadScheduler.QueuedAction<T> // TypeDefIndex: 6608
{
	// Fields
	public static readonly Action<object> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static void Invoke(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8C1E0 Offset: 0x2A8C2E1 VA: 0x2A8C1E0
	|-Scheduler.IgnoreTimeScaleMainThreadScheduler.QueuedAction<object>.Invoke
	|
	|-RVA: 0x2A8C8A0 Offset: 0x2A8C9A1 VA: 0x2A8C8A0
	|-Scheduler.IgnoreTimeScaleMainThreadScheduler.QueuedAction<Unit>.Invoke
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8C470 Offset: 0x2A8C571 VA: 0x2A8C470
	|-Scheduler.IgnoreTimeScaleMainThreadScheduler.QueuedAction<object>..cctor
	|
	|-RVA: 0x2A8CB30 Offset: 0x2A8CC31 VA: 0x2A8CB30
	|-Scheduler.IgnoreTimeScaleMainThreadScheduler.QueuedAction<Unit>..cctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E10 Offset: 0x12F11 VA: 0x12E10
private sealed class Scheduler.IgnoreTimeScaleMainThreadScheduler.<DelayAction>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6609
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan dueTime; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private float <elapsed>5__2; // 0x38
	private float <dt>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15BB0 Offset: 0x15CB1 VA: 0x15BB0
	// RVA: 0x1B07F50 Offset: 0x1B08051 VA: 0x1B07F50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15BC0 Offset: 0x15CC1 VA: 0x15BC0
	// RVA: 0x1B0D610 Offset: 0x1B0D711 VA: 0x1B0D610 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0D620 Offset: 0x1B0D721 VA: 0x1B0D620 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15BD0 Offset: 0x15CD1 VA: 0x15BD0
	// RVA: 0x1B0D880 Offset: 0x1B0D981 VA: 0x1B0D880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15BE0 Offset: 0x15CE1 VA: 0x15BE0
	// RVA: 0x1B0D890 Offset: 0x1B0D991 VA: 0x1B0D890 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15BF0 Offset: 0x15CF1 VA: 0x15BF0
	// RVA: 0x1B0D8D0 Offset: 0x1B0D9D1 VA: 0x1B0D8D0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E20 Offset: 0x12F21 VA: 0x12E20
private sealed class Scheduler.IgnoreTimeScaleMainThreadScheduler.<PeriodicAction>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6610
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan period; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private float <elapsed>5__2; // 0x38
	private float <dt>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15C00 Offset: 0x15D01 VA: 0x15C00
	// RVA: 0x1B08020 Offset: 0x1B08121 VA: 0x1B08020
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15C10 Offset: 0x15D11 VA: 0x15C10
	// RVA: 0x1B0D8E0 Offset: 0x1B0D9E1 VA: 0x1B0D8E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0D8F0 Offset: 0x1B0D9F1 VA: 0x1B0D8F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15C20 Offset: 0x15D21 VA: 0x15C20
	// RVA: 0x1B0DBA0 Offset: 0x1B0DCA1 VA: 0x1B0DBA0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15C30 Offset: 0x15D31 VA: 0x15C30
	// RVA: 0x1B0DBB0 Offset: 0x1B0DCB1 VA: 0x1B0DBB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15C40 Offset: 0x15D41 VA: 0x15C40
	// RVA: 0x1B0DBF0 Offset: 0x1B0DCF1 VA: 0x1B0DBF0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class Scheduler.IgnoreTimeScaleMainThreadScheduler : IScheduler, ISchedulerPeriodic, ISchedulerQueueing // TypeDefIndex: 6611
{
	// Fields
	private readonly Action<object> scheduleAction; // 0x10

	// Properties
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1AF66A0 Offset: 0x1AF67A1 VA: 0x1AF66A0
	public void .ctor() { }

	[IteratorStateMachineAttribute] // RVA: 0x15AD0 Offset: 0x15BD1 VA: 0x15AD0
	// RVA: 0x1B07EB0 Offset: 0x1B07FB1 VA: 0x1B07EB0
	private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation) { }

	[IteratorStateMachineAttribute] // RVA: 0x15B40 Offset: 0x15C41 VA: 0x15B40
	// RVA: 0x1B07F80 Offset: 0x1B08081 VA: 0x1B07F80
	private IEnumerator PeriodicAction(TimeSpan period, Action action, ICancelable cancellation) { }

	// RVA: 0x1B08050 Offset: 0x1B08151 VA: 0x1B08050 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1B08100 Offset: 0x1B08201 VA: 0x1B08100
	private void Schedule(object state) { }

	// RVA: 0x1B081C0 Offset: 0x1B082C1 VA: 0x1B081C0 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B082A0 Offset: 0x1B083A1 VA: 0x1B082A0
	public IDisposable Schedule(DateTimeOffset dueTime, Action action) { }

	// RVA: 0x1B083C0 Offset: 0x1B084C1 VA: 0x1B083C0 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B08580 Offset: 0x1B08681 VA: 0x1B08580 Slot: 7
	public IDisposable SchedulePeriodic(TimeSpan period, Action action) { }

	// RVA: -1 Offset: -1 Slot: 8
	public void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A150 Offset: 0x388A251 VA: 0x388A150
	|-Scheduler.IgnoreTimeScaleMainThreadScheduler.ScheduleQueueing<object>
	|
	|-RVA: 0x388A290 Offset: 0x388A391 VA: 0x388A290
	|-Scheduler.IgnoreTimeScaleMainThreadScheduler.ScheduleQueueing<Unit>
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E30 Offset: 0x12F31 VA: 0x12E30
private sealed class Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6612
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public ICancelable cancellation; // 0x0
	public Action<T> action; // 0x0
	public T state; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15DA0 Offset: 0x15EA1 VA: 0x15DA0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151070 Offset: 0x3151171 VA: 0x3151070
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<object>..ctor
	|
	|-RVA: 0x3151470 Offset: 0x3151571 VA: 0x3151470
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<Unit>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15DB0 Offset: 0x15EB1 VA: 0x15DB0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31510A0 Offset: 0x31511A1 VA: 0x31510A0
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x31514A0 Offset: 0x31515A1 VA: 0x31514A0
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31510B0 Offset: 0x31511B1 VA: 0x31510B0
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<object>.MoveNext
	|
	|-RVA: 0x31514B0 Offset: 0x31515B1 VA: 0x31514B0
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<Unit>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15DC0 Offset: 0x15EC1 VA: 0x15DC0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151210 Offset: 0x3151311 VA: 0x3151210
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x3151610 Offset: 0x3151711 VA: 0x3151610
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15DD0 Offset: 0x15ED1 VA: 0x15DD0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151220 Offset: 0x3151321 VA: 0x3151220
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3151620 Offset: 0x3151721 VA: 0x3151620
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15DE0 Offset: 0x15EE1 VA: 0x15DE0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151260 Offset: 0x3151361 VA: 0x3151260
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3151660 Offset: 0x3151761 VA: 0x3151660
	|-Scheduler.FixedUpdateMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E40 Offset: 0x12F41 VA: 0x12E40
private sealed class Scheduler.FixedUpdateMainThreadScheduler.<DelayAction>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6613
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan dueTime; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private float <startTime>5__2; // 0x38
	private float <dt>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15DF0 Offset: 0x15EF1 VA: 0x15DF0
	// RVA: 0x1B077E0 Offset: 0x1B078E1 VA: 0x1B077E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15E00 Offset: 0x15F01 VA: 0x15E00
	// RVA: 0x1B0D010 Offset: 0x1B0D111 VA: 0x1B0D010 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0D020 Offset: 0x1B0D121 VA: 0x1B0D020 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15E10 Offset: 0x15F11 VA: 0x15E10
	// RVA: 0x1B0D290 Offset: 0x1B0D391 VA: 0x1B0D290 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15E20 Offset: 0x15F21 VA: 0x15E20
	// RVA: 0x1B0D2A0 Offset: 0x1B0D3A1 VA: 0x1B0D2A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15E30 Offset: 0x15F31 VA: 0x15E30
	// RVA: 0x1B0D2E0 Offset: 0x1B0D3E1 VA: 0x1B0D2E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E50 Offset: 0x12F51 VA: 0x12E50
private sealed class Scheduler.FixedUpdateMainThreadScheduler.<PeriodicAction>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6614
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan period; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private float <startTime>5__2; // 0x38
	private float <dt>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15E40 Offset: 0x15F41 VA: 0x15E40
	// RVA: 0x1B078B0 Offset: 0x1B079B1 VA: 0x1B078B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x15E50 Offset: 0x15F51 VA: 0x15E50
	// RVA: 0x1B0D2F0 Offset: 0x1B0D3F1 VA: 0x1B0D2F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0D300 Offset: 0x1B0D401 VA: 0x1B0D300 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x15E60 Offset: 0x15F61 VA: 0x15E60
	// RVA: 0x1B0D5B0 Offset: 0x1B0D6B1 VA: 0x1B0D5B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x15E70 Offset: 0x15F71 VA: 0x15E70
	// RVA: 0x1B0D5C0 Offset: 0x1B0D6C1 VA: 0x1B0D5C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x15E80 Offset: 0x15F81 VA: 0x15E80
	// RVA: 0x1B0D600 Offset: 0x1B0D701 VA: 0x1B0D600 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class Scheduler.FixedUpdateMainThreadScheduler : IScheduler, ISchedulerPeriodic, ISchedulerQueueing // TypeDefIndex: 6615
{
	// Properties
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1AF68C0 Offset: 0x1AF69C1 VA: 0x1AF68C0
	public void .ctor() { }

	[IteratorStateMachineAttribute] // RVA: 0x15C50 Offset: 0x15D51 VA: 0x15C50
	// RVA: -1 Offset: -1
	private IEnumerator ImmediateAction<T>(T state, Action<T> action, ICancelable cancellation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3889EA0 Offset: 0x3889FA1 VA: 0x3889EA0
	|-Scheduler.FixedUpdateMainThreadScheduler.ImmediateAction<object>
	|
	|-RVA: 0x3889F50 Offset: 0x388A051 VA: 0x3889F50
	|-Scheduler.FixedUpdateMainThreadScheduler.ImmediateAction<Unit>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x15CC0 Offset: 0x15DC1 VA: 0x15CC0
	// RVA: 0x1B07740 Offset: 0x1B07841 VA: 0x1B07740
	private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation) { }

	[IteratorStateMachineAttribute] // RVA: 0x15D30 Offset: 0x15E31 VA: 0x15D30
	// RVA: 0x1B07810 Offset: 0x1B07911 VA: 0x1B07810
	private IEnumerator PeriodicAction(TimeSpan period, Action action, ICancelable cancellation) { }

	// RVA: 0x1B078E0 Offset: 0x1B079E1 VA: 0x1B078E0 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1B07990 Offset: 0x1B07A91 VA: 0x1B07990 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B07BD0 Offset: 0x1B07CD1 VA: 0x1B07BD0
	public IDisposable Schedule(DateTimeOffset dueTime, Action action) { }

	// RVA: 0x1B07A10 Offset: 0x1B07B11 VA: 0x1B07A10 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B07CF0 Offset: 0x1B07DF1 VA: 0x1B07CF0 Slot: 7
	public IDisposable SchedulePeriodic(TimeSpan period, Action action) { }

	// RVA: -1 Offset: -1 Slot: 8
	public void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3889FF0 Offset: 0x388A0F1 VA: 0x3889FF0
	|-Scheduler.FixedUpdateMainThreadScheduler.ScheduleQueueing<object>
	|
	|-RVA: 0x388A0A0 Offset: 0x388A1A1 VA: 0x388A0A0
	|-Scheduler.FixedUpdateMainThreadScheduler.ScheduleQueueing<Unit>
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E60 Offset: 0x12F61 VA: 0x12E60
private sealed class Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6616
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public ICancelable cancellation; // 0x0
	public Action<T> action; // 0x0
	public T state; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x15FE0 Offset: 0x160E1 VA: 0x15FE0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150E70 Offset: 0x3150F71 VA: 0x3150E70
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<object>..ctor
	|
	|-RVA: 0x3151270 Offset: 0x3151371 VA: 0x3151270
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<Unit>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x15FF0 Offset: 0x160F1 VA: 0x15FF0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150EA0 Offset: 0x3150FA1 VA: 0x3150EA0
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x31512A0 Offset: 0x31513A1 VA: 0x31512A0
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150EB0 Offset: 0x3150FB1 VA: 0x3150EB0
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<object>.MoveNext
	|
	|-RVA: 0x31512B0 Offset: 0x31513B1 VA: 0x31512B0
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<Unit>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16000 Offset: 0x16101 VA: 0x16000
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151010 Offset: 0x3151111 VA: 0x3151010
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x3151410 Offset: 0x3151511 VA: 0x3151410
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16010 Offset: 0x16111 VA: 0x16010
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151020 Offset: 0x3151121 VA: 0x3151020
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3151420 Offset: 0x3151521 VA: 0x3151420
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x16020 Offset: 0x16121 VA: 0x16020
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151060 Offset: 0x3151161 VA: 0x3151060
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3151460 Offset: 0x3151561 VA: 0x3151460
	|-Scheduler.EndOfFrameMainThreadScheduler.<ImmediateAction>d__1<Unit>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E70 Offset: 0x12F71 VA: 0x12E70
private sealed class Scheduler.EndOfFrameMainThreadScheduler.<DelayAction>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6617
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan dueTime; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private float <elapsed>5__2; // 0x38
	private float <dt>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x16030 Offset: 0x16131 VA: 0x16030
	// RVA: 0x1B07070 Offset: 0x1B07171 VA: 0x1B07070
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x16040 Offset: 0x16141 VA: 0x16040
	// RVA: 0x1B0CA20 Offset: 0x1B0CB21 VA: 0x1B0CA20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0CA30 Offset: 0x1B0CB31 VA: 0x1B0CA30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x16050 Offset: 0x16151 VA: 0x16050
	// RVA: 0x1B0CC90 Offset: 0x1B0CD91 VA: 0x1B0CC90 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x16060 Offset: 0x16161 VA: 0x16060
	// RVA: 0x1B0CCA0 Offset: 0x1B0CDA1 VA: 0x1B0CCA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x16070 Offset: 0x16171 VA: 0x16070
	// RVA: 0x1B0CCE0 Offset: 0x1B0CDE1 VA: 0x1B0CCE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E80 Offset: 0x12F81 VA: 0x12E80
private sealed class Scheduler.EndOfFrameMainThreadScheduler.<PeriodicAction>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6618
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimeSpan period; // 0x20
	public ICancelable cancellation; // 0x28
	public Action action; // 0x30
	private float <elapsed>5__2; // 0x38
	private float <dt>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x16080 Offset: 0x16181 VA: 0x16080
	// RVA: 0x1B07140 Offset: 0x1B07241 VA: 0x1B07140
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x16090 Offset: 0x16191 VA: 0x16090
	// RVA: 0x1B0CCF0 Offset: 0x1B0CDF1 VA: 0x1B0CCF0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B0CD00 Offset: 0x1B0CE01 VA: 0x1B0CD00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x160A0 Offset: 0x161A1 VA: 0x160A0
	// RVA: 0x1B0CFB0 Offset: 0x1B0D0B1 VA: 0x1B0CFB0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x160B0 Offset: 0x161B1 VA: 0x160B0
	// RVA: 0x1B0CFC0 Offset: 0x1B0D0C1 VA: 0x1B0CFC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x160C0 Offset: 0x161C1 VA: 0x160C0
	// RVA: 0x1B0D000 Offset: 0x1B0D101 VA: 0x1B0D000 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class Scheduler.EndOfFrameMainThreadScheduler : IScheduler, ISchedulerPeriodic, ISchedulerQueueing // TypeDefIndex: 6619
{
	// Properties
	public DateTimeOffset Now { get; }

	// Methods

	// RVA: 0x1AF6A70 Offset: 0x1AF6B71 VA: 0x1AF6A70
	public void .ctor() { }

	[IteratorStateMachineAttribute] // RVA: 0x15E90 Offset: 0x15F91 VA: 0x15E90
	// RVA: -1 Offset: -1
	private IEnumerator ImmediateAction<T>(T state, Action<T> action, ICancelable cancellation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3889BF0 Offset: 0x3889CF1 VA: 0x3889BF0
	|-Scheduler.EndOfFrameMainThreadScheduler.ImmediateAction<object>
	|
	|-RVA: 0x3889CA0 Offset: 0x3889DA1 VA: 0x3889CA0
	|-Scheduler.EndOfFrameMainThreadScheduler.ImmediateAction<Unit>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x15F00 Offset: 0x16001 VA: 0x15F00
	// RVA: 0x1B06FD0 Offset: 0x1B070D1 VA: 0x1B06FD0
	private IEnumerator DelayAction(TimeSpan dueTime, Action action, ICancelable cancellation) { }

	[IteratorStateMachineAttribute] // RVA: 0x15F70 Offset: 0x16071 VA: 0x15F70
	// RVA: 0x1B070A0 Offset: 0x1B071A1 VA: 0x1B070A0
	private IEnumerator PeriodicAction(TimeSpan period, Action action, ICancelable cancellation) { }

	// RVA: 0x1B07170 Offset: 0x1B07271 VA: 0x1B07170 Slot: 4
	public DateTimeOffset get_Now() { }

	// RVA: 0x1B07220 Offset: 0x1B07321 VA: 0x1B07220 Slot: 5
	public IDisposable Schedule(Action action) { }

	// RVA: 0x1B07460 Offset: 0x1B07561 VA: 0x1B07460
	public IDisposable Schedule(DateTimeOffset dueTime, Action action) { }

	// RVA: 0x1B072A0 Offset: 0x1B073A1 VA: 0x1B072A0 Slot: 6
	public IDisposable Schedule(TimeSpan dueTime, Action action) { }

	// RVA: 0x1B07580 Offset: 0x1B07681 VA: 0x1B07580 Slot: 7
	public IDisposable SchedulePeriodic(TimeSpan period, Action action) { }

	// RVA: -1 Offset: -1 Slot: 8
	public void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3889D40 Offset: 0x3889E41 VA: 0x3889D40
	|-Scheduler.EndOfFrameMainThreadScheduler.ScheduleQueueing<object>
	|
	|-RVA: 0x3889DF0 Offset: 0x3889EF1 VA: 0x3889DF0
	|-Scheduler.EndOfFrameMainThreadScheduler.ScheduleQueueing<Unit>
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12E90 Offset: 0x12F91 VA: 0x12E90
private sealed class Scheduler.<>c__DisplayClass11_0 // TypeDefIndex: 6620
{
	// Fields
	public Action<Action> action; // 0x10
	public IScheduler scheduler; // 0x18
	public object gate; // 0x20
	public CompositeDisposable group; // 0x28
	public Action recursiveAction; // 0x30
	public Action <>9__1; // 0x38

	// Methods

	// RVA: 0x1AF5DF0 Offset: 0x1AF5EF1 VA: 0x1AF5DF0
	public void .ctor() { }

	// RVA: 0x1B05390 Offset: 0x1B05491 VA: 0x1B05390
	internal void <Schedule>b__0() { }

	// RVA: 0x1B05460 Offset: 0x1B05561 VA: 0x1B05460
	internal void <Schedule>b__1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12EA0 Offset: 0x12FA1 VA: 0x12EA0
private sealed class Scheduler.<>c__DisplayClass11_1 // TypeDefIndex: 6621
{
	// Fields
	public bool isAdded; // 0x10
	public IDisposable d; // 0x18
	public bool isDone; // 0x20
	public Scheduler.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x1B05690 Offset: 0x1B05791 VA: 0x1B05690
	public void .ctor() { }

	// RVA: 0x1B056A0 Offset: 0x1B057A1 VA: 0x1B056A0
	internal void <Schedule>b__2() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12EB0 Offset: 0x12FB1 VA: 0x12EB0
private sealed class Scheduler.<>c__DisplayClass12_0 // TypeDefIndex: 6622
{
	// Fields
	public Action<Action<TimeSpan>> action; // 0x10
	public IScheduler scheduler; // 0x18
	public object gate; // 0x20
	public CompositeDisposable group; // 0x28
	public Action recursiveAction; // 0x30
	public Action<TimeSpan> <>9__1; // 0x38

	// Methods

	// RVA: 0x1AF6020 Offset: 0x1AF6121 VA: 0x1AF6020
	public void .ctor() { }

	// RVA: 0x1B057C0 Offset: 0x1B058C1 VA: 0x1B057C0
	internal void <Schedule>b__0() { }

	// RVA: 0x1B058A0 Offset: 0x1B059A1 VA: 0x1B058A0
	internal void <Schedule>b__1(TimeSpan dt) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12EC0 Offset: 0x12FC1 VA: 0x12EC0
private sealed class Scheduler.<>c__DisplayClass12_1 // TypeDefIndex: 6623
{
	// Fields
	public bool isAdded; // 0x10
	public IDisposable d; // 0x18
	public bool isDone; // 0x20
	public Scheduler.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x1B05AE0 Offset: 0x1B05BE1 VA: 0x1B05AE0
	public void .ctor() { }

	// RVA: 0x1B05AF0 Offset: 0x1B05BF1 VA: 0x1B05AF0
	internal void <Schedule>b__2() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12ED0 Offset: 0x12FD1 VA: 0x12ED0
private sealed class Scheduler.<>c__DisplayClass13_0 // TypeDefIndex: 6624
{
	// Fields
	public Action<Action<DateTimeOffset>> action; // 0x10
	public IScheduler scheduler; // 0x18
	public object gate; // 0x20
	public CompositeDisposable group; // 0x28
	public Action recursiveAction; // 0x30
	public Action<DateTimeOffset> <>9__1; // 0x38

	// Methods

	// RVA: 0x1AF6220 Offset: 0x1AF6321 VA: 0x1AF6220
	public void .ctor() { }

	// RVA: 0x1B05C10 Offset: 0x1B05D11 VA: 0x1B05C10
	internal void <Schedule>b__0() { }

	// RVA: 0x1B05CF0 Offset: 0x1B05DF1 VA: 0x1B05CF0
	internal void <Schedule>b__1(DateTimeOffset dt) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12EE0 Offset: 0x12FE1 VA: 0x12EE0
private sealed class Scheduler.<>c__DisplayClass13_1 // TypeDefIndex: 6625
{
	// Fields
	public bool isAdded; // 0x10
	public IDisposable d; // 0x18
	public bool isDone; // 0x20
	public Scheduler.<>c__DisplayClass13_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x1B05F00 Offset: 0x1B06001 VA: 0x1B05F00
	public void .ctor() { }

	// RVA: 0x1B05F10 Offset: 0x1B06011 VA: 0x1B05F10
	internal void <Schedule>b__2() { }
}

