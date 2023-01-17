// Namespace: Combat
public class CombatLocationSky : BaseCombatLocation // TypeDefIndex: 8765
{
	// Fields
	private readonly int[] RotateTable; // 0x90

	// Properties
	protected override int RoughPosCount { get; }
	protected override int PatternCount { get; }

	// Methods

	// RVA: 0x22D5500 Offset: 0x22D5601 VA: 0x22D5500
	public void .ctor(CombatRecord record) { }

	// RVA: 0x22D55D0 Offset: 0x22D56D1 VA: 0x22D55D0 Slot: 6
	protected override int get_RoughPosCount() { }

	// RVA: 0x22D55F0 Offset: 0x22D56F1 VA: 0x22D55F0 Slot: 7
	protected override void SetRoughPos(int tryCount) { }

	// RVA: 0x22D58D0 Offset: 0x22D59D1 VA: 0x22D58D0
	private ValueTuple<FXZ, int> GetMoveStyle(int tryCount) { }

	// RVA: 0x22D5A80 Offset: 0x22D5B81 VA: 0x22D5A80 Slot: 8
	protected override int get_PatternCount() { }

	// RVA: 0x22D5A90 Offset: 0x22D5B91 VA: 0x22D5A90 Slot: 9
	protected override void SetBattlePatern(int pattern) { }

	// RVA: 0x22D5E60 Offset: 0x22D5F61 VA: 0x22D5E60 Slot: 10
	protected override void CalcLocation() { }
}

