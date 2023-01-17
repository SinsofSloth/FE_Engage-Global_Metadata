// Namespace: 
public struct MapSkill.Result // TypeDefIndex: 12222
{
	// Fields
	public bool Moved; // 0x0
	public Unit Unit; // 0x8
	public int X; // 0x10
	public int Z; // 0x14

	// Methods

	// RVA: 0x213A2D0 Offset: 0x213A3D1 VA: 0x213A2D0
	public void Reset() { }
}

// Namespace: 
public sealed class MapSkill.UnitFunc : MulticastDelegate // TypeDefIndex: 12224
{
	// Methods

	// RVA: 0x213BA50 Offset: 0x213BB51 VA: 0x213BA50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x213C350 Offset: 0x213C451 VA: 0x213C350 Slot: 13
	public virtual void Invoke(int x, int z, Unit target) { }

	// RVA: 0x213C5B0 Offset: 0x213C6B1 VA: 0x213C5B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, Unit target, AsyncCallback callback, object object) { }

	// RVA: 0x213C660 Offset: 0x213C761 VA: 0x213C660 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct MapSkill.HistoryScope : IDisposable // TypeDefIndex: 12226
{
	// Fields
	private Unit m_Unit; // 0x0
	private int m_PrevHp; // 0x8
	private int m_PrevCount; // 0xC

	// Methods

	// RVA: 0x213A010 Offset: 0x213A111 VA: 0x213A010
	public void .ctor(Unit unit) { }

	// RVA: 0x213A060 Offset: 0x213A161 VA: 0x213A060 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278040 Offset: 0x278141 VA: 0x278040
private sealed class MapSkill.SkillCalculator.<>c__DisplayClass6_0 // TypeDefIndex: 12228
{
	// Fields
	public bool result; // 0x10
	public Unit center; // 0x18
	public Unit target; // 0x20
	public SkillData skill; // 0x28
	public Unit unit; // 0x30
	public MapSkill.SkillCalculator.UnitList list; // 0x38

	// Methods

	// RVA: 0x21E9DC0 Offset: 0x21E9EC1 VA: 0x21E9DC0
	public void .ctor() { }

	// RVA: 0x21E9DD0 Offset: 0x21E9ED1 VA: 0x21E9DD0
	internal void <Enumerate>b__0(int x, int z, Unit around) { }
}

// Namespace: 
public struct MapSkill.SkillCalculator : IDisposable // TypeDefIndex: 12230
{
	// Fields
	private Unit m_Unit; // 0x0
	private Unit m_Target; // 0x8
	private SkillData m_Skill; // 0x10
	private MapSkill.SkillCalculator.UnitList m_Arounds; // 0x18

	// Methods

	// RVA: 0x213A360 Offset: 0x213A461 VA: 0x213A360
	public void .ctor(Unit unit, SkillData skill, Unit target) { }

	// RVA: 0x213A410 Offset: 0x213A511 VA: 0x213A410
	public bool Enumerate(SkillData.Frequencies frequency) { }

	// RVA: 0x213BA70 Offset: 0x213BB71 VA: 0x213BA70
	public void Commit() { }

	// RVA: 0x213BFD0 Offset: 0x213C0D1 VA: 0x213BFD0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278060 Offset: 0x278161 VA: 0x278060
private sealed class MapSkill.AroundCalculator.<>c__DisplayClass4_0 // TypeDefIndex: 12232
{
	// Fields
	public BattleInfoSide side; // 0x10
	public SkillData.Frequencies frequency; // 0x18
	public List<MapSkill.AroundCalculator.Result> results; // 0x20

	// Methods

	// RVA: 0x21E94D0 Offset: 0x21E95D1 VA: 0x21E94D0
	public void .ctor() { }

	// RVA: 0x21E94E0 Offset: 0x21E95E1 VA: 0x21E94E0
	internal void <Enumerate>b__0(Unit target, SkillData skill) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278070 Offset: 0x278171 VA: 0x278070
private sealed class MapSkill.FixedCalculator.<>c__DisplayClass6_0 // TypeDefIndex: 12234
{
	// Fields
	public bool result; // 0x10
	public Unit target; // 0x18

	// Methods

	// RVA: 0x21E9CF0 Offset: 0x21E9DF1 VA: 0x21E9CF0
	public void .ctor() { }

	// RVA: 0x21E9D00 Offset: 0x21E9E01 VA: 0x21E9D00
	internal void <ExecuteAct>b__0(int x, int z, TerrainData data) { }
}

