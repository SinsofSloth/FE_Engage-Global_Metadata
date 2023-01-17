// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4736B0 Offset: 0x4737B1 VA: 0x4736B0
public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 807
{
	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x3B71B70 Offset: 0x3B71C71 VA: 0x3B71B70
	public void .ctor() { }

	// RVA: 0x3B71C70 Offset: 0x3B71D71 VA: 0x3B71C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3B71C80 Offset: 0x3B71D81 VA: 0x3B71C80
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x3B71C90 Offset: 0x3B71D91 VA: 0x3B71C90
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContractAttribute] // RVA: 0x47CC70 Offset: 0x47CD71 VA: 0x47CC70
	// RVA: 0x3B71E80 Offset: 0x3B71F81 VA: 0x3B71E80
	public void ReleaseWriterLock() { }

	// RVA: 0x3B72000 Offset: 0x3B72101 VA: 0x3B72000
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x3B71E30 Offset: 0x3B71F31 VA: 0x3B71E30
	private bool HasWriterLock() { }
}

