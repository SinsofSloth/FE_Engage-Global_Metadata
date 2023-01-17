// Namespace: App
public class MapFor // TypeDefIndex: 12021
{
	// Fields
	private static readonly int[] RhombusX; // 0x0
	private static readonly int[] RhombusZ; // 0x8

	// Methods

	// RVA: 0x21C0EE0 Offset: 0x21C0FE1 VA: 0x21C0EE0
	public static void EachPoke(MapInspector.Kind kind, MapFor.PosFunction func) { }

	// RVA: 0x21C0FE0 Offset: 0x21C10E1 VA: 0x21C0FE0
	public static void EachPoke(MapInspector.Kind kind, MapFor.PokeFunction func) { }

	// RVA: 0x21C1200 Offset: 0x21C1301 VA: 0x21C1200
	public static void EachDestroy(Unit unit, MapFor.DestroyFunction func) { }

	// RVA: 0x21C1AB0 Offset: 0x21C1BB1 VA: 0x21C1AB0
	private static void EachDestroy(PokeInspector inspector, Unit unit, uint itemMask, MapFor.DestroyFunction func) { }

	// RVA: 0x21C1F70 Offset: 0x21C2071 VA: 0x21C1F70
	public static void EachPlayArea(MapFor.PosFunction func) { }

	// RVA: 0x21C2180 Offset: 0x21C2281 VA: 0x21C2180
	public static void EachPlayArea2(MapFor.Pos2Function func) { }

	// RVA: 0x21C23B0 Offset: 0x21C24B1 VA: 0x21C23B0
	public static void EachRange(int px, int pz, int near, int far, MapFor.RangeFunction func) { }

	// RVA: 0x21C2680 Offset: 0x21C2781 VA: 0x21C2680
	public static void EachRange2(int px, int pz, int near, int far, MapFor.Range2Function func) { }

	// RVA: 0x21C2980 Offset: 0x21C2A81 VA: 0x21C2980
	public static void EachRange(Unit unit, int px, int pz, int near, int far, MapFor.RangeFunction func) { }

	// RVA: 0x21C2DE0 Offset: 0x21C2EE1 VA: 0x21C2DE0
	public static void EachTarget(Unit unit, int x, int z, int near, int far, uint itemMask, UnitItem specifiedItem, SkillData commandSkill, MapFor.TargetFunction func) { }

	// RVA: 0x21C3650 Offset: 0x21C3751 VA: 0x21C3650
	public static void EachLine(int x0, int z0, int x1, int z1, MapFor.Pos2Function func) { }

	// RVA: 0x21C3950 Offset: 0x21C3A51 VA: 0x21C3950
	public static void EachRhombus(int x, int z, int range, MapFor.PosFunction func) { }

	// RVA: 0x21C3BB0 Offset: 0x21C3CB1 VA: 0x21C3BB0
	public static void EachForce(MapFor.ForceFunction func) { }

	// RVA: 0x21C3C00 Offset: 0x21C3D01 VA: 0x21C3C00
	public static void EachForce2(MapFor.Force2Function func) { }

	// RVA: 0x21C3C50 Offset: 0x21C3D51 VA: 0x21C3C50
	public static void EachAllyForce(Force.Type forceType, MapFor.ForceFunction func) { }

	// RVA: 0x21C3E60 Offset: 0x21C3F61 VA: 0x21C3E60
	public static void EachEnemyForce(Force.Type forceType, MapFor.ForceFunction func) { }

	// RVA: 0x21C4070 Offset: 0x21C4171 VA: 0x21C4070
	public static void EachUnit(MapFor.UnitFunction func) { }

	// RVA: 0x21AEC90 Offset: 0x21AED91 VA: 0x21AEC90
	public static void EachForceUnit(Force.Type forceType, MapFor.UnitFunction func) { }

	// RVA: 0x21C4280 Offset: 0x21C4381 VA: 0x21C4280
	public static void EachSelfForceUnit(MapFor.UnitFunction func) { }

	// RVA: 0x21AF160 Offset: 0x21AF261 VA: 0x21AF160
	public static void EachForceUnit(Force.Type forceType, MapFor.Unit2Function func) { }

	// RVA: 0x21C4680 Offset: 0x21C4781 VA: 0x21C4680
	public static void EachAllyUnit(Force.Type forceType, MapFor.UnitFunction func) { }

	// RVA: 0x21C48E0 Offset: 0x21C49E1 VA: 0x21C48E0
	public static void EachAllyUnit2(Force.Type forceType, MapFor.Unit2Function func) { }

	// RVA: 0x21C4B40 Offset: 0x21C4C41 VA: 0x21C4B40
	public static void EachEnemyUnit(Force.Type forceType, MapFor.UnitFunction func) { }

	// RVA: 0x21C4DA0 Offset: 0x21C4EA1 VA: 0x21C4DA0
	public static void EachEnemyUnit2(Force.Type forceType, MapFor.Unit2Function func) { }

	// RVA: 0x21C5010 Offset: 0x21C5111 VA: 0x21C5010
	public static void EachAroundUnit(Unit unit, Force.Type forceType, MapFor.UnitFunction func) { }

	// RVA: 0x21C5930 Offset: 0x21C5A31 VA: 0x21C5930
	public static void EachAroundUnit(Unit unit, MapFor.UnitFunction func) { }

	// RVA: 0x21C50A0 Offset: 0x21C51A1 VA: 0x21C50A0
	public static void EachRangeUnit(Unit unit, Force.Type forceType, int range, MapFor.UnitFunction func) { }

	// RVA: 0x21C59B0 Offset: 0x21C5AB1 VA: 0x21C59B0
	public static void EachRangeUnit(Unit unit, int range, MapFor.UnitFunction func) { }

	// RVA: 0x21C60F0 Offset: 0x21C61F1 VA: 0x21C60F0
	public static void EachRangeUnitSkill(Unit target, SkillData.Timings timing, MapFor.UnitSkillFunction func) { }

	// RVA: 0x21C6B00 Offset: 0x21C6C01 VA: 0x21C6B00
	public static void EachRangeUnitAround(Unit unit, SkillData skill, MapFor.UnitFunction func) { }

	// RVA: 0x21C73A0 Offset: 0x21C74A1 VA: 0x21C73A0
	public static void EachRangeUnitSupport(Unit unit, SkillData skill, MapFor.UnitFunction func) { }

	// RVA: 0x21C7C40 Offset: 0x21C7D41 VA: 0x21C7C40
	public void .ctor() { }

	// RVA: 0x21C7C50 Offset: 0x21C7D51 VA: 0x21C7C50
	private static void .cctor() { }
}

