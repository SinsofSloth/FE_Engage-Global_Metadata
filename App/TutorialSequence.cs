// Namespace: App
public class TutorialSequence : SingletonProcInst<TutorialSequence> // TypeDefIndex: 11839
{
	// Fields
	private const string PrefabPath = "UI/Common/WdwTutorial/Prefabs/WdwTutorial";
	public static readonly string[] SpriteAtlasPaths; // 0x0
	private const string CapCommonName = "CAP_";
	private const string USCommonName = "";
	private const string EUCommonName = "_EU";
	private GameObject m_TutorialObject; // 0x78
	private SpriteAtlas m_MainSpriteAtlas; // 0x80
	private SpriteAtlas m_SubSpriteAtlas; // 0x88
	private WdwTutorialLocatorRoot m_LocatorRoot; // 0x90
	private List<TutorialData> m_TutorialData; // 0x98
	private string m_TutorialID; // 0xA0
	private const int FirstPage = 0;
	private int m_Page; // 0xA8
	private bool m_IsUpdate; // 0xAC
	private TResourceHandle<GameObject> m_PrefabHandle; // 0xB0
	private TResourceHandle<SpriteAtlas> m_MainHandle; // 0xB8
	private TResourceHandle<SpriteAtlas> m_SubHandle; // 0xC0
	private const string ClassChangeKey = "TUTID_クラスチェンジ";

	// Methods

	// RVA: 0x2884440 Offset: 0x2884541 VA: 0x2884440
	private void .ctor(string id) { }

	// RVA: 0x28845A0 Offset: 0x28846A1 VA: 0x28845A0
	private void LoadData() { }

	// RVA: 0x2884870 Offset: 0x2884971 VA: 0x2884870
	public static Language.Langs GetLanguage() { }

	// RVA: 0x2880EA0 Offset: 0x2880FA1 VA: 0x2880EA0
	public static string GetSpriteAtlasPath() { }

	// RVA: 0x2881A40 Offset: 0x2881B41 VA: 0x2881A40
	public static string GetImageName(SpriteAtlas spriteAtlas, int page) { }

	// RVA: 0x2884930 Offset: 0x2884A31 VA: 0x2884930
	private void UnloadData() { }

	// RVA: 0x2884AB0 Offset: 0x2884BB1 VA: 0x2884AB0
	private bool IsLoadData() { }

	// RVA: 0x2884B20 Offset: 0x2884C21 VA: 0x2884B20
	private void PrepareTutorial() { }

	// RVA: 0x2884C80 Offset: 0x2884D81 VA: 0x2884C80
	private void CheckTutorial() { }

	// RVA: 0x2884E10 Offset: 0x2884F11 VA: 0x2884E10
	private void Init() { }

	// RVA: 0x2885150 Offset: 0x2885251 VA: 0x2885150
	private void OpenWindow() { }

	// RVA: 0x28851E0 Offset: 0x28852E1 VA: 0x28851E0
	private void WaitOpenWindow() { }

	// RVA: 0x2885220 Offset: 0x2885321 VA: 0x2885220
	private void TutorialTick() { }

	// RVA: 0x2885A20 Offset: 0x2885B21 VA: 0x2885A20
	private bool IsCloseWindow() { }

	// RVA: 0x2885C80 Offset: 0x2885D81 VA: 0x2885C80
	private void CloseWindow() { }

	// RVA: 0x2885D10 Offset: 0x2885E11 VA: 0x2885D10
	private void WaitCloseWindow() { }

	// RVA: 0x28854F0 Offset: 0x28855F1 VA: 0x28854F0
	private void SetPage() { }

	// RVA: 0x28850E0 Offset: 0x28851E1 VA: 0x28850E0
	private void SetArrow() { }

	// RVA: 0x2885D50 Offset: 0x2885E51 VA: 0x2885D50
	public static void CreateBind(ProcInst super, string tid) { }

	// RVA: 0x28864C0 Offset: 0x28865C1 VA: 0x28864C0
	public static bool TryCreateBind(ProcInst super, string tid) { }

	// RVA: 0x2886750 Offset: 0x2886851 VA: 0x2886750
	public static bool IsClassChanged() { }

	// RVA: 0x28867B0 Offset: 0x28868B1 VA: 0x28867B0
	private static void .cctor() { }
}

