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

