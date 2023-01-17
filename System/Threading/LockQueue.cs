// Namespace: System.Threading
internal class LockQueue // TypeDefIndex: 803
{
	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x3420500 Offset: 0x3420601 VA: 0x3420500
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x3420540 Offset: 0x3420641 VA: 0x3420540
	public bool Wait(int timeout) { }

	// RVA: 0x34206D0 Offset: 0x34207D1 VA: 0x34206D0
	public bool get_IsEmpty() { }

	// RVA: 0x34207A0 Offset: 0x34208A1 VA: 0x34207A0
	public void Pulse() { }
}

