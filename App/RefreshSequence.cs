// Namespace: App
public class RefreshSequence : ProcInst // TypeDefIndex: 11700
{
	// Fields
	private static readonly string m_RelianceExpParamName; // 0x0
	private RefreshUnitSelectRoot m_RefreshUnitSelectRoot; // 0x70
	private string m_FacilityAid; // 0x78
	private bool m_EnteredFromFacility; // 0x80
	private Unit[] m_Unit; // 0x88
	private int m_UnitIndex; // 0x90
	private bool[,] m_SelectedEntrustAtLast; // 0x98
	private bool m_AddedRelianceExp; // 0xA0
	private RefreshUnitSetMenu m_UnitSetMenu; // 0xA8
	private RefreshUnitSetMenu.Result2 m_UnitSetMenuResult; // 0xB0
	private RefreshConfirmDialog.Result2 m_ConfirmDialogResult; // 0xB4
	private int m_UnitSelectMenuScrollIndex; // 0xB8

	// Methods

	// RVA: 0x252B970 Offset: 0x252BA71 VA: 0x252B970
	public static void CreateBind(ProcInst super, string aid) { }

	// RVA: 0x252B9F0 Offset: 0x252BAF1 VA: 0x252B9F0
	private void .ctor(string aid) { }

	// RVA: 0x252BD30 Offset: 0x252BE31 VA: 0x252BD30
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x252BFF0 Offset: 0x252C0F1 VA: 0x252BFF0
	private bool HadVisited() { }

	// RVA: 0x252C060 Offset: 0x252C161 VA: 0x252C060
	private void ShowAlreadyVisitedDialog() { }

	// RVA: 0x252C0F0 Offset: 0x252C1F1 VA: 0x252C0F0
	private void LoadResources() { }

	// RVA: 0x252C230 Offset: 0x252C331 VA: 0x252C230
	private bool IsLoadingResources() { }

	// RVA: 0x252C330 Offset: 0x252C431 VA: 0x252C330
	private void StartSequence() { }

	// RVA: 0x252C7A0 Offset: 0x252C8A1 VA: 0x252C7A0
	private void CreateUnitSelectRoot() { }

	// RVA: 0x252CFD0 Offset: 0x252D0D1 VA: 0x252CFD0
	private void CreateFacilitySelectMenu() { }

	// RVA: 0x252D450 Offset: 0x252D551 VA: 0x252D450
	private void CreateUnitSet() { }

	// RVA: 0x252E210 Offset: 0x252E311 VA: 0x252E210
	private void CreateUnitSelect() { }

	// RVA: 0x252E810 Offset: 0x252E911 VA: 0x252E810
	private void ShowConfirmDialog() { }

	// RVA: 0x252E960 Offset: 0x252EA61 VA: 0x252E960
	private void CloseUnitSelectRoot() { }

	// RVA: 0x252EC10 Offset: 0x252ED11 VA: 0x252EC10
	private bool IsClosedUnitSelectRoot() { }

	// RVA: 0x252ED70 Offset: 0x252EE71 VA: 0x252ED70
	private void DestroyUnitSelectRoot() { }

	// RVA: 0x252EE90 Offset: 0x252EF91 VA: 0x252EE90
	private void CalcReliance() { }

	// RVA: 0x252F180 Offset: 0x252F281 VA: 0x252F180
	private void CreateDemo() { }

	// RVA: 0x252F290 Offset: 0x252F391 VA: 0x252F290
	private void ShowResultDialog() { }

	// RVA: 0x252F4E0 Offset: 0x252F5E1 VA: 0x252F4E0
	private void EndSequence() { }

	// RVA: 0x252F620 Offset: 0x252F721 VA: 0x252F620
	private void UnloadResources() { }

	// RVA: 0x252F720 Offset: 0x252F821 VA: 0x252F720
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6390 Offset: 0x2C6491 VA: 0x2C6390
	// RVA: 0x252F7A0 Offset: 0x252F8A1 VA: 0x252F7A0
	private void <CreateFacilitySelectMenu>b__22_1(HubFacilityData data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C63A0 Offset: 0x2C64A1 VA: 0x2C63A0
	// RVA: 0x252F7B0 Offset: 0x252F8B1 VA: 0x252F7B0
	private void <CreateFacilitySelectMenu>b__22_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C63B0 Offset: 0x2C64B1 VA: 0x2C63B0
	// RVA: 0x252F7F0 Offset: 0x252F8F1 VA: 0x252F7F0
	private void <ShowConfirmDialog>b__25_0(RefreshConfirmDialog.Result2 result) { }
}

