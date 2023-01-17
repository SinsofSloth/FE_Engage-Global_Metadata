// Namespace: App
public class ShopCore // TypeDefIndex: 11183
{
	// Methods

	// RVA: 0x23324E0 Offset: 0x23325E1 VA: 0x23324E0
	public static bool BuyOnWeaponShop(Unit unit, ItemData itemData) { }

	// RVA: 0x23329F0 Offset: 0x2332AF1 VA: 0x23329F0
	public static bool BuyOnItemShop(Unit unit, ItemData itemData) { }

	// RVA: 0x2332AE0 Offset: 0x2332BE1 VA: 0x2332AE0
	public static bool BuyOnFleaMarket(Unit unit, ItemData itemData) { }

	// RVA: 0x2332BD0 Offset: 0x2332CD1 VA: 0x2332BD0
	public static void BuyOnAccessoryShop(AccessoryData accessoryData) { }

	// RVA: 0x2332D00 Offset: 0x2332E01 VA: 0x2332D00
	public static void Sell(Unit unit, int itemIndex, bool closeup = True) { }

	// RVA: 0x2332FF0 Offset: 0x23330F1 VA: 0x2332FF0
	public static UnitItem Refine(Unit unit, int itemIndex, int refineLevel) { }

	// RVA: 0x23333C0 Offset: 0x23334C1 VA: 0x23333C0
	public static int GetNeededIronToRefine(UnitItem unitItem, int newRefineLevel) { }

	// RVA: 0x23334E0 Offset: 0x23335E1 VA: 0x23334E0
	public static int GetNeededSteelToRefine(UnitItem unitItem, int newRefineLevel) { }

	// RVA: 0x2333600 Offset: 0x2333701 VA: 0x2333600
	public static int GetNeededSilverToRefine(UnitItem unitItem, int newRefineLevel) { }

	// RVA: 0x2333720 Offset: 0x2333821 VA: 0x2333720
	public static int GetNeededMoneyToRefine(UnitItem unitItem, int newRefineLevel) { }

	// RVA: 0x2333A30 Offset: 0x2333B31 VA: 0x2333A30
	public static UnitItem Evolve(Unit unit, int itemIndex, int evolveDataIndex) { }

	// RVA: 0x2333D60 Offset: 0x2333E61 VA: 0x2333D60
	public static UnitItem Engrave(Unit unit, int itemIndex, GodData godData) { }

	// RVA: 0x2333FF0 Offset: 0x23340F1 VA: 0x2333FF0
	public static int GetEngraveCost(ItemData itemData) { }

	// RVA: 0x2334070 Offset: 0x2334171 VA: 0x2334070
	public static int Exchange(ItemRefineExchangeData sourceMaterialData, ItemRefineExchangeData targetMaterialData, int sourceMaterialCount) { }

	// RVA: 0x23346E0 Offset: 0x23347E1 VA: 0x23346E0
	private static int GetUnitItemEmptyCount(Unit unit) { }

	// RVA: 0x2333300 Offset: 0x2333401 VA: 0x2333300
	public static UnitItem GetUnitItem(Unit unit, int itemIndex) { }

	// RVA: 0x2334710 Offset: 0x2334811 VA: 0x2334710
	public static int GetPrice(ItemData itemData, bool isDiscountableShop) { }

	// RVA: 0x2334720 Offset: 0x2334821 VA: 0x2334720
	public static bool CanAdd(Unit unit, ItemData itemData) { }

	// RVA: 0x2334740 Offset: 0x2334841 VA: 0x2334740
	public static ShopCore.Result CalcAdd(Unit unit, ItemData itemData) { }

	// RVA: 0x2334830 Offset: 0x2334931 VA: 0x2334830
	public static bool IsInventoryMax(ItemData itemData) { }

	// RVA: 0x23325D0 Offset: 0x23326D1 VA: 0x23325D0
	private static ShopCore.Result AddItem(Unit unit, ItemData itemData) { }

	// RVA: 0x2334470 Offset: 0x2334571 VA: 0x2334470
	public static int GetRefineMaterialCount(ItemRefineExchangeData materialData) { }

	// RVA: 0x2334600 Offset: 0x2334701 VA: 0x2334600
	public static int GetRefineMaterialMax(ItemRefineExchangeData materialData) { }

	// RVA: 0x2332790 Offset: 0x2332891 VA: 0x2332790
	private static void AddAchievementOnBuy(ItemData itemData, int count = 1) { }

	// RVA: 0x2332F10 Offset: 0x2333011 VA: 0x2332F10
	private static void AddAchievementOnSell(ItemData itemData, int count = 1) { }

	// RVA: 0x2333840 Offset: 0x2333941 VA: 0x2333840
	private static void AddAchievementOnRefine(ItemData itemData, int count = 1) { }

	// RVA: 0x23348A0 Offset: 0x23349A1 VA: 0x23348A0
	public static void AddAchievementOnBuyAccessory() { }

	// RVA: 0x2331A70 Offset: 0x2331B71 VA: 0x2331A70
	public static string GetUnknownName(UnitItem unititem) { }

	// RVA: 0x2334910 Offset: 0x2334A11 VA: 0x2334910
	public void .ctor() { }
}

