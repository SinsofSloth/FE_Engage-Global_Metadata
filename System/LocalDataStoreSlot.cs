// Namespace: System
[ComVisibleAttribute] // RVA: 0x46F950 Offset: 0x46FA51 VA: 0x46F950
public sealed class LocalDataStoreSlot // TypeDefIndex: 139
{
	// Fields
	private LocalDataStoreMgr m_mgr; // 0x10
	private int m_slot; // 0x18
	private long m_cookie; // 0x20

	// Properties
	internal LocalDataStoreMgr Manager { get; }
	internal int Slot { get; }
	internal long Cookie { get; }

	// Methods

	// RVA: 0x341FC70 Offset: 0x341FD71 VA: 0x341FC70
	internal void .ctor(LocalDataStoreMgr mgr, int slot, long cookie) { }

	// RVA: 0x3420330 Offset: 0x3420431 VA: 0x3420330
	internal LocalDataStoreMgr get_Manager() { }

	// RVA: 0x3420340 Offset: 0x3420441 VA: 0x3420340
	internal int get_Slot() { }

	// RVA: 0x3420350 Offset: 0x3420451 VA: 0x3420350
	internal long get_Cookie() { }

	// RVA: 0x3420360 Offset: 0x3420461 VA: 0x3420360 Slot: 1
	protected override void Finalize() { }
}

