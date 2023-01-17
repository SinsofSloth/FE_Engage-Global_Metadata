// Namespace: Combat
public class CombatLocationBrawl : BaseCombatLocation // TypeDefIndex: 8755
{
	// Fields
	private bool m_IsShootAttack; // 0x89
	private readonly int[] RotateTable; // 0x90
	private readonly int MaxCheckLength; // 0x98

	// Properties
	protected override int RoughPosCount { get; }
	protected override int PatternCount { get; }

	// Methods

	// RVA: 0x22CC980 Offset: 0x22CCA81 VA: 0x22CC980
	public void .ctor(CombatRecord record) { }

	// RVA: 0x22CCA60 Offset: 0x22CCB61 VA: 0x22CCA60 Slot: 5
	protected override void Setup(CharacterGameStatus[] gs) { }

	// RVA: 0x22CCAC0 Offset: 0x22CCBC1 VA: 0x22CCAC0 Slot: 6
	protected override int get_RoughPosCount() { }

	// RVA: 0x22CCAF0 Offset: 0x22CCBF1 VA: 0x22CCAF0 Slot: 7
	protected override void SetRoughPos(int tryCount) { }

	// RVA: 0x22CCE30 Offset: 0x22CCF31 VA: 0x22CCE30
	private ValueTuple<FXZ, int> GetMoveStyle(int tryCount) { }

	// RVA: 0x22CCFE0 Offset: 0x22CD0E1 VA: 0x22CCFE0 Slot: 8
	protected override int get_PatternCount() { }

	// RVA: 0x22CCFF0 Offset: 0x22CD0F1 VA: 0x22CCFF0 Slot: 9
	protected override void SetBattlePatern(int pattern) { }

	// RVA: 0x22CD340 Offset: 0x22CD441 VA: 0x22CD340 Slot: 10
	protected override void CalcLocation() { }
}

