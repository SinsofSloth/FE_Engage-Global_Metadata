// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextTaskScheduler : TaskScheduler // TypeDefIndex: 865
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x18
	private static SendOrPostCallback s_postCallback; // 0x0

	// Methods

	// RVA: 0x365DA90 Offset: 0x365DB91 VA: 0x365DA90
	internal void .ctor() { }

	// RVA: 0x365DC70 Offset: 0x365DD71 VA: 0x365DC70 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x365DD00 Offset: 0x365DE01 VA: 0x365DD00 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x365DDD0 Offset: 0x365DED1 VA: 0x365DDD0
	private static void PostCallback(object obj) { }

	// RVA: 0x365E040 Offset: 0x365E141 VA: 0x365E040
	private static void .cctor() { }
}

