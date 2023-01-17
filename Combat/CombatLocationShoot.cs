// Namespace: Combat
public class CombatLocationShoot : BaseCombatLocation // TypeDefIndex: 8764
{
	// Fields
	private readonly int[] RotateTable; // 0x90

	// Properties
	protected override int RoughPosCount { get; }
	protected override int PatternCount { get; }

	// Methods

	// RVA: 0x22D2B30 Offset: 0x22D2C31 VA: 0x22D2B30
	public void .ctor(CombatRecord record) { }

	// RVA: 0x22D2C00 Offset: 0x22D2D01 VA: 0x22D2C00 Slot: 6
	protected override int get_RoughPosCount() { }

	// RVA: 0x22D2C20 Offset: 0x22D2D21 VA: 0x22D2C20 Slot: 7
	protected override void SetRoughPos(int tryCount) { }

	// RVA: 0x22D2F50 Offset: 0x22D3051 VA: 0x22D2F50
	private ValueTuple<FXZ, int> GetMoveStyle(int tryCount) { }

	// RVA: 0x22D3100 Offset: 0x22D3201 VA: 0x22D3100 Slot: 8
	protected override int get_PatternCount() { }

	// RVA: 0x22D3110 Offset: 0x22D3211 VA: 0x22D3110 Slot: 9
	protected override void SetBattlePatern(int pattern) { }

	// RVA: 0x22D34D0 Offset: 0x22D35D1 VA: 0x22D34D0
	private void SetFlyHeight(int side) { }

	// RVA: 0x22D43C0 Offset: 0x22D44C1 VA: 0x22D43C0 Slot: 10
	protected override void CalcLocation() { }
}

