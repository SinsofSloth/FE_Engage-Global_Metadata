// Namespace: App
public class ArenaBondGodSelectRoot : MonoBehaviour // TypeDefIndex: 10943
{
	// Fields
	private const string PrefabPath = "UI/Hub/Arena/Prefabs/GodTrainingGodSelectRoot";
	private const string HelpPrefabPath = "UI/Hub/Arena/Prefabs/DetailHelp";
	[SerializeField] // RVA: 0x295F40 Offset: 0x296041 VA: 0x295F40
	private ArenaBondGodSelectMenuContent m_MenuContent; // 0x18
	[SerializeField] // RVA: 0x295F50 Offset: 0x296051 VA: 0x295F50
	private ArenaBondGodSelectSkillListSetter m_SkillListSetter; // 0x20
	[SerializeField] // RVA: 0x295F60 Offset: 0x296061 VA: 0x295F60
	private MenuBondSetter m_BondSetter; // 0x28
	private ArenaBondGodSelectRoot.DecideEventHandler m_DecideEventHandler; // 0x30
	private ArenaBondGodSelectMenu m_Menu; // 0x38
	private Unit m_SelectUnit; // 0x40
	private GodUnit m_SelectGod; // 0x48
	private RingCleaningSequence.GodType m_SelectType; // 0x50

	// Methods

	// RVA: 0x2102EB0 Offset: 0x2102FB1 VA: 0x2102EB0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2102F50 Offset: 0x2103051 VA: 0x2102F50
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2103020 Offset: 0x2103121 VA: 0x2103020
	public static void UnloadPrefab() { }

	// RVA: 0x21030C0 Offset: 0x21031C1 VA: 0x21030C0
	public static ArenaBondGodSelectRoot CreateBind(ProcInst super, Unit selectUnit, GodUnit defaultGod, RingCleaningSequence.GodType changeType, ArenaBondGodSelectRoot.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2103250 Offset: 0x2103351 VA: 0x2103250
	private void Create(ProcInst super, Unit selectUnit, GodUnit defaultGod, RingCleaningSequence.GodType changeType, ArenaBondGodSelectRoot.DecideEventHandler decideEventHandler) { }

	// RVA: 0x21035C0 Offset: 0x21036C1 VA: 0x21035C0
	public void CharaInfoPlayAnim(string animName) { }

	// RVA: 0x21036B0 Offset: 0x21037B1 VA: 0x21036B0
	private void OnSelectMenuItem(GodUnit god, RingCleaningSequence.GodType changeType) { }

	// RVA: 0x2103CC0 Offset: 0x2103DC1 VA: 0x2103CC0
	private void OnDecideMenuItem(GodUnit god, RingCleaningSequence.GodType changeType) { }

	// RVA: 0x2103D00 Offset: 0x2103E01 VA: 0x2103D00
	private void OnChangeUnitToPrev() { }

	// RVA: 0x2103EF0 Offset: 0x2103FF1 VA: 0x2103EF0
	private void OnChangeUnitToNext() { }

	// RVA: 0x2104100 Offset: 0x2104201 VA: 0x2104100
	private void OnStartHelp(ProcInst super, GodData god, int bondLv) { }

	// RVA: 0x2104440 Offset: 0x2104541 VA: 0x2104440
	public void .ctor() { }
}

