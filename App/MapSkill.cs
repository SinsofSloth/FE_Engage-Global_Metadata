// Namespace: App
public class MapSkill // TypeDefIndex: 12236
{
	// Fields
	public const float WaitTime = 0.5;
	public const float BeginWaitTime = 0.3;
	public const float EndWaitTime = 0.3;

	// Methods

	// RVA: 0x27404E0 Offset: 0x27405E1 VA: 0x27404E0
	public static bool Prediction(Unit current, Unit reverse, SkillData skill) { }

	// RVA: 0x2740E20 Offset: 0x2740F21 VA: 0x2740E20
	private static bool IsSightOut(Unit unit, int x, int z) { }

	// RVA: 0x2740F30 Offset: 0x2741031 VA: 0x2740F30
	private static bool CanEnter(Unit current, Unit target, int x, int z) { }

	// RVA: 0x2740FE0 Offset: 0x27410E1 VA: 0x2740FE0
	private static int TryGetX(Unit unit) { }

	// RVA: 0x2740FF0 Offset: 0x27410F1 VA: 0x2740FF0
	private static int TryGetZ(Unit unit) { }

	// RVA: 0x2740520 Offset: 0x2740621 VA: 0x2740520
	public static bool Prediction(Unit current, Unit reverse, SkillData skill, out MapSkill.Results results) { }

	// RVA: 0x2741000 Offset: 0x2741101 VA: 0x2741000
	public static bool CalcPierce(Unit current, Unit target, SkillData skill, MapSkill.UnitFunc func) { }

	// RVA: 0x2741730 Offset: 0x2741831 VA: 0x2741730
	public static bool CalcStepPos(ref int attackX, ref int attackZ, int targetX, int targetZ, SkillData skill, bool isReverse = False) { }

	// RVA: 0x27417C0 Offset: 0x27418C1 VA: 0x27417C0
	private static Dir.Type GetRangeDir(Unit attack, Unit target) { }

	// RVA: 0x2741CB0 Offset: 0x2741DB1 VA: 0x2741CB0
	private static bool TryGetRangeCenter(Unit current, Unit target, SkillData skill, out int x, out int z) { }

	// RVA: 0x2742250 Offset: 0x2742351 VA: 0x2742250
	private static void TryAddAttackRange(Unit current, int x, int z, bool isUnitOnly, MapSkill.UnitFunc func) { }

	// RVA: 0x2742440 Offset: 0x2742541 VA: 0x2742440
	public static void ForeachAttackRange(Unit current, Unit target, SkillData skill, bool isUnitOnly, MapSkill.UnitFunc func) { }

	// RVA: 0x2742650 Offset: 0x2742751 VA: 0x2742650
	public static void ForeachAttackRange(Unit current, int targetX, int targetZ, SkillData skill, bool isUnitOnly, MapSkill.UnitFunc func) { }

	// RVA: 0x2742830 Offset: 0x2742931 VA: 0x2742830
	public static void ForeachOverlapRange(Unit current, SkillData skill, MapSkill.TerrainFunc func) { }

	// RVA: 0x2742AA0 Offset: 0x2742BA1 VA: 0x2742AA0
	public static void ForeachOverlapRange(Unit current, int x, int z, int targetX, int targetZ, SkillData skill, MapSkill.TerrainFunc func) { }

	// RVA: 0x2742B20 Offset: 0x2742C21 VA: 0x2742B20
	public static void ForeachOverlapRange(Unit current, Unit target, SkillData skill, MapSkill.TerrainFunc func) { }

	// RVA: 0x2742850 Offset: 0x2742951 VA: 0x2742850
	public static void ForeachOverlapRange(Unit current, int x, int z, Dir.Type dir, SkillData skill, MapSkill.TerrainFunc func) { }

	// RVA: 0x2742BB0 Offset: 0x2742CB1 VA: 0x2742BB0
	private static Unit GetAroundCenter(SkillData skill, Unit unit, Unit target) { }

	// RVA: 0x2742C00 Offset: 0x2742D01 VA: 0x2742C00
	private static bool HasAddGiveSkill(SkillData skill, SkillData.GiveTargets target, Unit unit) { }

	// RVA: 0x2742CB0 Offset: 0x2742DB1 VA: 0x2742CB0
	private static bool TryAddGiveSkill(SkillData skill, SkillData.GiveTargets target, Unit unit) { }

	// RVA: 0x2742DE0 Offset: 0x2742EE1 VA: 0x2742DE0
	private static bool TryHitSkill(SkillData skill, Unit unit) { }

	// RVA: 0x2742F50 Offset: 0x2743051 VA: 0x2742F50
	public static void ExecuteAct(SkillData skill, Unit unit) { }

	// RVA: 0x2742FF0 Offset: 0x27430F1 VA: 0x2742FF0
	public void .ctor() { }
}

