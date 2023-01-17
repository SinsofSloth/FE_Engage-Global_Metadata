// Namespace: App
public class SaveDataMenu : BasicMenu // TypeDefIndex: 12659
{
	// Fields
	private const string LayoutPrefabPath = "UI/Title/FileMenu/Prefabs/FileSelectRoot";
	private const string IconSpriteAtlasPath = "UI/Title/FileMenu/Textures/FileMenu";
	private static bool s_IsSaveDataAccessSuccess; // 0x0
	private static SpriteAtlasManager s_IconSpriteAtlasManager; // 0x8
	private GameObject m_Prefab; // 0xC8
	private SaveDataMenuSequence m_MenuSequence; // 0xD0
	private GameSaveDataHeaderReader m_SaveDataHeaderReader; // 0xD8
	private SaveDataMenu.Mode m_Mode; // 0xE0
	private SaveDataMenu.Sequence m_Sequence; // 0xE4
	private GameSaveDataHeaderReader.Handle m_SrcSaveDataHeaderHandle; // 0xE8
	private GameSaveDataHeaderReader.Handle m_DestSaveDataHeaderHandle; // 0xF0
	private int m_Select1stItemIndex; // 0xF8

	// Methods

	// RVA: 0x2060C50 Offset: 0x2060D51 VA: 0x2060C50 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x2060C60 Offset: 0x2060D61 VA: 0x2060C60
	public bool IsSaveFromPeriod() { }

	// RVA: 0x2060C80 Offset: 0x2060D81 VA: 0x2060C80
	private static string GetTitleMess(SaveDataMenu.Mode mode) { }

	// RVA: 0x2060D70 Offset: 0x2060E71 VA: 0x2060D70
	private static string GetHelpMess(SaveDataMenu.Mode mode, SaveDataMenu.Sequence sequence) { }

	// RVA: 0x2060EC0 Offset: 0x2060FC1 VA: 0x2060EC0
	private static string GetKeyHelpId(SaveDataMenu.Mode mode) { }

	// RVA: 0x2060F30 Offset: 0x2061031 VA: 0x2060F30
	private void .ctor(List<BasicMenuItem> menuIltemList, BasicMenuContent basicMenuContent, GameObject prefab, SaveDataMenuSequence menuSequence, SaveDataMenu.Mode mode, GameSaveDataHeaderReader saveDataHeaderReader) { }

	// RVA: 0x2061160 Offset: 0x2061261 VA: 0x2061160 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2061170 Offset: 0x2061271 VA: 0x2061170 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2061250 Offset: 0x2061351 VA: 0x2061250 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2061330 Offset: 0x2061431 VA: 0x2061330
	private void SaveDataLoadSetting(GameSaveData.Types type, int index) { }

	// RVA: 0x2061490 Offset: 0x2061591 VA: 0x2061490
	private void SaveCallback(bool isSuccess, GameSaveDataHeader saveDataHeader) { }

	// RVA: 0x20615D0 Offset: 0x20616D1 VA: 0x20615D0
	private void CopyCallback(bool isSuccess, GameSaveDataHeader saveDataHeader) { }

	// RVA: 0x2061700 Offset: 0x2061801 VA: 0x2061700
	private void DeleteCallback(bool isSuccess) { }

	// RVA: 0x2061810 Offset: 0x2061911 VA: 0x2061810
	public static void LoadPrfabAsync() { }

	// RVA: 0x20618B0 Offset: 0x20619B1 VA: 0x20618B0
	public static void UnloadPrfab() { }

	// RVA: 0x2061930 Offset: 0x2061A31 VA: 0x2061930
	public static bool IsLoadingPrfab() { }

	// RVA: 0x20619B0 Offset: 0x2061AB1 VA: 0x20619B0
	public static void LoadIconAsync() { }

	// RVA: 0x2061A30 Offset: 0x2061B31 VA: 0x2061A30
	public static void UnloadIcon() { }

	// RVA: 0x2061AA0 Offset: 0x2061BA1 VA: 0x2061AA0
	public static bool IsLoadingIcon() { }

	// RVA: 0x2061B10 Offset: 0x2061C11 VA: 0x2061B10
	public static SpriteAtlasManager GetIconSpriteManager() { }

	// RVA: 0x2060FE0 Offset: 0x20610E1 VA: 0x2060FE0
	private void UpdateTitleBarText() { }

	// RVA: 0x2061B80 Offset: 0x2061C81 VA: 0x2061B80
	public static void CreateMenuBind(SaveDataMenuSequence super, SaveDataMenu.Mode mode, GameSaveDataHeaderReader reader) { }

	// RVA: 0x2061FA0 Offset: 0x20620A1 VA: 0x2061FA0
	public static bool IsSaveDataAccessSuccess() { }

	// RVA: 0x2062010 Offset: 0x2062111 VA: 0x2062010
	private static void .cctor() { }
}

