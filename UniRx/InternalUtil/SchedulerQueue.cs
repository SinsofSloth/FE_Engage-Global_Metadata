// Namespace: UniRx.InternalUtil
internal class SchedulerQueue // TypeDefIndex: 7244
{
	// Fields
	private readonly PriorityQueue<ScheduledItem> _queue; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1AF6C20 Offset: 0x1AF6D21 VA: 0x1AF6C20
	public void .ctor() { }

	// RVA: 0x1AF6CB0 Offset: 0x1AF6DB1 VA: 0x1AF6CB0
	public void .ctor(int capacity) { }

	// RVA: 0x1AF6D90 Offset: 0x1AF6E91 VA: 0x1AF6D90
	public int get_Count() { }

	// RVA: 0x1AF6DE0 Offset: 0x1AF6EE1 VA: 0x1AF6DE0
	public void Enqueue(ScheduledItem scheduledItem) { }

	// RVA: 0x1AF6E40 Offset: 0x1AF6F41 VA: 0x1AF6E40
	public bool Remove(ScheduledItem scheduledItem) { }

	// RVA: 0x1AF6EA0 Offset: 0x1AF6FA1 VA: 0x1AF6EA0
	public ScheduledItem Dequeue() { }

	// RVA: 0x1AF6F00 Offset: 0x1AF7001 VA: 0x1AF6F00
	public ScheduledItem Peek() { }
}

