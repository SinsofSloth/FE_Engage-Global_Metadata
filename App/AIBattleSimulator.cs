// Namespace: App
public class AIBattleSimulator : AISimulatorBase // TypeDefIndex: 9274
{
	// Fields
	private const int MaxSceneTimes = 4;
	private const int BattleSideOf = 0;
	private const int BattleSideDf = 1;
	private AIBattleSimulator.Indication[] m_aIndication; // 0x38
	private float[,] m_aKillWithoutInterference; // 0x40
	private float m_Kill; // 0x48
	private float m_Dead; // 0x4C
	private float m_Expectation; // 0x50
	private float m_ExpectationReceived; // 0x54
	private float m_Attack; // 0x58
	private float m_Follow; // 0x5C
	private AIBattleSimulator.ChainAttackCandidate[] m_aChainAttackCandidate; // 0x60
	private float m_ChainAttackExpectation; // 0x68
	private AIBattleSimulator.Break[] m_aBreak; // 0x70
	private int[] m_BattleSides; // 0x78
	private int m_OffenseBattleTimes; // 0x80
	private int m_DefenseBattleTimes; // 0x84

	// Properties
	public float Kill { get; }
	public float Dead { get; }
	public float Expectation { get; }
	public float Attack { get; }
	public float Follow { get; }
	public int Power { get; }
	public float Hit { get; }
	public int OffenseBattleTimes { get; }
	public int DefenseBattleTimes { get; }

	// Methods

	// RVA: 0x1CA2F50 Offset: 0x1CA3051 VA: 0x1CA2F50
	public float get_Kill() { }

	// RVA: 0x1CA2F60 Offset: 0x1CA3061 VA: 0x1CA2F60
	public float get_Dead() { }

	// RVA: 0x1CA2F70 Offset: 0x1CA3071 VA: 0x1CA2F70
	public float get_Expectation() { }

	// RVA: 0x1CA2F80 Offset: 0x1CA3081 VA: 0x1CA2F80
	public float get_Attack() { }

	// RVA: 0x1CA2F90 Offset: 0x1CA3091 VA: 0x1CA2F90
	public float get_Follow() { }

	// RVA: 0x1CA2FA0 Offset: 0x1CA30A1 VA: 0x1CA2FA0
	public int get_Power() { }

	// RVA: 0x1CA2FD0 Offset: 0x1CA30D1 VA: 0x1CA2FD0
	public float get_Hit() { }

	// RVA: 0x1CA3000 Offset: 0x1CA3101 VA: 0x1CA3000
	public int get_OffenseBattleTimes() { }

	// RVA: 0x1CA3010 Offset: 0x1CA3111 VA: 0x1CA3010
	public int get_DefenseBattleTimes() { }

	// RVA: 0x1CA3020 Offset: 0x1CA3121 VA: 0x1CA3020
	public void .ctor() { }

	// RVA: 0x1CA3460 Offset: 0x1CA3561 VA: 0x1CA3460
	public void Calculate(Unit offense, Unit defense, int x, int z, int range, int itemIndex, SkillData skill, int defenseX = -1, int defenseZ = -1, bool isRemove = False, int battleCount = -1) { }

	// RVA: 0x1CA4C20 Offset: 0x1CA4D21 VA: 0x1CA4C20
	public bool IsPower0Attack() { }

	// RVA: 0x1CA36C0 Offset: 0x1CA37C1 VA: 0x1CA36C0
	private void CalculateBattleInfo(Unit offense, Unit defense, int x, int z, int range, UnitItem unitItem, SkillData skill, int defenseX, int defenseZ, int battleCount) { }

	// RVA: 0x1CA3930 Offset: 0x1CA3A31 VA: 0x1CA3930
	private void CalculateIndication(BattleSide.Type side) { }

	// RVA: 0x1CA3FD0 Offset: 0x1CA40D1 VA: 0x1CA3FD0
	private void CalculateKillProbabilityWithoutInterference(BattleSide.Type side) { }

	// RVA: 0x1CA4CF0 Offset: 0x1CA4DF1 VA: 0x1CA4CF0
	private void CalculateKillProbabilityWithoutInterference2(BattleSide.Type side, int count, int times, float nowProbability, int restHp) { }

	// RVA: 0x1CA4F60 Offset: 0x1CA5061 VA: 0x1CA4F60
	private void CalculateKillProbabilityWithoutInterference3(BattleSide.Type side, int count, int times, float nowProbability, int restHp, int damage) { }

	// RVA: 0x1CA4F50 Offset: 0x1CA5051 VA: 0x1CA4F50
	private BattleSide.Type GetSceneSide(BattleSide.Type side) { }

	// RVA: 0x1CA3F20 Offset: 0x1CA4021 VA: 0x1CA3F20
	private void CalculateChainIndication() { }

	// RVA: 0x1CA50C0 Offset: 0x1CA51C1 VA: 0x1CA50C0
	private void CalculateChainAttackIndication(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x1CA4350 Offset: 0x1CA4451 VA: 0x1CA4350
	private void CalculateScore(bool isRemove) { }

	// RVA: 0x1CA5F30 Offset: 0x1CA6031 VA: 0x1CA5F30
	private uint KillScoreNormalize(float kill) { }

	// RVA: 0x1CA5F50 Offset: 0x1CA6051 VA: 0x1CA5F50
	private uint ExpectationScoreNormalize(float expectation, int bit, int max = -1) { }
}

