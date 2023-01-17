// Namespace: 
private class ShopSequnece.ParamItem : MenuItem // TypeDefIndex: 13137
{
	// Methods

	// RVA: 0x203A380 Offset: 0x203A481 VA: 0x203A380 Slot: 29
	public override int GetColumnCount() { }

	// RVA: 0x203A390 Offset: 0x203A491 VA: 0x203A390 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x203A3A0 Offset: 0x203A4A1 VA: 0x203A3A0 Slot: 32
	public override float GetColumnWidth1() { }

	// RVA: 0x203A3B0 Offset: 0x203A4B1 VA: 0x203A3B0 Slot: 33
	public override float GetColumnWidth2() { }

	// RVA: 0x203A3C0 Offset: 0x203A4C1 VA: 0x203A3C0 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x203A410 Offset: 0x203A511 VA: 0x203A410 Slot: 43
	public override string GetColumnName1() { }

	// RVA: 0x203A460 Offset: 0x203A561 VA: 0x203A460 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x203A4B0 Offset: 0x203A5B1 VA: 0x203A4B0 Slot: 55
	public override MenuItem.Align GetColumnAlign2() { }

	// RVA: 0x203A370 Offset: 0x203A471 VA: 0x203A370
	public void .ctor() { }
}

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
private class ShopSequnece.GoldItem : ShopSequnece.ParamItem // TypeDefIndex: 13139
{
	// Methods

	// RVA: 0x203A250 Offset: 0x203A351 VA: 0x203A250 Slot: 42
	public override string GetColumnName0() { }

	// RVA: 0x203A2A0 Offset: 0x203A3A1 VA: 0x203A2A0 Slot: 44
	public override string GetColumnName2() { }

	// RVA: 0x203A360 Offset: 0x203A461 VA: 0x203A360
	public void .ctor() { }
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

