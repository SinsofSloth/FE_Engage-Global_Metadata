// Namespace: 
public enum TutorialListRoot.SequenceType // TypeDefIndex: 7726
{
	// Fields
	public int value__; // 0x0
	public const TutorialListRoot.SequenceType Idle = 0;
	public const TutorialListRoot.SequenceType PrepareLoad = 1;
	public const TutorialListRoot.SequenceType Load = 2;
	public const TutorialListRoot.SequenceType Wait = 3;
	public const TutorialListRoot.SequenceType Show = 4;
	public const TutorialListRoot.SequenceType View = 5;
	public const TutorialListRoot.SequenceType Hide = 6;
	public const TutorialListRoot.SequenceType PrepareUnload = 7;
	public const TutorialListRoot.SequenceType Unload = 8;
}

// Namespace: 
public class TutorialListRoot : MonoBehaviour // TypeDefIndex: 7728
{
	// Fields
	private const string PrefabPath = "UI/Common/WdwTutorial/Prefabs/TutorialListRoot";
	private TutorialListRoot.SequenceType m_Seq; // 0x18
	private TutorialListRoot.FadeType m_FadeType; // 0x1C
	private float m_ImageAlpha; // 0x20
	private TResourceHandle<SpriteAtlas> m_MainHandle; // 0x28
	private TResourceHandle<SpriteAtlas> m_SubHandle; // 0x30
	private string m_MainSpriteAtlasPath; // 0x38
	private string m_SubSpriteAtlasPath; // 0x40
	private bool m_IsPrepareLoad; // 0x48
	private SpriteAtlas m_MainSpriteAtlas; // 0x50
	private SpriteAtlas m_SubSpriteAtlas; // 0x58
	private Sprite m_Sprite; // 0x60
	[SpaceAttribute] // RVA: 0x27C840 Offset: 0x27C941 VA: 0x27C840
	[HeaderAttribute] // RVA: 0x27C840 Offset: 0x27C941 VA: 0x27C840
	[SerializeField] // RVA: 0x27C840 Offset: 0x27C941 VA: 0x27C840
	private GameObject m_MenuContentObject; // 0x68
	[SerializeField] // RVA: 0x27C8A0 Offset: 0x27C9A1 VA: 0x27C8A0
	private GameObject m_RightArrow; // 0x70
	[SerializeField] // RVA: 0x27C8B0 Offset: 0x27C9B1 VA: 0x27C8B0
	private GameObject m_LeftArrow; // 0x78
	[SpaceAttribute] // RVA: 0x27C8C0 Offset: 0x27C9C1 VA: 0x27C8C0
	[HeaderAttribute] // RVA: 0x27C8C0 Offset: 0x27C9C1 VA: 0x27C8C0
	[SerializeField] // RVA: 0x27C8C0 Offset: 0x27C9C1 VA: 0x27C8C0
	private TextMeshProUGUI m_CategoryTitleText; // 0x80
	[SerializeField] // RVA: 0x27C920 Offset: 0x27CA21 VA: 0x27C920
	private TextMeshProUGUI m_TutorialTitleText; // 0x88
	[SerializeField] // RVA: 0x27C930 Offset: 0x27CA31 VA: 0x27C930
	private TextMeshProUGUI m_MessageText; // 0x90
	[SerializeField] // RVA: 0x27C940 Offset: 0x27CA41 VA: 0x27C940
	private TextMeshProUGUI m_Page0Text; // 0x98
	[SerializeField] // RVA: 0x27C950 Offset: 0x27CA51 VA: 0x27C950
	private TextMeshProUGUI m_Page1Text; // 0xA0
	[SpaceAttribute] // RVA: 0x27C960 Offset: 0x27CA61 VA: 0x27C960
	[HeaderAttribute] // RVA: 0x27C960 Offset: 0x27CA61 VA: 0x27C960
	[SerializeField] // RVA: 0x27C960 Offset: 0x27CA61 VA: 0x27C960
	private Image m_CaptureImage; // 0xA8
	[HeaderAttribute] // RVA: 0x27C9C0 Offset: 0x27CAC1 VA: 0x27C9C0
	[SerializeField] // RVA: 0x27C9C0 Offset: 0x27CAC1 VA: 0x27C9C0
	[SpaceAttribute] // RVA: 0x27C9C0 Offset: 0x27CAC1 VA: 0x27C9C0
	private Animator m_WdwTutorialAnimator; // 0xB0
	[SpaceAttribute] // RVA: 0x27CA20 Offset: 0x27CB21 VA: 0x27CA20
	[HeaderAttribute] // RVA: 0x27CA20 Offset: 0x27CB21 VA: 0x27CA20
	[RangeAttribute] // RVA: 0x27CA20 Offset: 0x27CB21 VA: 0x27CA20
	[SerializeField] // RVA: 0x27CA20 Offset: 0x27CB21 VA: 0x27CA20
	private float m_AlphaSpeed; // 0xB8

	// Properties
	public TutorialListRoot.SequenceType Seq { get; set; }
	public string MainSpriteAtlasPath { set; }
	public string SubSpriteAtlasPath { set; }
	public TResourceHandle<SpriteAtlas> Handle { get; }
	public bool IsPrepareLoad { set; }
	public SpriteAtlas MainSpriteAtlas { get; }
	public SpriteAtlas SubSpriteAtlas { get; }

	// Methods

