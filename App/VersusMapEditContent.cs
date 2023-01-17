// Namespace: App
public class VersusMapEditContent : MonoBehaviour // TypeDefIndex: 13641
{
	// Fields
	private const string PrefabPath = "UI/Network/Versus/Prefabs/VersusMapEditThumb";
	private const string SpriteAtlasThumbPath = "UI/Network/Versus/MapObjThumb/MapObjThumb";
	private const string SpriteAtlasCategoryPath = "UI/Network/Versus/Textures/Versus";
	private SpriteAtlas m_ThumbSpriteAtlas; // 0x18
	private Sprite m_ThumbSprite; // 0x20
	private SpriteAtlas m_CategorySpriteAtlas; // 0x28
	private Sprite m_CategorySprite; // 0x30
	[SerializeField] // RVA: 0x29C800 Offset: 0x29C901 VA: 0x29C800
	private Image m_ThumbImage; // 0x38
	[SerializeField] // RVA: 0x29C810 Offset: 0x29C911 VA: 0x29C810
	private Image m_CategoryImage; // 0x40
	[SerializeField] // RVA: 0x29C820 Offset: 0x29C921 VA: 0x29C820
	private TextMeshProUGUI m_HelpNum; // 0x48
	[SerializeField] // RVA: 0x29C830 Offset: 0x29C931 VA: 0x29C830
	private Animator m_Anim; // 0x50
	[SerializeField] // RVA: 0x29C840 Offset: 0x29C941 VA: 0x29C840
	private List<VersusMapEditCategoryContent> m_CategoryItems; // 0x58

	// Methods

	// RVA: 0x2A4B300 Offset: 0x2A4B401 VA: 0x2A4B300
	public static void LoadPrefabAsync() { }

	// RVA: 0x2A4B400 Offset: 0x2A4B501 VA: 0x2A4B400
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2A4B520 Offset: 0x2A4B621 VA: 0x2A4B520
	public static void UnloadPrefab() { }

	// RVA: 0x2A4B5E0 Offset: 0x2A4B6E1 VA: 0x2A4B5E0
	public static VersusMapEditContent Create() { }

	// RVA: 0x2A4B8D0 Offset: 0x2A4B9D1 VA: 0x2A4B8D0
	public void Destroy() { }

	// RVA: 0x2A4B6E0 Offset: 0x2A4B7E1 VA: 0x2A4B6E0
	private void Initialize() { }

	// RVA: 0x2A4BA30 Offset: 0x2A4BB31 VA: 0x2A4BA30
	public void SetImage(MapEditorObjectData data) { }

	// RVA: 0x2A4BBF0 Offset: 0x2A4BCF1 VA: 0x2A4BBF0
	public void SetTextNum(MapEditorCategoryData category, int num, int numMax) { }

	// RVA: 0x2A4BD20 Offset: 0x2A4BE21 VA: 0x2A4BD20
	public void SetHighlight(MapEditorCategoryData category) { }

	// RVA: 0x2A4A290 Offset: 0x2A4A391 VA: 0x2A4A290
	public Sprite GetThumbSprite(string name) { }

	// RVA: 0x2A4A320 Offset: 0x2A4A421 VA: 0x2A4A320
	public Sprite GetCategorySprite(string name) { }

	// RVA: 0x2A4A460 Offset: 0x2A4A561 VA: 0x2A4A460
	public void OpenToOne() { }

	// RVA: 0x2A4BF10 Offset: 0x2A4C011 VA: 0x2A4BF10
	public void OpenToEveryone() { }

	// RVA: 0x2A4C060 Offset: 0x2A4C161 VA: 0x2A4C060
	public bool IsOpenToEveryone() { }

	// RVA: 0x2A4C140 Offset: 0x2A4C241 VA: 0x2A4C140
	public bool IsOpenToEveryoneEnd() { }

	// RVA: 0x2A4C2C0 Offset: 0x2A4C3C1 VA: 0x2A4C2C0
	public void .ctor() { }
}

