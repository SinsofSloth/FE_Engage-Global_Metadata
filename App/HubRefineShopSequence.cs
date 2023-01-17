// Namespace: App
public class HubRefineShopSequence : ProcInst // TypeDefIndex: 11008
{
	// Fields
	private ShopWeaponModelRenderer m_WeaponModelRenderer; // 0x70
	private RefineShopRefineBaseRoot m_RefineShopRefineBaseRoot; // 0x78
	private RefineShopRefineTargetRoot m_RefineShopRefineTargetRoot; // 0x80
	private RefineShopEngraveItemSelectRoot m_RefineShopEngraveItemSelectRoot; // 0x88
	private RefineShopEngraveGodRoot m_RefineShopEngraveGodRoot; // 0x90
	private RefineShopEngraveDemoRoot m_RefineShopEngraveDemoRoot; // 0x98
	private RefineShopExchangeMenuTop m_RefineShopExchangeMenuTop; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x2961C0 Offset: 0x2962C1 VA: 0x2961C0
	private RefineShopTopMenu.Result2 <m_TopMenuResult>k__BackingField; // 0xA8
	private BasicMenu.Result m_Result; // 0xAC
	private Unit m_Unit; // 0xB0
	private int m_OwnerItemIndex; // 0xB8
	private UnitItem m_BaseUnitItem; // 0xC0
	private UnitItem m_AfterUnitItem; // 0xC8
	private GodData m_GodData; // 0xD0
	private ItemData.Kinds m_Kind; // 0xD8

