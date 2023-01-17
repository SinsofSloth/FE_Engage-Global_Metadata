// Namespace: NexPlugin
public class DataStoreChangeMetaCompareParam // TypeDefIndex: 14889
{
	// Fields
	internal DataStore.ComparisonFlag comparisonFlag; // 0x10
	internal string name; // 0x18
	internal DataStorePermission accessPermission; // 0x20
	internal DataStorePermission updatePermission; // 0x28
	internal ushort dataType; // 0x30
	internal ushort period; // 0x32
	internal List<string> tags; // 0x38
	internal List<byte> metaBinary; // 0x40
	internal DataStore.DataStatus status; // 0x48

	// Methods

	// RVA: 0x23C79B0 Offset: 0x23C7AB1 VA: 0x23C79B0
	public void .ctor() { }

	// RVA: 0x23C7C90 Offset: 0x23C7D91 VA: 0x23C7C90
	public void .ctor(DataStore.ComparisonFlag comparisonFlag, DataStoreMetaInfo metaInfo) { }

	// RVA: 0x23C7CD0 Offset: 0x23C7DD1 VA: 0x23C7CD0
	public void Set(DataStore.ComparisonFlag comparisonFlag_, DataStoreMetaInfo metaInfo_) { }

	// RVA: 0x23C8210 Offset: 0x23C8311 VA: 0x23C8210
	public void SetComparisonFlag(DataStore.ComparisonFlag comparisonFlag_) { }

	// RVA: 0x23C8220 Offset: 0x23C8321 VA: 0x23C8220
	public DataStore.ComparisonFlag GetComparisonFlag() { }

	// RVA: 0x23C7F80 Offset: 0x23C8081 VA: 0x23C7F80
	public void SetName(string name_) { }

	// RVA: 0x23C8230 Offset: 0x23C8331 VA: 0x23C8230
	public string GetName() { }

	// RVA: 0x23C7FF0 Offset: 0x23C80F1 VA: 0x23C7FF0
	public void SetAccessPermission(DataStorePermission permission_) { }

	// RVA: 0x23C8240 Offset: 0x23C8341 VA: 0x23C8240
	public DataStorePermission GetAccessPermission() { }

	// RVA: 0x23C8070 Offset: 0x23C8171 VA: 0x23C8070
	public void SetUpdatePermission(DataStorePermission updatePermission_) { }

	// RVA: 0x23C8250 Offset: 0x23C8351 VA: 0x23C8250
	public DataStorePermission GetUpdatePermission() { }

	// RVA: 0x23C8260 Offset: 0x23C8361 VA: 0x23C8260
	public void SetPeriod(ushort period_) { }

	// RVA: 0x23C8270 Offset: 0x23C8371 VA: 0x23C8270
	public ushort GetPeriod() { }

	// RVA: 0x23C8180 Offset: 0x23C8281 VA: 0x23C8180
	public void SetTags(List<string> tags_) { }

	// RVA: 0x23C8280 Offset: 0x23C8381 VA: 0x23C8280
	public List<string> GetTags() { }

	// RVA: 0x23C80F0 Offset: 0x23C81F1 VA: 0x23C80F0
	public void SetMetaBinary(List<byte> meta) { }

	// RVA: 0x23C8290 Offset: 0x23C8391 VA: 0x23C8290
	public List<byte> GetMetaBinary() { }

	// RVA: 0x23C82A0 Offset: 0x23C83A1 VA: 0x23C82A0
	public void SetDataType(ushort dataType_) { }

	// RVA: 0x23C82B0 Offset: 0x23C83B1 VA: 0x23C82B0
	public ushort GetDataType() { }

	// RVA: 0x23C82C0 Offset: 0x23C83C1 VA: 0x23C82C0
	public void SetDataStatus(DataStore.DataStatus status_) { }

	// RVA: 0x23C82D0 Offset: 0x23C83D1 VA: 0x23C82D0
	public DataStore.DataStatus GetDataStatus() { }

	// RVA: 0x23C79E0 Offset: 0x23C7AE1 VA: 0x23C79E0
	private void Reset() { }

	// RVA: 0x23C82E0 Offset: 0x23C83E1 VA: 0x23C82E0
	public void Trace() { }

	// RVA: 0x23C82F0 Offset: 0x23C83F1 VA: 0x23C82F0 Slot: 3
	public override string ToString() { }
}

