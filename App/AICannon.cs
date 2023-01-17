// Namespace: App
public class AICannon // TypeDefIndex: 9241
{
	// Fields
	private List<AICannon.CannonData> m_Cannons; // 0x10
	private AIBattleSimulator m_Simulator; // 0x18
	private MapDeployMoveImage m_EnemiesMoveImage; // 0x20
	private Unit[] m_NearEnemies; // 0x28
	private int[] m_EnemyDists; // 0x30

	// Properties
	public List<AICannon.CannonData> Cannons { get; }

	// Methods

	// RVA: 0x1C9F0B0 Offset: 0x1C9F1B1 VA: 0x1C9F0B0
	public void .ctor() { }

	// RVA: 0x1CA6120 Offset: 0x1CA6221 VA: 0x1CA6120
	public void Update() { }

	// RVA: 0x1CA6390 Offset: 0x1CA6491 VA: 0x1CA6390
	public bool Think(Unit actor, uint attackScore, float killRate) { }

	// RVA: 0x1CA7370 Offset: 0x1CA7471 VA: 0x1CA7370
	public bool ThinkFireCannon(Unit actor) { }

	// RVA: 0x1CA7100 Offset: 0x1CA7201 VA: 0x1CA7100
	private bool ThinkCommonCheck(Unit actor, AICannon.CannonData cannon, out int move, out SkillData cannonSkill) { }

	// RVA: 0x1CA8680 Offset: 0x1CA8781 VA: 0x1CA8680
	public static bool CanUse(Unit actor, AICannon.CannonData cannon) { }

	// RVA: 0x1CA5FE0 Offset: 0x1CA60E1 VA: 0x1CA5FE0
	private List<AICannon.CannonData> EnumerateCannon() { }

	// RVA: 0x1CA8EA0 Offset: 0x1CA8FA1 VA: 0x1CA8EA0
	public List<AICannon.CannonData> get_Cannons() { }
}

