// Namespace: App
public class PhotographSelectAreaMenuContent : BasicMenuContent // TypeDefIndex: 11495
{
	// Fields
	private static readonly string s_MenuPrefabPath; // 0x0
	private static readonly string s_AreaSpriteAtlasPath; // 0x8
	[SerializeField] // RVA: 0x2987D0 Offset: 0x2988D1 VA: 0x2987D0
	private Image m_AreaImage; // 0xE8
	[SerializeField] // RVA: 0x2987E0 Offset: 0x2988E1 VA: 0x2987E0
	private TextMeshProUGUI m_SpotCount; // 0xF0
	private SpriteAtlas m_AreaSpriteAtlas; // 0xF8
	private Sprite m_AreaSprite; // 0x100

	// Methods

	// RVA: 0x2A336E0 Offset: 0x2A337E1 VA: 0x2A336E0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2A33820 Offset: 0x2A33921 VA: 0x2A33820 Slot: 30
	protected override void Awake() { }

	// RVA: 0x2A33900 Offset: 0x2A33A01 VA: 0x2A33900
	public void SetAreaData(PhotographSpotData areaData) { }

	// RVA: 0x2A33A50 Offset: 0x2A33B51 VA: 0x2A33A50 Slot: 33
	protected override void OnDestroy() { }

	// RVA: 0x2A33AD0 Offset: 0x2A33BD1 VA: 0x2A33AD0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2A33B40 Offset: 0x2A33C41 VA: 0x2A33B40 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2A33BB0 Offset: 0x2A33CB1 VA: 0x2A33BB0 Slot: 9
	protected override float CalcCursorMovedPosX(int idx) { }

	// RVA: 0x2A33C50 Offset: 0x2A33D51 VA: 0x2A33C50 Slot: 10
	protected override float CalcCursorMovedPosY(int idx) { }

	// RVA: 0x2A33CF0 Offset: 0x2A33DF1 VA: 0x2A33CF0
	public static void LoadResource() { }

	// RVA: 0x2A33FF0 Offset: 0x2A340F1 VA: 0x2A33FF0
	public static bool IsLoadingResource() { }

	// RVA: 0x2A34100 Offset: 0x2A34201 VA: 0x2A34100
	public static void UnloadResource() { }

	// RVA: 0x2A341C0 Offset: 0x2A342C1 VA: 0x2A341C0
	public void .ctor() { }

	// RVA: 0x2A34230 Offset: 0x2A34331 VA: 0x2A34230
	private static void .cctor() { }
}

