// Namespace: 
private sealed class Timer.Scheduler // TypeDefIndex: 811
{
	// Fields
	private static Timer.Scheduler instance; // 0x0
	private SortedList list; // 0x10
	private ManualResetEvent changed; // 0x18

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x1C0B8C0 Offset: 0x1C0B9C1 VA: 0x1C0B8C0
	private static void .cctor() { }

	// RVA: 0x1C0BAA0 Offset: 0x1C0BBA1 VA: 0x1C0BAA0
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x1C0B920 Offset: 0x1C0BA21 VA: 0x1C0B920
	private void .ctor() { }

	// RVA: 0x1C0BB20 Offset: 0x1C0BC21 VA: 0x1C0BB20
	public void Remove(Timer timer) { }

	// RVA: 0x1C0BCA0 Offset: 0x1C0BDA1 VA: 0x1C0BCA0
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x1C0BFA0 Offset: 0x1C0C0A1 VA: 0x1C0BFA0
	private int FindByDueTime(long nr) { }

	// RVA: 0x1C0BE30 Offset: 0x1C0BF31 VA: 0x1C0BE30
	private void Add(Timer timer) { }

	// RVA: 0x1C0BC40 Offset: 0x1C0BD41 VA: 0x1C0BC40
	private int InternalRemove(Timer timer) { }

	// RVA: 0x1C0C100 Offset: 0x1C0C201 VA: 0x1C0C100
	private static void TimerCB(object o) { }

	// RVA: 0x1C0C170 Offset: 0x1C0C271 VA: 0x1C0C170
	private void SchedulerThread() { }

	// RVA: 0x1C0C740 Offset: 0x1C0C841 VA: 0x1C0C740
	private void ShrinkIfNeeded(List<Timer> list, int initial) { }
}

