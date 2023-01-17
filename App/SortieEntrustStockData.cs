// Namespace: App
public class SortieEntrustStockData // TypeDefIndex: 13162
{
	// Fields
	private UnitItem m_UnitItem; // 0x10
	private ItemData m_ItemData; // 0x18
	private int m_StockCount; // 0x20
	private int m_AssignedCount; // 0x24

	// Properties
	public UnitItem UnitItem { get; }
	public ItemData ItemData { get; }
	public int StockCount { get; }
	public int AssignedCount { get; }

	// Methods

	// RVA: 0x2157CF0 Offset: 0x2157DF1 VA: 0x2157CF0
	public void .ctor(UnitItem unitItem, int count) { }

	// RVA: 0x2157DB0 Offset: 0x2157EB1 VA: 0x2157DB0
	public void Assigned() { }

	// RVA: 0x2157DD0 Offset: 0x2157ED1 VA: 0x2157DD0
	public void AddStock(int count) { }

	// RVA: 0x2157DE0 Offset: 0x2157EE1 VA: 0x2157DE0
	public UnitItem get_UnitItem() { }

	// RVA: 0x2157DF0 Offset: 0x2157EF1 VA: 0x2157DF0
	public ItemData get_ItemData() { }

	// RVA: 0x2157E00 Offset: 0x2157F01 VA: 0x2157E00
	public int get_StockCount() { }

	// RVA: 0x2157E10 Offset: 0x2157F11 VA: 0x2157E10
	public int get_AssignedCount() { }
}

