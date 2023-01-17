// Namespace: 
private class ShopSequnece.ShopItem : ShopSequnece.ParamItem // TypeDefIndex: 13138
{
	// Fields
	private ShopData m_Data; // 0x20
	private ItemData m_Item; // 0x28
	private UnitItem m_UnitItem; // 0x30
	private Unit m_Unit; // 0x38

	// Methods

	// RVA: 0x203A4C0 Offset: 0x203A5C1 VA: 0x203A4C0
	public void .ctor(ShopData data, Unit unit) { }

	// RVA: 0x203A5F0 Offset: 0x203A6F1 VA: 0x203A5F0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x203A6F0 Offset: 0x203A7F1 VA: 0x203A6F0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x203A700 Offset: 0x203A801 VA: 0x203A700 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x203A7D0 Offset: 0x203A8D1 VA: 0x203A7D0 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x203A840 Offset: 0x203A941 VA: 0x203A840 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class ShopSequnece.StockItem : ShopSequnece.ParamItem // TypeDefIndex: 13140
{
	// Fields
	private Unit m_Unit; // 0x20

	// Methods

	// RVA: 0x203A950 Offset: 0x203AA51 VA: 0x203A950
	public void .ctor(Unit unit) { }

	// RVA: 0x203A990 Offset: 0x203AA91 VA: 0x203A990 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x203A9F0 Offset: 0x203AAF1 VA: 0x203A9F0 Slot: 44
	public override string GetColumnName2() { }
}

