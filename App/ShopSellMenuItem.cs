// Namespace: App
public class ShopSellMenuItem : BasicMenuItem // TypeDefIndex: 11198
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296EF0 Offset: 0x296FF1 VA: 0x296EF0
	private Unit <m_Unit>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x296F00 Offset: 0x297001 VA: 0x296F00
	private int <m_ItemIndex>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296F10 Offset: 0x297011 VA: 0x296F10
	private UnitItem <m_UnitItem>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296F20 Offset: 0x297021 VA: 0x296F20
	private bool <m_Decided>k__BackingField; // 0x80
	private Color m_activeTextColor2; // 0x84
	private Color m_inactiveTextColor2; // 0x94
	private ShopSellMenu.SelectEventHandler m_SelectEventHandler; // 0xA8
	private ShopSellMenuItem.DecideItemEventHandler m_DecideItemEventHandler; // 0xB0
	private ShopSellMenuItem.CancelItemEventHandler m_CancelItemEventHandler; // 0xB8
	private ShopSellMenu.DecideEventHandler m_DecideEventHandler; // 0xC0
	private ShopSellMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0xC8
	private ShopSellMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x296F30 Offset: 0x297031 VA: 0x296F30
	private long <m_SortValue>k__BackingField; // 0xD8

	// Properties
	public Unit m_Unit { get; set; }
	public int m_ItemIndex { get; set; }
	public UnitItem m_UnitItem { get; set; }
	public bool m_Decided { get; set; }
	public long m_SortValue { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3CD0 Offset: 0x2C3DD1 VA: 0x2C3CD0
	// RVA: 0x2339200 Offset: 0x2339301 VA: 0x2339200
	public Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3CE0 Offset: 0x2C3DE1 VA: 0x2C3CE0
	// RVA: 0x2339210 Offset: 0x2339311 VA: 0x2339210
	private void set_m_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3CF0 Offset: 0x2C3DF1 VA: 0x2C3CF0
	// RVA: 0x2339220 Offset: 0x2339321 VA: 0x2339220
	public int get_m_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D00 Offset: 0x2C3E01 VA: 0x2C3D00
	// RVA: 0x2339230 Offset: 0x2339331 VA: 0x2339230
	private void set_m_ItemIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D10 Offset: 0x2C3E11 VA: 0x2C3D10
	// RVA: 0x2339240 Offset: 0x2339341 VA: 0x2339240
	public UnitItem get_m_UnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D20 Offset: 0x2C3E21 VA: 0x2C3D20
	// RVA: 0x2339250 Offset: 0x2339351 VA: 0x2339250
	private void set_m_UnitItem(UnitItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D30 Offset: 0x2C3E31 VA: 0x2C3D30
	// RVA: 0x2339260 Offset: 0x2339361 VA: 0x2339260
	public bool get_m_Decided() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D40 Offset: 0x2C3E41 VA: 0x2C3D40
	// RVA: 0x2339270 Offset: 0x2339371 VA: 0x2339270
	private void set_m_Decided(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D50 Offset: 0x2C3E51 VA: 0x2C3D50
	// RVA: 0x2339280 Offset: 0x2339381 VA: 0x2339280
	public long get_m_SortValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D60 Offset: 0x2C3E61 VA: 0x2C3D60
	// RVA: 0x2339290 Offset: 0x2339391 VA: 0x2339290
	private void set_m_SortValue(long value) { }

	// RVA: 0x2337240 Offset: 0x2337341 VA: 0x2337240
	public void .ctor(Unit unit, int itemIndex, bool decided, ShopSellMenu.SelectEventHandler selectEventHandler, ShopSellMenuItem.DecideItemEventHandler decideItemEventHandler, ShopSellMenuItem.CancelItemEventHandler cancelItemEventHandler, ShopSellMenu.DecideEventHandler decideEventHandler, ShopSellMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ShopSellMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler) { }

	// RVA: 0x23392A0 Offset: 0x23393A1 VA: 0x23392A0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2339310 Offset: 0x2339411 VA: 0x2339310 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2339510 Offset: 0x2339611 VA: 0x2339510 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2339520 Offset: 0x2339621 VA: 0x2339520
	public void SetInitialColor() { }

	// RVA: 0x2339890 Offset: 0x2339991 VA: 0x2339890
	public bool IsEffective() { }

	// RVA: 0x233A490 Offset: 0x233A591 VA: 0x233A490
	public void SetTextColor(Color activeColor, Color activeColor2, Color inactiveColor, Color inactiveColor2) { }

	// RVA: 0x2339410 Offset: 0x2339511 VA: 0x2339410
	private void SetDecide() { }

	// RVA: 0x2339320 Offset: 0x2339421 VA: 0x2339320
	private void SetNotDecide() { }

	// RVA: 0x233A6C0 Offset: 0x233A7C1 VA: 0x233A6C0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x233A780 Offset: 0x233A881 VA: 0x233A780 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x233A890 Offset: 0x233A991 VA: 0x233A890 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x233AA20 Offset: 0x233AB21 VA: 0x233AA20
	public void SetDecideItemEventHandler(ShopSellMenuItem.DecideItemEventHandler decideItemEventHandler) { }

	// RVA: 0x233AA30 Offset: 0x233AB31 VA: 0x233AA30
	public void SetCancelItemEventHandler(ShopSellMenuItem.CancelItemEventHandler cancelItemEventHandler) { }

	// RVA: 0x233AA40 Offset: 0x233AB41 VA: 0x233AA40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x233AA90 Offset: 0x233AB91 VA: 0x233AA90 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x233AAA0 Offset: 0x233ABA1 VA: 0x233AAA0 Slot: 26
	public override BasicMenu.Result CustomCall() { }
}

