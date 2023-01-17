// Namespace: App
public class MapSequenceCommandSkill : SingletonProcInst<MapSequenceCommandSkill> // TypeDefIndex: 12404
{
	// Fields
	private MapSequenceCommandSkill.Action m_Action; // 0x74
	private MapSkill.Results m_Results; // 0x78
	private UnitSignal m_Signal; // 0xB0

	// Methods

	// RVA: 0x1D87480 Offset: 0x1D87581 VA: 0x1D87480
	private void .ctor(ref MapSkill.Results results, MapSequenceCommandSkill.Action action) { }

	// RVA: 0x1D87540 Offset: 0x1D87641 VA: 0x1D87540
	private void Start() { }

	// RVA: 0x1D87600 Offset: 0x1D87701 VA: 0x1D87600
	private void WaitSkip(UnitSignal signal) { }

	// RVA: 0x1D87610 Offset: 0x1D87711 VA: 0x1D87610
	private void BeginSignal() { }

	// RVA: 0x1D87730 Offset: 0x1D87831 VA: 0x1D87730
	private void EndSignal() { }

	// RVA: 0x1D877E0 Offset: 0x1D878E1 VA: 0x1D877E0
	private void Impact() { }

	// RVA: 0x1D87980 Offset: 0x1D87A81 VA: 0x1D87980
	private void Commit() { }

	// RVA: 0x1D879C0 Offset: 0x1D87AC1 VA: 0x1D879C0
	private static void Commit(MapSkill.Results results) { }

	// RVA: 0x1D87F30 Offset: 0x1D88031 VA: 0x1D87F30
	private static void RemoveForceSkill(Force.Type force, SkillData skill) { }

	// RVA: 0x1D87CD0 Offset: 0x1D87DD1 VA: 0x1D87CD0
	private static void AddGiveSkills(Unit unit, Unit target, SkillData skill) { }

	// RVA: 0x1D882F0 Offset: 0x1D883F1 VA: 0x1D882F0
	public static bool CreateBind(ProcInst super, Unit current, Unit reverse, SkillData skill, MapSequenceCommandSkill.Action action = 1) { }

	// RVA: 0x1D7D810 Offset: 0x1D7D911 VA: 0x1D7D810
	public static bool CreateBind(ProcInst super, MapSkill.Results results, MapSequenceCommandSkill.Action action = 0) { }
}

