// Namespace: UnityEngine.Experimental.Rendering.Universal
[ExecuteInEditMode] // RVA: 0x480420 Offset: 0x480521 VA: 0x480420
[DisallowMultipleComponent] // RVA: 0x480420 Offset: 0x480521 VA: 0x480420
[AddComponentMenu] // RVA: 0x480420 Offset: 0x480521 VA: 0x480420
public class ShadowCaster2D : ShadowCasterGroup2D // TypeDefIndex: 5492
{
	// Fields
	[SerializeField] // RVA: 0x484310 Offset: 0x484411 VA: 0x484310
	private bool m_HasRenderer; // 0x28
	[SerializeField] // RVA: 0x484320 Offset: 0x484421 VA: 0x484320
	private bool m_UseRendererSilhouette; // 0x29
	[SerializeField] // RVA: 0x484330 Offset: 0x484431 VA: 0x484330
	private bool m_CastsShadows; // 0x2A
	[SerializeField] // RVA: 0x484340 Offset: 0x484441 VA: 0x484340
	private bool m_SelfShadows; // 0x2B
	[SerializeField] // RVA: 0x484350 Offset: 0x484451 VA: 0x484350
	private int[] m_ApplyToSortingLayers; // 0x30
	[SerializeField] // RVA: 0x484360 Offset: 0x484461 VA: 0x484360
	private Vector3[] m_ShapePath; // 0x38
	[SerializeField] // RVA: 0x484370 Offset: 0x484471 VA: 0x484370
	private int m_ShapePathHash; // 0x40
	[SerializeField] // RVA: 0x484380 Offset: 0x484481 VA: 0x484380
	private Mesh m_Mesh; // 0x48
	[SerializeField] // RVA: 0x484390 Offset: 0x484491 VA: 0x484390
	private int m_InstanceId; // 0x50
	internal ShadowCasterGroup2D m_ShadowCasterGroup; // 0x58
	internal ShadowCasterGroup2D m_PreviousShadowCasterGroup; // 0x60
	private int m_PreviousShadowGroup; // 0x68
	private bool m_PreviousCastsShadows; // 0x6C
	private int m_PreviousPathHash; // 0x70

	// Properties
	internal Mesh mesh { get; }
	internal Vector3[] shapePath { get; }
	internal int shapePathHash { get; set; }
	public bool useRendererSilhouette { get; set; }
	public bool selfShadows { get; set; }
	public bool castsShadows { get; set; }

	// Methods

	// RVA: 0x3130460 Offset: 0x3130561 VA: 0x3130460
	internal Mesh get_mesh() { }

	// RVA: 0x3130470 Offset: 0x3130571 VA: 0x3130470
	internal Vector3[] get_shapePath() { }

	// RVA: 0x3130480 Offset: 0x3130581 VA: 0x3130480
	internal int get_shapePathHash() { }

	// RVA: 0x3130490 Offset: 0x3130591 VA: 0x3130490
	internal void set_shapePathHash(int value) { }

	// RVA: 0x31304A0 Offset: 0x31305A1 VA: 0x31304A0
	public void set_useRendererSilhouette(bool value) { }

	// RVA: 0x31304B0 Offset: 0x31305B1 VA: 0x31304B0
	public bool get_useRendererSilhouette() { }

	// RVA: 0x31304D0 Offset: 0x31305D1 VA: 0x31304D0
	public void set_selfShadows(bool value) { }

	// RVA: 0x31304E0 Offset: 0x31305E1 VA: 0x31304E0
	public bool get_selfShadows() { }

	// RVA: 0x31304F0 Offset: 0x31305F1 VA: 0x31304F0
	public void set_castsShadows(bool value) { }

	// RVA: 0x3130500 Offset: 0x3130601 VA: 0x3130500
	public bool get_castsShadows() { }

	// RVA: 0x3130510 Offset: 0x3130611 VA: 0x3130510
	private static int[] SetDefaultSortingLayers() { }

	// RVA: 0x31305E0 Offset: 0x31306E1 VA: 0x31305E0
	internal bool IsShadowedLayer(int layer) { }

	// RVA: 0x3130650 Offset: 0x3130751 VA: 0x3130650
	private void Awake() { }

	// RVA: 0x3130990 Offset: 0x3130A91 VA: 0x3130990
	protected void OnEnable() { }

	// RVA: 0x3131470 Offset: 0x3131571 VA: 0x3131470
	protected void OnDisable() { }

	// RVA: 0x3131650 Offset: 0x3131751 VA: 0x3131650
	public void Update() { }

	// RVA: 0x3131E70 Offset: 0x3131F71 VA: 0x3131E70
	public void .ctor() { }
}

