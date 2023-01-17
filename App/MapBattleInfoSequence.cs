// Namespace: App
internal class MapBattleInfoSequence : MonoBehaviour // TypeDefIndex: 12480
{
	// Fields
	public MapBattleInfoSequenceAttack[] m_AttackList; // 0x18
	public GameObject m_HealRoot; // 0x20
	public TextMeshProUGUI m_Heal; // 0x28

	// Methods

	// RVA: 0x2324150 Offset: 0x2324251 VA: 0x2324150
	public void SetBattleInfo(bool bShowWdw, BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x2324860 Offset: 0x2324961 VA: 0x2324860
	public static void GetSequenceAttack(BattleInfo info, BattleSceneList sceneList, out List<MapBattleInfoSequence.AttackInfo> attacks, bool isSeparator = False) { }

	// RVA: 0x2324F10 Offset: 0x2325011 VA: 0x2324F10
	private static bool SetAttackInfo(BattleInfo info, BattleSceneList sceneList, ref int sceneIdx, ref int firstOffenseDamage, ref int firstDefenseDamage, out MapBattleInfoSequence.AttackInfo attackInfo) { }

	// RVA: 0x2325BC0 Offset: 0x2325CC1 VA: 0x2325BC0
	private static int GetChainAttackCount(BattleSceneList sceneList, ref int idx, ref bool isDead) { }

	// RVA: 0x2325E40 Offset: 0x2325F41 VA: 0x2325E40
	private static int NextPushAttack(BattleSceneList sceneList, int startIdx, ref bool isDead) { }

	// RVA: 0x2325F60 Offset: 0x2326061 VA: 0x2325F60
	private static int PrePopOrder(BattleSceneList sceneList, int startIdx) { }

	// RVA: 0x2326000 Offset: 0x2326101 VA: 0x2326000
	public void .ctor() { }
}

