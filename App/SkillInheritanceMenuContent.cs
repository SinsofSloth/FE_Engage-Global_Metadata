// Namespace: App
public class SkillInheritanceMenuContent : BasicMenuContent // TypeDefIndex: 11225
{
	// Fields
	private const string PrefabPath = "UI/Hub/GodRoom/Prefabs/SkillSelectRoot";
	[SerializeField] // RVA: 0x296FF0 Offset: 0x2970F1 VA: 0x296FF0
	private TextMeshProUGUI m_TextGodName; // 0xE8
	[SerializeField] // RVA: 0x297000 Offset: 0x297101 VA: 0x297000
	private UnitIcon m_IconGod; // 0xF0
	[SerializeField] // RVA: 0x297010 Offset: 0x297111 VA: 0x297010
	private List<GameObject> m_ObjNaviList; // 0xF8
	[SerializeField] // RVA: 0x297020 Offset: 0x297121 VA: 0x297020
	private TextMeshProUGUI m_TextHelp; // 0x100
	[SerializeField] // RVA: 0x297030 Offset: 0x297131 VA: 0x297030
	private TextMeshProUGUI m_TextHelpNg; // 0x108
	[SerializeField] // RVA: 0x297040 Offset: 0x297141 VA: 0x297040
	private TextMeshProUGUI m_TextValueSp; // 0x110
	[SerializeField] // RVA: 0x297050 Offset: 0x297151 VA: 0x297050
	private TextMeshProUGUI m_TextUnitName; // 0x118
	private GameObject m_SkillSelectObj; // 0x120

	// Methods

	// RVA: 0x27DF420 Offset: 0x27DF521 VA: 0x27DF420 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x27DF520 Offset: 0x27DF621 VA: 0x27DF520 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x27DF610 Offset: 0x27DF711 VA: 0x27DF610
	public static void LoadPrefabAsync() { }

	// RVA: 0x27DF6B0 Offset: 0x27DF7B1 VA: 0x27DF6B0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x27DF730 Offset: 0x27DF831 VA: 0x27DF730
	public static void UnloadPrefab() { }

	// RVA: 0x27DBAE0 Offset: 0x27DBBE1 VA: 0x27DBAE0
	public static SkillInheritanceMenuContent Create() { }

	// RVA: 0x27DC700 Offset: 0x27DC801 VA: 0x27DC700
	public void Initialize() { }

	// RVA: 0x27DE070 Offset: 0x27DE171 VA: 0x27DE070
	public void SetActive(bool isActive) { }

	// RVA: 0x27DE260 Offset: 0x27DE361 VA: 0x27DE260
	public void SetCharaImageIgnoreParentGroups(bool isIgnore) { }

	// RVA: 0x27DF7B0 Offset: 0x27DF8B1 VA: 0x27DF7B0
	public void EnableInput(bool isEnable) { }

	// RVA: 0x27DD0B0 Offset: 0x27DD1B1 VA: 0x27DD0B0
	public void CloseOther() { }

	// RVA: 0x27DF800 Offset: 0x27DF901 VA: 0x27DF800 Slot: 21
	public override float CalcW() { }

	// RVA: 0x27DF870 Offset: 0x27DF971 VA: 0x27DF870 Slot: 22
	public override float CalcH() { }

	// RVA: 0x27DEF30 Offset: 0x27DF031 VA: 0x27DEF30
	public void SetSkillHelp(Unit unit, GodUnit god, SkillData skill, int level) { }

	// RVA: 0x27DE6C0 Offset: 0x27DE7C1 VA: 0x27DE6C0
	public void SetNavi(int index, bool isActive, GodUnit god) { }

	// RVA: 0x27DCE30 Offset: 0x27DCF31 VA: 0x27DCE30
	public void UpdateSkillPoint() { }

	// RVA: 0x27DF8E0 Offset: 0x27DF9E1 VA: 0x27DF8E0
	public void .ctor() { }
}

