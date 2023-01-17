// Namespace: App
public class HubFleaMarketSequence : ProcInst // TypeDefIndex: 11003
{
	// Fields
	public static readonly int RandomGiftCount; // 0x0
	private ItemShopTopMenu.Result2 m_ShopMenuResult; // 0x70
	private BasicMenu.Result m_ShopUnitSelectMenuResult; // 0x74
	private ShopUnitSelectRoot m_UnitSelectRoot; // 0x78
	private FleaMarketBuyRoot m_FleaMarketBuyRoot; // 0x80
	private ShopSellRoot m_ItemShopSellRoot; // 0x88
	private Unit m_Unit; // 0x90
	private int m_UnitSelectMenuScrollIndex; // 0x98
	private bool m_IsEnabledVoice; // 0x9C
	private int m_FishingPlayCountAtStart; // 0xA0

	// Methods

	// RVA: 0x2BD8970 Offset: 0x2BD8A71 VA: 0x2BD8970
	public static void CreateBind(ProcInst super, bool isEnabledVoice) { }

	// RVA: 0x2BD8A00 Offset: 0x2BD8B01 VA: 0x2BD8A00
	private void .ctor(bool isEnabledVoice) { }

	// RVA: 0x2BD8A30 Offset: 0x2BD8B31 VA: 0x2BD8A30
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2BD8F20 Offset: 0x2BD9021 VA: 0x2BD8F20
	private void LoadResources() { }

	// RVA: 0x2BD8F50 Offset: 0x2BD9051 VA: 0x2BD8F50
	private bool IsLoadingResources() { }

	// RVA: 0x2BD8FA0 Offset: 0x2BD90A1 VA: 0x2BD8FA0
	private void StartSequence() { }

	// RVA: 0x2BD90E0 Offset: 0x2BD91E1 VA: 0x2BD90E0
	private void CreateFleaMarketTopMenu() { }

	// RVA: 0x2BD9300 Offset: 0x2BD9401 VA: 0x2BD9300
	private void CreateShopUnitSelectMenu() { }

	// RVA: 0x2BD9580 Offset: 0x2BD9681 VA: 0x2BD9580
	private void DestroyShopUnitSelectMenu() { }

	// RVA: 0x2BD95C0 Offset: 0x2BD96C1 VA: 0x2BD95C0
	public void CreateFleaMarketBuyMenu() { }

	// RVA: 0x2BD99F0 Offset: 0x2BD9AF1 VA: 0x2BD99F0
	private void DestroyFleaMarketBuyMenu() { }

	// RVA: 0x2BD9B00 Offset: 0x2BD9C01 VA: 0x2BD9B00
	private void CreateFleaMarketSellMenu() { }

	// RVA: 0x2BD9CC0 Offset: 0x2BD9DC1 VA: 0x2BD9CC0
	private void DestroyFleaMarketSellMenu() { }

	// RVA: 0x2BD9D00 Offset: 0x2BD9E01 VA: 0x2BD9D00
	private void SetFishingPlayCount() { }

	// RVA: 0x2BD9F60 Offset: 0x2BDA061 VA: 0x2BD9F60
	private void EndSequence() { }

	// RVA: 0x2BDA110 Offset: 0x2BDA211 VA: 0x2BDA110
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D40 Offset: 0x2C2E41 VA: 0x2C2D40
	// RVA: 0x2BDA160 Offset: 0x2BDA261 VA: 0x2BDA160
	private void <CreateFleaMarketTopMenu>b__17_0(ItemShopTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D50 Offset: 0x2C2E51 VA: 0x2C2D50
	// RVA: 0x2BDA170 Offset: 0x2BDA271 VA: 0x2BDA170
	private void <CreateShopUnitSelectMenu>b__18_0(BasicMenu.Result r, Unit unit, int scrollIndex) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D60 Offset: 0x2C2E61 VA: 0x2C2D60
	// RVA: 0x2BDA1B0 Offset: 0x2BDA2B1 VA: 0x2BDA1B0
	private void <CreateFleaMarketBuyMenu>b__20_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2D70 Offset: 0x2C2E71 VA: 0x2C2D70
	// RVA: 0x2BDA1C0 Offset: 0x2BDA2C1 VA: 0x2BDA1C0
	private void <CreateFleaMarketSellMenu>b__22_0(Unit unit) { }
}

