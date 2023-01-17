// Namespace: App
public class ArenaBondLevelSelectRoot : MonoBehaviour // TypeDefIndex: 10956
{
	// Fields
	private const string PrefabPath = "UI/Hub/Arena/Prefabs/GodTrainingLevelSelectRoot";
	[SerializeField] // RVA: 0x2960C0 Offset: 0x2961C1 VA: 0x2960C0
	private ArenaBondLevelSelectMenuContent m_MenuContent; // 0x18
	[SerializeField] // RVA: 0x2960D0 Offset: 0x2961D1 VA: 0x2960D0
	private ArenaBondLevelSelectSetter m_LevelSetter; // 0x20
	[SerializeField] // RVA: 0x2960E0 Offset: 0x2961E1 VA: 0x2960E0
	private MenuBondSetter m_BondSetter; // 0x28
	private ArenaBondLevelSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x30
	private ArenaBondLevelSelectMenu m_Menu; // 0x38
	private Unit m_SelectUnit; // 0x40
	private int m_SelectGodIndex; // 0x48

	// Methods

	// RVA: 0x21052B0 Offset: 0x21053B1 VA: 0x21052B0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2105330 Offset: 0x2105431 VA: 0x2105330
	public static bool IsLoadingPrefab() { }

	// RVA: 0x21053B0 Offset: 0x21054B1 VA: 0x21053B0
	public static void UnloadPrefab() { }

	// RVA: 0x2105430 Offset: 0x2105531 VA: 0x2105430
	public static ArenaBondLevelSelectRoot CreateBind(ProcInst super, Unit selectUnit, GodUnit selectGod, RingCleaningSequence.GodType selectType, ArenaBondLevelSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x21055C0 Offset: 0x21056C1 VA: 0x21055C0
	private void Create(ProcInst super, Unit selectUnit, GodUnit selectGod, RingCleaningSequence.GodType selectType, ArenaBondLevelSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x21059A0 Offset: 0x2105AA1 VA: 0x21059A0
	public void CharaInfoPlayAnim(string animName) { }

	// RVA: 0x2105A90 Offset: 0x2105B91 VA: 0x2105A90
	public void OnSelectMenuItem(GodUnit god, int fromLv, int toLv) { }

	// RVA: 0x2105DE0 Offset: 0x2105EE1 VA: 0x2105DE0
	public void OnDecideMenuItem(GodUnit god, RingCleaningSequence.GodType type, bool start, int exp, int useCount) { }

	// RVA: 0x2105DF0 Offset: 0x2105EF1 VA: 0x2105DF0
	private void OnChangeGodToNext() { }

	// RVA: 0x2105F90 Offset: 0x2106091 VA: 0x2105F90
	private void OnChangeGodToPrev() { }

	// RVA: 0x2106140 Offset: 0x2106241 VA: 0x2106140
	public void .ctor() { }
}

