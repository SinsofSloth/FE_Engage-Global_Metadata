// Namespace: App
public class MapPanelDanger : MapPanelBase<MapPanelDanger> // TypeDefIndex: 9053
{
	// Fields
	private List<MapPanelDanger.MeshIndex>[] m_ImageList; // 0x40
	[SpaceAttribute] // RVA: 0x2866E0 Offset: 0x2867E1 VA: 0x2866E0
	[SpaceAttribute] // RVA: 0x2866E0 Offset: 0x2867E1 VA: 0x2866E0
	[SerializeField] // RVA: 0x2866E0 Offset: 0x2867E1 VA: 0x2866E0
	[HeaderAttribute] // RVA: 0x2866E0 Offset: 0x2867E1 VA: 0x2866E0
	private Material m_AttackDanger_0; // 0x48
	[SerializeField] // RVA: 0x286750 Offset: 0x286851 VA: 0x286750
	private Material m_AttackDanger_1; // 0x50
	[SerializeField] // RVA: 0x286760 Offset: 0x286861 VA: 0x286760
	private Material m_AttackDanger_2; // 0x58
	[SerializeField] // RVA: 0x286770 Offset: 0x286871 VA: 0x286770
	private Material m_AttackDanger_3; // 0x60
	[SerializeField] // RVA: 0x286780 Offset: 0x286881 VA: 0x286780
	[SpaceAttribute] // RVA: 0x286780 Offset: 0x286881 VA: 0x286780
	private Material m_RodDanger_0; // 0x68
	[SerializeField] // RVA: 0x2867C0 Offset: 0x2868C1 VA: 0x2867C0
	private Material m_RodDanger_1; // 0x70
	[SerializeField] // RVA: 0x2867D0 Offset: 0x2868D1 VA: 0x2867D0
	private Material m_RodDanger_2; // 0x78
	[SerializeField] // RVA: 0x2867E0 Offset: 0x2868E1 VA: 0x2867E0
	private Material m_RodDanger_3; // 0x80
	private MapPanelDanger.Mode m_Mode; // 0x88
	private bool m_IsUpdate; // 0x8C
	private InterpolatorFloat m_Alpha; // 0x90
	[SpaceAttribute] // RVA: 0x2867F0 Offset: 0x2868F1 VA: 0x2867F0
	[SerializeField] // RVA: 0x2867F0 Offset: 0x2868F1 VA: 0x2867F0
	[HeaderAttribute] // RVA: 0x2867F0 Offset: 0x2868F1 VA: 0x2867F0
	private Color m_AttackColor; // 0x98
	[SerializeField] // RVA: 0x286850 Offset: 0x286951 VA: 0x286850
	private Color m_RodColor; // 0xA8
	[SpaceAttribute] // RVA: 0x286860 Offset: 0x286961 VA: 0x286860
	[HeaderAttribute] // RVA: 0x286860 Offset: 0x286961 VA: 0x286860
	[SerializeField] // RVA: 0x286860 Offset: 0x286961 VA: 0x286860
	private AnimationCurve m_SwitchCurve; // 0xB8
	private float m_Time; // 0xC0
	public bool m_IsLoopAnime; // 0xC4
	private bool m_IsVisible; // 0xC5

	// Properties
	public override int SubMeshCount { get; }

	// Methods

	// RVA: 0x221BE40 Offset: 0x221BF41 VA: 0x221BE40 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x221BE50 Offset: 0x221BF51 VA: 0x221BE50
	private void Start() { }

	// RVA: 0x221BF90 Offset: 0x221C091 VA: 0x221BF90
	private void Update() { }

	// RVA: 0x221C2E0 Offset: 0x221C3E1 VA: 0x221C2E0
	private void OnValidate() { }

	// RVA: 0x221C350 Offset: 0x221C451 VA: 0x221C350 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x221C590 Offset: 0x221C691 VA: 0x221C590
	public void SetMode(MapPanelDanger.Mode mode, bool isForceUpdate = False) { }

	// RVA: 0x221C080 Offset: 0x221C181 VA: 0x221C080
	private void UpdateVisible() { }

	// RVA: 0x221C190 Offset: 0x221C291 VA: 0x221C190
	private void UpdateMode(MapPanelDanger.Mode mode) { }

	// RVA: 0x221C280 Offset: 0x221C381 VA: 0x221C280
	private void UpdateVertex(MapPanelDanger.Mode mode) { }

	// RVA: 0x221C290 Offset: 0x221C391 VA: 0x221C290
	private void UpdatePanelAlpha() { }

	// RVA: 0x221C950 Offset: 0x221CA51 VA: 0x221C950
	private void InitPanelAlpha() { }

	// RVA: 0x221CA50 Offset: 0x221CB51 VA: 0x221CA50
	private void SetPanelAlpha(MapPanelDanger.DangerType type, int firstIndex, int lastIndex) { }

	// RVA: 0x221C5C0 Offset: 0x221C6C1 VA: 0x221C5C0
	private void SetVertex() { }

	// RVA: 0x221CCA0 Offset: 0x221CDA1 VA: 0x221CCA0
	private void SetMesh(MapPanelDanger.MeshIndex index, Color color, MapPanelDanger.DangerType type, MapPanelBase.ImageGetFunction<MapPanelDanger> func) { }

	// RVA: 0x221D2B0 Offset: 0x221D3B1 VA: 0x221D2B0
	private void SetMesh(MapPanelDanger.MeshIndex index, Color color, MapPanelDanger.DangerType type, List<MapImageCoreBit> list) { }

	// RVA: 0x221D1C0 Offset: 0x221D2C1 VA: 0x221D1C0
	private void AddVertex(int x, int z, uint mask, Color density) { }

	// RVA: 0x221DA00 Offset: 0x221DB01 VA: 0x221DA00
	public void .ctor() { }
}

