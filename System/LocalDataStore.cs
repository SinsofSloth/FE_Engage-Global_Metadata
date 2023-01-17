// Namespace: System
internal sealed class LocalDataStore // TypeDefIndex: 138
{
	// Fields
	private LocalDataStoreElement[] m_DataTable; // 0x10
	private LocalDataStoreMgr m_Manager; // 0x18

	// Methods

	// RVA: 0x341EF20 Offset: 0x341F021 VA: 0x341EF20
	public void .ctor(LocalDataStoreMgr mgr, int InitialCapacity) { }

	// RVA: 0x341EFB0 Offset: 0x341F0B1 VA: 0x341EFB0
	internal void Dispose() { }

	// RVA: 0x341F0D0 Offset: 0x341F1D1 VA: 0x341F0D0
	public object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x341F270 Offset: 0x341F371 VA: 0x341F270
	public void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x341F650 Offset: 0x341F751 VA: 0x341F650
	internal void FreeData(int slot, long cookie) { }

	// RVA: 0x341F3A0 Offset: 0x341F4A1 VA: 0x341F3A0
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }
}

