// Namespace: App
public class BattleUtil // TypeDefIndex: 9534
{
	// Methods

	// RVA: 0x2261950 Offset: 0x2261A51 VA: 0x2261950
	public static DamageLevel GetDamageLevel(int damage, bool critical = False, bool efficacy = False) { }

	// RVA: 0x22619A0 Offset: 0x2261AA1 VA: 0x22619A0
	public static DamageLevel GetDamageLevel(BattleScene scene, BattleSide.Type side) { }

	// RVA: 0x2261BB0 Offset: 0x2261CB1 VA: 0x2261BB0
	public static bool CanGainExp(BattleInfoSide current) { }

	// RVA: 0x2261CA0 Offset: 0x2261DA1 VA: 0x2261CA0
	public static bool CanGainExp(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2261CE0 Offset: 0x2261DE1 VA: 0x2261CE0
	private static bool CanRodExp(BattleInfoSide current) { }

	// RVA: 0x2261DD0 Offset: 0x2261ED1 VA: 0x2261DD0
	public static int GetBattleExp(BattleInfoSide current, BattleInfoSide reverse, string command) { }

	// RVA: 0x2261EC0 Offset: 0x2261FC1 VA: 0x2261EC0
	public static int GetRodExp(BattleInfoSide current) { }

	// RVA: 0x2261FB0 Offset: 0x22620B1 VA: 0x2261FB0
	public static int GetDanceExp(BattleInfoSide current) { }

	// RVA: 0x22620A0 Offset: 0x22621A1 VA: 0x22620A0
	public static int GetSummonExp(BattleInfoSide current) { }

	// RVA: 0x22620B0 Offset: 0x22621B1 VA: 0x22620B0
	public static int GetGuardExp(BattleInfoSide current) { }

	// RVA: 0x22621A0 Offset: 0x22622A1 VA: 0x22621A0
	public static int GetBattleExp(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2262280 Offset: 0x2262381 VA: 0x2262280
	public static int GetEnchantExp(Unit unit, Unit target) { }

	// RVA: 0x2262290 Offset: 0x2262391 VA: 0x2262290
	public static bool IsAmbush(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2262440 Offset: 0x2262541 VA: 0x2262440
	public static bool IsIncessantAttack(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x22622A0 Offset: 0x22623A1 VA: 0x22622A0
	private static bool IsSwapOrder(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2262450 Offset: 0x2262551 VA: 0x2262450
	private static bool HasPlayerUnit(BattleInfo info) { }

	// RVA: 0x22625B0 Offset: 0x22626B1 VA: 0x22625B0
	public static bool IsDetailBattle(BattleInfo info) { }

	// RVA: 0x2245370 Offset: 0x2245471 VA: 0x2245370
	public static bool IsGrowTalk(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2262A50 Offset: 0x2262B51 VA: 0x2262A50
	public static bool CanGainSituation() { }

	// RVA: 0x2262C10 Offset: 0x2262D11 VA: 0x2262C10
	public static void PlayLastBattleDieSound() { }

	// RVA: 0x2262CA0 Offset: 0x2262DA1 VA: 0x2262CA0
	public void .ctor() { }
}

