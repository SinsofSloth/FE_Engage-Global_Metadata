// Namespace: App
public class SolanelInfoMenuContent : BasicMenuContent // TypeDefIndex: 11458
{
	// Fields
	private const string PrefabPath = "UI/Hub/CafeTerrace/NoticeBoard/Prefabs/SolanelInfoRoot";
	private const string SpriteAtlasPath = "UI/Hub/MiniMap/Textures/MiniMap";
	private static SpriteAtlasManager s_SpriteAtlasManager; // 0x0
	[SerializeField] // RVA: 0x2982E0 Offset: 0x2983E1 VA: 0x2982E0
	[HeaderAttribute] // RVA: 0x2982E0 Offset: 0x2983E1 VA: 0x2982E0
	private GameObject m_MapArrow; // 0xE8
	[SerializeField] // RVA: 0x298330 Offset: 0x298431 VA: 0x298330
	private float m_MapArrowMoveFrame; // 0xF0
	[SerializeField] // RVA: 0x298340 Offset: 0x298441 VA: 0x298340
	private List<GameObject> m_MapPoint; // 0xF8
	[SerializeField] // RVA: 0x298350 Offset: 0x298451 VA: 0x298350
	[HeaderAttribute] // RVA: 0x298350 Offset: 0x298451 VA: 0x298350
	private TextMeshProUGUI m_AreaName; // 0x100
	[SerializeField] // RVA: 0x2983A0 Offset: 0x2984A1 VA: 0x2983A0
	private TextMeshProUGUI m_AreaHelp; // 0x108
	[SerializeField] // RVA: 0x2983B0 Offset: 0x2984B1 VA: 0x2983B0
	private List<GameObject> m_AreaFastTravelObj; // 0x110
	private List<SolanelInfoMenuContent.HelpFastTravel> m_HelpFastTravelList; // 0x118
	[SerializeField] // RVA: 0x2983C0 Offset: 0x2984C1 VA: 0x2983C0
	[HeaderAttribute] // RVA: 0x2983C0 Offset: 0x2984C1 VA: 0x2983C0
	private List<GameObject> m_UnitListObj; // 0x120
	private List<SolanelInfoMenuContent.SolanelUnit> m_SolanelUnitList; // 0x128
	[HeaderAttribute] // RVA: 0x298410 Offset: 0x298511 VA: 0x298410
	[SerializeField] // RVA: 0x298410 Offset: 0x298511 VA: 0x298410
	private GameObject m_InfomationAbsentObj; // 0x130
	[SerializeField] // RVA: 0x298460 Offset: 0x298561 VA: 0x298460
	private List<GameObject> m_InfomationListObj; // 0x138
	private Vector2 m_Pos; // 0x140
	private Vector2 m_From; // 0x148
	private Vector2 m_To; // 0x150
	private float m_MoveTick; // 0x158

	// Methods

	// RVA: 0x27E7BD0 Offset: 0x27E7CD1 VA: 0x27E7BD0 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x27E7D50 Offset: 0x27E7E51 VA: 0x27E7D50 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x27E7E40 Offset: 0x27E7F41 VA: 0x27E7E40 Slot: 32
	protected override void Update() { }

	// RVA: 0x27E7F90 Offset: 0x27E8091 VA: 0x27E7F90
	public static void LoadPrefabAsync() { }

	// RVA: 0x27E8100 Offset: 0x27E8201 VA: 0x27E8100
	public static bool IsLoadingPrefab() { }

	// RVA: 0x27E8210 Offset: 0x27E8311 VA: 0x27E8210
	public static void UnloadPrefab() { }

	// RVA: 0x27E7160 Offset: 0x27E7261 VA: 0x27E7160
	public static SolanelInfoMenuContent Create() { }

	// RVA: 0x27E9700 Offset: 0x27E9801 VA: 0x27E9700 Slot: 21
	public override float CalcW() { }

	// RVA: 0x27E9770 Offset: 0x27E9871 VA: 0x27E9770 Slot: 22
	public override float CalcH() { }

	// RVA: 0x27E8330 Offset: 0x27E8431 VA: 0x27E8330
	private void Initialize() { }

	// RVA: 0x27E97E0 Offset: 0x27E98E1 VA: 0x27E97E0
	public SpriteAtlasManager GetSpriteAtlasManager() { }

	// RVA: 0x27E7470 Offset: 0x27E7571 VA: 0x27E7470
	public void SetAreaDetail(HubAreaData data) { }

	// RVA: 0x27E9850 Offset: 0x27E9951 VA: 0x27E9850
	public void .ctor() { }

	// RVA: 0x27E9970 Offset: 0x27E9A71 VA: 0x27E9970
	private static void .cctor() { }
}

