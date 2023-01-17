// Namespace: App
public class RefreshUnitSelectMenu : BasicMenu // TypeDefIndex: 11705
{
	// Fields
	private static readonly int m_MenuItemIndexNone; // 0x0
	private static readonly int m_MenuItemIndexEmpty; // 0x4
	private int m_DecidedMenuItemIndex; // 0xC4
	private Unit m_UnselectableUnit; // 0xC8
	private RefreshUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private RefreshUnitSelectMenu.CloseEventHandler m_CloseEventHandler; // 0xD8
	private RefreshUnitSelectMenu.DisposeEventHandler m_DisposeEventHandler; // 0xE0

	// Methods

	// RVA: 0x252E6B0 Offset: 0x252E7B1 VA: 0x252E6B0
	public static RefreshUnitSelectMenu CreateBind(ProcInst super, RefreshUnitSelectMenuContent menuContent, Unit initialSelectedUnit, Unit unselectableUnit, bool selectedEntrust, int initialScrollIndex, RefreshUnitSelectMenu.SelectEventHandler selectEventHandler, RefreshUnitSelectMenu.DecideEventHandler decideEventHandler, RefreshUnitSelectMenu.CloseEventHandler closeEventHandler, RefreshUnitSelectMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2530030 Offset: 0x2530131 VA: 0x2530030
	private static List<BasicMenuItem> CreateMenuItem(Unit initialSelectedUnit, Unit unselectableUnit, bool selectedEntrust, RefreshUnitSelectMenu.SelectEventHandler selectEventHandler, RefreshUnitSelectMenu.DecideEventHandler decideEventHandler, out int initialSelectIndex) { }

	// RVA: 0x2530340 Offset: 0x2530441 VA: 0x2530340
	private void .ctor(List<BasicMenuItem> menuItemList, RefreshUnitSelectMenuContent menuContent, int initialSelectIndex, Unit unselectableUnit, int initialScrollIndex, RefreshUnitSelectMenu.DecideEventHandler decideEventHandler, RefreshUnitSelectMenu.CloseEventHandler closeEventHandler, RefreshUnitSelectMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x25304A0 Offset: 0x25305A1 VA: 0x25304A0 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x25305C0 Offset: 0x25306C1 VA: 0x25305C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2530610 Offset: 0x2530711 VA: 0x2530610 Slot: 35
	public override void AdjustScrollIndex() { }

	// RVA: 0x2530650 Offset: 0x2530751 VA: 0x2530650
	public Unit GetUnselectableUnit() { }

	// RVA: 0x2530660 Offset: 0x2530761 VA: 0x2530660
	public bool SetDecidedMenuItem(int menuItemIndex) { }

	// RVA: 0x2530940 Offset: 0x2530A41 VA: 0x2530940
	public void CancelSetDecidedMenuItem() { }

	// RVA: 0x2530AF0 Offset: 0x2530BF1 VA: 0x2530AF0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2530B30 Offset: 0x2530C31 VA: 0x2530B30 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2530B50 Offset: 0x2530C51 VA: 0x2530B50 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2530C30 Offset: 0x2530D31 VA: 0x2530C30
	private static void .cctor() { }
}

