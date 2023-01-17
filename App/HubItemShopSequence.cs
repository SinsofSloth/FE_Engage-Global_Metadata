// Namespace: App
public class HubItemShopSequence : ProcInst // TypeDefIndex: 11005
{
	// Fields
	protected ItemShopTopMenu.Result2 m_ShopMenuResult; // 0x70
	protected BasicMenu.Result m_ShopUnitSelectMenuResult; // 0x74
	protected ShopUnitSelectRoot m_UnitSelectRoot; // 0x78
	protected ItemShopBuyRoot m_ItemShopBuyRoot; // 0x80
	protected ShopSellRoot m_ItemShopSellRoot; // 0x88
	protected Unit m_Unit; // 0x90
	protected int m_UnitSelectMenuScrollIndex; // 0x98

	// Methods

	// RVA: 0x2BDB3B0 Offset: 0x2BDB4B1 VA: 0x2BDB3B0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2BDB430 Offset: 0x2BDB531 VA: 0x2BDB430
	protected void .ctor() { }

	// RVA: 0x2BDB440 Offset: 0x2BDB541 VA: 0x2BDB440
	protected ProcDesc[] CreateDesc() { }

	// RVA: 0x2BDC3B0 Offset: 0x2BDC4B1 VA: 0x2BDC3B0
	private void LoadResources() { }

	// RVA: 0x2BDC3E0 Offset: 0x2BDC4E1 VA: 0x2BDC3E0
	private bool IsLoadingResources() { }

	// RVA: 0x2BDC430 Offset: 0x2BDC531 VA: 0x2BDC430
	private void StartSequence() { }

	// RVA: 0x2BDC560 Offset: 0x2BDC661 VA: 0x2BDC560 Slot: 18
	protected virtual void CreateItemShopTopMenu() { }

	// RVA: 0x2BDC790 Offset: 0x2BDC891 VA: 0x2BDC790
	private void CreateShopUnitSelectMenu() { }

	// RVA: 0x2BDCA20 Offset: 0x2BDCB21 VA: 0x2BDCA20
	private void DestroyShopUnitSelectMenu() { }

	// RVA: 0x2BDCA60 Offset: 0x2BDCB61 VA: 0x2BDCA60 Slot: 19
	protected virtual void CreateItemShopBuyMenu() { }

	// RVA: 0x2BDCC30 Offset: 0x2BDCD31 VA: 0x2BDCC30
	private void DestroyItemShopBuyMenu() { }

	// RVA: 0x2BDCC70 Offset: 0x2BDCD71 VA: 0x2BDCC70
	private void CreateItemShopSellMenu() { }

	// RVA: 0x2BDCE40 Offset: 0x2BDCF41 VA: 0x2BDCE40
	private void DestroyItemShopSellMenu() { }

	// RVA: 0x2BDCE80 Offset: 0x2BDCF81 VA: 0x2BDCE80
	private void EndSequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D80 Offset: 0x2C2E81 VA: 0x2C2D80
	// RVA: 0x2BDD080 Offset: 0x2BDD181 VA: 0x2BDD080
	private bool <CreateDesc>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D90 Offset: 0x2C2E91 VA: 0x2C2D90
	// RVA: 0x2BDD090 Offset: 0x2BDD191 VA: 0x2BDD090
	private bool <CreateDesc>b__10_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2DA0 Offset: 0x2C2EA1 VA: 0x2C2DA0
	// RVA: 0x2BDD0A0 Offset: 0x2BDD1A1 VA: 0x2BDD0A0
	private bool <CreateDesc>b__10_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2DB0 Offset: 0x2C2EB1 VA: 0x2C2DB0
	// RVA: 0x2BDD0B0 Offset: 0x2BDD1B1 VA: 0x2BDD0B0
	private bool <CreateDesc>b__10_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2DC0 Offset: 0x2C2EC1 VA: 0x2C2DC0
	// RVA: 0x2BDD0C0 Offset: 0x2BDD1C1 VA: 0x2BDD0C0
	private bool <CreateDesc>b__10_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2DD0 Offset: 0x2C2ED1 VA: 0x2C2DD0
	// RVA: 0x2BDD0D0 Offset: 0x2BDD1D1 VA: 0x2BDD0D0
	private bool <CreateDesc>b__10_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2DE0 Offset: 0x2C2EE1 VA: 0x2C2DE0
	// RVA: 0x2BDD0E0 Offset: 0x2BDD1E1 VA: 0x2BDD0E0
	private bool <CreateDesc>b__10_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2DF0 Offset: 0x2C2EF1 VA: 0x2C2DF0
	// RVA: 0x2BDD0F0 Offset: 0x2BDD1F1 VA: 0x2BDD0F0
	private void <CreateItemShopTopMenu>b__14_0(ItemShopTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E00 Offset: 0x2C2F01 VA: 0x2C2E00
	// RVA: 0x2BDD100 Offset: 0x2BDD201 VA: 0x2BDD100
	private void <CreateShopUnitSelectMenu>b__15_0(BasicMenu.Result r, Unit unit, int scrollIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E10 Offset: 0x2C2F11 VA: 0x2C2E10
	// RVA: 0x2BDD140 Offset: 0x2BDD241 VA: 0x2BDD140
	private void <CreateItemShopBuyMenu>b__17_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2E20 Offset: 0x2C2F21 VA: 0x2C2E20
	// RVA: 0x2BDD150 Offset: 0x2BDD251 VA: 0x2BDD150
	private void <CreateItemShopSellMenu>b__19_0(Unit unit) { }
}

