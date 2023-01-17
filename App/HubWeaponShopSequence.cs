// Namespace: App
public class HubWeaponShopSequence : ProcInst // TypeDefIndex: 11010
{
	// Fields
	protected WeaponShopTopMenu.Result2 m_ShopMenuResult; // 0x70
	protected BasicMenu.Result m_ShopUnitSelectMenuResult; // 0x74
	protected ShopUnitSelectRoot m_UnitSelectRoot; // 0x78
	protected WeaponShopBuyRoot m_WeaponShopBuyRoot; // 0x80
	protected ShopSellRoot m_WeaponShopSellRoot; // 0x88
	protected Unit m_Unit; // 0x90
	protected int m_UnitSelectMenuScrollIndex; // 0x98

	// Methods

	// RVA: 0x2D5FFD0 Offset: 0x2D600D1 VA: 0x2D5FFD0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2D60050 Offset: 0x2D60151 VA: 0x2D60050
	protected void .ctor() { }

	// RVA: 0x2D60060 Offset: 0x2D60161 VA: 0x2D60060
	protected ProcDesc[] CreateDesc() { }

	// RVA: 0x2D60FD0 Offset: 0x2D610D1 VA: 0x2D60FD0
	private void LoadResources() { }

	// RVA: 0x2D61000 Offset: 0x2D61101 VA: 0x2D61000
	private bool IsLoadingResources() { }

	// RVA: 0x2D61050 Offset: 0x2D61151 VA: 0x2D61050
	private void StartSequence() { }

	// RVA: 0x2D61180 Offset: 0x2D61281 VA: 0x2D61180 Slot: 18
	protected virtual void CreateWeaponShopTopMenu() { }

	// RVA: 0x2D613B0 Offset: 0x2D614B1 VA: 0x2D613B0
	private void CreateShopUnitSelectMenu() { }

	// RVA: 0x2D61640 Offset: 0x2D61741 VA: 0x2D61640
	private void DestroyShopUnitSelectMenu() { }

	// RVA: 0x2D61680 Offset: 0x2D61781 VA: 0x2D61680 Slot: 19
	protected virtual void CreateWeaponShopBuyMenu() { }

	// RVA: 0x2D61850 Offset: 0x2D61951 VA: 0x2D61850
	private void DestroyWeaponShopBuyMenu() { }

	// RVA: 0x2D61890 Offset: 0x2D61991 VA: 0x2D61890
	private void CreateWeaponShopSellMenu() { }

	// RVA: 0x2D61A60 Offset: 0x2D61B61 VA: 0x2D61A60
	private void DestroyWeaponShopSellMenu() { }

	// RVA: 0x2D61AA0 Offset: 0x2D61BA1 VA: 0x2D61AA0
	private void EndSequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F40 Offset: 0x2C3041 VA: 0x2C2F40
	// RVA: 0x2D61CA0 Offset: 0x2D61DA1 VA: 0x2D61CA0
	private bool <CreateDesc>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F50 Offset: 0x2C3051 VA: 0x2C2F50
	// RVA: 0x2D61CB0 Offset: 0x2D61DB1 VA: 0x2D61CB0
	private bool <CreateDesc>b__10_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F60 Offset: 0x2C3061 VA: 0x2C2F60
	// RVA: 0x2D61CC0 Offset: 0x2D61DC1 VA: 0x2D61CC0
	private bool <CreateDesc>b__10_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F70 Offset: 0x2C3071 VA: 0x2C2F70
	// RVA: 0x2D61CD0 Offset: 0x2D61DD1 VA: 0x2D61CD0
	private bool <CreateDesc>b__10_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F80 Offset: 0x2C3081 VA: 0x2C2F80
	// RVA: 0x2D61CE0 Offset: 0x2D61DE1 VA: 0x2D61CE0
	private bool <CreateDesc>b__10_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2F90 Offset: 0x2C3091 VA: 0x2C2F90
	// RVA: 0x2D61CF0 Offset: 0x2D61DF1 VA: 0x2D61CF0
	private bool <CreateDesc>b__10_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2FA0 Offset: 0x2C30A1 VA: 0x2C2FA0
	// RVA: 0x2D61D00 Offset: 0x2D61E01 VA: 0x2D61D00
	private bool <CreateDesc>b__10_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2FB0 Offset: 0x2C30B1 VA: 0x2C2FB0
	// RVA: 0x2D61D10 Offset: 0x2D61E11 VA: 0x2D61D10
	private void <CreateWeaponShopTopMenu>b__14_0(WeaponShopTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2FC0 Offset: 0x2C30C1 VA: 0x2C2FC0
	// RVA: 0x2D61D20 Offset: 0x2D61E21 VA: 0x2D61D20
	private void <CreateShopUnitSelectMenu>b__15_0(BasicMenu.Result r, Unit unit, int scrollIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2FD0 Offset: 0x2C30D1 VA: 0x2C2FD0
	// RVA: 0x2D61D60 Offset: 0x2D61E61 VA: 0x2D61D60
	private void <CreateWeaponShopBuyMenu>b__17_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2FE0 Offset: 0x2C30E1 VA: 0x2C2FE0
	// RVA: 0x2D61D70 Offset: 0x2D61E71 VA: 0x2D61D70
	private void <CreateWeaponShopSellMenu>b__19_0(Unit unit) { }
}

