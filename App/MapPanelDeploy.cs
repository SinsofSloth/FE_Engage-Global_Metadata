// Namespace: App
public class MapPanelDeploy : MapPanelBase<MapPanelDeploy> // TypeDefIndex: 9061
{
	// Fields
	private List<MapPanelDeploy.MeshIndex> m_MeshList; // 0x40
	[SpaceAttribute] // RVA: 0x2869D0 Offset: 0x286AD1 VA: 0x2869D0
	[HeaderAttribute] // RVA: 0x2869D0 Offset: 0x286AD1 VA: 0x2869D0
	public Material m_MoveImage; // 0x48
	public Material m_AttackImage; // 0x50
	public Material m_HealImage; // 0x58
	public Material m_SupportImage; // 0x60
	public Material m_InterferenceImage; // 0x68
	private MapPanelDeploy.Mode m_Mode; // 0x70
	private bool m_IsUpdate; // 0x74
	private MapImageCoreBit m_TempImage; // 0x78
	private InterpolatorFloat m_Scale; // 0x80
	private InterpolatorFloat m_Alpha; // 0x88
	private InterpolatorFloat m_Range; // 0x90
	[SpaceAttribute] // RVA: 0x286A20 Offset: 0x286B21 VA: 0x286A20
	[HeaderAttribute] // RVA: 0x286A20 Offset: 0x286B21 VA: 0x286A20
	public Color m_MoveColor; // 0x98
	public Color m_AttackColor; // 0xA8
	public Color m_HealColor; // 0xB8
	public Color m_SupportColor; // 0xC8
	public Color m_InterferenceColor; // 0xD8
	public AnimationCurve m_AlphaCurve; // 0xE8
	public bool m_IsIntegration; // 0xF0
	private MapImageCoreBit m_IntegrationImage; // 0xF8
	private float m_Time; // 0x100

	// Properties
	public override int SubMeshCount { get; }
	public bool IsIntegration { get; }

	// Methods

	// RVA: 0x2780130 Offset: 0x2780231 VA: 0x2780130 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x2780140 Offset: 0x2780241 VA: 0x2780140 Slot: 4
	protected override void Awake() { }

	// RVA: 0x27801F0 Offset: 0x27802F1 VA: 0x27801F0
	private void Update() { }

	// RVA: 0x2780DE0 Offset: 0x2780EE1 VA: 0x2780DE0
	public void SetMode(MapPanelDeploy.Mode mode, bool isForceUpdate = False) { }

	// RVA: 0x27806E0 Offset: 0x27807E1 VA: 0x27806E0
	private void UpdateMode(MapPanelDeploy.Mode mode) { }

	// RVA: 0x27809F0 Offset: 0x2780AF1 VA: 0x27809F0
	private void UpdateVertex(MapPanelDeploy.Mode mode) { }

	// RVA: 0x2782350 Offset: 0x2782451 VA: 0x2782350 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x2780B30 Offset: 0x2780C31 VA: 0x2780B30
	private void UpdatePanelAlpha() { }

	// RVA: 0x2780A30 Offset: 0x2780B31 VA: 0x2780A30
	private void UpdateScale(float scale) { }

	// RVA: 0x2780AB0 Offset: 0x2780BB1 VA: 0x2780AB0
	private void UpdateRange(float range) { }

	// RVA: 0x27824E0 Offset: 0x27825E1 VA: 0x27824E0
	public MapPanelDeploy.Mode GetMode() { }

	// RVA: 0x27824F0 Offset: 0x27825F1 VA: 0x27824F0
	public void Reset() { }

	// RVA: 0x2782560 Offset: 0x2782661 VA: 0x2782560
	public void Instant() { }

	// RVA: 0x2780E10 Offset: 0x2780F11 VA: 0x2780E10
	private void SetVertexMoveAndAttack() { }

	// RVA: 0x27825A0 Offset: 0x27826A1 VA: 0x27825A0
	private void SetMesh(MapImageCoreBit image, MapPanelDeploy.MeshIndex index, Color color) { }

	// RVA: 0x2781BB0 Offset: 0x2781CB1 VA: 0x2781BB0
	private void SetVertexAttack() { }

	// RVA: 0x2781420 Offset: 0x2781521 VA: 0x2781420
	private void SetVertexWarp() { }

	// RVA: 0x2781850 Offset: 0x2781951 VA: 0x2781850
	private void SetVertexCreation() { }

	// RVA: 0x2782BA0 Offset: 0x2782CA1 VA: 0x2782BA0
	public bool get_IsIntegration() { }

	// RVA: 0x2782BB0 Offset: 0x2782CB1 VA: 0x2782BB0
	public void .ctor() { }
}

