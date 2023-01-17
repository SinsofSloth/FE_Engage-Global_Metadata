// Namespace: App
public class WeaponShopBuyMenuItem : BasicMenuItem // TypeDefIndex: 11253
{
	// Fields
	private string m_Iid; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x297280 Offset: 0x297381 VA: 0x297280
	private ItemData <m_ItemData>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x297290 Offset: 0x297391 VA: 0x297290
	private UnitItem <m_UnitItem>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x2972A0 Offset: 0x2973A1 VA: 0x2972A0
	private int <m_StockNum>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2972B0 Offset: 0x2973B1 VA: 0x2972B0
	private bool <m_NewArrival>k__BackingField; // 0x84
	private Unit m_Unit; // 0x88
	private Color m_activeTextColor2; // 0x90
	private Color m_inactiveTextColor2; // 0xA0
	private WeaponShopBuyMenu.SelectEventHandler m_SelectEventHandler; // 0xB0
	private WeaponShopBuyMenu.DecideEventHandler m_DecideEventHandler; // 0xB8
	private WeaponShopBuyMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0xC0
	private WeaponShopBuyMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0xC8

	// Properties
	public ItemData m_ItemData { get; set; }
	public UnitItem m_UnitItem { get; set; }
	public int m_StockNum { get; set; }
	public bool m_NewArrival { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3F20 Offset: 0x2C4021 VA: 0x2C3F20
	// RVA: 0x26D0070 Offset: 0x26D0171 VA: 0x26D0070
	public ItemData get_m_ItemData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F30 Offset: 0x2C4031 VA: 0x2C3F30
	// RVA: 0x26D0080 Offset: 0x26D0181 VA: 0x26D0080
	private void set_m_ItemData(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F40 Offset: 0x2C4041 VA: 0x2C3F40
	// RVA: 0x26D0090 Offset: 0x26D0191 VA: 0x26D0090
	public UnitItem get_m_UnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F50 Offset: 0x2C4051 VA: 0x2C3F50
	// RVA: 0x26D00A0 Offset: 0x26D01A1 VA: 0x26D00A0
	private void set_m_UnitItem(UnitItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F60 Offset: 0x2C4061 VA: 0x2C3F60
	// RVA: 0x26D00B0 Offset: 0x26D01B1 VA: 0x26D00B0
	public int get_m_StockNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F70 Offset: 0x2C4071 VA: 0x2C3F70
	// RVA: 0x26D00C0 Offset: 0x26D01C1 VA: 0x26D00C0
	private void set_m_StockNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F80 Offset: 0x2C4081 VA: 0x2C3F80
	// RVA: 0x26D00D0 Offset: 0x26D01D1 VA: 0x26D00D0
	public bool get_m_NewArrival() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F90 Offset: 0x2C4091 VA: 0x2C3F90
	// RVA: 0x26D00E0 Offset: 0x26D01E1 VA: 0x26D00E0
	private void set_m_NewArrival(bool value) { }

	// RVA: 0x26CEDC0 Offset: 0x26CEEC1 VA: 0x26CEDC0
	public void .ctor(ShopContent shopContent, Unit unit, WeaponShopBuyMenu.SelectEventHandler selectEventHandler, WeaponShopBuyMenu.DecideEventHandler decideEventHandler, WeaponShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, WeaponShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler) { }

	// RVA: 0x26D00F0 Offset: 0x26D01F1 VA: 0x26D00F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x26D0100 Offset: 0x26D0201 VA: 0x26D0100 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26D01B0 Offset: 0x26D02B1 VA: 0x26D01B0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x26D0500 Offset: 0x26D0601 VA: 0x26D0500 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x26D01C0 Offset: 0x26D02C1 VA: 0x26D01C0
	public void SetInitialColor() { }

	// RVA: 0x26D0510 Offset: 0x26D0611 VA: 0x26D0510
	public bool IsEffective() { }

	// RVA: 0x26D1110 Offset: 0x26D1211 VA: 0x26D1110
	public void SetTextColor(Color activeColor1, Color activeColor2, Color inactiveColor1, Color inactiveColor2) { }

	// RVA: 0x26D1320 Offset: 0x26D1421 VA: 0x26D1320 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x26D1360 Offset: 0x26D1461 VA: 0x26D1360 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x26D1470 Offset: 0x26D1571 VA: 0x26D1470 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x26D1590 Offset: 0x26D1691 VA: 0x26D1590 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26CFB00 Offset: 0x26CFC01 VA: 0x26CFB00
	public void OnDoneToBuy() { }

	// RVA: 0x26D15F0 Offset: 0x26D16F1 VA: 0x26D15F0 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x26D19B0 Offset: 0x26D1AB1 VA: 0x26D19B0
	private int GetUnitItemEmptyCount() { }

	// RVA: 0x26D19E0 Offset: 0x26D1AE1 VA: 0x26D19E0
	public bool IsEnoughMoneyToBeBuyed() { }
}

