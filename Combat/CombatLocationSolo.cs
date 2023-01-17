// Namespace: Combat
public class CombatLocationSolo : BaseCombatLocation // TypeDefIndex: 8766
{
	// Fields
	private int m_TargetSide; // 0x8C
	private bool m_IsBigDragon; // 0x90
	private bool m_IsLastBoss; // 0x91
	private bool m_IsEnemy; // 0x92
	private bool m_IsReCalc; // 0x93
	[TupleElementNamesAttribute] // RVA: 0x284280 Offset: 0x284381 VA: 0x284280
	private ValueTuple<int, int> m_Center; // 0x94

	// Properties
	protected override int RoughPosCount { get; }
	protected override int PatternCount { get; }

	// Methods

	// RVA: 0x2564680 Offset: 0x2564781 VA: 0x2564680
	public void .ctor(CombatRecord rec) { }

	// RVA: 0x2564700 Offset: 0x2564801 VA: 0x2564700 Slot: 5
	protected override void Setup(CharacterGameStatus[] gs) { }

	// RVA: 0x2564820 Offset: 0x2564921 VA: 0x2564820 Slot: 6
	protected override int get_RoughPosCount() { }

	// RVA: 0x2564830 Offset: 0x2564931 VA: 0x2564830 Slot: 7
	protected override void SetRoughPos(int tryCount) { }

	// RVA: 0x2564F40 Offset: 0x2565041 VA: 0x2564F40 Slot: 8
	protected override int get_PatternCount() { }

	// RVA: 0x2564F50 Offset: 0x2565051 VA: 0x2564F50 Slot: 9
	protected override void SetBattlePatern(int pattern) { }

	// RVA: 0x2564FC0 Offset: 0x25650C1 VA: 0x2564FC0 Slot: 10
	protected override void CalcLocation() { }

	// RVA: 0x2565850 Offset: 0x2565951 VA: 0x2565850 Slot: 4
	protected override void LocateEmblem(int masterSide, Character master, Character emblem, LocationParams.LocateStyle locateStyle) { }
}

