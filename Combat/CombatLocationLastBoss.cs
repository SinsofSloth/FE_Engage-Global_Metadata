// Namespace: Combat
public class CombatLocationLastBoss : BaseCombatLocation // TypeDefIndex: 8762
{
	// Fields
	private bool m_IsCrossCut; // 0x89
	private Vector3 m_BossCenter; // 0x8C
	private float m_BossSize; // 0x98
	private float m_BattleDist; // 0x9C

	// Properties
	protected override int RoughPosCount { get; }
	protected override int PatternCount { get; }

	// Methods

	// RVA: 0x22D0EC0 Offset: 0x22D0FC1 VA: 0x22D0EC0
	public void .ctor(CombatRecord record) { }

	// RVA: 0x22D10E0 Offset: 0x22D11E1 VA: 0x22D10E0 Slot: 6
	protected override int get_RoughPosCount() { }

	// RVA: 0x22D10F0 Offset: 0x22D11F1 VA: 0x22D10F0 Slot: 7
	protected override void SetRoughPos(int tryCount) { }

	// RVA: 0x22D11D0 Offset: 0x22D12D1 VA: 0x22D11D0
	private void SetRoughPosCrosscut(int tryCount) { }

	// RVA: 0x22D11E0 Offset: 0x22D12E1 VA: 0x22D11E0
	private void SetRoughPosStandard(int tryCount) { }

	// RVA: 0x22D1430 Offset: 0x22D1531 VA: 0x22D1430 Slot: 8
	protected override int get_PatternCount() { }

	// RVA: 0x22D1440 Offset: 0x22D1541 VA: 0x22D1440 Slot: 9
	protected override void SetBattlePatern(int pattern) { }

	// RVA: 0x22D1730 Offset: 0x22D1831 VA: 0x22D1730 Slot: 10
	protected override void CalcLocation() { }
}

