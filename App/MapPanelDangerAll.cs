// Namespace: App
public class MapPanelDangerAll : MapPanelBase<MapPanelDangerAll> // TypeDefIndex: 9056
{
	// Fields
	[HeaderAttribute] // RVA: 0x2868C0 Offset: 0x2869C1 VA: 0x2868C0
	[SpaceAttribute] // RVA: 0x2868C0 Offset: 0x2869C1 VA: 0x2868C0
	[SerializeField] // RVA: 0x2868C0 Offset: 0x2869C1 VA: 0x2868C0
	private Material m_AttackMaterial; // 0x40
	[SerializeField] // RVA: 0x286920 Offset: 0x286A21 VA: 0x286920
	private Material m_RodMaterial; // 0x48
	[SerializeField] // RVA: 0x286930 Offset: 0x286A31 VA: 0x286930
	private Material m_GunnerMaterial; // 0x50
	[SerializeField] // RVA: 0x286940 Offset: 0x286A41 VA: 0x286940
	private Material m_FrameForGunnerMaterial; // 0x58
	private GameConfig.AllInfo m_Mode; // 0x60
	private GameConfig.AllInfo m_OldMode; // 0x64
	private bool m_IsUpdate; // 0x68
	private bool m_IsVisible; // 0x69
	private InterpolatorFloat m_Alpha; // 0x70
	private Material[] m_MiniMapFillMaterials; // 0x78
	private Material[] m_MiniMapFrameMaterials; // 0x80
	[SpaceAttribute] // RVA: 0x286950 Offset: 0x286A51 VA: 0x286950
	[HeaderAttribute] // RVA: 0x286950 Offset: 0x286A51 VA: 0x286950
	[SerializeField] // RVA: 0x286950 Offset: 0x286A51 VA: 0x286950
	private Color m_AttackColor; // 0x88
	[SerializeField] // RVA: 0x2869B0 Offset: 0x286AB1 VA: 0x2869B0
	private Color m_RodColor; // 0x98
	[SerializeField] // RVA: 0x2869C0 Offset: 0x286AC1 VA: 0x2869C0
	private Color m_GunnerColor; // 0xA8

	// Properties
	public override int SubMeshCount { get; }
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x221DB10 Offset: 0x221DC11 VA: 0x221DB10 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x221DB20 Offset: 0x221DC21 VA: 0x221DB20
	private void Start() { }

	// RVA: 0x221DD70 Offset: 0x221DE71 VA: 0x221DD70
	private void Update() { }

	// RVA: 0x221E080 Offset: 0x221E181 VA: 0x221E080
	private void OnValidate() { }

	// RVA: 0x221E0E0 Offset: 0x221E1E1 VA: 0x221E0E0 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x221E240 Offset: 0x221E341 VA: 0x221E240
	public Material[] GetSourceMaterialsForMiniMapFill() { }

	// RVA: 0x221E2F0 Offset: 0x221E3F1 VA: 0x221E2F0
	public Material[] GetSourceMaterialsForMiniMapFrame() { }

	// RVA: 0x221E3A0 Offset: 0x221E4A1 VA: 0x221E3A0
	public GameConfig.AllInfo GetMode() { }

	// RVA: 0x221E3B0 Offset: 0x221E4B1 VA: 0x221E3B0
	public void SetMode(GameConfig.AllInfo mode, bool isForceUpdate = False) { }

	// RVA: 0x221DF30 Offset: 0x221E031 VA: 0x221DF30
	private void UpdateMode(GameConfig.AllInfo mode) { }

	// RVA: 0x221DE00 Offset: 0x221DF01 VA: 0x221DE00
	private void UpdateVisible() { }

	// RVA: 0x221E030 Offset: 0x221E131 VA: 0x221E030
	private void UpdatePanelAlpha() { }

	// RVA: 0x221E3E0 Offset: 0x221E4E1 VA: 0x221E3E0
	private void SetPanelAlpha(int index) { }

	// RVA: 0x221E020 Offset: 0x221E121 VA: 0x221E020
	private void UpdateVertex(GameConfig.AllInfo mode) { }

	// RVA: 0x221E4C0 Offset: 0x221E5C1 VA: 0x221E4C0
	private void SetVertex() { }

	// RVA: 0x221E820 Offset: 0x221E921 VA: 0x221E820
	private void SetMesh(MapPanelDangerAll.MeshIndex index, Color color, MapPanelDangerAll.DangerType type, MapPanelBase.ImageGetFunction<MapPanelDangerAll> func) { }

	// RVA: 0x221EC70 Offset: 0x221ED71 VA: 0x221EC70
	private void SetMeshForGunner(MapPanelDangerAll.MeshIndex index, Color color, bool isImageFilled, MapPanelBase.ImageGetFunction<MapPanelDangerAll> gunner, MapPanelBase.ImageGetFunction<MapPanelDangerAll> attack, MapPanelBase.ImageGetFunction<MapPanelDangerAll> rod) { }

	// RVA: 0x221F160 Offset: 0x221F261 VA: 0x221F160
	public bool get_IsVisible() { }

	// RVA: 0x221F170 Offset: 0x221F271 VA: 0x221F170
	public void .ctor() { }
}

