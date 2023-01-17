// Namespace: App
public class MascotAccChangeContent : BasicMenuContent // TypeDefIndex: 10837
{
	// Fields
	private const string PrefabPath = "UI/Hub/Mascot/Prefabs/AccChangeRoot";
	private const string UIName = "MascotAccChange";
	private GameObject m_category1; // 0xE8
	private GameObject m_category2; // 0xF0
	private GameObject m_content1; // 0xF8
	private GameObject m_content2; // 0x100
	private GameObject m_exchangeCursor; // 0x108
	[SerializeField] // RVA: 0x295C90 Offset: 0x295D91 VA: 0x295C90
	private GameObject m_ChoiceAcc; // 0x110
	[SerializeField] // RVA: 0x295CA0 Offset: 0x295DA1 VA: 0x295CA0
	private GameObject m_AccName; // 0x118
	[SerializeField] // RVA: 0x295CB0 Offset: 0x295DB1 VA: 0x295CB0
	private GameObject m_AccIcon; // 0x120
	[SerializeField] // RVA: 0x295CC0 Offset: 0x295DC1 VA: 0x295CC0
	private GameObject m_AccParts; // 0x128
	[SerializeField] // RVA: 0x295CD0 Offset: 0x295DD1 VA: 0x295CD0
	private GameObject m_AccHelp; // 0x130

	// Methods

	// RVA: 0x2764450 Offset: 0x2764551 VA: 0x2764450
	public static void LoadPrefabAsync() { }

	// RVA: 0x27644F0 Offset: 0x27645F1 VA: 0x27644F0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2764570 Offset: 0x2764671 VA: 0x2764570
	public static void UnloadPrefab() { }

	// RVA: 0x27645F0 Offset: 0x27646F1 VA: 0x27645F0
	public static MascotAccChangeContent Create() { }

	// RVA: 0x27646C0 Offset: 0x27647C1 VA: 0x27646C0
	public static void Destroy() { }

	// RVA: 0x2764750 Offset: 0x2764851 VA: 0x2764750
	public void SetActiveParts(MascotAccData.PartsType type) { }

	// RVA: 0x27649C0 Offset: 0x2764AC1 VA: 0x27649C0
	public void SetHelpText(MascotAccData mascotData, AccessoryData accData) { }

	// RVA: 0x2764C10 Offset: 0x2764D11 VA: 0x2764C10
	private void UpdateEquipText(TextMeshProUGUI text, string aid) { }

	// RVA: 0x2764E50 Offset: 0x2764F51 VA: 0x2764E50
	public void UpdateEquipAcc() { }

	// RVA: 0x2764F50 Offset: 0x2765051 VA: 0x2764F50 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x2764F90 Offset: 0x2765091 VA: 0x2764F90 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2764FA0 Offset: 0x27650A1 VA: 0x2764FA0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2765010 Offset: 0x2765111 VA: 0x2765010 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2765080 Offset: 0x2765181 VA: 0x2765080 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2765170 Offset: 0x2765271 VA: 0x2765170 Slot: 30
	protected override void Awake() { }

	// RVA: 0x27655A0 Offset: 0x27656A1 VA: 0x27655A0
	public void .ctor() { }
}

