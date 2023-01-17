// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4736F0 Offset: 0x4737F1 VA: 0x4736F0
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 812
{
	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private const long MaxValue = 4294967294;

	// Methods

	// RVA: 0x1B23EC0 Offset: 0x1B23FC1 VA: 0x1B23EC0
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1B23F20 Offset: 0x1B24021 VA: 0x1B23F20
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public bool Change(int dueTime, int period) { }

	// RVA: 0x1B24320 Offset: 0x1B24421 VA: 0x1B24320
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1B243D0 Offset: 0x1B244D1 VA: 0x1B243D0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x1B24470 Offset: 0x1B24571 VA: 0x1B24470
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x1B24460 Offset: 0x1B24561 VA: 0x1B24460
	private static long GetTimeMonotonic() { }

	// RVA: 0x1B24480 Offset: 0x1B24581 VA: 0x1B24480
	private static void .cctor() { }
}

