// Namespace: 
internal abstract class TimerThread.Queue // TypeDefIndex: 2497
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x19232A0 Offset: 0x19233A1 VA: 0x19232A0
	internal void .ctor(int durationMilliseconds) { }
}

// Namespace: 
internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 2498
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0x19232D0 Offset: 0x19233D1 VA: 0x19232D0
	internal void .ctor(int durationMilliseconds) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: 0x1923310 Offset: 0x1923411 VA: 0x1923310 Slot: 4
	public void Dispose() { }
}

// Namespace: 
internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 2499
{
	// Methods

	// RVA: 0x1922DF0 Offset: 0x1922EF1 VA: 0x1922DF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1922E10 Offset: 0x1922F11 VA: 0x1922E10 Slot: 13
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x19231B0 Offset: 0x19232B1 VA: 0x19231B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	// RVA: 0x1923260 Offset: 0x1923361 VA: 0x1923260 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 2500
{
	// Fields
	private readonly TimerThread.TimerNode m_Timers; // 0x18

	// Methods

	// RVA: 0x1923540 Offset: 0x1923641 VA: 0x1923540
	internal void .ctor(int durationMilliseconds) { }
}

// Namespace: 
private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 2501
{
	// Methods

	// RVA: 0x1923270 Offset: 0x1923371 VA: 0x1923270
	internal void .ctor() { }
}

// Namespace: 
private enum TimerThread.TimerNode.TimerState // TypeDefIndex: 2502
{
	// Fields
	public int value__; // 0x0
	public const TimerThread.TimerNode.TimerState Ready = 0;
	public const TimerThread.TimerNode.TimerState Fired = 1;
	public const TimerThread.TimerNode.TimerState Cancelled = 2;
	public const TimerThread.TimerNode.TimerState Sentinel = 3;
}

// Namespace: 
private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 2503
{
	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x1923320 Offset: 0x1923421 VA: 0x1923320
	internal void .ctor() { }

	// RVA: 0x1923360 Offset: 0x1923461 VA: 0x1923360
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x1923370 Offset: 0x1923471 VA: 0x1923370
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x1923380 Offset: 0x1923481 VA: 0x1923380
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x1923390 Offset: 0x1923491 VA: 0x1923390
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x19233A0 Offset: 0x19234A1 VA: 0x19233A0 Slot: 5
	internal override bool Cancel() { }
}

