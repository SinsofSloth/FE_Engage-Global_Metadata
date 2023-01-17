// Namespace: NexPlugin
public class DataStoreSearchParam // TypeDefIndex: 14882
{
	// Fields
	internal DataStore.SearchType searchTarget; // 0x10
	internal List<ulong> ownerIds; // 0x18
	internal DataStore.SearchTarget ownerType; // 0x20
	internal List<ulong> destinationIds; // 0x28
	internal List<ushort> dataTypes; // 0x30
	internal NpDateTime createdAfter; // 0x38
	internal NpDateTime createdBefore; // 0x40
	internal NpDateTime updatedAfter; // 0x48
	internal NpDateTime updatedBefore; // 0x50
	internal DataStore.SearchSortColumn resultOrderColumn; // 0x58
	internal DataStore.SearchSortOrder resultOrder; // 0x5C
	internal ResultRange resultRange; // 0x60
	internal DataStore.ResultFlag resultOption; // 0x68
	internal List<string> tags; // 0x70
	internal uint minimalRatingFrequency; // 0x78
	internal bool totalCountEnabled; // 0x7C
	internal bool useCache; // 0x7D

	// Methods

	// RVA: 0x2E95CD0 Offset: 0x2E95DD1 VA: 0x2E95CD0
	public void .ctor() { }

	// RVA: 0x2E96020 Offset: 0x2E96121 VA: 0x2E96020
	public void SetSearchType(DataStore.SearchType searchType) { }

	// RVA: 0x2E96030 Offset: 0x2E96131 VA: 0x2E96030
	public DataStore.SearchType GetSearchType() { }

	// RVA: 0x2E96040 Offset: 0x2E96141 VA: 0x2E96040
	public void SetOwnerIds(List<ulong> ownerIds_) { }

	// RVA: 0x2E960D0 Offset: 0x2E961D1 VA: 0x2E960D0
	public List<ulong> GetOwnerIds() { }

	// RVA: 0x2E960E0 Offset: 0x2E961E1 VA: 0x2E960E0
	public void SetOwnerType(DataStore.SearchTarget ownerType_) { }

	// RVA: 0x2E960F0 Offset: 0x2E961F1 VA: 0x2E960F0
	public DataStore.SearchTarget GetOwnerType() { }

	// RVA: 0x2E96100 Offset: 0x2E96201 VA: 0x2E96100
	public void SetDestinationIds(List<ulong> destinationIds_) { }

	// RVA: 0x2E96190 Offset: 0x2E96291 VA: 0x2E96190
	public List<ulong> GetDestinationIds() { }

	// RVA: 0x2E961A0 Offset: 0x2E962A1 VA: 0x2E961A0
	public void SetDataType(ushort dataType_) { }

	// RVA: 0x2E96230 Offset: 0x2E96331 VA: 0x2E96230
	public void SetDataType(List<ushort> dataTypes_) { }

	// RVA: 0x2E962C0 Offset: 0x2E963C1 VA: 0x2E962C0
	public ushort GetDataType() { }

	// RVA: 0x2E96330 Offset: 0x2E96431 VA: 0x2E96330
	public void GetDataType(ref List<ushort> dataTypes_) { }

	// RVA: 0x2E963D0 Offset: 0x2E964D1 VA: 0x2E963D0
	public void SetCreatedAfter(NpDateTime createdAfter_) { }

	// RVA: 0x2E963E0 Offset: 0x2E964E1 VA: 0x2E963E0
	public NpDateTime GetCreatedAfter() { }

	// RVA: 0x2E963F0 Offset: 0x2E964F1 VA: 0x2E963F0
	public void SetCreatedBefore(NpDateTime createdBefore_) { }

	// RVA: 0x2E96400 Offset: 0x2E96501 VA: 0x2E96400
	public NpDateTime GetCreatedBefore() { }

	// RVA: 0x2E96410 Offset: 0x2E96511 VA: 0x2E96410
	public void SetUpdatedAfter(NpDateTime updatedAfter_) { }

	// RVA: 0x2E96420 Offset: 0x2E96521 VA: 0x2E96420
	public NpDateTime GetUpdatedAfter() { }

	// RVA: 0x2E96430 Offset: 0x2E96531 VA: 0x2E96430
	public void SetUpdatedBefore(NpDateTime updatedBefore_) { }

	// RVA: 0x2E96440 Offset: 0x2E96541 VA: 0x2E96440
	public NpDateTime GetUpdatedBefore() { }

	// RVA: 0x2E96450 Offset: 0x2E96551 VA: 0x2E96450
	public void SetSearchSortOrderColumn(DataStore.SearchSortColumn resultOrderColumn_) { }

	// RVA: 0x2E96460 Offset: 0x2E96561 VA: 0x2E96460
	public DataStore.SearchSortColumn GetSearchSortOrderColumn() { }

	// RVA: 0x2E96470 Offset: 0x2E96571 VA: 0x2E96470
	public void SetSearchSortOrder(DataStore.SearchSortOrder resultOrder_) { }

	// RVA: 0x2E96480 Offset: 0x2E96581 VA: 0x2E96480
	public DataStore.SearchSortOrder GetSearchSortOrder() { }

	// RVA: 0x2E96490 Offset: 0x2E96591 VA: 0x2E96490
	public void SetResultRange(ResultRange resultRange_) { }

	// RVA: 0x2E964A0 Offset: 0x2E965A1 VA: 0x2E964A0
	public ResultRange GetResultRange() { }

	// RVA: 0x2E964B0 Offset: 0x2E965B1 VA: 0x2E964B0
	public void SetResultOption(DataStore.ResultFlag resultOption_) { }

	// RVA: 0x2E964C0 Offset: 0x2E965C1 VA: 0x2E964C0
	public DataStore.ResultFlag GetResultOption() { }

	// RVA: 0x2E964D0 Offset: 0x2E965D1 VA: 0x2E964D0
	public void SetTags(List<string> tags_) { }

	// RVA: 0x2E96560 Offset: 0x2E96661 VA: 0x2E96560
	public List<string> GetTags() { }

	// RVA: 0x2E96570 Offset: 0x2E96671 VA: 0x2E96570
	public void SetMinimalRatingFrequency(uint minimalRatingFrequency_) { }

	// RVA: 0x2E96580 Offset: 0x2E96681 VA: 0x2E96580
	public uint GetMinimalRatingFrequency() { }

	// RVA: 0x2E96590 Offset: 0x2E96691 VA: 0x2E96590
	public void SetUseCache(bool useCache_) { }

	// RVA: 0x2E965A0 Offset: 0x2E966A1 VA: 0x2E965A0
	public bool GetUseCache() { }

	// RVA: 0x2E965B0 Offset: 0x2E966B1 VA: 0x2E965B0
	public void SetTotalCountEnabled(bool totalCountEnabled_) { }

	// RVA: 0x2E965C0 Offset: 0x2E966C1 VA: 0x2E965C0
	public bool GetTotalCountEnabled() { }

	// RVA: 0x2E95D00 Offset: 0x2E95E01 VA: 0x2E95D00
	private void Reset() { }

	// RVA: 0x2E965D0 Offset: 0x2E966D1 VA: 0x2E965D0
	public void Trace() { }

	// RVA: 0x2E965E0 Offset: 0x2E966E1 VA: 0x2E965E0 Slot: 3
	public override string ToString() { }
}

