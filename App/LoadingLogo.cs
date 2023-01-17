// Namespace: App
public class LoadingLogo : SingletonMonoBehaviour<LoadingLogo> // TypeDefIndex: 14073
{
	// Fields
	private const int GroundImageMax = 4;
	private const int UnitDotMax = 15;
	[SerializeField] // RVA: 0x29D900 Offset: 0x29DA01 VA: 0x29D900
	public GameObject m_Tips; // 0x20
	[SerializeField] // RVA: 0x29D910 Offset: 0x29DA11 VA: 0x29D910
	public GameObject m_Icon; // 0x28
	private CanvasGroup m_IconCanvasGroup; // 0x30
	private CanvasGroup m_TipsCanvasGroup; // 0x38
	private UnitIcon m_TipsUnitIcon; // 0x40
	private GameObject m_ItemIconRootObject; // 0x48
	private Image m_ItemIconFrameImage; // 0x50
	private Image m_ItemIconImage; // 0x58
	private Image m_SkillIconImage; // 0x60
	private Image m_TitleFrameImage; // 0x68
	private TextMeshProUGUI m_TitleText; // 0x70
	private TextMeshProUGUI m_TipsText; // 0x78
	private GameObject m_UnitIconAndGroundRootObject; // 0x80
	private GameObject[] m_GroundImageObjects; // 0x88
	private LoadingLogo.UnitDotObject[] m_UnitDotObjects; // 0x90
	private TipsData m_TipsData; // 0x98
	private InterpolatorFloat m_TipsAlpha; // 0xA0
	private InterpolatorFloat m_IconAlpha; // 0xA8
	private LoadingManager.Modes m_LoadingMode; // 0xB0
	private LoadingLogo.Sequences m_Sequence; // 0xB4

	// Methods

	// RVA: 0x1F8D7C0 Offset: 0x1F8D8C1 VA: 0x1F8D7C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1F8DFF0 Offset: 0x1F8E0F1 VA: 0x1F8DFF0
	protected void Start() { }

	// RVA: 0x1F8E3A0 Offset: 0x1F8E4A1 VA: 0x1F8E3A0
	protected void LateUpdate() { }

	// RVA: 0x1F8E720 Offset: 0x1F8E821 VA: 0x1F8E720
	private static TipsData GetNextTipsData(TipsData now, LoadingManager.Modes mode) { }

	// RVA: 0x1F8F040 Offset: 0x1F8F141 VA: 0x1F8F040
	private void SetText(TextMeshProUGUI textMesh, string text) { }

	// RVA: 0x1F8E9B0 Offset: 0x1F8EAB1 VA: 0x1F8E9B0
	private void SetTipsData(TipsData tipsData) { }

	// RVA: 0x1F8E000 Offset: 0x1F8E101 VA: 0x1F8E000
	private void Clear() { }

	// RVA: 0x1F8F0E0 Offset: 0x1F8F1E1 VA: 0x1F8F0E0
	private void ShowImpl(LoadingManager.Modes mode) { }

	// RVA: 0x1F8F9B0 Offset: 0x1F8FAB1 VA: 0x1F8F9B0
	private void ShowImpl(Unit heroUnit, Unit eatUnit0, Unit eatUnit1) { }

	// RVA: 0x1F8F130 Offset: 0x1F8F231 VA: 0x1F8F130
	private void ShowImpl(TipsData tipsData, Unit heroUnit, Unit eatUnit0, Unit eatUnit1) { }

	// RVA: 0x1F8F9D0 Offset: 0x1F8FAD1 VA: 0x1F8F9D0
	private bool SetupUnitDot(int iconIndex, Unit unit) { }

	// RVA: 0x1F8FB90 Offset: 0x1F8FC91 VA: 0x1F8FB90
	private bool SetupUnitDot(int iconIndex, PersonData person, bool isFemale) { }

	// RVA: 0x1F8FBF0 Offset: 0x1F8FCF1 VA: 0x1F8FBF0
	private void HideImpl() { }

	// RVA: 0x1F8E6A0 Offset: 0x1F8E7A1 VA: 0x1F8E6A0
	private void Commit() { }

	// RVA: 0x1F8FC60 Offset: 0x1F8FD61 VA: 0x1F8FC60
	public static void Show(LoadingManager.Modes mode) { }

	// RVA: 0x1F8FD40 Offset: 0x1F8FE41 VA: 0x1F8FD40
	public static void Show(TipsData tipsData) { }

	// RVA: 0x1F8FDF0 Offset: 0x1F8FEF1 VA: 0x1F8FDF0
	public static void Show(Unit heroUnit, Unit eatUnit0, Unit eatUnit1) { }

	// RVA: 0x1F8FEC0 Offset: 0x1F8FFC1 VA: 0x1F8FEC0
	public static void Hide() { }

	// RVA: 0x1F8FFA0 Offset: 0x1F900A1 VA: 0x1F8FFA0
	public void .ctor() { }
}

