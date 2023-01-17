// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278B20 Offset: 0x278C21 VA: 0x278B20
[Serializable]
private sealed class SortieUnitSelect.UnitMenuItem.<>c // TypeDefIndex: 13322
{
	// Fields
	public static readonly SortieUnitSelect.UnitMenuItem.<>c <>9; // 0x0
	public static UnitSelectRingMenu.CloseEventHandler <>9__11_0; // 0x8

	// Methods

	// RVA: 0x21FA9C0 Offset: 0x21FAAC1 VA: 0x21FA9C0
	private static void .cctor() { }

	// RVA: 0x21FAA30 Offset: 0x21FAB31 VA: 0x21FAA30
	public void .ctor() { }

	// RVA: 0x21FAA40 Offset: 0x21FAB41 VA: 0x21FAA40
	internal void <LCall>b__11_0() { }
}

// Namespace: 
public class SortieUnitSelect.UnitMenuItem : BasicMenuItem // TypeDefIndex: 13323
{
	// Fields
	private Unit m_unit; // 0x68
	private bool m_CanSortieForRelay; // 0x70

	// Methods

	// RVA: 0x2047DC0 Offset: 0x2047EC1 VA: 0x2047DC0
	public void .ctor(Unit unit) { }

	// RVA: 0x2048360 Offset: 0x2048461 VA: 0x2048360
	public void .ctor(Unit unit, bool canSortieForRelay) { }

	// RVA: 0x20483B0 Offset: 0x20484B1 VA: 0x20483B0
	public Unit GetUnit() { }

	// RVA: 0x20483C0 Offset: 0x20484C1 VA: 0x20483C0 Slot: 4
	public override string GetName() { }

	// RVA: 0x20483D0 Offset: 0x20484D1 VA: 0x20483D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2048720 Offset: 0x2048821 VA: 0x2048720 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2049330 Offset: 0x2049431 VA: 0x2049330 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2049450 Offset: 0x2049551 VA: 0x2049450 Slot: 20
	public override BasicMenu.Result XCall() { }

	// RVA: 0x20494E0 Offset: 0x20495E1 VA: 0x20494E0 Slot: 24
	public override BasicMenu.Result PlusCall() { }

	// RVA: 0x2049610 Offset: 0x2049711 VA: 0x2049610 Slot: 22
	public override BasicMenu.Result LCall() { }

	// RVA: 0x2049860 Offset: 0x2049961 VA: 0x2049860 Slot: 23
	public override BasicMenu.Result RCall() { }

	// RVA: 0x20499D0 Offset: 0x2049AD1 VA: 0x20499D0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2049180 Offset: 0x2049281 VA: 0x2049180
	private static void CreateSubMenu(bool byDecision, BasicMenuItem parentMenuItem) { }

	// RVA: 0x2048F60 Offset: 0x2049061 VA: 0x2048F60
	private void CancelInventoryTrade() { }
}

// Namespace: 
public class SortieUnitSelect.UnitEmptyMenuItem : SortieUnitSelect.UnitMenuItem // TypeDefIndex: 13324
{
	// Methods

	// RVA: 0x2048130 Offset: 0x2048231 VA: 0x2048130
	public void .ctor() { }

	// RVA: 0x2048170 Offset: 0x2048271 VA: 0x2048170 Slot: 4
	public override string GetName() { }

	// RVA: 0x20481C0 Offset: 0x20482C1 VA: 0x20481C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x20481D0 Offset: 0x20482D1 VA: 0x20481D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20481E0 Offset: 0x20482E1 VA: 0x20481E0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x20482A0 Offset: 0x20483A1 VA: 0x20482A0 Slot: 20
	public override BasicMenu.Result XCall() { }

	// RVA: 0x20482B0 Offset: 0x20483B1 VA: 0x20482B0 Slot: 24
	public override BasicMenu.Result PlusCall() { }

	// RVA: 0x20482C0 Offset: 0x20483C1 VA: 0x20482C0 Slot: 22
	public override BasicMenu.Result LCall() { }

	// RVA: 0x20482D0 Offset: 0x20483D1 VA: 0x20482D0 Slot: 23
	public override BasicMenu.Result RCall() { }

	// RVA: 0x20482E0 Offset: 0x20483E1 VA: 0x20482E0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class SortieUnitSelect.ConfirmBattleSequence : ProcInst // TypeDefIndex: 13325
{
	// Fields
	private BasicMenu m_ParentMenu; // 0x70

	// Methods

	// RVA: 0x2047E00 Offset: 0x2047F01 VA: 0x2047E00
	public static void CreateBind(BasicMenu parentMenu) { }

	// RVA: 0x2048060 Offset: 0x2048161 VA: 0x2048060
	private void .ctor(BasicMenu parentMenu) { }

	// RVA: 0x20480A0 Offset: 0x20481A1 VA: 0x20480A0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x20480B0 Offset: 0x20481B1 VA: 0x20480B0
	private void CreateDialog() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278B30 Offset: 0x278C31 VA: 0x278B30
private sealed class SortieUnitSelect.<>c__DisplayClass4_0 // TypeDefIndex: 13326
{
	// Fields
	public List<BasicMenuItem> cannotItemList; // 0x10
	public List<BasicMenuItem> menuItemList; // 0x18

	// Methods

	// RVA: 0x2047CB0 Offset: 0x2047DB1 VA: 0x2047CB0
	public void .ctor() { }

	// RVA: 0x2047CC0 Offset: 0x2047DC1 VA: 0x2047CC0
	internal void <CreateMenuItemListForVersus>b__0(Unit unit) { }
}

