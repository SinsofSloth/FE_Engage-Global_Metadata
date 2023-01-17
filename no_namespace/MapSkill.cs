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
public struct MapSkill.Results // TypeDefIndex: 12223
{
	// Fields
	public SkillData Skill; // 0x0
	public MapSkill.Result Current; // 0x8
	public MapSkill.Result Reverse; // 0x20

	// Methods

	// RVA: 0x213A300 Offset: 0x213A401 VA: 0x213A300
	public void Reset() { }

	// RVA: 0x213A350 Offset: 0x213A451 VA: 0x213A350
	public bool IsEnable() { }
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
public sealed class MapSkill.TerrainFunc : MulticastDelegate // TypeDefIndex: 12225
{
	// Methods

	// RVA: 0x2139FF0 Offset: 0x213A0F1 VA: 0x2139FF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x213C030 Offset: 0x213C131 VA: 0x213C030 Slot: 13
	public virtual void Invoke(int x, int z, TerrainData terrain) { }

	// RVA: 0x213C290 Offset: 0x213C391 VA: 0x213C290 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, TerrainData terrain, AsyncCallback callback, object object) { }

	// RVA: 0x213C340 Offset: 0x213C441 VA: 0x213C340 Slot: 15
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
private class MapSkill.SkillCalculator.UnitList : List<Unit> // TypeDefIndex: 12227
{
	// Methods

	// RVA: 0x21EA720 Offset: 0x21EA821 VA: 0x21EA720
	public bool TryAdd(Unit unit) { }

	// RVA: 0x21EA860 Offset: 0x21EA961 VA: 0x21EA860
	public void .ctor() { }
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
[CompilerGeneratedAttribute] // RVA: 0x278050 Offset: 0x278151 VA: 0x278050
private sealed class MapSkill.SkillCalculator.<>c__DisplayClass7_0 // TypeDefIndex: 12229
{
	// Fields
	public Unit unit; // 0x10

	// Methods

	// RVA: 0x21EA7C0 Offset: 0x21EA8C1 VA: 0x21EA7C0
	public void .ctor() { }

	// RVA: 0x21EA7D0 Offset: 0x21EA8D1 VA: 0x21EA7D0
	internal void <Commit>b__0(int x, int z, TerrainData terran) { }
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
public struct MapSkill.AroundCalculator.Result // TypeDefIndex: 12231
{
	// Fields
	public Unit target; // 0x0
	public SkillData skill; // 0x8

	// Methods

	// RVA: 0x21E9AA0 Offset: 0x21E9BA1 VA: 0x21E9AA0
	public void Commit(Unit unit) { }
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
public struct MapSkill.AroundCalculator : IDisposable // TypeDefIndex: 12233
{
	// Fields
	private BattleInfoSide m_Side; // 0x0
	private List<MapSkill.AroundCalculator.Result> m_Results; // 0x8

	// Properties
	public List<MapSkill.AroundCalculator.Result> Results { get; }

	// Methods

	// RVA: 0x2139B50 Offset: 0x2139C51 VA: 0x2139B50
	public void .ctor(BattleInfoSide side) { }

	// RVA: 0x2139BF0 Offset: 0x2139CF1 VA: 0x2139BF0
	public bool Enumerate(SkillData.Frequencies frequency) { }

	// RVA: 0x2139D30 Offset: 0x2139E31 VA: 0x2139D30 Slot: 4
	public void Dispose() { }

	// RVA: 0x2139D90 Offset: 0x2139E91 VA: 0x2139D90
	public List<MapSkill.AroundCalculator.Result> get_Results() { }
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

// Namespace: 
public struct MapSkill.FixedCalculator : IDisposable // TypeDefIndex: 12235
{
	// Fields
	private Unit m_Unit; // 0x0
	private SkillData m_Skill; // 0x8
	private List<Unit> m_Targets; // 0x10

	// Methods

	// RVA: 0x2136810 Offset: 0x2136911 VA: 0x2136810
	public void .ctor(Unit unit, SkillData skill) { }

	// RVA: 0x2139DA0 Offset: 0x2139EA1 VA: 0x2139DA0
	private bool IsIgnore(SkillData skill) { }

	// RVA: 0x21368C0 Offset: 0x21369C1 VA: 0x21368C0
	public bool Enumerate() { }

	// RVA: 0x2139E70 Offset: 0x2139F71 VA: 0x2139E70
	private bool ExecuteAct(Unit target) { }

	// RVA: 0x2137620 Offset: 0x2137721 VA: 0x2137620
	public void Commit(ProcInst super) { }

	// RVA: 0x2137B00 Offset: 0x2137C01 VA: 0x2137B00 Slot: 4
	public void Dispose() { }
}

