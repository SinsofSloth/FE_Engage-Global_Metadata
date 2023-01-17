// Namespace: App
public class MiniMapController : MonoBehaviour // TypeDefIndex: 12352
{
	// Fields
	public float m_GridSize; // 0x18
	public float m_OutLineSize; // 0x1C
	[SpaceAttribute] // RVA: 0x299D50 Offset: 0x299E51 VA: 0x299D50
	public GameObject m_ViewPort; // 0x20
	[SpaceAttribute] // RVA: 0x299D60 Offset: 0x299E61 VA: 0x299D60
	public GameObject m_Scroll; // 0x28
	[SpaceAttribute] // RVA: 0x299D70 Offset: 0x299E71 VA: 0x299D70
	public GameObject m_TerrainRoot; // 0x30
	[SpaceAttribute] // RVA: 0x299D80 Offset: 0x299E81 VA: 0x299D80
	public GameObject m_SightRoot; // 0x38
	[SpaceAttribute] // RVA: 0x299D90 Offset: 0x299E91 VA: 0x299D90
	public GameObject m_PanelDeployRoot; // 0x40
	[SpaceAttribute] // RVA: 0x299DA0 Offset: 0x299EA1 VA: 0x299DA0
	public GameObject m_PanelDangerRoot; // 0x48
	[SpaceAttribute] // RVA: 0x299DB0 Offset: 0x299EB1 VA: 0x299DB0
	public GameObject m_PanelDangerAllRoot; // 0x50
	[SpaceAttribute] // RVA: 0x299DC0 Offset: 0x299EC1 VA: 0x299DC0
	public GameObject m_FrameForPanelDangerAllRoot; // 0x58
	[SpaceAttribute] // RVA: 0x299DD0 Offset: 0x299ED1 VA: 0x299DD0
	public GameObject m_PanelRouteRoot; // 0x60
	[SpaceAttribute] // RVA: 0x299DE0 Offset: 0x299EE1 VA: 0x299DE0
	public GameObject m_UnitSymbolRoot; // 0x68
	public GameObject m_UnitIconRoot; // 0x70
	public Color m_ColorPlayer; // 0x78
	public Color m_ColorEnemy; // 0x88
	public Color m_ColorAlly; // 0x98
	public Color m_ColorEnemy2; // 0xA8
	[SpaceAttribute] // RVA: 0x299DF0 Offset: 0x299EF1 VA: 0x299DF0
	public GameObject m_EventSymbolRoot; // 0xB8
	[SpaceAttribute] // RVA: 0x299E00 Offset: 0x299F01 VA: 0x299E00
	public GameObject m_CursorRoot; // 0xC0
	[SpaceAttribute] // RVA: 0x299E10 Offset: 0x299F11 VA: 0x299E10
	[RangeAttribute] // RVA: 0x299E10 Offset: 0x299F11 VA: 0x299E10
	public float m_Scale; // 0xC8
	public float m_PanelDeployScale; // 0xCC
	[SpaceAttribute] // RVA: 0x299E50 Offset: 0x299F51 VA: 0x299E50
	public Vector3 m_LargeModePosition; // 0xD0
	public Vector2 m_LargeModeSize; // 0xDC
	public float m_LargeModeScale; // 0xE4
	public MiniMapController.Alignment m_LargeModeAlignment; // 0xE8
	private float m_LargeModeScaleOld; // 0xEC
	[SpaceAttribute] // RVA: 0x299E60 Offset: 0x299F61 VA: 0x299E60
	public Vector3 m_SmallModePosition; // 0xF0
	public Vector2 m_SmallModeSize; // 0xFC
	public float m_SmallModeScale; // 0x104
	public MiniMapController.Alignment m_SmallModeAlignment; // 0x108
	[SpaceAttribute] // RVA: 0x299E70 Offset: 0x299F71 VA: 0x299E70
	public Vector3 m_MenuModePosition; // 0x10C
	public Vector2 m_MenuModeSize; // 0x118
	public float m_MenuModeScale; // 0x120
	public MiniMapController.Alignment m_MenuModeAlignment; // 0x124
	private MiniMapController.DisplayPosSize m_DisplayPosSize; // 0x128
	[SpaceAttribute] // RVA: 0x299E80 Offset: 0x299F81 VA: 0x299E80
	public bool m_InterpolateZoom; // 0x12C
	[SpaceAttribute] // RVA: 0x299E90 Offset: 0x299F91 VA: 0x299E90
	[MinAttribute] // RVA: 0x299E90 Offset: 0x299F91 VA: 0x299E90
	public float m_MiniMapAlphaChangeTime; // 0x130
	[SpaceAttribute] // RVA: 0x299EE0 Offset: 0x299FE1 VA: 0x299EE0
	[RangeAttribute] // RVA: 0x299EE0 Offset: 0x299FE1 VA: 0x299EE0
	public float m_MiniMapAlphaMax; // 0x134
	[SpaceAttribute] // RVA: 0x299F20 Offset: 0x29A021 VA: 0x299F20
	public SpriteAtlas m_SpriteAtlas; // 0x138
	[SpaceAttribute] // RVA: 0x299F30 Offset: 0x29A031 VA: 0x299F30
	public float m_InterpolateTime; // 0x140
	private float m_OldScale; // 0x144
	private List<MiniMapController.TImage<Image>> m_UnitSymbolList; // 0x148
	private List<MiniMapController.TImage<Image>> m_EventSymbolList; // 0x150
	private List<MiniMapController.TImage<UnitIcon>> m_UnitIconList; // 0x158
	private float m_ZoomScaleMax; // 0x160
	private float m_ZoomScaleMin; // 0x164
	private InterpolatorVector3 m_TargetPosition; // 0x168
	private Vector3 m_Offset; // 0x170
	private MiniMapController.Alignment m_Alignment; // 0x17C
	private static readonly string[] IconNames; // 0x0
	private Sprite[] m_Sprites; // 0x180
	private MiniMapController.Mode m_Mode; // 0x188
	private bool m_ModeDirty; // 0x18C
	private int m_ModeChangeDelay; // 0x190
	private CanvasGroup m_CanvasGroup; // 0x198
	private float m_MiniMapAlpha; // 0x1A0
	private GameConfig.MinimapType m_MinimapType; // 0x1A4
	private int m_TerrainHashCode; // 0x1A8
	private MiniMapController.FadeMode m_AlphaFadeMode; // 0x1AC
	private RectTransform m_minimaplRT; // 0x1B0
	private RectTransform m_scrollRT; // 0x1B8
	private RectTransform m_terrainRT; // 0x1C0
	private RectTransform m_sightRT; // 0x1C8
	private RectTransform m_panelDeployRT; // 0x1D0
	private RectTransform m_panelDangerRT; // 0x1D8
	private RectTransform m_panelDangerAllRT; // 0x1E0
	private RectTransform m_frameForDangerAllRT; // 0x1E8
	private RectTransform m_panelRouteRT; // 0x1F0
	private MiniMapCursor m_cursor; // 0x1F8
	private MiniMapPanelDeployRenderer m_deployRenderer; // 0x200
	private MiniMapPanelDangerRenderer m_dangerRenderer; // 0x208
	private MiniMapPanelDangerAllRenderer m_dangerAllRenderer; // 0x210
	private MiniMapPanelFrameForDangerAllRenderer m_frameForDangerAllRenderer; // 0x218
	private MiniMapPanelRouteRenderer m_routeRenderer; // 0x220
	private MiniMapTerrainRenderer m_terrainRenderer; // 0x228
	private MiniMapSightRenderer m_sightRenderer; // 0x230

