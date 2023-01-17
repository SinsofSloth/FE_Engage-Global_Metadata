// Namespace: 
private class SortieEntrustScore.Result // TypeDefIndex: 13155
{
	// Fields
	private bool m_IsValid; // 0x10
	private int m_Score; // 0x14

	// Properties
	public bool IsValid { get; }
	public int Score { get; }

	// Methods

	// RVA: 0x2041C40 Offset: 0x2041D41 VA: 0x2041C40
	public void Clear() { }

	// RVA: 0x2041C50 Offset: 0x2041D51 VA: 0x2041C50
	public void Set(int score) { }

	// RVA: 0x2041DF0 Offset: 0x2041EF1 VA: 0x2041DF0
	public bool get_IsValid() { }

	// RVA: 0x2041E00 Offset: 0x2041F01 VA: 0x2041E00
	public int get_Score() { }

	// RVA: 0x2041E10 Offset: 0x2041F11 VA: 0x2041E10
	public void .ctor() { }
}

// Namespace: 
private class SortieEntrustScore.Weapon // TypeDefIndex: 13156
{
	// Fields
	private const int PowerFactor = 10;
	private const int HitLow = 70;
	private const int HitHigh = 100;

	// Methods

	// RVA: 0x2042300 Offset: 0x2042401 VA: 0x2042300
	public static bool IsExclude(SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2042450 Offset: 0x2042551 VA: 0x2042450
	public static void Calc(SortieEntrustScore.Result result, SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x20427B0 Offset: 0x20428B1 VA: 0x20427B0
	private static int GetEfficacyPowerOffset(UnitItem stockUnitItem, ItemData stockItemData) { }

	// RVA: 0x20427C0 Offset: 0x20428C1 VA: 0x20427C0
	public void .ctor() { }
}

// Namespace: 
private class SortieEntrustScore.Rod // TypeDefIndex: 13157
{
	// Methods

	// RVA: 0x2041E20 Offset: 0x2041F21 VA: 0x2041E20
	public static bool IsExclude(SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2041F10 Offset: 0x2042011 VA: 0x2041F10
	public static void Calc(SortieEntrustScore.Result result, SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2042040 Offset: 0x2042141 VA: 0x2042040
	public void .ctor() { }
}

// Namespace: 
private class SortieEntrustScore.EnhancePerson // TypeDefIndex: 13158
{
	// Methods

	// RVA: 0x2041C70 Offset: 0x2041D71 VA: 0x2041C70
	public static bool IsExclude(SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2041CD0 Offset: 0x2041DD1 VA: 0x2041CD0
	public static void Calc(SortieEntrustScore.Result result, SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2041DE0 Offset: 0x2041EE1 VA: 0x2041DE0
	public void .ctor() { }
}

// Namespace: 
private class SortieEntrustScore.Enhance // TypeDefIndex: 13159
{
	// Methods

	// RVA: 0x2041B20 Offset: 0x2041C21 VA: 0x2041B20
	public static bool IsExclude(SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2041B50 Offset: 0x2041C51 VA: 0x2041B50
	public static void Calc(SortieEntrustScore.Result result, SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x2041C60 Offset: 0x2041D61 VA: 0x2041C60
	public void .ctor() { }
}

// Namespace: 
private class SortieEntrustScore.Vulnerary // TypeDefIndex: 13160
{
	// Methods

	// RVA: 0x2042050 Offset: 0x2042151 VA: 0x2042050
	public static bool IsExclude(SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x20420D0 Offset: 0x20421D1 VA: 0x20420D0
	public static void Calc(SortieEntrustScore.Result result, SortieEntrustUnitData unitData, SortieEntrustStockData stockData) { }

	// RVA: 0x20422F0 Offset: 0x20423F1 VA: 0x20422F0
	public void .ctor() { }
}