	// Properties
	public RefineShopTopMenu.Result2 m_TopMenuResult { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2E30 Offset: 0x2C2F31 VA: 0x2C2E30
	// RVA: 0x28BFC70 Offset: 0x28BFD71 VA: 0x28BFC70
	public RefineShopTopMenu.Result2 get_m_TopMenuResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E40 Offset: 0x2C2F41 VA: 0x2C2E40
	// RVA: 0x28BFC80 Offset: 0x28BFD81 VA: 0x28BFC80
	private void set_m_TopMenuResult(RefineShopTopMenu.Result2 value) { }

	// RVA: 0x28B52B0 Offset: 0x28B53B1 VA: 0x28B52B0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x28BFC90 Offset: 0x28BFD91 VA: 0x28BFC90
	private void .ctor() { }

	// RVA: 0x28BFCA0 Offset: 0x28BFDA1 VA: 0x28BFCA0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x28C10C0 Offset: 0x28C11C1 VA: 0x28C10C0
	private void LoadResources() { }

	// RVA: 0x28C11C0 Offset: 0x28C12C1 VA: 0x28C11C0
	private bool IsLoadingResources() { }

	// RVA: 0x28C12A0 Offset: 0x28C13A1 VA: 0x28C12A0
	private void StartSequence() { }

	// RVA: 0x28C1380 Offset: 0x28C1481 VA: 0x28C1380
	private void CreateRefineShopTopMenu() { }

	// RVA: 0x28C1610 Offset: 0x28C1711 VA: 0x28C1610
	private void CreateRefineShopRefineMenu() { }

	// RVA: 0x28C18B0 Offset: 0x28C19B1 VA: 0x28C18B0
	private void DestroyRefineShopRefineMenu() { }

	// RVA: 0x28C18F0 Offset: 0x28C19F1 VA: 0x28C18F0
	private void CreateRefineShopRefineTargetMenu() { }

	// RVA: 0x28C1AC0 Offset: 0x28C1BC1 VA: 0x28C1AC0
	private void DestroyRefineShopRefineTargetMenu() { }

	// RVA: 0x28C1B00 Offset: 0x28C1C01 VA: 0x28C1B00
	private void CreateRefineShopEngraveItemSelectMenu() { }

	// RVA: 0x28C1DA0 Offset: 0x28C1EA1 VA: 0x28C1DA0
	private void DestroyRefineShopEngraveItemSelectMenu() { }

	// RVA: 0x28C1DE0 Offset: 0x28C1EE1 VA: 0x28C1DE0
	private void CreateRefineShopEngraveGodMenu() { }

	// RVA: 0x28C1FB0 Offset: 0x28C20B1 VA: 0x28C1FB0
	private void DestroyRefineShopEngraveGodMenu() { }

	// RVA: 0x28C1FF0 Offset: 0x28C20F1 VA: 0x28C1FF0
	private void PrepareRefineShopEngraveDemo() { }

	// RVA: 0x28C2000 Offset: 0x28C2101 VA: 0x28C2000
	private bool WaitPreparingRefineShopEngraveDemo() { }

	// RVA: 0x28C2010 Offset: 0x28C2111 VA: 0x28C2010
	private void CreateRefineShopEngraveDemo() { }

	// RVA: 0x28C2030 Offset: 0x28C2131 VA: 0x28C2030
	private void DestroyRefineShopEngraveDemo() { }

	// RVA: 0x28C20E0 Offset: 0x28C21E1 VA: 0x28C20E0
	private void CreateRefineShopExchangeMenu() { }

	// RVA: 0x28C23C0 Offset: 0x28C24C1 VA: 0x28C23C0
	private void DestroyRefineShopExchangeMenu() { }

	// RVA: 0x28C23D0 Offset: 0x28C24D1 VA: 0x28C23D0
	private void HideTitle() { }

	// RVA: 0x28C24F0 Offset: 0x28C25F1 VA: 0x28C24F0
	private void ShowTitle() { }

	// RVA: 0x28C2610 Offset: 0x28C2711 VA: 0x28C2610
	private void EndSequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E50 Offset: 0x2C2F51 VA: 0x2C2E50
	// RVA: 0x28C28A0 Offset: 0x28C29A1 VA: 0x28C28A0
	private bool <CreateDesc>b__21_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E60 Offset: 0x2C2F61 VA: 0x2C2E60
	// RVA: 0x28C28B0 Offset: 0x28C29B1 VA: 0x28C28B0
	private bool <CreateDesc>b__21_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E70 Offset: 0x2C2F71 VA: 0x2C2E70
	// RVA: 0x28C28C0 Offset: 0x28C29C1 VA: 0x28C28C0
	private bool <CreateDesc>b__21_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E80 Offset: 0x2C2F81 VA: 0x2C2E80
	// RVA: 0x28C28D0 Offset: 0x28C29D1 VA: 0x28C28D0
	private bool <CreateDesc>b__21_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E90 Offset: 0x2C2F91 VA: 0x2C2E90
	// RVA: 0x28C28E0 Offset: 0x28C29E1 VA: 0x28C28E0
	private bool <CreateDesc>b__21_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2EA0 Offset: 0x2C2FA1 VA: 0x2C2EA0
	// RVA: 0x28C28F0 Offset: 0x28C29F1 VA: 0x28C28F0
	private bool <CreateDesc>b__21_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2EB0 Offset: 0x2C2FB1 VA: 0x2C2EB0
	// RVA: 0x28C2900 Offset: 0x28C2A01 VA: 0x28C2900
	private bool <CreateDesc>b__21_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2EC0 Offset: 0x2C2FC1 VA: 0x2C2EC0
	// RVA: 0x28C2910 Offset: 0x28C2A11 VA: 0x28C2910
	private bool <CreateDesc>b__21_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2ED0 Offset: 0x2C2FD1 VA: 0x2C2ED0
	// RVA: 0x28C2920 Offset: 0x28C2A21 VA: 0x28C2920
	private bool <CreateDesc>b__21_8() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2EE0 Offset: 0x2C2FE1 VA: 0x2C2EE0
	// RVA: 0x28C2930 Offset: 0x28C2A31 VA: 0x28C2930
	private bool <CreateDesc>b__21_9() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2EF0 Offset: 0x2C2FF1 VA: 0x2C2EF0
	// RVA: 0x28C2940 Offset: 0x28C2A41 VA: 0x28C2940
	private void <CreateRefineShopTopMenu>b__25_0(RefineShopTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F00 Offset: 0x2C3001 VA: 0x2C2F00
	// RVA: 0x28C2950 Offset: 0x28C2A51 VA: 0x28C2950
	private void <CreateRefineShopRefineMenu>b__26_0(BasicMenu.Result r, Unit unit, int ownerItemIndex, ItemData.Kinds kind) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F10 Offset: 0x2C3011 VA: 0x2C2F10
	// RVA: 0x28C29A0 Offset: 0x28C2AA1 VA: 0x28C29A0
	private void <CreateRefineShopRefineTargetMenu>b__28_0(UnitItem afterUnitItem) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F20 Offset: 0x2C3021 VA: 0x2C2F20
	// RVA: 0x28C2A50 Offset: 0x28C2B51 VA: 0x28C2A50
	private void <CreateRefineShopEngraveItemSelectMenu>b__30_0(BasicMenu.Result r, Unit unit, int ownerItemIndex, ItemData.Kinds kind) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F30 Offset: 0x2C3031 VA: 0x2C2F30
	// RVA: 0x28C2B20 Offset: 0x28C2C21 VA: 0x28C2B20
	private void <CreateRefineShopEngraveGodMenu>b__32_0(BasicMenu.Result r, GodData godData, UnitItem afterUnitItem) { }
}

