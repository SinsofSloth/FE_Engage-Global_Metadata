// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3617
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x384C4A0 Offset: 0x384C5A1 VA: 0x384C4A0
	private void .ctor(int mainThreadID) { }

	// RVA: 0x384C580 Offset: 0x384C681 VA: 0x384C580
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x384C640 Offset: 0x384C741 VA: 0x384C640 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x384C970 Offset: 0x384CA71 VA: 0x384C970 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x384C980 Offset: 0x384CA81 VA: 0x384C980 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x384C990 Offset: 0x384CA91 VA: 0x384C990 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x384CAB0 Offset: 0x384CBB1 VA: 0x384CAB0 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x384CB20 Offset: 0x384CC21 VA: 0x384CB20
	private void Exec() { }

	// RVA: 0x384CD90 Offset: 0x384CE91 VA: 0x384CD90
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x450920 Offset: 0x450A21 VA: 0x450920
	// RVA: 0x384CE00 Offset: 0x384CF01 VA: 0x384CE00
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x450930 Offset: 0x450A31 VA: 0x450930
	// RVA: 0x384CE70 Offset: 0x384CF71 VA: 0x384CE70
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x450940 Offset: 0x450A41 VA: 0x450940
	// RVA: 0x384CEE0 Offset: 0x384CFE1 VA: 0x384CEE0
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}

