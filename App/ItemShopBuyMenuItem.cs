// Namespace: App
public class ItemShopBuyMenuItem : BasicMenuItem // TypeDefIndex: 11019
{
	// Fields
	private string m_Iid; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x2961F0 Offset: 0x2962F1 VA: 0x2961F0
	private ItemData <m_ItemData>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296200 Offset: 0x296301 VA: 0x296200
	private UnitItem <m_UnitItem>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296210 Offset: 0x296311 VA: 0x296210
	private int <m_StockNum>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x296220 Offset: 0x296321 VA: 0x296220
	private bool <m_NewArrival>k__BackingField; // 0x84
	private Unit m_Unit; // 0x88
	private Color m_activeTextColor2; // 0x90
	private Color m_inactiveTextColor2; // 0xA0
	private ItemShopBuyMenu.SelectEventHandler m_SelectEventHandler; // 0xB0
	private ItemShopBuyMenu.DecideEventHandler m_DecideEventHandler; // 0xB8
	private ItemShopBuyMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0xC0
	private ItemShopBuyMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0xC8
	private bool m_ForFleaMarket; // 0xD0

	// Properties
	public ItemData m_ItemData { get; set; }
	public UnitItem m_UnitItem { get; set; }
	public int m_StockNum { get; set; }
	public bool m_NewArrival { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2FF0 Offset: 0x2C30F1 VA: 0x2C2FF0
	// RVA: 0x2457510 Offset: 0x2457611 VA: 0x2457510
	public ItemData get_m_ItemData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3000 Offset: 0x2C3101 VA: 0x2C3000
	// RVA: 0x2457520 Offset: 0x2457621 VA: 0x2457520
	private void set_m_ItemData(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3010 Offset: 0x2C3111 VA: 0x2C3010
	// RVA: 0x2457530 Offset: 0x2457631 VA: 0x2457530
	public UnitItem get_m_UnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3020 Offset: 0x2C3121 VA: 0x2C3020
	// RVA: 0x2457540 Offset: 0x2457641 VA: 0x2457540
	private void set_m_UnitItem(UnitItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3030 Offset: 0x2C3131 VA: 0x2C3030
	// RVA: 0x2457550 Offset: 0x2457651 VA: 0x2457550
	public int get_m_StockNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3040 Offset: 0x2C3141 VA: 0x2C3040
	// RVA: 0x2457560 Offset: 0x2457661 VA: 0x2457560
	private void set_m_StockNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3050 Offset: 0x2C3151 VA: 0x2C3050
	// RVA: 0x2457570 Offset: 0x2457671 VA: 0x2457570
	public bool get_m_NewArrival() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3060 Offset: 0x2C3161 VA: 0x2C3060
	// RVA: 0x2457580 Offset: 0x2457681 VA: 0x2457580
	private void set_m_NewArrival(bool value) { }

	// RVA: 0x24567F0 Offset: 0x24568F1 VA: 0x24567F0
	public void .ctor(ShopContent shopContent, Unit unit, ItemShopBuyMenu.SelectEventHandler selectEventHandler, ItemShopBuyMenu.DecideEventHandler decideEventHandler, ItemShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ItemShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, bool forFleaMarket) { }

	// RVA: 0x2457590 Offset: 0x2457691 VA: 0x2457590 Slot: 4
	public override string GetName() { }

	// RVA: 0x24575A0 Offset: 0x24576A1 VA: 0x24575A0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2457660 Offset: 0x2457761 VA: 0x2457660 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2457A50 Offset: 0x2457B51 VA: 0x2457A50 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2457670 Offset: 0x2457771 VA: 0x2457670
	public void SetInitialColor() { }

	// RVA: 0x2457C40 Offset: 0x2457D41 VA: 0x2457C40
	public bool IsEffective() { }

	// RVA: 0x2457A60 Offset: 0x2457B61 VA: 0x2457A60
	public void SetTextColor(Color activeColor1, Color activeColor2, Color inactiveColor1, Color inactiveColor2) { }

	// RVA: 0x2458870 Offset: 0x2458971 VA: 0x2458870 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x24588B0 Offset: 0x24589B1 VA: 0x24588B0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x24589C0 Offset: 0x2458AC1 VA: 0x24589C0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x2458B50 Offset: 0x2458C51 VA: 0x2458B50 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2456E50 Offset: 0x2456F51 VA: 0x2456E50
	public void OnDoneToBuy() { }

	// RVA: 0x2458BB0 Offset: 0x2458CB1 VA: 0x2458BB0 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x2458F70 Offset: 0x2459071 VA: 0x2458F70
	private int GetUnitItemEmptyCount() { }

	// RVA: 0x2458FA0 Offset: 0x24590A1 VA: 0x2458FA0
	public bool IsEnoughMoneyToBeBuyed() { }
}

