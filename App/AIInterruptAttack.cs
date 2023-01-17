// Namespace: App
public class AIInterruptAttack // TypeDefIndex: 9263
{
	// Fields
	private const int MaxAttackCountLunatic = 4;
	private const int MaxAttackCountDefault = 1;
	private const int MaxCandidate = 8;
	private Unit m_Original; // 0x10
	private int m_OriginalMoveX; // 0x18
	private int m_OriginalMoveZ; // 0x1C
	private int m_OriginalAttackX; // 0x20
	private int m_OriginalAttackZ; // 0x24
	private int m_OriginalItemIndex; // 0x28
	private int m_OriginalBulletPattern; // 0x2C
	private Unit m_Target; // 0x30
	private int m_TargetBaseX; // 0x38
	private int m_TargetBaseZ; // 0x3C
	private int m_TargetX; // 0x40
	private int m_TargetZ; // 0x44
	private AIInterruptAttack.CandidateList m_Candidates; // 0x48
	private int m_AttackCount; // 0x50
	private int m_MaxAttackCount; // 0x54
	private bool m_IsDecidedAttacker; // 0x58
	private AIBattleSimulator m_BattleSimulator; // 0x60
	private AIInterruptAttack.AttackScoreResult m_ASResult; // 0x68

	// Methods

	// RVA: 0x1C9F190 Offset: 0x1C9F291 VA: 0x1C9F190
	public void .ctor() { }

	// RVA: 0x1CA9140 Offset: 0x1CA9241 VA: 0x1CA9140
	public bool Think(Unit actor, Unit target, int moveX, int moveZ, int attackX, int attackZ, int itemIndex, int targetX = -1, int targetZ = -1, int bulletPattern = -1) { }

	// RVA: 0x1CAD020 Offset: 0x1CAD121 VA: 0x1CAD020
	private bool ThinkImpl(Unit actor, Unit target, int moveX, int moveZ, int attackX, int attackZ, int itemIndex, int targetX, int targetZ, int bulletPattern) { }

	// RVA: 0x1CA2B20 Offset: 0x1CA2C21 VA: 0x1CA2B20
	public bool Attack() { }

	// RVA: 0x1CA2B10 Offset: 0x1CA2C11 VA: 0x1CA2B10
	public bool IsReserved() { }

	// RVA: 0x1CA2EC0 Offset: 0x1CA2FC1 VA: 0x1CA2EC0
	public void Clear() { }

	// RVA: 0x1CAD480 Offset: 0x1CAD581 VA: 0x1CAD480
	private void EnumerateCandidates(bool isOriginalThinkBreak, bool isOriginalThinkChain) { }

	// RVA: 0x1CAD590 Offset: 0x1CAD691 VA: 0x1CAD590
	private bool DecideAttacker(bool isAddMovedOriginal) { }

	// RVA: 0x1CAD990 Offset: 0x1CADA91 VA: 0x1CAD990
	private void Deploy(Unit unit) { }

	// RVA: 0x1CADE40 Offset: 0x1CADF41 VA: 0x1CADE40
	private bool GetAttackScore(Unit actor, int flag, int bulletPattern, ref AIInterruptAttack.AttackScoreResult result) { }

	// RVA: 0x1CAE490 Offset: 0x1CAE591 VA: 0x1CAE490
	private int GetRange(Unit unit) { }

	// RVA: 0x1CAD260 Offset: 0x1CAD361 VA: 0x1CAD260
	private int GetMaxAttackCount() { }

	// RVA: 0x1CAD3D0 Offset: 0x1CAD4D1 VA: 0x1CAD3D0
	private void AddMovedOriginalToImage() { }

	// RVA: 0x1CAD8E0 Offset: 0x1CAD9E1 VA: 0x1CAD8E0
	private void DeleteMovedOriginalFromImage() { }

	// RVA: 0x1CADBE0 Offset: 0x1CADCE1 VA: 0x1CADBE0
	private void Mind(Unit attacker, int moveX, int moveZ, int attackX, int attackZ, int itemIndex, int bulletPattern) { }

	[ConditionalAttribute] // RVA: 0x2AEA30 Offset: 0x2AEB31 VA: 0x2AEA30
	// RVA: 0x1CAE990 Offset: 0x1CAEA91 VA: 0x1CAE990
	private void DbgLog(string msg) { }

	[ConditionalAttribute] // RVA: 0x2AEA70 Offset: 0x2AEB71 VA: 0x2AEA70
	// RVA: 0x1CAE9A0 Offset: 0x1CAEAA1 VA: 0x1CAE9A0
	private void DbgLogOrignalAndTarget() { }

	[ConditionalAttribute] // RVA: 0x2AEAB0 Offset: 0x2AEBB1 VA: 0x2AEAB0
	// RVA: 0x1CAEFC0 Offset: 0x1CAF0C1 VA: 0x1CAEFC0
	private void DbgLogCandidates() { }

	[ConditionalAttribute] // RVA: 0x2AEAF0 Offset: 0x2AEBF1 VA: 0x2AEAF0
	// RVA: 0x1CAF4F0 Offset: 0x1CAF5F1 VA: 0x1CAF4F0
	private void DbgLogAttacker(string msg, Unit unit, int moveX, int moveZ, int attackX, int attackZ, int itemIndex, int bulletPattern) { }

	[ConditionalAttribute] // RVA: 0x2AEB30 Offset: 0x2AEC31 VA: 0x2AEB30
	// RVA: 0x1CAF970 Offset: 0x1CAFA71 VA: 0x1CAF970
	private void DbgLogExist(string methodName, Unit attacker, int moveX, int moveZ) { }
}

