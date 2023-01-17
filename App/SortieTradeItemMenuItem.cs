// Namespace: App
public class SortieTradeItemMenuItem : BasicItemMenuItem // TypeDefIndex: 13292
{
	// Fields
	private Unit m_unit; // 0x68
	private Unit m_recieverUnit; // 0x70
	private int m_itemIndex; // 0x78
	public bool m_bDefaultSelect; // 0x7C
	private bool m_SelectableBlank; // 0x7D
	private bool m_EnabledToSelectBlank; // 0x7E
	private bool m_Disabled; // 0x7F

	// Methods

	// RVA: 0x2172840 Offset: 0x2172941 VA: 0x2172840
	public void .ctor(Unit unit, Unit recieverUnit, int index, bool defaultSelect = False, bool selectableBlank = False) { }

	// RVA: 0x2173370 Offset: 0x2173471 VA: 0x2173370 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2173450 Offset: 0x2173551 VA: 0x2173450 Slot: 32
	public override void SetInitialColor() { }

	// RVA: 0x21735E0 Offset: 0x21736E1 VA: 0x21735E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21736D0 Offset: 0x21737D1 VA: 0x21736D0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2173790 Offset: 0x2173891 VA: 0x2173790 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x21738B0 Offset: 0x21739B1 VA: 0x21738B0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x2173A40 Offset: 0x2173B41 VA: 0x2173A40 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x2172E00 Offset: 0x2172F01 VA: 0x2172E00
	public void SetSelect() { }

	// RVA: 0x2172C10 Offset: 0x2172D11 VA: 0x2172C10
	public void ClearSelect() { }

	// RVA: 0x2173B60 Offset: 0x2173C61 VA: 0x2173B60 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x2173B80 Offset: 0x2173C81 VA: 0x2173B80 Slot: 29
	protected override Unit GetRecieverUnit() { }

	// RVA: 0x2173090 Offset: 0x2173191 VA: 0x2173090
	public bool IsSelectable() { }

	// RVA: 0x2173B90 Offset: 0x2173C91 VA: 0x2173B90
	public bool IsSelectableBlank() { }

	// RVA: 0x2173160 Offset: 0x2173261 VA: 0x2173160
	public void EnableToSelectBlank(bool enabled) { }

	// RVA: 0x21731A0 Offset: 0x21732A1 VA: 0x21731A0
	public void SetAttributeDisable(bool value) { }

	// RVA: 0x21695A0 Offset: 0x21696A1 VA: 0x21695A0
	public bool IsNullOrEmpty() { }
}

