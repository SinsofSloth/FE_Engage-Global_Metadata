// Namespace: App
public class RingListSequence : SingletonProcInst<RingListSequence> // TypeDefIndex: 13133
{
	// Fields
	private const string LayoutPrefabPath = "UI/Hub/RingBook/Prefabs/BookRoot";
	private const string CharaFrameImageSpriteAtlasPath = "UI/Hub/RingBook/Textures/RingBook";
	private RingListSequence.PageDataList m_PageList; // 0x78
	private int m_CurrentPageIndex; // 0x80
	private RingListSequence.PageData m_CurrentPageData; // 0x88
	private GameObject m_LayoutPrefab; // 0x90
	private RingListSequence.RelatedGroupWindow m_RelatedGroupWindow; // 0x98
	private RingListSequence.CharaArrowGroup m_CharaArrowGroup; // 0xA0
	private RingListSequence.CharaImageController m_CharaImageController; // 0xA8
	private RingListSequence.CharaNavigation m_CharaNavigation; // 0xB0
	private RingListSequence.CharaInfoWindow m_CharaInfoWindow; // 0xB8
	private RingListSkillMenu m_SkillListWindow; // 0xC0
	private RingListSequence.RingListWindow m_RingListWindow; // 0xC8
	private RingListSequence.GodAndRingListWindow m_GodAndRingListWindow; // 0xD0
	private RingListSequence.PageData m_ReservedJumpPageData; // 0xD8
	private SpriteAtlasManager m_CharaFrameSpriteAtlasManager; // 0xE0
	private Animator m_RootAnim; // 0xE8

	// Methods

	// RVA: 0x268D8B0 Offset: 0x268D9B1 VA: 0x268D8B0
	private static GodUnit GetGodUnit(GodData godData) { }

	// RVA: 0x268D8C0 Offset: 0x268D9C1 VA: 0x268D8C0
	private static bool IsGotGod(GodData godData) { }

	// RVA: 0x268D8F0 Offset: 0x268D9F1 VA: 0x268D8F0
	private static bool IsGotRing(RingData ringData) { }

	// RVA: 0x268D900 Offset: 0x268DA01 VA: 0x268D900
	private static bool IsGodAndRingRelated(RingListSequence.GodPageData godPageData, RingListSequence.RingPageData ringPageData) { }

	// RVA: 0x268D930 Offset: 0x268DA31 VA: 0x268D930
	private static string GetGodName(GodData godData) { }

	// RVA: 0x268D990 Offset: 0x268DA91 VA: 0x268D990
	private static string GetGodName(RingListSequence.PageData pageData) { }

	// RVA: 0x268DAD0 Offset: 0x268DBD1 VA: 0x268DAD0
	private bool CompareGodName(string godName1, string godName2) { }

	// RVA: 0x268DAE0 Offset: 0x268DBE1 VA: 0x268DAE0
	private static string GetWorldTextMid(GodData godData) { }

	// RVA: 0x268DB70 Offset: 0x268DC71 VA: 0x268DB70
	private void Load() { }

	// RVA: 0x268DCF0 Offset: 0x268DDF1 VA: 0x268DCF0
	private void Unload() { }

	// RVA: 0x268DEB0 Offset: 0x268DFB1 VA: 0x268DEB0
	private void WaitLoading() { }

	// RVA: 0x268E000 Offset: 0x268E101 VA: 0x268E000
	private void Start() { }

	// RVA: 0x268E5F0 Offset: 0x268E6F1 VA: 0x268E5F0
	private void SetPageData(RingListSequence.PageData pageData) { }

	// RVA: 0x268ECF0 Offset: 0x268EDF1 VA: 0x268ECF0
	private void Open() { }

	// RVA: 0x268EED0 Offset: 0x268EFD1 VA: 0x268EED0
	private void WaitOpening() { }

	// RVA: 0x268EF90 Offset: 0x268F091 VA: 0x268EF90
	private void Tick() { }

	// RVA: 0x268FD00 Offset: 0x268FE01 VA: 0x268FD00
	private void Close() { }

	// RVA: 0x268FE80 Offset: 0x268FF81 VA: 0x268FE80
	private void WaitClosing() { }

	// RVA: 0x268FF40 Offset: 0x2690041 VA: 0x268FF40 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x268FFE0 Offset: 0x26900E1 VA: 0x268FFE0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x26900C0 Offset: 0x26901C1 VA: 0x26900C0
	private ProcDesc[] GetDesc() { }

	// RVA: 0x2690780 Offset: 0x2690881 VA: 0x2690780
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x26908C0 Offset: 0x26909C1 VA: 0x26908C0
	public static bool IsOpenEnable() { }

	// RVA: 0x2690800 Offset: 0x2690901 VA: 0x2690800
	public void .ctor() { }
}

