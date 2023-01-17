// Namespace: NexPlugin
public class DataStorePreparePostParam // TypeDefIndex: 14880
{
	// Fields
	internal uint size; // 0x10
	internal string name; // 0x18
	internal ushort dataType; // 0x20
	internal ushort period; // 0x22
	internal DataStorePermission accessPermission; // 0x28
	internal DataStorePermission updatePermission; // 0x30
	internal DataStore.DataFlag flag; // 0x38
	internal List<string> tags; // 0x40
	internal Dictionary<sbyte, DataStoreRatingInitParam> ratingInitParams; // 0x48
	internal List<byte> meta; // 0x50
	internal DataStorePersistenceInitParam persistenceInitParam; // 0x58

	// Methods

	// RVA: 0x2E93D00 Offset: 0x2E93E01 VA: 0x2E93D00
	public void .ctor() { }

	// RVA: 0x2E94180 Offset: 0x2E94281 VA: 0x2E94180
	public void SetSize(uint size_) { }

	// RVA: 0x2E94190 Offset: 0x2E94291 VA: 0x2E94190
	public uint GetSize() { }

	// RVA: 0x2E941A0 Offset: 0x2E942A1 VA: 0x2E941A0
	public void SetName(string name_) { }

	// RVA: 0x2E94210 Offset: 0x2E94311 VA: 0x2E94210
	public string GetName() { }

	// RVA: 0x2E94220 Offset: 0x2E94321 VA: 0x2E94220
	public void SetDataType(ushort dataType_) { }

	// RVA: 0x2E94230 Offset: 0x2E94331 VA: 0x2E94230
	public ushort GetDataType() { }

	// RVA: 0x2E94240 Offset: 0x2E94341 VA: 0x2E94240
	public void SetAccessPermission(DataStorePermission permission_) { }

	// RVA: 0x2E942C0 Offset: 0x2E943C1 VA: 0x2E942C0
	public DataStorePermission GetAccessPermission() { }

	// RVA: 0x2E942D0 Offset: 0x2E943D1 VA: 0x2E942D0
	public void SetUpdatePermission(DataStorePermission updatePermission_) { }

	// RVA: 0x2E94350 Offset: 0x2E94451 VA: 0x2E94350
	public DataStorePermission GetUpdatePermission() { }

	// RVA: 0x2E94360 Offset: 0x2E94461 VA: 0x2E94360
	public void SetDataFlag(DataStore.DataFlag flag_) { }

	// RVA: 0x2E94370 Offset: 0x2E94471 VA: 0x2E94370
	public DataStore.DataFlag GetDataFlag() { }

	// RVA: 0x2E94380 Offset: 0x2E94481 VA: 0x2E94380
	public void SetPeriod(ushort period_) { }

	// RVA: 0x2E94390 Offset: 0x2E94491 VA: 0x2E94390
	public ushort GetPeriod() { }

	// RVA: 0x2E943A0 Offset: 0x2E944A1 VA: 0x2E943A0
	public void SetTags(List<string> tags_) { }

	// RVA: 0x2E94430 Offset: 0x2E94531 VA: 0x2E94430
	public List<string> GetTags() { }

	// RVA: 0x2E94440 Offset: 0x2E94541 VA: 0x2E94440
	public void SetRatingSetting(Dictionary<sbyte, DataStoreRatingInitParam> ratingInitParam) { }

	// RVA: 0x2E944D0 Offset: 0x2E945D1 VA: 0x2E944D0
	public void ClearRatingSetting() { }

	// RVA: 0x2E94530 Offset: 0x2E94631 VA: 0x2E94530
	public bool AddRatingSetting(sbyte slot, DataStoreRatingInitParam ratingInitParam) { }

	// RVA: 0x2E945E0 Offset: 0x2E946E1 VA: 0x2E945E0
	public Dictionary<sbyte, DataStoreRatingInitParam> GetRatingSetting() { }

	// RVA: 0x2E945F0 Offset: 0x2E946F1 VA: 0x2E945F0
	public void SetMetaBinary(List<byte> meta_) { }

	// RVA: 0x2E94680 Offset: 0x2E94781 VA: 0x2E94680
	public List<byte> GetMetaBinary() { }

	// RVA: 0x2E94690 Offset: 0x2E94791 VA: 0x2E94690
	public void SetPersistenceInitParam(DataStorePersistenceInitParam persistenceInitParam_) { }

	// RVA: 0x2E94720 Offset: 0x2E94821 VA: 0x2E94720
	public DataStorePersistenceInitParam GetPersistenceInitParam() { }

	// RVA: 0x2E93D30 Offset: 0x2E93E31 VA: 0x2E93D30
	public void Reset() { }

	// RVA: 0x2E94730 Offset: 0x2E94831 VA: 0x2E94730
	public void Trace() { }

	// RVA: 0x2E94740 Offset: 0x2E94841 VA: 0x2E94740 Slot: 3
	public override string ToString() { }
}

