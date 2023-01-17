// Namespace: App
public class MapBattleInfoRoot : MonoBehaviour // TypeDefIndex: 12477
{
	// Fields
	public GameObject m_FrameRoot; // 0x18
	public GameObject m_CommandRoot; // 0x20
	public GameObject m_CommandSubRoot; // 0x28
	public TextMeshProUGUI m_CommandText; // 0x30
	public TextMeshProUGUI m_CommandSubText; // 0x38
	public GameObject m_InfoLeft; // 0x40
	public GameObject m_InfoRight; // 0x48

	// Methods

	// RVA: 0x2323030 Offset: 0x2323131 VA: 0x2323030
	public static bool IsDestroy(BattleInfo info) { }

	// RVA: 0x2323090 Offset: 0x2323191 VA: 0x2323090
	public static bool IsDance(BattleInfo info) { }

	// RVA: 0x23230F0 Offset: 0x23231F1 VA: 0x23230F0
	public static bool IsFireCannon(BattleInfo info) { }

	// RVA: 0x231DFF0 Offset: 0x231E0F1 VA: 0x231DFF0
	public static bool IsEngageRodRangeAgain(BattleInfo info, UnitItem item) { }

	// RVA: 0x2320CE0 Offset: 0x2320DE1 VA: 0x2320CE0
	public static bool IsEngageRodRangeHeal(BattleInfo info, UnitItem item) { }

	// RVA: 0x231E140 Offset: 0x231E241 VA: 0x231E140
	public static bool IsSupoortCommandSkill() { }

	// RVA: 0x2320E90 Offset: 0x2320F91 VA: 0x2320E90
	public static bool IsRodInterference(BattleSide.Type sideType, UnitItem item) { }

	// RVA: 0x2320F80 Offset: 0x2321081 VA: 0x2320F80
	public static bool IsRodRangeHeal(UnitItem item) { }

	// RVA: 0x2323150 Offset: 0x2323251 VA: 0x2323150
	public static bool IsRodCreation(UnitItem item) { }

	// RVA: 0x2323200 Offset: 0x2323301 VA: 0x2323200
	public static bool IsRodRewarp(UnitItem item) { }

	// RVA: 0x23232B0 Offset: 0x23233B1 VA: 0x23232B0
	public static bool IsNoShowParamRod(UnitItem item) { }

	// RVA: 0x2321080 Offset: 0x2321181 VA: 0x2321080
	public static bool IsRecoveryHP(BattleSide.Type sideType, BattleSceneList sceneList) { }

	// RVA: 0x2322D60 Offset: 0x2322E61 VA: 0x2322D60
	public static bool IsSelfRecoveryHP(BattleSide.Type sideType, BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x2323360 Offset: 0x2323461 VA: 0x2323360
	public static bool IsSelfTarget(BattleInfo info) { }

	// RVA: 0x2323420 Offset: 0x2323521 VA: 0x2323420
	public static bool IsNotExistTarget(BattleInfo info) { }

	// RVA: 0x23214C0 Offset: 0x23215C1 VA: 0x23214C0
	public static bool IsShowParam(BattleInfoSide side, BattleSceneList sceneList) { }

	// RVA: 0x2320230 Offset: 0x2320331 VA: 0x2320230
	public static bool IsEngageRodBless(BattleInfo info, UnitItem item) { }

	// RVA: 0x2320330 Offset: 0x2320431 VA: 0x2320330
	public static bool IsEngageRodBlessRest(BattleInfo info, UnitItem item) { }

	// RVA: 0x23209E0 Offset: 0x2320AE1 VA: 0x23209E0
	public static bool IsRodRest(UnitItem item) { }

	// RVA: 0x2320AA0 Offset: 0x2320BA1 VA: 0x2320AA0
	public static bool IsEnchantHeal(UnitItem item) { }

	// RVA: 0x2320BC0 Offset: 0x2320CC1 VA: 0x2320BC0
	public static bool IsEnchantRest(UnitItem item) { }

	// RVA: 0x2323490 Offset: 0x2323591 VA: 0x2323490
	public bool Setup(MapMind.Type mindType, SkillData skill, BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x2323970 Offset: 0x2323A71 VA: 0x2323970
	public void SetCommandText(MapMind.Type mindType) { }

	// RVA: 0x23238A0 Offset: 0x23239A1 VA: 0x23238A0
	public void SetCommandText(SkillData skill) { }

	// RVA: 0x2323820 Offset: 0x2323921 VA: 0x2323820
	public void SetCommandText(string text) { }

	// RVA: 0x2323F50 Offset: 0x2324051 VA: 0x2323F50
	public void SetEngageCommandVisible(MapMind.Type mindType, Unit unit, Unit target) { }

	// RVA: 0x2324140 Offset: 0x2324241 VA: 0x2324140
	public void .ctor() { }
}

