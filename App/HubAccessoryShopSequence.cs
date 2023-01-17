// Namespace: App
public class HubAccessoryShopSequence : ProcInst // TypeDefIndex: 11001
{
	// Fields
	private AccessoryShopTopMenu.Result2 m_ShopMenuResult; // 0x70
	private BasicMenu.Result m_ShopUnitSelectMenuResult; // 0x74
	private AccessoryShopUnitSelectRoot m_AccessoryShopUnitSelectRoot; // 0x78
	private AccessoryShopBuyRoot m_AccessoryShopBuyRoot; // 0x80
	private AccessoryShopChangeRoot m_AccessoryShopChangeRoot; // 0x88
	private Unit m_Unit; // 0x90
	private int m_UnitSelectMenuScrollIndex; // 0x98
	private bool m_Changed; // 0x9C

	// Methods

	// RVA: 0x3047C40 Offset: 0x3047D41 VA: 0x3047C40
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x3047CC0 Offset: 0x3047DC1 VA: 0x3047CC0
	private void .ctor() { }

	// RVA: 0x3047CD0 Offset: 0x3047DD1 VA: 0x3047CD0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x3048B40 Offset: 0x3048C41 VA: 0x3048B40
	private void LoadResources() { }

	// RVA: 0x3048B70 Offset: 0x3048C71 VA: 0x3048B70
	private bool IsLoadingResources() { }

	// RVA: 0x3048BC0 Offset: 0x3048CC1 VA: 0x3048BC0
	private void StartSequence() { }

	// RVA: 0x3048CA0 Offset: 0x3048DA1 VA: 0x3048CA0
	private void CreateAccessoryShopTopMenu() { }

	// RVA: 0x3048EF0 Offset: 0x3048FF1 VA: 0x3048EF0
	private void CreateShopUnitSelectMenu() { }

	// RVA: 0x3049240 Offset: 0x3049341 VA: 0x3049240
	private void DestroyShopUnitSelectMenu() { }

	// RVA: 0x3049280 Offset: 0x3049381 VA: 0x3049280
	public void CreateAccessoryShopBuyMenu() { }

	// RVA: 0x3049450 Offset: 0x3049551 VA: 0x3049450
	private void DestroyAccessoryShopBuyMenu() { }

	// RVA: 0x3049490 Offset: 0x3049591 VA: 0x3049490
	private void CreateAccessoryShopChangeMenu() { }

	// RVA: 0x3049660 Offset: 0x3049761 VA: 0x3049660
	private void DestroyAccessoryShopChangeMenu() { }

	// RVA: 0x30496A0 Offset: 0x30497A1 VA: 0x30496A0
	private void EndSequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C90 Offset: 0x2C2D91 VA: 0x2C2C90
	// RVA: 0x3049840 Offset: 0x3049941 VA: 0x3049840
	private bool <CreateDesc>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2CA0 Offset: 0x2C2DA1 VA: 0x2C2CA0
	// RVA: 0x3049850 Offset: 0x3049951 VA: 0x3049850
	private bool <CreateDesc>b__11_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2CB0 Offset: 0x2C2DB1 VA: 0x2C2CB0
	// RVA: 0x3049860 Offset: 0x3049961 VA: 0x3049860
	private bool <CreateDesc>b__11_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2CC0 Offset: 0x2C2DC1 VA: 0x2C2CC0
	// RVA: 0x3049870 Offset: 0x3049971 VA: 0x3049870
	private bool <CreateDesc>b__11_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2CD0 Offset: 0x2C2DD1 VA: 0x2C2CD0
	// RVA: 0x3049880 Offset: 0x3049981 VA: 0x3049880
	private bool <CreateDesc>b__11_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2CE0 Offset: 0x2C2DE1 VA: 0x2C2CE0
	// RVA: 0x3049890 Offset: 0x3049991 VA: 0x3049890
	private bool <CreateDesc>b__11_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2CF0 Offset: 0x2C2DF1 VA: 0x2C2CF0
	// RVA: 0x30498A0 Offset: 0x30499A1 VA: 0x30498A0
	private bool <CreateDesc>b__11_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D00 Offset: 0x2C2E01 VA: 0x2C2D00
	// RVA: 0x30498B0 Offset: 0x30499B1 VA: 0x30498B0
	private void <CreateAccessoryShopTopMenu>b__15_0(AccessoryShopTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D10 Offset: 0x2C2E11 VA: 0x2C2D10
	// RVA: 0x30498C0 Offset: 0x30499C1 VA: 0x30498C0
	private void <CreateShopUnitSelectMenu>b__16_0(BasicMenu.Result r, Unit unit, int scrollIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D20 Offset: 0x2C2E21 VA: 0x2C2D20
	// RVA: 0x3049900 Offset: 0x3049A01 VA: 0x3049900
	private void <CreateAccessoryShopBuyMenu>b__18_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D30 Offset: 0x2C2E31 VA: 0x2C2D30
	// RVA: 0x3049910 Offset: 0x3049A11 VA: 0x3049910
	private void <CreateAccessoryShopChangeMenu>b__20_0(Unit unit, bool changed) { }
}

