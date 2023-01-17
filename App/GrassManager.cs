// Namespace: App
[ExecuteAlways] // RVA: 0x274DF0 Offset: 0x274EF1 VA: 0x274DF0
public abstract class GrassManager : MonoBehaviour // TypeDefIndex: 8994
{
	// Fields
	[SerializeField] // RVA: 0x285120 Offset: 0x285221 VA: 0x285120
	private GrassData m_grassData; // 0x18
	private List<Transform> m_referenceTransform; // 0x20
	private List<Material> m_grassMaterials; // 0x28
	private Texture m_grassTexture; // 0x30
	[SerializeField] // RVA: 0x285130 Offset: 0x285231 VA: 0x285130
	private bool m_enableCustomGroundTexture; // 0x38
	[SerializeField] // RVA: 0x285140 Offset: 0x285241 VA: 0x285140
	private List<Texture2D> m_groundTextures; // 0x40
	[RangeAttribute] // RVA: 0x285150 Offset: 0x285251 VA: 0x285150
	public float m_cutoff; // 0x48
	[SerializeField] // RVA: 0x285170 Offset: 0x285271 VA: 0x285170
	[HideInInspector] // RVA: 0x285170 Offset: 0x285271 VA: 0x285170
	public float m_drawDistance; // 0x4C
	[SerializeField] // RVA: 0x2851B0 Offset: 0x2852B1 VA: 0x2851B0
	[HideInInspector] // RVA: 0x2851B0 Offset: 0x2852B1 VA: 0x2851B0
	public bool m_isDistanceClipScaleFading; // 0x50
	[HideInInspector] // RVA: 0x2851F0 Offset: 0x2852F1 VA: 0x2851F0
	[SerializeField] // RVA: 0x2851F0 Offset: 0x2852F1 VA: 0x2851F0
	public Vector2 m_distanceClipScale; // 0x54
	[HideInInspector] // RVA: 0x285230 Offset: 0x285331 VA: 0x285230
	[SerializeField] // RVA: 0x285230 Offset: 0x285331 VA: 0x285230
	public bool m_isOverrideDownParams; // 0x5C
	[SerializeField] // RVA: 0x285270 Offset: 0x285371 VA: 0x285270
	[HideInInspector] // RVA: 0x285270 Offset: 0x285371 VA: 0x285270
	public float m_nearClipDistance; // 0x60
	[SerializeField] // RVA: 0x2852B0 Offset: 0x2853B1 VA: 0x2852B0
	[HideInInspector] // RVA: 0x2852B0 Offset: 0x2853B1 VA: 0x2852B0
	public float m_nearDownDistance; // 0x64
	[SerializeField] // RVA: 0x2852F0 Offset: 0x2853F1 VA: 0x2852F0
	[HideInInspector] // RVA: 0x2852F0 Offset: 0x2853F1 VA: 0x2852F0
	public float m_nearDownOffset; // 0x68
	[HideInInspector] // RVA: 0x285330 Offset: 0x285431 VA: 0x285330
	[SerializeField] // RVA: 0x285330 Offset: 0x285431 VA: 0x285330
	public float m_groundColorWindRatio; // 0x6C
	[SerializeField] // RVA: 0x285370 Offset: 0x285471 VA: 0x285370
	[HideInInspector] // RVA: 0x285370 Offset: 0x285471 VA: 0x285370
	public Color m_waveTintColor; // 0x70
	[SerializeField] // RVA: 0x2853B0 Offset: 0x2854B1 VA: 0x2853B0
	[HideInInspector] // RVA: 0x2853B0 Offset: 0x2854B1 VA: 0x2853B0
	public float m_waveSpeed; // 0x80
	[SerializeField] // RVA: 0x2853F0 Offset: 0x2854F1 VA: 0x2853F0
	[HideInInspector] // RVA: 0x2853F0 Offset: 0x2854F1 VA: 0x2853F0
	public float m_waveSize; // 0x84
	[SerializeField] // RVA: 0x285430 Offset: 0x285531 VA: 0x285430
	[HideInInspector] // RVA: 0x285430 Offset: 0x285531 VA: 0x285430
	public float m_waveBlending; // 0x88
	[SerializeField] // RVA: 0x285470 Offset: 0x285571 VA: 0x285470
	[HideInInspector] // RVA: 0x285470 Offset: 0x285571 VA: 0x285470
	public float m_grassBrightness; // 0x8C
	[HideInInspector] // RVA: 0x2854B0 Offset: 0x2855B1 VA: 0x2854B0
	[SerializeField] // RVA: 0x2854B0 Offset: 0x2855B1 VA: 0x2854B0
	public Color m_grassTintColor; // 0x90
	[HideInInspector] // RVA: 0x2854F0 Offset: 0x2855F1 VA: 0x2854F0
	[SerializeField] // RVA: 0x2854F0 Offset: 0x2855F1 VA: 0x2854F0
	public float m_groundColorCoefficient; // 0xA0
	[HideInInspector] // RVA: 0x285530 Offset: 0x285631 VA: 0x285530
	[SerializeField] // RVA: 0x285530 Offset: 0x285631 VA: 0x285530
	public float m_groundColorGradationScale; // 0xA4
	[SerializeField] // RVA: 0x285570 Offset: 0x285671 VA: 0x285570
	[HideInInspector] // RVA: 0x285570 Offset: 0x285671 VA: 0x285570
	public GrassManager.MixType m_groundColorMixType; // 0xA8
	[SerializeField] // RVA: 0x2855B0 Offset: 0x2856B1 VA: 0x2855B0
	[HideInInspector] // RVA: 0x2855B0 Offset: 0x2856B1 VA: 0x2855B0
	public float m_lightingMin; // 0xAC
	[HideInInspector] // RVA: 0x2855F0 Offset: 0x2856F1 VA: 0x2855F0
	public float m_interactionRadius; // 0xB0
	[HideInInspector] // RVA: 0x285600 Offset: 0x285701 VA: 0x285600
	public int m_interactionAngle; // 0xB4
	[HideInInspector] // RVA: 0x285610 Offset: 0x285711 VA: 0x285610
	public float m_interactionHeightCorrection; // 0xB8
	private int m_interactionCenterPropertyId; // 0xBC
	private const string kGroundUVFromMeshKeyword = "_KEY_GROUND_UV_FROM_MESH";
	private const string kLightmapKeyword = "_KEY_GROUND_LIGHTMAP";

