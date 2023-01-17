// Namespace: App
public class InventoryUnitItemMenuItem : BasicItemMenuItem // TypeDefIndex: 13224
{
	// Fields
	private int m_OwnerItemIndex; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x29BCC0 Offset: 0x29BDC1 VA: 0x29BCC0
	private bool <m_SelectableBlank>k__BackingField; // 0x68

	// Properties
	public bool m_SelectableBlank { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB640 Offset: 0x2CB741 VA: 0x2CB640
	// RVA: 0x2B589B0 Offset: 0x2B58AB1 VA: 0x2B589B0
	public bool get_m_SelectableBlank() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB650 Offset: 0x2CB751 VA: 0x2CB650
	// RVA: 0x2B589C0 Offset: 0x2B58AC1 VA: 0x2B589C0
	private void set_m_SelectableBlank(bool value) { }

	// RVA: 0x2B57210 Offset: 0x2B57311 VA: 0x2B57210
	public void .ctor(int ownerItemIndex, bool selectableBlank) { }

	// RVA: 0x2B589D0 Offset: 0x2B58AD1 VA: 0x2B589D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2B58A90 Offset: 0x2B58B91 VA: 0x2B58A90 Slot: 33
	public override bool IsEffective() { }

	// RVA: 0x2B58BB0 Offset: 0x2B58CB1 VA: 0x2B58BB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2B59AD0 Offset: 0x2B59BD1 VA: 0x2B59AD0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2B59C50 Offset: 0x2B59D51 VA: 0x2B59C50 Slot: 26
	public override BasicMenu.Result CustomCall() { }

	// RVA: 0x2B5A570 Offset: 0x2B5A671 VA: 0x2B5A570 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2B5A630 Offset: 0x2B5A731 VA: 0x2B5A630 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x2B5A6B0 Offset: 0x2B5A7B1 VA: 0x2B5A6B0 Slot: 29
	protected override Unit GetRecieverUnit() { }

	// RVA: 0x2B5A6C0 Offset: 0x2B5A7C1 VA: 0x2B5A6C0
	public int GetUnitItemIndex() { }

	// RVA: 0x2B5A6D0 Offset: 0x2B5A7D1 VA: 0x2B5A6D0 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x2B5A720 Offset: 0x2B5A821 VA: 0x2B5A720
	public void AddSelection() { }

	// RVA: 0x2B5A7F0 Offset: 0x2B5A8F1 VA: 0x2B5A7F0
	public void RemoveSelection() { }

	// RVA: 0x2B57990 Offset: 0x2B57A91 VA: 0x2B57990
	public void HoldSelection() { }

	// RVA: 0x2B59950 Offset: 0x2B59A51 VA: 0x2B59950
	private BasicMenu.Result GoToSubMenu() { }

	// RVA: 0x2B58DE0 Offset: 0x2B58EE1 VA: 0x2B58DE0
	private BasicMenu.Result GoToTrade() { }

	// RVA: 0x2B597D0 Offset: 0x2B598D1 VA: 0x2B597D0
	private BasicMenu.Result GoToPoolMenu() { }

	// RVA: 0x2B59000 Offset: 0x2B59101 VA: 0x2B59000
	private BasicMenu.Result DirectTrade() { }
}