	// Methods

	// RVA: 0x226CD90 Offset: 0x226CE91 VA: 0x226CD90
	private void TryGetComponent() { }

	// RVA: 0x226D0F0 Offset: 0x226D1F1 VA: 0x226D0F0
	private void Start() { }

	// RVA: 0x226D6D0 Offset: 0x226D7D1 VA: 0x226D6D0
	private void Update() { }

	// RVA: 0x226E8D0 Offset: 0x226E9D1 VA: 0x226E8D0
	private void LateUpdate() { }

	// RVA: 0x226E680 Offset: 0x226E781 VA: 0x226E680
	private void UpdateCore() { }

	// RVA: 0x226F280 Offset: 0x226F381 VA: 0x226F280
	private void UpdateTerrain() { }

	// RVA: 0x226D320 Offset: 0x226D421 VA: 0x226D320
	private void UpdateSymbolAndIconList() { }

	// RVA: 0x226F410 Offset: 0x226F511 VA: 0x226F410
	public void UpdateUnitIcons() { }

	// RVA: 0x2272FA0 Offset: 0x22730A1 VA: 0x2272FA0
	private void UpdateEventSymbols() { }

	// RVA: 0x2273C50 Offset: 0x2273D51 VA: 0x2273C50
	public void Initialize() { }

	// RVA: 0x22742B0 Offset: 0x22743B1 VA: 0x22742B0
	private bool UpdateAlpha() { }

	// RVA: 0x226DEC0 Offset: 0x226DFC1 VA: 0x226DEC0
	private void ChangeDisplayModeByGameConfig() { }

	// RVA: 0x226D650 Offset: 0x226D751 VA: 0x226D650
	private MapImage GetMapImage() { }

	// RVA: 0x226D8C0 Offset: 0x226D9C1 VA: 0x226D8C0
	private void ChangeMode() { }

	// RVA: 0x22743F0 Offset: 0x22744F1 VA: 0x22743F0
	private void ChangeDisplayPosSize(MiniMapController.DisplayPosSize displayPosSize) { }

	// RVA: 0x2274580 Offset: 0x2274681 VA: 0x2274580
	public void ChangeMode(MiniMapController.Mode mode) { }

	// RVA: 0x22745A0 Offset: 0x22746A1 VA: 0x22745A0
	public void SetDirty() { }

	// RVA: 0x226EE60 Offset: 0x226EF61 VA: 0x226EE60
	private void CalcOffset(MiniMapController.Alignment alignment, float scale) { }

	// RVA: 0x22745B0 Offset: 0x22746B1 VA: 0x22745B0
	public void Show() { }

	// RVA: 0x22745C0 Offset: 0x22746C1 VA: 0x22745C0
	public void Hide() { }

	// RVA: 0x226F1B0 Offset: 0x226F2B1 VA: 0x226F1B0
	public void Zoom(float zoom) { }

	// RVA: 0x22745D0 Offset: 0x22746D1 VA: 0x22745D0
	public void .ctor() { }

	// RVA: 0x2274780 Offset: 0x2274881 VA: 0x2274780
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C81A0 Offset: 0x2C82A1 VA: 0x2C81A0
	// RVA: 0x22739F0 Offset: 0x2273AF1 VA: 0x22739F0
	internal static void <UpdateEventSymbols>g__SetEventSymbol|90_0(List<MiniMapController.TImage<Image>> eventSymbolList, ref int symbolIndex, GameObject eventSymbolRoot, int x, int z, Sprite sprite, float calculatedGridSize, Vector3 symbolScale) { }
}

