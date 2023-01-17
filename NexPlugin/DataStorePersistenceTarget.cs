// Namespace: NexPlugin
public class DataStorePersistenceTarget // TypeDefIndex: 14885
{
	// Fields
	internal ulong ownerId; // 0x10
	internal ushort persistenceSlotId; // 0x18

	// Methods

	// RVA: 0x2E91650 Offset: 0x2E91751 VA: 0x2E91650
	public void .ctor(ulong ownerId = 0, ushort persistenceSlotId = 65535) { }

	// RVA: 0x2E93660 Offset: 0x2E93761 VA: 0x2E93660
	public void SetOwnerId(ulong ownerId_) { }

	// RVA: 0x2E93670 Offset: 0x2E93771 VA: 0x2E93670
	public ulong GetOwnerId() { }

	// RVA: 0x2E93680 Offset: 0x2E93781 VA: 0x2E93680
	public void SetPersistenceSlotId(ushort persistenceSlotId_) { }

	// RVA: 0x2E93690 Offset: 0x2E93791 VA: 0x2E93690
	public ushort GetPersistenceSlotId() { }

	// RVA: 0x2E936A0 Offset: 0x2E937A1 VA: 0x2E936A0
	public void Reset() { }

	// RVA: 0x2E936B0 Offset: 0x2E937B1 VA: 0x2E936B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E937D0 Offset: 0x2E938D1 VA: 0x2E937D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E93810 Offset: 0x2E93911 VA: 0x2E93810
	public void Trace() { }

	// RVA: 0x2E93820 Offset: 0x2E93921 VA: 0x2E93820 Slot: 3
	public override string ToString() { }
}