	// RVA: 0x287E3E0 Offset: 0x287E4E1 VA: 0x287E3E0
	private void Start() { }

	// RVA: 0x287E520 Offset: 0x287E621 VA: 0x287E520
	private void OnDisable() { }

	// RVA: 0x287E610 Offset: 0x287E711 VA: 0x287E610
	private void Update() { }

	// RVA: 0x287E810 Offset: 0x287E911 VA: 0x287E810
	private void Idle() { }

	// RVA: 0x287E830 Offset: 0x287E931 VA: 0x287E830
	private void PrepareLoad() { }

	// RVA: 0x287E8B0 Offset: 0x287E9B1 VA: 0x287E8B0
	private void Load() { }

	// RVA: 0x287E9D0 Offset: 0x287EAD1 VA: 0x287E9D0
	private void Show() { }

	// RVA: 0x287E9E0 Offset: 0x287EAE1 VA: 0x287E9E0
	private void Hide() { }

	// RVA: 0x287E9F0 Offset: 0x287EAF1 VA: 0x287E9F0
	private void PrepareUnload() { }

	// RVA: 0x287EA10 Offset: 0x287EB11 VA: 0x287EA10
	private void Unload() { }

	// RVA: 0x287EAC0 Offset: 0x287EBC1 VA: 0x287EAC0
	private void UpdateAlpha() { }

	// RVA: 0x287EB80 Offset: 0x287EC81 VA: 0x287EB80
	public static void LoadPrefabAsync() { }

	// RVA: 0x287EC00 Offset: 0x287ED01 VA: 0x287EC00
	public static void UnloadPrefab() { }

	// RVA: 0x287EC80 Offset: 0x287ED81 VA: 0x287EC80
	public static bool IsLoadingPrefab() { }

	// RVA: 0x287ED00 Offset: 0x287EE01 VA: 0x287ED00
	public static GameObject Create() { }

	// RVA: 0x287ED90 Offset: 0x287EE91 VA: 0x287ED90
	public TutorialListSelectMenuContent GetMenuContent() { }

	// RVA: 0x287EDF0 Offset: 0x287EEF1 VA: 0x287EDF0
	public void SetCategoryTitleText(string text) { }

	// RVA: 0x287EE10 Offset: 0x287EF11 VA: 0x287EE10
	public void SetTutorialTitleText(string text) { }

	// RVA: 0x287EE30 Offset: 0x287EF31 VA: 0x287EE30
	public void SetMessageText(string text) { }

	// RVA: 0x287EE50 Offset: 0x287EF51 VA: 0x287EE50
	public void SetPage0Text(int value) { }

	// RVA: 0x287EED0 Offset: 0x287EFD1 VA: 0x287EED0
	public void SetPage1Text(int value) { }

	// RVA: 0x287EF50 Offset: 0x287F051 VA: 0x287EF50
	public void SetSprite(Sprite sprite) { }

	// RVA: 0x287EFF0 Offset: 0x287F0F1 VA: 0x287EFF0
	public void SetFadeType(TutorialListRoot.FadeType fadeType) { }

	// RVA: 0x287E4D0 Offset: 0x287E5D1 VA: 0x287E4D0
	public void SetAlpha(float alpha) { }

	// RVA: 0x287F000 Offset: 0x287F101 VA: 0x287F000
	public void SetActiveRightArrow(bool enable) { }

	// RVA: 0x287F050 Offset: 0x287F151 VA: 0x287F050
	public void SetActiveLeftArrow(bool enable) { }

	// RVA: 0x287F0A0 Offset: 0x287F1A1 VA: 0x287F0A0
	public Animator GetWdwTutorialAnimator() { }

	// RVA: 0x287F0B0 Offset: 0x287F1B1 VA: 0x287F0B0
	public TutorialListRoot.SequenceType get_Seq() { }

	// RVA: 0x287F0C0 Offset: 0x287F1C1 VA: 0x287F0C0
	public void set_Seq(TutorialListRoot.SequenceType value) { }

	// RVA: 0x287F0D0 Offset: 0x287F1D1 VA: 0x287F0D0
	public void set_MainSpriteAtlasPath(string value) { }

	// RVA: 0x287F0E0 Offset: 0x287F1E1 VA: 0x287F0E0
	public void set_SubSpriteAtlasPath(string value) { }

	// RVA: 0x287F0F0 Offset: 0x287F1F1 VA: 0x287F0F0
	public TResourceHandle<SpriteAtlas> get_Handle() { }

	// RVA: 0x287F100 Offset: 0x287F201 VA: 0x287F100
	public void set_IsPrepareLoad(bool value) { }

	// RVA: 0x287F110 Offset: 0x287F211 VA: 0x287F110
	public SpriteAtlas get_MainSpriteAtlas() { }

	// RVA: 0x287F120 Offset: 0x287F221 VA: 0x287F120
	public SpriteAtlas get_SubSpriteAtlas() { }

	// RVA: 0x287F130 Offset: 0x287F231 VA: 0x287F130
	public bool IsOpeningWdwTutorial() { }

	// RVA: 0x287F190 Offset: 0x287F291 VA: 0x287F190
	public void CloseWdwTutorial() { }

	// RVA: 0x287F1F0 Offset: 0x287F2F1 VA: 0x287F1F0
	public bool IsClosingWdwTutorial() { }

	// RVA: 0x287F250 Offset: 0x287F351 VA: 0x287F250
	public void .ctor() { }
}

