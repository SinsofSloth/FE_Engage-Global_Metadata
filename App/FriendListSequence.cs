// Namespace: App
public class FriendListSequence : SingletonProcInst<FriendListSequence> // TypeDefIndex: 13430
{
	// Fields
	private const string PrefabPath = "UI/Hub/Notebook/Prefabs/NotebookRoot";
	private const string StampAtlasPath = "UI/Hub/Notebook/Stamps/AllStamps";
	private const string CharaImageFolder = "UI/Hub/Notebook/Pictures/";
	private const string CharaImageFolderS = "Event/PuppetDemo/Textures/Pictures/";
	private const float m_OpenTime = 0.5;
	private const float m_PageChangeTime = 0.5;
	private GameObject m_FriendListObject; // 0x78
	private FriendListContent m_FriendListContent; // 0x80
	private CanvasGroup m_CanvasGroup; // 0x88
	private Animator m_RootAnimator; // 0x90
	private string[] m_CharaSpritePathArray; // 0x98
	private Sprite[] m_CharaSpriteArray; // 0xA0
	private int m_ActiveCharaSpriteIndex; // 0xA8
	private string m_CharaSpritePathS; // 0xB0
	private Texture2D m_CharaTextureS; // 0xB8
	private const int FirstPage = 0;
	private int m_Page; // 0xC0
	private int m_NextPage; // 0xC4
	private List<FriendListData> m_FriendListDataArray; // 0xC8
	private SpriteAtlasManager m_StampAtlasManager; // 0xD0

	// Methods

	// RVA: 0x269A2F0 Offset: 0x269A3F1 VA: 0x269A2F0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x269A980 Offset: 0x269AA81 VA: 0x269A980 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x269AC20 Offset: 0x269AD21 VA: 0x269AC20
	private bool IsLoadingPrefab() { }

	// RVA: 0x269AD60 Offset: 0x269AE61 VA: 0x269AD60
	private bool IsLoadingSprite() { }

	// RVA: 0x269AE50 Offset: 0x269AF51 VA: 0x269AE50
	private void Initialize() { }

	// RVA: 0x269B0A0 Offset: 0x269B1A1 VA: 0x269B0A0
	private void WaitFriendListContent() { }

	// RVA: 0x269B280 Offset: 0x269B381 VA: 0x269B280
	private void TickOpen() { }

	// RVA: 0x269B320 Offset: 0x269B421 VA: 0x269B320
	private int GetNextPage(int nowPage) { }

	// RVA: 0x269B380 Offset: 0x269B481 VA: 0x269B380
	private int GetPrevPage(int nowPage) { }

	// RVA: 0x269B3E0 Offset: 0x269B4E1 VA: 0x269B3E0
	private void TickMain() { }

	// RVA: 0x269CDC0 Offset: 0x269CEC1 VA: 0x269CDC0
	private void PreparePageChange() { }

	// RVA: 0x269D080 Offset: 0x269D181 VA: 0x269D080
	private void StartPageChange() { }

	// RVA: 0x269D270 Offset: 0x269D371 VA: 0x269D270
	private void TickPageChange() { }

	// RVA: 0x269D290 Offset: 0x269D391 VA: 0x269D290
	private void ListCancel() { }

	// RVA: 0x269D3E0 Offset: 0x269D4E1 VA: 0x269D3E0
	private void WaitClose() { }

	// RVA: 0x269D440 Offset: 0x269D541 VA: 0x269D440
	public static void CreateBind(ProcInst parent) { }

	// RVA: 0x269E0B0 Offset: 0x269E1B1 VA: 0x269E0B0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB9C0 Offset: 0x2CBAC1 VA: 0x2CB9C0
	// RVA: 0x269E1C0 Offset: 0x269E2C1 VA: 0x269E1C0
	private void <TickMain>b__31_0(string pid) { }
}

