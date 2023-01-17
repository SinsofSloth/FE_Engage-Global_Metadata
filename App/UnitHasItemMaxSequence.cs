// Namespace: App
public class UnitHasItemMaxSequence : SingletonProcInst<UnitHasItemMaxSequence> // TypeDefIndex: 13014
{
	// Fields
	private Unit m_Unit; // 0x78
	private UnitItem m_GainUnitItem; // 0x80
	private string m_Label; // 0x88
	private bool m_IsSendingUnitItem; // 0x90
	private int m_SendingUnitItemIndex; // 0x94
	private bool m_IsDiscarding; // 0x98
	private bool m_IsDiscardingTransporterItem; // 0x99
	private int m_DiscardingTransporterItemIndex; // 0x9C

	// Methods

	// RVA: 0x23E8FD0 Offset: 0x23E90D1 VA: 0x23E8FD0
	public static void CreateBind(ProcInst super, Unit unit, UnitItem unitItem, string label) { }

	// RVA: 0x23E9070 Offset: 0x23E9171 VA: 0x23E9070
	private void .ctor(Unit unit, UnitItem unitItem, string label) { }

	// RVA: 0x23E9140 Offset: 0x23E9241 VA: 0x23E9140
	private ProcDesc[] CreateDescs() { }

	// RVA: 0x23E95A0 Offset: 0x23E96A1 VA: 0x23E95A0
	private void ShowGetMessage() { }

	// RVA: 0x23E9630 Offset: 0x23E9731 VA: 0x23E9630
	private void CreateSendItemMenu() { }

	// RVA: 0x23E96E0 Offset: 0x23E97E1 VA: 0x23E96E0
	private void BranchDiscardOrExecute() { }

	// RVA: 0x23E9760 Offset: 0x23E9861 VA: 0x23E9760
	private void CreateDiscardItemMenu() { }

	// RVA: 0x23E9880 Offset: 0x23E9981 VA: 0x23E9880
	private void Execute() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CAD90 Offset: 0x2CAE91 VA: 0x2CAD90
	// RVA: 0x23E9A00 Offset: 0x23E9B01 VA: 0x23E9A00
	private void <CreateSendItemMenu>b__13_0(bool isSelectedUnitItem, int unitItemIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CADA0 Offset: 0x2CAEA1 VA: 0x2CADA0
	// RVA: 0x23E9A10 Offset: 0x23E9B11 VA: 0x23E9A10
	private void <CreateDiscardItemMenu>b__15_0(bool transporterIsSelected, int transporterItemIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CADB0 Offset: 0x2CAEB1 VA: 0x2CADB0
	// RVA: 0x23E9A30 Offset: 0x23E9B31 VA: 0x23E9A30
	private void <CreateDiscardItemMenu>b__15_1() { }
}

