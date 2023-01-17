// Namespace: App
public class SortieEntrustScore // TypeDefIndex: 13161
{
	// Fields
	private const int MaxRangeForRangeCovered = 10;
	private SortieEntrustStockData m_StockData; // 0x10
	private SortieEntrustScore.Result m_Result; // 0x18

	// Properties
	public SortieEntrustStockData StockData { get; }
	public bool IsValidScore { get; }
	public int Score { get; }

	// Methods

	// RVA: 0x2156FA0 Offset: 0x21570A1 VA: 0x2156FA0
	public static uint GetItemKindMask(SortieEntrustUnitData unitData) { }

	// RVA: 0x2157170 Offset: 0x2157271 VA: 0x2157170
	public void .ctor() { }

	// RVA: 0x21571F0 Offset: 0x21572F1 VA: 0x21571F0
	public void Initialize(SortieEntrustStockData stockData) { }

	// RVA: 0x2157220 Offset: 0x2157321 VA: 0x2157220
	public void Calc(SortieEntrustUnitData unitData) { }

	// RVA: 0x2157940 Offset: 0x2157A41 VA: 0x2157940
	public void SelectHigh(SortieEntrustScore other) { }

	// RVA: 0x2157A50 Offset: 0x2157B51 VA: 0x2157A50
	public SortieEntrustStockData get_StockData() { }

	// RVA: 0x2157A30 Offset: 0x2157B31 VA: 0x2157A30
	public bool get_IsValidScore() { }

	// RVA: 0x2157A40 Offset: 0x2157B41 VA: 0x2157A40
	public int get_Score() { }

	// RVA: 0x21572F0 Offset: 0x21573F1 VA: 0x21572F0
	private bool IsExclude(SortieEntrustUnitData unitData) { }

	// RVA: 0x2157A60 Offset: 0x2157B61 VA: 0x2157A60
	private static bool IsRangeNormal(ItemData itemData) { }

	// RVA: 0x2157B00 Offset: 0x2157C01 VA: 0x2157B00
	private static bool IsRangeSpecial(ItemData itemData) { }

	// RVA: 0x2157B60 Offset: 0x2157C61 VA: 0x2157B60
	private static bool IsRangeCovered(SortieEntrustUnitData unitData, ItemData stockItemData) { }

	// RVA: 0x2157CE0 Offset: 0x2157DE1 VA: 0x2157CE0
	private static bool IsPersonalUse(ItemData itemData) { }
}

