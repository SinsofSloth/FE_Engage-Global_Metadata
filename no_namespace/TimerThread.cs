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

