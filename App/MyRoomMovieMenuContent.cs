// Namespace: App
public class MyRoomMovieMenuContent : BasicMenuContent // TypeDefIndex: 11306
{
	// Fields
	private const string PrefabPath = "UI/Hub/MyRoom/Prefabs/MovieSelectRoot";
	private const string ThumbnailPath = "UI/Hub/MyRoom/MovieThumb/MovieThumb";
	private GameObject m_title; // 0xE8
	private GameObject m_help; // 0xF0
	private GameObject m_thumbnail; // 0xF8
	private Dictionary<string, Sprite> m_thumbnailCache; // 0x100

	// Methods

	// RVA: 0x282EFB0 Offset: 0x282F0B1 VA: 0x282EFB0
	public static void LoadPrefabAsync() { }

	// RVA: 0x282F090 Offset: 0x282F191 VA: 0x282F090
	public static bool IsLoadingPrefab() { }

	// RVA: 0x282F160 Offset: 0x282F261 VA: 0x282F160
	public static void UnloadPrefab() { }

	// RVA: 0x282E830 Offset: 0x282E931 VA: 0x282E830
	public static MyRoomMovieMenuContent Create() { }

	// RVA: 0x282F200 Offset: 0x282F301 VA: 0x282F200
	public static void Destroy(MyRoomMovieMenuContent menuContent) { }

	// RVA: 0x282F280 Offset: 0x282F381 VA: 0x282F280 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x282F370 Offset: 0x282F471 VA: 0x282F370 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x282F380 Offset: 0x282F481 VA: 0x282F380 Slot: 21
	public override float CalcW() { }

	// RVA: 0x282F3F0 Offset: 0x282F4F1 VA: 0x282F3F0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x282EBB0 Offset: 0x282ECB1 VA: 0x282EBB0
	public void SetTitle(string title) { }

	// RVA: 0x282ED70 Offset: 0x282EE71 VA: 0x282ED70
	public void SetHelp(string help) { }

	// RVA: 0x282EF30 Offset: 0x282F031 VA: 0x282EF30
	public void SetThumbnail(string thumbnail) { }

	// RVA: 0x282F460 Offset: 0x282F561 VA: 0x282F460
	private Sprite Get(string thumbnail) { }

	// RVA: 0x282F770 Offset: 0x282F871 VA: 0x282F770 Slot: 30
	protected override void Awake() { }

	// RVA: 0x282F910 Offset: 0x282FA11 VA: 0x282F910 Slot: 33
	protected override void OnDestroy() { }

	// RVA: 0x282FAB0 Offset: 0x282FBB1 VA: 0x282FAB0
	public void .ctor() { }
}

