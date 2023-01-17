// Namespace: System
internal sealed class LocalDataStoreMgr // TypeDefIndex: 140
{
	// Fields
	private const int InitialSlotTableSize = 64;
	private const int SlotTableDoubleThreshold = 512;
	private const int LargeSlotTableSizeIncrease = 128;
	private bool[] m_SlotInfoTable; // 0x10
	private int m_FirstAvailableSlot; // 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; // 0x20
	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap; // 0x28
	private long m_CookieGenerator; // 0x30

	// Methods

	// RVA: 0x341F810 Offset: 0x341F911 VA: 0x341F810
	public LocalDataStoreHolder CreateLocalDataStore() { }

	// RVA: 0x341EFC0 Offset: 0x341F0C1 VA: 0x341EFC0
	public void DeleteLocalDataStore(LocalDataStore store) { }

	// RVA: 0x341F9F0 Offset: 0x341FAF1 VA: 0x341F9F0
	public LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x341FCC0 Offset: 0x341FDC1 VA: 0x341FCC0
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x341FDF0 Offset: 0x341FEF1 VA: 0x341FDF0
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x341FF20 Offset: 0x3420021 VA: 0x341FF20
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x3420030 Offset: 0x3420131 VA: 0x3420030
	internal void FreeDataSlot(int slot, long cookie) { }

	// RVA: 0x341F1F0 Offset: 0x341F2F1 VA: 0x341F1F0
	public void ValidateSlot(LocalDataStoreSlot slot) { }

	// RVA: 0x341F6B0 Offset: 0x341F7B1 VA: 0x341F6B0
	internal int GetSlotTableLength() { }

	// RVA: 0x3420210 Offset: 0x3420311 VA: 0x3420210
	public void .ctor() { }
}

