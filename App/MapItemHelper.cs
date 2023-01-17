// Namespace: App
public class MapItemHelper // TypeDefIndex: 12167
{
	// Methods

	// RVA: 0x2201BE0 Offset: 0x2201CE1 VA: 0x2201BE0
	public static bool CanUse(Unit unit, int unitItemIndex, int targetX, int targetZ, int unitX, int unitZ, MapItemHelper.Flag flag, SkillData skill) { }

	// RVA: 0x2203340 Offset: 0x2203441 VA: 0x2203340
	private static Unit GetUseTargetUnit(Unit unit, ItemData item, int x, int z) { }

	// RVA: 0x2201C60 Offset: 0x2201D61 VA: 0x2201C60
	public static bool CanUse(Unit attackUnit, UnitItem unitItem, int atkPosX, int atkPosZ, int targetPosX, int targetPosZ, MapItemHelper.Flag flag, SkillData skill) { }

	// RVA: 0x2203820 Offset: 0x2203921 VA: 0x2203820
	private static bool IsTargetAllied(ItemData.UseTypes type) { }

	// RVA: 0x2203490 Offset: 0x2203591 VA: 0x2203490
	public static bool CanDirectTarget(ItemData item) { }

	// RVA: 0x2203850 Offset: 0x2203951 VA: 0x2203850
	public static MapItemHelper.BlessFlags GetBlessFlags(ItemData item, Unit target, ItemData.UseTypes useType) { }

	// RVA: 0x2203C60 Offset: 0x2203D61 VA: 0x2203C60
	public static MapItemHelper.BlessFlags GetBlessFlags(ItemData item, Unit target) { }

	// RVA: 0x2203D00 Offset: 0x2203E01 VA: 0x2203D00
	private static bool CanUseImpl(Unit unit, ItemData item, Unit target, ItemData.UseTypes useType, SkillArray giveSkills) { }

	// RVA: 0x2205160 Offset: 0x2205261 VA: 0x2205160
	public static bool CanUseEnchant(Unit unit, ItemData item, Unit target, bool cancelable = False) { }

	// RVA: 0x2205280 Offset: 0x2205381 VA: 0x2205280
	public static bool CanUseTarget(Unit unit, ItemData item, Unit target) { }

	// RVA: 0x22052A0 Offset: 0x22053A1 VA: 0x22052A0
	public static int GetItemIndex(Unit unit, int targetX, int targetZ, int unitX, int unitZ, MapItemHelper.Flag flag) { }

	// RVA: 0x22054E0 Offset: 0x22055E1 VA: 0x22054E0
	public static void ForEachRodTarget(Unit unit, ItemData item, int targetX, int targetZ, SkillData skill, Action<Unit> func) { }

	// RVA: 0x2205F70 Offset: 0x2206071 VA: 0x2205F70
	public static void ForEachRodRange(Unit unit, ItemData item, int targetX, int targetZ, Action<int, int> func) { }

	// RVA: 0x2206160 Offset: 0x2206261 VA: 0x2206160
	public static bool TryCreation(ProcInst super, Unit unit, int targetX, int targetZ, string tid) { }

	// RVA: 0x2206470 Offset: 0x2206571 VA: 0x2206470
	public static bool GetRescuePosition(out int dstX, out int dstZ, Unit target, int srcX, int srcZ, bool isHere = False) { }

	// RVA: 0x22064A0 Offset: 0x22065A1 VA: 0x22064A0
	public static bool GetRescuePosition(Unit rodUnit, out int dstX, out int dstZ, Unit target, int srcX, int srcZ, bool isHere = False) { }

	// RVA: 0x2203550 Offset: 0x2203651 VA: 0x2203550
	private static bool CanAttack(Unit unit, Unit target, MapItemHelper.Flag flag) { }

	// RVA: 0x2203650 Offset: 0x2203751 VA: 0x2203650
	private static bool CanRod(Unit unit, Unit target, ItemData item, MapItemHelper.Flag flag) { }

	// RVA: 0x2206E10 Offset: 0x2206F11 VA: 0x2206E10
	public static ItemData GetFireCannonItem() { }

	// RVA: 0x2206EA0 Offset: 0x2206FA1 VA: 0x2206EA0
	public static void GetFireCannonRangeIO(Unit unit, out int rangeI, out int rangeO) { }

	// RVA: 0x2207000 Offset: 0x2207101 VA: 0x2207000
	private static int GetHealPower(Unit unit, ItemData.UseTypes useType, int power) { }

	// RVA: 0x2207050 Offset: 0x2207151 VA: 0x2207050
	public static int GetHealPower(Unit unit, ItemData item, bool isEnchant) { }

	// RVA: 0x22070E0 Offset: 0x22071E1 VA: 0x22070E0
	public void .ctor() { }
}

