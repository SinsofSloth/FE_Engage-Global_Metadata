// Namespace: NexPlugin
public class DataStoreChangeMetaParam // TypeDefIndex: 14890
{
	// Fields
	internal ulong dataId; // 0x10
	internal DataStore.ModificationFlag modifiesFlag; // 0x18
	internal string name; // 0x20
	internal DataStorePermission accessPermission; // 0x28
	internal DataStorePermission updatePermission; // 0x30
	internal ushort period; // 0x38
	internal ushort dataType; // 0x3A
	internal List<string> tags; // 0x40
	internal List<byte> metaBinary; // 0x48
	internal DataStorePersistenceTarget persistenceTarget; // 0x50
	internal DataStore.DataStatus status; // 0x58
	internal ulong updatePassword; // 0x60
	internal DataStoreChangeMetaCompareParam compareParam; // 0x68

	// Methods

	// RVA: 0x2E91150 Offset: 0x2E91251 VA: 0x2E91150
	public void .ctor() { }

	// RVA: 0x2E91560 Offset: 0x2E91661 VA: 0x2E91560
	public void SetDataId(ulong dataId_) { }

	// RVA: 0x2E91690 Offset: 0x2E91791 VA: 0x2E91690
	public ulong GetDataId() { }

	// RVA: 0x2E916A0 Offset: 0x2E917A1 VA: 0x2E916A0
	public void SetModificationFlag(DataStore.ModificationFlag modificationFlag) { }

	// RVA: 0x2E916B0 Offset: 0x2E917B1 VA: 0x2E916B0
	public DataStore.ModificationFlag GetModificationFlag() { }

	// RVA: 0x2E916C0 Offset: 0x2E917C1 VA: 0x2E916C0
	public void SetName(string name_) { }

	// RVA: 0x2E91730 Offset: 0x2E91831 VA: 0x2E91730
	public string GetName() { }

	// RVA: 0x2E91740 Offset: 0x2E91841 VA: 0x2E91740
	public void SetAccessPermission(DataStorePermission permission_) { }

	// RVA: 0x2E917F0 Offset: 0x2E918F1 VA: 0x2E917F0
	public DataStorePermission GetAccessPermission() { }

	// RVA: 0x2E91800 Offset: 0x2E91901 VA: 0x2E91800
	public void SetUpdatePermission(DataStorePermission updatePermission_) { }

	// RVA: 0x2E91880 Offset: 0x2E91981 VA: 0x2E91880
	public DataStorePermission GetUpdatePermission() { }

	// RVA: 0x2E91890 Offset: 0x2E91991 VA: 0x2E91890
	public void SetPeriod(ushort period_) { }

	// RVA: 0x2E918A0 Offset: 0x2E919A1 VA: 0x2E918A0
	public ushort GetPeriod() { }

	// RVA: 0x2E918B0 Offset: 0x2E919B1 VA: 0x2E918B0
	public void SetTags(List<string> tags_) { }

	// RVA: 0x2E91940 Offset: 0x2E91A41 VA: 0x2E91940
	public List<string> GetTags() { }

	// RVA: 0x2E91950 Offset: 0x2E91A51 VA: 0x2E91950
	public void SetMetaBinary(List<byte> meta) { }

	// RVA: 0x2E919E0 Offset: 0x2E91AE1 VA: 0x2E919E0
	public List<byte> GetMetaBinary() { }

	// RVA: 0x2E919F0 Offset: 0x2E91AF1 VA: 0x2E919F0
	public void SetUpdatePassword(ulong updatePassword_) { }

	// RVA: 0x2E91A00 Offset: 0x2E91B01 VA: 0x2E91A00
	public ulong GetUpdatePassword() { }

	// RVA: 0x2E91A10 Offset: 0x2E91B11 VA: 0x2E91A10
	public void SetDataType(ushort dataType_) { }

	// RVA: 0x2E91A20 Offset: 0x2E91B21 VA: 0x2E91A20
	private ushort GetDataType() { }

	// RVA: 0x2E91A30 Offset: 0x2E91B31 VA: 0x2E91A30
	public void SetDataStatus(DataStore.DataStatus status_) { }

	// RVA: 0x2E91A40 Offset: 0x2E91B41 VA: 0x2E91A40
	public DataStore.DataStatus GetDataStatus() { }

	// RVA: 0x2E91A50 Offset: 0x2E91B51 VA: 0x2E91A50
	public void SetChangeMetaCompareParam(DataStoreChangeMetaCompareParam compareParam_) { }

	// RVA: 0x2E91AD0 Offset: 0x2E91BD1 VA: 0x2E91AD0
	public DataStoreChangeMetaCompareParam GetChangeMetaCompareParam() { }

	// RVA: 0x2E91AE0 Offset: 0x2E91BE1 VA: 0x2E91AE0
	public void SetPersistenceTarget(DataStorePersistenceTarget persistenceTarget_) { }

	// RVA: 0x2E91BC0 Offset: 0x2E91CC1 VA: 0x2E91BC0
	public DataStorePersistenceTarget GetPersistenceTarget() { }

	// RVA: 0x2E91180 Offset: 0x2E91281 VA: 0x2E91180
	public void Reset() { }

	// RVA: 0x2E91C70 Offset: 0x2E91D71 VA: 0x2E91C70
	public void Trace() { }

	// RVA: 0x2E91C80 Offset: 0x2E91D81 VA: 0x2E91C80 Slot: 3
	public override string ToString() { }
}