	// Properties
	public int ReferenceTransformNum { get; }
	public GrassData GrassData { get; set; }
	public virtual bool HasTerrain { get; }

	// Methods

	// RVA: 0x27BE850 Offset: 0x27BE951 VA: 0x27BE850
	public int get_ReferenceTransformNum() { }

	// RVA: 0x27BE8B0 Offset: 0x27BE9B1 VA: 0x27BE8B0
	public void set_GrassData(GrassData value) { }

	// RVA: 0x27BE8C0 Offset: 0x27BE9C1 VA: 0x27BE8C0
	public GrassData get_GrassData() { }

	// RVA: 0x27BE8D0 Offset: 0x27BE9D1 VA: 0x27BE8D0 Slot: 4
	public virtual bool get_HasTerrain() { }

	// RVA: 0x27BE8E0 Offset: 0x27BE9E1 VA: 0x27BE8E0
	private void Awake() { }

	// RVA: 0x27BEAC0 Offset: 0x27BEBC1 VA: 0x27BEAC0
	private void OnEnable() { }

	// RVA: 0x27BEAD0 Offset: 0x27BEBD1 VA: 0x27BEAD0
	public Material GetMaterial(int index) { }

	// RVA: 0x27BEB70 Offset: 0x27BEC71 VA: 0x27BEB70
	public Texture2D GetTexture(int index) { }

	// RVA: 0x27BEC10 Offset: 0x27BED11 VA: 0x27BEC10
	public void SetInteractionCenter(Vector3 position) { }

	// RVA: 0x27BE8F0 Offset: 0x27BE9F1 VA: 0x27BE8F0
	public void Setup() { }

	// RVA: 0x27BF670 Offset: 0x27BF771 VA: 0x27BF670
	private static Texture2D GetAtlasTexture(SpriteAtlas atlas) { }

	// RVA: 0x27BEEA0 Offset: 0x27BEFA1 VA: 0x27BEEA0
	public void SetupMaterial() { }

	// RVA: 0x27BF4F0 Offset: 0x27BF5F1 VA: 0x27BF4F0
	public void UpdateMaterialParameter() { }

	// RVA: 0x27BF770 Offset: 0x27BF871 VA: 0x27BF770
	protected void UpdateMaterialParameter(int meshIndex) { }

	// RVA: 0x27BFF80 Offset: 0x27C0081 VA: 0x27BFF80
	public void UpdateLightmap() { }

	// RVA: 0x27C00E0 Offset: 0x27C01E1 VA: 0x27C00E0
	protected void UpdateLightmap(int meshIndex) { }

	// RVA: 0x27BF5D0 Offset: 0x27BF6D1 VA: 0x27BF5D0
	private void SetMaterialToChildrenAll() { }

	// RVA: 0x27C0340 Offset: 0x27C0441 VA: 0x27C0340
	private void SetMaterialToChildren(Transform parent, int meshIndex) { }

	// RVA: 0x27C04A0 Offset: 0x27C05A1 VA: 0x27C04A0
	public void SetNotEditableToChildren() { }

	// RVA: 0x27C0660 Offset: 0x27C0761 VA: 0x27C0660
	public void SetEditableToChildren() { }

	// RVA: 0x27C0010 Offset: 0x27C0111 VA: 0x27C0010
	protected void SetGrassMaterialKeyword(int materialIndex, string keyword, bool enabled) { }

	// RVA: 0x27C0850 Offset: 0x27C0951 VA: 0x27C0850 Slot: 5
	protected virtual Transform FindGrassMeshParentTransform(Transform parent, int meshIndex) { }

	// RVA: 0x27BEDB0 Offset: 0x27BEEB1 VA: 0x27BEDB0
	protected void InitRefrenceTransform() { }

	// RVA: 0x27C0860 Offset: 0x27C0961 VA: 0x27C0860 Slot: 6
	protected virtual int CalcReferenceTransformNum() { }

	// RVA: 0x27C0870 Offset: 0x27C0971 VA: 0x27C0870 Slot: 7
	public virtual ValueTuple<Transform, int> FindGroundTransform(int meshIndex) { }

	// RVA: 0x27C0920 Offset: 0x27C0A21 VA: 0x27C0920
	public int FindGroundTransformIndex(Transform searchTargetTransform) { }

	// RVA: 0x27C0A30 Offset: 0x27C0B31 VA: 0x27C0A30 Slot: 8
	public virtual bool GetFieldSizeOffset(out Vector3 size, out Vector3 offset) { }

	// RVA: 0x27C0B90 Offset: 0x27C0C91 VA: 0x27C0B90 Slot: 9
	public virtual bool GetLightmapData(int meshIndex, out int index, out Vector4 scaleOffset) { }

	// RVA: 0x27C0D50 Offset: 0x27C0E51 VA: 0x27C0D50 Slot: 10
	protected virtual Texture2D FindGroundTexture(int meshIndex) { }

	// RVA: 0x27C0EF0 Offset: 0x27C0FF1 VA: 0x27C0EF0
	protected void .ctor() { }
}

