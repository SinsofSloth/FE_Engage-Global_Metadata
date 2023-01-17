// Namespace: App
public class InventoryPoolItemMenuItem : BasicItemMenuItem // TypeDefIndex: 13201
{
	// Fields
	private int m_OwnerItemIndex; // 0x64
	private Unit m_Unit; // 0x68
	private int m_SortIndex; // 0x70

	// Methods

	// RVA: 0x2B4FFF0 Offset: 0x2B500F1 VA: 0x2B4FFF0
	public void .ctor(Unit unit, int ownerItemIndex, int sortIndex) { }

	// RVA: 0x2B53ED0 Offset: 0x2B53FD1 VA: 0x2B53ED0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2B53EE0 Offset: 0x2B53FE1 VA: 0x2B53EE0 Slot: 33
	public override bool IsEffective() { }

	// RVA: 0x2B54000 Offset: 0x2B54101 VA: 0x2B54000 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2B54E60 Offset: 0x2B54F61 VA: 0x2B54E60 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2B55050 Offset: 0x2B55151 VA: 0x2B55050 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x2B55F10 Offset: 0x2B56011 VA: 0x2B55F10 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2B560C0 Offset: 0x2B561C1 VA: 0x2B560C0 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x2B560E0 Offset: 0x2B561E1 VA: 0x2B560E0 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x2B560F0 Offset: 0x2B561F1 VA: 0x2B560F0 Slot: 29
	protected override Unit GetRecieverUnit() { }

	// RVA: 0x2B561C0 Offset: 0x2B562C1 VA: 0x2B561C0
	public int GetSortIndex() { }

	// RVA: 0x2B561D0 Offset: 0x2B562D1 VA: 0x2B561D0 Slot: 34
	public virtual InventoryPoolItemMenuItem.PoolItemKind GetMenuItemKind() { }

	// RVA: 0x2B561E0 Offset: 0x2B562E1 VA: 0x2B561E0
	public void AddSelection() { }

	// RVA: 0x2B52300 Offset: 0x2B52401 VA: 0x2B52300
	public void HoldSelection() { }

	// RVA: 0x2B54230 Offset: 0x2B54331 VA: 0x2B54230
	private BasicMenu.Result GoToTrade() { }

	// RVA: 0x2B54CE0 Offset: 0x2B54DE1 VA: 0x2B54CE0
	private BasicMenu.Result GoToSubMenu() { }

	// RVA: 0x2B54470 Offset: 0x2B54571 VA: 0x2B54470
	private BasicMenu.Result DirectTrade() { }
}

