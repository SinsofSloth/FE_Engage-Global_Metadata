// Namespace: 
public struct AIEnum.SkillRangeEnemyEnumerator : IEnumerable<AIEnum.SkillRangeEnemyData>, IEnumerable, IEnumerator<AIEnum.SkillRangeEnemyData>, IEnumerator, IDisposable // TypeDefIndex: 9256
{
	// Fields
	private Unit m_Unit; // 0x0
	private List<RangeData.Offset> m_Offsets; // 0x8
	private int m_TargetX; // 0x10
	private int m_TargetZ; // 0x14
	private int m_Index; // 0x18
	private AIEnum.SkillRangeEnemyData m_Current; // 0x20
	private List<int> m_Enumerated; // 0x30

	// Properties
	public AIEnum.SkillRangeEnemyData Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2F30430 Offset: 0x2F30531 VA: 0x2F30430
	public AIEnum.SkillRangeEnemyEnumerator Setup(Unit unit, SkillData skill, int x, int z, int targetX, int targetZ) { }

	// RVA: 0x2F30770 Offset: 0x2F30871 VA: 0x2F30770 Slot: 7
	public void Dispose() { }

	// RVA: 0x2F30780 Offset: 0x2F30881 VA: 0x2F30780 Slot: 6
	public AIEnum.SkillRangeEnemyData get_Current() { }

	// RVA: 0x2F30790 Offset: 0x2F30891 VA: 0x2F30790 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2F30800 Offset: 0x2F30901 VA: 0x2F30800 Slot: 8
	public bool MoveNext() { }

	// RVA: 0x2F30B50 Offset: 0x2F30C51 VA: 0x2F30B50 Slot: 10
	public void Reset() { }

	// RVA: 0x2F30BD0 Offset: 0x2F30CD1 VA: 0x2F30BD0 Slot: 4
	private IEnumerator<AIEnum.SkillRangeEnemyData> System.Collections.Generic.IEnumerable<App.AIEnum.SkillRangeEnemyData>.GetEnumerator() { }

	// RVA: 0x2F30C50 Offset: 0x2F30D51 VA: 0x2F30C50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2F30CD0 Offset: 0x2F30DD1 VA: 0x2F30CD0
	public AIEnum.SkillRangeEnemyEnumerator GetEnumerator() { }
}

