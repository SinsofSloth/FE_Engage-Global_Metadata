// Namespace: NexPlugin
public class DataStoreMetaInfo // TypeDefIndex: 14874
{
	// Fields
	internal ulong dataId; // 0x10
	internal ulong ownerId; // 0x18
	internal uint size; // 0x20
	internal string name; // 0x28
	internal ushort dataType; // 0x30
	internal ushort period; // 0x32
	internal DataStorePermission accessPermission; // 0x38
	internal DataStorePermission updatePermission; // 0x40
	internal NpDateTime createdTime; // 0x48
	internal NpDateTime updatedTime; // 0x50
	internal DataStore.DataStatus status; // 0x58
	internal uint referDataId; // 0x5C
	internal DataStore.DataFlag flag; // 0x60
	internal NpDateTime expireTime; // 0x64
	internal List<string> tags; // 0x70
	internal List<DataStoreRatingInfo> ratingInfo; // 0x78
	internal List<byte> metaBinary; // 0x80

	// Methods

	// RVA: 0x2E92760 Offset: 0x2E92861 VA: 0x2E92760
	public void .ctor() { }

	// RVA: 0x2E92910 Offset: 0x2E92A11 VA: 0x2E92910
	public ulong GetDataId() { }

	// RVA: 0x2E92920 Offset: 0x2E92A21 VA: 0x2E92920
	public ulong GetOwnerId() { }

	// RVA: 0x2E92930 Offset: 0x2E92A31 VA: 0x2E92930
	public uint GetSize() { }

	// RVA: 0x2E92940 Offset: 0x2E92A41 VA: 0x2E92940
	public string GetName() { }

	// RVA: 0x2E92950 Offset: 0x2E92A51 VA: 0x2E92950
	public ushort GetDataType() { }

	// RVA: 0x2E92960 Offset: 0x2E92A61 VA: 0x2E92960
	public DataStorePermission GetAccessPermission() { }

	// RVA: 0x2E92970 Offset: 0x2E92A71 VA: 0x2E92970
	public DataStorePermission GetUpdatePermission() { }

	// RVA: 0x2E92980 Offset: 0x2E92A81 VA: 0x2E92980
	public NpDateTime GetCreatedTime() { }

	// RVA: 0x2E92990 Offset: 0x2E92A91 VA: 0x2E92990
	public NpDateTime GetUpdatedTime() { }

	// RVA: 0x2E929A0 Offset: 0x2E92AA1 VA: 0x2E929A0
	public ushort GetPeriod() { }

	// RVA: 0x2E929B0 Offset: 0x2E92AB1 VA: 0x2E929B0
	public DataStore.DataStatus GetDataStatus() { }

	// RVA: 0x2E929C0 Offset: 0x2E92AC1 VA: 0x2E929C0
	public uint GetReferDataId() { }

	// RVA: 0x2E929D0 Offset: 0x2E92AD1 VA: 0x2E929D0
	public DataStore.DataFlag GetDataFlag() { }

	// RVA: 0x2E929E0 Offset: 0x2E92AE1 VA: 0x2E929E0
	public NpDateTime GetExpireTime() { }

	// RVA: 0x2E929F0 Offset: 0x2E92AF1 VA: 0x2E929F0
	public List<string> GetTags() { }

	// RVA: 0x2E92A00 Offset: 0x2E92B01 VA: 0x2E92A00
	public List<DataStoreRatingInfo> GetRating() { }

	// RVA: 0x2E92A10 Offset: 0x2E92B11 VA: 0x2E92A10
	public List<byte> GetMetaBinary() { }

	// RVA: 0x2E92A20 Offset: 0x2E92B21 VA: 0x2E92A20
	public bool IsValid() { }

	// RVA: 0x2E92A30 Offset: 0x2E92B31 VA: 0x2E92A30
	public void Trace() { }

	// RVA: 0x2E92A40 Offset: 0x2E92B41 VA: 0x2E92A40 Slot: 3
	public override string ToString() { }
}

