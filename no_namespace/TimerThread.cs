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
private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 2500
{
	// Fields
	private readonly TimerThread.TimerNode m_Timers; // 0x18

	// Methods

	// RVA: 0x1923540 Offset: 0x1923641 VA: 0x1923540
	internal void .ctor(int durationMilliseconds) { }
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

