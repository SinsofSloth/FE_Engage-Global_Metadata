// Namespace: App
public class RefineGodWeaponSequence : ProcInst // TypeDefIndex: 11076
{
	// Fields
	private RefineGodWeaponTopMenu.Result2 m_ShopMenuResult; // 0x70
	private BasicMenu.Result m_MenuResult; // 0x74
	private ShopWeaponModelRenderer m_WeaponModelRenderer; // 0x78
	private RefineGodWeaponRoot m_RefineGodWeaponRoot; // 0x80
	private GodUnit m_GodUnit; // 0x88
	private ItemData m_GodWeapon; // 0x90
	private GodWeaponRefineData.Kind m_RefineKind; // 0x98
	private int m_WeaponSelectMenuScrollIndex; // 0x9C

	// Methods

	// RVA: 0x277D9B0 Offset: 0x277DAB1 VA: 0x277D9B0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x277DA30 Offset: 0x277DB31 VA: 0x277DA30
	private void .ctor() { }

	// RVA: 0x277DA40 Offset: 0x277DB41 VA: 0x277DA40
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x277EA90 Offset: 0x277EB91 VA: 0x277EA90
	private void LoadResources() { }

	// RVA: 0x277EBA0 Offset: 0x277ECA1 VA: 0x277EBA0
	private bool IsLoadingResources() { }

	// RVA: 0x277ECC0 Offset: 0x277EDC1 VA: 0x277ECC0
	private void StartSequence() { }

	// RVA: 0x277ED70 Offset: 0x277EE71 VA: 0x277ED70
	private void CreateRefineGodWeaponTopMenu() { }

	// RVA: 0x277EFE0 Offset: 0x277F0E1 VA: 0x277EFE0
	private void CreateRefineGodWeaponRoot() { }

	// RVA: 0x277F060 Offset: 0x277F161 VA: 0x277F060
	private void DestroyRefineGodWeaponRoot() { }

	// RVA: 0x277F110 Offset: 0x277F211 VA: 0x277F110
	private void CreateRefineGodWeaponSelectMenu() { }

	// RVA: 0x277F3E0 Offset: 0x277F4E1 VA: 0x277F3E0
	private void CreateRefineGodWeaponParamMenu() { }

	// RVA: 0x277F600 Offset: 0x277F701 VA: 0x277F600
	private void CreateRefineGodWeaponSelectMenuForReset() { }

	// RVA: 0x277F8D0 Offset: 0x277F9D1 VA: 0x277F8D0
	private void CreateRefineGodWeaponParamMenuForReset() { }

	// RVA: 0x277FAF0 Offset: 0x277FBF1 VA: 0x277FAF0
	private void EndSequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3420 Offset: 0x2C3521 VA: 0x2C3420
	// RVA: 0x277FC50 Offset: 0x277FD51 VA: 0x277FC50
	private bool <CreateDesc>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3430 Offset: 0x2C3531 VA: 0x2C3430
	// RVA: 0x277FC60 Offset: 0x277FD61 VA: 0x277FC60
	private bool <CreateDesc>b__11_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3440 Offset: 0x2C3541 VA: 0x2C3440
	// RVA: 0x277FC70 Offset: 0x277FD71 VA: 0x277FC70
	private bool <CreateDesc>b__11_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3450 Offset: 0x2C3551 VA: 0x2C3450
	// RVA: 0x277FC80 Offset: 0x277FD81 VA: 0x277FC80
	private bool <CreateDesc>b__11_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3460 Offset: 0x2C3561 VA: 0x2C3460
	// RVA: 0x277FC90 Offset: 0x277FD91 VA: 0x277FC90
	private bool <CreateDesc>b__11_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3470 Offset: 0x2C3571 VA: 0x2C3470
	// RVA: 0x277FCA0 Offset: 0x277FDA1 VA: 0x277FCA0
	private bool <CreateDesc>b__11_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3480 Offset: 0x2C3581 VA: 0x2C3480
	// RVA: 0x277FCB0 Offset: 0x277FDB1 VA: 0x277FCB0
	private bool <CreateDesc>b__11_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3490 Offset: 0x2C3591 VA: 0x2C3490
	// RVA: 0x277FCC0 Offset: 0x277FDC1 VA: 0x277FCC0
	private bool <CreateDesc>b__11_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C34A0 Offset: 0x2C35A1 VA: 0x2C34A0
	// RVA: 0x277FCD0 Offset: 0x277FDD1 VA: 0x277FCD0
	private void <CreateRefineGodWeaponTopMenu>b__15_0(RefineGodWeaponTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C34B0 Offset: 0x2C35B1 VA: 0x2C34B0
	// RVA: 0x277FCE0 Offset: 0x277FDE1 VA: 0x277FCE0
	private void <CreateRefineGodWeaponSelectMenu>b__18_0(BasicMenu.Result r, GodUnit godUnit, UnitItem godWeapon, int scrollIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C34C0 Offset: 0x2C35C1 VA: 0x2C34C0
	// RVA: 0x277FE80 Offset: 0x277FF81 VA: 0x277FE80
	private void <CreateRefineGodWeaponParamMenu>b__19_0(BasicMenu.Result r, ItemData godWeapon) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C34D0 Offset: 0x2C35D1 VA: 0x2C34D0
	// RVA: 0x277FE90 Offset: 0x277FF91 VA: 0x277FE90
	private void <CreateRefineGodWeaponSelectMenuForReset>b__20_0(BasicMenu.Result r, GodUnit godUnit, UnitItem godWeapon, int scrollIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C34E0 Offset: 0x2C35E1 VA: 0x2C34E0
	// RVA: 0x2780030 Offset: 0x2780131 VA: 0x2780030
	private void <CreateRefineGodWeaponParamMenuForReset>b__21_0(BasicMenu.Result r, ItemData godWeapon) { }
}

